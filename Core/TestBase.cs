using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.IO;
using System.Reflection;

namespace TechnicalTask.Core
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
        }

        protected void UserInterfaceExcepationCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {                
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string fileName = ex.GetType().Name.ToString() + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss");
                
                screenshot.SaveAsFile($"../../../Screenshots/{fileName}.png", ScreenshotImageFormat.Png);

                throw;
            }
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
