---
title: "Calling into the SharePoint Object Models | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, client object model"
  - "SharePoint development in Visual Studio, server object model"
  - "SharePoint commands [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, extensibility features"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Call into the SharePoint object models
  When you create extensions for the SharePoint tools in Visual Studio, you might have to call SharePoint APIs to perform certain tasks. For example, if you create a custom deployment step for SharePoint projects, you might have to call SharePoint APIs to perform some of the tasks to deploy solutions.

 [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] and [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] provide two different object models that you can use in SharePoint tools extensions: a server object model and a client object model. Each object model has benefits and drawbacks in the context of SharePoint tools extensions.

 For an overview of the SharePoint object models, see [Overview of the programming model of SharePoint tools extensions](../sharepoint/overview-of-the-programming-model-of-sharepoint-tools-extensions.md).

## Use the client object model in extension projects
 When you develop an extension for the SharePoint tools, you can use the client object model in your project like any other set of managed APIs. You can add references to assemblies in the client object model to your project, and you can call APIs in the client object model directly from your code.

 However, the client object model has two drawbacks in the context of SharePoint tools extensions:

- The client object model provides only a subset of the server object model. If you have to use SharePoint functionality that is not exposed in the client object model, then you must use the server object model.

- Although using the client object model in SharePoint tools extensions should work in most cases, you might encounter some scenarios where calls to the client object model do not work as expected. The client object model is designed to be used in client applications to call into SharePoint sites on a remote server or farm. The SharePoint tools in Visual Studio work only with a local SharePoint installation on the development computer. Therefore, when you use the client object model in a SharePoint tools extension, you call into a SharePoint site on the local computer, which is not how the client object model was designed to be used.

  For a walkthrough that demonstrates how to use the client object model in an extension of the SharePoint tools in Visual Studio, see [Walkthrough: Call into the SharePoint client object model in a Server Explorer extension](../sharepoint/walkthrough-calling-into-the-sharepoint-client-object-model-in-a-server-explorer-extension.md).

## Use the server object model in extension projects
 The server object model is a superset of the client object model. When you use the server object model, you can use all the features that [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] and [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] expose programmatically.

 SharePoint tools extensions can use APIs in the server object model, but they cannot call the APIs directly. The server object model can be called only from a 64-bit process that targets the .NET Framework 3.5. However, SharePoint tools extensions require the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] and they run in the 32-bit Visual Studio process. This prevents SharePoint tools extensions from referencing the assemblies in the SharePoint server object model directly.

 If you want to use the server object model in a SharePoint tools extension, you must create a custom *SharePoint command* to call the API. You define the SharePoint command in a secondary assembly that can call into the server object model directly. In your extension project, you call the SharePoint command indirectly by using the ExecuteCommand method of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection> object.

 For more information about creating and using SharePoint commands, see [How to: Create a SharePoint command](../sharepoint/how-to-create-a-sharepoint-command.md) and [How to: Execute a SharePoint command](../sharepoint/how-to-execute-a-sharepoint-command.md). For information about how to deploy SharePoint commands, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

 For walkthroughs that demonstrate how to create and use SharePoint commands, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md) and [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md).

### Understand how SharePoint commands are executed
 Assemblies that define SharePoint commands are loaded in a 64-bit host process named *vssphost4.exe*. After you call a SharePoint command in a SharePoint tools extension, the command is executed by *vssphost4.exe* instead of the 32-bit Visual Studio process (*devenv.exe*). You can control some aspects of how SharePoint commands are executed by setting values in the registry. For more information, see [Debug extensions for the SharePoint tools in Visual Studio](../sharepoint/debugging-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [How to: Create a SharePoint command](../sharepoint/how-to-create-a-sharepoint-command.md)
- [How to: Execute a SharePoint command](../sharepoint/how-to-execute-a-sharepoint-command.md)
- [Overview of the programming model of SharePoint tools extensions](../sharepoint/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)
