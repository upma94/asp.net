using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    class FunctionalTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }


        [Test]
        public void ValidUserCredential()
        {

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            option.AddArgument("--window-size=1920,1080");
            option.AddArgument("--disable-extensions");
            option.AddArgument("--proxy-server='direct://'");
            option.AddArgument("--proxy-bypass-list=*");
            option.AddArgument("--start-maximized");
            option.AddArgument("--disable-gpu");
            option.AddArgument("--disable-dev-shm-usage");
            option.AddArgument("--no-sandbox");
            option.AddArgument("--ignore-certificate-errors");
           // driver = new ChromeDriver(ChromeDriverManager(84.0.4147.105).install());
            driver = new ChromeDriver(option);
            //objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            
            //var chromeDriverService = ChromeDriverService.CreateDefaultService();
            //chromeDriverService.HideCommandPromptWindow = true;    // This is to hidden the console.
            //ChromeDriver driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
            driver.Navigate().GoToUrl("http://localhost:51471/Login/Index");

            Thread.Sleep(100);

            //driver.FindElement(By.XPath(".//*[@Name='email']")).SendKeys("admin@infosys.com");
            //driver.FindElement(By.XPath(".//*[@Name='Password']")).SendKeys("admin");
            //driver.FindElement(By.Name("email")).SendKeys("admin@infosys.com");
            //driver.FindElement(By.Name("Password")).SendKeys("admin");

            //driver.FindElement(By.XPath(".//*[@value='SignIn']")).Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(".//*[@Name='A']")).SendKeys("200");
            //driver.FindElement(By.XPath(".//*[@Name='B']")).SendKeys("100");
            //driver.FindElement(By.Name("A")).SendKeys("200");
            //driver.FindElement(By.Name("B")).SendKeys("100");
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath(".//*[@value='add']")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath(".//*[@value='sub']")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath(".//*[@value='mul']")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath(".//*[@value='div']")).Click();
            
        }

        [Test]
       public void InValidUserCredential()
        {
            //driver.Manage().Timeouts().ImplicitWait(5);
            //ChromeOptions option = new ChromeOptions();
            //option.AddArgument("--headless");
            //driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl("http://localhost:51471/Login/Index");
            Thread.Sleep(200);
            //driver.FindElement(By.Name("email")).SendKeys("admin");
            Thread.Sleep(200);
            //driver.FindElement(By.Name("Password")).SendKeys("admin");
            Thread.Sleep(200);
            //driver.FindElement(By.XPath(".//*[@value='SignIn']")).Click();
        }

        [TearDown]
        public void CloseBrowser()
        {

            Thread.Sleep(500);
            driver.Close();
        }
    }
}
