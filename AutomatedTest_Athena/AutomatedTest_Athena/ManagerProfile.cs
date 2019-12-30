using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

using System.Configuration;

using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.IO.Compression;










/*namespace AutomatedTest_Athena
{
  /*  [TestClass]
    public class ManagerProfile
    {

        public IWebDriver driver = null;

        //IWebDriver driver;
       
         public  ManagerProfile()
        {
             this.driver = driver;
             
         }


        /* public object  driver
         {
             get
             {
                 return driver;
             }
             set
             {
                 this.driver = null;
             }
         }*/


      

      //  AthenaBase objbase = new AthenaBase();
      

      /* [TestInitialize]
        public void TestInitialize()
        {

           /// objbase.DriverInitialization();

           /* InternetExplorerOptions options = new InternetExplorerOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            driver = new InternetExplorerDriver(@"C:\Athena\AutomatedTest_Athena\packages\Selenium.WebDriver.IEDriver.3.14.0\driver", options);
                    
        }*/


      /*  [TestMethod]
        public void DriverClose()
        {
            driver.Close();
        }*/


     /*   [TestMethod]
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
        }*/

     /*   [TestMethod]
        public void currentwindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        } */
        
        // Portfolio - Fund Portal

      /*  [TestMethod]
        public void validateportfolio_Fundporttal()
        {
            try
            {
                
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                IJavaScriptExecutor portfolioexecutor = (IJavaScriptExecutor)driver;
                objbase.wait();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elportmenulink = driver.FindElement(By.LinkText("Reports Menu"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elportmenulink);
                portfolioexecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                objbase.wait();
                IWebElement lnkfundportal = driver.FindElement(By.LinkText("Portfolio Fund Portal"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", lnkfundportal);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.wait();

                IWebElement divportfoliofund = driver.FindElement(By.Id("select-typer"));
                IWebElement eletxtportfoliofund = divportfoliofund.FindElement(By.ClassName("single-select-search"));
                eletxtportfoliofund.SendKeys("Citadel Kensington Ltd");
                eletxtportfoliofund.SendKeys(OpenQA.Selenium.Keys.Enter);
                objbase.wait();

                // Portfolio Fund Portal - Overview

                IWebElement divreportfundportalmenu = driver.FindElement(By.Id("page-container"));
                IWebElement reportoverview = divreportfundportalmenu.FindElement(By.LinkText("Overview"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportoverview);
                //driver.SwitchTo().Window(driver.WindowHandles.Last());
                portfolioexecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                objbase.Waitforreportload();
                driver.Quit();
                   
                // Portfolio Fund Portal - Portfolio Fund Risk Summary 


                IWebElement reportportfoliofundrisksummary = divreportfundportalmenu.FindElement(By.LinkText("Portfolio Fund Risk Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportportfoliofundrisksummary);
                objbase.Waitforreportload();
               // driver.Quit();

                //Portfolio Fund Portal -  Financial Shocks 

                IWebElement reportFinancialShocks = divreportfundportalmenu.FindElement(By.LinkText("Financial Shocks"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportFinancialShocks);
                objbase.Waitforreportload();

                // Portfolio Fund Portal -   Exposure 

                IWebElement reportExposure = divreportfundportalmenu.FindElement(By.LinkText("Exposure"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportExposure);
                objbase.Waitforreportload();

                // Portfolio Fund Portal -  Historical Exposure 

                IWebElement reportHistoricalExposure = divreportfundportalmenu.FindElement(By.LinkText("Historical Exposure"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportHistoricalExposure);
                objbase.Waitforreportload();

                // Portfolio Fund Portal - Peer Strategy

                IWebElement reportpeerstrategy = divreportfundportalmenu.FindElement(By.LinkText("Peer Strategy"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportpeerstrategy);
                objbase.Waitforreportload();

                // Portfolio Fund Portal - Peer SubStrategy

                IWebElement reportPeersubStrategy = divreportfundportalmenu.FindElement(By.LinkText("Peer SubStrategy"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportPeersubStrategy);
                objbase.Waitforreportload();

                // Portfolio Fund Portal - Manager Snapshot 

                IWebElement reportmanagersnapshot = divreportfundportalmenu.FindElement(By.LinkText("Manager Snapshot"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", reportmanagersnapshot);
                objbase.Waitforreportload();

                driver.Quit();

            }
            catch (Exception exfundportal)
            {
                Console.WriteLine(exfundportal.Message.ToString());
            }
        }

        [TestMethod]
        public void validatePortfolioManagerReports()
        {
            try
            {

                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elportmenulink = driver.FindElement(By.LinkText("Portfolio Menu"));
                IJavaScriptExecutor portfolioexecutor = (IJavaScriptExecutor)driver;
                portfolioexecutor.ExecuteScript("arguments[0].click();", elportmenulink);
                objbase.wait();

                IWebElement eleportlnkmgmtreport = driver.FindElement(By.LinkText("Portfolio Mgmt Reports"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleportlnkmgmtreport);
                objbase.wait();

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                IWebElement eleselectportfolio = driver.FindElement(By.Id("SelectedPortfolio"));
                SelectElement selecportfoio = new SelectElement(eleselectportfolio);
                selecportfoio.SelectByValue("522");
                objbase.wait();

                IWebElement elerefreshReport = driver.FindElement(By.Id("refreshReport"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elerefreshReport);
                objbase.wait();

                IWebElement elementallocation = driver.FindElement(By.Id("SelectedAllocation"));
                SelectElement selectallocation = new SelectElement(elementallocation);
                IWebElement eelerefreshReportle1 = driver.FindElement(By.Id("refreshReport"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eelerefreshReportle1);
                objbase.wait();

                IWebElement elereport = driver.FindElement(By.Id("reports"));
                IWebElement eleportfolioreportsnapshot = elereport.FindElement(By.LinkText("Portfolio Snapshot"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportsnapshot);
                Thread.Sleep(5000);

                // Portfolio Management Report - Fund Performance Summary

                IWebElement elegfundperformancesummary = elereport.FindElement(By.LinkText("Fund Performance Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elegfundperformancesummary);
                Thread.Sleep(5000);

                // Portfolio Management Report - Allocation Summary - report 

                IWebElement eleallocationsummaryreport = elereport.FindElement(By.LinkText("Allocation Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleallocationsummaryreport);
                Thread.Sleep(7000);

                // Portfolio Management Report - FWIG

                IWebElement elefwigreport = elereport.FindElement(By.LinkText("FWIG"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elefwigreport);
                Thread.Sleep(7000);

                // Portfolio Management Report - Proposed Activity Summary

                IWebElement eleProposedActiveSummary = elereport.FindElement(By.LinkText("Proposed Activity Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleProposedActiveSummary);
                Thread.Sleep(7000);

                // Portfolio Management Report - Portfolio Fund Target Allocations

                IWebElement eleportfoliofundtargetallocations = elereport.FindElement(By.LinkText("Portfolio Fund Target Allocations"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleportfoliofundtargetallocations);
                Thread.Sleep(7000);

                // Portfolio Management Report - Liquidity Analysis By Fund

                IWebElement eleLiquidityanalysisbyfund = elereport.FindElement(By.LinkText("Liquidity Analysis By Fund"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleportfoliofundtargetallocations);
                Thread.Sleep(5000);

                // Portfolio Management Report - Risk Summary
                // Portfolio Management Report - RisK summary report not loading 

                IWebElement elerisksummary = elereport.FindElement(By.LinkText("Risk Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elerisksummary);
                Thread.Sleep(5000);

                // Portfolio Management Report -  PM Top Position Comparison

                IWebElement elepmtoppositioncomparison = elereport.FindElement(By.LinkText("PM Top Position Comparison"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elepmtoppositioncomparison);
                Thread.Sleep(5000);

                //  Portfolio Management Report - VaR Contribution

                IWebElement elevarContribution = elereport.FindElement(By.LinkText("VaR Contribution"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elevarContribution);
                Thread.Sleep(5000);

                // Portfolio Management Report - Financial Shocks

                IWebElement elefinancialshocks = elereport.FindElement(By.LinkText("Financial Shocks"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elefinancialshocks);
                Thread.Sleep(5000);


                //  Portfolio Management Report - PM Contribution to BAN

                IWebElement elepmcontributiontoban = elereport.FindElement(By.LinkText("PM Contribution to BAN"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", elepmcontributiontoban);
                Thread.Sleep(5000);

                // Portfolio Management Report - Exposure Summary

                IWebElement eleexposuresummary = elereport.FindElement(By.LinkText("Exposure Summary"));
                portfolioexecutor.ExecuteScript("arguments[0].click();", eleexposuresummary);
                Thread.Sleep(5000);

                
               // driver.Quit();
            

            }
            catch (Exception ex)
            {
                driver.Quit();

            }
        }

        // Manager Reporting - Manager Due Diligence Reporting

        [TestMethod]
        public void ValidateManagerReports_Due_Diligence_Reporting()
        {
            try
            {
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elmgrlink = driver.FindElement(By.LinkText("Manager Menu"));
                IJavaScriptExecutor Managerexecutor = (IJavaScriptExecutor)driver;
                Managerexecutor.ExecuteScript("arguments[0].click();", elmgrlink);
                objbase.wait();

                IWebElement elemmenumgrreports = driver.FindElement(By.LinkText("Manager Reports"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elemmenumgrreports);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.wait();

                if(validatelementexist(By.Id("list")))
                {
                     IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elmexporesummarylink = driver.FindElement(By.LinkText("Manager Due Diligence Reporting"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", elmexporesummarylink);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                     //  objbase.wait();
                
                }

                if (validatelementexist(By.Id("Filters_SelectedInvestmentManagerId")))
                {

                    IWebElement eleselInvestmentcompany = driver.FindElement(By.Id("Filters_SelectedInvestmentManagerId"));
                    SelectElement seleInvestmentCompany = new SelectElement(eleselInvestmentcompany);
                    seleInvestmentCompany.SelectByValue(ConfigurationSettings.AppSettings["MgrDueDiligence"]);
                    objbase.wait();
                }
                
                IWebElement eleportfoliofund = driver.FindElement(By.Id("AvailablePortfolioFunds"));
                SelectElement seleportfoliofund = new SelectElement(eleportfoliofund);
                seleportfoliofund.SelectByValue(ConfigurationSettings.AppSettings["MgrDueDiligencePortfolio"]);

                IWebElement eleaddbtn = driver.FindElement(By.Id("addPortfolioFund"));
                Managerexecutor.ExecuteScript("arguments[0].click();", eleaddbtn);

                IWebElement elebtnreport = driver.FindElement(By.Id("btnView"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elebtnreport);
                objbase.Waitformanagerreports();
                driver.Quit();

            }
            catch (Exception exduediligence)
            {
                Console.WriteLine("Exception Message:" + exduediligence.Message.ToString());
            }
        }
       
        // Manager Reporting  - Exposure report

        [TestMethod]
        public void ValidateManagerReports_Exposure_Report()
        {
            try
            {
               
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elmgrlink = driver.FindElement(By.LinkText("Manager Menu"));
                IJavaScriptExecutor Managerexecutor = (IJavaScriptExecutor)driver;
                Managerexecutor.ExecuteScript("arguments[0].click();", elmgrlink);
                objbase.wait();

                IWebElement elemmenumgrreports = driver.FindElement(By.LinkText("Manager Reports"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elemmenumgrreports);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.wait();

                if (validatelementexist(By.Id("list")))
                {

                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elmexporesummarylink = driver.FindElement(By.LinkText("Exposure Report"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", elmexporesummarylink);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    objbase.wait();
                }
                if (validatelementexist(By.Id("selection")))
                {
                    Console.WriteLine("element selection");
                    IWebElement frmselection = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmselection);
                    objbase.wait();
                    IWebElement eleconfig = driver.FindElement(By.Id("config"));
                    SelectElement selconfig = new SelectElement(eleconfig);
                    selconfig.SelectByValue("89");
                    objbase.wait();

                    // var eleSearch = WebDriver.FindElement(By.XPath("//*[@id='PEMenu_4690']"));

                    //var eleoptportfoliofund = driver.FindElement(By.XPath("//*[@id='rdoReportData']"));

                    IList<IWebElement> lstportfoliofund = driver.FindElements(By.XPath("//*[@id='rdoReportData']"));

                    lstportfoliofund[1].Click();

                    // Managerexecutor.ExecuteScript("arguments[0].click();", lstportfoliofund[0]);
                    objbase.wait();

                    IWebElement elemanager = driver.FindElement(By.Id("manager"));
                    bool managerdropdown = elemanager.Enabled;
                    Console.WriteLine("Manager drown enabled" + managerdropdown);
                    SelectElement selmgr = new SelectElement(elemanager);
                    selmgr.SelectByValue("12969");
                    objbase.wait();

                    IWebElement eleviewreport = driver.FindElement(By.Id("btnViewRpt"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", eleviewreport);
                    objbase.wait();

                    /*
                 WebClient client = new System.Net.WebClient();
                    client.UseDefaultCredentials = true;
                    byte[] dwdreport = client.DownloadData("http://athena-qat/reports/Exposure/ParamsScreen.html");
                    System.IO.File.WriteAllBytes("exposure.txt", dwdreport);
                    System.IO.File.OpenRead("C:/Athena/AutomatedTest_Athena/AutomatedTest_Athena/bin/Debug/exposure.txt");
                   //ystem.IO. */
                          
                  //string file1 = Convert.ToString(dwdreport);
                   //System.IO.File.Open(file1, System.IO.FileMode.Open);
                   
                   // ;
                    //  client.OpenRead("http://athena-qat/reports/Exposure/ParamsScreen.html");
                    // byte[] file = client.DownloadData("http://athena-qat/reports/Exposure/ParamsScreen.html");
                    ///   System.IO.File.WriteAllBytes("helloworld.txt", file);
                    /*System.Net.WebRequest request = System.Net.HttpWebRequest.Create("http://athena-qat/reports/Exposure/ParamsScreen.html");
                    System.Net.WebResponse response = request.GetResponse();
                       
                                      
                } 



            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: "+ ex.Message.ToString());
            }
        }*/

        // Adhoc - Report


        //Manager REP - Summary of Legal Terms and Conditions Report
    /*
        [TestMethod]
        public void ValidateManagerReports_Text_Summary_of_Legal_Terms_and_Conditions_Report()
        {
            try
            {
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elmgrlink = driver.FindElement(By.LinkText("Manager Menu"));
                IJavaScriptExecutor Managerexecutor = (IJavaScriptExecutor)driver;
                Managerexecutor.ExecuteScript("arguments[0].click();", elmgrlink);
                objbase.wait();

                IWebElement elemmenumgrreports = driver.FindElement(By.LinkText("Manager Reports"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elemmenumgrreports);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.wait();
                if(validatelementexist(By.Id("list")))
                {

                   IWebElement  frmlist =driver.FindElement(By.Id("list"));
                   driver.SwitchTo().Frame(frmlist);
                   IWebElement elmsummmaryltclink = driver.FindElement(By.LinkText("Summary of Legal Terms and Conditions Report"));
                   Managerexecutor.ExecuteScript("arguments[0].click();", elmsummmaryltclink);
                   driver.SwitchTo().Window(driver.WindowHandles.Last());
                   objbase.wait();
                }
                               
                if(validatelementexist(By.Id("report")))
                {
                   
                    IWebElement frmreportmenu = driver.FindElement(By.Id("report"));
                    driver.SwitchTo().Frame(frmreportmenu);
                    IWebElement elemanagerfund = driver.FindElement(By.Id("manager"));
                    SelectElement selmgrfund = new SelectElement(elemanagerfund);
                    selmgrfund.SelectByValue("9869");
                   

                    IWebElement legaldoctype = driver.FindElement(By.Name("availableTypes"));
                    SelectElement seledlegaldoctype = new SelectElement(legaldoctype);
                    seledlegaldoctype.SelectByValue("1");
                    objbase.wait();

                    IWebElement eletbllayout = driver.FindElement(By.Id("layout"));
                    IWebElement eleaddbtn = eletbllayout.FindElement(By.Name("ldtadd"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", eleaddbtn);
                    objbase.wait();

                    IWebElement eleavblLegalDocs = driver.FindElement(By.Name("availableDocs"));
                    SelectElement sellegaldocs = new SelectElement(eleavblLegalDocs);
                    sellegaldocs.SelectByValue("1|5920");
                    objbase.wait();

                    IWebElement eleaddsinglebtn = driver.FindElement(By.Name("ldadd"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", eleaddsinglebtn);
                    driver.Manage().Window.Maximize();
                    objbase.wait();

                    if(validatelementexist(By.ClassName("mp_button")))
                    {
                        IWebElement elemviewbtn = driver.FindElement(By.XPath("//img[contains(@src, '/images/view.gif')]"));
                       
                            Managerexecutor.ExecuteScript("arguments[0].click();", elemviewbtn);
                            objbase.wait();
                            IAlert altlegalterms = driver.SwitchTo().Alert();
                            altlegalterms.Accept();
                            driver.SwitchTo().Window(driver.WindowHandles.Last());
                            objbase.wait();
                            driver.Manage().Window.Maximize();
                          
                        
                    }


                    //driver.Quit();

                                           
                }

              }
            catch (Exception ex)
            {
                 Console.WriteLine(" Manager Reports Exception: " + ex.Message.ToString());
                // driver.Quit();
            }


        }

        [TestMethod]
        public void ValidatePortfolioReports_PortfolioAllocationReport()
        {
            try
            {
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
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    //currentwindow();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }
                
                if(validatelementexist(By.Id("report")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("report"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Name("porId"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                  //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Name("AllocIds"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();
                 }

                if(validatelementexist(By.ClassName("mp_button")))
                {
                         
                    IWebElement eleviewreportbutton = driver.FindElement(By.ClassName("mp_button"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    string pdfpagesource = driver.Url;
                    Console.WriteLine("PDF URL: " + pdfpagesource);
                    Assert.IsTrue(pdfpagesource.Contains("ParamsScreen"));
                    Console.WriteLine("Pdf page source" + pdfpagesource);

                    objbase.wait();
                    driver.Quit();
                }
                          
            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Quit();
            }

        }

       
       
        // Underlying Manager Exposure Report 
        
        [TestMethod]
        public void ValidatePortfolioReports_Underlying_Manager_Exposure_Report()
        {
            try
            {
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
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Underlying Manager Exposure Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if(validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if(validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.Waitforreportload();
                    driver.Quit();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Quit();
            }

        }


        // Stress Test Report

        [TestMethod]
        public void ValidatePortfolioReports_Stress_Test_Report()
        {
            try
            {
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
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Stress Test Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if(validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("459");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("4718");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if(validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                    driver.Quit();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Quit();
            }

        }

        // Portfolio Reports -  Historical Simulation Summary
        [TestMethod]
        public void ValidatePortfolioReports_Historical_Simulation_Summary_Report()
        {
            try
            {
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
                if (validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Simulation Summary"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if (validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("459");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("4718");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if (validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                    driver.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Close();
            }

        }

        // Historical Portfolio Allocation Report
        [TestMethod]
        public void ValidatePortfolioReports_Historical_Portfolio_Allocation_Report()
        {
            try
            {
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
                if (validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if (validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if (validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                    driver.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Close();
            }

        }

        // Historical Financial Shock Analysis

        [TestMethod]
        public void ValidatePortfolioReports_Historical_Financial_Shock_Analysis()
        {
            try
            {
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
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Historical Financial Shock Analysis"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if(validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if(validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                    driver.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Close();
            }

        }

        // Risk Based Allocation Report

        [TestMethod]
        public void ValidatePortfolioReports_Risk_Based_Allocation_Report()
        {
            try
            {
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
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Risk Based Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                }

                if(validatelementexist(By.Id("selection")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();
                    driver.SwitchTo().DefaultContent();
                }

                if (validatelementexist(By.Id("buttons")))
                {

                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                    driver.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
                driver.Close();
            }

        }


        // Portfolio Liquidity Schedule

        [TestMethod]
        public void ValidatePortfolioReports_Portfolio_Liquidity_Schedule()
        {
            try
            {
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
                if (validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Liquidity Schedule"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);
                    objbase.wait();
                    currentwindow();
                }

                if (validatelementexist(By.Id("report")))
                {
                    IWebElement frmreport = driver.FindElement(By.Id("report"));
                    driver.SwitchTo().Frame(frmreport);
                    objbase.wait();

                    IWebElement elementportfolio = driver.FindElement(By.Name("IndexPP"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("178");
                    //  objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Name("AllocId"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("2881");
                    objbase.wait();
                }

                if (validatelementexist(By.ClassName("mp_button")))
                {

                    IWebElement eleviewreportbutton = driver.FindElement(By.ClassName("mp_button"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
            }

        }
        [TestMethod]
        public void ValidatePortfolioReports()
        {
            try
            {
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement frmportreportfolioMenu=driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(frmportreportfolioMenu);
                IWebElement elementReportsmenu = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Reportexecutor = (IJavaScriptExecutor)driver;
                Reportexecutor.ExecuteScript("arguments[0].click();", elementReportsmenu);
                objbase.wait();

                IWebElement eleportfolioreportmenu =  driver.FindElement(By.LinkText("Portfolio Reports"));
                Reportexecutor.ExecuteScript("arguments[0].click();", eleportfolioreportmenu);
                objbase.wait();

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                if(validatelementexist(By.Id("list")))
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elereportallocation = driver.FindElement(By.LinkText("Portfolio Allocation Report"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", elereportallocation);

                   
                    objbase.wait();
                    currentwindow();
                   // objbase.wait();
                
                }
                              
                
               // if(validatelementexist(By.Id("port")))
               // {

                   driver.SwitchTo().Window(driver.WindowHandles.Last());

                   IWebElement frmselection = driver.FindElement(By.Id("selection"));
                   driver.SwitchTo().Frame(frmselection);
                   

                    IWebElement elementportfolio = driver.FindElement(By.Id("port"));
                    SelectElement selectporfolio = new SelectElement(elementportfolio);
                    selectporfolio.SelectByValue("522");
                    objbase.wait();

                    IWebElement eleallocation = driver.FindElement(By.Id("alloc"));
                    SelectElement seleallocation = new SelectElement(eleallocation);
                    seleallocation.SelectByValue("7102");
                    objbase.wait();

                    driver.SwitchTo().DefaultContent();
                // }

                if(validatelementexist(By.Id("buttons")))
                {
                
                    IWebElement frmviewbuttons = driver.FindElement(By.Id("buttons"));
                    driver.SwitchTo().Frame(frmviewbuttons);
                    objbase.wait();
                    IWebElement eleviewreportbutton = driver.FindElement(By.Name("viewReportButton"));
                    Reportexecutor.ExecuteScript("arguments[0].click();", eleviewreportbutton);
                    objbase.wait();
                }
                        
                

               // }

            }
            catch (Exception ex)
            {
                Console.WriteLine("PortfolioReport Exception: " + ex.Message.ToString());
            }

        }

        [TestMethod]
        public void ValidatePortfolioProfile()
        {
                try
                {
                    driver =  objbase.DriverInitialization();
                    driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                    driver.Manage().Window.Maximize();
                    objbase.waitforPageload();
                    IWebElement elefrmportfolioprofile = driver.FindElement(By.Id("menu"));
                    driver.SwitchTo().Frame(elefrmportfolioprofile);
                    IWebElement elePorfoliomenu = driver.FindElement(By.LinkText("Portfolio Menu"));
                    IJavaScriptExecutor portfolioexecutor = (IJavaScriptExecutor)driver;
                    portfolioexecutor.ExecuteScript("arguments[0].click();", elePorfoliomenu);
                    objbase.waitforPageload();
                    if(validatelementexist(By.LinkText("Portfolio Profile")))
                    {
                        IWebElement eleporfolioprofile = driver.FindElement(By.LinkText("Portfolio Profile"));
                        portfolioexecutor.ExecuteScript("arguments[0].click();", eleporfolioprofile);
                        objbase.waitforPageload();
                    }

                        driver.SwitchTo().Window(driver.WindowHandles.Last());
                        if(validatelementexist(By.Id("pp_buttons1")))
                        {

                            IWebElement elemfrmselectportfolio = driver.FindElement(By.Id("pp_buttons1"));
                            driver.SwitchTo().Frame(elemfrmselectportfolio);
                        }
                        if(validatelementexist(By.Name("selectPortfolioButton")))
                        {
                            
                                 IWebElement elebtnselecportfolio = driver.FindElement(By.Name("selectPortfolioButton"));
                                 try
                                 {
                                     portfolioexecutor.ExecuteScript("arguments[0].click();", elebtnselecportfolio);
                                     objbase.waitforPageload();
                                 }
                                 catch (Exception exseleportfolio)
                                 { }
                          
                        }
                                                    
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    objbase.waitforPageload();
                    if(validatelementexist(By.Id("selectPortfolio")))
                     {
                        IWebElement frmselectPortfolios = driver.FindElement(By.Id("selectPortfolio"));
                        driver.SwitchTo().Frame(frmselectPortfolios);
                        IWebElement eleselPorfolio = driver.FindElement(By.Id("pp"));
                        SelectElement selectportfolio = new SelectElement(eleselPorfolio);
                        selectportfolio.SelectByValue(ConfigurationSettings.AppSettings["PortfolioProfile_Portfolio"]);
                        objbase.waitforPageload();
                     }

                    // Poftfolio profile - ok 
                    if(validatelementexist(By.Name("okButton")))
                    {
                        IWebElement elementok = driver.FindElement(By.Name("okButton"));
                        try
                        {
                            portfolioexecutor.ExecuteScript("arguments[0].click();", elementok);
                            objbase.waitforPageload();
                        }
                        catch (Exception exokbutton)
                        { }

                    }
                   // driver.Close();       
                   // Portfolio - Save

                  /*  driver.SwitchTo().Window(driver.WindowHandles.Last());

                     objbase.wait();
                    IWebElement frmsave = driver.FindElement(By.Id("pp_buttons2"));
                    objbase.wait();
                    driver.SwitchTo().Frame(frmsave);
                    objbase.wait();
                    IWebElement btnsave = driver.FindElement(By.Id("btnSave"));
                    
                    portfolioexecutor.ExecuteScript("arguments[0].click();", btnsave);
                    objbase.wait();*/

                    // Portfolio - Formal Objectives and Constraints
                 
               /*     driver.SwitchTo().Window(driver.WindowHandles.Last());
                    objbase.waitforPageload();
                    IWebElement elefrmppnavigator = driver.FindElement(By.Id("pp_navigator"));
                    driver.SwitchTo().Frame(elefrmppnavigator);
                    var ForObjectivesandContstraints = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Formal Objectives and Constraints')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", ForObjectivesandContstraints);
                    Thread.Sleep(5000);

                    //Informal Objectives and Constraints
                    
                    var InformalObjectivesandconstraints = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Informal Objectives and Constraints')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", InformalObjectivesandconstraints);
                    Thread.Sleep(5000);

                    // Investable Cash Components

                   /* var InvestableCashComponents = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Investable Cash Components')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", InvestableCashComponents);
                    Thread.Sleep(5000);*/
                           
                    // Investable Cash Components Settings

              /*      var InvestableCashComponentsSettings = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Investable Cash Components Settings')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", InvestableCashComponentsSettings);
                    Thread.Sleep(5000);

                    //Legal Profile

                    var LegalProfile = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Legal Profile')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", LegalProfile);
                    Thread.Sleep(5000);

                    // Legal Document -  Legal Information

                    var Legaldoclegalinformation = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Legal Information')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", Legaldoclegalinformation);
                    Thread.Sleep(5000);



                    // Trade Execution Details

                    var TradeExecutionDetails = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Trade Execution Details')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", TradeExecutionDetails);
                    Thread.Sleep(5000);

                    // Legal Policies

                    var LegalPolicies = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Legal Policies')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", LegalPolicies);
                    Thread.Sleep(5000);

                    //  Legal Information
                    try
                    {
                        var LegalInformation = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Legal Information')]"));
                        portfolioexecutor.ExecuteScript("arguments[0].click();", LegalInformation);
                        Thread.Sleep(5000);
                    }
                    catch (Exception exlegalInfo)
                    { }

                    // Liquidity Summarization

                    var LiquiditySummarization = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Liquidity Summarization')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", LiquiditySummarization);
                    Thread.Sleep(5000);

                    // Portfolio Report Preferences

                    var PortfolioReportPreferences = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Portfolio Report Preferences')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", PortfolioReportPreferences);
                    Thread.Sleep(5000);

                    // Global Report Preferences

                    var GlobalReportPreferences = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Global Report Preferences')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", GlobalReportPreferences);
                    Thread.Sleep(5000);

                    // Historical Financial Shocks Periods

                    var HistoricalFinancialShocksPeriods = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Historical Financial Shocks Periods')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", HistoricalFinancialShocksPeriods);
                    Thread.Sleep(5000);

                    // Bank Summary Covenants

                     var BankSummaryCovenants  = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Bank Summary Covenants')]"));
                     portfolioexecutor.ExecuteScript("arguments[0].click();", BankSummaryCovenants);
                    Thread.Sleep(5000);
                    
                    // Portfolio Bank Summary Covenants

                    var PortfolioBankSummaryCovenants = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Portfolio Bank Summary Covenants')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", PortfolioBankSummaryCovenants);
                    Thread.Sleep(5000);

                    // Beta Factors

                    var BetaFactors = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Beta Factors')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", BetaFactors);
                    Thread.Sleep(5000);

                    //Fund Targets

                    var FunTargets = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Fund Targets')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", FunTargets);
                    Thread.Sleep(5000);

                    // Mandate Targets

                    var MandateTargets = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Mandate Targets')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", MandateTargets);
                    Thread.Sleep(5000);

                    // Portfolio Related Documents

                    var PortfolioRelatedDocuments = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Portfolio Related Documents')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", PortfolioRelatedDocuments);
                    Thread.Sleep(5000);

                    // Firm-Wide Related Documents

                    var FirmWideRelatedDocuments = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Firm-Wide Related Documents')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", FirmWideRelatedDocuments);
                    Thread.Sleep(5000);

                    // Review Notes

                    var ReviewNotes = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Review Notes')]"));
                    portfolioexecutor.ExecuteScript("arguments[0].click();", ReviewNotes);
                    Thread.Sleep(5000);

             }
                catch(WebDriverException wx)
                {
                    Console.WriteLine("Web driver exception:" + wx.Message.ToString());
                }
                
        }*/

     /*   [TestMethod]
        public void Validate_AdhocRepots()
        {

            try
            {
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
                IWebElement elefrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elefrmenu);
                IWebElement elportmreportslink = driver.FindElement(By.LinkText("Reports Menu"));
                IJavaScriptExecutor Adhocreportexecutor = (IJavaScriptExecutor)driver;
                Adhocreportexecutor.ExecuteScript("arguments[0].click();", elportmreportslink);
                objbase.wait();

                IWebElement eleAdHocReports = driver.FindElement(By.LinkText("Ad Hoc Reports"));
                Adhocreportexecutor.ExecuteScript("arguments[0].click();", eleAdHocReports);

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                IWebElement elehiredfiredmgrstrategy = driver.FindElement(By.Id("ui_a23"));
                IWebElement lnkhiredfiredmgrstartegy = elehiredfiredmgrstrategy.FindElement(By.LinkText("Hired and Fired Managers with Strategy Classification"));
                Adhocreportexecutor.ExecuteScript("arguments[0].click();", lnkhiredfiredmgrstartegy);

                IWebElement adhocportfolio = driver.FindElement(By.Id("ctl32_ctl04_ctl03_ddValue"));
                SelectElement seladhocportfolio = new SelectElement(adhocportfolio);
                seladhocportfolio.SelectByValue(ConfigurationSettings.AppSettings["Adhoc_portfolio"]);

              /*  IWebElement adhocAccountingperiodsine = driver.FindElement(By.Id("ctl32_ctl04_ctl05_ddValue"));
                SelectElement seleperiod = new SelectElement(adhocAccountingperiodsine);
                seleperiod.SelectByValue(ConfigurationSettings.AppSettings[""])




                 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message:" + ex.Message.ToString());
 
            }
        }*/


     /*   [TestMethod]
        public void ValidateManagerProfile()
        {
            IWebElement elefrmMgrMenu;
            try
            {
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.wait();
               
                // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                //  driver.Quit();

                elefrmMgrMenu = driver.FindElement(By.Id("menu"));

                driver.SwitchTo().Frame(elefrmMgrMenu);
                Thread.Sleep(3000);
                IWebElement elementmanager = driver.FindElement(By.LinkText("Manager Menu"));
                Thread.Sleep(3000);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", elementmanager);

                IWebElement elementmgrProfile = driver.FindElement(By.LinkText("Manager Profile"));
                executor.ExecuteScript("arguments[0].click();", elementmgrProfile);
                Thread.Sleep(10000);

                IList<string> currenthandles = driver.WindowHandles;
                                
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                if(validatelementexist(By.Id("mp_buttons1")))
                {

                    try
                    {
                        IWebElement elefrmcompany = driver.FindElement(By.Id("mp_buttons1"));
                        driver.SwitchTo().Frame(elefrmcompany);
                        IWebElement CompanyFundBtn = driver.FindElement(By.Name("selectCompanyFundButton"));
                        executor.ExecuteScript("arguments[0].click();", CompanyFundBtn);
                        objbase.waitformanagerProfile();
                       
                    }
                    catch(Exception ex1)
                    {
                        Console.WriteLine("Exception Message:"+ ex1.Message.ToString());
                    }
                }
                        
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    //Thread.Sleep(5000);
                    if(validatelementexist(By.Id("MFIS")))
                    {

                        IWebElement elemgrfundIvnStatus = driver.FindElement(By.Id("MFIS"));
                     // Thread.Sleep(5000);
                       // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                        SelectElement selmgrfundIvnStatus = new SelectElement(elemgrfundIvnStatus);
                        selmgrfundIvnStatus.SelectByValue(ConfigurationSettings.AppSettings["PortfolioProfileManagerFundInvestmentStatus"]);
                      
                     }
                   
                   // Thread.Sleep(5000);
                    if(validatelementexist(By.Id("mc")))
                    {
                        IWebElement elemgmtComp = driver.FindElement(By.Id("mc"));
                        SelectElement selmgmtComp = new SelectElement(elemgmtComp);
                        selmgmtComp.SelectByValue(ConfigurationSettings.AppSettings["PortfolioProfileManagementCompany"]);
                        //Thread.Sleep(10000);
                    }

                    if(validatelementexist(By.Id("mf")))
                    {
                        IWebElement elemgrfund = driver.FindElement(By.Id("mf"));
                        SelectElement selmgrfund = new SelectElement(elemgrfund);
                        selmgrfund.SelectByValue(ConfigurationSettings.AppSettings["PortfolioProfileManagerFund"]);
                        Thread.Sleep(5000);
                    }

                    //okButton

                    if(validatelementexist(By.Id("okButton")))
                    {
                        try
                        {
                            IWebElement elembtnok = driver.FindElement(By.Id("okButton"));
                            executor.ExecuteScript("arguments[0].click();", elembtnok);
                            Thread.Sleep(10000);
                        }
                        catch (Exception exok)
                        { }
                    }
                    
                                    
                    // Save buton -geneal Administration

             /*    driver.SwitchTo().Window(driver.WindowHandles.Last());
                   IWebElement Elefrmsave = driver.FindElement(By.Id("mp_buttons2"));
                   driver.SwitchTo().Frame(Elefrmsave);
                   IWebElement elegasave = driver.FindElement(By.Name("saveButton"));
                   executor.ExecuteScript("arguments[0].click();", elegasave);
                   objbase.wait(); */
                        
                  /*  try
                    {

                        // Fund Information -  Due Diligence

                         driver.SwitchTo().Window(driver.WindowHandles.Last());
                         if(validatelementexist(By.Id("mp_navigator")))
                         {
                             IWebElement frmNavigatorforsubmenu = driver.FindElement(By.Id("mp_navigator"));
                             driver.SwitchTo().Frame(frmNavigatorforsubmenu);
                         }
                       // IWebElement eletbllayout = driver.FindElement(By.Id("layout"));

                        // Found Information - Due Diligence

                     /*   var DueDiligence = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Due Diligence')]"));
                        executor.ExecuteScript("arguments[0].click();", DueDiligence);
                        Thread.Sleep(5000);

                        // Fund Information - Web Logon

                        var WebLogon = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Web Logon')]"));
                        executor.ExecuteScript("arguments[0].click();", WebLogon);
                        Thread.Sleep(5000);

                        // Fund Informarmation - Broker
                                              
                        var Broker = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Brokers')]"));
                        executor.ExecuteScript("arguments[0].click();", Broker);
                        Thread.Sleep(5000);

                       // Manager Network

                        var MgrNetWork = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Manager Network')]"));
                        executor.ExecuteScript("arguments[0].click();", MgrNetWork);
                        Thread.Sleep(5000);

                        // Employment History

                        var EmpHistory = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Employment History')]"));
                        executor.ExecuteScript("arguments[0].click();", EmpHistory);
                        Thread.Sleep(5000);
                        
                        //Education History

                        var EduHistory = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Education History')]"));
                        executor.ExecuteScript("arguments[0].click();", EduHistory);
                        Thread.Sleep(5000);

                        //Certifications

                        var elecertificate = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Certifications')]"));
                        executor.ExecuteScript("arguments[0].click();", elecertificate);
                        Thread.Sleep(5000);

                        //Strategy Classifications

                        var elestrtgyclassification = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Strategy Classifications')]"));
                        executor.ExecuteScript("arguments[0].click();", elestrtgyclassification);
                        Thread.Sleep(5000);

                        //Share Class Mapping

                        var elesharecls = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Share Class Mapping')]"));
                        executor.ExecuteScript("arguments[0].click();", elesharecls);
                        Thread.Sleep(5000);

                        //Approvals

                        var eleapproval = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Approvals')]"));
                        executor.ExecuteScript("arguments[0].click();", eleapproval);
                        Thread.Sleep(5000);

                        //Manager Status - Investment

                        var elemgrstatus = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Manager Status - Investment')]"));
                        executor.ExecuteScript("arguments[0].click();", elemgrstatus);
                        Thread.Sleep(5000);

                        //Manager Status - Operation

                        // Fund level Administration - Manager status operation

                        var elemgrstatusoperation = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Manager Status - Operation')]"));
                        executor.ExecuteScript("arguments[0].click();", elemgrstatusoperation);
                        Thread.Sleep(5000);

                        //Manager Fund Group

                        var elemgrFundgrp = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Manager Fund Group')]"));
                        executor.ExecuteScript("arguments[0].click();", elemgrFundgrp);
                        Thread.Sleep(5000);

                        //Historical Simulation Return Series

                        var elemhissimulationreturn = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Historical Simulation Return Series')]"));
                        executor.ExecuteScript("arguments[0].click();", elemhissimulationreturn);
                        Thread.Sleep(5000);

                        // Principals' Investment

                     //* var elemprinInvestment = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(), \"Principals' Investment\")]"));
                     // executor.ExecuteScript("arguments[0].click();", elemprinInvestment);
                     // Thread.Sleep(5000);

                        // Related Documents

                        var elemrelatedocs = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Related Documents')]"));
                        executor.ExecuteScript("arguments[0].click();", elemrelatedocs);
                      

                        // Miscellaneous / Other Information

                        var elemisotherinfo = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Miscellaneous / Other Information')]"));
                        executor.ExecuteScript("arguments[0].click();", elemisotherinfo);
                        Thread.Sleep(5000);

                        //  Confidentiality Obligations

                        var elemconfiobligations = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Confidentiality Obligations')]"));
                        executor.ExecuteScript("arguments[0].click();", elemconfiobligations);
                        Thread.Sleep(5000); */


                        //  Investment operation - Legal Profile
                                                
                   /*    var elemLegalProfile = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Legal Profile')]"));
                        executor.ExecuteScript("arguments[0].click();", elemLegalProfile);
                        objbase.waitformanagerProfile();*/
                       

                        // Fund Level Administration - Manager Status Investment

                /*        var elemManagerStatusInvestment = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Manager Status - Investment')]"));
                        executor.ExecuteScript("arguments[0].click();", elemManagerStatusInvestment);
                        objbase.waitformanagerProfile();
                        driver.Quit(); 


                        //Athena Reports - Reports Menu
                                           
                      
                        driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                        Thread.Sleep(3000);
                        IWebElement elefrmreports = driver.FindElement(By.Id("menu"));
                        driver.SwitchTo().Frame(elefrmreports);
                        IWebElement elementmenuReport = driver.FindElement(By.LinkText("Reports Menu"));
                        executor.ExecuteScript("arguments[0].click();", elementmenuReport);
                        Thread.Sleep(3000);                                      
                        
                    }
                    catch (Exception exDuediligence)
                    {
                        Console.WriteLine("Excecption Due Diligence:"+ exDuediligence.Message.ToString());
                    }

                  //  DriverClose();
                                                                 
                }
                       
            catch (WebDriverException ex)
            {
                Console.WriteLine("Web Driver Exception: " + ex.Message.ToString());

            }

            

        }*/

     
  //  }
//}