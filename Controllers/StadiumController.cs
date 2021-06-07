using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : FootballBaseController
    {
        //private readonly IStadiumService _stadiumService;

        public StadiumController(
            ILogger<StadiumController> logger
            //, IStadiumService stadiumService
            ) : base(logger)
        {
            //_stadiumService = stadiumService;
        }
    }
}
