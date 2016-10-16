---
title: "Using Environment Variables in Generic Tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "generic tests, using environment variables with"
  - "generic tests"
ms.assetid: e9e543d7-5622-4a5f-8d4b-9e17157604a7
caps.latest.revision: 15
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Environment Variables in Generic Tests
To program a generic test, you type information into fields on the generic test page. In several of these fields, you type paths to folders. Although you can hard-code these paths, you can also use environment variables to represent paths in the following fields:  
  
-   target executable  
  
-   command-line arguments  
  
-   summary results file location  
  
-   deployment items  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 You can use any system-defined or user-defined environment variable, such as **SystemDrive**, **ProgramFiles**, and **UserProfile**. An especially useful variable is **ComSpec**. **ComSpec** expands to the full path of cmd.exe, which is the command prompt executable. You can use **ComSpec** for running command prompt scripts such as .bat files.  
  
> [!NOTE]
>  Environment variables are not case sensitive.  
  
 To determine which environment variables are set and the values they have, type `set` at a command line.  
  
 By default, undefined environment variables are expanded to an empty string. For example, if you specify `%MyExecutableDir%MyExecutable.exe` in a generic test, but `MyExecutableDir` is not defined, the test engine treats this string as MyExecutable.exe and tries to run it in the deployment directory. This works if MyExecutable.exe was deployed.  
  
 You can use an environment variable to control the folder in which the test engine runs a test. For example, if you set `MyExecutableDir` to `E:\builds\drop\...\Bin\`, the test engine tries to run the file in that location. This technique is useful if a test cannot be moved, which could be the case if the test is under source control.  
  
## See Also  
 [Using a Summary Results File with a Generic Test](../test/using-a-summary-results-file-with-a-generic-test.md)