using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PageModel
{
    /// <summary>
    /// Page object for the T5 Menu Page Model
    /// </summary>
    public class T5_MenuPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T5_MenuPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The test object</param>
        public T5_MenuPageModel(SeleniumTestObject testObject) : base(testObject)
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
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li:nth-child(6) > button > div"), "Profile Link"); }
            //button
        }
        
        /// <summary>
        /// Gets the Contact Information Link from Menu side panel
        /// </summary>
        private LazyElement ContactInformationLink
        {
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li.expanded > ul > li:nth-child(1) > a"), "Contact Information Link"); }
        }

        /// <summary>
        /// Gets the Account Link from Menu side panel
        /// </summary>
        private LazyElement AccountsLink
        {
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li:nth-child(1) > button"), "Accounts Link"); }
        }

        /// <summary>
        ///  the Credit Score Link from Menu side panel
        /// </summary>
        private LazyElement CreditScoreLink
        {
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li.expanded > ul > li:nth-child(3) > a"), "Credit Score Link"); }
        }

        private LazyElement AccountSummaryLink
        {
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li.expanded > ul > li:nth-child(1) > a"), "Account Summary Link"); }
        }

        /// <summary>
        ///  the eStatements Link from Menu side panel
        /// </summary>
        private LazyElement EStatementsLink
        {
            get { return this.GetLazyElement(By.CssSelector("div#ctl138 a[href='/T5REL211SMT/Accounts/eStatements.aspx']"), "E-Statement Link"); }
        }

        /// <summary>
        ///  the Cards Link from Menu side panel
        /// </summary>
        private LazyElement CardsLink
        {
            get { return this.GetLazyElement(By.CssSelector("#ctl138 > div.drawer-nav-container > ul > li.expanded > ul > li:nth-child(7) > a"), "Cards"); }
        }

        /// <summary>
        /// Clicks the Profile link in Menu side panel
        /// </summary>
        public void ClickProfileLink()
        {
            this.ProfileLink.Click();
        }

        /// <summary>
        /// Clicks the Contact Information link in Menu side panel
        /// </summary>
        public T5_UpdateContactInformationPageModel ClickContactInformationLink()
        {
            this.ContactInformationLink.Click();
            return new T5_UpdateContactInformationPageModel(this.TestObject);
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
        public T5_CreditScorePageModel ClickCreditScoreLink()
        {
            this.CreditScoreLink.Click();
            return new T5_CreditScorePageModel(this.TestObject);
        }

        /// <summary>
        /// Clicks the Account Summary link in Menu side panel
        /// </summary>
        /// <returns></returns>
        public T5_AccountSummaryPageModel ClickAccountSummaryLink()
        {
            this.AccountSummaryLink.Click();
            return new T5_AccountSummaryPageModel(this.TestObject);
        }

        /// <summary>
        /// Clicks the eStatements link in Menu side panel
        /// </summary>
        /// <returns></returns>
        public T5_EStatementsPageModel ClickEStatementsLink()
        {
            this.EStatementsLink.Click();
            return new T5_EStatementsPageModel(this.TestObject);
        }

        /// <summary>
        /// Clicks the Cards link in Menu side panel
        /// </summary>
        /// <returns></returns>
        public T5_CardsPageModel ClickCardsLink()
        {
            this.CardsLink.Click();
            return new T5_CardsPageModel(this.TestObject);
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


