using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUITestSuite.Features
{
    [TestClass]
    public class FormAuthenticationTests : TestTemplate
    {
        [TestInitialize]
        public override void TestSetup() 
        {
            base.TestSetup();
            HomePage.GoToFormAuthenticationPage();
        }

        [TestMethod]
        public void FormAuthenticationPageLoadsTest()
        {
            FormAuthenticationPage.PageLoads();
        }

        [TestMethod]
        public void SuccessfulLoginSecureAreaTest()
        {
            string expectedMessage = "You logged into a secure area!";

            FormAuthenticationPage.LoginToFormViaDefaults();
            SecureAreaPage.PageLoads();
            SecureAreaPage.TestMessageDisplayed(expectedMessage);
        }

        [TestMethod]
        public void SuccessfulLogoutSecureAreaTest()
        {
            string expectedMessage = "You logged out of the secure area!";

            FormAuthenticationPage.LoginToFormViaDefaults();
            SecureAreaPage.Logout();
            FormAuthenticationPage.TestMessageDisplayed(expectedMessage);
        }

        [TestMethod]
        public void LoginWithBlankFormTest()
        {
            string expectedMessage = "Your username is invalid!";

            FormAuthenticationPage.LoginToForm("", "");
            FormAuthenticationPage.TestMessageDisplayed(expectedMessage);
        }

        [TestMethod]
        public void LoginWithInvalidPasswordTest()
        {
            string user = "tomsmith";
            string pass = "SuperPassword!";
            string expectedMessage = "Your password is invalid!";

            FormAuthenticationPage.LoginToForm(user, pass);
            FormAuthenticationPage.TestMessageDisplayed(expectedMessage);
        }
    }
}
