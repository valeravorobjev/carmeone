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
    private readonly CarmeoneContext _context;
    
    public AccountRepository(CarmeoneContext context)
    {
        _context = context;

        if (_context is null)
            throw new Exception("Context is null.");
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
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("username", "password"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("email"),
                Subject = "subject",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("recipient");

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