using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewItems.Utility
{
    //############## This class is Pareent of all the test case class (TestCases), using Inheritence ##############3
    public class Abstract
    {
        // This is to setup the execution before test start running
        private string driverpath = @"C:\Users\m61790\Downloads\chromedriver_win32";    // Path of ChromeDriver
        public IWebDriver driver = null;
        [SetUp]
        public void SetDriver() {
           
            driver = new ChromeDriver(driverpath);
            driver.Manage().Window.Maximize();   // Maximixing the window

        }

        [TearDown]
        public void close_Browser()
        {
            driver.Close();
        }
    }
    }

