using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace SonOfCod.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController(_userManager, _db);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
