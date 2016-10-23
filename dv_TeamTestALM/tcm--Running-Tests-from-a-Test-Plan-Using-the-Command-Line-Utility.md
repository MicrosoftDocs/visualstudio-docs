---
title: "tcm: Running Tests from a Test Plan Using the Command Line Utility"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 80bfd9e4-2959-4ee6-a3cb-0cff6e06605e
caps.latest.revision: 32
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
# tcm: Running Tests from a Test Plan Using the Command Line Utility
You can run automated tests that are part of a test plan from the command line. This lets you start a test run using a batch file so that you can schedule a run. You can also manage the test runs from the command line. If you want to export a test run so that a developer can view the test results using Visual Studio, you can use **tcm** to accomplish this. You can also publish test run results from a Visual Studio test run file (.trx) using **tcm**. You can specify which results from this test run file that you want to publish back to your test plan. You can use the following **tcm** commands to accomplish these tasks:  
  
-   **tcm run /create**  
  
-   **tcm run /list**  
  
-   **tcm run /execute**  
  
-   **tcm run /abort**  
  
-   **tcm run /delete**  
  
-   **tcm run /export**  
  
-   **tcm run /publish**  
  
 tcm.exe is located in **<Drive:>\Program Files\Microsoft Visual Studio <version\>\Common7\IDE** on any computer that has Visual Studio Enterprise or Visual Studio Test Professional.  
  
 For more information about how to import automated tests into your test project and set up your test plan to run these tests, see [Create Test Cases from an Assembly of Automated Tests](assetId:///d7a31fc7-7773-4bcc-a8e2-65279934559b#CreateTestCases) and [Run automated tests from the command line using tcm](../dv_TeamTestALM/Run-automated-tests-from-the-command-line-using-tcm.md).  
  
## Syntax  
  
```  
tcm run /create /title:title /planid: id /collection:CollectionURL /teamproject:project (suiteid:id /configid:configid | /querytext: query) [/settingsname:name] [/owner:owner] [/builddir:directory]  [/testenvironment:name] [/login:username,[password]] [/include]  
```  
  
```  
tcm run /execute /id:id /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm run /list [/planid:id | /querytext: query] /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm run /abort /id:id /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm run /delete /id:id /collection:CollectionURL /teamproject:project [/login:username,[password]] [/noprompt]  
```  
  
```  
tcm run /export /id:id /resultsfile:path /collection:CollectionURL /teamproject:project [/login:username,[password]] [/attachment:attachmentname]  
```  
  
```  
tcm run /publish /suiteid:id /configid:id /resultowner:owner /resultsfile:path /collection:CollectionURL /teamproject:project    [/title: runtitle] [/runowner:owner] [/build:buildnumber /builddefinition:builddefinition] [/flavor:flavor [/platform:platform]  [/assignfailurestouser:user] [/login:username,[password]] [/buildverification]  
```  
  
#### Parameters  
  
|**Parameter**|**Description**|  
|-------------------|---------------------|  
|**/collection**:`CollectionURL`|Specifies the URI of the team project collection. The format for the URI is as follows: **http**://*ServerName:Port/VirtualDirectoryName/CollectionName*<br /><br /> If no virtual directory is used, then the format for the URI is as follows:<br /><br /> **http**://*ServerName:Port/CollectionName*|  
|**/teamproject**:`project`|The name of the team project that contains the test plan that you want to import your automated tests into.|  
|**/title**: `title`|Specifies the title that you want to use for the run that you create or if you publish a test run file.|  
|**/planid**:`id`|Specifies the plan that contains the tests that you want to run or the plan that is associated with the test runs that you want to list.|  
|**/suiteid**:`id`|Specifies the test suites that you want to run.<br /><br /> It can also specify the test suite to use when you publish a test run. **Note:**  To find the suite id, you can list the test suites for a test plan. For more information, see [tcm: Listing test plans, test suites, test configurations, and environments](../dv_TeamTestALM/tcm--Listing-test-plans--test-suites--test-configurations--and-environments.md). **Tip:**  To run more than one test suite, you can use the /querytext parameter.|  
|**/configid**:`configid`|Specifies which test configuration you want to run for your test suites.<br /><br /> It can also specify the test configuration to use when you publish a test run. **Tip:**  To run more than one test configuration, you can use the /querytext parameter.|  
|**/querytext**:`query`|Specifies the query to use to return the test runs or the query to use to select the tests that you want to run. **Tip:**  You can use the /querytest parameter to run more than one test suite. For example: **querytext:“SELECT \* FROM TestPoint WHERE (ConfigurationId=20 OR ConfigurationId=21) AND (Suiteid=1185 OR Suiteid=1186)”**|  
|**/settingsname**:`name`|Optional. Specifies the test settings that you want to use for this test run. If you do not select test settings with this parameter, the default test settings for automated tests in the test plan is used.|  
|**/owner**:`owner`|Optional. Specifies the owner of the test run.|  
|**/runowner**:`owner`|Optional. Specifies the owner of the test run.|  
|**/builddir**:`directory`|Optional. Specifies the build directory to use to locate the test assemblies for the automated test. If this is not specified the build location is used based on the build that is currently assigned to the test plan.|  
|**/testenvironment**:`name`|Optional. Specifies the test environment that you want to use for this test run. If you do not select a test environment with this parameter, the default test environment for automated tests in the test plan is used.|  
|**/id**:`id`|Specifies the run id that you want to delete, abort or export.|  
|**/resultsfile**:`path`|Specifies the location to use to export a test run or to find the test run to publish it. For example, "c:\temp\ResultsForDeveloper.trx".|  
|**/attachment**:`attachmentname`|Specifies the name of the attachment for a test run that you export.|  
|**/resultowner**:`owner`|Specifies the owner for the test results.|  
|**/build**:`buildnumber`|Optional. Specifies the build number to use to publish a test run. This parameter must be used with **/builddefinition**.|  
|**/builddefinition**:`builddefinition`|Optional. Specifies the build definition to use to publish a test run. This parameter must be used with **/build**.|  
|**/flavor**:`flavor`|Optional. Specifies the build flavor. For example, Release. This parameter can only be used if the **/build** parameter is used.|  
|**/platform**:`platform`|Optional. Specifies the build platform. For example, x86. This parameter can only be used if the **/build** parameter is used.|  
|**/assignfailurestouser**:`user`|Optional. Specifies to whom to assign any failed tests in the test run.|  
|**/buildverification**|Optional. Specifies that this test run contains build verification tests that check the basic functionality of your build.|  
|**/include**|Optional. Specifies that all tests that are selected for the test run are included, even if the tests are not currently set to the Active state.|  
|**/noprompt**|Optional. Specifies that the user is not prompted to confirm deletion of a test run.|  
|**/login**:`username,[password]`|Optional. Specifies the name and password of a user who is logged on to the application-tier server for Team Foundation Server and who has permissions to run the command. You would use this option if your Windows credentials do not have the appropriate permissions, or you are using basic authentication, or you are not connected to a domain.<br /><br /> To login to Visual Studio Team Services, you will also need to use **/allowalternatecredentials** listed below.|  
|**/allowalternatecredentials**|This flag must be specified in addition to the **/login** parameter when connecting to Visual Studio Team Services. (This flag is only available if you have Visual Studio 2013 Update 4 or greater.)|  
  
 You can add parameters for **/collection** and **/teamproject** to the **tcm.exe.config** XML file which is located in the same directory as **tcm.exe**: **<Drive:>\Program Files\Microsoft Visual Studio <version\>\Common7\IDE**. If you add these to the file, you do not have to enter them on the command line each time you run a **tcm** command. You can add these keys and their values to the file, as follows, in the **appSettings** section:  
  
```  
  
<appSettings>  
     <add key="TeamFoundationServer" value="http://<ServerName:Port/VirtualDirectoryName/CollectionName>"/>  
     <add key ="TeamProject" value="DinnerNow"/>  
</appSettings>  
  
```  
  
## Examples  
  
## Running Tests and Managing Test Runs  
 The following examples assume that you have started a Visual Studio command prompt. (Go to Start, All Programs, Microsoft Visual Studio, Visual Studio Tools, Developer Command Prompt.)  
  
 The command prompt opens to the folder: **<drive\>:\Program Files\Microsoft Visual Studio <version\>\VC**  
  
 Change directory to the folder that contains the assembly built from your test project.  
  
> [!IMPORTANT]
>  To run automated tests from the command line using tcm.exe, you must have your test cases associated with your automated tests. You must also set up your test plan correctly to use a build to locate the automated tests to run if you do not specify the build information on the command line. For more information about how to do this, see [How to: Create Test Cases from an Assembly of Automated Tests Using tcm.exe](assetId:///d7a31fc7-7773-4bcc-a8e2-65279934559b).  
  
 To get the necessary ids for the following commands, you may have to use **tcm** to list the test artifacts and their ids. For more information about how to do this, see [tcm: Listing test plans, test suites, test configurations, and environments](../dv_TeamTestALM/tcm--Listing-test-plans--test-suites--test-configurations--and-environments.md) and [Run automated tests from the command line using tcm](../dv_TeamTestALM/Run-automated-tests-from-the-command-line-using-tcm.md).  
  
 The following command runs tests using a test point query:  
  
```  
tcm run /create /title:"Nightly Run" /planid:1 /querytext:"SELECT * FROM TestPoint WHERE ConfigurationId=13" /settingsname:"<Name of your automated test settings>" /testenvironment:"<Name of a matching environment>" /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command runs tests using a specific test suite and configuration:  
  
```  
tcm run /create /title:"Nightly Run" /planid:1 /suiteid:5 /configid:13 /settingsname:"<Name of your automated test settings>" /testenvironment:"<Name of a matching environment>" /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command runs tests using a specific ID:  
  
```  
Tcm run /execute /id:1207 /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command lists the test runs for a specific test plan:  
  
```  
tcm run /list /planid:1 /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command deletes a specific test run:  
  
```  
tcm run /delete /id:1009 /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command exports a test run to a .trx file:  
  
```  
tcm run /export /id:1273 /resultsfile:"c:\temp\latest.trx" /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
 The following command publishes a test run for a specific test suite and test configuration and reassigns the owner. This updates the existing test points for the test cases in the test suite paired with this configuration to the results in the .trx file:  
  
```  
tcm run /publish /suiteid:5 /configid:13 /resultowner:"<Name of new owner>" /resultsfile:"c:\temp\latest.trx" /collection:<CollectionURL> /teamproject:<Team Project name>  
```  
  
## See Also  
 [tcm: Listing test plans, test suites, test configurations, and environments](../dv_TeamTestALM/tcm--Listing-test-plans--test-suites--test-configurations--and-environments.md)   
 [Using tcm to import and run automated tests for a test plan from the command line](../dv_TeamTestALM/Using-tcm-to-import-and-run-automated-tests-for-a-test-plan-from-the-command-line.md)