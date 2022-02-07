using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TechnicalTask.Pages
{
    class JobOpportunitiesPage
    {
        private readonly IWebDriver driver;

        public JobOpportunitiesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='/par-if/darbs-if/vakances']")]
        public IWebElement vacanciesLink;

        public VacanciesPage GoToVacanciesPage()
        {
            vacanciesLink.Click();

            return new VacanciesPage(driver);
        }
    }
}
