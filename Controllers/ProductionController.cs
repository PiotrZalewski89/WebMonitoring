using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class ProductionController : ControllerBase
    {

       [Route("api/weeklyproduction")]
       [HttpGet]             
       public WeeklyProduction GetProduction(string line)
        {          
            WeeklyProduction production = new WeeklyProduction();

            return production.Production(line);
        }
    }
}
