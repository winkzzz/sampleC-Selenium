using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// T4 Profile Tests
    /// </summary>
    [TestClass]
    public class T4_ProfileTests : BaseSeleniumTest
    {
        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void UpdateContactInformation()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T4_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickProfileLink();
            menuPage.ClickProfileUpdatesLink();
            T4_UpdateContactInformationPageModel updateContactPage = menuPage.ClickContactInformationLink();
            Assert.IsTrue(updateContactPage.IsPageLoaded());
        }
    }
}
