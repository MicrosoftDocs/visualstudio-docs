---
title: Write Unit tests for C++ DLLs
description: Learn about the several ways to test DLL code, depending on whether the DLL exports the functions that you want to test.
ms.date: 02/16/2021
ms.topic: how-to
ms.author: twhitney
manager: coxford
author: tylermsft
---
# Write unit tests for C++ DLLs in Visual Studio

There are several ways to test DLL code, depending on whether it exports the functions that you want to test. Choose one of the following ways:

**The unit tests call only functions that are exported from the DLL:**
Add a separate test project as described in [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md). In the test project, add a reference to the DLL project.

Go to the procedure [To reference exported functions from the DLL project](#projectRef).

**The DLL is built as an .exe file:**
Add a separate test project. Link it to the output object file.

Go to the procedure [To link the tests to the object or library files](#objectRef).

**The unit tests call non-member functions that aren't exported from the DLL, and the DLL can be built as a static library:**
Change the DLL project so that it's compiled to a *.lib* file. Add a separate test project that references the project under test.

This approach has the benefit of allowing your tests to use non-exported members, but still keep the tests in a separate project.

Go to the procedure [To change the DLL to a static library](#staticLink).

**The unit tests must call non-member functions that aren't exported, and the code must be built as a dynamic link library (DLL):**
Add unit tests in the same project as the product code.

Go to the procedure [To add unit tests in the same project](#sameProject).

## Create the tests

### <a name="staticLink"></a> To change the DLL to a static library

- If your tests must use members that aren't exported by the DLL project, and the project under test is built as a dynamic library, consider converting it to a static library.

  1. In **Solution Explorer**, on the shortcut menu of the project under test, choose **Properties**. The project **Properties** window opens.

  2. Choose **Configuration Properties** > **General**.

  3. Set **Configuration Type** to **Static Library (.lib)**.

  Continue with the procedure [To link the tests to the object or library files](#objectRef).

### <a name="projectRef"></a> To reference exported DLL functions from the test project

- If the DLL project exports the functions that you want to test, then you can add a reference to the code project from the test project.

  1. Create a Native Unit Test Project.

      1. On the **File** menu, choose **New** > **Project**. In the **Add a New Project** dialog, set **Language** to C++ and type "test" into the search box. Then choose the **Native Unit Test Project**.

  1. In **Solution Explorer**, right-click on the test project, then choose **Add** > **Reference**.

  1. Select **Projects**, and then the project to be tested.

       Choose the **Add** button.

  1. In the properties for the test project, add the location of the project under test to the Include Directories.

       Choose **Configuration Properties** > **VC++ Directories** > **Include Directories**.

       Choose **Edit**, and then add the header directory of the project under test.

  Go to [Write the unit tests](#addTests).

### <a name="objectRef"></a> To link the tests to the object or library files

- If the DLL doesn't export the functions that you want to test, you can add the output *.obj* or *.lib* file to the dependencies of the test project.

  1. Create a Native Unit Test Project.

      1. On the **File** menu, choose **New** > **Project**. In the **Add a New Project** dialog, set **Language** to C++ and type "test" into the search box. Then choose the **Native Unit Test Project**.

  1. In **Solution Explorer**, on the shortcut menu of the test project, choose **Properties**.

  1. Choose **Configuration Properties** > **Linker** > **Input** > **Additional Dependencies**.

       Choose **Edit**, and add the names of the **.obj** or **.lib** files. Don't use the full path names.

  1. Choose **Configuration Properties** > **Linker** > **General** > **Additional Library Directories**.

       Choose **Edit**, and add the directory path of the **.obj** or **.lib** files. The path is typically within the build folder of the project under test.

  1. Choose **Configuration Properties** > **VC++ Directories** > **Include Directories**.

       Choose **Edit**, and then add the header directory of the project under test.

  Go to [Write the unit tests](#addTests).

### <a name="sameProject"></a> To add unit tests in the same project

1. Modify the product code project properties to include the headers and library files that are required for unit testing.

   1. In **Solution Explorer**, in the shortcut menu of the project under test, choose **Properties**. The project **Properties** window opens.

   1. Choose **Configuration Properties** > **VC++ Directories**.

   1. Edit the Include and Library directories:

       |Directory|Property|
       |-|-|
       |**Include Directories** | **$(VCInstallDir)Auxiliary\VS\UnitTest\include** |
       |**Library Directories** | **$(VCInstallDir)Auxiliary\VS\UnitTest\lib** |

1. Add a C++ Unit Test file:

   1. Right-click on the project node in **Solution Explorer** and choose **Add** > **New Item**.

   1. In the **Add New Item** dialog, select  **C++ File (.cpp)**, give it an appropriate name, and then choose **Add**.

   Go to [Write the unit tests](#addTests).

## <a name="addTests"></a> Write the unit tests

1. In each unit test code file, add an `#include` statement for the headers of the project under test.

1. Add test classes and methods to the unit test code files. For example:

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

## Run the tests

1. On the **Test** menu, choose **Windows** > **Test Explorer**.

1. If not all of your tests are visible in the window, build the test project: right-click its node in **Solution Explorer** and choose **Build** or **Rebuild**.

1. In **Test Explorer**, choose **Run All**, or select the specific tests you want to run. Right-click on a test for other options, for example, to run it in debug mode with breakpoints enabled.

## Related content

- [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md)
- [Microsoft.VisualStudio.TestTools.CppUnitTestFramework API Reference](../test/microsoft-visualstudio-testtools-cppunittestframework-api-reference.md)
- [Debug native code](../debugger/debugging-native-code.md)
- [Walkthrough: Creating and using a dynamic link library (C++)](/cpp/build/walkthrough-creating-and-using-a-dynamic-link-library-cpp)
- [Import and export](/cpp/build/importing-and-exporting)
- [Quickstart: Test driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)
