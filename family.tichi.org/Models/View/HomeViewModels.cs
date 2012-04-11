using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace family.tichi.org.Models.View
{
    /**
     * \author Katharine Gillis
     * \date   4/11/2012
     * 
     * View model for the HomeController SignIn action
     */
    public class HomeSignInViewModel
    {
        [Required(ErrorMessageResourceType = typeof(ModelRes.HomeValidationStrings), ErrorMessageResourceName = "Required")]
        [Display(Name = "SignInEmail", ResourceType = typeof(ModelRes.HomeNameStrings))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(ModelRes.HomeValidationStrings), ErrorMessageResourceName = "Required")]
        [Display(Name = "SignInPassword", ResourceType = typeof(ModelRes.HomeNameStrings))]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}