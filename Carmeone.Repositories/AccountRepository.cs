using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using Carmeone.Db;
using Carmeone.Db.Entities;
using Carmeone.Repositories.Common;
using Carmeone.Repositories.Contracts;
using Carmeone.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Repositories;

public class AccountRepository: IAccountRepository
{
    private readonly CContext _context;
    private readonly CSmtpSettings _smtpSettings;
    
    public AccountRepository(CContext context, CSmtpSettings smtpSettings)
    {
        _context = context;
        _smtpSettings = smtpSettings;

        if (_context is null)
            throw new Exception("Context is null.");
        
        if (_smtpSettings is null)
            throw new Exception("SmtpSettings is null.");
        
        
    }
    
    public async ValueTask<CResult<string>> RegistrationAsync(CRegistration registration)
    {
        CValidation validation = registration.Validate();

        if (!validation.IsValid)
            return new CResult<string>
            {
                Data = null,
                StatusResult = new CStatusResult
                {
                    Message = validation.ToString(),
                    Status = CCodes.ModelInvalid,
                    Validation = validation
                }
            };

        int countResult = await _context.Accounts!.CountAsync(a => a.Email == registration.Email);

        if (countResult > 0)
            return new CResult<string>
            {
                StatusResult = new CStatusResult
                {
                    Status = CCodes.UserAllreadyExists,
                    Message = $"User with email {registration.Email} allready exists"
                }
            };

        int salt = Random.Shared.Next(10000000, 99999999);
        var passtring = registration.Password + salt;

        var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(passtring));
        StringBuilder sbHash = new StringBuilder(); ;
        foreach (byte hashByte in hashBytes)
        {
            sbHash.Append(hashByte.ToString("x2"));
        }

        string hash = sbHash.ToString();
        string activationCode = Guid.NewGuid().ToString();

        Account account = new Account
        {
            AccountRole = registration.AccountRole,
            ActivateCode = activationCode,
            Email = registration.Email,
            IsActive = false,
            Password = hash,
            Salt = salt
        };

        try
        {
            var smtpClient = new SmtpClient("smtp.mail.ru")
            {
                Port = 465,
                Credentials = new NetworkCredential(_smtpSettings.Login, _smtpSettings.Password),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpSettings.Login),
                Subject = "Регистрация Carmeone",
                Body = @$"
<h1>Регистрация</h1>
<p>Здравствуйте, спасибо за регистрацию на сервисе Carmeone!</p>
<p>Для завершения регистрации, пожалуйста, перейдите по следущей ссылке: 
http://carmeone.ru/registration/confirm/{activationCode}</p>
",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(registration.Email);

            smtpClient.Send(mailMessage);
        }
        catch (Exception e)
        {
            //TODO: Добавить запись в лог
            return new CResult<string>
            {
                StatusResult = new CStatusResult
                {
                    Status = CCodes.InternalServerError,
                    Message = "Internal server error."
                }
            };
        }

        _context.Add(account);
        await _context.SaveChangesAsync();

        return new CResult<string>
        {
            Data = account.AccountId.ToString(),
            StatusResult = new CStatusResult
            {
                Status = CCodes.Ok
            }
        };

    }
}