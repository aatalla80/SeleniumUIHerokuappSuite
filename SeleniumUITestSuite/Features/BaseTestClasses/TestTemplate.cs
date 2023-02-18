using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUITestSuite.Features
{
    public partial class TestTemplate : PageObjectsInTest
    {
        public TestTemplate() : base() { }

        [ClassInitialize]
        public void ClassSetup() { }

        [TestInitialize]
        public virtual void TestSetup()
        {
            HomePage.GoToPageViaDirectUrl();
        }

        [TestCleanup]
        public void TestEnd()
        {
            WebDriver.Dispose();
        }
    }
}
