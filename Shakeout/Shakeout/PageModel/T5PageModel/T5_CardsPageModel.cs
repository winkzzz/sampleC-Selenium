using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModel
{
    /// <summary>
    /// Page object for the T5_Cards page
    /// </summary>
    public class T5_CardsPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_CardsPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_CardsPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Cards page
        /// </summary>
        private LazyElement Cards
        {
            get { return this.GetLazyElement(By.CssSelector("div[class='laguna-message-container']"), "Cards"); }
        }

        public override bool IsPageLoaded()
        {
            return this.Cards.Displayed;
        }
    }
}

