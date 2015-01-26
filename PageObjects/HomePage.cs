using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MyWebDriverTest
{
  public class HomePage
  {
    private IWebDriver driver;

    [FindsBy(How = How.LinkText, Using = "Home")]
    private IWebElement MenuHome;

    [FindsBy(How = How.LinkText, Using = "Contact")]
    private IWebElement MenuContact;

    [FindsBy(How = How.LinkText, Using = "Resources")]
    private IWebElement MenuResources;

    public HomePage(IWebElement driver)
    {
        this.driver = driver;
        PageFactory.InitElements(driver, this);
    }
      
      
      
    public HomePage UserLogin(string user, string pass)
    {
        tbxUsername.SendKeys(user);
        tbxPassword.SendKeys(pass);
        btnLogin.Click();

        return new HomePage(driver);
    }
  }
}
