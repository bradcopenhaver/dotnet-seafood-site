using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class SubscriberTest
    {
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var subscriber = new Subscriber();
            subscriber.Email = "foo@bar.com";

            //Act
            var result = subscriber.Email;

            //Assert
            Assert.Equal("foo@bar.com", result);
        }
    }
}
