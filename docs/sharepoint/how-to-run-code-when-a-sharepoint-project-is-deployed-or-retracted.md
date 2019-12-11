---
title: "Run code when SharePoint project is deployed or retracted"
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
# How to: Run code when a SharePoint project is deployed or retracted
  If you want to perform additional tasks when a SharePoint project is deployed or retracted, you can handle events that are raised by Visual Studio. For more information, see [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md).

### To run code when a SharePoint project is deployed or retracted

1. Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:

   - [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md)

   - [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)

   - [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)

2. In the extension, access the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object. For more information, see [How to: Retrieve the SharePoint project service](../sharepoint/how-to-retrieve-the-sharepoint-project-service.md).

3. Handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events of the project service.

4. In the event handlers, use the <xref:Microsoft.VisualStudio.SharePoint.DeploymentEventArgs> parameter to get information about the current deployment session. For example, you can determine which project is in the current deployment session and whether it is being deployed or retracted.

   The following code example demonstrates how to handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events in a project extension. This extension writes an additional message to the **Output** window when deployment starts and completes for a SharePoint project.

   [!code-csharp[SPExtensibility.ProjectSystemExtension.General#12](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/handleprojectdeploymentevents.cs#12)]
   [!code-vb[SPExtensibility.ProjectSystemExtension.General#12](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/handleprojectdeploymentevents.vb#12)]

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)
- [How to: Run code when deployment steps are executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md)
