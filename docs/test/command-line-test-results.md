---
title: "Command-Line test results"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, running from command line"
  - "tests, obtaining results"
ms.assetid: 78a5a28a-35e1-4b54-b7b6-c2c1998b4ff0
caps.latest.revision: 27
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
# Command-Line test results
You can use the executable program MSTest.exe to run tests from a command line. MSTest.exe automatically displays a run summary to the command prompt window.  
  
 It also automatically saves test results to disk. In the Summary section of the results output screen, MSTest displays the name of the automatically generated results file. For example:  
  
 **Results file:      D:\temp\test\TestProject3\TestProject3\TestResults\thisuser@ThisUser-32G 9_24_2012 1_27_37 PM.trx**  
  
 If you prefer, you can explicitly save test results to a file that you name. And if your [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] client session is connected to a [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], you can publish results to the database for your team project collection. Both options are described in the following procedures.  
  
> [!NOTE]
>  For information about publishing test data from [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], see [Command-Line options for publishing test results](../test/command-line-options-for-publishing-test-results.md).  
  
### To save command-line test results to a specific file  
  
-   Using the MSTest program, run tests.  
  
     Use the **/resultsfile:[***file name***]** option to specify the name of a file in which you want to save test results. For example:  
  
     **MSTest /testmetadata:Bank.vsmdi /resultsfile:BanktestResults.trx**  
  
    > [!NOTE]
    >  Test results files need the .trx extension to function correctly, but the MSTest command does not automatically supply that extension. Therefore, we recommend that you include the .trx extension when you run this command.  
  
     For more information about the options that you can use with the MSTest program, see [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md).  
  
### To publish command-line test results to the database for the team project collection  
  
-   Using the MSTest program, run tests.  
  
    > [!NOTE]
    >  You can publish test results to the database for the team project collection only if connected to a [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and if you have [!INCLUDE[esprtfc](../codequality/includes/esprtfc_md.md)] installed. For information about how to connect to [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], see [Connect to team projects](../Topic/Connect%20to%20team%20projects%20in%20Team%20Foundation%20Server.md).  
  
     Several command-line options pertain to publishing test results. You use them in combination, depending on which test results you want to publish. Five of these options are required: **/publish**, **/publishbuild**, **/teamproject**, **/platform**, and **/flavor**. One is optional**: /publishresultsfile**.  
  
    -   **Publish current test results**. To run tests and publish their results immediately, use options that specify the tests to run and the required options for publishing. For example:  
  
         **MSTest /testcontainer:test.dll /publish:http://ourtfsmachine:8080 /teamproject:ProjectName /publishbuild:BuildNumber01 /platform:AnyCpu /flavor:Release**  
  
    -   **Publish past test results**. To publish the results of tests that were run previously, omit any command-line options that specify tests to run -- such as **/testcontainer:** and **/testmetadata:**, because you are not running tests. For example:  
  
         **MSTest /publishresultsfile:testResult.trx /publish:http://ourtfsmachine:8080 /teamproject:ProjectName /publishbuild:BuildNumber01 /platform:AnyCpu /flavor:Release**  
  
         For more information about how to use these options, see [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md).  
  
## See Also  
 [Run automated tests from the command line using MSTest](../test/run-automated-tests-from-the-command-line-using-mstest.md)   
 [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md)