using Microsoft.AspNetCore.Identity;
using SonOfCod.Models;
using SonOfCod.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class AccountControllerTest
    {
        [Fact]
        public void Get_UserList_AccountIndex_Test()
        {
            //Arrange            
            ViewResult indexView = new AccountController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<ApplicationUser>>(result);
        }
    }
}
