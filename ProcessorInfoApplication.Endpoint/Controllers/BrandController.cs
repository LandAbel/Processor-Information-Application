using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;
using ProcessorInfoApplication.Endpoint.Services;

namespace ProcessorInfoApplication.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandLogic brandlog;
        IHubContext<SignalRHub> hub;

        public BrandController(IBrandLogic brandlog, IHubContext<SignalRHub> hub)
        {
            this.brandlog = brandlog;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<Brand> ReadAll()
        {
            return this.brandlog.ReadAll();
        }
        [HttpGet("{id}")]
        public Brand Read(int id)
        {
            return this.brandlog.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Brand c)
        {
            this.brandlog.Create(c);
            this.hub.Clients.All.SendAsync("BrandCreated", c);
        }

        [HttpPut]
        public void Update([FromBody] Brand c)
        {
            this.brandlog.Update(c);
            this.hub.Clients.All.SendAsync("BrandUpdated", c);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var brandToDelete = (Brand)this.brandlog.Read(id);
            this.brandlog.Delete(id);
            this.hub.Clients.All.SendAsync("BrandDeleted", brandToDelete);
        }
    }
}
