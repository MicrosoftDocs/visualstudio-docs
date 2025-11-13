---
title: Publish ClickOnce Application with Publish Wizard
description: Learn how to use the Publish Wizard to make your ClickOnce application available to users, including which publishing properties to use.
ms.date: 04/17/2025
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, publishing
  - deploying applications [ClickOnce], Publish wizard
  - Windows applications, ClickOnce deployments
  - publishing, ClickOnce
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
#customer intent: As a developer, I want to use the Publish Wizard in Visual Studio so I can make my ClickOnce application available to users.
---
# Deploy a .NET Framework desktop application with the ClickOnce Publish Wizard

To make a ClickOnce application available to users, you need to publish the app to a file share or path, FTP server, or removable media. You can publish the application by using the **Publish Wizard**. Extra publishing properties are available in the **Publish** page of the **Project Designer**. For more information, see [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md).

Before you run the **Publish Wizard**, you should set the publishing properties appropriately. For example, you can designate a key to sign your ClickOnce application in the **Signing** page of the **Project Designer**. For more information, see [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md).

When you install multiple versions of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named *Archive*, in the publishing location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

> [!NOTE]
> The dialogs and menus you see might differ from the UI described in this article, depending on your active settings or edition. To change your settings, select **Import and Export Settings** on the **Tools** menu. For more information, see [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

## Publish to file share or path

1. In **Solution Explorer**, select the application project.

1. On the **Build** menu, select either **Publish** *Projectname* or **Publish Selection**, which opens the **Publish Wizard**.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

1. In the **Where do you want to publish the application?** page of the **Publish Wizard**, enter a valid FTP server address or a valid file path by using one of the formats shown, and then select **Next**.

1. In the **How will users install the application?** page, select the location for user installation of the application:

   - To enable user installation from a web site, select **From a Web site**. Enter a URL that corresponds to the file path entered in the previous step. This option is typically used to specify an FTP address as the publishing location. Direct download from FTP isn't supported, so you have to enter a URL for this option.

   - To enable user installation directly from the file share, select **From a UNC path or file share**. Enter a UNC path or file share that corresponds to the file path entered in the previous step. This option is for publishing locations of the form *c:\deploy\myapp* or *\\\server\myapp*.

   - To enable user installation **From a CD-ROM or DVD-ROM**, follow the steps in the [next section](#publish-to-cd-rom-or-dvd-rom).

   Select **Next** to continue.

1. In the **Will the application be available offline?** page, select the appropriate option:

   - To allow the application to run when the user is disconnected from the network, select **Yes, this application is available online or offline**. Visual Studio adds an application shortcut on the **Start** menu.

   - To run the application directly from the publish location, select **No, this application is only available online**.

   Select **Next** to continue.

1. To publish the application with your settings, select **Finish**.

   Visual Studio displays the publishing progress in the status notification area.

## Publish to CD-ROM or DVD-ROM

1. In **Solution Explorer**, right-click the project and select **Properties**, which opens the **Project Designer**.

1. In the **Project Designer**, select the **Publish** tab, and then select **Publish Wizard**.

1. In the **Where do you want to publish the application?** page of the **Publish Wizard**, enter a valid FTP server address or a valid file path by using one of the formats shown, and then select **Next**.

1. In the **How will users install the application?** page, select **From a CD-ROM or DVD-ROM**, and then select **Next**.

   > [!NOTE]
   > You can [configure the installation to run automatically](#configure-automatic-installation) when the user inserts the CD-ROM into the drive.

1. If you distribute your application on CD-ROM, you can provide updates from a web site. In the **Where will the application check for updates?** page, select an update option:

   - To enable the application check for updates, select **The application will check for updates from the following location**. Enter the post location for the updates, such as a file location, web site, or FTP server.

   - For no application check for updates, select **The application will not check for updates**.

   Select **Next** to continue.

1. To publish the application with your settings, select **Finish**.

   Visual Studio displays the publishing progress in the status notification area.

   > [!NOTE]
   > After publishing completes, use a CD/DVD rewriter to copy the files from the **Where do you want to publish the application?** location to the CD-ROM or DVD-ROM media.

### Configure automatic installation

When you enable user installation from a CD-ROM or DVD-ROM, you can configure the process to run automatically when the user inserts the CD-ROM into the drive. 

::: moniker range=">=vs-2022"

1. In the **Project Designer**, select the **Publish** tab.

1. Select **Options**, which opens the **Publish Options** wizard.

1. In the **Publish Options** wizard, select the **Deployment** tab.

1. Select the **For CD installations, automatically start Setup when CD is inserted** option.

1. To apply the change, select **OK**.

::: moniker-end
::: moniker range="vs-2019"

1. In the **Project Designer**, select the **Publish** tab.

1. Select **Options**, which opens the **Publish Options** wizard.

1. Select the **For CD installations, automatically start Setup when CD is inserted** option.

1. To apply the change, select **OK**.

::: moniker-end

## Related content

- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Deploying an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)