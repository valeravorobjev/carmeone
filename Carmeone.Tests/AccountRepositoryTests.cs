using Carmeone.Db;
using Carmeone.Repositories;
using Carmeone.Repositories.Contracts;
using Carmeone.Repositories.Models;

namespace Carmeone.Tests;

public class AccountRepositoryTests
{
    private readonly IAccountRepository _accountRepository;

    public AccountRepositoryTests()
    {
        _accountRepository = new AccountRepository(new CContext(), new CSmtpSettings());
    }
    

    [Fact]
    public void RegistrationTest()
    {
        
    }
}