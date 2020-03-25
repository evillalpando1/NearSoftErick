using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NearSoft_interview
{
    class POM : Program
    {
        private IWebDriver _driver;

        public POM(IWebDriver driver)
        {
            this._driver = driver;
        }


        // creating Objects to store locators
        private static readonly string Vuelos_Button = "//button[@id='tab-flight-tab-hp']//span[@class='uitk-icon uitk-icon-flights']";
        private static readonly string Origen_TxtField = "flight-origin-hp-flight";
        private static readonly string Destino_TxtField = "flight-destination-hp-flight";
        public string Salida_TxtField = "flight-departing-hp-flight";
        public string Llegada_TxtField = "flight-returning-hp-flight";
        public string Buscar_Button = "//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']";
        public string Price_Container = "flightModuleList";
        private static readonly string Order_Dropdown = "sortDropdown";
        

        //Defining properties

        public IWebElement VuelosBtn => _driver.FindElement(By.XPath(Vuelos_Button));
        public IWebElement OrigenTxt => _driver.FindElement(By.Id(Origen_TxtField));
        public IWebElement DestinoTxt => _driver.FindElement(By.Id(Destino_TxtField));
        public IWebElement SalidaTxt => _driver.FindElement(By.Id(Salida_TxtField));
        public IWebElement LlegadaTxt => _driver.FindElement(By.Id(Llegada_TxtField));
        public IWebElement BuscarBtn => _driver.FindElement(By.XPath(Buscar_Button));
        public IWebElement PriceContainer => _driver.FindElement(By.Id(Price_Container));
        public IWebElement OrderList => _driver.FindElement(By.Id(Order_Dropdown));

        //Interacting with the objects

        public IWebElement GetVuelosButton()
        {
            return VuelosBtn;
        }
        public void SendText(string Strtext)
        {
            //PropertyName.SendKeys( Strtext);

        }
        public void ClickOnVuleosBtn()
        {
            VuelosBtn.Click();
        }
        public void ClickOnOrigenTXT()
        {
            OrigenTxt.Click();
        }
        public void OrigenSendKeys(string strOrigen)
        {
            OrigenTxt.SendKeys(strOrigen);

        }
        public void DestinoSendKeys(string strDestino)
        {
            DestinoTxt.SendKeys(strDestino);

        }

        public void EnterFechaSalida(string srtFechaSalida)
        {
            SalidaTxt.SendKeys(srtFechaSalida);
        }
        public void EnterFechaLlegada(string srtFechaLlegada)
        {
            LlegadaTxt.SendKeys(srtFechaLlegada);
        }
        public void ClickBuscarBtn()
        {
            BuscarBtn.Click();
        }
        public IWebElement GetPriceContainer()
        {
            return PriceContainer;
        }
        public void SelectOrderDropDown(string option)
        {
            var selectElement = new SelectElement(OrderList);
            selectElement.SelectByValue(option);
        }


        //Creating the list to sort

        public string fligthXpath = "/html[1]/body[1]/div[2]/div[12]/section[1]/div[1]/div[11]/ul[1]/li[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/span[1]";
        public IWebElement Fligth => _driver.FindElement(By.XPath(fligthXpath));

    }

    }


