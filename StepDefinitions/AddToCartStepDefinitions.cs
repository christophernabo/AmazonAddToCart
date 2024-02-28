using AmazonAddToCart.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AmazonAddToCart.StepDefinitions
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        private IWebDriver driver;
        private HomePage homePage;
        private ResultPage resultPage;
        private CartPage cartPage;

        public AddToCartStepDefinitions()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            resultPage = new ResultPage(driver);
            cartPage = new CartPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        [Test]
        [Given(@"User navigate to the Amazon website")]
        public void GivenUserNavigateToTheAmazonWebsite()
        {
            homePage.NavigateToHomePage();
        }

        [When(@"User searches for ""([^""]*)""")]
        public void WhenUserSearchesFor(string itemName)
        {
            homePage.SearchForItem(itemName);
            resultPage.ClickOnItem(itemName);
        }

        [When(@"User adds the item to my cart")]
        public void WhenUserAddsTheItemToMyCart()
        {
            resultPage.AddToCart();
        }

        [When(@"User navigates to the cart")]
        public void WhenUserNavigatesToTheCart()
        {
            resultPage.GoToCart();
        }

        [Then(@"User can validate that the correct item and amount are displayed for ""([^""]*)""")]
        public void ThenUserCanValidateThatTheCorrectItemAndAmountAreDisplayedFor(string itemName)
        {
            cartPage.ValidateItemAndPrice(itemName);
        }
    }
}
