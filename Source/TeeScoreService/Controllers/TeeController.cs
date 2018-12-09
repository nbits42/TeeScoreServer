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
    public class TeeController : TableController<Tee>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<Tee>(context, Request);
        }

        // GET tables/Tee
        public IQueryable<Tee> GetAllTees()
        {
            return Query(); 
        }

        // GET tables/Tee/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Tee> GetTee(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Tee/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Tee> PatchTee(string id, Delta<Tee> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Tee
        public async Task<IHttpActionResult> PostTee(Tee item)
        {
            Tee current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Tee/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTee(string id)
        {
             return DeleteAsync(id);
        }
    }
}
