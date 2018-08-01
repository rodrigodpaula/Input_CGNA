using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Input_CGNA._driver;
using Input_CGNA._robot;
using Input_CGNA._input;
using OpenQA.Selenium;

namespace Input_CGNA
{
    class Processa_CGNA
    {
        IWebDriver Driver;
        public Processa_CGNA()
        {
           InitDRIVER processa = new InitDRIVER();
           Driver = processa.Driver;
            
        }
        
    }
}
