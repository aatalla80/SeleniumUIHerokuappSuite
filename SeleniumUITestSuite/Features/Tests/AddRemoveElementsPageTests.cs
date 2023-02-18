using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUITestSuite.Features
{
    [TestClass]
    public class AddRemoveElementsPageTests : TestTemplate
    {
        [TestInitialize]
        public override void TestSetup()
        {
            base.TestSetup();
            HomePage.GoToAddRemoveElementsPage();
        }

        [TestMethod]
        public void AddRemoveElementPageLoadsTest()
        {
            AddRemoveElementsPage.PageLoads();
        }

        [TestMethod]
        public void AddOneElementTest()
        {
            int numberOfElementsAdded = 1;

            AddRemoveElementsPage.ClickOnAddElementButton(numberOfElementsAdded);
            AddRemoveElementsPage.CheckTheElementsAreDisplayed(numberOfElementsAdded);
        }

        [TestMethod]
        public void AddSeveralElementsTest()
        {
            int numberOfElementsAdded = 5;

            AddRemoveElementsPage.ClickOnAddElementButton(numberOfElementsAdded);
            AddRemoveElementsPage.CheckTheElementsAreDisplayed(numberOfElementsAdded);
        }

        [TestMethod]
        public void DeleteOneElementTest()
        {
            int numberOfElementsAdded = 5, numberOfElementsDeleted = 1;

            AddRemoveElementsPage.ClickOnAddElementButton(numberOfElementsAdded);
            AddRemoveElementsPage.DeleteXElements(numberOfElementsDeleted);
            AddRemoveElementsPage.CheckTheElementsAreNotDisplayed(numberOfElementsAdded, numberOfElementsDeleted);
        }

        [TestMethod]
        public void DeleteAllElementsTest()
        {
            int numberOfElementsAdded = 5;

            AddRemoveElementsPage.ClickOnAddElementButton(numberOfElementsAdded);
            AddRemoveElementsPage.DeleteAllElements();
            AddRemoveElementsPage.CheckAllElementsAreNotDisplayed(numberOfElementsAdded);
        }

    }
}
