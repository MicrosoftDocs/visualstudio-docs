---
title: "Run automated tests from the command line using tcm"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "automated tests, running from command line"
  - "command line, running automated tests"
  - "command line, TCM"
ms.assetid: ee28496b-d919-489b-b6ff-c2bed2719e0c
caps.latest.revision: 39
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
# Run automated tests from the command line using tcm
You can run test cases with associated automation from the command line using tcm.exe instead of using the user interface provided by [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. This enables you to start runs automatically from a batch file. For example, you can then decide to schedule that batch file to run every time that a build is completed.  
  
 To run these automated test cases so that the test results are part of your test plan, you must use a lab environment. When you start the run from the command line, use tcm.exe. You must specify both the test settings that contain the set of roles that you require to run your tests, and an environment that contains this set of roles. For more information about test settings and environments, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md).  
  
> [!NOTE]
>  If you want to run automated tests that interact with the desktop, you must set up your agent to run as a process instead of a service. For more information, see [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md).  
  
 You can use a query to specify the test case and configuration pairing*,* which are named *test points,* or you can specify the test suites and configurations that you want to run from your test plan. You have to know the IDs for your test plan, your test suites, and configurations. You can use tcm.exe to list these for you if it is required.  
  
 Use the following procedures to gather the information that you have to have in order to run your automated tests from the command line and then run the tests:  
  
