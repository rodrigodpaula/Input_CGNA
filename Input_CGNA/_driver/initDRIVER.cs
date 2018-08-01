using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Runtime.InteropServices;

namespace Input_CGNA._driver
{
    class InitDRIVER
    {
        private const int SW_SHOWNORMAL = 1; // - normal e maxi mantidos caso necessite.
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private List<Process> procInt = new List<Process>();
        [DllImport("user32")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private string pgLogin = "https://sigma.cgna.gov.br/";

        public InitDRIVER()
        {
        }
        public IWebDriver Driver { get { return initDriver(); } } 
        public void EndDriver()
        {
            endDriver();
        }
        private IWebDriver initDriver()
        {
            ChromeDriverService driverSvc = ChromeDriverService.CreateDefaultService();
            ChromeOptions chromeOptions = new ChromeOptions();
            //var chromeDriverService = ChromeDriverService.CreateDefaultService();
            string idCHRsec = chromeOptions.BrowserName;
            chromeOptions.AddUserProfilePreference("--homepage", pgLogin);
            chromeOptions.AddUserProfilePreference("--homepage_is_newtabpage", true);
            driverSvc.Port = 9030;

            IWebDriver chrm = new ChromeDriver(driverSvc, chromeOptions, TimeSpan.FromSeconds(60));
            //minimizar janela do driver
            Process[] proc_localAll = Process.GetProcesses();
            foreach (Process process in proc_localAll)
            {
                string procN = string.Format(process.MainWindowTitle);
                string title = "data:,";
                if ((process.ProcessName == "chromedriver") | (process.MainWindowTitle.IndexOf(title) > -1))
                {
                    procInt.Add(process);
                    ShowWindow(process.MainWindowHandle, SW_SHOWMINIMIZED);
                }
            }
            return chrm;
        }
        private void endDriver()
        {
            try
            {
                Thread.Sleep(7000);
                try
                {
                    //colocar condicional de logout
                    //driver.FindElement(By.XPath("//a[contains(@href,\"javascript:void(0)\")]")).Click();
                }
                catch (Exception ex) { }// { new geraLOG(string.Format("Erro ao encerrar seção DIIO - Msg {0}", ex)); }
                Driver.Close();
                Driver.Quit();
                Driver.Dispose();
                //Process[] localAll = Process.GetProcesses();
                try
                {
                    foreach (Process p in procInt)
                    {
                        p.Kill();
                    }
                }
                catch { }
            }
            catch (Exception ex) { } // { new geraLOG(string.Format("Erro ao encerrar driver/navegador - Msg {0}", ex)); }
        }
    }

}

