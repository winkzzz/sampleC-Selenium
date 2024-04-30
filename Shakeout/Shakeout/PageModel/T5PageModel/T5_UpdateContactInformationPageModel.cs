using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the T4_UpdateContactInformationPageModel page
    /// </summary>
    public class T5_UpdateContactInformationPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_UpdateContactInformationPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_UpdateContactInformationPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Address and Phone Number Module
        /// </summary>
        private LazyElement AddressAndPhoneNumberModule
        {
            get { return this.GetLazyElement(By.CssSelector("div[data-moduletitle='Address and Phone Number']"), "Address and Phone Number module"); }
        }

        /// <summary>
        /// Check if the update contact information page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.AddressAndPhoneNumberModule.Displayed;
        }
    }
}

