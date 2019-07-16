---
title: "Publishing ClickOnce Applications | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.Dialog.Options"
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.PublishWizard.Help"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, publishing"
  - "ClickOnce applications, publishing"
  - "applications [Visual Studio], ClickOnce deployment"
  - "deploying applications [ClickOnce], publishing ClickOnce applications"
ms.assetid: eb6dfe79-f54c-4331-8e36-073688e70973
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Publish ClickOnce applications
When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application for the first time, publish properties can be set using the Publish Wizard. Only a few of the properties are available in the wizard; all other properties are set to their default values.

 Subsequent changes to publish properties are made on the **Publish** page in the **Project Designer**.

## Publish Wizard
 You can use the Publish Wizard to set the basic settings for publishing your application. This includes the following publishing properties:

- Publishing Folder Location - where Visual Studio will copy the files (local computer, network file share, FTP server, or Web site)

- Installation Folder Location - where end users will install from (network file share, FTP server, Web site, CD/DVD)

- Online or Offline availability - if end users can access the application with or without a network connection

- Update frequency - how often the application checks for new updates.

  For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

## Publish Page
 The **Publish** page of the **Project Designer** is used to configure properties for ClickOnce deployment. The following table lists topics.

|Title|Description|
|-----------|-----------------|
|[How to: Specify where Visual Studio copies the files](../deployment/how-to-specify-where-visual-studio-copies-the-files.md)|Describes how to set where Visual Studio puts the application files and manifests.|
|[How to: Specify the location where end users will install from](../deployment/how-to-specify-the-location-where-end-users-will-install-from.md)|Describes how to set the location where users go to download and install the application.|
|[How to: Specify the ClickOnce offline or online install mode](../deployment/how-to-specify-the-clickonce-offline-or-online-install-mode.md)|Describes how to set whether the application will be available offline or online.|
|[How to: Set the ClickOnce publish version](../deployment/how-to-set-the-clickonce-publish-version.md)|Describes how to set the ClickOnce **Publish Version** property, which determines whether or not the application that you are publishing will be treated as an update.|
|[How to: Automatically increment the ClickOnce publish version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)|Describes how to automatically increment the Revision number of the **PublishVersion** each time you publish the application.|

 For more information, see [Publish Page, Project Designer](../ide/reference/publish-page-project-designer.md)

### Application Files dialog box
 This dialog box allows you to specify how the files in your project are categorized for publishing, dynamic downloading, and updating. It contains a grid that lists the project files that are not excluded by default, or that have a download group.

 To exclude files, mark files as data files or prerequisites, and create groups of files for conditional installation in the Visual Studio UI, see [How to: Specify which files are published by ClickOnce](../deployment/how-to-specify-which-files-are-published-by-clickonce.md). You can also mark data files by using the Mage.exe. For more information, see [How to: Include a data file in a ClickOnce application](../deployment/how-to-include-a-data-file-in-a-clickonce-application.md).

### Prerequisites dialog box
 This dialog box specifies which prerequisite components are installed, as well as how they are installed. For more information, see [How to: Install prerequisites with a ClickOnce application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md) and [Prerequisites dialog box](../ide/reference/prerequisites-dialog-box.md).

### Application Updates dialog box
 This dialog box specifies how the application installation should check for updates. For more information, see [How to: Manage updates for a ClickOnce application](../deployment/how-to-manage-updates-for-a-clickonce-application.md).

### Publish Options dialog box
 The Publish Options dialog box specifies an application's deployment options.

|||
|-|-|
|[How to: Change the publish language for a ClickOnce application](../deployment/how-to-change-the-publish-language-for-a-clickonce-application.md)|Describes how to specify a language and culture to match the localized version.|
|[How to: Specify a Start menu name for a ClickOnce application](../deployment/how-to-specify-a-start-menu-name-for-a-clickonce-application.md)|Describes how to change the display name for a ClickOnce application.|
|[How to: Specify a link for Technical Support](../deployment/how-to-specify-a-link-for-technical-support.md)|Describes how to set the **Support URL** property, which identifies a Web page or file share where users can go to get information about the application.|
|[How to: Specify a Support URL for individual prerequisites in a ClickOnce deployment](../deployment/how-to-specify-a-support-url-for-individual-prerequisites-in-a-clickonce-deployment.md)|Demonstrated how to manually alter an application manifest to include individual support URLs for each prerequisite.|
|[How to: Specify a publish page for a ClickOnce application](../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md)|Describes how to generate and publish a default Web page (publish.htm) along with the application|
|[How to: Customize the ClickOnce default Web page](../deployment/how-to-customize-the-default-web-page-for-a-clickonce-application.md)|Describes how to customize the Web page that is automatically generated and published along with the application.|
|[How to: Enable AutoStart for CD installations](../deployment/how-to-enable-autostart-for-cd-installations.md)|Describes how to enable AutoStart so that the ClickOnce application is automatically launched when the media is inserted.|

## Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Create file associations For a ClickOnce application](../deployment/how-to-create-file-associations-for-a-clickonce-application.md)|Describes how to add file name extension support to a ClickOnce application.|
|[How to: Retrieve query string information in an online ClickOnce application](../deployment/how-to-retrieve-query-string-information-in-an-online-clickonce-application.md)|Demonstrates how to retrieve parameters passed in the URL used to run a ClickOnce application.|
|[How to: Disable URL activation of ClickOnce applications by using the designer](../deployment/how-to-disable-url-activation-of-clickonce-applications-by-using-the-designer.md)|Describes how to force users to start the application from the **Start** menu by using the designer.|
|[How to: Disable URL activation of ClickOnce applications](../deployment/how-to-disable-url-activation-of-clickonce-applications.md)|Describes how to force users to start the application from the **Start** menu.|
|[Walkthrough: Downloading assemblies on demand with the ClickOnce deployment API using the Designer](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md)|Explains how to download application assemblies only when they are first used by the application using the designer.|
|[Walkthrough: Download assemblies on demand with the ClickOnce deployment API](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api.md)|Explains how to download application assemblies only when they are first used by the application.|
|[Walkthrough: Download satellite assemblies on demand with the ClickOnce deployment API](../deployment/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api.md)|Describes how to mark your satellite assemblies as optional, and download only the assembly a client machine needs for its current culture settings.|
|[Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application.|
|[Walkthrough: Manually deploy a ClickOnce application that does not require re-signing and that preserves branding information](../deployment/walkthrough-manually-deploying-a-clickonce-app-no-re-signing-required.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application without re-signing the manifests.|
|[How to: Configure projects to target platforms](../ide/how-to-configure-projects-to-target-platforms.md)|Explains how to publish for a 64-bit processor by changing the **Target CPU** or **Platform target** property in your project.|
|[Walkthrough: Enable a ClickOnce application to run on multiple .NET Framework versions](https://msdn.microsoft.com/library/7f4383af-ed87-4853-b4d4-02a3967a5fd9)|Explains how to enable a ClickOnce application to install and run on multiple versions of the NET Framework.|
|[Walkthrough: Create a custom installer for a ClickOnce application](../deployment/walkthrough-creating-a-custom-installer-for-a-clickonce-application.md)|Explains how to create a custom installer to install a ClickOnce application.|
|[How to: Publish a WPF application with visual styles enabled](../deployment/how-to-publish-a-wpf-application-with-visual-styles-enabled.md)|Provides step-by-step instructions to resolve an error that appears when you attempt to publish a WPF application that has visual styles enabled.|

## See also
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [ClickOnce reference](../deployment/clickonce-reference.md)
