using Microsoft.AspNetCore.Mvc;
using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;

namespace ProcessorInfoApplication.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        IProcessorLogic prolog;
        public StatisticsController(IProcessorLogic prolog)
        {
            this.prolog = prolog;
        }
        [HttpGet]
        public IEnumerable<Processor> z790ProcessorsWith10Core()
        {
            return this.prolog.z790ProcessorsWith10Core();
        }
        [HttpGet]
        public IEnumerable<Processor> INTELProcessorsWithMorethan30mbCache()
        {
            return this.prolog.INTELProcessorsWithMorethan30mbCache();
        }
        [HttpGet]
        public IEnumerable<Processor> INTELProcessorsWithIntegratedGraph()
        {
            return this.prolog.INTELProcessorsWithIntegratedGraph();
        }
        [HttpGet]
        public IEnumerable<Processor> MaxTurboFreqMoreThen49ProcessorFromAMD()
        {
            return this.prolog.MaxTurboFreqMoreThen49ProcessorFromAMD();
        }
        [HttpGet]
        public IEnumerable<Processor> MobileProcessorsWithMoreThan6Core()
        {
            return this.prolog.MobileProcessorsWithMoreThan6Core();
        }
        [HttpGet]
        public IEnumerable<Processor> IntelProcessorsWithMoreTh30Threads()
        {
            return this.prolog.IntelProcessorsWithMoreTh30Threads();
        }
        [HttpGet]
        public IEnumerable<Processor.ProcessorInfo> ProcessorsByBrands()
        {
            return this.prolog.ProcessorsByBrands();
        }

    }
}
