using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the Automation page
    /// </summary>
    public class T5_RememberThisDevicePageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_RememberThisDevicePageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_RememberThisDevicePageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets the Save button in Remember this device
        /// </summary>
        private LazyElement Save
        {
            get { return this.GetLazyElement(By.CssSelector("div.mainmodule input[value='Save']"), "Save button in Remember this device"); }
        }

        /// <summary>
        /// Check if the remember this device page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.Save.Displayed;
        }

        /// <summary>
        /// Clicks the save button
        /// </summary>
        /// <returns></returns>
        public T5_HomePageModel ClickSaveButton()
        {
            this.Save.Click();
            return new T5_HomePageModel(this.TestObject);
        }
    }
}
