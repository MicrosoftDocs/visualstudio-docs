---
title: "Use the Microsoft Unit Testing Framework for C++"
ms.date: 06/13/2019
ms.topic: conceptual
ms.author: mblome
manager: markl
ms.workload:
  - "cplusplus"
author: mikeblome
---
# Use the Microsoft Unit Testing Framework for C++ in Visual Studio

The Microsoft Unit Testing Framework for C++ is included by default in the **Desktop Development with C++** workload.

## <a name="separate_project"></a> To write unit tests in a separate project

Typically, you run your test code in its own project in the same solution as the code you want to test. To set up and configure a new test project, see [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md).

## <a name="same_project"></a> To write unit tests in the same project

In some cases, for example when testing non-exported functions in a DLL, you might need to create the tests in the same project as the program you're testing. To write unit tests in the same project:

1. Modify the project properties to include the headers and library files that are required for unit testing.

   1. In **Solution Explorer**, right-click on project node for the program you are testing, then choose **Properties** > **Configuration Properties** > **VC++ Directories**.

   2. Click on the down arrow in the following rows and choose **\<Edit>**. Add these paths:

      | Directory | Property |
      |-| - |
      | **Include Directories** | **$(VCInstallDir)Auxiliary\VS\UnitTest\include** |
      | **Library Directories** | **$(VCInstallDir)Auxiliary\VS\UnitTest\lib** |

2. Add a C++ Unit Test file:

   - Right-click on the project node in **Solution Explorer** and choose **Add** > **New Item** > **C++ File (.cpp)**.

## Write the tests

Any *.cpp* file with test classes must include "CppUnitTest.h" and have a using statement for `using namespace Microsoft::VisualStudio::CppUnitTestFramework`. The test project is already configured for you. It also includes a namespace definition, and a TEST_CLASS with a TEST_METHOD to get you started. You can modify the namespace name as well as the names in parentheses in the class and method macros.

Special macros are defined for initializing test modules, classes and methods, and for cleanup of resources when tests are completed. These macros generate code that is executed before a class or method is first accessed, and after the last test has run. For more information, see [Initialize and cleanup](microsoft-visualstudio-testtools-cppunittestframework-api-reference.md#Initialize_and_cleanup).

Use the static methods in the [Assert](microsoft-visualstudio-testtools-cppunittestframework-api-reference.md#general_asserts) class to define test conditions. Use the [Logger](microsoft-visualstudio-testtools-cppunittestframework-api-reference.md#logger) class to write messages to the **Output Window**. Add attributes to test methods

## Run the tests

1. On the **Test** menu, choose **Windows** > **Test Explorer**.

1. If all your tests are not visible in the window, build the test project by right-clicking its node in **Solution Explorer** and choosing **Build** or **Rebuild**.

1. In **Test Explorer**, choose **Run All**, or select the specific tests you want to run. Right-click on a test for other options, including running it in debug mode with breakpoints enabled.

1. In the **Output Window** choose **Tests** in the drop down to view messages written out by the `Logger` class:

   ![C++ Output Window showing test messages](media/cpp-test-output-window.png)

## Define traits to enable grouping

You can define traits on test methods which enable you to categorize and group tests in **Test Explorer**. To define a trait, use the `TEST_METHOD_ATTRIBUTE` macro. For example, to define a trait named `TEST_MY_TRAIT`:

```cpp
#define TEST_MY_TRAIT(traitValue) TEST_METHOD_ATTRIBUTE(L"MyTrait", traitValue)
```

To use the defined trait in your unit tests:

```cpp
BEGIN_TEST_METHOD_ATTRIBUTE(Method1)
    TEST_OWNER(L"OwnerName")
    TEST_PRIORITY(1)
    TEST_MY_TRAIT(L"thisTraitValue")
END_TEST_METHOD_ATTRIBUTE()

TEST_METHOD(Method1)
{
    Logger::WriteMessage("In Method1");
    Assert::AreEqual(0, 0);
}
```

### C++ trait attribute macros

The following pre-defined traits are found in `CppUnitTest.h`. For more information, see [The Microsoft Unit Testing Framework for C++ API reference](microsoft-visualstudio-testtools-cppunittestframework-api-reference.md).

|Macro|Description|
|-|-----------------|
|`TEST_METHOD_ATTRIBUTE(attributeName, attributeValue)`|Use the TEST_METHOD_ATTRIBUTE macro to define a trait.|
|`TEST_OWNER(ownerAlias)`|Use the predefined Owner trait to specify an owner of the test method.|
|`TEST_PRIORITY(priority)`|Use the predefined Priority trait to assign relative priorities to your test methods.|

## See also

- [Quickstart: Test driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)
