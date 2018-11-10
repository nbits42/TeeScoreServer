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
    public class FacilityController : TableController<Facility>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<Facility>(context, Request);
        }

        // GET tables/Facility
        public IQueryable<Facility> GetAllFacility()
        {
            return Query(); 
        }

        // GET tables/Facility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Facility> GetFacility(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Facility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Facility> PatchFacility(string id, Delta<Facility> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Facility
        public async Task<IHttpActionResult> PostFacility(Facility item)
        {
            Facility current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Facility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFacility(string id)
        {
             return DeleteAsync(id);
        }
    }
}
