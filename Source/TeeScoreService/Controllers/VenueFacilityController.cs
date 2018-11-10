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
    public class VenueFacilityController : TableController<VenueFacilities>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<VenueFacilities>(context, Request);
        }

        // GET tables/VenueFacility
        public IQueryable<VenueFacilities> GetAllVenueFacility()
        {
            return Query(); 
        }

        // GET tables/VenueFacility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<VenueFacilities> GetVenueFacility(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/VenueFacility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<VenueFacilities> PatchVenueFacility(string id, Delta<VenueFacilities> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/VenueFacility
        public async Task<IHttpActionResult> PostVenueFacility(VenueFacilities item)
        {
            VenueFacilities current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/VenueFacility/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteVenueFacility(string id)
        {
             return DeleteAsync(id);
        }
    }
}
