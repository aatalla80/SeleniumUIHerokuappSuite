using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestSuite.PageObjects
{
    public partial class SecureAreaPageMethods : SecureAreaPageElements
    {
        public SecureAreaPageMethods(IWebDriver driver) : base(driver) { }

        public override string Url => @ConfigurationManager.AppSettings["seleniumBaseUrl"] + "/secure";

        public void PageLoads() => Assert.IsTrue(PageHeader.Text == "Secure Area" && LogoutButton.Displayed && DisplayedMessage.Displayed);
        public string MessageDisplayed() => DisplayedMessage.Text;

        public void TestMessageDisplayed(string expectedMessage)
        {
            string actualResult = MessageDisplayed();

            if (actualResult.Contains(expectedMessage))
            {
                Console.WriteLine($"The correct message is displayed: {actualResult}");
                Assert.IsTrue(actualResult.Contains(expectedMessage));
            }
            else
            {
                Console.WriteLine($"The wrong message is displayed: {actualResult}");
                Assert.Fail();
            }
        }

        public void Logout()
        {
            if (LogoutButton.Displayed)
            {
                LogoutButton.Click();
            }
            else
            {
                Console.WriteLine("The Logout button is not displayed!");
            }
        }
    }
}
