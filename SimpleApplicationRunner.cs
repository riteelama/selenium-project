
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SimpleApplication
{
    public class SimpleApplicationRunner
    {
        public static void Main(string[] args)
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());

            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://github.com/");

            IWebElement searchBox = driver.FindElement(By.CssSelector(".search-input") );
            searchBox.Click();

            IWebElement searchInput = driver.FindElement(By.CssSelector("#query-builder-test"));
            searchInput.SendKeys("selenium");
            searchInput.SendKeys(Keys.Enter);

            driver.Quit();
        }
    }
}
