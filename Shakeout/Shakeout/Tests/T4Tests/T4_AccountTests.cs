using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// T4 Profile Tests
    /// </summary>
    [TestClass]
    public class T4_AccountTests : BaseSeleniumTest
    {
        /// <summary>
        /// Verify page for Credit Score
        /// </summary>
        [TestMethod]
        public void NavigateCreditScorePage()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T4_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T4_CreditScorePageModel creditScorePage = menuPage.ClickCreditScoreLink();
            Assert.IsTrue(creditScorePage.IsPageLoaded());
        }

        /// <summary>
        /// Verify page for EStatements
        /// </summary>
        [TestMethod]
        public void NavigateToEStatements()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T4_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T4_EStatementsPageModel eStatementsPage =  menuPage.ClickEStatementsLink();
            Assert.IsTrue(eStatementsPage.IsPageLoaded());
        }

        /// <summary>
        /// Verify page for Account Summary
        /// </summary>
        [TestMethod]
        public void NavigateAccountSummaryPage()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T4_LoginPageModel page = new T4_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T4_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T4_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T4_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T4_AccountSummaryPageModel accountSummaryPage = menuPage.ClickAccountSummaryLink();
            Assert.IsTrue(accountSummaryPage.IsPageLoaded());
        }

    }
}
