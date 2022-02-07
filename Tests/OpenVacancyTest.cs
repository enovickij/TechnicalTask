using NUnit.Framework;
using TechnicalTask.Core;
using TechnicalTask.Pages;

namespace TechnicalTask
{
    class OpenVacancyTest : TestBase
    {
        [Test]
        public void OpenTestAutomationSpecialistVacancy()
        {

            UserInterfaceExcepationCatch(() =>
            {
                HomePage home = new HomePage(driver);
                home.goToPage();
                home.AcceptCookies();
                AboutPage about = home.GoToAboutPage();
                JobOpportunitiesPage jobOpportunities = about.GoToJobOpportunitiesPage();
                VacanciesPage vacancies = jobOpportunities.GoToVacanciesPage();
                vacancies.OpenDesiredVacancy("Quality Assurance/Test Automation Specialist");
            });
        }
    }
}
