---
title: "Troubleshooting Generic Tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "generic tests, on 32-bit platform"
  - "generic tests, gathering code-coverage data"
  - "generic tests, on 64-bit platform"
  - "generic tests, troubleshooting"
ms.assetid: 0d20dc99-a0a9-4898-85d8-903669228c7f
caps.latest.revision: 19
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
# Troubleshooting Generic Tests
When you run generic tests, you might encounter the following error: Gathering code-coverage data does not work when you run a generic test on a 64-bit platform. To solve this error, use the information in the following section, [Circumventing the 32-Bit Limitation](#Circumventing32BitLimitation).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
##  <a name="Circumventing32BitLimitation"></a> Circumventing the 32-Bit Limitation  
 Code coverage instrumentation works only in 32-bit mode, not in 64-bit mode. This is because an assembly can only be loaded in 32-bit mode after it has been instrumented for code coverage.  
  
> [!NOTE]
>  No such limitation applies when you run unit tests on a 64-bit computer if you are not gathering code-coverage data. This is because VSTestHost.exe, the test engine that loads the class library, runs in a 32-bit process.  
  
 For a generic test, the wrapped application is built against "Any CPU," which on a 64-bit computer is executed as a 64-bit process. When this 64-bit process tries to load a 32-bit assembly, an error occurs. You can solve this problem in one of the following ways.  
  
 Use the following method if your generic test directly wraps the binary file into which your production code has been compiled:  
  
-   [Change the Solution Configuration to x86](#ChangeConfigTox86)  
  
 Use either of the following two methods if there is a layer between the generic test and the production-code binary file. That is, your generic test wraps an intermediary application as a test harness. This test harness, in turn, runs the production code that you are testing.  
  
-   [Change Build Settings for the Application that Loads the Production-Code Binary File](#BuildSettingsOnAppThatLoadsCUT)  
  
###  <a name="ChangeConfigTox86"></a> Change the Solution Configuration to x86  
 Change the solution configuration from "Any CPU" to "x86."  
  
##### To change the solution configuration  
  
1.  Right-click the solution and then choose **Properties**.  
  
     The **Solution Property Pages** dialog box is displayed.  
  
2.  Under **Configuration Properties**, choose **Configuration**.  
  
3.  Choose **Configuration Manager**.  
  
     The **Configuration Manager** dialog box is displayed.  
  
4.  Under **Active solution platform**, click **New**.  
  
     The **New Solution Platform** dialog box is displayed.  
  
5.  Under **Type or select the new platform**, choose **x86**.  
  
6.  In the **New Solution Platform** dialog box, choose **OK.**  
  
7.  In the dialog box that asks whether you want to save changes, choose **Yes**.  
  
8.  On the **Configuration Manager** dialog box, under **Active solution platform**, make sure that **x86** is selected, and then choose **Close**.  
  
9. On the **Solution Property Pages** dialog box, choose **OK**.  
  
###  <a name="BuildSettingsOnAppThatLoadsCUT"></a> Change Build Settings for the Application that Loads the Production-Code Binary File  
 Use this procedure to instrument any intermediary application, or test harness, that your generic test wraps. This intermediary application runs the code that you want to test.  
  
 In this procedure, you change the settings for the intermediary application to make it build for the x86 platform.  
  
> [!NOTE]
>  You can do this only if the wrapped application is built from a project in your solution.  
  
##### To change the build settings for the wrapped application  
  
1.  In Solution Explorer, right-click the project from which the intermediary application is built, and then choose **Properties**.  
  
     This displays a property page for the project.  
  
2.  Choose the **Build** tab.  
  
3.  For Platform target, specify **x86**.  
  
4.  On the **File** menu, choose **Save Selected Items**.  
  
## See Also  
 [Creating an Automated Test That Runs an Executable Using Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md)