---
title: "tcm: Importing Automated Tests into Test Cases"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c8a9f269-b650-4d42-a6f8-d10896559d8d
caps.latest.revision: 23
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
# tcm: Importing Automated Tests into Test Cases
You can import automated tests, such as unit tests or coded UI tests, into your test project to use as part of a test plan. The tests are imported from a test assembly using the following **tcm** command:  
  
-   **tcm testcase /import**  
  
 Each automated test that you select, based on the parameters provided, has a test case created for it. The automated test is automatically associated with that test case. You can add test cases to a static test suite by using this command, or you can add test cases to test suites after you have imported them. For more information about how to add test cases to test suites, see [Plan your tests](../test/planning-manual-tests-using-the-web-portal.md). You can also link these test cases to requirements, so that you can view the status of automated tests for the requirement. For more information about how to do this, see [Link Existing Test Cases to a Requirement](../test_notintoc/how-to--add-product-backlog-items--user-story--or-requirements-work-items-to-your-test-plan.md#LinkTestCasesToRequirements).  
  
 For more information about how to run automated tests from a test plan, see [Automate system tests](../test/automate-system-tests.md).  
  
 tcm.exe is located in **\<Drive:>\Program Files\Microsoft Visual Studio \<version>\Common7\IDE** on any machine that has Visual Studio Enterprise or Visual Studio Test Professional.  
  
> [!WARNING]
>  You can also update existing imported test cases by using this command. If the test cases that you selected to update do not include tests that were previously imported, only the selected test cases are updated. If you specify a test suite to synchronize with when you update the test cases, the tests that are not imported are removed from the test suite but not the test plan itself.  
  
## Syntax  
  
```  
tcm testcase /import /collection:CollectionURL /teamproject:project /storage:path [/maxpriority:priority] [/minpriority:priority] [/category:filter] [/syncsuite:id [/include:]] [/login:username,[password]]  
```  
  
#### Parameters  
  
|**Parameter**|**Description**|  
|-------------------|---------------------|  
|**/collection**:`CollectionURL`|Specifies the URI of the team project collection. The format for the URI is as follows: **http**://*ServerName:Port/VirtualDirectoryName/CollectionName*<br /><br /> If no virtual directory is used, then the format for the URI is as follows:<br /><br /> **http**://*ServerName:Port/CollectionName*|  
|**/teamproject**:`project`|The name of the team project that contains the test plan that you want to import your automated tests into.|  
|**/storage**: `path`|Specifies the path and name of the test assembly that contains your automated tests that you want to import.|  
|**/maxpriority**:`priority`|Optional. Specifies which tests to import based on the maximum priority of the test method. For example, if the parameter is **/maxpriority:1**, only tests with a priority attribute for the test method less than or equal to 1 are imported as test cases from the assembly.|  
|**/minpriority**:`priority`|Optional. Specifies which tests to import based on the minimum priority of the test method. For example, if the parameter is **/minpriority:2**, only tests with a priority attribute for the test method equal or greater than 2 are imported as test cases from the assembly.|  
|**/category**:`filter`|Optional. Specifies which tests to import based on the category of each test method in the test assembly. You can use this parameter together with /syncsuite to import tests with a certain category into a specific test suite.<br /><br /> For more information about test categories see [Defining Test Categories to Group Your Tests](../test/defining-test-categories-to-group-your-tests.md).|  
|**/syncsuite**:`id`|Optional. Specifies the suite ID for the test suite in your test plan to which you want to add the test cases that you import. This suite cannot be a dynamic suite or a query-based suite. If you specify a test suite to synchronize to update tests that have already been added, the tests that are not imported are removed from the test suite but not from the test plan itself.<br /><br /> To determine the suite id for the test suite that you want to use, you can use the following command to list the test suites in your team project:<br /><br /> **tcm suites /list**<br /><br /> For more information about this command, see [tcm: Listing test plans, test suites, test configurations, and environments](../test/tcm--listing-test-plans--test-suites--test-configurations--and-environments.md).|  
|**/include**|Optional. Specifies that test methods that are marked with an Ignore() attribute are also imported.|  
|**/login**:`username,[password]`|Optional. Specifies the name and password of a user who is logged on to the application-tier server for [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and who has permissions to run the command. You would use this option if your Windows credentials do not have the appropriate permissions, or you are using basic authentication, or you are not connected to a domain.<br /><br /> To login to Visual Studio Team Services, you will also need to use **/allowalternatecredentials** listed below.|  
|**/allowalternatecredentials**|This flag must be specified in addition to the /login parameter when connecting to Visual Studio Team Services. (This flag is only available if you have Visual Studio 2013 Update 4 or greater.)|  
  
 You can add parameters for **/collection** and **/teamproject** to the **tcm.exe.config** XML file which is located in the same directory as **tcm.exe**: **\<Drive:>\Program Files\Microsoft Visual Studio 11.0\Common7\IDE**. If you add these to the file, you do not have to enter them on the command line each time you run a **tcm** command. You can add these keys and their values to the file, as follows, in the **appSettings** section:  
  
```  
  
<appSettings>  
     <add key="TeamFoundationServer" value="http://<ServerName:Port/VirtualDirectoryName/CollectionName>"/>  
     <add key ="TeamProject" value="DinnerNow"/>  
</appSettings>  
  
```  
  
## Examples  
  
## Import Test Cases  
 The following examples assume that you have started a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt. (Go to Start, All Programs, Microsoft Visual Studio, Visual Studio Tools, Developer Command Prompt.)  
  
 The command prompt opens to the folder: **\<drive>:\Program Files\Microsoft Visual Studio 11.0\VC**  
  
 Change directory to the folder that contains the assembly built from your test project.  
  
 The following command imports tests from the TestProject1.dll into the DinnerNow team project:  
  
```  
tcm testcase /import /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow /storage:TestProject1.dll  
```  
  
 The following command imports only the test cases with a priority of 1:  
  
```  
tcm testcase /import /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow /storage:TestProject1.dll /maxpriority:1  
```  
  
 The following command imports only the test cases in the SmokeTest and ShoppingCart categories and adds them to the test suite with id of 3:  
  
```  
tcm testcase /import /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow /storage:TestProject1.dll /category:"ShoppingCart&SmokeTest" /syncsuite:3  
```  
  
## See Also  
 [Plan your tests](../test/planning-manual-tests-using-the-web-portal.md)   
 [Using tcm to import and run automated tests for a test plan from the command line](../test/using-tcm-to-import-and-run-automated-tests-for-a-test-plan-from-the-command-line.md)