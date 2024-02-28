using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AmazonAddToCart.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("captchacharacters")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div/div/form/div[2]/div")).Click();
            Thread.Sleep(1000);
        }

        public void SearchForItem(string itemName)
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(itemName);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            Thread.Sleep(1000);
        }
    }
}
