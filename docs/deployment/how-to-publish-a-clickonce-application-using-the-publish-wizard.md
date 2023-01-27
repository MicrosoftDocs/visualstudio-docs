---
title: Publish ClickOnce application using Publish wizard
description: Learn about using the Publish Wizard to make your ClickOnce application available to users, including which publishing properties to use.
ms.custom: SEO-VS-2020
ms.date: 01/27/2023
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
ms.assetid: 2e4aa67c-4445-4f7b-9e03-9acb95829127
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# Deploy a .NET Framework desktop application using the ClickOnce Publish wizard

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
To make a ClickOnce application available to users, you must publish it to a file share or path, FTP server, or removable media. You can publish the application by using the Publish Wizard; additional properties related to publishing are available on the **Publish** page of the **Project Designer**. For more information, see [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md).

Before you run the Publish Wizard, you should set the publishing properties appropriately. For example, if you want to designate a key to sign your ClickOnce application, you can do so on the **Signing** page of the **Project Designer**. For more information, see [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md).

> [!NOTE]
> When you install more than one version of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named *Archive*, in the publish location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, click **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## To publish to a file share or path

1. In **Solution Explorer**, select the application project.

2. On the **Build** menu, choose either **Publish** *Projectname* or **Publish Selection**.

    The Publish Wizard appears.

    [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In the **Where do you want to publish the application?** page, enter a valid FTP server address or a valid file path using one of the formats shown, and then click **Next**.

4. In the **How will users install the application?** page, select the location where users will go to install the application:

   - If users will install from a Web site, click **From a Web site** and enter a URL that corresponds to the file path entered in the previous step. Click **Next**. (This option is typically used when you specify an FTP address as the publishing location. Direct download from FTP is not supported. Therefore, you have to enter a URL here.)

   - If users will install the application directly from the file share, click **From a UNC path or file share**, and then click **Next**. (This is for publishing locations of the form *c:\deploy\myapp* or *\\\server\myapp*.)

   - If users will install from removable media, click **From a CD-ROM or DVD-ROM**, and then click **Next**.

5. On the **Will the application be available offline?** page, click the appropriate option:

   - If you want to enable the application to be run when the user is disconnected from the network, click **Yes, this application will be available online or offline**. A shortcut on the **Start** menu will be created for the application.

   - If you want to run the application directly from the publish location, click **No, this application is only available online**. A shortcut on the **Start** menu will not be created.

     Click **Next** to continue.

6. Click **Finish** to publish the application.

    Publishing status is displayed in the status notification area.

## To publish to a CD-ROM or DVD-ROM

1. In **Solution Explorer**, right-click the application project and click **Properties**.

    The **Project Designer** appears.

2. Click the **Publish** tab to open the **Publish** page in the **Project Designer**, and click the **Publish Wizard** button.

    The Publish Wizard appears.

3. In the **Where do you want to publish the application?** page, enter the file path or FTP location where the application will be published, for example *d:\deploy*. Then click **Next** to continue.

4. On the **How will users install the application?** page, click From a **CD-ROM or DVD-ROM**, and then click **Next**.

   > [!NOTE]
   > If you want the installation to run automatically when the CD-ROM is inserted into the drive, open the **Publish** page in the **Project Designer** and click the **Options** button, and then, in the **Publish Options** wizard, select **For CD installations, automatically start Setup when CD is inserted**.

5. If you distribute your application on CD-ROM, you might want to provide updates from a Web site. In the **Where will the application check for updates?** page, choose an update option:

   - If the application will check for updates, click **The application will check for updates from the following location** and enter the location where updates will be posted. This can be a file location, Web site, or FTP server.

   - If the application will not check for updates, click **The application will not check for updates**.

     Click **Next** to continue.

6. Click **Finish** to publish the application.

    Publishing status is displayed in the status notification area.

   > [!NOTE]
   > After publishing is complete, you will have to use a CD-Rewriter or DVD-Rewriter to copy the files from the location specified in step 3 to the CD-ROM or DVD-ROM media.

## See also

- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Deploying an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)