---
title: "Writing Unit tests for C/C++ | Microsoft Docs"
ms.custom: ""
ms.date: "10/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4f4b5f10-7314-4725-8c6e-e72f52eff918
caps.latest.revision: 14
ms.author: "mblome"
manager: "ghogen"
---
# Writing Unit tests for C/C++
Visual Studio supports unit tests for C++ code using any of these options:
 -  the Microsoft Unit Testing Framework for C++
 -  Google Test
 -  Boost.Test
 -  CTest   
  
 The following procedure contains the essential information that will get you started. The later sections provide a walkthrough that describes the steps in more detail.  
  
## Create a test project
You define an run tests inside one or more test projects that are in the same solution as the code you want to test. To add a new test project to an existing solution, right-click on the Solution node in **Solution Explorer** and choose ** Add | New Project**. Then in the left pane choose *Visual C++ Test** and choose one of the project types from the center pane. The available projects might differ from what you see here depending on what you have installed on your machine:

![C++ Test Projects](media/cpp-new-test-project.png "C++ new test project templates")

## Create references to other projects in the solution
To enable your test code to access the functions in the project to be tested, add a reference to the project in your test project. Right- click on the test project node in **Solution Explorer** and choose **Add | Reference**. Then in the dialog choose the project(s) you want to test.

![Add reference](media/cpp-add-ref-test-project.png "C++ test add a reference to projects to be tested")

## Add #include directives for header files
Next, in your unit test .cpp file, add an `#include` directive for any header files that declare the types and functions you want to test. For a typical solution, type `#include "../` and then Intellisense will activate to help you choose. Repeat for any additional headers.

![Add include directives](media/cpp-add-includes-test-project.png "C++ test add includes for header files")

## Write test methods
The .cpp file in your test project (by default named unittest1.cpp) has a stub class and method defined for you as an example of how to write test code. Note that the signatures use the TEST_CLASS and TEST_METHOD macros, which make the methods discoverable from the Test Explorer window.

![Add include directives](media/cpp-write-test-methods.png "C++ test add includes for header files")

TEST_CLASS and TEST_METHOD are part of the Microsoft Native Test Framework. For more information and documentation on all the available macros and functions, see [Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework](using-microsoft-visualstudio-testtools-cppunittestframework.md).

A TEST_METHOD returns void. To produce a test result, use the static methods in the Assert class to test actual results against what is expected. In the following example, assume `MyClass` has a constructor that that takes a `std::string`, and also defines a public function named `GetName` which returns the string that was used to initialize the class. We can test that the class was initialized as expected like so:

```cpp
		TEST_METHOD(TestClassInitialization)
		{
			std::string name = "Bill";
			MyClass mc(name);
			Assert::AreEqual(name, mc.GetName());
		}
```
In the previous example, the result of the `Assert::AreEqual` call determines whether the test passes or fails. The Assert class contains many other methods for comparing expected vs. actual results.



