using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumUITestSuite.PageObjects;

namespace SeleniumUITestSuite.Features
{
    public abstract class PageObjectsInTest : BaseTest
    {
        public PageObjectsInTest() : base()
        {
            HomePage = new HomePageMethods(WebDriver);
            AddRemoveElementsPage = new AddRemoveElementsPageMethods(WebDriver);
            FormAuthenticationPage = new FormAuthenticationPageMethods(WebDriver);
            SecureAreaPage = new SecureAreaPageMethods(WebDriver);
        }

        public HomePageMethods HomePage {get; set;}
        public AddRemoveElementsPageMethods AddRemoveElementsPage { get; set; }
        public FormAuthenticationPageMethods FormAuthenticationPage { get; set; }
        public SecureAreaPageMethods SecureAreaPage { get; set; }
    }
}
