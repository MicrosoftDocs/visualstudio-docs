---
title: "Overview of programming model of SharePoint tools extensions"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visual Studio, extending tools"
  - "SharePoint development in Visual Studio, extensibility object models"
  - "SharePoint development in Visual Studio, extending tools"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Overview of the programming model of SharePoint tools extensions
  When you create an extension for the SharePoint tools in Visual Studio, you begin by implementing one or more extensibility interfaces that are exposed by the SharePoint tools. In most cases, you will also use other types provided by the SharePoint tools to implement features in your extension. In some scenarios you might also use types in other object models provided by Visual Studio and SharePoint. You must understand the purpose of each of these object models and know how to use them with each other to create extensions for the SharePoint tools.

## Extend the SharePoint tools by implementing extensibility interfaces
 Visual Studio uses the Managed Extensibility Framework (MEF) in the .NET Framework 4 to provide the extensibility model for the SharePoint tools. MEF is an API (implemented in the System.ComponentModel.Composition assembly) that enables applications to expose extensibility points and to discover and load extensions at run time. For more information about MEF, see [Managed Extensibility Framework &#40;MEF&#41;](/dotnet/framework/mef/index).

 To extend the SharePoint tools, implement one or more extensibility interfaces that are exposed by Visual Studio. You must also apply the <xref:System.ComponentModel.Composition.ExportAttribute>, and additional SharePoint tools-specific attributes as necessary, to your interface implementation. The following table lists the interfaces you can implement to extend the SharePoint tools.

|Interface|Description|
|---------------|-----------------|
|<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider>|Implement this interface to define a new type of SharePoint project item. For an example, see [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).|
|<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension>|Implement this interface to extend a type of SharePoint project item that is already installed in Visual Studio. For an example, see [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md).|
|<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension>|Implement this interface to extend SharePoint projects. For an example, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentStep>|Implement this interface to define a new deployment step that can be executed when a SharePoint project item is deployed or retracted. For an example, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension>|Implement this interface to extend an existing node under the **SharePoint Connections** node in the **Server Explorer** window. For an example, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider>|Implement this interface to define a new type of node under the **SharePoint Connections** node in the **Server Explorer** window. For an example, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Validation.IFeatureValidationRule>|Implement this interface to define a custom feature validation rule. For an example, see [How to: Create custom feature and package validation rules for SharePoint solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Validation.IPackageValidationRule>|Implement this interface to define a custom package validation rule. For an example, see [How to: Create custom feature and package validation rules for SharePoint solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).|

 After you implement an extension of the SharePoint tools, you must deploy the extension assembly in a Visual Studio extension (VSIX) package to enable Visual Studio to discover and load the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## Understand the object models that you use in SharePoint tools extensions
 There are several object models you can use when you create extensions for the SharePoint tools:

- *SharePoint tools object model*. This object model provides the extensibility interfaces that you implement to create SharePoint tools extensions, and other related types.

- *Visual Studio automation and integration object models*. Use these object models to access Visual Studio features that are beyond the scope of the SharePoint tools object model.

    > [!NOTE]
    > You can convert some objects in the SharePoint tools object model to objects in the Visual Studio automation and integration object models, and vice versa, by using the SharePoint project service. For more information, see [Convert between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).

- *SharePoint server and client object models*. Use these object models to modify a SharePoint site or to retrieve data from a SharePoint site from the context of a SharePoint tools extension.

### SharePoint tools object model
 Each SharePoint tools extension uses types in the SharePoint tools object model to define the core behavior and functionality of the extension. The following tables describe the namespaces that are included in this object model, by the assembly that contains them.

#### Microsoft.VisualStudio.SharePoint.dll

|Namespace|Description|
|-|-|
|<xref:Microsoft.VisualStudio.SharePoint>|Contains types that you use to extend and automate the SharePoint project system. For example, you can extend the built-in SharePoint projects and project items, or you can create your own project items. For more information, see [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Deployment>|Contains types that you use to extend the deployment process for SharePoint projects, such as creating your own deployment steps and deployment configurations. For more information, see [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Explorer>|Contains types that you use to extend nodes under the **SharePoint Connections** node in the **Server Explorer** window, or to define new types of nodes. For more information, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).|
|<xref:Microsoft.VisualStudio.SharePoint.Features>|Contains types that you use to access the Feature definitions in a SharePoint project.|
|<xref:Microsoft.VisualStudio.SharePoint.Packages>|Contains types that you use to access the package definition in a SharePoint solution.|
|<xref:Microsoft.VisualStudio.SharePoint.Validation>|Contains types that you use to customize the Feature and package validation behavior for SharePoint projects. For more information, see [How to: Create custom feature and package validation rules for SharePoint solutions](../sharepoint/how-to-create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).|

#### Microsoft.VisualStudio.SharePoint.Commands.dll

|Namespace|Description|
|-|-|
|<xref:Microsoft.VisualStudio.SharePoint.Commands>|Contains types that you can use to create custom *SharePoint commands*. A SharePoint command is a method that calls into the SharePoint server object model from a SharePoint tools extension. For more information, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).|

#### Microsoft.VisualStudio.SharePoint.Explorer.Extensions.dll

|Namespace|Description|
|-|-|
|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions>|Contains types that you can use to get information about built-in **Server Explorer** nodes that represent individual components on a SharePoint site, such as a node that represents a list, field, or content type. For more information, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).|

### Visual Studio automation object model
 The Visual Studio automation object model provides APIs that you can use to automate Visual Studio projects and the IDE. Use the Visual Studio object model to perform project-related tasks that are not specific to SharePoint projects, or to perform other general automation tasks in Visual Studio. Traditionally, this object model is often used in Visual Studio add-ins and macros, but you can also use it in SharePoint tools extensions.

 The main part of the Visual Studio automation object model is defined in the *EnvDTE.dll* assembly. The *EnvDTE\\\<version>.dll* assemblies provide additional functionality that was introduced in specific versions of Visual Studio. These assemblies are included with Visual Studio.

 For more information about the automation object model, see [Visual Studio SDK Reference](../extensibility/visual-studio-sdk-reference.md).

### Visual Studio integration object model
 The integration object model provides APIs that you can use to add features to Visual Studio by creating a *VSPackage*. A VSPackage is a module that extends the Visual Studio IDE by providing custom features such as tool windows, editors, designers, services, and projects.

 You can use the integration object model if you want to add a new Visual Studio feature that will be used with the built-in SharePoint tools. For example, if you create a custom SharePoint project item that represents a custom action for a SharePoint site, you can also create a VSPackage that implements a designer for the custom action. You can associate the designer with the custom action by adding a shortcut menu item to the project item that represents the custom action in **Solution Explorer**. You can open your designer by opening its shortcut menu (either by right-clicking the custom action project item or by choosing it and then choosing the **Shift**+**F10** keys) and then choosing **Open**.

 This object model is defined in a set of assemblies that are included with the Visual Studio SDK. Some of the main assemblies in this object model include *Microsoft.VisualStudio.Shell.11.0.dll*, *Microsoft.VisualStudio.Shell.Interop.dll*, and *Microsoft.VisualStudio.OLE.Interop.dll*.

 For more information about the integration object model, see [Automation Model Overview](../extensibility/internals/automation-model-overview.md) and [Visual Studio SDK Reference](../extensibility/visual-studio-sdk-reference.md).

### SharePoint object models
 SharePoint tools extensions can use SharePoint APIs to modify a SharePoint site or to retrieve data from a SharePoint site. [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] and [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] provide two different object models: a server object model and a client object model.

 You can use APIs in either object model in a SharePoint tools extension, but each object model has some benefits and drawbacks in the context of SharePoint tools extensions. For more information, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

|Object model|Description|
|------------------|-----------------|
|Server object model|The server object model provides access to all of the features that [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] and [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] expose programmatically. This object model is designed to be used by SharePoint solutions that run on the SharePoint server. The majority of this object model is defined in the *Microsoft.SharePoint.dll* assembly. For more information about the server object model, see [Using the SharePoint Foundation Server-Side Object Model](/previous-versions/office/developer/sharepoint-2010/ee538251(v=office.14)).|
|Client object model|The client object model is a subset of the server object model that can be used to interoperate with SharePoint data from a remote client or server. It is designed to minimize the number of round trips that must be executed to perform common tasks. The majority of the client object model is defined in the *Microsoft.SharePoint.Client.dll* and *Microsoft.SharePoint.Client.Runtime.dll* assemblies. For more information about the client object model, see [Managed Client Object Model](/previous-versions/office/developer/sharepoint-2010/ee537247(v=office.14)).|

## See also
- [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md)
- [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md)
- [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md)
