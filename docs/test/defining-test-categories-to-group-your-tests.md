---
title: "Defining Test Categories to Group Your Tests"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test categories"
ms.assetid: 2c26a648-f068-4d60-99b6-b9747b7bdbc9
caps.latest.revision: 37
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
# Defining Test Categories to Group Your Tests
If you have created automated tests using Visual Studio you can manage these tests by categorizing them with *test categories*. When you run these automated tests using Visual Studio, [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)], or mstest.exe, you can use these test categories to easily select which tests you run. You add test categories as attributes to your test methods.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 Test categories provide more flexibility than the test lists functionality from earlier versions of Microsoft Visual Studio. You can use logical operators with test categories to run tests from multiple categories together or to limit the tests that you run to tests that belong to multiple categories. Also test categories are easy to add as you create your test methods and you do not have to maintain test lists after you have created your test methods. By using test categories, you do not have to check in and check out the **\<solution name>.vsmdi** file that maintains the test lists.  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Grouping Tests into Test Categories:** You can add an automated test to one or multiple test categories using a test attribute. Each test can belong to multiple test categories.|-   [How to: Group and Run Automated Tests Using Test Categories](../test/how-to--group-and-run-automated-tests-using-test-categories.md)|  
|**Running Tests Using Test Categories:** After you choose which tests you want to run, you can choose which test categories they must belong to. You do this by using logical operators. For example, you could run all tests that belong to Priority 1 test category and Priority 2 test category.|-   [VSTest.Console.exe command-line options](../test/vstest.console.exe-command-line-options.md)<br />-   [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md)|  
|**Using Test Categories To Select Tests to Run Before Check-In:** You can use a build to check your code changes before you check in. You can use test categories to define the tests to run for this gated check-in build.|-   [Use gated check-in to validate changes](../Topic/Use%20a%20gated%20check-in%20build%20process%20to%20validate%20changes.md)|  
|**Using Test Categories To Select Tests to Run After Building Your Application or Before Check-In:** You can use a build definition to define which test categories to run to test a new build.|-   [How to: Configure and Run Scheduled Tests After Building Your Application](assetId:///32acfeb1-b1aa-4afb-8cfe-cc209e6183fd)|  
  
## See Also  
 [Creating Automated Tests Using Microsoft Test Manager](assetId:///7b5075ee-ddfe-411d-b1d4-94283550a5d0)