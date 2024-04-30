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
    public class T4_EStatementsPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T4_EStatementsPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T4_EStatementsPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets eStatements container
        /// </summary>
        private LazyElement EStatementsContainer
        {
            get { return this.GetLazyElement(By.CssSelector("div[data-moduletitle='eStatements']"), "eStatements Container"); }
        }

        public override bool IsPageLoaded()
        {
            return this.EStatementsContainer.Displayed;
        }
    }
}