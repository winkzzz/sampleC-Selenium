using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace PageModel
{
    /// <summary>
    /// Page object for the KBAPageModel page
    /// </summary>
    public class T5_KBAPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_KBAPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_KBAPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets KBA form
        /// </summary>
        private LazyElement KBAForm
        {
            get { return this.GetLazyElement(By.CssSelector("M_layout_content_PCDZ_MFUZWNF_ctl00_ctl00_webInputForm_LC_Zone0"), "KBA Form"); }
        }

        /// <summary>
        /// Gets the Submit button
        /// </summary>
        private LazyElement SubmitButton
        {
            get { return this.GetLazyElement(By.CssSelector("input[value='Submit']"), "Submit Button"); }
        }

        /// <summary>
        /// Check if the KBA page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.KBAForm.Displayed;
        }

        /// <summary>
        /// Answers the KBA verification questions
        /// </summary>
        public void AnswerKBAQuestions()
        {
            IList<IWebElement> answersRadioButton = this.WebDriver.FindElements(By.CssSelector("label[for*='Answers_4']"));
            for (int i = 0; i < answersRadioButton.Count; i++)
            {
                answersRadioButton[i].Click();
            }
        }

        /// <summary>
        /// Clicks the submit button
        /// </summary>
        /// <returns></returns>
        public T5_RememberThisDevicePageModel ClickSubmit()
        {
            this.SubmitButton.Click();
            return new T5_RememberThisDevicePageModel(this.TestObject);
        }
    }
}
