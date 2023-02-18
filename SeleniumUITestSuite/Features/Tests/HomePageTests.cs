using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUITestSuite.Features
{

    [TestClass]
    public class HomePageTests : TestTemplate
    { 
        [TestMethod]
        public void HomePageLoadsTest()
        {
            HomePage.PageLoads();
            HomePage.PageElementsLoad();
        }
    }
}
