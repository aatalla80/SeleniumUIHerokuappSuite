using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUITestSuite.Features
{
    public abstract class BaseTest
    {
        public BaseTest() => WebDriver = new ChromeDriver();

        protected IWebDriver WebDriver { get; set; }
    }
}
