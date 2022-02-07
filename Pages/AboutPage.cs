using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace TechnicalTask.Pages
{
    class AboutPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > li > a[href='/par-if/darbs-if']")]
        private IWebElement jobOpportunitiesButton;

        public JobOpportunitiesPage GoToJobOpportunitiesPage()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(jobOpportunitiesButton));
            jobOpportunitiesButton.Click();

            return new JobOpportunitiesPage(driver);
        }
    }
}
