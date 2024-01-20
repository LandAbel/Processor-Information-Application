using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;
using ProcessorInfoApplication.Endpoint.Services;

namespace ProcessorInfoApplication.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProcessorController : ControllerBase
    {
        IProcessorLogic prolog;
        IHubContext<SignalRHub> hub;

        public ProcessorController(IProcessorLogic prolog, IHubContext<SignalRHub> hub)
        {
            this.prolog = prolog;
            this.hub = hub;
        }

        [HttpGet]
        public IEnumerable<Processor> ReadAll()
        {
            return this.prolog.ReadAll();
        }
        [HttpGet("{id}")]
        public Processor Read(int id)
        {
            return this.prolog.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Processor c)
        {
            this.prolog.Create(c);
            this.hub.Clients.All.SendAsync("ProcessorCreated", c);
        }

        [HttpPut]
        public void Update([FromBody] Processor c)
        {
            this.prolog.Update(c);
            this.hub.Clients.All.SendAsync("ProcessorUpdated", c);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var processorToDelete = (Processor)this.prolog.Read(id);
            this.prolog.Delete(id);
            this.hub.Clients.All.SendAsync("ProcessorDeleted", processorToDelete);
        }

    }
}
