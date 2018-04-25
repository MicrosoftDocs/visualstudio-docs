---
title: "Troubleshooting IntelliSense in C++ Projects | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ".ncb files"
  - "ncb files"
  - "IntelliSense, troubleshooting failure in C++ projects"
  - "troubleshooting IntelliSense"
  - "troubleshooting Visual C++, IntelliSense"
ms.assetid: 72e4eb39-66d3-403d-8da7-00ed288a1899
caps.latest.revision: 20
author: "mikeblome"
ms.author: "mblome"
manager: "douge"
---
# Troubleshooting IntelliSense in C++ Projects
IntelliSense can stop working under certain conditions. Use the following steps to help determine why IntelliSense does not work for C++ projects.  
  
### To investigate IntelliSense failure in C++ projects  
  
1.  Make sure that the Visual C++ project contains no compilation errors.  
  
    1.  If the project is a Makefile project, see [How to: Enable IntelliSense for Makefile Projects](http://msdn.microsoft.com/library/9443f453-f18f-4f12-a9a1-ef9dbf8b188f).  
  
2.  Make sure that stdafx.h is on the include path. For more information about include paths in Visual C++ projects, see [#include Directive (C/C++)](http://msdn.microsoft.com/library/17067dc0-8db1-4f2d-b43e-ec12ecf83238) and [/I (Additional Include Directories)](http://msdn.microsoft.com/library/3e9add2a-5ed8-4d15-ad79-5b411e313a49).  
  
## IntelliSense Limitations  
 IntelliSense does not work in C++ projects under the following circumstances:  
  
-   The cursor is in a code comment.  
  
-   You are writing a string literal.  
  
-   A syntax error appears over the cursor.  
  
-   The solution consists of either the syntax for managed C++, or the earlier Managed Extensions for C++ syntax.  
  
-   IntelliSense is not fully supported when you reference a header file multiple times by using the `#include` directive, and the meaning of that header file changes because of various macro states that are defined through the `#define` directive. In other words, when you include a header file several times and the header usage changes under different macro states, IntelliSense does not always work.  
  
## See Also  
 [Troubleshooting IntelliSense](http://msdn.microsoft.com/en-us/c1b3adb9-0d48-4770-a51e-392ed818c484)   
 [How to: Organize Project Output Files for Builds](http://msdn.microsoft.com/library/521d95ea-2dcc-4da0-b5eb-ac3e57941446)