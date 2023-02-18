using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestSuite.PageObjects
{
    public abstract class AddRemoveElementsPageElements : NavigatablePage
    {
        protected AddRemoveElementsPageElements(IWebDriver driver) : base(driver) { }

        By HeaderElement = By.XPath("/html/body/div[2]/div/h3");
        By AddElementElement = By.XPath("/html/body/div[2]/div/div/button");
        By FirstDeleteElement = By.XPath("/html/body/div[2]/div/div/div/button[1]");

        public IWebElement PageHeader => WrappedDriver.FindElement(HeaderElement);
        public IWebElement AddElementButton => WrappedDriver.FindElement(AddElementElement);
        public IWebElement FirstDeleteButton => WrappedDriver.FindElement(FirstDeleteElement);
    }
}
