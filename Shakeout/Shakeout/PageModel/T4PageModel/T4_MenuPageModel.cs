using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PageModel
{
    /// <summary>
    /// Page object for the T4 Menu Page Model
    /// </summary>
    public class T4_MenuPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T4_MenuPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The test object</param>
        public T4_MenuPageModel(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets Logout Button
        /// </summary>
        private LazyElement LogoutButton
        {
            get { return this.GetLazyElement(By.CssSelector("div.slider-menu-logoff > a.logout"), "Logout button"); }
        }

        /// <summary>
        /// Gets the Profile Link from Menu side panel
        /// </summary>
        private LazyElement ProfileLink
        {
            get { return this.GetLazyElement(By.CssSelector("ul[id='M_ctl10'] > li[class*='menu-item'] > a[portalpage-commandname='Profile']"), "Profile Link"); }
        }

        /// <summary>
        /// Gets the Profile Updates Link from Menu side panel
        /// </summary>
        private LazyElement ProfileUpdatesLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_ctl10_ul_2 > ul> li[class*='menu-item'] > a[portalpage-commandname='Profile/UserProfile']"), "Profile Updates Link"); }
        }

        /// <summary>
        /// Gets the Contact Information Link from Menu side panel
        /// </summary>
        private LazyElement ContactInformationLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_ctl10_ul_3 ul > li[class*='menu-item'] > a[portalpage-commandname='Profile/ChangeAddressPhoneNumber']"), "Contact Information Link"); }
        }

        /// <summary>
        /// Gets the Account Link from Menu side panel
        /// </summary>
        private LazyElement AccountsLink
        {
            get { return this.GetLazyElement(By.CssSelector("#M_ctl10_74cfd8d9-4f31-40e3-a1aa-913deef81287_a > div.icon-text"), "Accounts Link"); }
        }

        /// <summary>
        ///  the Credit Score Link from Menu side panel
        /// </summary>
        private LazyElement CreditScoreLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_ctl10_ul_2 > ul> li[class*='menu-item'] > a[portalpage-commandname='Accounts/CreditScore']"), "Credit Score Link"); }
        }

        private LazyElement AccountSummaryLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_ctl10_ul_2 > ul> li[class*='menu-item'] > a[portalpage-commandname='Accounts/MobileAccountSummary']"), "Account Summary Link"); }
        }

        /// <summary>
        ///  the eStatements Link from Menu side panel
        /// </summary>
        private LazyElement EStatementsLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#M_ctl10_ul_2 > ul> li[class*='menu-item'] > a[portalpage-commandname='Accounts/eStatements']"), "eStatements Link"); }
        }

        /// <summary>
        /// Clicks the Profile link in Menu side panel
        /// </summary>
        public void ClickProfileLink()
        {
            this.ProfileLink.Click();
        }

        /// <summary>
        /// Clicks the Profile Updates link in Menu side panel
        /// </summary>
        public void ClickProfileUpdatesLink()
        {
            this.ProfileUpdatesLink.Click();
        }

        /// <summary>
        /// Clicks the Contact Information link in Menu side panel
        /// </summary>
        public T4_UpdateContactInformationPageModel ClickContactInformationLink()
        {
            this.ContactInformationLink.Click();
            return new T4_UpdateContactInformationPageModel(this.TestObject);
        }

        /// <summary>
        /// Clicks the Account link in Menu side panel
        /// </summary>
        public void ClickAccountLinks()
        {
            this.AccountsLink.Click();
        }

        /// <summary>
        /// Clicks the Credit Score link in Menu side panel
        /// </summary>
        /// <returns></returns>
        public T4_CreditScorePageModel ClickCreditScoreLink()
        {
            this.CreditScoreLink.Click();
            return new T4_CreditScorePageModel(this.TestObject);
        }

        public T4_AccountSummaryPageModel ClickAccountSummaryLink()
        {
            this.AccountSummaryLink.Click();
            return new T4_AccountSummaryPageModel(this.TestObject);
        }

        /// <summary>
        /// Clicks the eStatements link in Menu side panel
        /// </summary>
        /// <returns></returns>
        public T4_EStatementsPageModel ClickEStatementsLink()
        {
            this.EStatementsLink.Click();
            return new T4_EStatementsPageModel(this.TestObject);
        }

        /// <summary>
        /// Check if the Hamburger menu side panel is loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.LogoutButton.Displayed;
        }
    }
}

