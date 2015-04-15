using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MyWebDriverTest
{
  public class HomePage
  {
    private IWebDriver _driver;

    [FindsBy(How = How.LinkText, Using = "Home")]
    private IWebElement MenuHome;
    [FindsBy(How = How.LinkText, Using = "Contact")]
    private IWebElement MenuContact;
    [FindsBy(How = How.LinkText, Using = "Resources")]
    private IWebElement MenuResources;
	
	
	/// <summary>
	/// Class Constructor
	/// </summary>
	/// <param name="driver">WebDriver Object</param>
    public HomePage(IWebElement driver)
    {
        this._driver = driver;
        PageFactory.InitElements(_driver, this);
    }
    
	/// <summary>
	/// Opens the Contact Page by clicking on the "Contact" link
	/// </summary>
	/// <returns>Returns a ContactPage object</returns>
    public ContactPage OpenContactPage()  
    {
      MenuContact.Click();
      return new ContactPage(_driver);
    }
    
  }
}
