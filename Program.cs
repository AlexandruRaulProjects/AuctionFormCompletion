using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers; // Ensure you have DotNetSeleniumExtras.WaitHelpers installed
using System;
using QA.helpers; // IMPORT YOUR HELPERS FOLDER

namespace QA
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            // options.AddArgument("--headless"); 

            using (var driver = new ChromeDriver(options))
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                driver.Login(wait, "Alice", "Pass123$");

                var createPage = new CreateAuctionPage(driver);

                var auctions = AuctionData.GetAll(); 
                
                string createUrl = "https://app.traydez.online/auctions/create";
                driver.Navigate().GoToUrl(createUrl);

                int count = 1;
                foreach (var auction in auctions)
                {
                    try
                    {
                        Console.Write($"[{count}/{auctions.Count}] Adding {auction.Item.Make} {auction.Item.Model}... ");

                        if (!driver.Url.Contains("/auctions/create"))
                        {
                            driver.Navigate().GoToUrl(createUrl);
                        }

                        createPage.FillAndSubmit(auction);
                        Thread.Sleep(5000);

                        Console.WriteLine("Done.");
                        count++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nFAILED: {ex.Message}");
                    }
                }

                Console.WriteLine("Automation Complete!");
                Console.ReadLine();
            }
        }
    }

    public class CreateAuctionPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Selectors
        private readonly By _makeInput = By.Name("make");
        private readonly By _modelInput = By.Name("model");
        private readonly By _colorInput = By.Name("color");
        private readonly By _yearInput = By.Name("year");
        private readonly By _mileageInput = By.Name("mileage");
        private readonly By _imageUrlInput = By.Name("imageUrl"); 
        private readonly By _reservePriceInput = By.Name("reservePrice");
        private readonly By _submitButton = By.XPath("//button[text()='Submit']");
        private readonly By _dateInput = By.CssSelector("input[placeholder='Auction end date/time']");

        public CreateAuctionPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void FillAndSubmit(Auction auction)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(_makeInput));

            _driver.FillField(_makeInput, auction.Item.Make);
            _driver.FillField(_modelInput, auction.Item.Model);
            _driver.FillField(_colorInput, auction.Item.Color);
            _driver.FillField(_yearInput, auction.Item.Year.ToString());
            _driver.FillField(_mileageInput, auction.Item.Mileage.ToString());
            _driver.FillField(_imageUrlInput, auction.Item.ImageUrl);
            _driver.FillField(_reservePriceInput, auction.ReservePrice.ToString());
            _driver.FillField(_dateInput, auction.AuctionEnd.ToString("dd MMMM yyyy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture));
            _driver.SwitchTo().ActiveElement().SendKeys(Keys.Escape);


            _driver.FindElement(_submitButton).Click();
            
            Thread.Sleep(5000); 
        }
    }
}