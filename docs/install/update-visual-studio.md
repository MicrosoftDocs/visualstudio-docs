---
title: "Update Visual Studio 2017"
description: "Learn how to update Visual Studio to the most recent release, step-by-step."
ms.date: 04/23/2018
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
helpviewer_keywords:
  - "update Visual Studio"
  - "change visual studio"
  - "changing Visual Studio"
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Update Visual Studio 2017 to the most recent release

We encourage you to update to the most [recent version](/visualstudio/releasenotes/vs2017-relnotes) of Visual Studio 2017 so that you always get the latest features, fixes, and improvements.

And if you'd like to try out anything before we release it, consider downloading the [preview release](/visualstudio/releasenotes/vs2017-preview-relnotes) of the next version, too.

> [!IMPORTANT]
> You must log on with an account that has administrative permissions to install, update, or modify Visual Studio. For more information, see [User Permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md).

## Update Visual Studio 2017 version 15.6 or later

We've streamlined the installation and update experience to make it easier to use directly from within the IDE. Here's how to update from version 15.6 and later to newer versions of Visual Studio.

### Use the Notifications hub

When there is an update, there's a corresponding notification flag in Visual Studio.

1. Save your work.

2. Choose the notification flag to open the **Notifications** hub, and then choose the update that you want to install.

  ![Update Visual Studio 2017 by using the Notification hub](media/vs-install-notifications-hub-15dot6.png "The Notifications hub in Visual Studio 2017")

3. When the **Update** dialog box opens, choose **Update Now**.

    ![Update Visual Studio 2017 by using the Update dialog box from the Notifications hub](media/vs-update-now-from-notifications-hub.png "The Update dialog box from the Notifications hub in Visual Studio")

     If a User Access Control dialog box opens, choose **Yes**. Next, a "Please wait" dialog might open for a moment, and then the Visual Studio Installer opens to start the update.

     ![The new Visual Studio Installer experience in version 15.6](media/visual-studio-15dot6-installer.png "The new Visual Studio Installer experience in version 15.6")

     Your update continues. Then, when it's complete, Visual Studio restarts.

     > [!NOTE]
     > If you run Visual Studio in administrator mode, you must manually restart Visual Studio after the update.    

### Use the IDE

You can check for an update and then install the update from the menu bar in Visual Studio.

1. Save your work.

2. Choose **Help** > **Check for Updates**.

     ![The new Help menu in Visual Studio version 15.6](media/vs-help-menu-check-for-updates.png "The new Help menu in Visual Studio version 15.6")

3. When the **Update** dialog box opens, choose **Update Now**.

   The update proceeds as described in the previous section, and then Visual Studio restarts after the update completes successfully.

   > [!NOTE]
   > If you run Visual Studio in administrator mode, you must manually restart Visual Studio after the update.  

### Use the Visual Studio Installer

As in earlier versions of Visual Studio 2017, you can use the Visual Studio Installer to install an update.

1. Save your work.

2. Open the installer. The Visual Studio Installer might require updating before you continue.

  > [!NOTE]
  > On a computer running Windows 10, you can find the installer under the letter **V** as the **Visual Studio Installer**, or under the letter **M** as the **Microsoft Visual Studio Installer**.

2. On the **Product** page in the installer, look for the edition of Visual Studio that you have installed.

3. If an update is available, you see an **Update** button. (It might take a few seconds for the installer to determine whether an update is available.)

  Choose the **Update** button to install the updates.

     ![Update Visual Studio 2017 by using the Visual Studio Installer](media/update-visual-studio.png "Update Visual Studio 2017 by using the Visual Studio Installer")

## Update Visual Studio 2017 version 15.5 or earlier

If you are using an earlier version, here's how to apply an update from Visual Studio 2017 version 15.0 through version 15.5.

### Update by using the Notifications hub

1. When there are updates, there's a corresponding notification flag in Visual Studio.

  ![Update Visual Studio 2017 by using the Notification hub](media/notification-flag.png "The update Notification flag in Visual Studio")

  Choose the notification flag to open the **Notifications** hub.

  ![Update Visual Studio 2017 by using the Notification hub](media/notifications-hub.png "The Notifications hub in Visual Studio")

2. Choose **"Visual Studio Update" is available**, which opens the **Extensions and Updates** dialog box.

  ![Update Visual Studio 2017 by using the Notifications hub](media/notifications-hub-select.png "The Notifications hub in Visual Studio")

3. In the **Extensions and Updates** dialog box, choose the **Update** button.

  ![Update Visual Studio 2017 by using the Notifications hub](media/notifications-extensions-and-updates.png "The Extensions and Updates dialog in Visual Studio")

#### More about Visual Studio notifications

Visual Studio notifies you when an update is available for Visual Studio itself or for any components, and also when certain events occur in the Visual Studio environment.

* When the notification flag is yellow, there is a Visual Studio product update available for you to install.
* When the notification flag is red, there is a problem with your license.
* When the notification flag is black, there are optional or informational messages to review.

Choose the notifications flag to open the **Notifications** hub and then choose the notifications that you want to act on. Or, choose to ignore or dismiss a notification.

 ![View an optional or informational message in the Notification hub](media/notification-flag-optional.png "The optional or informational message Notification flag in Visual Studio")

If you choose to ignore a notification, Visual Studio stops showing it. If you want to reset the list of ignored notifications, choose the **Settings** button in the Notifications hub.

   ![Choose the Settings button in the Notifications hub to view Notification options](media/vs-notifications-hub-settings-button.png "Choose the Settings button in the Notifications hub to view notification options")

### Update by using the Visual Studio Installer

1. Open the installer. You might need to update the installer before continuing. If this is the case, you are prompted to do so.

  > [!NOTE]
  > On a computer running Windows 10, you can find the installer under the letter **V** as the **Visual Studio Installer**, or under the letter **M** as the **Microsoft Visual Studio Installer**.

2. On the **Product** page in the installer, look for the edition of Visual Studio that you have installed.

3. If an update is available, you see an **Update** button. (It might take a few seconds for the installer to determine whether an update is available.)

  Choose the **Update** button to install the updates.

     ![Update Visual Studio 2017 by using the Visual Studio Installer](media/update-visual-studio.png "Update Visual Studio 2017 by using the Visual Studio Installer")

## Get support

Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:

* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/).
* You can also engage with us and other Visual Studio developers through the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio). (This option requires a [GitHub](https://github.com/) account.)

## See also

* [Install Visual Studio 2017](install-visual-studio.md)
* [Modify Visual Studio 2017](modify-visual-studio.md)
* [Uninstall Visual Studio 2017](uninstall-visual-studio.md)
* [Visual Studio Administrators Guide](visual-studio-administrator-guide.md)
