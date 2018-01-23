---
title: "How to: Edit a SharePoint Deployment Configuration | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.Project.DeploymentConfig"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, deploying"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Edit a SharePoint Deployment Configuration
  You can create a deployment configuration or modify an existing deployment configuration. For example, you could run a single step or change the order of the steps in the deployment process. You may want to create or modify deployment configurations because the built-in and programmatically added configurations cannot be changed.  
  
## Creating a SharePoint Deployment Configuration  
  
#### To create a SharePoint deployment configuration  
  
1.  In **Solution Explorer**, choose a SharePoint project, and then, on the menu bar, choose **Project**, *ProjectName***Properties**.  
  
2.  On the **SharePoint** tab, choose the **New** button.  
  
     The **Add New Deployment Configuration** dialog box appears.  
  
3.  In the **Name** text box, enter a name for the deployment configuration.  
  
4.  In the **Available Deployment Steps** pane, choose the steps that you want to add to the deployment configuration, choose the (**>**) button, and then choose the **OK** button.  
  
    > [!NOTE]  
    >  If you have configured a pre-deployment command or a post-deployment command, these steps run only if you add them to a customized deployment configuration.  
  
## Changing the Active Deployment Configuration  
  
#### To change the active deployment configuration  
  
1.  In **Solution Explorer**, choose a SharePoint project, and then, on the menu bar, choose **Project**, *ProjectName***Properties**.  
  
2.  Choose the **SharePoint** tab.  
  
3.  In the **Active Deployment Configuration** list box, choose the name of the deployment configuration that you want to use.  
  
## See Also  
 [Packaging and Deploying SharePoint Solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)  
  
  