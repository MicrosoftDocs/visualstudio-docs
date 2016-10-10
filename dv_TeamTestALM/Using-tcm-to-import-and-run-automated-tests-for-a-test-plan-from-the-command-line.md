---
title: "Using tcm to import and run automated tests for a test plan from the command line"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b45def12-0e67-4270-89ea-67c41bc188a7
caps.latest.revision: 11
manager: douge
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
# Using tcm to import and run automated tests for a test plan from the command line
Tcm.exe is a command-line utility that lets you perform the following tasks:  
  
-   Import automated tests into a test plan  
  
-   Run tests that are part of a test plan from the command line  
  
-   View a list of test items and their corresponding IDs to use when you import tests or run tests  
  
 For more information about how to create test plans, see [Defining a Test Plan](../Topic/Defining%20a%20Test%20Plan.md).  
  
 tcm.exe is located in **<Drive:>\Program Files\Microsoft Visual Studio <version\>\Common7\IDE** on any machine that has Visual Studio Enterprise or Visual Studio Test Professional.  
  
## Global Parameters  
 You can use the following parameters to display Help text for **tcm**.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**/help**<br /><br /> or<br /><br /> **/?**|Displays the syntax and parameters for the **tcm** command-line tool.|  
|**command /help**<br /><br /> or<br /><br /> **command /?**|Displays the syntax and parameters for the **tcm** command that you specify.|  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Importing Automated Tests:** If you have created automated tests using Visual Studio, you might want to run these tests as part of a test plan. By adding them to a test plan, you can measure your testing progress. You can associate these tests with requirements or user stories. In addition, you can view the results from these automated tests and any other tests in your test plan together and track the progress that you are making. You can also analyze the results every time that you run these tests using Microsoft Test Manager.<br /><br /> Tcm.exe provides an easy way to import automated tests from a test assembly and associate them with test cases using the following syntax:<br /><br /> **tcm testcase /import**|-   [How to: Create Test Cases from an Assembly of Automated Tests Using tcm.exe](assetId:///d7a31fc7-7773-4bcc-a8e2-65279934559b)<br />-   [tcm: Importing Automated Tests into Test Cases](../dv_TeamTestALM/tcm--Importing-Automated-Tests-into-Test-Cases.md)|  
|**Running Tests that are Part of a Test Plan from the Command Line:** You can run test cases with associated automation from the command line using tcm.exe instead of using the user interface provided by Microsoft Test Manager. This enables you to start runs automatically from a batch file. For example, you can then decide to schedule that batch file to run every time that a build is completed.<br /><br /> Use the following command to run tests using tcm.exe:<br /><br /> **tcm run**<br /><br /> You can also manage test runs, export test results and publish test results to a test plan using **tcm run**.|-   [Run automated tests from the command line using tcm](../dv_TeamTestALM/Run-automated-tests-from-the-command-line-using-tcm.md)<br />-   [tcm: Running Tests from a Test Plan Using the Command Line Utility](../dv_TeamTestALM/tcm--Running-Tests-from-a-Test-Plan-Using-the-Command-Line-Utility.md)|  
|**Viewing a List of Test Items:** To import tests or run tests using tcm.exe, you have to provide the IDs for certain test items. You can view a list of these items and their IDs using commands that are part of tcm.exe.<br /><br /> For example, to view test suites use the following command:<br /><br /> **tcm suites /list**|-   [tcm: Listing test plans, test suites, test configurations, and environments](../dv_TeamTestALM/tcm--Listing-test-plans--test-suites--test-configurations--and-environments.md)|  
|**Importing or Exporting Mappings to a Bug Field:** You can create a bug when a tester finds a code defect when using Microsoft Test Manager. The **tcm** command-line utility supports the import and export of a mapping file to the team project. The mapping file defines the type of work item to create when the user takes this action and the three data fields to be filled in by Microsoft Test Manager. The three fields are test steps, system information, and the build in which the defect was found. When testers run a test and find a defect, they can create a bug in which the three fields are filled in automatically.|-   [tcm: Customize and manage the test experience](../Topic/Customize%20and%20manage%20the%20test%20experience.md)|