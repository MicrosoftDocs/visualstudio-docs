---
title: "How to: Run Code When a SharePoint Project is Deployed or Retracted | Microsoft Docs"
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
# How to: Run Code When a SharePoint Project is Deployed or Retracted
  If you want to perform additional tasks when a SharePoint project is deployed or retracted, you can handle events that are raised by Visual Studio. For more information, see [Extending SharePoint Packaging and Deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md).  
  
### To run code when a SharePoint project is deployed or retracted  
  
1.  Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:  
  
    -   [How to: Create a SharePoint Project Item Extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md)  
  
    -   [How to: Create a SharePoint Project Extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)  
  
    -   [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)  
  
2.  In the extension, access the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object. For more information, see [How to: Retrieve the SharePoint Project Service](../sharepoint/how-to-retrieve-the-sharepoint-project-service.md).  
  
3.  Handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events of the project service.  
  
4.  In the event handlers, use the <xref:Microsoft.VisualStudio.SharePoint.DeploymentEventArgs> parameter to get information about the current deployment session. For example, you can determine which project is in the current deployment session and whether it is being deployed or retracted.  
  
 The following code example demonstrates how to handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events in a project extension. This extension writes an additional message to the **Output** window when deployment starts and completes for a SharePoint project.  
  
 [!code-csharp[SPExtensibility.ProjectSystemExtension.General#12](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/handleprojectdeploymentevents.cs#12)]
 [!code-vb[SPExtensibility.ProjectSystemExtension.General#12](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/handleprojectdeploymentevents.vb#12)]  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Packaging and Deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)   
 [How to: Run Code When Deployment Steps are Executed](../sharepoint/how-to-run-code-when-deployment-steps-are-executed.md)  
  
  