---
title: "Test Area 2: Get From Source Control"
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
  - "source control plug-ins, getting items from source control"
  - "source control [Visual Studio SDK], getting items from"
ms.assetid: cbd345c5-ca43-4630-b7a4-85564f4e2090
caps.latest.revision: 18
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
# Test Area 2: Get From Source Control
This test area covers test cases for retrieving items from the version store via the Get command. These test cases can be applied to both local and to Web projects.  
  
## Command Menu Access  
 The following [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] integrated development environment menu paths are used in the test cases.  
  
##### Get Latest Version:  
  
-   **File**, **Source Control**, **Get Latest Version**.  
  
-   **File**, **Get Latest Version**.  
  
-   Shortcut menu, **Get Latest Version**.  
  
-   Get: **File**, **Source Control**, **Get**.  
  
## Expected Behavior  
  
##### Get Latest Version:  
 Performs a silent (no UI) retrieval of the latest version of the item from the version store.  
  
##### Get:  
 Displays the **Get** dialog box and allows the user to make changes to the file set that will be retrieved as well as modify the options that affect how the files are retrieved.  
  
## Test Cases  
  
|Action|Test Steps|Expected Results to Verify|  
|------------|----------------|--------------------------------|  
|Get Latest Version of a file that does NOT exist locally|1.  Create a project.<br />2.  Add an item to the project.<br />3.  Put the project under source control.<br />4.  Delete local copy of item.<br />5.  Get Latest Version of the item (Shortcut Menu, **Get Latest Version**).|Item file is retrieved locally.|  
|Get a file that does NOT exist locally|1.  Create a project.<br />2.  Add an item to the project.<br />3.  Put the project under source control.<br />4.  Delete local copy of item.<br />5.  Get the item (**File**, **Source Control**, **Get** \<item>).|Item file is retrieved locally.|  
|Get a file that has been checked out exclusively and modified locally|1.  Create a project.<br />2.  Add an item to the project.<br />3.  Put the project under source control.<br />4.  Check out the project item exclusively.<br />5.  Modify the local copy.<br />6.  Get Latest Version of the item (**File**, **Get Latest Version of** \<item>). If this step succeeds, continue to next step.<br />7.  Click **Replace** button in the warning dialog box.|**ReResult from Step 6** `:`<br /><br /> Warning dialog box indicates that file is checked out.<br /><br /> **ReResult from Step 7:**<br /><br /> Modified local file is replaced by the original version from the version store.<br /><br /> File is read/write.|  
|Get and Replace file that is checked out, shared, and modified locally|1.  Create a new project.<br />2.  Add an item to the project.<br />3.  Put the project under source control.<br />4.  Check out the project item as shared.<br />5.  Modify the local copy.<br />6.  Get Latest Version of the item (**File**, **Get Latest Version of** \<item>). If this step succeeds, continue to next step.<br />7.  Click **Replace** in the warning dialog box.|**Result from Step 6:**<br /><br /> Warning dialog box indicates that file is checked out.<br /><br /> **Result from Step 7:**<br /><br /> Modified local file is replaced by the original version from the version store.<br /><br /> File is read/write.|  
|Get a file that DOES exist locally, same as latest version in the version store|1.  Create a new project.<br />2.  Add an item to the project.<br />3.  Put the project under source control.<br />4.  Get the item (**File**, **Source Control**, **Get** \<item>).|Local file is unchanged.|  
|Get a solution with one project|1.  Create a solution with one project.<br />2.  Place the solution under source control.<br />3.  Delete all the project files locally.<br />4.  Get the solution (**File**, **Source Control**, **Get**).|All deleted files are restored locally.|  
  
## See Also  
 [Test Guide for Source Control Plug-ins](../extensibility/test-guide-for-source-control-plug-ins.md)