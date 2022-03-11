using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ViewItems.Utility;

namespace ViewItems
{
    public class Tests : Abstract
    {

        string URL = "https://www.amazon.com/";  // Defining the URL (Could be used Data driven concept for better approach)

        //#################### Start of Test Cases ###################################
        [Test]
        public void SearchLaptop()
        {            
            driver.Navigate().GoToUrl(URL);    // Navigate to URL
            ReusableActions actions = new ReusableActions();     // Creating instance of Reusable actions to call Enter Element and click customized actions

            actions.EnterValueAndPressEnter(driver, PageObject.ElementList.Searchbox(), "Laptop");   // Calling EnterValueAndPressEnter function and search for Laptop

            actions.clickElement(driver, PageObject.ElementList.FirstSeachElement());  //Customized clickElement Function to click on an element 

            bool isPriceelementPresent=actions.waitPeriod(driver, PageObject.ElementList.LaptopPriceElement());   // Calling user defined waitPeriod finction which wait for max almost 30 seconds (dynamically) to find the Laptop price Element


            // ######## Below piece of code is to compare Laptop Price and pass the test if Price is less thatn $100 and fail if it above that
            if (isPriceelementPresent)
            {       

                string text=  driver.FindElement(By.XPath(PageObject.ElementList.LaptopPriceElement())).Text;  // getting price text from the element

                System.Console.WriteLine("Price text = "+text);
      
                double x = double.Parse(text.Substring(1, text.Length - 1));   // Parsing the String to remove Dollar $ sign
                if (x < 100.00)
                {
                    System.Console.WriteLine("Price is Lowser than $100");
                }
                else {
                    System.Console.WriteLine("Price is Higher than $100");
                    throw new System.Exception("Price is Higher than $100");
                }
            }
            else {

                System.Console.WriteLine("Price not found");
                throw new System.Exception("Price Tag not available");
            }
        
        }
    }
}