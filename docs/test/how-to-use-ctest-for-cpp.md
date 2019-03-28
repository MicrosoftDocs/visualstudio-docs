---
title: "How to use CTest for C++"
ms.date: 11/07/2017
ms.topic: conceptual
ms.author: mblome
manager: jillfra
ms.workload:
  - "cplusplus"
author: mikeblome
---
# How to use CTest for C++ in Visual Studio

CMake (which includes CTest) is integrated into the Visual Studio IDE by default as a component of the **Desktop Development with C++** workload. If you need to install it on your machine, open the Visual Studio Installer program, click the **Modify** button, then check [CMake tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp) under the list of workload components.

## To write tests

CMake support in Visual Studio doesn't involve the Visual Studio project system. Therefore, you write and configure CTest tests just as you would in any CMake environment. For more information about using CMake in Visual Studio, see [CMake tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp).

## To run tests

::: moniker range="vs-2017"

### Visual Studio 2017 version 15.6 and later

In Visual Studio 2017 version 15.6 and later, CTest is fully integrated with **Test Explorer** and also supports both the Google and Boost unit testing frameworks. Those frameworks are included by default as components in the **Desktop Development with C++** workload. However, if you are upgrading a project from an older version of Visual Studio, you may need to install those frameworks by using the Visual Studio Installer program.

The following illustration shows results of a CTest run using Google Test framework:

![CTest with Google Test Framework in Visual Studio 2017](media/ctest-test-explorer.png)

If you are using CTest but not the Google or Boost adapters, you see results at the CTest level instead of the individual test method level. You can debug and step-through CTest-only executables, but stack traces on individual tests aren't supported.

### Visual Studio 2017 version 15.5

In Visual Studio 2017 version 15.5, CTest is not integrated with **Test Explorer**. You can run your tests from the CMake main menu or from the right-click menu on a *CMakeLists.txt* file in **Solution Explorer**. Test results are directed to the Visual Studio **Output Window**.

![Run CTest tests in Visual Studio 2017 version 15.5](media/cpp-cmake-run-tests.png)

::: moniker-end

::: moniker range=">=vs-2019"

CTest is fully integrated with **Test Explorer** and also supports both the Google and Boost unit testing frameworks. Those frameworks are included by default as components in the **Desktop Development with C++** workload. However, if you are upgrading a project from an older version of Visual Studio, you may need to install those frameworks by using the Visual Studio Installer program.

The following illustration shows results of a CTest run using Google Test framework:

![CTest with Google Test Framework in Visual Studio](media/ctest-test-explorer.png)

If you are using CTest but not the Google or Boost adapters, you see results at the CTest level instead of the individual test method level. You can debug and step-through CTest-only executables, but stack traces on individual tests aren't supported.

::: moniker-end

## See also

- [Write unit tests for C/C++](writing-unit-tests-for-c-cpp.md)