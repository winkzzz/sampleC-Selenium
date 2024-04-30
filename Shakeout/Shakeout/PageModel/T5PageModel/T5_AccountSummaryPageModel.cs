using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModel
{
    /// <summary>
    /// Page object for the T5_AccountSummaryPageModel page
    /// </summary>
    public class T5_AccountSummaryPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_AccountSummaryPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_AccountSummaryPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Account Summary page
        /// </summary>
        private LazyElement AccountSummary
        {
            get { return this.GetLazyElement(By.CssSelector("div[class='main-content']"), "Account Summary"); }
        }

        public override bool IsPageLoaded()
        {
            return this.AccountSummary.Displayed;
        }
    }
}

