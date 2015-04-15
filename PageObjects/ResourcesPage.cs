using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverTest
{
  public class ResourcesPage
  {
    private IWEDriver _driver;
	
	[FindsBy(How = How.ClassName, Using = "entry-title")]
	private IWebElement h1PageTitle = null;
	
	/// <summary>
	/// Class Constructor
	/// </summary>
	/// <param name="driver">WebDriver Object</param>
	public ResourcesPage(IWebDriver driver)
	{
		this._driver = driver
		PageFactory.InitElements(_driver, this);
	}
	

  }
}
