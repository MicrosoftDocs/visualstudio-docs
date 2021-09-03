---
title: "Extending SharePoint Packaging and Deployment | Microsoft Docs"
description: Extend SharePoint packaging and deployment. Create deployment steps and configurations. Handle deployment conflicts. Customize validation rules.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, extending deployment"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Extend SharePoint packaging and deployment
  You can extend the packaging and deployment process for SharePoint projects.

## Create deployment steps
 When you deploy a SharePoint project, [!INCLUDE[vs_current_short](../sharepoint/includes/vs-current-short-md.md)] executes a series of deployment steps. Visual Studio includes built-in deployment steps for many tasks, such as retracting and adding solutions. However, you can also create your own deployment steps.

 For a walkthrough that demonstrates how to create a deployment step, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).

## Create deployment configurations
 A deployment configuration is a set of deployment steps that is executed for a given project but can affect all SharePoint project items. Every deployment configuration includes one set of steps that is executed when the project is deployed, and another set that is executed when the project is retracted. [!INCLUDE[vs_current_short](../sharepoint/includes/vs-current-short-md.md)] includes two built-in deployment configurations, but you can also create your own. When you create a deployment configuration, you can include built-in deployment steps and deployment steps that you create.

 For a walkthrough that demonstrates how to create a deployment configuration, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).

## Run code when a SharePoint solution is deployed or retracted
 You can handle events to perform additional tasks when a SharePoint solution is deployed or retracted. Visual Studio raises events that you can handle in the following scenarios:

- Before and after each deployment step is executed for a SharePoint project item. For more information, see [How to: Run code when deployment steps are executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md).

- Before and after a SharePoint project is deployed or retracted. For more information, see [How to: Run code when a SharePoint project is deployed or retracted](../sharepoint/how-to-run-code-when-a-sharepoint-project-is-deployed-or-retracted.md).

## Handle deployment conflicts
 Some types of SharePoint project items, including modules, Web parts, list instances, and content types, provide built-in deployment conflict resolution. When you deploy a solution that contains one of these project items, Visual Studio first checks whether a file already exists on the SharePoint site with the same name, URL, or ID as a file in the item you are deploying. If a conflict exists, Visual Studio can automatically resolve the conflict, or it can prompt you to determine whether you want to have Visual Studio resolve the conflict or cancel the deployment. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).

 You can extend this feature by providing your own code that checks for and resolves deployment conflicts. For more information, see [How to: Handle deployment conflicts](../sharepoint/how-to-handle-deployment-conflicts.md).

## Run command line operations before or after a project is deployed
 If you want to run a command line operation when a SharePoint solution is deployed, you can set the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PreDeploymentCommand%2A> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PostDeploymentCommand%2A> properties of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. Visual Studio executes these commands before and after the project is deployed.

 In some cases, you may see deployment conflicts. There are several different ways to resolve conflicts. For more information, see [Troubleshoot SharePoint packaging and deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).

## Customize validation rules
 Before you deploy a solution package (.wsp), you can create custom Feature and package validation rules to verify that the Feature or package is valid. For example, you can report information, warnings, or errors to developers to help them fix validation problems. For more information, see [How to: Create custom feature and package validation rules for SharePoint solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).

## See also
- [How to: Run code when deployment steps are executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md)
- [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md)
- [How to: Create custom feature and package validation rules for SharePoint solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md)
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
