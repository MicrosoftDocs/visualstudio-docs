---
title: "Publish Page, Project Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.Dialog.PropertyPage"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Project Designer, Publish page"
  - "Publish page in Project Designer"
ms.assetid: 153527c6-8b95-4003-8e8e-03a489d0a629
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Publish Page, Project Designer
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **Publish** page of the **Project Designer** is used to configure properties for ClickOnce deployment.

 To access the **Publish** page, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Publish** tab.

> [!NOTE]
> Some of the ClickOnce properties described here can also be set in the **PublishWizard**, available from the **Build** menu or by clicking the **PublishWizard** button on this page.

## UIElement List
 **Publishing Folder Location**
 Specifies the location where the application is published. Can be a drive path (`C:\deploy\myapplication`), a file share (`\\server\myapplication`), an FTP server (`ftp://ftp.microsoft.com/myapplication`), or a Web site (`http://www.microsoft.com/myapplication`). Note that text must be present in the **Publishing Location** box in order for the browse (**...**) button to work.

 By default, the publishing location is `http://localhost/<projectname>/` if you have IIS installed, or the `publish\` directory if you do not have IIS installed. If your computer is running Windows Vista, the default is always the `publish\` directory, regardless of whether you have IIS installed.

 **Installation Folder URL**
 Optional. Specifies a Web site to which users go to install the application. This is necessary only when it differs from the **Publishing Location**, for example, when the application is published to a staging server.

 **Install Mode and Settings**
 Determines whether the application is run directly from the **Publishing Location** (when **The application is available online only** is selected) or is installed and added to the **Start** menu and the **Add or Remove Programs** item in **Control Panel** (when **The application is available offline as well** is selected).

 For WPF Web Browser Applications, the **The application is available offline as well** option is disabled, because such applications are available only online.

 **Application Files**
 Opens the [Application Files Dialog Box](https://msdn.microsoft.com/b06dff3a-b87a-4caf-996b-7a4acf8137a8), which is used to specify how and where individual files are installed.

 **Prerequisites**
 Opens the [Prerequisites Dialog Box](../../ide/reference/prerequisites-dialog-box.md), which is used to specify prerequisite components, such as the .NET Framework, to be installed together with the application.

 **Updates**
 Opens the [Application Updates Dialog Box](https://msdn.microsoft.com/8eca8743-8e68-4d04-bfd5-4dc0a9b2934f), which is used to specify update behavior for the application. Not available when **The application is available online only** is selected.

 **Options**
 Opens the [Publish Options Dialog Box](https://msdn.microsoft.com/fd9baa1b-7311-4f9e-8ffb-ae50cf110592), which is used to specify additional advanced publishing options.

 **Publish Version**
 Sets the publish version number for the application; when the version number is changed, the application is published as an update. Each part of the publish version (**Major**, **Minor**, **Build**, **Revision**) can have a maximum value of 65355 (<xref:System.UInt16.MaxValue>), the maximum allowed by <xref:System.Version>.

 When you install more than one version of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named Archive, in the publish location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

 **Automatically increment revision with each publish**
 Optional. When this option is selected (the default), the **Revision** part of the publish version number is incremented by one every time that the application is published. This causes the application to be published as an update.

 **Publish Wizard**
 Opens the [Publish Wizard](https://msdn.microsoft.com/fc6abebd-13d6-48e4-a567-fbc52dad0872). Completing the Publish Wizard has the same effect as running the **Publish** command on the **Build** menu.

 **Publish Now**
 Publishes the application using the current settings. Equivalent to the **Finish** button in the **PublishWizard**.

## See Also
 [Publishing ClickOnce Applications](../../deployment/publishing-clickonce-applications.md)
 [How to: Publish a ClickOnce Application using the Publish Wizard](../../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
 [How to: Specify Where Visual Studio Copies the Files](../../deployment/how-to-specify-where-visual-studio-copies-the-files.md)
 [How to: Specify the Location Where End Users Will Install From](../../deployment/how-to-specify-the-location-where-end-users-will-install-from.md)
 [How to: Specify a Link for Technical Support](../../deployment/how-to-specify-a-link-for-technical-support.md)
 [How to: Specify the ClickOnce Offline or Online Install Mode](../../deployment/how-to-specify-the-clickonce-offline-or-online-install-mode.md)
 [How to: Enable AutoStart for CD Installations](../../deployment/how-to-enable-autostart-for-cd-installations.md)
 [How to: Set the ClickOnce Publish Version](../../deployment/how-to-set-the-clickonce-publish-version.md)
 [How to: Automatically Increment the ClickOnce Publish Version](../../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)
 [How to: Specify Which Files Are Published by ClickOnce](../../deployment/how-to-specify-which-files-are-published-by-clickonce.md)
 [How to: Install Prerequisites with a ClickOnce Application](../../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
 [How to: Manage Updates for a ClickOnce Application](../../deployment/how-to-manage-updates-for-a-clickonce-application.md)
 [How to: Change the Publish Language for a ClickOnce Application](../../deployment/how-to-change-the-publish-language-for-a-clickonce-application.md)
 [How to: Specify a Start Menu Name for a ClickOnce Application](../../deployment/how-to-specify-a-start-menu-name-for-a-clickonce-application.md)
 [How to: Specify a Publish Page for a ClickOnce Application](../../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md)
 [ClickOnce Security and Deployment](../../deployment/clickonce-security-and-deployment.md)
