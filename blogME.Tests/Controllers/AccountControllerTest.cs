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
            var sut = new AccountController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void DashboardActionShouldRenderDashboardView()
        {
            var sut = new AccountController();
            sut.WithCallTo(x => x.Dashboard()).ShouldRenderView("Dashboard");
        }

        [TestMethod]
        public void TagsActionShouldRenderTagsView()
        {
            var sut = new AccountController();
            sut.WithCallTo(x => x.Tags()).ShouldRenderView("Tags");
        }
    }
}
