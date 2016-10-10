---
title: "Publishing ClickOnce Applications"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eb6dfe79-f54c-4331-8e36-073688e70973
caps.latest.revision: 22
manager: wpickett
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Publishing ClickOnce Applications
When publishing a ClickOnce application for the first time, publish properties can be set using the Publish Wizard. Only a few of the properties are available in the wizard; all other properties are set to their default values.  
  
 Subsequent changes to publish properties are made on the **Publish** page in the **Project Designer**.  
  
## Publish Wizard  
 You can use the Publish Wizard to set the basic settings for publishing your application. This includes the following publishing properties:  
  
-   Publishing Folder Location - where Visual Studio will copy the files (local computer, network file share, FTP server, or Web site)  
  
-   Installation Folder Location - where end users will install from (network file share, FTP server, Web site, CD/DVD)  
  
-   Online or Offline availability - if end users can access the application with or without a network connection  
  
-   Update frequency - how often the application checks for new updates.  
  
 For more information, see [How to: Publish a ClickOnce Application using the Publish Wizard](../VS_IDE/How-to--Publish-a-ClickOnce-Application-using-the-Publish-Wizard.md).  
  
## Publish Page  
 The **Publish** page of the **Project Designer** is used to configure properties for ClickOnce deployment. The following table lists topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Specify Where Visual Studio Copies the Files](../VS_IDE/How-to--Specify-Where-Visual-Studio-Copies-the-Files.md)|Describes how to set where Visual Studio puts the application files and manifests.|  
|[How to: Specify the Location Where End Users Will Install From](../VS_IDE/How-to--Specify-the-Location-Where-End-Users-Will-Install-From.md)|Describes how to set the location where users go to download and install the application.|  
|[How to: Specify the ClickOnce Offline or Online Install Mode](../VS_IDE/How-to--Specify-the-ClickOnce-Offline-or-Online-Install-Mode.md)|Describes how to set whether the application will be available offline or online.|  
|[How to: Set the ClickOnce Publish Version](../VS_IDE/How-to--Set-the-ClickOnce-Publish-Version.md)|Describes how to set the ClickOnce **Publish Version** property, which determines whether or not the application that you are publishing will be treated as an update.|  
|[How to: Automatically Increment the ClickOnce Publish Version](../VS_IDE/How-to--Automatically-Increment-the-ClickOnce-Publish-Version.md)|Describes how to automatically increment the Revision number of the **PublishVersion** each time you publish the application.|  
  
 For more information, see [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)  
  
### Application Files Dialog Box  
 This dialog box allows you to specify how the files in your project are categorized for publishing, dynamic downloading, and updating. It contains a grid that lists the project files that are not excluded by default, or that have a download group.  
  
 To exclude files, mark files as data files or prerequisites, and create groups of files for conditional installation in the Visual Studio UI, see [How to: Specify Which Files Are Published by ClickOnce](../VS_IDE/How-to--Specify-Which-Files-Are-Published-by-ClickOnce.md). You can also mark data files by using the Mage.exe. For more information, see [How to: Include a Data File in a ClickOnce Application](../VS_IDE/How-to--Include-a-Data-File-in-a-ClickOnce-Application.md).  
  
### Prerequisites Dialog Box  
 This dialog box specifies which prerequisite components are installed, as well as how they are installed. For more information, see [How to: Install Prerequisites with a ClickOnce Application](../VS_IDE/How-to--Install-Prerequisites-with-a-ClickOnce-Application.md) and [Prerequisites Dialog Box](../VS_IDE/Prerequisites-Dialog-Box.md).  
  
### Application Updates Dialog Box  
 This dialog box specifies how the application installation should check for updates. For more information, see [How to: Manage Updates for a ClickOnce Application](../VS_IDE/How-to--Manage-Updates-for-a-ClickOnce-Application.md).  
  
### Publish Options Dialog Box  
 The Publish Options dialog box specifies an application's deployment options.  
  
