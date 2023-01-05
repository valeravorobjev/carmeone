using Carmeone.Db;
using Carmeone.Db.Entities.Base;
using Carmeone.Repositories;
using Carmeone.Repositories.Contracts;
using Carmeone.Repositories.Models;
using Microsoft.Extensions.Configuration;

namespace Carmeone.Tests;

public class AccountRepositoryTests
{
    private readonly IAccountRepository _accountRepository;

    public AccountRepositoryTests()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddUserSecrets<AccountRepositoryTests>(optional: true, reloadOnChange: false)
            .Build();

        CSmtpSettings? smtpSettings = config.GetSection("MailSender").Get<CSmtpSettings>();

        if (smtpSettings == null)
            throw new Exception("Can't get CSmtpSettings from user secrets");

        _accountRepository = new AccountRepository(new CContext(), smtpSettings);
    }
    

    [Fact]
    public async Task RegistrationTest()
    {
        CRegistration registration = new CRegistration
        {
            AccountRole = AccountRole.Individual,
            Email = "vopre@mail.ru",
            Password = "12345",
            ConfirmPassword = "12345"
        };
        CResult<string> result = await _accountRepository.RegistrationAsync(registration);
        
        Assert.NotNull(result);
        Assert.NotNull(result.StatusResult);
        Assert.NotEmpty(result.StatusResult.Status);
        Assert.True(result.StatusResult.Status == CCodes.Ok);
        
        Assert.NotNull(result.Data);
        Assert.NotEmpty(result.Data);

        var ok = Guid.TryParse(result.Data, out _);
        
        Assert.True(ok);
    }
}