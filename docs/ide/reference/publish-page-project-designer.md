---
title: Publish Page, Project Designer
description: The Publish page of the Project Designer is used to configure properties for your ClickOnce deployment.
ms.date: 11/04/2016
ms.subservice: deployment
ms.topic: reference
f1_keywords:
  - "Microsoft.VisualStudio.Publish.ClickOnceProvider.Dialog.PropertyPage"
helpviewer_keywords:
  - "Project Designer, Publish page"
  - "Publish page in Project Designer"
ms.custom: "ide-ref"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
monikerRange: 'vs-2019'
---
# Publish Page, Project Designer

The **Publish** page of the **Project Designer** is used to configure properties for ClickOnce deployment.

To access the **Publish** page, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Publish** tab.

[!INCLUDE[ndptecclick](../../deployment/includes/dotnet-publish-tool.md)]

> [!NOTE]
> Some of the ClickOnce properties described here can also be set in the **PublishWizard**, available from the **Build** menu or by clicking the **PublishWizard** button on this page.

## UIElement List

 **Publishing Folder Location**

Specifies the location where the application is published. Can be a drive path (`C:\deploy\myapplication`), a file share (`\\server\myapplication`), or an FTP server (`ftp://ftp.microsoft.com/myapplication`). Note that text must be present in the **Publishing Location** box in order for the browse (**...**) button to work.

 **Installation Folder URL**

Optional. Specifies a website to which users go to install the application. This is necessary only when it differs from the **Publishing Location**, for example, when the application is published to a staging server.

 **Install Mode and Settings**

Determines whether the application is run directly from the **Publishing Location** (when **The application is available online only** is selected) or is installed and added to the **Start** menu and the **Add or Remove Programs** item in **Control Panel** (when **The application is available offline as well** is selected).

For WPF web browser apps, the **application is available offline as well** option is disabled, because such applications are available only online.

 **Application Files**

Opens the Application Files dialog box, which is used to specify how and where individual files are installed.

 **Prerequisites**

Opens the Prerequisites dialog box, which is used to specify prerequisite components, such as the .NET Framework, to be installed together with the application.

 **Updates**

Opens the Application Updates dialog box, which is used to specify update behavior for the application. Not available when **The application is available online only** is selected.

 **Options**

Opens the Publish Options dialog box, which is used to specify additional advanced publishing options.

 **Publish Version**

Sets the publish version number for the application; when the version number is changed, the application is published as an update. Each part of the publish version (**Major**, **Minor**, **Build**, **Revision**) can have a maximum value of 65355 (<xref:System.UInt16.MaxValue>), the maximum allowed by <xref:System.Version>.

When you install more than one version of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named Archive, in the publish location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

 **Automatically increment revision with each publish**

Optional. When this option is selected (the default), the **Revision** part of the publish version number is incremented by one every time that the application is published. This causes the application to be published as an update.

 **Publish Wizard**

Opens the Publish Wizard. Completing the Publish Wizard has the same effect as running the **Publish** command on the **Build** menu.

 **Publish Now**

Publishes the application using the current settings. Equivalent to the **Finish** button in the **PublishWizard**.

## See also

- [Publishing ClickOnce Applications](../../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce Application using the Publish Wizard](../../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
- [How to: Specify Where Visual Studio Copies the Files](../../deployment/how-to-specify-where-visual-studio-copies-the-files.md)
- [How to: Specify the Location Where End Users Will Install From](../../deployment/how-to-specify-the-location-where-end-users-will-install-from.md)
- [How to: Specify a Link for Technical Support](../../deployment/how-to-specify-a-link-for-technical-support.md)
- [How to: Specify the ClickOnce Offline or Online Install Mode](../../deployment/how-to-specify-the-clickonce-offline-or-online-install-mode.md)
- [How to: Enable AutoStart for CD Installations](../../deployment/how-to-enable-autostart-for-cd-installations.md)
- [How to: Set the ClickOnce Publish Version](../../deployment/how-to-set-the-clickonce-publish-version.md)
- [How to: Automatically Increment the ClickOnce Publish Version](../../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)
- [How to: Specify Which Files Are Published by ClickOnce](../../deployment/how-to-specify-which-files-are-published-by-clickonce.md)
- [How to: Install Prerequisites with a ClickOnce Application](../../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
- [How to: Manage Updates for a ClickOnce Application](../../deployment/how-to-manage-updates-for-a-clickonce-application.md)
- [How to: Change the Publish Language for a ClickOnce Application](../../deployment/how-to-change-the-publish-language-for-a-clickonce-application.md)
- [How to: Specify a Start Menu Name for a ClickOnce Application](../../deployment/how-to-specify-a-start-menu-name-for-a-clickonce-application.md)
- [How to: Specify a Publish Page for a ClickOnce Application](../../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md)
- [ClickOnce Security and Deployment](../../deployment/clickonce-security-and-deployment.md)
