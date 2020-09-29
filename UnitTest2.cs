using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace GridTest
{
    [TestFixture]
    [Parallelizable]
    public class Test_Grid
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var capabilities = new DesiredCapabilities("internet explorer", string.Empty, new Platform(PlatformType.Any));
            capabilities.SetCapability("ignoreProtectedModeSettings", true);

            driver = new RemoteWebDriver(new Uri("http://localhost:4445/wd/hub"), capabilities);
        }

        [Test]
        [Parallelizable]
        public void GoogleSearch()
        {
            string homepage = "http://www.google.com";
            driver.Navigate().GoToUrl(homepage);

        }

        [Test]
        [Parallelizable]
        public void BingSearch()
        {
            driver.Navigate().GoToUrl("http://www.bing.com");
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
