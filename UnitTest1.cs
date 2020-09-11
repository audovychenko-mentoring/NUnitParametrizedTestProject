using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitParametrizedTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\WebDrivers");
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }
    }
}