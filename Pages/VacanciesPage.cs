using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TechnicalTask.Pages
{
    class VacanciesPage
    {
        private readonly IWebDriver driver;

        public VacanciesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public VacancyPage OpenDesiredVacancy(string positionTitle)
        {
            driver.FindElement(By.XPath("//*[contains(., '"+ positionTitle +"')]")).Click();

            return new VacancyPage();
        }
    }
}
