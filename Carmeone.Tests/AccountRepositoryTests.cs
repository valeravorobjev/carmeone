using Carmeone.Db;
using Carmeone.Db.Entities.Base;
using Carmeone.Services;
using Carmeone.Services.Contracts;
using Carmeone.Services.Models;
using Microsoft.Extensions.Configuration;

namespace Carmeone.Tests;

public class AccountRepositoryTests
{
    private readonly IAuthService _accountRepository;

    public AccountRepositoryTests()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddUserSecrets<AccountRepositoryTests>(optional: true, reloadOnChange: false)
            .Build();

        SmtpSettings? smtpSettings = config.GetSection("MailSender").Get<SmtpSettings>();

        if (smtpSettings == null)
            throw new Exception("Can't get CSmtpSettings from user secrets");

        _accountRepository = new AccountRepository(new CarmeoneContext(), smtpSettings);
    }
    

    [Fact]
    public async Task RegistrationTest()
    {
        Registration registration = new Registration
        {
            AccountRole = AccountRole.User,
            Email = "vopre@mail.ru",
            Password = "12345",
            ConfirmPassword = "12345"
        };
        CarmeoneResult<string> result = await _accountRepository.RegAsync(registration);
        
        Assert.NotNull(result);
        Assert.NotNull(result.StatusResult);
        Assert.True(result.StatusResult.StatusCode == StatusCode.Ok);
        
        Assert.NotNull(result.Data);
        Assert.NotEmpty(result.Data);

        var ok = Guid.TryParse(result.Data, out _);
        
        Assert.True(ok);
    }
}