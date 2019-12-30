using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace AutomatedTest_Athena
{
    [TestClass]
   public class PortfolioReports
    {
        public IWebDriver driver;

        AthenaBase objbase = new AthenaBase();


        // Portfolio Reports - Historical Financial Shock Analysis
        
        [TestMethod]
        public void ValidatePortfolioReports_Historical_Financial_Shock_Analysis()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Financial Shock Analysis"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool eleselectionresult = objbase.validatelementexist(By.Id("selection"));
                if(eleselectionresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                   // objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["HistoricalFinancialShockAnalysis_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["HistoricalFinancialShockAnalysis_Allocations"]);
                    objbase.waitforPageload();
                    driver.SwitchTo().DefaultContent();
                }

                bool elebuttonresult = objbase.validatelementexist(By.Id("buttons"));
                if(elebuttonresult)
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.waitforPageload();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    driver.Quit();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Historical_Financial_Shock_Analysis Exception: " + ex.Message.ToString());
                driver.Quit();
            }

        }

        // Portfolio Reports -  Risk Based Allocation Report

        [TestMethod]
        public void ValidatePortfolioReports_Risk_Based_Allocation_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                //objbase.wait();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.waitforPageload();
                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Risk Based Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool eleselectionresult = objbase.validatelementexist(By.Id("selection"));
                if(eleselectionresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["RiskBasedAllocationReport_Portfolio"]);
                    objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["RiskBasedAllocationReport_Allocations"]);
                    objbase.wait();

                    driver.SwitchTo().DefaultContent();
                }

                bool elebtnresult = objbase.validatelementexist(By.Id("buttons"));
                if(elebtnresult)
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Portfolio Report Risk_Based_Allocation Exception: " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

        // Portfolio Reports -  Historical Simulation Summary
        [TestMethod]
        public void ValidatePortfolioReports_Historical_Simulation_Summary_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                bool eleresultlist = objbase.validatelementexist(By.Id("list"));

                if(eleresultlist)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Simulation Summary"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool resulteleselection = objbase.validatelementexist(By.Id("selection"));

                if(resulteleselection)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.waitforPageload();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["HistoricalSimulationSummaryReport_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["HistoricalSimulationSummaryReport_Allocations"]);
                    objbase.waitforPageload();
                    driver.SwitchTo().DefaultContent();
                }

                bool resultelebutton = objbase.validatelementexist(By.Id("buttons"));

                if(resultelebutton)
                {
                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.waitforPageload();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception - Historical_Simulation_Summary: " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

        // Portfolio Reports -  Historical Portfolio Allocation Report

        [TestMethod]
        public void ValidatePortfolioReports_Historical_Portfolio_Allocation_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                bool resultelelist = objbase.validatelementexist(By.Id("list"));

                if(resultelelist)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool resulteleselection = objbase.validatelementexist(By.Id("selection"));

                if(resulteleselection)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["HistoricalPortfolioAllocationReport_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["HistoricalPortfolioAllocationReport_Allocation"]);
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                bool elebtnresults = objbase.validatelementexist(By.Id("buttons"));

                if(elebtnresults)
                {
                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Close();
            }

        }

        // Portfolio Reports - Portfolio Liquidity Schedule

        [TestMethod]
        public void ValidatePortfolioReports_Portfolio_Liquidity_Schedule()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Liquidity Schedule"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool elereportresult = objbase.validatelementexist(By.Id("report"));
                
                if(elereportresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("report"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.waitforPageload();

                    IWebElement elementportfolio = driver.FindElement(By.Name("IndexPP"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["PortfolioLiquiditySchedule_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Name("AllocId"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["PortfolioLiquiditySchedule_Allocation"]);
                    objbase.waitforPageload();
                }

                bool eleresultbutton = objbase.validatelementexist(By.ClassName("mp_button"));
                if(eleresultbutton)
                {
                    IWebElement eleviewreportbutton = driver.FindElement(By.ClassName("mp_button"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception - Portfolio_Liquidity_Schedule " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

        // Portfolio Reports -  Stress Test Report

        [TestMethod]
        public void ValidatePortfolioReports_Stress_Test_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                bool  elelistresult = objbase.validatelementexist(By.Id("list"));
               
                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Stress Test Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool eleselectionresult = objbase.validatelementexist(By.Id("selection"));

                if(eleselectionresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.waitforPageload();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["StressTestReport_Portfolio"]);
                    objbase.waitforPageload();
                   
                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["StressTestReport_Allcations"]);
                    objbase.waitforPageload();
                    driver.SwitchTo().DefaultContent();
                }

                bool elebtnresults = objbase.validatelementexist(By.Id("buttons"));
              
                if(elebtnresults)
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.waitforPageload();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception - Stress_Test_Report  " + ex.Message.ToString());
                objbase.driverclose();
            }

        }


        // Portfolio Reports - Underlying Manager Exposure Report 

        [TestMethod]
        public void ValidatePortfolioReports_Underlying_Manager_Exposure_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Underlying Manager Exposure Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool eleselectionresult = objbase.validatelementexist(By.Id("selection"));

                if(eleselectionresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["UnderlyingManagerExposureReport_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["UnderlyingManagerExposureReport_Allocations"]);
                    objbase.waitforPageload();
                    driver.SwitchTo().DefaultContent();
                }

                bool elebtnresult = objbase.validatelementexist(By.Id("buttons"));

                if(elebtnresult)
                {
                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.waitforPageload();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception -  Underlying Manager Exposure Report  " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

        // Portfolio Reports - Portfolio Allocation Report

        [TestMethod]
        public void ValidatePortfolioReports_PortfolioAllocationReport()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.waitforPageload();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.waitforPageload();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.waitforPageload();
                    //currentwindow();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                bool elereportresult = objbase.validatelementexist(By.Id("report"));

                if(elereportresult)
                {
                    IWebElement frmreport = driver.FindElement(By.Id("report"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.waitforPageload();

                    IWebElement elementportfolio = driver.FindElement(By.Name("porId"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["PortfolioAllocationReport_Portfolio"]);
                    objbase.waitforPageload();

                    IWebElement eleallocation = driver.FindElement(By.Name("AllocIds"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["PortfolioAllocationReport_Allocations"]);
                    objbase.waitforPageload();
                }

                bool elebtnresult = objbase.validatelementexist(By.ClassName("mp_button"));
                
                if(elebtnresult)
                {

                    IWebElement eleviewreportbutton = driver.FindElement(By.ClassName("mp_button"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                  
                    string pdfpagesource = driver.Url;
                    Console.WriteLine("PDF URL: " + pdfpagesource);
                    Assert.IsTrue(pdfpagesource.Contains("ParamsScreen"));
                    Console.WriteLine("Pdf page source" + pdfpagesource);
                    objbase.wait();
                    objbase.driverclose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception - PortfolioAllocationReport " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

        [TestMethod]
        public void ValidatePortfolioReports1()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement frmportreportfolioMenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.wait();

                IWebElement eleportfolioreportmenu = driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.wait();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                bool repotresultlist =   objbase.validatelementexist(By.Id("list"));
                if(repotresultlist)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
               
                }
                                          

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                bool eleselectionresult = objbase.validatelementexist(By.Id("selection"));
                if(eleselectionresult)
                {
                    IWebElement frmselection = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmselection);

                }
                
                bool eleportresult = objbase.validatelementexist(By.Id("port"));
                if(eleportresult)
                {
                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue(ConfigurationSettings.AppSettings["HistoricalPortfolioAllocationReport_Portfolio"]);
                    objbase.waitforPageload();
                }

                bool eleallocationresult = objbase.validatelementexist(By.Id("alloc"));

                if(eleallocationresult)
                {

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue(ConfigurationSettings.AppSettings["HistoricalPortfolioAllocationReport_Allocation"]);
                    objbase.waitforPageload();

                    driver.SwitchTo().DefaultContent();
                }
               

                bool resultfrmbuttons = objbase.validatelementexist(By.Id("buttons"));

                if(resultfrmbuttons)
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    objbase.driverclose();
                 }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception - HistoricalPortfolioAllocationReport_Allocation " + ex.Message.ToString());
                objbase.driverclose();
            }

        }

      

    }
}
