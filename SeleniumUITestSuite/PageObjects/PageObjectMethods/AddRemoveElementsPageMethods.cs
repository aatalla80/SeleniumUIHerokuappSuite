
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace SeleniumUITestSuite.PageObjects
{
    public partial class AddRemoveElementsPageMethods : AddRemoveElementsPageElements
    {
        public AddRemoveElementsPageMethods(IWebDriver driver) : base(driver) { }

        private int count = 0;
        public override string Url => @ConfigurationManager.AppSettings["seleniumBaseUrl"] + "/add_remove_elements/";

        private int Count { get; set; }

        public void PageLoads() => Assert.IsTrue(PageHeader.Text == "Add/Remove Elements" && AddElementButton.Displayed);

        public int GetCount() => Count;

        public void ClickOnAddElementButton(int noOfClicks)
        {
            if (AddElementButton.Displayed == true)
            {
                int i = 0;
                while (i < noOfClicks)
                {
                    AddElementButton.Click();
                    i++;
                }
                Count = i;
                Console.WriteLine($"The number of elements added = {Count}");
            }
            else
            {
                Console.WriteLine("The add element button is not available");
            }
        }

        public void DeleteXElements(int noOfClicks)
        {
            int i = noOfClicks, deleted = 0;
            try
            {
                IWebElement DeleteButton = WrappedDriver.FindElement(By.XPath($"//*[@id='elements']/button[{i}]"));
                while (i > 0)
                {
                    DeleteButton.Click();
                    i--;
                    deleted++;
                }
                Console.WriteLine($"The number of elements deleted = {(deleted)}");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }

        public void DeleteAllElements()
        {
            int i = Count, deleted = 0;
            try
            {
                IWebElement DeleteButton = WrappedDriver.FindElement(By.XPath($"//*[@id='elements']/button[{i}]"));
                while (i > 0)
                {
                    DeleteButton.Click();
                    i--;
                    deleted++;
                }
                Console.WriteLine($"The number of elements deleted = {(deleted)}");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }

        public void CheckTheElementsAreDisplayed(int expectedNumElements)
        {
            int i = 1, found = 0;
            while ((i - 1) < expectedNumElements)
            {
                try
                {
                    IWebElement DeleteButton = WrappedDriver.FindElement(By.XPath($"//*[@id='elements']/button[{i}]"));
                    found++;
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine(e.Message);
                    Assert.Fail();
                }
                i++;
            }
            Console.WriteLine($"The expected number of elements: {expectedNumElements} the actual number of elements found: {found}");
            Assert.AreEqual(expectedNumElements, found);
        }

        public void CheckTheElementsAreNotDisplayed(int noOfAddedElements, int noOfDeletedElements)

        {
          
            int y = (noOfAddedElements ) - noOfDeletedElements;           
            int  i = noOfAddedElements;
            
            while(i > y)
            {
                bool displayed = false;
                try
                {
                    IWebElement DeleteButton = WrappedDriver.FindElement(By.XPath($"//*[@id='elements']/button[{i}]"));
                    displayed = true;
                }
                catch(NoSuchElementException)
                {
                    displayed = false;
                    Console.WriteLine($"Element {i} was deleted");
                }
              
                if(displayed == true)
                {
                    Assert.Fail();
                }
                i--;
            }
        }

        public void CheckAllElementsAreNotDisplayed(int noOfAddedElements)
        {
            CheckTheElementsAreNotDisplayed(noOfAddedElements, Count);
            Count = 0;
        }
    }      
        
    
}
