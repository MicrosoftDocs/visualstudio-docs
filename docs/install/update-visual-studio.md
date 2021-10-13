---
title: Update Visual Studio
titleSuffix: ''
description: Learn how to update Visual Studio to the most recent release, step by step.
ms.date: 09/14/2021
ms.custom: vs-acquisition
ms.topic: how-to
ms.prod: visual-studio-windows
ms.technology: vs-installation
helpviewer_keywords:
- update [Visual Studio]
- change [Visual Studio]
f1_keywords:
- VS.ToolsOptionsPages.Environment.ProductUpdates
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
---
# Update Visual Studio to the most recent release

::: moniker range="vs-2017"

We encourage you to update to the most [recent release](/visualstudio/releasenotes/vs2017-relnotes/) of Visual Studio 2017 so that you always get the latest features, fixes, and improvements.

And if you'd like to try out our newest version, consider downloading and installing [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) instead.

> [!IMPORTANT]
> You must log on with an account that has administrative permissions to install, update, or modify Visual Studio. For more information, see [User Permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md).
>
> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Update Visual Studio for Mac](/visualstudio/mac/update).

## Update Visual Studio 2017 version 15.6 or later

We've streamlined the installation and update experience to make it easier to use directly from within the IDE. Here's how to update from version 15.6 and later to newer versions of Visual Studio.

### Using the Notifications hub

When there's an update, there's a corresponding notification flag in Visual Studio.

1. Save your work.

1. Choose the notification flag to open the **Notifications** hub, and then choose the update that you want to install.

   ![Screenshot showing an update in the the Notification hub of the Visual Studio IDE.](media/vs-install-notifications-hub-15dot6.png "The Notifications hub in Visual Studio 2017")

      > [!TIP]
      > An update for an edition of Visual Studio 2017 is cumulative, so always choose to install the one with the most recent version number.

1. When the **Update** dialog box opens, choose **Update Now**.

    ![Screenshot showing the Update Now button in the Update dialog box launched from the Notifications hub of Visual Studio 2017.](media/vs-update-now-from-notifications-hub.png "The Update dialog box from the Notifications hub in Visual Studio")

     If a User Access Control dialog box opens, choose **Yes**. Next, a "Please wait" dialog might open for a moment, and then the Visual Studio Installer opens to start the update.

     ![Screenshot showing the new Visual Studio Installer experience in version 15.6.](media/visual-studio-15dot6-installer.png "The new Visual Studio Installer experience in version 15.6")

     Your update continues. Then, when it's complete, Visual Studio restarts.

     > [!NOTE]
     > When you run Visual Studio in administrator mode, you must manually restart Visual Studio after the update.

### Using the IDE

You can check for an update and then install the update from the menu bar in Visual Studio.

1. Save your work.

1. Choose **Help** > **Check for Updates**.

     ![Screenshot showing the new Help menu in Visual Studio version 15.6.](media/vs-help-menu-check-for-updates.png "The new Help menu in Visual Studio version 15.6")

1. When the **Update** dialog box opens, choose **Update Now**.

   The update proceeds as described in the previous section, and then Visual Studio restarts after the update completes successfully.

   > [!NOTE]
   > When you run Visual Studio in administrator mode, you must manually restart Visual Studio after the update.

### Using the Visual Studio Installer

As in earlier versions of Visual Studio, you can use the Visual Studio Installer to install an update.

1. Save your work.

1. Open the installer. The Visual Studio Installer might require updating before you continue.

   > [!NOTE]
   > On a computer running Windows 10 or later, you can find the installer under the letter **V** as the **Visual Studio Installer**, or under the letter **M** as the **Microsoft Visual Studio Installer**.

1. On the **Product** page in the installer, look for the edition of Visual Studio that you installed previously.

1. If an update is available, you see an **Update** button. (It might take a few seconds for the installer to determine whether an update is available.)

   Choose the **Update** button to install the updates.

     ![Screenshot showing the Update button in the Visual Studio Installer that can be used to update Visual Studio 2017.](media/update-visual-studio.png "Update Visual Studio 2017 by using the Visual Studio Installer")

