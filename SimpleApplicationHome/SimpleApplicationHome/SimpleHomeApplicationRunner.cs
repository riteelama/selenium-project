using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SimpleApplication
{
    public class SimpleApplicationHomeClassRunner
    {
        public static void Main(string[] args)
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());

            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://daraz.com.np");

            IWebElement searchInput = driver.FindElement(By.CssSelector("#q"));

            searchInput.SendKeys("laptop");
            searchInput.SendKeys(Keys.Enter);

            driver.Quit();
        }
    }
}
