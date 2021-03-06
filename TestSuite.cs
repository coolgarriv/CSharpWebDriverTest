using OpenQA.Selenium;
using NUnit.Framework;


namespace MyWebDriverTest
{
    [TestFixture]
    public class Class1
    {
        private IWebDriver driver;
        
        [Setup]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        
        [Test, Category("Test")]
        public void TestCase01()
        {
            driver.NavigateTo().URL("http://www.webdrivertips.com");
        }
        
        [Test]
        public void TestCase02()
        {
            driver.NavigateTo().URL("http://www.WebDriverTips.com");
        }
    }
}
