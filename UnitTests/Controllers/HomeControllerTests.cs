using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using NUnit.Framework;

using family.tichi.org.Controllers;
using family.tichi.org.Models.View;

namespace UnitTests
{
    /**
     * \author Katharine Gillis
     * \date   4/12/2012
     * 
     * Unit tests for the HomeController class.
     */
    public class HomeControllerTests
    {
        /**
         * Defines the unit test that runs the Index method, expecting the Index view to be returned.
         */
        [Test]
        public void Index_Get_ReturnsIndexView()
        {
            // Arrange
            HomeController testSubject = new HomeController();

            // Act
            ActionResult result = testSubject.Index();

            // Assert
            Assert.That(result, Is.InstanceOf(typeof(ViewResult)));

            ViewResult viewResult = result as ViewResult;
            Assert.That(viewResult.ViewName, Is.EqualTo("Index"));
        }

        /**
         * Defines the unit test that runs the Index method with an invalid model, expecting the Index view to be returned with errors.
         */
        [Test]
        public void Index_PostWithInvalidModelState_ReturnsIndexViewWithModelErrors()
        {
            // Arrange
            HomeController testSubject = new HomeController();
            testSubject.ModelState.Clear();
            testSubject.ModelState.AddModelError("Email", "Email is required.");
            
            // Act
            ActionResult result = testSubject.Index(new HomeSignInViewModel());

            // Assert
            Assert.That(result, Is.InstanceOf(typeof(ViewResult)));

            ViewResult viewResult = result as ViewResult;
            Assert.That(viewResult.ViewName, Is.EqualTo("Index"));
            Assert.That(viewResult.ViewData.ModelState.IsValid, Is.False);
        }

        [Test]
        public void Index_PostWithInvalidEmailValidPassword_ReturnsIndexViewWithModelErrors()
        {
        }
    }
}
