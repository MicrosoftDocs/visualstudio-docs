---
title: "Unit testing a Visual C++ DLL for Store apps | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 24afc90a-8774-4699-ab01-6602a7e6feb2
caps.latest.revision: 15
author: "alexhomer1"
ms.author: jillfra
manager: jillfra
---
# Unit testing a Visual C++ DLL for Store apps
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes one way to create unit tests for a C++ DLL for Windows Store apps The RooterLib DLL demonstrates vague memories of limit theory from the calculus by implementing a function that calculates an estimate of the square root of a given number. The DLL might then be included in a Windows Store app that shows a user the fun things that can be done with math.

 This topic shows you how to use unit testing as the first step in development. In this approach, you first write a test method that verifies a specific behavior in the system that you are testing and then you write the code that passes the test. By making changes in the order of the following procedures, you can reverse this strategy to first write the code that you want to test and then write the unit tests.

 This topic also creates a single Visual Studio solution and separate projects for the unit tests and the DLL that you want to test. You can also include the unit tests directly in the DLL project, or you can create separate solutions for the unit tests and the .DLL. See [Adding unit tests to existing C++ applications](../test/unit-testing-existing-cpp-applications-with-test-explorer.md) for tips on which structure to use.

## <a name="BKMK_In_this_topic"></a> In this topic
 This topic takes you through the following tasks:

 [Create the solution and the unit test project](#BKMK_Create_the_solution_and_the_unit_test_project)

 [Verify that the tests run in Test Explorer](#BKMK_Verify_that_the_tests_run_in_Test_Explorer)

 [Add the DLL project to the solution](#BKMK_Add_the_DLL_project_to_the_solution)

 [Couple the test project to the dll project](#BKMK_Couple_the_test_project_to_the_dll_project)

 [Iteratively augment the tests and make them pass](#BKMK_Iteratively_augment_the_tests_and_make_them_pass)

 [Debug a failing test](#BKMK_Debug_a_failing_test)

 [Refactor the code without changing tests](#BKMK_Refactor_the_code_without_changing_tests)

## <a name="BKMK_Create_the_solution_and_the_unit_test_project"></a> Create the solution and the unit test project

1. On the **File** menu, choose **New**, and then choose **New Project**.

2. On the New Project dialog, expand **Installed**, then expand **Visual C++** and choose **Windows Store**. Then choose **Unit Test Library (Windows Store apps)** from the list of project templates.

     ![Create a C&#43;&#43; unit test library](../test/media/ute-cpp-windows-unittestlib-create.png "UTE_Cpp_windows_UnitTestLib_Create")

3. Name the project `RooterLibTests`; specify the location; name the solution `RooterLib`; and make sure **Create directory for solution** is checked.

     ![Specify the solution and project name and location](../test/media/ute-cpp-windows-unittestlib-createspecs.png "UTE_Cpp_windows_UnitTestLib_CreateSpecs")

4. In the new project, open **unittest1.cpp**.

     ![unittest1.cpp](../test/media/ute-cpp-windows-unittest1-cpp.png "UTE_Cpp_windows_unittest1_cpp")

     Note that:

    - Each test is defined by using `TEST_METHOD(YourTestName){...}`.

         You do not have to write a conventional function signature. The signature is created by the macro TEST_METHOD. The macro generates an instance function that returns void. It also generates a static function that returns information about the test method. This information allows the test explorer to find the method.

    - Test methods are grouped into classes by using `TEST_CLASS(YourClassName){...}`.

         When the tests are run, an instance of each test class is created. The test methods are called in an unspecified order. You can define special methods that are invoked before and after each module, class, or method. For more information, see [Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework](../test/using-microsoft-visualstudio-testtools-cppunittestframework.md) in the MSDN Library.

## <a name="BKMK_Verify_that_the_tests_run_in_Test_Explorer"></a> Verify that the tests run in Test Explorer

1. Insert some test code:

    ```cpp
    TEST_METHOD(TestMethod1)
    {
        Assert::AreEqual(1,1);
    }
    ```

     Notice that the `Assert` class provides several static methods that you can use to verify results in test methods.

2. On the **Test** menu, choose **Run** and then choose **Run All**.

     The test project builds and runs. The Test Explorer window appears, and the test is listed under **Passed Tests**. The Summary pane at the bottom of the window provides additional details about the selected test.

     ![Test Explorer](../test/media/ute-cpp-testexplorer-testmethod1.png "UTE_Cpp_TestExplorer_TestMethod1")

## <a name="BKMK_Add_the_DLL_project_to_the_solution"></a> Add the DLL project to the solution

1. In Solution Explorer, choose the solution name. From the shortcut menu, choose **Add**, and then **Add New Project**.

     ![Create the RooterLib project](../test/media/ute-cpp-windows-rooterlib-create.png "UTE_Cpp_windows_RooterLib_Create")

2. In the **Add New Project** dialog box, choose **DLL (Windows Store apps)**.

3. Add the following code to the **RooterLib.h** file:

    ```cpp
    // The following ifdef block is the standard way of creating macros which make exporting
    // from a DLL simpler. All files within this DLL are compiled with the ROOTERLIB_EXPORTS
    // symbol defined on the command line. This symbol should not be defined on any project
    // that uses this DLL. This way any other project whose source files include this file see
    // ROOTERLIB_API functions as being imported from a DLL, whereas this DLL sees symbols
    // defined with this macro as being exported.
    #ifdef ROOTERLIB_EXPORTS
    #define ROOTERLIB_API  __declspec(dllexport)
    #else
    #define ROOTERLIB_API __declspec(dllimport)
    #endif //ROOTERLIB_EXPORTS

    class ROOTERLIB_API CRooterLib {
    public:
        CRooterLib(void);
        double SquareRoot(double v);
    };
    ```

     The comments explain the ifdef block not only to the developer of the dll, but to anyone who references the DLL in their project. You can add the ROOTERLIB_EXPORTS symbol to the command line by using the project properties of the DLL.

     The `CRooterLib` class declares a constructor and the `SqareRoot` estimator method.

4. Add the ROOTERLIB_EXPORTS symbol to the command line.

    1. In Solution Explorer, choose the **RooterLib** project, and then choose **Properties** from the shortcut menu.

         ![Add a preprocessor symbol definition](../test/media/ute-cpp-windows-addpreprocessorsymbol.png "UTE_Cpp_windows_AddPreprocessorSymbol")

    2. In the RooterLib Property Page dialog box, expand **Configuration Properties**, expand **C++** and choose **Preprocessor**.

    3. Choose **\<Edit...>** from the **Preprocessor Definitions** list, and then add `ROOTERLIB_EXPORTS` in the Preprocessor Definitions dialog box.

5. Add minimal implementations of the declared functions. Open **RooterLib.cpp** and add the following code:

    ```
    // constructor
    CRooterLib::CRooterLib()
    {
    }

    // Find the square root of a number.
    double CRooterLib::SquareRoot(double v)
    {
        return 0.0;
    }

    ```

## <a name="BKMK_Couple_the_test_project_to_the_dll_project"></a> Couple the test project to the dll project

1. Add RooterLib to the RooterLibTests project.

   1. In Solution Explorer, choose the **RooterLibTests** project and then choose **References...** on the shortcut menu.

   2. On the RooterLib Project Properties dialog box, expand **Common Properties** and choose **Framework and References**.

   3. Choose **Add New Reference....**

   4. In the **Add Reference** dialog box, expand **Solution** and then choose **Projects**. Then select the **RouterLib** item.

2. Include the RooterLib header file in **unittest1.cpp**.

   1. Open **unittest1.cpp**.

   2. Add this code to below the `#include "CppUnitTest.h"` line:

       ```cpp
       #include "..\RooterLib\RooterLib.h"
       ```

3. Add a test that uses the imported function. Add the following code to **unittest1.cpp**:

   ```
   TEST_METHOD(BasicTest)
   {
       CRooterLib rooter;
       Assert::AreEqual(
           // Expected value:
           0.0,
           // Actual value:
           rooter.SquareRoot(0.0),
           // Tolerance:
           0.01,
           // Message:
           L"Basic test failed",
           // Line number - used if there is no PDB file:
           LINE_INFO());
   }

   ```

4. Build the solution.

    The new test appears in Test Explorer in the **Not Run Tests** node.

5. In Test Explorer, choose **Run All**.

    ![Basic Test passed](../test/media/ute-cpp-testexplorer-basictest.png "UTE_Cpp_TestExplorer_BasicTest")

   You have set up the test and the code projects, and verified that you can run tests that run functions in the code project. Now you can begin to write real tests and code.

## <a name="BKMK_Iteratively_augment_the_tests_and_make_them_pass"></a> Iteratively augment the tests and make them pass

1. Add a new test:

    ```
    TEST_METHOD(RangeTest)
    {
        CRooterLib rooter;
        for (double v = 1e-6; v < 1e6; v = v * 3.2)
        {
            double expected = v;
            double actual = rooter.SquareRoot(v*v);
            double tolerance = expected/1000;
            Assert::AreEqual(expected, actual, tolerance);
        }
    };

    ```

    > [!TIP]
    > We recommend that you do not change tests that have passed. Instead, add a new test, update the code so that the test passes, and then add another test, and so on.
    >
    >  When your users change their requirements, disable the tests that are no longer correct. Write new tests and make them work one at a time, in the same incremental manner.

2. In Test Explorer, choose **Run All**.

3. The test fails.

     ![The RangeTest fails](../test/media/ute-cpp-testexplorer-rangetest-fail.png "UTE_Cpp_TestExplorer_RangeTest_Fail")

    > [!TIP]
    > Verify that each test fails immediately after you have written it. This helps you avoid the easy mistake of writing a test that never fails.

4. Enhance the code under test so that the new test passes. Add the following to **RooterLib.cpp**:

    ```cpp
    #include <math.h>
    ...
    // Find the square root of a number.
    double CRooterLib::SquareRoot(double v)
    {
        double result = v;
        double diff = v;
        while (diff > result/1000)
        {
            double oldResult = result;
            result = result - (result*result - v)/(2*result);
            diff = abs (oldResult - result);
        }
        return result;
    }

    ```

5. Build the solution and then in Test Explorer, choose **Run All**.

     Both tests pass.

> [!TIP]
> Develop code by adding tests one at a time. Make sure that all the tests pass after each iteration.

## <a name="BKMK_Debug_a_failing_test"></a> Debug a failing test

1. Add another test to **unittest1.cpp**:

   ```
   // Verify that negative inputs throw an exception.
    TEST_METHOD(NegativeRangeTest)
    {
      wchar_t message[200];
      CRooterLib rooter;
      for (double v = -0.1; v > -3.0; v = v - 0.5)
      {
        try
        {
          // Should raise an exception:
          double result = rooter.SquareRoot(v);

          swprintf_s(message, L"No exception for input %g", v);
          Assert::Fail(message, LINE_INFO());
        }
        catch (std::out_of_range ex)
        {
          continue; // Correct exception.
        }
        catch (...)
        {
          swprintf_s(message, L"Incorrect exception for %g", v);
          Assert::Fail(message, LINE_INFO());
        }
      }
   };

   ```

2. In Test Explorer, choose **Run All**.

    The test fails. Choose the test name in Test Explorer. The failed assertion is highlighted. The failure message is visible in the detail pane of Test Explorer.

    ![NegativeRangeTests failed](../test/media/ute-cpp-testexplorer-negativerangetest-fail.png "UTE_Cpp_TestExplorer_NegativeRangeTest_Fail")

3. To see why the test fails, step through the function:

   1. Set a breakpoint at the start of the `SquareRoot` function.

   2. On the shortcut menu of the failed test, choose **Debug Selected Tests**.

        When the run stops at the breakpoint, step through the code.

   3. Add code to **RooterLib.cpp** to catch the exception:

       ```
       #include <stdexcept>
       ...
       double CRooterLib::SquareRoot(double v)
       {
           //Validate the input parameter:
           if (v < 0.0)
           {
             throw std::out_of_range("Can't do square roots of negatives");
           }
       ...

       ```

   1. In Test Explorer, choose **Run All** to test the corrected method and make sure that you haven't introduced a regression.

   All tests now pass.

   ![All tests pass](../test/media/ute-ult-alltestspass.png "UTE_ULT_AllTestsPass")

## <a name="BKMK_Refactor_the_code_without_changing_tests"></a> Refactor the code without changing tests

1. Simplify the central calculation in the `SquareRoot` function:

    ```
    // old code
    //result = result - (result*result - v)/(2*result);
    // new code
    result = (result + v/result) / 2.0;

    ```

2. Choose **Run All** to test the refactored method and make sure that you haven't introduced a regression.

    > [!TIP]
    > A stable set of good unit tests gives confidence that you have not introduced bugs when you change the code.
    >
    >  Keep refactoring separate from other changes.
