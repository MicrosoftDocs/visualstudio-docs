---
title: "How to: Retrieve the SharePoint Project Service | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project service"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Retrieve the SharePoint project service
  You can access the SharePoint project service in the following types of solutions:

- An extension of the SharePoint project system, such as a project extension, project item extension, or project item type definition. For more information about these types of extensions, see [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md).

- An extension of the **SharePoint Connections** node in **Server Explorer**. For more information about these types of extensions, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).

- Another type of Visual Studio extension, such as a VSPackage.

## Retrieve the service in project system extensions
 In any extension of the SharePoint project system, you can access the project service by using the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectService%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object.

 You can also retrieve the project service by using the following procedures.

#### To retrieve the service in a project extension

1. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface, locate the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method.

2. Use the *projectService* parameter to access the service.

     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple project extension.

     [!code-vb[SPExtensibility.ProjectService.FromProjectSystemExtensions#1](../sharepoint/codesnippet/VisualBasic/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.vb#1)]
     [!code-csharp[SPExtensibility.ProjectService.FromProjectSystemExtensions#1](../sharepoint/codesnippet/CSharp/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.cs#1)]

     For more information about creating project extensions, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

#### To retrieve the service in a project item extension

1. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> interface, locate the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize%2A> method.

2. Use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType.ProjectService%2A> property of the *projectItemType* parameter to retrieve the service.

     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple extension of the **List Definition** project item.

     [!code-vb[SPExtensibility.ProjectService.FromProjectSystemExtensions#2](../sharepoint/codesnippet/VisualBasic/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.vb#2)]
     [!code-csharp[SPExtensibility.ProjectService.FromProjectSystemExtensions#2](../sharepoint/codesnippet/CSharp/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.cs#2)]

     For more information about creating project item extensions, see [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md).

#### To retrieve the service in a project item type definition

1. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface, locate the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType%2A> method.

2. Use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.ProjectService%2A> property of the *typeDefinition* parameter to retrieve the service.

     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple project item type definition.

     [!code-vb[SPExtensibility.ProjectService.FromProjectSystemExtensions#3](../sharepoint/codesnippet/VisualBasic/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.vb#3)]
     [!code-csharp[SPExtensibility.ProjectService.FromProjectSystemExtensions#3](../sharepoint/codesnippet/CSharp/spextensibility.projectservice.fromprojectsystemextensions.getprojectservice/extension/extension.cs#3)]

     For more information about defining project item types, see [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).

## Retrieve the service in Server Explorer extensions
 In an extension of the **SharePoint Connections** node in **Server Explorer**, you can access the project service by using the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode.ServiceProvider%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode> object.

#### To retrieve the service in a Server Explorer extension

1. Get an <xref:System.IServiceProvider> object from the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode.ServiceProvider%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode> object in your extension.

2. Use the <xref:System.IServiceProvider.GetService%2A> method to request an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object.

     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window from a shortcut menu that the extension adds to list nodes in **Server Explorer**.

     [!code-vb[SPExtensibility.ProjectService.FromSPExplorerExtensions#1](../sharepoint/codesnippet/VisualBasic/spextensibility.projectservice.fromspexplorerextensions.getprojectservice/extension/extension.vb#1)]
     [!code-csharp[SPExtensibility.ProjectService.FromSPExplorerExtensions#1](../sharepoint/codesnippet/CSharp/spextensibility.projectservice.fromspexplorerextensions.getprojectservice/extension/extension.cs#1)]

     For more information about extending the **SharePoint Connections** node in **Server Explorer**, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).

## Retrieve the Service in other Visual Studio extensions
 You can retrieve the project service in a VSPackage, or in any Visual Studio extension that has access to a <xref:EnvDTE80.DTE2> object in the automation object model, such as a project template wizard that implements the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface.

 In a VSPackage, you can request an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object by using one of the following methods:

- The <xref:System.IServiceProvider.GetService%2A> method of a managed VSPackage that derives from the <xref:Microsoft.VisualStudio.Shell.Package> class. For more information, see [How to: Get a Service](../extensibility/how-to-get-a-service.md).

- The static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method. For more information, see [Use GetGlobalService](../extensibility/internals/service-essentials.md#how-to-use-getglobalservice).

  In a Visual Studio extension that has access to a <xref:EnvDTE80.DTE2> object, you can request an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object by using the <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GetService%2A> method of a <xref:Microsoft.VisualStudio.Shell.ServiceProvider> object. For more information, see [Getting a service from the DTE object](../extensibility/how-to-get-a-service.md#getting-a-service-from-the-dte-object).

## See also
- [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md)
- [How to: Get a service](../extensibility/how-to-get-a-service.md)
- [How to: Use wizards with project templates](../extensibility/how-to-use-wizards-with-project-templates.md)
