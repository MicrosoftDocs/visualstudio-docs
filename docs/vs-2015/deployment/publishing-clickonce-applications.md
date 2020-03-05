---
title: "Publishing ClickOnce Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
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
caps.latest.revision: 24
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Publishing ClickOnce Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When publishing a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application for the first time, publish properties can be set using the Publish Wizard. Only a few of the properties are available in the wizard; all other properties are set to their default values.  
  
 Subsequent changes to publish properties are made on the **Publish** page in the **Project Designer**.  
  
## Publish Wizard  
 You can use the Publish Wizard to set the basic settings for publishing your application. This includes the following publishing properties:  
  
- Publishing Folder Location - where Visual Studio will copy the files (local computer, network file share, FTP server, or Web site)  
  
- Installation Folder Location - where end users will install from (network file share, FTP server, Web site, CD/DVD)  
  
- Online or Offline availability - if end users can access the application with or without a network connection  
  
- Update frequency - how often the application checks for new updates.  
  
  For more information, see [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).  
  
## Publish Page  
 The **Publish** page of the **Project Designer** is used to configure properties for ClickOnce deployment. The following table lists topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Specify Where Visual Studio Copies the Files](../deployment/how-to-specify-where-visual-studio-copies-the-files.md)|Describes how to set where Visual Studio puts the application files and manifests.|  
|[How to: Specify the Location Where End Users Will Install From](../deployment/how-to-specify-the-location-where-end-users-will-install-from.md)|Describes how to set the location where users go to download and install the application.|  
|[How to: Specify the ClickOnce Offline or Online Install Mode](../deployment/how-to-specify-the-clickonce-offline-or-online-install-mode.md)|Describes how to set whether the application will be available offline or online.|  
|[How to: Set the ClickOnce Publish Version](../deployment/how-to-set-the-clickonce-publish-version.md)|Describes how to set the ClickOnce **Publish Version** property, which determines whether or not the application that you are publishing will be treated as an update.|  
|[How to: Automatically Increment the ClickOnce Publish Version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)|Describes how to automatically increment the Revision number of the **PublishVersion** each time you publish the application.|  
  
 For more information, see [Publish Page, Project Designer](../ide/reference/publish-page-project-designer.md)  
  
### Application Files Dialog Box  
 This dialog box allows you to specify how the files in your project are categorized for publishing, dynamic downloading, and updating. It contains a grid that lists the project files that are not excluded by default, or that have a download group.  
  
 To exclude files, mark files as data files or prerequisites, and create groups of files for conditional installation in the Visual Studio UI, see [How to: Specify Which Files Are Published by ClickOnce](../deployment/how-to-specify-which-files-are-published-by-clickonce.md). You can also mark data files by using the Mage.exe. For more information, see [How to: Include a Data File in a ClickOnce Application](../deployment/how-to-include-a-data-file-in-a-clickonce-application.md).  
  
### Prerequisites Dialog Box  
 This dialog box specifies which prerequisite components are installed, as well as how they are installed. For more information, see [How to: Install Prerequisites with a ClickOnce Application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md) and [Prerequisites Dialog Box](../ide/reference/prerequisites-dialog-box.md).  
  
### Application Updates Dialog Box  
 This dialog box specifies how the application installation should check for updates. For more information, see [How to: Manage Updates for a ClickOnce Application](../deployment/how-to-manage-updates-for-a-clickonce-application.md).  
  
### Publish Options Dialog Box  
 The Publish Options dialog box specifies an application's deployment options.  
  
