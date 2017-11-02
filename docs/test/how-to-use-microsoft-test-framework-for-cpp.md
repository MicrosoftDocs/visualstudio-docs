---
title: "How to use the Microsoft Unit Testing Framework for C++ | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7d08de69-c32e-4f0b-89aa-75347b15fb82
caps.latest.revision: 11
ms.author: mblome
manager: ghogen
---
# How to use the Microsoft Unit Testing Framework for C++

 There are several ways to test product code, depending on whether it exposes the interfaces that you want to test. Choose one of the following ways:  
  
 **The unit tests can call only functions that are exported from the code under test:**  
 Add a separate test project. In the test project, add a reference to the project under test.  
  
 Go to the procedure [To reference exported functions from the test project](#projectRef).  
  
 **The code under test is built as an .exe file:**  
 Add a separate test project. Link it to the output object file.  
  
 Go to the procedure [To link the tests to the object or library files](#objectRef).  
  
 **The unit tests must use private functions and data, and the code under test can be built as a static library:**  
 Change the project under test so that it is compiled to a .lib file. Add a separate test project that references the project under test.  
  
 This approach has the benefit of allowing your tests to use private members, but still keep the tests in a separate project. However, it might not be suitable for some applications where you must have a dynamic link library (.dll).  
  
 Go to the procedure [To change the code under test to a static library](#staticLink).  
  
 **The unit tests must use private member functions and data, and the code must be built as a dynamic link library (DLL):**  
 Add unit tests in the same project as the product code.  
  
 Go to the procedure [To add unit tests in the same project](#sameProject).  
  
## Creating the tests  
  
###  <a name="staticLink"></a> To change the code under test to a static library  
  
-   If your tests must use members that are not exported by a project under test, and the project under test is built as a dynamic library, consider converting it to a static library.  
  
    1.  In Solution Explorer, on the shortcut menu of the project under test, choose **Properties**. The project properties window opens.  
  
    2.  Choose **Configuration Properties**, **General**.  
  
    3.  Set **Configuration Type** to **Static Library (.lib)**.  
  
 Continue with the procedure [To link the tests to the object or library files](#objectRef).  
  
###  <a name="projectRef"></a> To reference exported DLL functions from the test project  
  
-   If a project under test is a DLL that exports the functions that you want to test, then you can add a reference to the code project from the test project.  
  
    1.  Create a C++ test project.  
  
        1.  On the **File** menu, choose **New**, **Project**, **Visual C++,Test**, **C++ Unit Test Project**.  
  
    2.  In Solution Explorer, on the shortcut menu of the test project, choose **References**. The project properties window opens.  
  
    3.  Select **Common Properties**, **Framework and References**, and then choose the **Add New Reference** button.  
  
    4.  Select **Projects**, and then the project to be tested.  
  
         Choose the **Add** button.  
  
    5.  In the properties for the test project, add the location of the project under test to the Include Directories.  
  
         Choose **Configuration Properties**, **VC++ Directories**, **Include Directories**.  
  
         Choose **Edit**, and then add the header directory of the project under test.  
  
 Go to [Writing the unit tests](#addTests).  
  
###  <a name="objectRef"></a> To link the tests to the object or library files  
  
-   If the code under test does not export the functions that you want to test, you can add the output **.obj** or **.lib** file to the dependencies of the test project.  
  
    1.  Create a C++ test project.  
  
        1.  On the **File** menu, choose **New**, **Project**, **Visual C++,Test**, **C++ Unit Test Project**.  
  
    2.  In Solution Explorer, on the shortcut menu of the test project, choose **Properties**. The project properties window opens.  
  
    3.  Choose **Configuration Properties**, **Linker**, **Input**, **Additional Dependencies**.  
  
         Choose **Edit**, and add the names of the **.obj** or **.lib** files. Do not use the full path names.  
  
    4.  Choose **Configuration Properties**, **Linker**, **General**, **Additional Library Directories**.  
  
         Choose **Edit**, and add the directory path of the **.obj** or **.lib** files. The path is typically within the build folder of the project under test.  
  
    5.  Choose **Configuration Properties**, **VC++ Directories**, **Include Directories**.  
  
         Choose **Edit**, and then add the header directory of the project under test.  
  
 Go to [Writing the unit tests](#addTests).  
  
###  <a name="sameProject"></a> To add unit tests in the same project  
  
1.  Modify the product code project properties to include the headers and library files that are required for unit testing.  
  
    1.  In Solution Explorer, in the shortcut menu of the project under test, choose Properties. The project properties window opens.  
  
    2.  Choose **Configuration Properties**, **VC++ Directories**.  
  
    3.  Edit the Include and Library directories:  
  
        |||  
        |-|-|  
        |**Include Directories**|**$(VCInstallDir)UnitTest\include;$(IncludePath)**|  
        |**Library Directories**|**$(VCInstallDir)UnitTest\lib;$(LibraryPath)**|  
  
2.  Add a C++ Unit Test file:  
  
    -   In Solution Explorer, in the shortcut menu of the project, choose **Add**, **New Item**, and then choose **C++ Unit Test**.  
  
 Go to [Writing the unit tests](#addTests).  
  
##  <a name="addTests"></a> Writing the unit tests  
  
1.  In each unit test code file, add an `#include` statement for the headers of the project under test.  
  
2.  Add test classes and methods to the unit test code files. For example:  
  
    ```cpp  
    #include "stdafx.h"  
    #include "CppUnitTest.h"  
    #include "MyProjectUnderTest.h"  
    using namespace Microsoft::VisualStudio::CppUnitTestFramework;  
    namespace MyTest  
    {  
      TEST_CLASS(MyTests)  
      {  
      public:  
          TEST_METHOD(MyTestMethod)  
          {  
              Assert::AreEqual(MyProject::Multiply(2,3), 6);  
          }  
      };  
    }  
    ```  
  
 For more information, see [Unit testing native code with Test Explorer](http://msdn.microsoft.com/en-us/8a09d6d8-3613-49d8-9ffe-11375ac4736c).  
  
## Run the tests  
  
1.  On the **Test** menu, choose **Windows**, **Test Explorer**.  
2. If all your tests are not visible in the window, build the test project by right-clicking its node in **Solution Explorer** and choosing **Build** or **Rebuild**.
  
2.  In Test Explorer, choose **Run All**, or select the specific tests you want to run. Right-click on a test for other options, including running it in debug mode with breakpoints enabled.
  
## See Also
[Quick Start: Test Driven Development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)

