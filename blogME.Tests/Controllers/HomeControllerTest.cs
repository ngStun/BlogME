using blogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace blogME.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeControllerShouldRenderDefaultView()
        {
            var sut = new HomeController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}