-   [List all the configurations in your team project](#ListConfigs)  
  
-   [List all the test plans in your team project](#ListPlans)  
  
-   [List all the test environments for your team project](#ListEnvironments)  
  
-   [List all the test suites in your test plan](#ListSuites)  
  
-   [Create a test run using a test point query](#CreateRunFromQuery)  
  
-   [Create a test run for a test suite and a specific configuration](#CreateRunForSuite)  
  
-   [View and update the test results](#ViewTest)  
  
## Common parameters for the procedures  
  
|**Parameter**|**Description**|  
|-------------------|---------------------|  
|**/collection**:`CollectionURL`|Specifies the URI of the team project collection. The format for the URI is as follows: **http**://*ServerName:Port/VirtualDirectoryName/CollectionName*<br /><br /> If no virtual directory is used, then the format for the URI is as follows:<br /><br /> **http**://*ServerName:Port/CollectionName*<br /><br /> If you do not know the correct path, contact your [!INCLUDE[esprfound](../codequality/includes/esprfound_md.md)] system administrator.|  
|**/teamproject:** *TeamProjectName*|The team project that you want to use. This team project must be defined in the project collection specified by the **/collection** parameter.|  
|**/login:** *UserName,Password*|Optional. Specifies the name and password of a user who is logged on to the application-tier server for [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and who has permissions to run the command.<br /><br /> You would use this option if your Windows credentials do not have the appropriate permissions, or you are using basic authentication, or you are not connected to a domain.<br /><br /> To login to Visual Studio Team Services, you will also need to use **/allowalternatecredentials** listed below.|  
|**/allowalternatecredentials**|This flag must be specified in addition to the **/login** parameter when connecting to Visual Studio Team Services. (This flag is only available if you have Visual Studio 2013 Update 4 or greater.)|  
|**/build**|Optional. Specifies the number of the build that will be associated with the test run. If the /buildDir option is not specified, the drop location of this build will be used to pick up test binaries.|  
|**/buildDefinition**|Name of the build definition that the build belongs to.|  
|**/flavor**|Flavor of the build to be used, in case the build has more than one.|  
|**/platform**|Platform of the Build to be used, in case the build has more than one.|  
|**/?** or **help**|Displays help about the command in the Command Prompt window.|  
  
## Procedures  
  
###  <a name="ListConfigs"></a> List all the configurations in your team project  
  
##### To list all the configurations in your team project  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To list all the configurations in your team project, type the following at the command prompt:  
  
     **tcm configs /list /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Id                          Name**  
  
     **----------------       ------------------**  
  
     **1                            Vista and IE 7**  
  
     **25                          Vista and IE 8**  
  
    > [!NOTE]
    >  You can list plans for your team project too by using the following command: **Tcm plans /list /collection:<CollectionURL> /teamproject:<Team Project name>**  
  
###  <a name="ListPlans"></a> List all the test plans in your team project  
  
##### To list all the test plans in your team project  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To list all the plans in your team project, type the following at the command prompt:  
  
     **tcm plans /list /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Id                          Name**  
  
     **----------------       ------------------**  
  
     **1                            Beta 1 Test Plan**  
  
     **22                          RTM Test Plan**  
  
3.  (Optional) To find all the test suites in a test plan, type the following at the command prompt:  
  
     **tcm suites /list /planid:\<your plan id> /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Id                          Name**  
  
     **----------------       ------------------**  
  
     **1                            Priority 1 Test Suite**  
  
     **15                          Shopping Cart Test Suite**  
  
###  <a name="ListEnvironments"></a> List all the test environments for your team project  
  
##### To list all the test environments for your team project  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To list all the plans in your team project, type the following at the command prompt:  
  
     **tcm testenvironments /list /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Name                             Description**  
  
     **----------------                 ------------------**  
  
     **Staging Environment     Use to test staging environment**  
  
     **Testing Environment for Customer ABC**  
  
###  <a name="ListSuites"></a> List all the test suites in your test plan  
  
##### To list all the test suites in your test plan  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To find all the test suites in your test plan, type the following at the command prompt:  
  
     **tcm suites /list /planid:\<your plan id> /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Id                          Name**  
  
     **----------------       ------------------**  
  
     **1                            Priority 1 Test Suite**  
  
     **15                          Shopping Cart Test Suite**  
  
###  <a name="CreateRunFromQuery"></a> Create a test run using a test point query  
  
##### To create a test run using a test point query  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To create a test run that uses a test point query for a specific test configuration,  use the information in the following table.  
  
    |Id|Value|  
    |--------|-----------|  
    |Planid|1|  
    |Configid|13|  
  
     Type the following at the command prompt:  
  
     **tcm run /create /title:"Nightly Run" /planid:1 /querytext:"SELECT \* FROM TestPoint WHERE ConfigurationId=13" /settingsname:"\<Name of your automated test settings>" /testenvironment:"\<Name of a matching environment>" /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Run created with ID: <xxx>.**  
  
    > [!NOTE]
    >  You must provide a test settings and an environment that matches the set of roles in your test settings for an automated test run using tcm.exe. For more information about test settings and environments, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md). To create test settings, see [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
3.  To view the progress of your test run, follow the steps in [View and Update the Test Results](#ViewTest).  
  
###  <a name="CreateRunForSuite"></a> Create a test run for a test suite and a specific configuration  
  
##### To create a test run for a test suite and a specific configuration  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  To create a test run for all the tests in a test suite for a specific configuration, use the information in the following table.  
  
    |Id|Value|  
    |--------|-----------|  
    |Planid|1|  
    |Suiteid|5|  
    |Configid|13|  
  
     Type the following at the command prompt:  
  
     **tcm run /create /title:"Nightly Run" /planid:1 /suiteid:5 /configid:13 /settingsname:"\<Name of your automated test settings>" /testenvironment:"\<Name of a matching environment>" /collection:\<CollectionURL> /teamproject:\<Team Project name>**  
  
     You’ll see results similar to these:  
  
     **Run created with ID: \<xxx>.**  
  
    > [!NOTE]
    >  You must provide a test settings and an environment that matches the set of roles in your test settings for an automated test run using tcm.exe. For more information about test settings and environments, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md). To create test settings, see [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
3.  To view the progress of your test run, follow the steps in [View and Update the Test Results](#ViewTest).  
  
##  <a name="ViewTest"></a> View and update the test results  
  
#### To view and update the test results  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
    > [!NOTE]
    >  To display the [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] window, choose Start, and then choose All Programs. Point to Microsoft Visual Studio 2012 and then choose Microsoft Test Manager.  
  
2.  To view the test results, choose the down-arrow on the center group switcher and choose **Testing Center**.  
  
3.  On the center group menu bar, choose **Test** and then choose **Analyze Test Runs**.  
  
     The **Analyze Test Runs** activity is displayed that shows any test runs for this test plan.  
  
4.  Open the test run with the title that you gave it from the command line to open and view the details.  
  
     The test run details are displayed.  
  
5.  (Optional) To update the title of your test run, type the new name in **Title**.  
  
6.  (Optional) If your test failed, you can update the reason for the failure. Choose **Resolution** and select the reason for the failure from the list.  
  
7.  (Optional) To add comments to the test result, choose the Comments icon. Type your comments and then choose **Save comments**.  
  
8.  (Optional) To view the details of an individual test, open the test.  
  
     The test result that is displayed shows the details from the test run and the test results history for that test. You can close this view to return to the test run.  
  
    > [!NOTE]
    >  If you determine that there is a bug from your analysis, you can create a bug from this view.  
  
9. To save these changes for this test run, choose **Save** in the toolbar.  
  
## See Also  
 [tcm: Listing test plans, test suites, test configurations, and environments](../test/tcm--listing-test-plans--test-suites--test-configurations--and-environments.md)   
 [tcm: Running Tests from a Test Plan Using the Command Line Utility](../test/tcm--running-tests-from-a-test-plan-using-the-command-line-utility.md)   
 [Running automated tests from the command line](../test/running-automated-tests-from-the-command-line.md)   
 [Plan your tests](../test/planning-manual-tests-using-the-web-portal.md)