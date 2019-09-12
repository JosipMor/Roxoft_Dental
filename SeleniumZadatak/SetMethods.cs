using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumZadatak
{
    public static class SetMethods
    {

        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
        }

        public static void KorisnickoIme_Lozinka(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);

        }

        public static void KorisnickoImeILozinka(IWebDriver driver, string element1, string element2, string value1, string value2, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element1)).SendKeys(value1);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element1)).SendKeys(value1);
            if (elementtype == "Id")
                driver.FindElement(By.Id(element2)).SendKeys(value2);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element2)).SendKeys(value2);
            
        }

       
    }
}
