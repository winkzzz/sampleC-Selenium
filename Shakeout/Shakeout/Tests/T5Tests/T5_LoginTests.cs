using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with VS unit
    /// </summary>
    [TestClass]
    public class T5_LoginTests : BaseSeleniumTest
    {

        /// <summary>
        /// Enter credentials test and  Verify Home page is displayed
        /// </summary>
        [TestMethod]
        public void LoginHome()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            Assert.IsTrue(homePage.IsPageLoaded());
        }

        /// <summary>
        /// Verify ATM/Branch Locator page is displayed
        /// </summary>
        [TestMethod]
        public void BranchLocatorIsDisplayed()
        {
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();

            T5_BranchLocatorPageModel Branchpage = new T5_BranchLocatorPageModel(this.TestObject);
            T5_LoginPageModel LoginPage = new T5_LoginPageModel(this.TestObject);
            LoginPage.ClickAtmBranchLocation();
            Assert.IsTrue(Branchpage.IsPageLoaded());
        }

        /// <summary>
        /// Login via KBA SecureNow verification
        /// </summary>
        [TestMethod]
        public void LoginKBAVerification()
        {
            string username = "htuserkba";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_KBAPageModel kbaPage = page.LoginWithValidCredentialsForKBA(username, password);
            kbaPage.AnswerKBAQuestions();
            T5_RememberThisDevicePageModel rememberThisDevicePage = kbaPage.ClickSubmit();
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            Assert.IsTrue(homePage.IsPageLoaded());
        }

        /// <summary>
        /// Login via SCQ SecureNow verification
        /// </summary>
        [TestMethod]
        public void LoginSCQVerification()
        {
            string username = "htuserscq";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_SCQPageModel scqPage = page.LoginWithValidCredentialsForSCQ(username, password);
            scqPage.AnswerSCQ();
            T5_RememberThisDevicePageModel rememberThisDevicePage = scqPage.ClickSubmit();
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            Assert.IsTrue(homePage.IsPageLoaded());
        }
    }
}
