---
title: "How to use CTest for C++ in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/07/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-devops-test
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.author: mblome
manager: ghogen
ms.workload: 
  - "cplusplus"
author: mikeblome
---

# How to use CTest for C++ in Visual Studio

CMake (which includes CTest) is integrated into the Visual Studio IDE by default as a component of the **Desktop Develoment with C++** workload. If you need to install it on your machine, open the Visual Studio Installer program, click the **Modify** button, then check [CMake Tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp) under the list of workload components.

## To write tests

CMake support in Visual Studio does not involve the Visual Studio project system. Therefore, you write and configure CTest tests just as you would in any CMake environment. See [CMake Tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp) for more infomation about using CMake in Visual Studio.

## To run tests (Visual Studio 2017 version 15.6)

In Visual Studio 2017 version 15.6, CTest is fully-integrated with **Test Explorer** and also supports both the Google and Boost unit testing frameworks. Those frameworks are included by default as components in the **Desktop Develoment with C++** workload but if you are upgrading a project from an older version of Visual Studio, you may need install those frameworks by using the Visual Studio Installer program.

The following illustration shows results of a CTest run using Google Test framework:

![CTest with Google Test Framework in VS2017 15.6](media/ctest-test-explorer.png "CTest and Google Test in Test Explorer")

If you are using CTest but not the Google or Boost adapters, you will see results at the CTest level instead of the individual test method level. You can debug and step-through CTest-only executables, but stack traces on individual tests are not supported.

## To run tests (Visual Studio 2017 version 15.5)

In **Visual Studio 2017 version 15.5**, CTest is not integrated with **Test Explorer**. You can run your tests from the CMake main menu or from the context menu on a **CMakeLists.txt** file in **Solution Explorer**. Test results are directed to the Visual Studio **Output Window**.

![Run CTest tests in VS2017 15.5](media/cpp-cmake-run-tests.png "Run CTest tests in 15.5")

## See Also

[Writing Unit Tests for C/C++](writing-unit-tests-for-c-cpp.md)