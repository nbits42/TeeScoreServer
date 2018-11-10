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
    public class GamePlayerController : TableController<GamePlayer>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TeeScoreContext context = new TeeScoreContext();
            DomainManager = new EntityDomainManager<GamePlayer>(context, Request);
        }

        // GET tables/GamePlayer
        public IQueryable<GamePlayer> GetAllGamePlayer()
        {
            return Query(); 
        }

        // GET tables/GamePlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<GamePlayer> GetGamePlayer(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/GamePlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<GamePlayer> PatchGamePlayer(string id, Delta<GamePlayer> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/GamePlayer
        public async Task<IHttpActionResult> PostGamePlayer(GamePlayer item)
        {
            GamePlayer current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/GamePlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteGamePlayer(string id)
        {
             return DeleteAsync(id);
        }
    }
}
