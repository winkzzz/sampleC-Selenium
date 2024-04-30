using Magenic.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// T5 Account Tests
    /// </summary>
    [TestClass]
    public class T5_AccountTest : BaseSeleniumTest
    {
        /// <summary>
        /// Verify page for Credit Score
        /// </summary>
        [TestMethod]
        public void NavigateCreditScorePage()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T5_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T5_CreditScorePageModel creditScorePage = menuPage.ClickCreditScoreLink();
            Assert.IsTrue(creditScorePage.IsPageLoaded());
        }

        /// <summary>
        /// Verify page for Account Summary
        /// </summary>
        [TestMethod]
        public void NavigateAccountSummaryPage()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T5_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T5_AccountSummaryPageModel accountSummaryPage = menuPage.ClickAccountSummaryLink();
            Assert.IsTrue(accountSummaryPage.IsPageLoaded());
        }

        /// <summary>
        /// Verify page for Cards
        /// </summary>
        [TestMethod]
        public void NavigateCardsPage()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T5_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T5_CardsPageModel cardsPage = menuPage.ClickCardsLink();
            Assert.IsTrue(cardsPage.IsPageLoaded());
        }

        /// <summary>
        /// Verify page for E-Statements
        /// </summary>
        [TestMethod]
        public void NavigateToEStatements()
        {
            string username = "htuserretail";
            string password = "Asdf!1234";
            T5_LoginPageModel page = new T5_LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            T5_RememberThisDevicePageModel rememberThisDevicePage = page.LoginWithValidCredentials(username, password);
            T5_HomePageModel homePage = rememberThisDevicePage.ClickSaveButton();
            T5_MenuPageModel menuPage = homePage.ClickHamburgerMenu();
            menuPage.ClickAccountLinks();
            T5_EStatementsPageModel eStatementsPage = menuPage.ClickEStatementsLink();
            Assert.IsTrue(eStatementsPage.IsPageLoaded());
        }
    }
}