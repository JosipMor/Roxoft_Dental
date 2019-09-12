using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumZadatak
{
    public class Testing
    {
        public IWebDriver driver { get; set; }


        [SetUp]
        public void Initialise()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.plusplaner.com/account/login");
            Console.WriteLine("Opend URL");

        }

        [Test]
        public void TestANula()
        {
            GetMethods.KorisnickoImeLozinka(driver, "Username");
            GetMethods.KorisnickoImeLozinka(driver, "password");
            GetMethods.LoginButton(driver, "action");

        }

        [Test]

        public void TestBJedan()
        {
            SetMethods.Click(driver, "action", "Name");
            Console.WriteLine("Allert message: " + GetMethods.GetText(driver, "/ html / body / div[1] / div / div / div / div / div / div / div / div / ul"));
            
        }

        [Test]
        public void TestCDva()
        {
            SetMethods.KorisnickoIme_Lozinka(driver, "Username", "KorisnickoIme ", "Id");
            TestBJedan();


        }

        [Test]
        public void TestDTri()
        {
            SetMethods.KorisnickoIme_Lozinka(driver, "password", "Lozinka", "Id");
            TestBJedan();

        }

        [Test]
        public void TestECetiri()
        {
            SetMethods.KorisnickoImeILozinka(driver, "Username", "password", "KorisnickoIme", "Lozinka", "Id");
            TestBJedan();

        }

        [Test]
        public void TestFPet()
        {
            SetMethods.KorisnickoImeILozinka(driver, "Username", "password", "tester12", "Password1!", "Id");
            Console.WriteLine("login succeeded");

        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
