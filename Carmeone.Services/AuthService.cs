using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using Carmeone.Db;
using Carmeone.Db.Entities;
using Carmeone.Services.Common;
using Carmeone.Services.Contracts;
using Carmeone.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Services;

public class AuthService : IAuthService
{
    private readonly CarmeoneContext _context;
    private readonly SmtpSettings _smtpSettings;

    public AuthService(CarmeoneContext context, SmtpSettings smtpSettings)
    {
        _context = context;
        _smtpSettings = smtpSettings;

        if (_context is null)
            throw new Exception("Context is null.");

        if (_smtpSettings is null)
            throw new Exception("SmtpSettings is null.");
    }

    public async ValueTask<CarmeoneResult<string>> RegAsync(Registration registration)
    {
        Validation validation = registration.Validate();

        if (!validation.IsValid)
            return new CarmeoneResult<string>
            {
                Data = null,
                StatusResult = new StatusResult
                {
                    Message = validation.ToString(),
                    StatusCode = StatusCode.ModelInvalid,
                    Validation = validation
                }
            };

        int countResult = await _context.Accounts!.CountAsync(a => a.Email == registration.Email);

        if (countResult > 0)
            return new CarmeoneResult<string>
            {
                StatusResult = new StatusResult
                {
                    StatusCode = StatusCode.UserAllreadyExists,
                    Message = $"User with email {registration.Email} allready exists"
                }
            };

        int salt = Random.Shared.Next(10000000, 99999999);

        string hash = Helpers.PassGen(registration.Password, salt);
        Guid activationCode = Guid.NewGuid();

        Account account = new Account
        {
            AccountRole = registration.AccountRole,
            ActivationCode = activationCode,
            Email = registration.Email,
            IsActive = false,
            Password = hash,
            Salt = salt
        };

        _context.Add(account);
        await _context.SaveChangesAsync();

        try
        {
            var smtpClient = new SmtpClient("smtp.mail.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential(_smtpSettings.Login, _smtpSettings.Password),
                Timeout = 10 * 1000,
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
http://carmeone.ru/registration/confirm/{account.AccountId}/{activationCode}</p>
",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(registration.Email);

            smtpClient.Send(mailMessage);
        }
        catch (Exception e)
        {
            return new CarmeoneResult<string>
            {
                StatusResult = new StatusResult
                {
                    StatusCode = StatusCode.InternalError,
                    Message = "Internal server error."
                }
            };
        }

        return new CarmeoneResult<string>
        {
            Data = account.AccountId.ToString(),
            StatusResult = new StatusResult
            {
                StatusCode = StatusCode.Ok
            }
        };
    }

    public async ValueTask<CarmeoneResult<bool>> RegConfirmAsync(RegistrationConfirm registrationConfirm)
    {
        Validation validation = registrationConfirm.Validate();

        if (!validation.IsValid)
            return new CarmeoneResult<bool>
            {
                Data = false,
                StatusResult = new StatusResult
                {
                    Message = validation.ToString(),
                    StatusCode = StatusCode.ModelInvalid,
                    Validation = validation
                }
            };

        var account = await _context.Accounts!.FirstOrDefaultAsync(a =>
            a.AccountId == registrationConfirm.AccountId &&
            a.ActivationCode == registrationConfirm.ActivationCode);

        if (account is null)
        {
            return new CarmeoneResult<bool>
            {
                Data = false,
                StatusResult = new StatusResult
                {
                    StatusCode = StatusCode.NotFound,
                    Message = $"Account with id {registrationConfirm.AccountId} doesn't exists"
                }
            };
        }

        account.IsActive = true;
        await _context.SaveChangesAsync();
        
        return new CarmeoneResult<bool>
        {
            Data = true,
            StatusResult = new StatusResult
            {
                StatusCode = StatusCode.Ok
            }
        };
    }

    public async ValueTask<CarmeoneResult<bool>> LoginAsync(Login login)
    {
        var account = await _context.Accounts!.AsNoTracking().FirstOrDefaultAsync(a => a.Email == login.Email);

        if (account == null)
            return new CarmeoneResult<bool>
            {
                Data = false,
                StatusResult = new StatusResult
                {
                    StatusCode = StatusCode.LoginOrPasswordIncorrect,
                    Message = "Login or password is incorrect."
                }
            };

        string password = Helpers.PassGen(login.Password, account.Salt);
        
        if (password != account.Password)
            return new CarmeoneResult<bool>
            {
                Data = false,
                StatusResult = new StatusResult
                {
                    StatusCode = StatusCode.LoginOrPasswordIncorrect,
                    Message = "Login or password is incorrect."
                }
            };

        return new CarmeoneResult<bool>
        {
            Data = true,
            StatusResult = new StatusResult
            {
                StatusCode = StatusCode.Ok
            }
        };
    }
}