---
title: "tcm: Listing test plans, test suites, test configurations, and environments"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c927aa26-a2d4-4e84-af39-c6a09de0bf99
caps.latest.revision: 18
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
# tcm: Listing test plans, test suites, test configurations, and environments
To run your tests from the command line using tcm.exe or to import your test cases into a specific test suite, you need the names and the IDs of the artifacts that are required to run the tests. You can get a list of test artifacts from the command line by using the following **tcm** commands:  
  
-   **tcm plans /list**  
  
-   **tcm suites /list**  
  
-   **tcm configs /list**  
  
-   **tcm testenvironments /list**  
  
 tcm.exe is located in **\<Drive:>\Program Files\Microsoft Visual Studio 11.0\Common7\IDE** on any machine that has Visual Studio Enterprise or Visual Studio Test Professional.  
  
## Syntax  
  
```  
tcm plans /list [/querytext:query] /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm suites /list [/planid: id | /querytext:query] /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm configs /list [/querytext:query] /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm testenvironments /list /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
#### Parameters  
  
|**Parameter**|**Description**|  
|-------------------|---------------------|  
|**/querytext**:`query`|Specifies the query to use to return the test artifacts.|  
|**/planid**:`id`|Specifies that only the test suites in this test plan will be listed.|  
|**/collection**:`CollectionURL`|Specifies the URI of the team project collection. The format for the URI is as follows: **http**://*ServerName:Port/VirtualDirectoryName/CollectionName*<br /><br /> If no virtual directory is used, then the format for the URI is as follows:<br /><br /> **http**://*ServerName:Port/CollectionName*|  
|**/teamproject**:`project`|The name of the team project that contains the test plan that you want to import your automated tests into.|  
|**/login**:`username,[password]`|Optional. Specifies the name and password of a user who is logged on to the application-tier server for [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and who has permissions to run the command. You would use this option if your Windows credentials do not have the appropriate permissions, or you are using basic authentication, or you are not connected to a domain.<br /><br /> To login to Visual Studio Team Services, you will also need to use **/allowalternatecredentials** listed below.|  
|**/allowalternatecredentials**|This flag must be specified in addition to the **/login** parameter when connecting to Visual Studio Team Services. (This flag is only available if you have Visual Studio 2013 Update 4 or greater.)|  
  
 You can add parameters for **/collection** and **/teamproject** to the **tcm.exe.config** XML file which is located in the same directory as **tcm.exe**: **\<Drive:>\Program Files\Microsoft Visual Studio 11.0\Common7\IDE**. If you add these to the file, you do not need to have them on the command line each time you run a **tcm** command. You can add these keys and their values to the file, as follows, in the **appSettings** section:  
  
```  
  
<appSettings>  
     <add key="TeamFoundationServer" value=""http://<ServerName:Port/VirtualDirectoryName/CollectionName>"/>  
     <add key ="TeamProject" value="DinnerNow"/>  
</appSettings>  
  
```  
  
## Examples  
  
## List Test Items  
 The following examples assume that you have started a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
 To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
 The command prompt opens to the folder: **\<drive>:\Program Files\Microsoft Visual Studio 11.0\VC**  
  
 The following command lists the test configurations in the DinnerNow team project:  
  
```  
tcm configs /list /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow  
```  
  
 The following command lists only the test plan Sprint 1 in the DinnerNow team project so that you can view its ID:  
  
```  
tcm plans /list /querytext:"SELECT * FROM TestPlan WHERE PlanName=’Sprint 1’" /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow  
```  
  
 The following command lists the test suites in the test plan with ID 3 in the DinnerNow team project:  
  
```  
tcm suites /list /planid:3 /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow  
```  
  
## See Also  
 [tcm: Running Tests from a Test Plan Using the Command Line Utility](../test/tcm--running-tests-from-a-test-plan-using-the-command-line-utility.md)   
 [Using tcm to import and run automated tests for a test plan from the command line](../test/using-tcm-to-import-and-run-automated-tests-for-a-test-plan-from-the-command-line.md)