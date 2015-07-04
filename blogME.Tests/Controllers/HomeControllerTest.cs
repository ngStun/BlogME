using BlogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace BlogME.Tests.Controllers
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
