using System.Web.Mvc;
using blogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace blogME.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
