using Carmeone.Db;
using Carmeone.Repositories.Contracts;
using Carmeone.Repositories.Models;

namespace Carmeone.Repositories;

public class AccountRepository: IAccountRepository
{
    private CarmeoneContext _context;
    
    public AccountRepository(CarmeoneContext context)
    {
        _context = context;
    }
    
    public ValueTask<bool> RegistrationAsync(DtoRegistration dtoRegistration)
    {
        throw new NotImplementedException();
    }
}