using SimpleBlog.ViewModels;
using System.Web.Mvc;
// <copyright file="AuthControllerTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBlog.Controllers;

namespace SimpleBlog.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(AuthController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AuthControllerTest
    {

        [PexMethod]
        public ActionResult Login([PexAssumeUnderTest]AuthController target, AuthLogin form)
        {
            ActionResult result = target.Login(form);
            return result;
            // TODO: add assertions to method AuthControllerTest.Login(AuthController, AuthLogin)
        }
    }
}
