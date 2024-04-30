using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModel
{
    /// <summary>
    /// Page object for the T4_CreditScore page
    /// </summary>
    public class T4_CreditScorePageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T4_CreditScorePageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T4_CreditScorePageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Credit Score page
        /// </summary>
        private LazyElement CreditScore
        {
            get { return this.GetLazyElement(By.CssSelector("div[data-moduletitle='Credit Score']"), "Credit Score "); }
        }

        public override bool IsPageLoaded()
        {
            return this.CreditScore.Displayed;
        }
    }
}

