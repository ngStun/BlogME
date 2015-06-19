using blogME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace blogME.Tests.Controllers
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
