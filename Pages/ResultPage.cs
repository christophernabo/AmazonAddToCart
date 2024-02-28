using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AmazonAddToCart.Pages
{
    public class ResultPage
    {
        private readonly IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnItem(string itemName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement itemImage = wait.Until(driver => driver.FindElement(By.XPath($"//img[@alt='{itemName}']")));
            Thread.Sleep(1000);
            itemImage.Click();
            Thread.Sleep(1000);
        }

        public void AddToCart()
        {
            driver.FindElement(By.ClassName("a-button-stack")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("a-autoid-2-offer-1")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("aod-close")).Click();
            Thread.Sleep(1000);
        }

        public void GoToCart()
        {
            driver.FindElement(By.XPath("//*[@id=\"nav-cart\"]")).Click();
            Thread.Sleep(1000);
        }
    }
}