|||  
|-|-|  
|[How to: Change the Publish Language for a ClickOnce Application](../VS_IDE/How-to--Change-the-Publish-Language-for-a-ClickOnce-Application.md)|Describes how to specify a language and culture to match the localized version.|  
|[How to: Specify a Start Menu Name for a ClickOnce Application](../VS_IDE/How-to--Specify-a-Start-Menu-Name-for-a-ClickOnce-Application.md)|Describes how to change the display name for a ClickOnce application.|  
|[How to: Specify a Link for Technical Support](../VS_IDE/How-to--Specify-a-Link-for-Technical-Support.md)|Describes how to set the **Support URL** property, which identifies a Web page or file share where users can go to get information about the application.|  
|[How to: Specify a Support URL for Individual Prerequisites in a ClickOnce Deployment](../VS_IDE/How-to--Specify-a-Support-URL-for-Individual-Prerequisites-in-a-ClickOnce-Deployment.md)|Demonstrated how to manually alter an application manifest to include individual support URLs for each prerequisite.|  
|[How to: Specify a Publish Page for a ClickOnce Application](../VS_IDE/How-to--Specify-a-Publish-Page-for-a-ClickOnce-Application.md)|Describes how to generate and publish a default Web page (publish.htm) along with the application|  
|[How to: Customize the ClickOnce Default Web Page](../VS_IDE/How-to--Customize-the-Default-Web-Page-for-a-ClickOnce-Application.md)|Describes how to customize the Web page that is automatically generated and published along with the application.|  
|[How to: Enable AutoStart for CD Installations](../VS_IDE/How-to--Enable-AutoStart-for-CD-Installations.md)|Describes how to enable AutoStart so that the ClickOnce application is automatically launched when the media is inserted.|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Create File Associations For a ClickOnce Application](../VS_IDE/How-to--Create-File-Associations-For-a-ClickOnce-Application.md)|Describes how to add file name extension support to a ClickOnce application.|  
|[How to: Retrieve Query String Information in an Online ClickOnce Application](../VS_IDE/How-to--Retrieve-Query-String-Information-in-an-Online-ClickOnce-Application.md)|Demonstrates how to retrieve parameters passed in the URL used to run a ClickOnce application.|  
|[How to: Disable URL Activation of ClickOnce Applications by Using the Designer](../VS_IDE/How-to--Disable-URL-Activation-of-ClickOnce-Applications-by-Using-the-Designer.md)|Describes how to force users to start the application from the **Start** menu by using the designer.|  
|[How to: Disable URL Activation of ClickOnce Applications](../VS_IDE/How-to--Disable-URL-Activation-of-ClickOnce-Applications.md)|Describes how to force users to start the application from the **Start** menu.|  
|[Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API Using the Designer](../VS_IDE/Walkthrough--Downloading-Assemblies-on-Demand-with-the-ClickOnce-Deployment-API-Using-the-Designer.md)|Explains how to download application assemblies only when they are first used by the application using the designer.|  
|[Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API](../VS_IDE/Walkthrough--Downloading-Assemblies-on-Demand-with-the-ClickOnce-Deployment-API.md)|Explains how to download application assemblies only when they are first used by the application.|  
|[Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API](../VS_IDE/Walkthrough--Downloading-Satellite-Assemblies-on-Demand-with-the-ClickOnce-Deployment-API.md)|Describes how to mark your satellite assemblies as optional, and download only the assembly a client machine needs for its current culture settings.|  
|[Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application.|  
|[Walkthrough: Manually Deploying a ClickOnce Application that Does Not Require Re-Signing and that Preserves Branding Information](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application-that-Does-Not-Require-Re-Signing-and-that-Preserves-Branding-Information.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application without re-signing the manifests.|  
|[NIB: How to: Optimize an Application for a Specific CPU Type](assetId:///294a75d2-4279-4b72-8298-2bea05be907a)|Explains how to publish for a 64-bit processor by changing the **Target CPU** or **Platform target** property in your project.|  
|[Walkthrough: Enabling a ClickOnce Application to Run on Multiple .NET Framework Versions](assetId:///7f4383af-ed87-4853-b4d4-02a3967a5fd9)|Explains how to enable a ClickOnce application to install and run on multiple versions of the NET Framework.|  
|[Walkthrough: Creating a Custom Installer for a ClickOnce Application](../VS_IDE/Walkthrough--Creating-a-Custom-Installer-for-a-ClickOnce-Application.md)|Explains how to create a custom installer to install a ClickOnce application.|  
|[How to: Publish a WPF Application with Visual Styles Enabled](../VS_IDE/How-to--Publish-a-WPF-Application-with-Visual-Styles-Enabled.md)|Provides step-by-step instructions to resolve an error that appears when you attempt to publish a WPF application that has visual styles enabled.|  
  
## See Also  
 [ClickOnce Security and Deployment](../VS_IDE/ClickOnce-Security-and-Deployment.md)   
 [ClickOnce Reference](../VS_IDE/ClickOnce-Reference.md)