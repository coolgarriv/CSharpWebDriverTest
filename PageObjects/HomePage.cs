using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MyWebDriverTest
{
  public class HomePage
  {
    private IWebDriver driver;

    [FindsBy(How = How.Id, Using = "tbxUsername")]
    private IWebElement tbxUsername;

    [FindsBy(How = How.Id, Using = "tbxPassword")]
    private IWebElement tbxPassword;

    [FindsBy(How = How.Id, Using = "btnLogin")]
    private IWebElement btnLogin;

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