## Update Visual Studio 2017 version 15.5 or earlier

If you're using an earlier version, here's how to apply an update from Visual Studio 2017 version 15.0 through version 15.5.

### Update by using the Notifications hub

1. When there are updates, there's a corresponding notification flag in Visual Studio.

   ![Screenshot showing a Notification flag in Visual Studio 2017 that indicates an update is available.](media/notification-flag.png "The update Notification flag in Visual Studio")

   Choose the notification flag to open the **Notifications** hub.

   ![Screenshot showing the Visual Studio 2017 Notification hub with one notification.](media/notifications-hub.png "Visual Studio 2017 update in the Notification hub")

      > [!TIP]
      > An update for an edition of Visual Studio 2017 is cumulative, so always choose to install the one with the most recent version number.

1. Choose **"Visual Studio Update" is available**, which opens the **Extensions and Updates** dialog box.

   ![Screenshot showing a Visual Studio 2017 update notification in the Notification hub.](media/notifications-hub-select.png "Choose Visual Studio Update")

1. In the **Extensions and Updates** dialog box, choose the **Update** button.

   ![Screenshot showing an update in the Extensions and Updates dialog window.](media/notifications-extensions-and-updates.png "The Extensions and Updates dialog in Visual Studio")

#### More about Visual Studio notifications

Visual Studio notifies you when an update is available for Visual Studio itself or for any components, and also when certain events occur in the Visual Studio environment.

* When the notification flag is yellow, there's a Visual Studio product update available for you to install.
* When the notification flag is red, there's a problem with your license.
* When the notification flag is black, there are optional or informational messages to review.

Choose the notifications flag to open the **Notifications** hub and then choose the notifications that you want to act on. Or, choose to ignore or dismiss a notification.

 ![Screenshot showing an optional or informational message in the Notification hub.](media/notification-flag-optional.png "The optional or informational message Notification flag in Visual Studio")

If you choose to ignore a notification, Visual Studio stops showing it. If you want to reset the list of ignored notifications, choose the **Settings** button in the Notifications hub.

   ![Screenshot showing the Settings button in the Notifications hub to view Notification options.](media/vs-notifications-hub-settings-button.png "Choose the Settings button in the Notifications hub to view notification options")

### Update by using the Visual Studio Installer

1. Open the installer. You might need to update the installer before continuing. If this is the case, you're prompted to do so.

   > [!NOTE]
   > On a computer running Windows 10 or later, you can find the installer under the letter **V** as the **Visual Studio Installer**, or under the letter **M** as the **Microsoft Visual Studio Installer**.

1. On the **Product** page in the installer, look for the edition of Visual Studio that installed previously.

1. If an update is available, you see an **Update** button. (It might take a few seconds for the installer to determine whether an update is available.)

   Choose the **Update** button to install the updates.

     ![Screenshot showing the Update button in the Visual Studio Installer for a Visual Studio 2017 update.](media/update-visual-studio.png "Update Visual Studio by using the Visual Studio Installer")

::: moniker-end

::: moniker range="vs-2019"

We encourage you to update to the most [recent release](/visualstudio/releases/2019/release-notes/) of Visual Studio so that you always get the latest features, fixes, and improvements.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free. If you are currently using a different version of Visual Studio, you can either [install Visual Studio versions side-by-side](../install/install-visual-studio-versions-side-by-side.md), or [uninstall previous versions of Visual Studio](../install/uninstall-visual-studio.md).

> [!IMPORTANT]
> You must log on with an account that has administrative permissions to install, update, or modify Visual Studio. For more information, see [User Permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md).
>
> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Update Visual Studio for Mac](/visualstudio/mac/update).

Here's how to update Visual&nbsp;Studio&nbsp;2019.

## Use the Visual Studio Installer

