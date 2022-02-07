using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace TechnicalTask.Pages
{
    class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='/par-if']")]
        private readonly IWebElement about;

        [FindsBy(How = How.ClassName, Using = "accept-cookies-button")]
        private IWebElement acceptCookiesButton;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.if.lv/");
        }

        public void AcceptCookies()
        {
            acceptCookiesButton.Click();
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("accept-cookies-button")));
        }

        public AboutPage GoToAboutPage()
        {
            about.Click();

            return new AboutPage(driver);
        }
    }
}
