using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test1.TestCases
{
    class Page1
    {
        private static IWebDriver webdriver;

       internal static object Driver;
        private object window;

        [Test]
        public void Login()
        {
            
            webdriver = new ChromeDriver();
            webdriver.Url = "https://www.ultimateqa.com/complicated-page/";

            webdriver.Manage().Window.Maximize();

            Thread.Sleep(100);

            //scroll the page down
            ((JavascriptExecutor)webdriver).executeScript(window.scrollBy(200, 300));

                     //Enter Form1 

            //Enter Name
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_name_0"]")).SendKeys("testuser1");

            //Enter  Email
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_email_0"]")).SendKeys("test1@gmail.com");

            //Enter Message
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_message_0"]")).SendKeys("message1");

            //Enter Addition Number
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_0"]/div[2]/form/div/div/p/input"]")).SendKeys("21");

            //Click on Submit buttton
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_0"]/div[2]/form/div/button"]")).Click();

            //scroll the page down
            ((JavascriptExecutor)webdriver).executeScript(window.scrollBy(200, 300));

            //Enter user name
            webdriver.FindElement(By.XPath("//*[@id="user_login_5d27b62d1b8a6"]")).SendKeys("testuser1username");
            
            //Enter Password
            webdriver.FindElement(By.XPath("//*[@id="user_pass_5d27b62d1b8a6"]")).SendKeys("test1pass");

            //Click on Login button
            webdriver.FindElement(By.XPath("//*[@id="et - boc"]/div/div/div[7]/div[2]/div[2]/div[2]/form/p[4]/button")).Click();

            //  string title = driver.FindElement(By.XPath(".//*[@id='main-content']/div/h1/div")).Text;
            //  Assert.That(title, Is.EqualTo("Ultimate QA"));

                     //Enter Form2

            //Enter Name
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_name_1"]")).SendKeys("testuser2");

            //Enter  Email
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_email_1"]")).SendKeys("test2@gmail.com");

            //Enter Message
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_message_1"]")).SendKeys("message2");

            //Enter Addition Number
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_1"]/div[2]/form/div/div/p/input"]")).SendKeys("21");

            //Click on Submit buttton
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_1"]/div[2]/form/div/button"))).Click();

            //scroll the page down
            ((JavascriptExecutor)webdriver).executeScript(window.scrollBy(200, 300));

            //Enter user name
            webdriver.FindElement(By.XPath("//*[@id="user_login_5d27c68aba1b8"]")).SendKeys("testuser2username");

            //Enter Password
            webdriver.FindElement(By.XPath("//*[@id="user_pass_5d27c68aba1b8"]")).SendKeys("test2pass");

            //Click on Login button
            webdriver.FindElement(By.XPath("//*[@id="et-boc"]/div/div/div[7]/div[2]/div[5]/div[2]/form/p[4]/button"]")).Click();


                        // Enter Form3

            //Enter Name
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_name_2"]")).SendKeys("testuser3");

            //Enter  Email
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_email_2"]")).SendKeys("test3");

            //Enter Message
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_message_2"]")).SendKeys("message3");

            //Enter Addition Number
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_2"]/div[2]/form/div/div/p/input")).SendKeys("13");

            //Click on Submit buttton
            webdriver.FindElement(By.XPath("//*[@id="et_pb_contact_form_2"]/div[2]/form/div/button")).Click();
        }
    }
}
