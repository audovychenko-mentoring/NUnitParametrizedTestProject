using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
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
            //IWebDriver driver = new ChromeDriver("C:\\Program Files\\WebDrivers");
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new FirefoxOptions().ToCapabilities());
            if (TestContext.Parameters["environment"] != null)
            {
                Enum.TryParse(TestContext.Parameters["environment"], out Environment environment);
                CurrentEnvironment = environment;
            }
            driver.Navigate().GoToUrl(CurrentEnvironmentURL);
            
            IWebDriver driver2 = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
            driver2.Navigate().GoToUrl(CurrentEnvironmentURL);

        }
    }
}