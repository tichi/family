using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using family.tichi.org.Models.View;

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
