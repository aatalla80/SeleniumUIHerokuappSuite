using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumUITestSuite.PageObjects
{
    public partial class FormAuthenticationPageMethods : FormAuthenticationPageElements
    {
        public FormAuthenticationPageMethods(IWebDriver driver) : base(driver) {}

        public override string Url => @ConfigurationManager.AppSettings["seleniumBaseUrl"] + "/login";

        public void PageLoads()
        {
            Assert.IsTrue(PageHeader.Text == "Login Page" && UsernameField.Displayed 
                && PasswordField.Displayed && LoginButton.Displayed);
        }

        public void LoginToForm(string user, string pass)
        {
            if (LoginButton.Displayed)
            {
                UsernameField.Clear();
                UsernameField.SendKeys(user);
                PasswordField.Clear();
                PasswordField.SendKeys(pass);
                LoginButton.Click();
            }
            else
            {
                Console.WriteLine("The Login Button is not displayed");
            }

        }

        public void LoginToFormViaDefaults()
        {
            LoginToForm(ConfigurationManager.AppSettings["usersUsername"], ConfigurationManager.AppSettings["usersPassword"]);
        }

        public string ErrorMessageDisplayed()
        {
            return ErrorMessageText.Text;
        }

        public void TestMessageDisplayed(string expectedMessage)
        {
            string actualResult = ErrorMessageDisplayed();

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
        
    }



    
}