1. Find the **Visual Studio Installer** on your computer.

   In the Windows Start menu, you can search for "installer".

   ![Screenshot showing the result of a Start menu search for the Visual Studio Installer.](media/vs-2019/visual-studio-installer.png "Search for the Visual Studio Installer")

   You might have to update the installer before continuing. If so, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed.

   For example, if you previously installed Visual&nbsp;Studio Community&nbsp;2019 and there's an update for it, then an **Update available** message appears in the installer.

     ![Screenshot showing a Visual Studio 2019 installation with an available update.](media/vs-2019/vs-installer-update-visual-studio-community.png "Select the edition of Visual Studio 2019 that you want to update")

1. Choose **Update** to install the updates.

    ![Screenshot showing the Update button in the Visual Studio installer that can be used to update to a Visual Studio 2019 installation.](media/vs-2019/vs-installer-choose-update-visual-studio-community.png "Select the Update button to install the updates")

1. After the update is complete, you might be asked to restart your computer. If so, do so, and then start Visual Studio as you typically would.

   If you aren't asked to restart your computer, choose **Launch** to start Visual Studio from the installer.

    ![Screenshot showing the Launch button in the Visual Studio installer that can be used to start Visual Studio 2019.](media/vs-2019/choose-launch-visual-studio-community.png "Select the Launch button to start Visual Studio")

## Use the IDE

You can check for an update and then install it by using the menu bar or the search box in Visual Studio 2019.

### Open Visual Studio

1. From the Windows **Start** menu, choose **Visual Studio 2019**.

    ![Screenshot showing the results of a Visual Studio IDE start window search for Visual Studio 2019.](media/vs-2019/vs-installer-visual-studio-2019.png "Open Visual Studio 2019 from Windows")

1. Under **Get started**, choose any option to open the IDE.

    ![Screenshot showing the Visual Studio Installer.](media/vs2019-choose-option-from-get-started.png "Open the Visual Studio Installer")

    Visual Studio opens. In the IDE, a **Visual Studio 2019 update** message appears briefly.

    ![Screenshot showing the 'Visual Studio 2019 update' message in the IDE.](media/vs-2019/update-visual-studio-ide-message.png "The 'Visual Studio 2019 update' message in the IDE")

1. In the **Visual Studio 2019 update** message, choose **View details**.

   ![Screenshot showing the View Details button in the Visual Studio 2019 IDE update message.](media/vs-2019/update-visual-studio-ide-view-details.png "Choose the View Details button in the Visual Studio 2019 update message")

1. In the **Update downloaded and ready to install** dialog box, choose **Update**.

     ![Screenshot showing the Update button in the 'Update downloaded and ready to install' dialog box.](media/vs-2019/update-ready-install-visual-studio-community-from-ide.png "Choose the Update button in the 'Update downloaded and ready to install' dialog box")

   Visual Studio updates, closes, and then reopens.

### In Visual Studio

1. From the menu bar, choose **Help**, and then choose **Check for Updates**.

     ![Screenshot showing the 'Check for Updates' from the Help menu.](media/vs-2019/vs-ide-check-updates-help-menu.png "Choose 'Check for Updates' from the Help menu")

    > [!NOTE]
    > You can also use the search box in the IDE to check for updates. Press **Ctrl**+**Q**, type "check for updates", and then choose the search result that matches.

1. In the **Update available** dialog box, choose **Update**.

     ![Screenshot showing the Update button in the 'Update available' dialog box.](media/vs-2019/update-visual-studio-community-from-ide.png "Choose the Update button in the 'Update available' dialog box")

   Visual Studio updates, closes, and then reopens.

## Use the Notifications hub

1. In Visual Studio, save your work.

1. Choose the notification icon from the lower-right corner of the Visual Studio IDE to open the **Notifications** hub.

   ![Screenshot showing the notification icon in the Visual Studio IDE.](media/vs-2019/notification-bar.png "The notification icon in the Visual Studio IDE")

