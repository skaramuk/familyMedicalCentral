using FMC.Entity.Model;
using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FMC.Controllers
{
    public class UserController : ApiController
    {
        private UserService userService = new UserService();

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }


        [HttpPost]
        public IHttpActionResult Create(User user)
        {
            return Ok(userService.Create(user));
        }
    }
}
