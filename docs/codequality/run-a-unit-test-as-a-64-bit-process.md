---
title: "Run a unit test as a 64-bit process"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "unit tests, creating"
  - "unit tests, running"
ms.assetid: d23a9ee7-58e3-4e8b-a38c-b2207ea73fea
caps.latest.revision: 25
ms.author: "mlearned"
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
# Run a unit test as a 64-bit process
If you have a 64-bit machine, you can run unit tests and capture code coverage information as a 64-bit process.  
  
## Running a unit test as a 64-bit process  
  
#### To run a unit test as a 64-bit process  
  
1.  If your code or tests were compiled as 32-bit/x86, but you now want to run them as a 64-bit process, recompile them as **Any CPU**, or optionally as **64-bit**.  
  
    > [!TIP]
    >  For maximum flexibility, you should compile your test projects with the **Any CPU** configuration. Then you can run on both 32 and 64 bit agents. There is no advantage to compiling test projects with the **64-bit** configuration.  
  
2.  From the Visual Studio menu, choose **Test**, then choose **Settings**, and then choose **Processor Architecture**. Choose **x64** to run the tests as a 64-bit process.  
  
     \- or -  
  
     Specify `<TargetPlatform>x64</TargetPlatform>` in a .runsettings file. An advantage of this method is that you can specify groups of settings in different files and quickly switch between different settings. You can also copy settings between solutions. For more information, see [Configure unit tests by using a .runsettings file](../codequality/configure-unit-tests-by-using-a-.runsettings-file.md).  
  
## See Also  
 [Run unit tests with Test Explorer](../codequality/run-unit-tests-with-test-explorer.md)   
 [Unit Test Your Code](../codequality/unit-test-your-code.md)   
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)