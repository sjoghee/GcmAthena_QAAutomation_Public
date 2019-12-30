using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

namespace AutomatedTest_Athena
{
  
    [TestClass]
    public  class PortfolioProfile
    {

       AthenaBase objbase = new AthenaBase();
       IWebDriver driver;
        
       [TestMethod]
       public void ValidatePortfolioProfile()
       {
           try
           {
               driver = objbase.DriverInitialization();
               driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
               driver.Manage().Window.Maximize();
               objbase.waitforPageload();
               IWebElement elefrmportfolioprofile = driver.FindElement(By.Id("menu"));
               driver.SwitchTo().Frame(elefrmportfolioprofile);
               IWebElement elePorfoliomenu = driver.FindElement(By.LinkText("Portfolio Menu"));
               IJavaScriptExecutor portfolioexecutor = (IJavaScriptExecutor)driver;
               portfolioexecutor.ExecuteScript("arguments[0].click();", elePorfoliomenu);
               objbase.waitforPageload();

             
               bool PortfolioProfillinkexists = objbase.validatelementexist(By.LinkText("Portfolio Profile"));
               if(PortfolioProfillinkexists)
               {
                   IWebElement eleporfolioprofile = driver.FindElement(By.LinkText("Portfolio Profile"));
                   portfolioexecutor.ExecuteScript("arguments[0].click();", eleporfolioprofile);
                   objbase.waitforPageload();
               }

               driver.SwitchTo().Window(driver.WindowHandles.Last());
               bool ppbuttonexists = objbase.validatelementexist(By.Id("pp_buttons1"));

               if(ppbuttonexists)
               {

                   IWebElement elemfrmselectportfolio = driver.FindElement(By.Id("pp_buttons1"));
                   driver.SwitchTo().Frame(elemfrmselectportfolio);
               }

               bool selectportfoliobuttonexits = objbase.validatelementexist(By.Name("selectPortfolioButton"));

               if(selectportfoliobuttonexits)
               {

                   IWebElement elebtnselecportfolio = driver.FindElement(By.Name("selectPortfolioButton"));
                   try
                   {
                       portfolioexecutor.ExecuteScript("arguments[0].click();", elebtnselecportfolio);
                       objbase.waitforPortfolioProfilePageload();
                   }
                   catch (Exception exseleportfolio)
                   { }

               }

               driver.SwitchTo().Window(driver.WindowHandles.Last());
               objbase.waitforPageload();
               bool selectportfolioexits = objbase.validatelementexist(By.Id("selectPortfolio"));
               if(selectportfolioexits)
               {
                   IWebElement frmselectPortfolios = driver.FindElement(By.Id("selectPortfolio"));
                   driver.SwitchTo().Frame(frmselectPortfolios);
                   IWebElement eleselPorfolio = driver.FindElement(By.Id("pp"));
                   SelectElement selectportfolio = new SelectElement(eleselPorfolio);
                   selectportfolio.SelectByValue(ConfigurationSettings.AppSettings["PortfolioProfile_Portfolio"]);
                   objbase.waitforPortfolioProfilePageload();
               }

               // Portfolio profile - ok 
               bool okbuttonexists = objbase.validatelementexist(By.Name("okButton"));

               if(okbuttonexists)
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

               driver.SwitchTo().Window(driver.WindowHandles.Last());
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

               var InvestableCashComponentsSettings = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Investable Cash Components Settings')]"));
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

             /*  var TradeExecutionDetails = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Trade Execution Details')]"));
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

               var BankSummaryCovenants = driver.FindElement(By.XPath("//span[contains(@class,'mp_td_text_ptr')]  [contains(text(),'Bank Summary Covenants')]"));
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
               Thread.Sleep(5000);*/
               objbase.driverclose();

           }
           catch(WebDriverException wx)
           {
               Console.WriteLine("Portfolio Profile Exception:" + wx.Message.ToString());
               objbase.driverclose();
           }

       }
    }
}
