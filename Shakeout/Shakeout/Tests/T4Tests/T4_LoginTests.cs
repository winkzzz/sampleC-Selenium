using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with VS unit
    /// </summary>
    [TestClass]
    public class T4_LoginTests : BaseSeleniumTest
    {

        /// <summary>
        /// Enter credentials test and  Verify Home page is displayed
        /// </summary>
        [TestMethod]
        public void LoginHome()
        {
            string username = "mgnuser01";
            string password = "Asdf!1234";
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            Assert.IsTrue(homePage.IsPageLoaded());
        }

        /// <summary>
        /// Verify ATM/Branch Locator page is displayed
        /// </summary>
        [TestMethod]
        public void BranchLocatorIsDisplayed()
        {
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();

            T4_BranchLocatorPageModel Branchpage = new T4_BranchLocatorPageModel(this.TestObject);
            T4_LoginPageModel LoginPage = new T4_LoginPageModel(this.TestObject);
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
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_KBAPageModel kbaPage = page.LoginWithValidCredentialsForKBA(username, password);
            kbaPage.AnswerKBAQuestions();
            T4_RememberThisDevicePageModel rememberThisDevicePage = kbaPage.ClickSubmit();
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
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
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_SCQPageModel scqPage = page.LoginWithValidCredentialsForSCQ(username, password);
            scqPage.AnswerSCQ();
            T4_RememberThisDevicePageModel rememberThisDevicePage = scqPage.ClickSubmit();
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            Assert.IsTrue(homePage.IsPageLoaded());
        }
    }
}