1. In the **Notifications hub**, choose the update that you want to install, and then choose **View details**.

     ![Screenshot showing the Notification hub in Visual Studio 2019.](media/vs-2019/notification-hub-update.png "The Notification hub in Visual Studio 2019")

      > [!TIP]
      > An update for an edition of Visual Studio 2019 is cumulative, so always choose to install the one with the most recent version number.

1. In the **Update available** dialog box, choose **Update**.

   Visual Studio updates, closes, and then reopens.

## Customize update settings

You can customize the update settings in Visual Studio in several different ways, such as by changing the installation mode and by selecting automatic downloads.

There are two installation modes to choose from:

* **Install while downloading**
* **Download all, then install**

You can also choose the **Automatically download updates** setting, which allows updates to download while your machine is idle.

Here's how:

1. On the menu bar, choose **Tools** > **Options**.

1. Expand **Environment**, and then choose **Product Updates**.

    ![Screenshot showing the updates settings in Visual Studio.](media/vs-2019/update-settings-options.png)

1. Choose the installation mode and the automatic download options you want for your Visual Studio updates.

::: moniker-end

::: moniker range=">=vs-2022"

We encourage you to update to the most [recent release](/visualstudio/releases/2022/release-notes-preview) of Visual Studio so that you always get the latest features, fixes, and improvements.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free. If you're currently using a different version of Visual Studio, you can either [install Visual Studio versions side-by-side](../install/install-visual-studio-versions-side-by-side.md), or [uninstall previous versions of Visual Studio](../install/uninstall-visual-studio.md).

> [!IMPORTANT]
> To install, modify, or update Visual Studio, you must run the Visual Studio Installer as an administrator. If you try to modify Visual Studio as a typical user, you'll get a User Account Control notice prompting you for admin credentials. For more information, see [User Permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md).
>
> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Update Visual Studio for Mac](/visualstudio/mac/update).

Here's how to update Visual Studio 2022.

## Use the Visual Studio Installer

