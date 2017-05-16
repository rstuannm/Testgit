using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTLibrary.MTInterface;

namespace MTWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _userRepository;

        public UserController(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: User
        public ActionResult Index()
        {
            var model = _userRepository.GetList();
            return View(model);
        }
    }
}