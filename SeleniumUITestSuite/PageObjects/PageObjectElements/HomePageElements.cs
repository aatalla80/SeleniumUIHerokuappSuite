using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUITestSuite.PageObjects           
{
    public abstract class HomePageElements : NavigatablePage
    {
        protected HomePageElements(IWebDriver driver) : base(driver) { }

        private string pageTitle = "The Internet";
        By AddRemoveElementsPageMainMenuElement = By.XPath("/html/body/div[2]/div/ul/li[2]/a");
        By BasicAuthPageMainMenuElement = By.XPath("/html/body/div[2]/div/ul/li[3]/a");
        By FormAuthenticationPageMainMenuElement = By.XPath("/html/body/div[2]/div/ul/li[21]/a");

        public string PageTitle => pageTitle;

        public IWebElement AddRemoveElementsPageOnMainMenu => this.WrappedDriver.FindElement(AddRemoveElementsPageMainMenuElement);
        public IWebElement BasicAuthOnMainMenu => this.WrappedDriver.FindElement(BasicAuthPageMainMenuElement);
        public IWebElement FormAuthenticationOnMainMenu => this.WrappedDriver.FindElement(FormAuthenticationPageMainMenuElement);
    }


}
