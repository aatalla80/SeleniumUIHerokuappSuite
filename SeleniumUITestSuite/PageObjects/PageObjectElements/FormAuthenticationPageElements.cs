using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium; 

namespace SeleniumUITestSuite.PageObjects
{
    public abstract class FormAuthenticationPageElements  : NavigatablePage
    {
        protected FormAuthenticationPageElements(IWebDriver driver) : base(driver) { }

        By HeaderElement = By.XPath("/html/body/div[2]/div/div/h2");
        By UsernameElement = By.Id("username");
        By PasswordElement = By.Id("password");
        By LoginButtonElement = By.XPath("/html/body/div[2]/div/div/form/button");
        By ErrorMessageTextElement = By.Id("flash");

        public IWebElement PageHeader => WrappedDriver.FindElement(HeaderElement);
        public IWebElement UsernameField => WrappedDriver.FindElement(UsernameElement);
        public IWebElement PasswordField => WrappedDriver.FindElement(PasswordElement);
        public IWebElement LoginButton => WrappedDriver.FindElement(LoginButtonElement);
        public IWebElement ErrorMessageText => WrappedDriver.FindElement(ErrorMessageTextElement);
    }
}
