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
    public class VenueController : TableController<Venue>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<Venue>(context, Request);
        }

        // GET tables/Venue
        public IQueryable<Venue> GetAllVenue()
        {
            return Query(); 
        }

        // GET tables/Venue/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Venue> GetVenue(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Venue/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Venue> PatchVenue(string id, Delta<Venue> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Venue
        public async Task<IHttpActionResult> PostVenue(Venue item)
        {
            Venue current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Venue/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteVenue(string id)
        {
             return DeleteAsync(id);
        }
    }
}
