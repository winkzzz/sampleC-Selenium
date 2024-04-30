using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the HomePageModel page
    /// </summary>
    public class T5_HomePageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_HomePageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_HomePageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Ascend logo
        /// </summary>
        private LazyElement AscendLogo
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_pageTemplateHeader_view a.logo"), "Logo"); }
        }

        /// <summary>
        /// Gets Hamburger Menu icon
        /// </summary>
        private LazyElement HamburgerMenu
        {
            get { return this.GetLazyElement(By.CssSelector("#M_pageTemplateHeader_view button.btn-icon.icon-menu"), "Hamburger Menu"); }
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
        public T5_MenuPageModel ClickHamburgerMenu()
        {
            this.HamburgerMenu.Click();

            return new T5_MenuPageModel(this.TestObject);
        }
    }
}