---
title: Specify ClickOnce Publish properties
description: Learn how to set the Publish properties for a ClickOnce application, such as the location where the application files and manifest are put, and the installation URL.
ms.date: 08/04/2023
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - publishing, specifying location
  - Publish Location property
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Specify ClickOnce Publish properties

You can configure ClickOnce Publish properties on the **Publish** page of the **Project Designer**, or by using the Publish Wizard. In this article, you learn how to specify basic properties such as the publishing location, the installation URL, online or offline install mode, and the publish version.

## Specify a publishing location

When you publish an application by using ClickOnce, the `Publish Location` property specifies the location where the application files and manifest are put. This can be a file path or the path to an FTP server.

 You can specify the `Publish Location` property on the **Publish** page of the **Project Designer**, or by using the Publish Wizard. For more information, see [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

> [!NOTE]
> When you install more than one version of an application by using ClickOnce, the installation moves earlier versions of the application into a folder named Archive, in the publish location that you specify. Archiving earlier versions in this manner keeps the installation directory clear of folders from the earlier version.

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In the **Publish Location** field, enter the publishing location by using one of the following formats:

   - To publish to a file share or disk path, enter the path by using either a UNC path (*\\\Server\ApplicationName*) or a file path (*C:\Deploy\ApplicationName*).

   - To publish to an FTP server, enter the path using the format <em>ftp://ftp.microsoft.com/\<ApplicationName></em>.

     Note that text must be present in the **Publishing Location** box in order for the Browse (**...**) button to work.

## Specify the location where end users will install from

When publishing a ClickOnce application, the location where users go to download and install the application is not necessarily the location where you initially publish the application. For example, in some organizations a developer might publish an application to a staging server, and then an administrator would move the application to a Web server.

In this case, you can use the `Installation URL` property to specify the Web server where users will go to download the application. This is necessary so that the application manifest knows where to look for updates.

The `Installation URL` property can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The `Installation URL` property can also be set using the **PublishWizard**. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

### Specify an Installation URL

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In the Installation URL field, enter the installation location using a fully qualified URL using the format `https://www.contoso.com/ApplicationName`, or a UNC path using the format `\Server\ApplicationName`.

## Specify the ClickOnce offline or online install mode

The `Install Mode` for a ClickOnce application determines whether the application will be available offline or online. When you choose **The application is available online only**, the user must have access to the ClickOnce publishing location (either a Web page or a file share) in order to run the application. When you choose **The application is available offline as well**, the application adds entries to the **Start** menu and the **Add or Remove Programs** dialog box; the user is able to run the application when they are not connected.

The `Install Mode` can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The `Install Mode` can also be set using the Publish wizard. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

### Make a ClickOnce application available online only

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In the **Install Mode and Settings** area, click the **The application is available online only** option button.

### Make a ClickOnce application available online or offline

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Install Mode and Settings** area, click the **The application is available offline as well** option button.

     When installed, the application adds entries to the **Start** menu and to **Add or Remove Programs** in Control Panel.

## Set the ClickOnce publish version

The ClickOnce `Publish Version` property determines whether or not the application that you are publishing will be treated as an update. Each time version is incremented, the application will be published as an update.

The `Publish Version` property can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> There is a project option that will automatically increment the `Publish Version` property each time the application is published; this option is enabled by default. For more information, see [Automatically Increment the ClickOnce Publish Version](../deployment/how-to-specify-where-visual-studio-copies-the-files.md#automatically-increment-the-clickonce-publish-version).

### Change the publish version

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In **Publish Version** field, increment the **Major**, **Minor**, **Build**, or **Revision** version numbers.

    > [!NOTE]
    > You should never decrement a version number; doing so could cause unpredictable update behavior.

## Automatically increment the ClickOnce publish version

When publishing a ClickOnce application, changing the `Publish Version` property causes the application to be published as an update. By default, Visual Studio automatically increments the `Revision` number of the `Publish Version` each time you publish the application.

You can disable this behavior on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

### Disable automatically incrementing the publish version

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

   [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

3. In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.

## Related content

- [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)