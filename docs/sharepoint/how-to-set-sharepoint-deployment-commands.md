---
title: "How to: Set SharePoint Deployment Commands | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, deploying"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Set SharePoint deployment commands
  You can customize the deployment process by setting pre-deployment and post-deployment commands. These commands run before and after other deployment actions when you debug SharePoint solutions from Visual Studio.

### To add a pre-deployment command

1. On the menu bar, choose **Project** > **\<*ProjectName*> Properties**.

2. Choose the **SharePoint** tab.

3. In the **Pre-deployment Command Line** text box, enter MS-DOS or MSBuild commands to customize this step.

     For example, to list the directory contents before deployment is completed, enter **dir**.

### To add a post-deployment command

1. On the menu bar, choose **Project** > **\<*ProjectName*> Properties**.

2. Choose the **SharePoint** tab.

3. In the **Post-deployment Command Line** text box, enter MS-DOS or MSBuild commands to customize this step.

     For example, to list the directory contents after deployment is completed, enter **dir**. To use a MSBuild variable to copy the assembly from the build directory, enter **copy $(TargetPath) c:\DeploymentDirectory**.

## See also
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
