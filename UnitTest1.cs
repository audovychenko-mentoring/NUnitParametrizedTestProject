using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitParametrizedTestProject
{
    [TestFixture(Environment.Development)]
    public class LoginTest : BaseTest
    {
        public LoginTest(Environment currentEnvironment)
        {
            CurrentEnvironment = currentEnvironment;
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\WebDrivers");
            if (TestContext.Parameters["environment"] != null)
            {
                Enum.TryParse(TestContext.Parameters["environment"], out Environment environment);
                CurrentEnvironment = environment;
            }
            driver.Navigate().GoToUrl(CurrentEnvironmentURL);
        }
    }
}