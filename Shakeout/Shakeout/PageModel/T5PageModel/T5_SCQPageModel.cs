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
    public class T5_SCQPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_SCQPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public T5_SCQPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Security Question
        /// </summary>
        private LazyElement SecQ
        {
            get { return this.GetLazyElement(By.CssSelector("#M_layout_content_PCDZ_MFUZWNF_ctl00_ctl00_webInputForm_grpSecurityQuestions_phSecurityQuestions > div > p"), "Security Question"); }
        }

        /// <summary>
        /// Gets Security Question Answer Text Field
        /// </summary>
        private LazyElement SecQAnswerField
        {
            get { return this.GetLazyElement(By.CssSelector("#M_layout_content_PCDZ_MFUZWNF_ctl00_ctl00_webInputForm_grpSecurityQuestions_lvSecurityQuestions_ctrl0_txtSecurityQuestionAnswer"), "Security Question Answer Text Field"); }
        }

        /// <summary>
        /// Gets the Submit button
        /// </summary>
        private LazyElement SubmitButton
        {
            get { return this.GetLazyElement(By.CssSelector("input[value='Submit']"), "Submit Button"); }
        }

        /// <summary>
        /// Check if the SCQ page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.SecQ.Displayed;
        }

        /// <summary>
        /// Answers the SCQ verification
        /// </summary>
        public void AnswerSCQ()
        {
            string scqSentence = SecQ.Text;
            string[] scqToArray = scqSentence.Split();
            int x = scqToArray.Length - 1;
            string answer = scqToArray[x].Replace("?", "");
            this.SecQAnswerField.SendKeys(answer);
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