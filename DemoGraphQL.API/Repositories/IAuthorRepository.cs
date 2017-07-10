using DemoGraphQL.API.Models;
using System.Threading.Tasks;

namespace DemoGraphQL.API.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> GetFromId(int id);
    }
}
