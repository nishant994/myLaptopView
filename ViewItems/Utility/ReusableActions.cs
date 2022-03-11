using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewItems.Utility
{
	// ################################## This Class contains all the cutomized actions like Click, Enter text .... ###################################
    public class ReusableActions
    {

		// ######### Below method is to wait for almost max 30 seconds and to retry on every 3 seconds before failing the test ##########

		public bool waitPeriod(IWebDriver driver, String objectElement) 
		{
			bool isElelmentpresent = true;

		int index = 0;

		while (index<11) {
			try {

				bool stsusabc = driver.FindElement(By.XPath(objectElement)).Enabled;   // Verifies if element is enabled to receive actions

				break;
			} catch (Exception e) {

				if (index<10) {
						System.Threading.Thread.Sleep(3000);
						index++; 
					continue;
				} else
{
	isElelmentpresent = false;
	throw new Exception("Something wired happened while finding the element or Element: " + objectElement+ " not found");
	//break;
}


			}

		}

		return isElelmentpresent;
	}


	// ######################## Below custom method is to enter value and press enter in a text field #######################
	public ReusableActions EnterValueAndPressEnter(IWebDriver driver, String element, String Value) 
	{

		bool isElementPresent = waitPeriod(driver,element); //waiting for an element for 30 seconds if page loads
			
			try {
			if (isElementPresent)
			{

				driver.FindElement(By.XPath(element)).SendKeys(Value); //enter the value
				System.Threading.Thread.Sleep(2000);
				driver.FindElement(By.XPath(element)).SendKeys(Keys.Enter);
				System.Console.WriteLine("Value: " + Value + " successfully enterd");

			}
			else
			{

				System.Console.WriteLine("Element not present");
					

			}
		} catch (Exception e) {
				System.Console.WriteLine("Something wired happened");
				throw new Exception("Something wired happened while finding the element");


			}

		return this;

	}

		// ########################### Below function is to click on an element #################################
		public ReusableActions clickElement(IWebDriver driver, String element) 
		{
			//System.Threading.Thread.Sleep(5000);
			System.Console.WriteLine("before object creation in click");
			bool isElementPresent = waitPeriod(driver, element);
			System.Console.WriteLine("boolean is "+ isElementPresent);
			//waiting for an element for 30 seconds if its present
			System.Console.WriteLine("After wait in click");

			try {
			if (isElementPresent) {

				driver.FindElement(By.XPath(element)).Click(); //Click on the element

			} else {

					System.Console.WriteLine("Element not present");

}
		} catch (Exception e)
{
				System.Console.WriteLine("Something wired happened");


}

		return this;

		}

	}
}