|||  
|-|-|  
|[How to: Change the Publish Language for a ClickOnce Application](../deployment/how-to-change-the-publish-language-for-a-clickonce-application.md)|Describes how to specify a language and culture to match the localized version.|  
|[How to: Specify a Start Menu Name for a ClickOnce Application](../deployment/how-to-specify-a-start-menu-name-for-a-clickonce-application.md)|Describes how to change the display name for a ClickOnce application.|  
|[How to: Specify a Link for Technical Support](../deployment/how-to-specify-a-link-for-technical-support.md)|Describes how to set the **Support URL** property, which identifies a Web page or file share where users can go to get information about the application.|  
|[How to: Specify a Support URL for Individual Prerequisites in a ClickOnce Deployment](../deployment/how-to-specify-a-support-url-for-individual-prerequisites-in-a-clickonce-deployment.md)|Demonstrated how to manually alter an application manifest to include individual support URLs for each prerequisite.|  
|[How to: Specify a Publish Page for a ClickOnce Application](../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md)|Describes how to generate and publish a default Web page (publish.htm) along with the application|  
|[How to: Customize the ClickOnce Default Web Page](../deployment/how-to-customize-the-default-web-page-for-a-clickonce-application.md)|Describes how to customize the Web page that is automatically generated and published along with the application.|  
|[How to: Enable AutoStart for CD Installations](../deployment/how-to-enable-autostart-for-cd-installations.md)|Describes how to enable AutoStart so that the ClickOnce application is automatically launched when the media is inserted.|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Create File Associations For a ClickOnce Application](../deployment/how-to-create-file-associations-for-a-clickonce-application.md)|Describes how to add file name extension support to a ClickOnce application.|  
|[How to: Retrieve Query String Information in an Online ClickOnce Application](../deployment/how-to-retrieve-query-string-information-in-an-online-clickonce-application.md)|Demonstrates how to retrieve parameters passed in the URL used to run a ClickOnce application.|  
|[How to: Disable URL Activation of ClickOnce Applications by Using the Designer](../deployment/how-to-disable-url-activation-of-clickonce-applications-by-using-the-designer.md)|Describes how to force users to start the application from the **Start** menu by using the designer.|  
|[How to: Disable URL Activation of ClickOnce Applications](../deployment/how-to-disable-url-activation-of-clickonce-applications.md)|Describes how to force users to start the application from the **Start** menu.|  
|[Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API Using the Designer](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md)|Explains how to download application assemblies only when they are first used by the application using the designer.|  
|[Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api.md)|Explains how to download application assemblies only when they are first used by the application.|  
|[Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API](../deployment/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api.md)|Describes how to mark your satellite assemblies as optional, and download only the assembly a client machine needs for its current culture settings.|  
|[Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application.|  
|[Walkthrough: Manually Deploying a ClickOnce Application that Does Not Require Re-Signing and that Preserves Branding Information](/visualstudio/deployment/walkthrough-manually-deploying-a-clickonce-app-no-re-signing-required?view=vs-2015)|Explains how to use .NET Framework utilities to deploy your ClickOnce application without re-signing the manifests.|  
|[NIB: How to: Optimize an Application for a Specific CPU Type](https://msdn.microsoft.com/294a75d2-4279-4b72-8298-2bea05be907a)|Explains how to publish for a 64-bit processor by changing the **Target CPU** or **Platform target** property in your project.|  
|[Walkthrough: Enabling a ClickOnce Application to Run on Multiple .NET Framework Versions](https://msdn.microsoft.com/7f4383af-ed87-4853-b4d4-02a3967a5fd9)|Explains how to enable a ClickOnce application to install and run on multiple versions of the NET Framework.|  
|[Walkthrough: Creating a Custom Installer for a ClickOnce Application](../deployment/walkthrough-creating-a-custom-installer-for-a-clickonce-application.md)|Explains how to create a custom installer to install a ClickOnce application.|  
|[How to: Publish a WPF Application with Visual Styles Enabled](../deployment/how-to-publish-a-wpf-application-with-visual-styles-enabled.md)|Provides step-by-step instructions to resolve an error that appears when you attempt to publish a WPF application that has visual styles enabled.|  
  
## See Also  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [ClickOnce Reference](../deployment/clickonce-reference.md)
