using DemoGraphQL.API.Models.Queries;
using DemoGraphQL.API.Repositories.Impl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoGraphQL.API.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {

        private AuthorQuery _authorQuery { get; set; }

        public GraphQLController(AuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = _authorQuery };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
