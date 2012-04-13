using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using family.tichi.org.Models.View;
using family.tichi.org.Services;

namespace family.tichi.org.Controllers
{
    /**
     * \author Katharine Gillis
     * \date   4/12/2012
     * 
     * Actions available to the Home controller.
     */
    public class HomeController : Controller
    {
        public IAuthenticationService AuthenticationService { get; private set; }
        public IUserService UserService { get; private set; }

        /**
         * Create the Home controller with the default services.
         */
        public HomeController() : this(null, null) { }

        /**
         * Create the Home controller with the given services.
         * 
         * \param authService The authentication service.
         * \param userService The user service.
         */
        public HomeController(IAuthenticationService authService, IUserService userService)
        {
            this.AuthenticationService = authService;
            this.UserService = userService;
        }

        /**
         * Index page.
         * 
         * GET: /Home/
         */
        public ActionResult Index()
        {
            return View();
        }

        /**
         * Index page (login form submission).
         * 
         * POST: /Home/
         */
        public ActionResult Index(HomeSignInViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
