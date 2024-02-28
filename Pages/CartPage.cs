using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonAddToCart.Pages
{
    public class CartPage
    {
        private readonly IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool ValidateItemAndPrice(string itemName)
        {
            bool isItemPresent = driver.PageSource.Contains(itemName);
            bool isPriceCorrect = driver.PageSource.Contains("$71.00");

            if (isItemPresent && isPriceCorrect)
            {
                Console.WriteLine("Item and price are correct in the cart.");
                return true;
            }
            else
            {
                Console.WriteLine("Item or price is incorrect in the cart.");
                return false;
            }
        }
    }
}
