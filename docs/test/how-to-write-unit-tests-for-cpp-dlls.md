---
title: "Write Unit tests for C++ DLLs"
ms.date: 05/01/2019
ms.topic: conceptual
ms.author: mblome
manager: markl
ms.workload:
  - "cplusplus"
author: mikeblome
---
# Write unit tests for C++ DLLs in Visual Studio

There are several ways to test DLL code, depending on whether it exports the functions that you want to test. Choose one of the following ways:

**The unit tests call only functions that are exported from the DLL:**
Add a separate test project as described in [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md). In the test project, add a reference to the DLL project.

Go to the procedure [To reference exported functions from the DLL project](#projectRef).

**The DLL is built as an .exe file:**
Add a separate test project. Link it to the output object file.

Go to the procedure [To link the tests to the object or library files](#objectRef).

**The unit tests call non-member functions which are not exported from the DLL, and the DLL can be built as a static library:**
Change the DLL project so that it is compiled to a *.lib* file. Add a separate test project that references the project under test.

This approach has the benefit of allowing your tests to use non-exported members, but still keep the tests in a separate project.

Go to the procedure [To change the DLL to a static library](#staticLink).

**The unit tests must call non-member functions that are not exported, and the code must be built as a dynamic link library (DLL):**
Add unit tests in the same project as the product code.

Go to the procedure [To add unit tests in the same project](#sameProject).

## Create the tests

### <a name="staticLink"></a> To change the DLL to a static library

- If your tests must use members that are not exported by the DLL project, and the project under test is built as a dynamic library, consider converting it to a static library.

  1. In **Solution Explorer**, on the shortcut menu of the project under test, choose **Properties**. The project **Properties** window opens.

  2. Choose **Configuration Properties** > **General**.

  3. Set **Configuration Type** to **Static Library (.lib)**.

  Continue with the procedure [To link the tests to the object or library files](#objectRef).

### <a name="projectRef"></a> To reference exported DLL functions from the test project

- If the DLL project exports the functions that you want to test, then you can add a reference to the code project from the test project.

  1. Create a Native Unit Test Project.

      ::: moniker range="vs-2019"

      1. On the **File** menu, choose **New** > **Project**. In the **Add a New Project** dialog, set **Language** to C++ and type "test" into the search box. Then choose the **Native Unit Test Project**.

      ::: moniker-end

      ::: moniker range="vs-2017"

      1. On the **File** menu, choose **New** > **Project** > **Visual C++** > **Test** > **C++ Unit Test Project**.

      ::: moniker-end

  1. In **Solution Explorer**, right-click on the test project, then choose **Add** > **Reference**.

  1. Select **Projects**, and then the project to be tested.

       Choose the **Add** button.

  1. In the properties for the test project, add the location of the project under test to the Include Directories.

       Choose **Configuration Properties** > **VC++ Directories** > **Include Directories**.

       Choose **Edit**, and then add the header directory of the project under test.

  Go to [Write the unit tests](#addTests).

### <a name="objectRef"></a> To link the tests to the object or library files

- If the DLL does not export the functions that you want to test, you can add the output *.obj* or *.lib* file to the dependencies of the test project.

  1. Create a Native Unit Test Project.

      ::: moniker range="vs-2019"

      1. On the **File** menu, choose **New** > **Project**. In the **Add a New Project** dialog, set **Language** to C++ and type "test" into the search box. Then choose the **Native Unit Test Project**.

      ::: moniker-end

      ::: moniker range="vs-2017"

      1. On the **File** menu, choose **New** > **Project** > **Visual C++** > **Test** > **C++ Unit Test Project**.

      ::: moniker-end

  2. In **Solution Explorer**, on the shortcut menu of the test project, choose **Properties**.

  3. Choose **Configuration Properties** > **Linker** > **Input** > **Additional Dependencies**.

       Choose **Edit**, and add the names of the **.obj** or **.lib** files. Do not use the full path names.

  4. Choose **Configuration Properties** > **Linker** > **General** > **Additional Library Directories**.

       Choose **Edit**, and add the directory path of the **.obj** or **.lib** files. The path is typically within the build folder of the project under test.

  5. Choose **Configuration Properties** > **VC++ Directories** > **Include Directories**.

       Choose **Edit**, and then add the header directory of the project under test.

  Go to [Write the unit tests](#addTests).

### <a name="sameProject"></a> To add unit tests in the same project

1. Modify the product code project properties to include the headers and library files that are required for unit testing.

   1. In **Solution Explorer**, in the shortcut menu of the project under test, choose **Properties**. The project **Properties** window opens.

   2. Choose **Configuration Properties** > **VC++ Directories**.

   3. Edit the Include and Library directories:

       |Directory|Property|
       |-|-|
       |**Include Directories** | **$(VCInstallDir)UnitTest\include;$(IncludePath)**|
       |**Library Directories** | **$(VCInstallDir)UnitTest\lib;$(LibraryPath)**|

2. Add a C++ Unit Test file:

   - In **Solution Explorer**, in the shortcut menu of the project, choose **Add** > **New Item** > **C++ Unit Test**.

   Go to [Write the unit tests](#addTests).

## <a name="addTests"></a> Write the unit tests

1. In each unit test code file, add an `#include` statement for the headers of the project under test.

2. Add test classes and methods to the unit test code files. For example:

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

1. If all your tests are not visible in the window, build the test project by right-clicking its node in **Solution Explorer** and choosing **Build** or **Rebuild**.

1. In **Test Explorer**, choose **Run All**, or select the specific tests you want to run. Right-click on a test for other options, including running it in debug mode with breakpoints enabled.

## See also

- [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md)
- [Microsoft.VisualStudio.TestTools.CppUnitTestFramework API Reference](../test/microsoft-visualstudio-testtools-cppunittestframework-api-reference.md)
- [Debug native code](../debugger/debugging-native-code.md)
- [Walkthrough: Creating and using a dynamic link library (C++)](/cpp/build/walkthrough-creating-and-using-a-dynamic-link-library-cpp)
- [Import and export](/cpp/build/importing-and-exporting)
- [Quickstart: Test driven development with Test Explorer](../test/quick-start-test-driven-development-with-test-explorer.md)
