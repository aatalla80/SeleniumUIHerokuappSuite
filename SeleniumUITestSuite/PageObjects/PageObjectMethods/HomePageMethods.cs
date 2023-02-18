using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Assemblies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace SeleniumUITestSuite.PageObjects
{
    public partial class HomePageMethods : HomePageElements
    {      
        public HomePageMethods(IWebDriver driver) : base(driver){}
        public override string Url => @ConfigurationManager.AppSettings["seleniumBaseUrl"];

        public void PageLoads() => Assert.IsTrue(WrappedDriver.Title == PageTitle);

        public void PageElementsLoad() => Assert.IsTrue(AddRemoveElementsPageOnMainMenu.Displayed &&
            BasicAuthOnMainMenu.Displayed && FormAuthenticationOnMainMenu.Displayed);

        public void GoToAddRemoveElementsPage() => AddRemoveElementsPageOnMainMenu.Click();
        public void GoToFormAuthenticationPage() => FormAuthenticationOnMainMenu.Click();
    }
}
