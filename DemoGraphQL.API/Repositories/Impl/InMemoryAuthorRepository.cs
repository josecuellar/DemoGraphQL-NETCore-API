using DemoGraphQL.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.API.Repositories.Impl
{
    public class InMemoryAuthorRepository : IAuthorRepository
    {
        private IList<Author> _authors = new List<Author> {
            new Author { Id = 1, Name = "Flora", Surname = "Davis" }
        };

        public Task<Author> GetFromId(int id)
        {
            return Task.FromResult(_authors.ToList().FirstOrDefault(author => author.Id == id));
        }
    }
}
