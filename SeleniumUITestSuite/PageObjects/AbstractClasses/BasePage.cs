using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUITestSuite.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage(IWebDriver driver) => WrappedDriver = driver;
        protected IWebDriver WrappedDriver { get; }
    }

    
}
