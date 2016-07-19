using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicAuth.API.Requests.Query.AccountLevel;
using BasicAuth.API.Requests;
using BasicAuth.DTO.ViewModels.AccountLevels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAuth.API.Controllers
{
    [Route("api/[controller]")]
    public class LevelsController : Controller
    {
        IQueryHandler<GetAccountLevelsQuery, AccountLevelListDTO> _getLevelsHandler;
        IQueryHandler<GetAccountLevelQuery, SingleAccountLevelDTO> _getLevelHandler;

        public LevelsController(
            IQueryHandler<GetAccountLevelsQuery, AccountLevelListDTO> getLevelsHandler,
            IQueryHandler<GetAccountLevelQuery, SingleAccountLevelDTO> getLevelHandler)
        {
            _getLevelHandler = getLevelHandler;
            _getLevelsHandler = getLevelsHandler;
        }

        [HttpGet]
        public IActionResult Get(GetAccountLevelsQuery query)
        {
            return Ok(_getLevelsHandler.Execute(query));
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(GetAccountLevelQuery query)
        {
            return Ok(_getLevelHandler.Execute(query));
        }
    }
}
