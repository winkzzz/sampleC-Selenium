using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumTest;

public class SeleniumTest
{
    IWebDriver driver = new ChromeDriver();

    [Test]
    [Category("Selenium")]
    public void SampleTest()
    {
        
        driver.Navigate().GoToUrl("https://www.google.com/");

        IWebElement inputHere = driver.FindElement(By.XPath("//textarea"));
        inputHere.SendKeys("test" + Keys.Enter);

        System.Threading.Thread.Sleep(500);
        driver.Quit();
    }

    [Test]
    public void LoginTest()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        IWebElement username = driver.FindElement(By.Id("user-name"));
        IWebElement password = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("login-button"));

        username.SendKeys("standard_user");
        password.SendKeys("secret_sauce");
        loginButton.Click();
        System.Threading.Thread.Sleep(500);
        //string productHeader = driver.FindElement(By.XPath("//*[contains(text(), 'Products')]")).Text;

        //Assert.That(productHeader, Is.EqualTo"Products");
        
        IWebElement fleeceJacket = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        fleeceJacket.Click();
        System.Threading.Thread.Sleep(500);

        int totalProduct = 5;
        Random random = new Random();
        int randomProductIndex = random.Next(1, totalProduct + 1);

        string productXpath = $"(//*[contains(text(), 'Add to cart')])[{randomProductIndex}]";
        IWebElement productChoosen = driver.FindElement(By.XPath(productXpath));
        productChoosen.Click();
        System.Threading.Thread.Sleep(1000);

        IWebElement shoppingCart = driver.FindElement(By.XPath("//*[contains(@class, 'shopping_cart_link')]"));
        shoppingCart.Click();
        System.Threading.Thread.Sleep(1000);
    }
}
