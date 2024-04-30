using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModel
{
    /// <summary>
    /// Page object for the LoginPageModel page
    /// </summary>
    public class T4_LoginPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// The page url
        /// </summary>
        private static readonly string PageUrl = "https://cfsfiserv-s.fiservmobileapps.com/REL212SMT/SignIn.aspx";

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The test object</param>
        public T4_LoginPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets user id input field
        /// </summary>
        private LazyElement UserIdInput
        {
            get { return this.GetLazyElement(By.CssSelector("#M_layout_content_PCDZ_MMCA7G7_ctl00_webInputForm_txtLoginName"), "User Id Input"); }
        }

        /// <summary>
        /// Gets password box
        /// </summary>
        private LazyElement PasswordInput
        {
            get { return this.GetLazyElement(By.CssSelector("#M_layout_content_PCDZ_MMCA7G7_ctl00_webInputForm_txtPassword"), "Password input"); }
        }

        /// <summary>
        /// Gets continue button
        /// </summary>
        private LazyElement ContinueButton
        {
            get { return this.GetLazyElement(By.CssSelector("#M_layout_content_PCDZ_MMCA7G7_ctl00_webInputForm_cmdContinue"), "Continue button"); }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        private LazyElement ErrorMessage
        {
            get { return this.GetLazyElement(By.CssSelector("#M_MessageQueue > div > p > span"), "Error message"); }
        }
        
        /// <summary>
        /// Gets the Save button in Remember this device
        /// </summary>
        private LazyElement Save
        {
            get { return this.GetLazyElement(By.CssSelector("div.module-container.mainmodule input[value='Save']"), "Save button in Remember this device"); }
        }

        /// <summary>
        /// Gets the ATM/Branch Locator hyperlink
        /// </summary>
        private LazyElement BranchLocator
        {
            get { return this.GetLazyElement(By.CssSelector("li:nth-child(5) > a"), "ATM/Branch Locator"); }
        }


        /// <summary>
        /// Open the login page
        /// </summary>
        public void OpenLoginPage()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.EnableMobileEmulation("iPhone X");
            var driver = new ChromeDriver(chromeOptions);
            this.TestObject.OverrideWebDriver(driver);
            this.TestObject.WebDriver.Navigate().GoToUrl(PageUrl);            
            this.AssertPageLoaded();
        }

        /// <summary>
        /// Enter the use credentials
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        public void EnterCredentials(string userName, string password)
        {
            this.UserIdInput.SendKeys(userName);
            this.PasswordInput.SendKeys(password);
        }

        /// <summary>
        /// Enter the use credentials and log in - Navigation sample
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        /// <returns>The home page</returns>
        public T4_RememberThisDevicePageModel LoginWithValidCredentials(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.ContinueButton.Click();
            return new T4_RememberThisDevicePageModel(this.TestObject);
        }

        public T4_KBAPageModel LoginWithValidCredentialsForKBA(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.ContinueButton.Click();
            return new T4_KBAPageModel(this.TestObject);
        }

        public T4_SCQPageModel LoginWithValidCredentialsForSCQ(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.ContinueButton.Click();
            return new T4_SCQPageModel(this.TestObject);
        }


        /// <summary>
        /// Enter the use credentials and try to log in - Verify login failed
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        /// <returns>True if the error message is displayed</returns>
        public bool LoginWithInvalidCredentials(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.ContinueButton.Click();
            return this.ErrorMessage.Displayed;
        }

        /// <summary>
        /// Assert the login page loaded
        /// </summary>
        public void AssertPageLoaded()
        {
            Assert.IsTrue(
                this.IsPageLoaded(),
                "The web page '{0}' is not loaded",
                PageUrl);
        }

        /// <summary>
        /// Check if the login page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.UserIdInput.Displayed && this.PasswordInput.Displayed && this.ContinueButton.Displayed;
        }

        /// <summary>
        /// Click ATM/Branch Location Hyperlink
        /// </summary>
        public void ClickAtmBranchLocation()
        {
            this.BranchLocator.Click();
        }
    }
}

