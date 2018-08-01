using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Input_CGNA._robot
{
    class testaSite
    {
        private bool status = false;
        private IWebDriver driver;

        public testaSite(IWebDriver drv)
        {
            driver = drv;
        }
        public bool Status { get { return status = testSITE(); } }
        private bool testSITE()
        {
            bool logOK = true;
            try
            {
                driver.Navigate().GoToUrl("https://sigma.cgna.gov.br/air/login.html");
                if (driver.Title.ToString() == "Session Lockout") // testa mais de uma conex ao mesmo tempo
                {
                    logOK = false;
                }
            }
            catch
            {
                logOK = false;
            }
            return logOK;
        }
    }
}
