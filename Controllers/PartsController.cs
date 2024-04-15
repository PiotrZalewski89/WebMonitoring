using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    [Route("api/Parts")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        [HttpPost]
        public IActionResult TotalPartsForm([FromBody] LineParametersWS lineParameters)
        {
            string urlAction = lineParameters.Url.ReturnAction;
            string urlControler = lineParameters.Url.ReturnController;
            return RedirectToAction(urlAction, urlControler, lineParameters);
        }
    }
}
