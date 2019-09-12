using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumZadatak
{
    class GetMethods
    {

        public static string GetText(IWebDriver driver, string element)
        {
            return driver.FindElement(By.XPath(element)).Text;      //xpath je u element-u
        }

        public static void KorisnickoImeLozinka(IWebDriver driver, string element)
        {
            bool TextboxEnabled = driver.FindElement(By.Id(element)).Enabled;
            string TextboxEmpty = driver.FindElement(By.Id(element)).Text;
            

            if (element == "Username")
            {
                if (TextboxEnabled == true && TextboxEmpty == "")
                {
                    Console.WriteLine("“Početna” is displayed when application is started \n");
                    Console.WriteLine("“Korisničko ime” textbox is enabled and empty \n");
                }
                else
                    Console.WriteLine("Error: Login screen shall have “Korisničko ime” textbox. It is not enabled or empty \n");
            }

            if (element == "password")
            {
                if (TextboxEnabled == true && TextboxEmpty == "")
                {

                    Console.WriteLine(" “Lozinka” textbox is enabled and empty. \n");
                }
                else
                    Console.WriteLine("Error: Login screen shall have “Lozinka” textbox. It is not enabled or empty \n");
            }

           
                
                                 
        }

        public static void LoginButton(IWebDriver driver, string element)
        {
            bool buttonEnabled = driver.FindElement(By.Name(element)).Enabled;

            if (buttonEnabled == true)
            {
                Console.WriteLine(" “Prijava” button is enabled \n");
            }
            else
                Console.WriteLine(" “Prijava” button is disabled \n ");
        }
    }
}
