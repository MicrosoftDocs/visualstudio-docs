---
title: "How to: Create a SharePoint Command | Microsoft Docs"
description: Learn how to create a custom SharePoint command to call the API of the server object model in a SharePoint tools extension.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint commands [SharePoint development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Create a SharePoint command
  If you want to use the server object model in a SharePoint tools extension, you must create a custom *SharePoint command* to call the API. You define the SharePoint command in an assembly that can call into the server object model directly.

 For more information about the purpose of SharePoint commands, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

### To create a SharePoint command

1. Create a class library project that has the following configuration:

    - Targets the .NET Framework 3.5. For more information about selecting the target framework, see [How to: Target a Version of the .NET Framework](../ide/visual-studio-multi-targeting-overview.md).

    - Targets the AnyCPU or x64 platform. By default, the target platform for class library projects is AnyCPU. For more information about selecting the target platform, see [How to: Configure Projects to Target Platforms](../ide/how-to-configure-projects-to-target-platforms.md).

    > [!NOTE]
    > You cannot implement a SharePoint command in the same project that defines a SharePoint tools extension, because SharePoint commands target the .NET Framework 3.5 and SharePoint tools extensions target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. You must define any SharePoint commands that are used by your extension in a separate project. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

2. Add references to the following assemblies:

    - Microsoft.VisualStudio.SharePoint.Commands

    - Microsoft.SharePoint

3. In a class in the project, create a method that defines your SharePoint command. The method must conform to the following guidelines:

    - It can have one or two parameters.

         The first parameter must be a <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> object. This object provides the Microsoft.SharePoint.SPSite or Microsoft.SharePoint.SPWeb in which the command is executed. It also provides an <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandLogger> object that can be used to write messages to the **Output** window or **Error List** window in Visual Studio.

         The second parameter can be a type of your choice, but this parameter is optional. You can add this parameter to your SharePoint command if you need to pass data from your SharePoint tools extension to the command.

    - It can have a return value, but this is optional.

    - The second parameter and return value must be a type that can be serialized by the Windows Communication Foundation (WCF). For more information, see [Types Supported by the Data Contract Serializer](/dotnet/framework/wcf/feature-details/types-supported-by-the-data-contract-serializer) and [Using the XmlSerializer Class](/dotnet/framework/wcf/feature-details/using-the-xmlserializer-class).

    - The method can have any visibility (**public**, **internal**, or **private**), and it can be static or non-static.

4. Apply the <xref:Microsoft.VisualStudio.SharePoint.Commands.SharePointCommandAttribute> to the method. This attribute specifies a unique identifier for the command; this identifier does not have to match the method name.

     You must specify the same unique identifier when you call the command from your SharePoint tools extension. For more information, see [How to: Execute a SharePoint command](../sharepoint/how-to-execute-a-sharepoint-command.md).

## Example
 The following code example demonstrates a SharePoint command that has the identifier `Contoso.Commands.UpgradeSolution`. This command uses APIs in the server object model to upgrade to a deployed solution.

 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/SharePointCommands/Commands.cs" id="Snippet5":::
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/sharepointcommands/commands.vb" id="Snippet5":::

 In addition to the implicit first <xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter, this command also has a custom string parameter that contains the full path of the .wsp file that is being upgraded to the SharePoint site. To see this code in the context of a larger example, see [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md).

## Compiling the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint.Commands

- Microsoft.SharePoint

## Deploying the command
 To deploy the command, include the command assembly in the same [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (*vsix*) package with the extension assembly that uses the command. You must also add an entry for the command assembly in the extension.vsixmanifest file. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md)
- [How to: Execute a SharePoint command](../sharepoint/how-to-execute-a-sharepoint-command.md)
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)
