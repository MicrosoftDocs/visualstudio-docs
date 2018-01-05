---
title: "Extending SharePoint Packaging and Deployment | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, extending deployment"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Extending SharePoint Packaging and Deployment
  You can extend the packaging and deployment process for SharePoint projects.
  
##  Creating Deployment Steps  
 When you deploy a SharePoint project, [!INCLUDE[vs_current_short](../sharepoint/includes/vs-current-short-md.md)] executes a series of deployment steps. Visual Studio includes built-in deployment steps for many tasks, such as retracting and adding solutions. However, you can also create your own deployment steps.  
  
 For a walkthrough that demonstrates how to create a deployment step, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
##  Creating Deployment Configurations  
 A deployment configuration is a set of deployment steps that is executed for a given project but can affect all SharePoint project items. Every deployment configuration includes one set of steps that is executed when the project is deployed, and another set that is executed when the project is retracted. [!INCLUDE[vs_current_short](../sharepoint/includes/vs-current-short-md.md)] includes two built-in deployment configurations, but you can also create your own. When you create a deployment configuration, you can include built-in deployment steps and deployment steps that you create.  
  
 For a walkthrough that demonstrates how to create a deployment configuration, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
##  Run Code When a SharePoint Solution is Deployed or Retracted  
 You can handle events to perform additional tasks when a SharePoint solution is deployed or retracted. Visual Studio raises events that you can handle in the following scenarios:  
  
-   Before and after each deployment step is executed for a SharePoint project item. For more information, see [How to: Run Code When Deployment Steps are Executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md).  
  
-   Before and after a SharePoint project is deployed or retracted. For more information, see [How to: Run Code When a SharePoint Project is Deployed or Retracted](../sharepoint/how-to-run-code-when-a-sharepoint-project-is-deployed-or-retracted.md).  
  
##  Handling Deployment Conflicts  
 Some types of SharePoint project items, including modules, Web parts, list instances, and content types, provide built-in deployment conflict resolution. When you deploy a solution that contains one of these project items, Visual Studio first checks whether a file already exists on the SharePoint site with the same name, URL, or ID as a file in the item you are deploying. If a conflict exists, Visual Studio can automatically resolve the conflict, or it can prompt you to determine whether you want to have Visual Studio resolve the conflict or cancel the deployment. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).  
  
 You can extend this feature by providing your own code that checks for and resolves deployment conflicts. For more information, see [How to: Handle Deployment Conflicts](../sharepoint/how-to-handle-deployment-conflicts.md).  
  
##  Run Command Line Operations Before or After a Project is Deployed  
 If you want to run a command line operation when a SharePoint solution is deployed, you can set the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PreDeploymentCommand%2A> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PostDeploymentCommand%2A> properties of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. Visual Studio executes these commands before and after the project is deployed.  
  
 In some cases, you may see deployment conflicts. There are several different ways to resolve conflicts. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).  
  
##  Customizing Validation Rules  
 Before you deploy a solution package (.wsp), you can create custom Feature and package validation rules to verify that the Feature or package is valid. For example, you can report information, warnings, or errors to developers to help them fix validation problems. For more information, see [How to: Create Custom Feature and Package Validation Rules for SharePoint Solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).  
  
## See Also  
 [How to: Run Code When Deployment Steps are Executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md)   
 [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md)   
 [How to: Create Custom Feature and Package Validation Rules for SharePoint Solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md)   
 [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md)  
  
  
