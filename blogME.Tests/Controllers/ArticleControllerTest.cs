using BlogME.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace BlogME.Tests.Controllers
{
    [TestClass]
    public class ArticleControllerTest
    {
        [TestMethod]
        public void ArticleControllerShouldRenderDefaultView()
        {
            var sut = new ArticleController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}
