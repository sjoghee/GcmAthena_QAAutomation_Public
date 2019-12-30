using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;

namespace AutomatedTest_Athena
{
    [TestClass]
 public class AthenaBase
    {
        IWebDriver driver;



        [TestMethod]
        public bool validatelementexist(By by)
        {
            try
            {

                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [TestMethod]
        public void waitforPageload()
        {
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void waitforPortfolioProfilePageload()
        {
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void wait()
        {

            Thread.Sleep(4000);
        }

        [TestMethod]
        public void waitformanagerProfile()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        public void Waitforreportload()
        {
            Thread.Sleep(20000);
        }

        [TestMethod]
        public void Waitformanagerreports()
        {
            Thread.Sleep(60000);
        }

        [TestMethod]
        public void driverclose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception exDriverClose)
            {
                Console.WriteLine("ExceptionMessage-DriverQuit"+ exDriverClose.Message.ToString());
            }
        }

        [TestMethod]
        public IWebDriver DriverInitialization()
        {

            InternetExplorerOptions options = new InternetExplorerOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.IgnoreZoomLevel = true;
            driver = new InternetExplorerDriver(@"C:\Athena\AutomatedTest_Athena\packages\Selenium.WebDriver.IEDriver.3.14.0\driver", options);
            
            return driver;
        }


       
    }
}
