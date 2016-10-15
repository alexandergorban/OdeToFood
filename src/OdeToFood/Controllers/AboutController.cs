using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //[Route("about")]
    //[Route("[controller]")]
    //[Route("company/[controller]/[action]")]
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("phone")]
        //[Route("[action]")]
        public string Phone()
        {
            return "1+333-555-7777";
        }

        //[Route("address")]
        //[Route("[action]")]
        public string Address()
        {
            return "USA";
        }
    }
}
