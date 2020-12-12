using fiefapp.graphql.DTOs;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace fiefapp.api.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;

        public GraphQLController(ISchema schema, IDocumentExecuter executer)
        {
            _schema = schema;
            _executer = executer;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQueryDTO query)
        {
            var result = await _executer.ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
                Problem(detail: result.Errors.Select(_ => _.Message)
                                             .FirstOrDefault(),
                                             statusCode: 500);

            return Ok(result.Data);
        }
    }
}
