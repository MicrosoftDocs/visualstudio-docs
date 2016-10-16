---
title: "Test Area 4: Check In"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "source control [Visual Studio SDK], checking items in"
  - "source control plug-ins, checking items in"
ms.assetid: d0329fa8-7a8d-4d30-b67b-6f2a97b75a30
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Test Area 4: Check In
This source-control plug-in test area covers sending updated items to the version store via the **Check In** command.  
  
## Command Menu Access  
 The following [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] integrated development environment menu paths are used in the test cases.  
  
##### Check In:  
 **File**, **Source Control**, **Check In**.  
  
 **File**, **Check In**.  
  
 Shortcut menu, **Check In**.  
  
## Common Expected Behavior  
  
-   Projects and files added to a solution or project under source control appear in the **Check In** dialog box and the **Pending Checkins** window.  
  
-   After the check in, added items appear in source control.  
  
-   After the check in, updated items are properly versioned in the store.  
  
## Test Cases  
 The following are specific test cases for the Checkin test area.  
  
### Case 4a: Modified items  
 Describes using the check in action to update a file under source control that has been modified.  
  
|Action|Test Steps|Expected Results to Verify|  
|------------|----------------|--------------------------------|  
|Modify a text file that has been checked out, check in file only (**Check In** dialog box)|1.  Create a new project with a text file.<br />2.  Add the solution to source control.<br />3.  Check out and modify the text file.<br />4.  Check in via the Check In dialog box (**File**, **Source Control**, **Check In**).|Common Expected Behavior.|  
|Modify a text file that has been checked out, Check in file only (**Pending Checkins** window)|1.  Create a new project with a text file.<br />2.  Add the solution to source control.<br />3.  Check out and modify the text file.<br />4.  Check in via the **Pending Checkins** window.|Common Expected Behavior.|  
  
### Case 4b: Adding files  
 When adding a file to a project or an item to a solution, the project or solution must change also. Thus the parent file is also checked out and must be checked in to complete the addition.  
  
|Action|Test Steps|Expected Results to Verify|  
|------------|----------------|--------------------------------|  
|Add a text file and check in everything (**Check In** dialog box)|1.  Create a new project.<br />2.  Add the solution to source control.<br />3.  Add a text file to the project.<br />4.  Accept check out of the project if prompted.<br />5.  Select the solution in **Solution Explorer**.<br />6.  Check in from the **Check In** dialog box.|Common Expected Behavior.|  
|Add a text file and check in everything (**Pending Checkins** window)|1.  Create a new project.<br />2.  Add the solution to source control.<br />3.  Add a text file to the project.<br />4.  Accept check out of the project if prompted.<br />5.  Check in solution from **Pending Checkins** window.|Common Expected Behavior|  
  
### Case 4c: Adding projects  
 When adding a project to a solution, the solution must change also. Thus the solution file is also checked out and must be checked in to complete the addition.  
  
|Action|Test Steps|Expected Results to Verify|  
|------------|----------------|--------------------------------|  
|Add a project to a blank solution under source control (**Check In** dialog box)|1.  Create a blank solution.<br />2.  Add the solution to source control.<br />3.  Add a new project.<br />4.  Accept check out of the solution if prompted.<br />5.  Check in from the **Check In** dialog box.|Common Expected Behavior.|  
|Add a project to a blank solution under source control (**Pending Checkins** window)|1.  Create a blank solution.<br />2.  Add the solution to source control.<br />3.  Add a new project.<br />4.  Accept check out of the solution if prompted.<br />5.  Check in solution from **Pending Checkins** window.|Common Expected Behavior.|  
  
## See Also  
 [Test Guide for Source Control Plug-ins](../extensibility/test-guide-for-source-control-plug-ins.md)