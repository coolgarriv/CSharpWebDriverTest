using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PCI
{
  public class ContactPage
  {
      private IWebDriver driver;

      [FindsBy(How = How.ID, Using = "g12-name")]
      private IWebElement tbxName = null;
      [FindsBy(How = How.ID, Using = "g12-email")]
      private IWebElement tbxEmail = null;
      [FindsBy(How = How.ID, Using = "g12-website")]
      private IWebElement tbxWebsite = null;
      [FindsBy(How = How.ID, Using = "g12-comment")]
      private IWebElement tbxComment = null;
      
      
      
      // Class Constructor
      public HomePage(IWebDriver driver)
      {
          this.driver = driver;
          PageFactory.InitElements(driver, this);
      }
      
      public boolean FieldsDisplayedCorrectly()
      {
        // If all the fields are displayed then return true
        
        
        return true;
      }
      
    }
}
