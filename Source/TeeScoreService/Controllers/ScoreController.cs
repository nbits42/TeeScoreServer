using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using TeeScoreService.DataObjects;
using TeeScoreService.Models;

namespace TeeScoreService.Controllers
{
    public class ScoreController : TableController<Score>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<Score>(context, Request);
        }

        // GET tables/Score
        public IQueryable<Score> GetAllScore()
        {
            return Query(); 
        }

        // GET tables/Score/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Score> GetScore(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Score/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Score> PatchScore(string id, Delta<Score> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Score
        public async Task<IHttpActionResult> PostScore(Score item)
        {
            Score current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Score/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteScore(string id)
        {
             return DeleteAsync(id);
        }
    }
}
