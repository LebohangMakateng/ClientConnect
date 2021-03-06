using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
         IUserRepository UserRepository {get;}
         IGigRepository GigRepository {get;}
         Task<bool> Complete();
    }
}