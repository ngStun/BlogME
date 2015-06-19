using System.Web.Mvc;
using blogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace blogME.Tests.Controllers
{
    [TestClass]
    public class AboutControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new AboutController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
