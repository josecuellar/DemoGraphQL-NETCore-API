using DemoGraphQL.API.Models.Types;
using DemoGraphQL.API.Repositories;
using GraphQL.Types;

namespace DemoGraphQL.API.Models.Queries
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(IAuthorRepository repository)
        {
            Field<AuthorType>(
              "author",
              resolve: context => repository.GetFromId(1)
            );
        }
    }
}
