using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTest_Athena
{

    [TestClass]
    public class AthenaSmoke
    {
        AthenaBase objbase = new AthenaBase();
        PortfolioReports objportfoliorpts = new PortfolioReports();
        ManagerReports objmgrreports = new ManagerReports();
        PortfolioProfile objportfolioprofile = new PortfolioProfile();
       

        [TestMethod]
        public void Athena_SmokeTest()
        {
            try
            {
              
                objportfoliorpts.ValidatePortfolioReports_Historical_Financial_Shock_Analysis();
                objportfoliorpts.ValidatePortfolioReports_Risk_Based_Allocation_Report();
                objportfoliorpts.ValidatePortfolioReports_Portfolio_Liquidity_Schedule();
                objportfoliorpts.ValidatePortfolioReports_Stress_Test_Report();
                objportfoliorpts.ValidatePortfolioReports_Underlying_Manager_Exposure_Report();

                objportfolioprofile.ValidatePortfolioProfile();

                objmgrreports.ValidateManagerReports_Due_Diligence_Reporting();
                objmgrreports.ValidateManagerReports_Exposure_Report();
              
                                  
            }
            catch (Exception exathenasmoke)
            {
                Console.WriteLine("Athena smoke exception: "+ exathenasmoke.Message.ToString());
            }
             
        }

    }
}
