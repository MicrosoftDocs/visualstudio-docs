---
title: "How to: Execute a SharePoint Command | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint commands [SharePoint development in Visual Studio], executing"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Execute a SharePoint command
  If you want to use the server object model in a SharePoint tools extension, you must create a custom *SharePoint command* to call the API. After you define the command and deploy it with your SharePoint tools extension, your extension can execute the command to call into the SharePoint server object model. To execute the command, use one of the ExecuteCommand methods of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection> object.

 For more information about the purpose of SharePoint commands, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

### To execute a SharePoint command

1. In your SharePoint tools extension, get an <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection> object. The way you get an <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection> object depends on the type of extension you are creating:

    - In an extension of the SharePoint project system, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.SharePointConnection%2A> property.

         For more information about project system extensions, see [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md).

    - In an extension of the **SharePoint Connections** node in **Server Explorer**, use the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeContext.SharePointConnection%2A> property. To get an <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeContext> object, use the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode.Context%2A> property.

         For more information about **Server Explorer** extensions, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).

    - In code that is not part of an extension of the SharePoint tools, such as a project template wizard, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.SharePointConnection%2A> property.

         For more information about retrieving the project service, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

2. Call one of the ExecuteCommand methods of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection> object. Pass the name of the command you want to execute to the first argument of the ExecuteCommand method. If your command has a custom parameter, pass that parameter to the second argument of the ExecuteCommand method.

     There is a different ExecuteCommand overload for each supported command signature. The following table lists the supported signatures and which overload to use for each signature.

    |Command signature|ExecuteCommand overload to use|
    |-----------------------|------------------------------------|
    |The command has only the default <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter and no return value.|<xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A>|
    |The command has only the default <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter and a return value.|<xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A>|
    |The command has two parameters (the default <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter and a custom parameter) and no return value.|<xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A>|
    |The command has two parameters and a return value.|<xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A>|

## Example
 The following code example demonstrates how to use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A> overload to call the `Contoso.Commands.UpgradeSolution` command that is described in [How to: Create a SharePoint command](../sharepoint/how-to-create-a-sharepoint-command.md).

 [!code-csharp[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#6](../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/deploymentstepextension/upgradestep.cs#6)]
 [!code-vb[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#6](../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/deploymentstepextension/upgradestep.vb#6)]

 The `Execute` method shown in this example is an implementation of the <xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentStep.Execute%2A> method of the <xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentStep> interface in a custom deployment step. To see this code in the context of a larger example, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).

 Note the following details about the call to the <xref:Microsoft.VisualStudio.SharePoint.ISharePointConnection.ExecuteCommand%2A> method:

- The first parameter identifies the command that you want to call. This string matches the value that you pass to the <xref:Microsoft.VisualStudio.SharePoint.Commands.SharePointCommandAttribute> on the command definition.

- The second parameter is the value that you want to pass to the custom second parameter of the command. In this case, it is the full path of the *.wsp* file that is being upgraded to the SharePoint site.

- The code does not pass the implicit <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter to the command. This parameter is passed into the command automatically when you call the command from an extension of the SharePoint project system or an extension of the **SharePoint Connections** node in **Server Explorer**. In other types of solutions, such as in a project template wizard that implements the <xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface, this parameter is **null**.

## Compile the code
 This example requires a reference to the Microsoft.VisualStudio.SharePoint assembly.

## See also
- [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md)
- [How to: Create a SharePoint command](../sharepoint/how-to-create-a-sharepoint-command.md)
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)
