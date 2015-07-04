using BlogME.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace BlogME.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void AccountControllerShouldRenderDefaultView()
        {
            var sut = new HomeController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}
