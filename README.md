# Code Overview and Framework Explanations
This is an automated Selenium code written in C#, .Net framework using NUbit framework
It has Basically 5 Folders:

  1. **TestCases:** It has all the Test cases written in NUnit framework
  2. **Utility:** It has all the utility calsses. It has basically 2 class:
  
         a. **Abstract:** Parent class of Test class which does all the setups before and after the execution, Like Creating Driver and closing window.
      
         b. **ReusableActions:** It has all the customized functions like, click, Enter text, Dynamic wait and all
      
  3. **PageObject:** All the elements have been saperated in different Folder within a class so that can be easy reusability and maintainance
  4. **Drivers:** Usually it has the driver but the code uses different one, located on  local. Ideally it should be within the project itself
  5. **Dependencies:** It has all the Selenium NuGet packages

 **NOTE: NEED TO UPDATE _driverpath_ STRING INSIDE ABSTRACT.CS CLASS**
