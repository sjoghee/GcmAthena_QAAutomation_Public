using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;
using System.Windows.Input;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

using AutoItX3Lib;

using Microsoft.VisualStudio.TestTools.UnitTesting;





namespace AutomatedTest_Athena
{
    [TestClass]
    public class ManagerReports
    {
        AthenaBase objbase = new AthenaBase();

        IWebDriver driver;

        // Manager Reporting - Manager Due Diligence Reporting

        [TestMethod]
        public void ValidateManagerReports_Due_Diligence_Reporting()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elmgrlink = driver.FindElement(By.LinkText("Manager Menu"));
                IJavaScriptExecutor Managerexecutor = (IJavaScriptExecutor)driver;
                Managerexecutor.ExecuteScript("arguments[0].click();", elmgrlink);
                objbase.waitforPageload();

                IWebElement elemmenumgrreports = driver.FindElement(By.LinkText("Manager Reports"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elemmenumgrreports);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                //objbase.waitforPageload();

                bool elelistresult = objbase.validatelementexist(By.Id("list"));

                if(elelistresult)
                {
                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elmexporesummarylink = driver.FindElement(By.LinkText("Manager Due Diligence Reporting"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", elmexporesummarylink);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    //  objbase.wait();

                }

                bool eleinvsmgrfundresult = objbase.validatelementexist(By.Id("Filters_SelectedInvestmentManagerId"));

                if(eleinvsmgrfundresult)
                {
                    IWebElement eleselInvestmentcompany = driver.FindElement(By.Id("Filters_SelectedInvestmentManagerId"));
                    SelectElement seleInvestmentCompany = new SelectElement(eleselInvestmentcompany);
                    seleInvestmentCompany.SelectByValue(ConfigurationSettings.AppSettings["MgrDueDiligence"]);
                    objbase.waitforPageload();
                }

                IWebElement eleportfoliofund = driver.FindElement(By.Id("AvailablePortfolioFunds"));
                SelectElement seleportfoliofund = new SelectElement(eleportfoliofund);
                seleportfoliofund.SelectByValue(ConfigurationSettings.AppSettings["MgrDueDiligencePortfolio"]);

                bool eleaddbtnresult = objbase.validatelementexist(By.Id("addPortfolioFund"));
                if(eleaddbtnresult)
                {

                    IWebElement eleaddbtn = driver.FindElement(By.Id("addPortfolioFund"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", eleaddbtn);
                }

                bool elebtnreportresult = objbase.validatelementexist(By.Id("btnView"));

                if(elebtnreportresult)
                {
                    IWebElement elebtnreport = driver.FindElement(By.Id("btnView"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", elebtnreport);
                    objbase.Waitformanagerreports();
                    
                AutoItX3 autox = new AutoItX3();
                autox.WinWaitActive("Do you want to open or save", "", 10);
                    autox.MouseClick("Open",320,703,1,-1);
               


               /* int autoitrunresult = autox.Run("http://athena-qat/ - Manager Due Diligence Reporting","",50);
              
                 int autointcountx =  autox.WinWaitActive("http://athena-qat/ - Manager Due Diligence Reporting","", 50);
                 int controlclickresponse =   autox.ControlClick("http://athena-qat/ - Manager Due Diligence Reporting", "", "DirectUIHWND1", "RIGHT", 1, 924,749);
                 autox.WinWait("http://athena-qat/ - Manager Due Diligence Reporting", "",50); 
               int controlfocus =   autox.Run("http://athena-qat/ - Manager Due Diligence Reporting","", "DirectUIHWND1");
               Console.WriteLine("Control focus window response" + controlfocus);
               int controlclick =   autox.ControlClick("http://athena-qat/ - Manager Due Diligence Reporting","","DirectUIHWND1", "RIGHT",1,-8,-8);
               Console.WriteLine("Control click window response" + controlclick);
               SikuliSharp sk = new SikuliSharp(); */
               

                }

            }
            catch (Exception exduediligence)
            {
                Console.WriteLine("Exception Message - Due_Diligence_Reporting: " + exduediligence.Message.ToString());
            }
        }

        // Manager Reporting  - Exposure report

        [TestMethod]
        public void ValidateManagerReports_Exposure_Report()
        {
            try
            {
                driver = objbase.DriverInitialization();
                driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                driver.Manage().Window.Maximize();
                objbase.waitforPageload();
                IWebElement elegrmenu = driver.FindElement(By.Id("menu"));
                driver.SwitchTo().Frame(elegrmenu);
                IWebElement elmgrlink = driver.FindElement(By.LinkText("Manager Menu"));
                IJavaScriptExecutor Managerexecutor = (IJavaScriptExecutor)driver;
                Managerexecutor.ExecuteScript("arguments[0].click();", elmgrlink);
                objbase.waitforPageload();

                IWebElement elemmenumgrreports = driver.FindElement(By.LinkText("Manager Reports"));
                Managerexecutor.ExecuteScript("arguments[0].click();", elemmenumgrreports);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                objbase.waitforPageload();

                bool elelistresult = objbase.validatelementexist(By.Id("list"));
                if(elelistresult)
                {

                    IWebElement frmlist = driver.FindElement(By.Id("list"));
                    driver.SwitchTo().Frame(frmlist);
                    IWebElement elmexporesummarylink = driver.FindElement(By.LinkText("Exposure Report"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", elmexporesummarylink);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    objbase.waitforPageload();
                }
                bool elefrmselectionresult = objbase.validatelementexist(By.Id("selection"));
                if(elefrmselectionresult)
                {

                    IWebElement frmselection = driver.FindElement(By.Id("selection"));
                    driver.SwitchTo().Frame(frmselection);
                    objbase.waitforPageload();
                    IWebElement eleconfig = driver.FindElement(By.Id("config"));
                    SelectElement selconfig = new SelectElement(eleconfig);
                    selconfig.SelectByValue(ConfigurationSettings.AppSettings["ExposureReportConfig"]);
                    objbase.waitforPageload();

                    IList<IWebElement> lstportfoliofund = driver.FindElements(By.XPath("//*[@id='rdoReportData']"));
                    lstportfoliofund[1].Click();
                    objbase.waitforPageload();
                }

                bool elemanagerportfoliofundresult = objbase.validatelementexist(By.Id("manager"));
                if(elemanagerportfoliofundresult)
                {
                    IWebElement elemanagerportfoliofund = driver.FindElement(By.Id("manager"));
                    bool managerdropdown = elemanagerportfoliofund.Enabled;
                    Console.WriteLine("Manager drown enabled" + managerdropdown);
                    SelectElement selmgr = new SelectElement(elemanagerportfoliofund);
                    selmgr.SelectByValue(ConfigurationSettings.AppSettings["ExposureReportPortfolioFund"]);
                    objbase.waitforPageload();
                }

                bool eleviewreportresult = objbase.validatelementexist(By.Id("btnViewRpt"));
                if(eleviewreportresult)
                {
                    IWebElement eleviewreport = driver.FindElement(By.Id("btnViewRpt"));
                    Managerexecutor.ExecuteScript("arguments[0].click();", eleviewreport);
                    objbase.Waitformanagerreports();
                   

                }

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
                System.Net.WebResponse response = request.GetResponse();*/

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message - Exposure_Report  " + ex.Message.ToString());
            }
        }
    }
    
}