using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicAuth.API.Requests.Query.User;
using BasicAuth.API.Requests;
using BasicAuth.DTO.ViewModels.Users;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAuth.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        IQueryHandler<GetUserQuery, SingleUserDTO> _getUserHandler;
        IQueryHandler<GetUsersQuery, UserListDTO> _getUsersHandler;

        public UsersController(
            IQueryHandler<GetUserQuery, SingleUserDTO> getUserHandler,
            IQueryHandler<GetUsersQuery, UserListDTO> getUsersHandler)
        {
            _getUserHandler = getUserHandler;
            _getUsersHandler = getUsersHandler;
        }

        [HttpGet]
        public IActionResult Get(GetUsersQuery query)
        {
            return Ok(_getUsersHandler.Execute(query));
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(GetUserQuery query)
        {
            return Ok(_getUserHandler.Execute(query));
        }
    }
}
