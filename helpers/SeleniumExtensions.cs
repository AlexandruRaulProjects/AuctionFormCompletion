using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA.helpers
{
    
    public static class SeleniumExtensions
    {
        private const string Url = "https://app.traydez.online";

        public static void Login(this IWebDriver driver, WebDriverWait wait, string username, string password)
        {
            Console.WriteLine($"Logging in as {username}...");

            driver.Navigate().GoToUrl(Url);

            var loginButton = wait.Until(d => d.FindElement(By.XPath("//button[text()='Login']")));
            loginButton.Click();

            Thread.Sleep(5000);

            var userField = wait.Until(d => d.FindElement(By.Id("Input_Username")));

            userField.Clear();
            userField.SendKeys(username);
            Console.WriteLine("username: ", username);
            Thread.Sleep(5000);

            var passField = driver.FindElement(By.Id("Input_Password"));
            passField.Clear();
            passField.SendKeys(password);
            Console.WriteLine("password: ", password);
            Thread.Sleep(5000);

            var loginBtn = driver.FindElement(By.XPath("//button[@value='login']"));
            loginBtn.Click();

            Thread.Sleep(2000);
            Console.WriteLine("Login successful (assumed).");
        }
        public static void FillField(this IWebDriver driver, By selector, string value)
        {
            var element = driver.FindElement(selector);
            
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            element.SendKeys(value);
        }
    }
}