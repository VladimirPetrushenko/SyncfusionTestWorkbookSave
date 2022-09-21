using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestRoundedValues.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            SyncfusionWorker.Open();
            SyncfusionWorker.Save();

            return new string[] { "value1", "value2" };
        }
    }
}
