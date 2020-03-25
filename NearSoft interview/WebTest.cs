using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NearSoft_interview
{
    class WebTest:Program
    {
        public POM LoginPage;

        [SetUp]

        public void SetUpTc()
        {
            SetUp();
            LoginPage = new POM(driver);


        }

        [Test]

        public void FirstTestCasePositive()
        {
            Utils.AssertIsPresent(LoginPage.GetVuelosButton());
            LoginPage.ClickOnVuleosBtn();
            LoginPage.ClickOnVuleosBtn();
            LoginPage.OrigenSendKeys("MID");
            LoginPage.DestinoSendKeys("MEX");
            LoginPage.EnterFechaSalida("01/04/2020");//dd/mm/aaaa
            LoginPage.EnterFechaLlegada("10/04/2020");
            LoginPage.ClickBuscarBtn();
            //Add  explicit wait instead assert
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(LoginPage.PriceContainer.Displayed);
            Utils.AssertIsPresent(LoginPage.GetPriceContainer());

            //Getting prices 

            string text = driver.FindElements(By.XPath("//div[@class='primary-content   custom-primary-padding']/span[@class='full-bold no-wrap']"));
            string price = text.Split('$')[1];
            price = price.Replace(",", "");
            int fprice = Int32.Parse(price);
            //creating list
            List<int> Prices = new List<int>();
            Prices.Add(fprice);
            Prices.Sort();
            Prices.Reverse();

            LoginPage.SelectOrderDropDown("price:desc");

        }

        [TearDown]
        public void closeBrowser()
        {
            Exit();


        }
    }
}

