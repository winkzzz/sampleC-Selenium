using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModel
{
    /// <summary>
    /// Page object for the T4 Menu Page Model
    /// </summary>
    public class T4_BranchLocatorPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T4_BranchLocatorPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The test object</param>
        public T4_BranchLocatorPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets the whole panel from ATM/Branch Locator Page
        /// </summary>
        private LazyElement BranchLocatorPanel
        {
            get { return this.GetLazyElement(By.CssSelector("div[data-moduletitle='ATM/Branch Locator']"), "ATM/Branch Locator Page"); }
        }
                
        /// <summary>
        /// Check if the ATM/Branch Locator Page is loaded using the whole panel
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.BranchLocatorPanel.Displayed;
        }
    }
}

