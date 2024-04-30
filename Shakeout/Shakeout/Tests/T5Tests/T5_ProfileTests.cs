using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// T4 Profile Tests
    /// </summary>
    [TestClass]
    public class T5_ProfileTests : BaseSeleniumTest
    {
        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void UpdateContactInformation()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T5_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickProfileLink();
            T5_UpdateContactInformationPageModel updateContactPage = menuPage.ClickContactInformationLink();
            Assert.IsTrue(updateContactPage.IsPageLoaded());
        }
    }
}