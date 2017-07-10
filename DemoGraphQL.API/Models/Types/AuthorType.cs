using GraphQL.Types;

namespace DemoGraphQL.API.Models.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id).Description("The Id of the author.");
            Field(x => x.Name, nullable: true).Description("The name of the author.");
            Field(x => x.Surname).Description("The surname of the author.");
        }
    }
}


