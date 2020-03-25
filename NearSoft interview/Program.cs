using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NearSoft_interview
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static IWebDriver driver;
        public static string FirstUrl = ConfigurationManager.AppSettings.Get("BaseUrl");

        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = FirstUrl;
        }

        public static void Exit()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
