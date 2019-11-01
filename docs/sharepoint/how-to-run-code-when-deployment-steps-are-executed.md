---
title: "How to: Run Code When Deployment Steps are Executed | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, extending deployment"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Run code when deployment steps are executed
  If you want to perform additional tasks for a deployment step in a SharePoint project, you can handle events that are raised by SharePoint project items before and after Visual Studio executes each deployment step. For more information, see [Extending SharePoint Packaging and Deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md).

### To run code when deployment steps are executed

1. Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:

    - [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md)

    - [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)

    - [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)

2. In the extension, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepCompleted> events of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType> object (in a project item extension or project extension) or an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition> object (in a definition of a new project item type).

3. In the event handlers, use the <xref:Microsoft.VisualStudio.SharePoint.DeploymentStepStartedEventArgs> and <xref:Microsoft.VisualStudio.SharePoint.DeploymentStepCompletedEventArgs> parameters to get information about the deployment step. For example, you can determine which deployment step is executing and whether the solution is being deployed or retracted.

## Example
 The following code example demonstrates how to handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepCompleted> events in an extension for the List Instance project item. This extension writes an additional message to the **Output** window when Visual Studio recycles the application pool while deploying and retracting the solution.

 [!code-vb[SPExtensibility.ProjectSystemExtension.General#4](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/handledeploymentstepevents.vb#4)]
 [!code-csharp[SPExtensibility.ProjectSystemExtension.General#4](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/handledeploymentstepevents.cs#4)]

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)
- [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md)
- [How to: Run code when a SharePoint project is deployed or retracted](../sharepoint/how-to-run-code-when-a-sharepoint-project-is-deployed-or-retracted.md)
