using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestSuite.PageObjects
{
    public abstract class SecureAreaPageElements : NavigatablePage
    {
        protected SecureAreaPageElements(IWebDriver driver) : base(driver) { }

        By HeaderElement = By.XPath("/html/body/div[2]/div/div/h2");
        By DisplayedMessageTextElement = By.Id("flash");
        By LogoutButtonElement = By.XPath("/html/body/div[2]/div/div/a");

        public IWebElement PageHeader => WrappedDriver.FindElement(HeaderElement);
        public IWebElement DisplayedMessage => WrappedDriver.FindElement(DisplayedMessageTextElement);
        public IWebElement LogoutButton => WrappedDriver.FindElement(LogoutButtonElement);
    }
}
