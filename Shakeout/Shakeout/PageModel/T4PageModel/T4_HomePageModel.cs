using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the HomePageModel page
    /// </summary>
    public class T4_HomePageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T4_HomePageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Ascend logo
        /// </summary>
        private LazyElement AscendLogo
        {
            get { return this.GetLazyElement(By.CssSelector("div#page-header-container-2 div.logo"), "Ascend logo"); }
        }

        /// <summary>
        /// Gets Hamburger Menu icon
        /// </summary>
        private LazyElement HamburgerMenu
        {
            get { return this.GetLazyElement(By.CssSelector("#page-header-container-2 > div.hamburger-menu"), "Hamburger Menu"); }
        }

        /// <summary>
        /// Check if the home page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.AscendLogo.Displayed;
        }

        /// <summary>
        /// Clicks the hamburger menu
        /// </summary>
        public T4_MenuPageModel ClickHamburgerMenu()
        {
            this.HamburgerMenu.Click();

            return new T4_MenuPageModel(this.TestObject);
        }
    }
}

