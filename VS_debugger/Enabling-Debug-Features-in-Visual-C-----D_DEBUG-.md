---
title: "Enabling Debug Features in Visual C++ (-D_DEBUG)"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
H1: Enabling Debug Features in Visual C++ (/D_DEBUG)
ms.assetid: 276e2254-7274-435e-ba4d-67fcef4f33bc
caps.latest.revision: 7
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Enabling Debug Features in Visual C++ (-D_DEBUG)
In Visual C++, debugging features such as assertions are enabled when you compile your program with the symbol **_DEBUG** defined. You can define **_DEBUG** in one of two ways:  
  
-   Specify **#define _DEBUG** in your source code, or  
  
-   Specify the **/D_DEBUG** compiler option. (If you create your project in Visual Studio using wizards, **/D_DEBUG** is defined automatically in the Debug configuration.)  
  
 When **_DEBUG** is defined, the compiler compiles sections of code surrounded by **#ifdef _DEBUG** and `#endif`.  
  
 The Debug configuration of an MFC program must link with a Debug version of the MFC library. The MFC header files determine the correct version of the MFC library to link with based on the symbols you have defined, such as **_DEBUG** and **_UNICODE**. For details, see [MFC Library Versions](../Topic/MFC%20Library%20Versions.md).  
  
## See Also  
 [Debugging Native Code](../VS_debugger/Debugging-Native-Code.md)   
 [Project Settings for a C++ Debug Configuration](../VS_debugger/Project-Settings-for-a-C---Debug-Configuration.md)