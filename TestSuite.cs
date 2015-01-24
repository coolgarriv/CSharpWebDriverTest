using OpenQA.Selenium;
using NUnit.Framework;


namespace MyWebDriverTest
{
    [TestFixture]
    public class Class1
    {
        private IWebDriver driver;
        
        [Setup]
        publiv void Setup()
        {
            driver = new FirefoxDriver();
            
        }
        [Test]
        public void TestCase01()
        {
            driver.NavigateTo().URL("http://www.webdrivertips.com");
            
        }
    }
}