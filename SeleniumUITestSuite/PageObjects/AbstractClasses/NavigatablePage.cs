using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUITestSuite.PageObjects
{
    public abstract class NavigatablePage : BasePage
    {
        protected NavigatablePage(IWebDriver driver) : base(driver) { }

        public abstract string Url { get; }
        public void GoToPageViaDirectUrl() => WrappedDriver.Navigate().GoToUrl(Url);
    }
}
