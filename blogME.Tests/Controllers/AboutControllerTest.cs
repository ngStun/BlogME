using BlogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace BlogME.Tests.Controllers
{
    [TestClass]
    public class AboutControllerTest
    {
        [TestMethod]
        public void AboutControllerShouldRenderDefaultView()
        {
            var sut = new AboutController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}
