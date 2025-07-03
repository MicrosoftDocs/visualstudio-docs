---
title: Find & manage extension packages
description: Learn about extensions in Visual Studio and how to manage them so you have the controls, samples, templates, tools, and other components you need.
ms.date: 09/05/2024
ms.topic: how-to
f1_keywords:
- vs.ExtensionManager
helpviewer_keywords:
- install extensions
- install packages
- managing extensions visual studio
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to learn about managing extensions so that I can effectively extend the functionality of Visual Studio. 
---

# Find, install, and manage extensions for Visual Studio

::: moniker range="vs-2022"

This article describes how to find, install, and manage extension packages in Visual Studio. [Extensions](../extensibility/index.yml) are code packages that run inside Visual Studio and provide new or improved features. Extensions can be controls, samples, templates, tools, or other components that add functionality to Visual Studio, for example, [Live Share](https://marketplace.visualstudio.com/items?itemName=MS-vsliveshare.vsls-vs-2022) or [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs).

For information about creating Visual Studio extensions, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md). For information about using extensions, see the individual extension page on [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs). For information about finding extensions, see the [Where Are My Favorite Extensions in Visual Studio 2022?](https://devblogs.microsoft.com/visualstudio/where-are-my-favorite-extensions-in-visual-studio-2022/) blog post.

> [!NOTE]
> To learn more about a new extensibility model that's currently in preview, see the [Build Better Extensions with VisualStudio.Extensibility (Preview 3)](https://devblogs.microsoft.com/visualstudio/visualstudio-extensibility-preview-3/) blog post.

::: moniker-end

::: moniker range="<=vs-2019"

This article describes how to find, install, and manage extension packages in Visual Studio. [Extensions](../extensibility/index.yml) are code packages that run inside Visual Studio and provide new or improved features. Extensions can be controls, samples, templates, tools, or other components that add functionality to Visual Studio, for example, [Live Share](https://marketplace.visualstudio.com/items?itemName=MS-vsliveshare.vsls-vs) or [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs).

For information about creating Visual Studio extensions, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md). For information about using extensions, see the individual extension page on [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs).

::: moniker-end

## Use Extension Manager 

In the Visual Studio IDE, Extension Manager is the tool you use to find, install, and manage Visual Studio extensions. To open Extension Manager, select **Extensions** > **Manage Extensions**. Or type **extensions** in the search box and select **Manage Extensions**.

::: moniker range="vs-2022"

:::image type="content" source="media/finding-using-visual-studio-extensions/vs-2022/extensions-and-updates.png" alt-text="Screenshot of Extension Manager in Visual Studio.":::

::: moniker-end

::: moniker range="<=vs-2019"

:::image type="content" source="media/vs-2019/extensions-and-updates.png" alt-text="Screenshot of Extension Manager in Visual Studio.":::

::: moniker-end

The left pane categorizes extensions by those that are available on Visual Studio Marketplace (**Browse**), those that are installed, and those that have updates available. The **Roaming** tab lists all the Visual Studio extensions that you have installed on any machine or instance of Visual Studio. It's designed to let you find your favorite extensions more easily.

## Find and install extensions

You can install extensions from [Visual Studio Marketplace](https://marketplace.visualstudio.com) or from Extension Manager in Visual Studio.

To install extensions from Visual Studio:

1. Select **Extensions** > **Manage Extensions**. Find the extension you want to install. (If you know the name or part of the name of the extension, you can search in the search box.)

1. Select **Install**.

::: moniker range="vs-2022"

  After the download completes, you see a notification at the top of Extension Manager: "Your changes are scheduled. The modifications will begin when Microsoft Visual Studio is closed."

  :::image type="content" source="media/finding-and-using-visual-studio-extensions/manage-extensions-install-notification.png" alt-text="Screenshot of a notification in Extension Manager." lightbox="media/finding-and-using-visual-studio-extensions/manage-extensions-install-notification.png":::

::: moniker-end

::: moniker range="<=vs-2019"

After download completes, you'll see a notification at the bottom of the Manage Extensions dialog box: "The extension is scheduled for install. Your extension will be installed after all instances of Visual Studio have been closed."

  :::image type="content" source="media/vs-2019/manage-extensions-install-notification.png" alt-text="Screenshot of a notification in Extension Manager." lightbox="media/vs-2019/manage-extensions-install-notification.png":::

::: moniker-end

If you try to install an extension that has dependencies, the installer determines whether they're already installed. If they aren't installed, Extension Manager lists the dependencies that must be installed before you can install the extension.

### Install without using Extension Manager

Extensions that are packaged in *.vsix* files might be available in locations other than Visual Studio Marketplace. The **Extensions** > **Extension Manager** dialog can't detect these files, but you can install a *.vsix* file by double-clicking the file or selecting the file and then selecting **Enter**. If you run into permission issues, ensure you are running Visual Studio as an administrator. After that, just follow the instructions. When the extension is installed, you can use Extension Manager to enable it, disable it, or uninstall it.

> [!NOTE]
> - Visual Studio Marketplace contains both .vsix-based and .msi-based extensions. Extension Manager can't enable or disable .msi-based extensions.
> - If an .msi-based extension includes an *extension.vsixmanifest* file, the extension appears in **Extension Manager**.

## Uninstall or disable an extension

If you want to stop using an extension, you can either disable it or uninstall it. Disabling an extension keeps it installed but unloaded. Find the extension and select **Uninstall** or **Disable**. Restart Visual Studio to unload a disabled extension.

> [!NOTE]
> You can disable VSIX-based extensions but not extensions that are installed via MSI. MSI-installed extensions can only be uninstalled.

## Manage extensions

This section provides information about managing extensions for an organization, automatic extension updates, and unresponsiveness notifications.

### Per-user and administrative extensions

Most extensions are per-user extensions and are installed in the *%LocalAppData%\Microsoft\VisualStudio\\<Visual Studio version\>\Extensions\\* folder. A few extensions are administrative extensions and are installed in the *\<Visual Studio installation folder>\Common7\IDE\Extensions\\* folder.

To protect your system against extensions that might contain errors or malicious code, you can restrict per-user extensions to load only when Visual Studio is run with normal user permissions. This causes per-user extensions to be disabled when Visual Studio is run with elevated permissions.

To restrict when per-user extensions load:

1. Open the extensions options page (**Tools** > **Options** > **Environment** > **Extensions**).

1. Clear the **Load per user extensions when running as administrator** checkbox.

1. Restart Visual Studio.

### Automatic extension updates

:::moniker range=">=vs-2019"

Extensions are updated automatically when a new version is available on Visual Studio Marketplace. The new version of the extension is detected and installed in the background. The next time you open Visual Studio, the new version of the extension will be running.

If you want to disable automatic updates, you can disable the feature for all extensions or for only specific extensions.

- To disable automatic updates for all extensions, select the **View Settings** button in the **Extensions** > **Manage Extensions** dialog. In the **Options** dialog, under **Environment** > **Extensions**, clear **Automatically update extensions**.

- To disable automatic updates for a specific extension, clear the **Automatically update this extension** option in the extension's details pane on the right side of Extension Manager.

:::moniker-end

:::moniker range=">=vs-2022"

Extensions are updated automatically when a new version is available on Visual Studio Marketplace. The new version of the extension is detected and installed in the background. The next time you open Visual Studio, the new version of the extension will be running.

If you want to disable automatic updates, you can disable the feature for all extensions or for only specific extensions.

- To disable automatic updates for all extensions, select the **View Settings** button in the **Extensions** > **Manage Extensions** dialog. In the **Options** dialog, under **Environment** > **Extensions**, clear **Automatically update extensions**.

- To disable automatic updates for a specific extension, clear the **Automatically update this extension** option in the extension's details pane on the right side of Extension Manager.

### Manage automatic updates (17.14 and later)

Changes in Visual Studio 2022 17.14 and later make it easier to see what's going on with extension updates, and manage auto-update settings from Extension Manager or in **Tools** > **Options**.

Whenever you open the Extension Manager window, you automatically trigger updates. This ensures you are consistently working with the latest features and fixes without needing to manually initiate updates.

When an update is available for an extension, you see a notification in a yellow infobar:

:::image type="content" source="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-notification-bar.png" alt-text="Screenshot showing how Visual Studio notifies you about extension updates that are available.":::

Also, an infobar appears when updates are applied, reminding you to restart Visual Studio so that the extensions take effect.

You can change settings for automatic updates on the extension's page in Extension Manager.

:::image type="content" source="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-update-automatically.png" alt-text="Screenshot showing how to toggle whether an extension is updated automatically." lightbox="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-update-automatically.png" :::

The **Pending** category enables you to view only extensions with pending updates.

:::image type="content" source="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-category-pending.png" alt-text="Screenshot showing how to filter the extension list to view only extensions with pending updates." lightbox="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-category-pending.png" :::

#### Auto update settings

You can also configure auto-update settings in **Tools > Options**.

:::image type="content" source="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-tools-options.png" alt-text="Screenshot showing how to configure automatic extension updates in Tools > Options." lightbox="./media/vs-2022/finding-and-using-visual-studio-extensions/extension-manager-tools-options.png" :::

The list under **Extensions excluded from automatic updates** shows the extensions currently set to not be updated automatically. You might use this to ensure the stability and consistency of the extensions you're using during a critical phase of your development lifecycle.

:::moniker-end

### Crash and unresponsiveness notifications

Visual Studio notifies you if it suspects that an extension was involved in a crash during a previous session. When Visual Studio crashes, it stores the exception stack. The next time Visual Studio starts, it examines the stack, starting with the leaf and working towards the base. If Visual Studio determines that a frame belongs to a module that's part of an installed and enabled extension, it shows a notification.

Visual Studio also notifies you if it suspects an extension is causing the UI to be unresponsive.

When you see one of these notifications, you can ignore it or take one of the following actions:

- Select **Disable this extension**. Visual Studio disables the extension and lets you know whether you need to restart your system for the disable operation to take effect. You can re-enable the extension in the **Extensions** > **Manage Extensions** dialog.

- Select **Never show this message again**.

  - If the notification concerns a crash in a previous session, Visual Studio no longer shows a notification when a crash associated with the extension occurs. Visual Studio still shows notifications when unresponsiveness can be associated with the extension or for crashes or unresponsiveness that can be associated with other extensions.
  - If the notification concerns unresponsiveness, the IDE no longer shows a notification when the extension is associated with unresponsiveness. Visual Studio still shows crash-related notifications for the extension and crash-related and unresponsiveness-related notifications for other extensions.

- Select **Learn more**.

- Select the **X** at the end of the notification to dismiss the notification. A new notification will appear if the extension is associated with a crash or with UI unresponsiveness in the future.

> [!NOTE]
> A UI unresponsiveness notification or crash notification means that one of the extension's modules was on the stack when the UI was unresponsive or when the crash occurred. It doesn't necessarily mean that the extension caused the problem. It's possible that the extension called code that's part of Visual Studio, which in turn resulted in unresponsive UI or a crash. However, the notification might still be useful if the extension that led to the UI unresponsiveness or crash isn't important to you. In this case, disabling the extension avoids the UI unresponsiveness or crash in the future.

### Samples

When you install an online sample, the solution is stored in two locations:

- A working copy is stored in the location that you specified when you created the project.

- A separate master copy is stored on your computer.

You can use the **Extensions** > **Manage Extensions** dialog box to perform these samples-related tasks:

- List the master copies of samples that you have installed.

- Disable or uninstall the master copy of a sample.

- Install Sample Packs, which are collections of samples that relate to a technology or feature.

- Install individual online samples.

- View update notifications when source code changes are published for installed samples.

- Update the master copy of an installed sample when there's an update notification.

## Related content

- [Visual Studio SDK](/visualstudio/extensibility/visual-studio-sdk)
- [Visual Studio Extensibility](../extensibility/index.yml)
- [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs)
