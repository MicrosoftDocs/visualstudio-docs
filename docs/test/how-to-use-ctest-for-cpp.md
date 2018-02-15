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
CMake (which includes CTest) is integrated into the Visual Studio IDE as a component of the **Desktop Develoment with C++** workload. To install it on your machine, open the Visual Studio Installer and find [CMake Tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp) under the list of workload components.

CMake support in Visual Studio does not involve the Visual Studio project system. Therefore, you write and configure CTest tests just as you would in any CMake environment. See [CMake Tools for Visual C++](/cpp/ide/cmake-tools-for-visual-cpp) for more infomation about using CMake in Visual Studio.

**Visual Studio 2017 version 15.5**
CTest is not currently integrated with **Test Explorer**. You can run your tests from the CMake main menu or from the context menu on a **CMakeLists.txt** file in **Solution Explorer**. Test results are directed to the Visual Studio **Output Window**.

![Run CTest tests](media/cpp-cmake-run-tests.png "Run CTest tests")

## See Also
[Writing Unit Tests for C/C++](writing-unit-tests-for-c-cpp.md)