1. Find the **Visual Studio Installer** on your computer.

   In the Windows Start menu, search for "installer", and then select **Visual Studio Installer** from the results.

   ![Screenshot showing the result of a Start menu search for the Visual Studio Installer.](media/vs-2022/vs-installer.png "Search for the Visual Studio Installer")

   > [!NOTE]
   > You can also find the Visual Studio Installer in the following location:
   >
   > `C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

   If you're prompted to update the Visual Studio Installer before continuing, do so by following the prompts.

1. In the Visual Studio Installer, look for the installation of Visual Studio that you want to update. 

   For example, if you previously installed Visual Studio Community 2022 Preview and there's an update for it, then an **Update available** message appears in the Visual Studio Installer.

     ![Screenshot showing the Update button and message in the Visual Studio Installer when a new update is available.](media/vs-2022/vs-installer-update-visual-studio-community.png "Select the edition of Visual Studio 2022 that you want to update")

1. Choose **Update** to install the update.

    ![Screenshot showing the Update button that you can select to install the new update.](media/vs-2022/vs-installer-choose-update-visual-studio-community.png "Select the Update button to install the update")

1. After the update is complete, the Visual Studio Installer might prompt you to restart your computer. If so, do so, and then start Visual Studio as you typically would.

    If you aren't asked to restart your computer, choose **Launch** to start Visual Studio from the Visual Studio Installer.

    ![Screenshot showing the Launch button that you can select to start Visual Studio.](media/vs-2022/vs-installer-choose-launch-visual-studio-community.png "Select the Launch button to start Visual Studio")

## Use the Visual Studio IDE

You can check for an update and then install it by using the menu bar or the search box in Visual Studio 2022.

### Open Visual Studio

1. From the Windows **Start** menu, choose **Visual Studio 2022 RC**.

    ![Screenshot showing the Visual Studio 2022 RC entry in the Windows 10 Start menu.](media/vs-2022/ide-start-menu.png "Open Visual Studio 2022 RC from Windows")

1. Under **Get started** in the start window, choose any option to open the Visual Studio IDE.

    ![Screenshot showing the start window in the Visual Studio IDE.](media/vs-2022/choose-option-from-get-started.png "Open the Visual Studio IDE")

    Visual Studio opens. In the Visual Studio IDE, a **Visual Studio 2022 update** message appears briefly.

    ![Screenshot showing an update message for Visual Studio 2022 in the lower-right corner of the Visual Studio IDE.](media/vs-2022/update-visual-studio-ide-message.png "The 'Visual Studio 2022 update' message in the IDE")

1. In the Visual Studio 2022 update message, choose **View details**.

   ![Screenshot showing the View details button for the Visual Studio 2022 update notification in the Visual Studio IDE.](media/vs-2022/update-visual-studio-ide-view-details.png "Choose the View Details button in the Visual Studio 2022 update message")

1. In the **Update available** dialog box, choose **Update**.

     ![Screenshot showing the Update button in the 'Update available' dialog box in Visual Studio 2022.](media/vs-2022/update-ready-install-visual-studio-community-from-ide.png "Choose the Update button in the 'Update available' dialog box")

   Visual Studio updates, closes, and then reopens.

### In Visual Studio

1. From the menu bar, choose **Help**, and then choose **Check for Updates**.

     ![Screenshot showing the 'Check for Updates' option in the Help menu.](media/vs-2022/ide-check-updates-help-menu.png "Choose 'Check for Updates' from the Help menu")

    > [!NOTE]
    > You can also use the search box in the Visual Studio IDE to check for updates. Press **Ctrl**+**Q**, type "check for updates", and then choose the search result that matches.

1. In the **Update available** dialog box, choose **Update**.

     ![Screenshot showing the Update button in the 'Update available' dialog box.](media/vs-2022/update-visual-studio-community-from-ide.png "Choose the Update button in the 'Update available' dialog box")

   Visual Studio updates, closes, and then reopens.

## Use the Notifications hub

1. In Visual Studio, save your work.

1. Choose the notification icon from the lower-right corner of the Visual Studio IDE to open the **Notifications hub**.

   ![Screenshot showing the notification icon in the Visual Studio IDE.](media/vs-2022/notification-bar.png "The notification icon in Visual Studio 2022")

1. In the **Notifications hub**, choose the update that you want to install, and then choose **View details**.

     ![Screenshot showing the Notifications hub in the Visual Studio IDE.](media/vs-2022/notification-hub-update.png "The Notifications hub in Visual Studio 2022")

      > [!TIP]
      > Updates for each edition of Visual Studio 2022 are cumulative, so always choose to install the update with the most recent version number.

1. In the **Update available** dialog box, choose **Update**.

   Visual Studio updates, closes, and then reopens.

## Customize update settings

You can customize the update settings in Visual Studio in several different ways, such as by changing the installation mode or selecting automatic downloads.

There are two installation modes to choose from:

* **Install while downloading**
* **Download all, then install**

You can also select the **Automatically download updates** option, which lets Visual Studio download updates while your machine is idle.

Here's how:

1. On the menu bar, choose **Tools** > **Options**.

1. Expand **Environment**, and then choose **Product Updates**.

    ![Screenshot showing the Updates settings in the Options window of the Visual Studio IDE.](media/vs-2022/update-settings-options.png)

1. Choose the installation mode and automatic download option you want for your Visual Studio updates.

::: moniker-end

## Administrator updates

If you are part of an organization that centralizes management of software installations, then your enterprise administrator might control how Visual Studio updates your machine. For more about how to control or configure the types of updates your machine can accept, see [Using Configuration Manager to deploy Visual Studio updates](../install/applying-administrator-updates.md#using-configuration-manager-to-deploy-visual-studio-updates).

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio versions side-by-side](install-visual-studio-versions-side-by-side.md)
* [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
* [Visual Studio enterprise guide](visual-studio-enterprise-guide.md)
* [Update Visual Studio while on a servicing baseline](update-servicing-baseline.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Modify Visual Studio](modify-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
