---
title: "Install & configure Visual Studio Tools for Unity"
description: Connect Unity and Visual Studio and use Visual Studio Tools for Unity to support writing and debugging for cross-platform development.
ms.date: 08/26/2022
ms.subservice: unity-tools
ms.service: visual-studio
ms.topic: quickstart
author: "therealjohn"
ms.author: "johmil"
manager: crdun
zone_pivot_groups: platform
---

# Quickstart: Configure Visual Studio for cross-platform development with Unity

In this quickstart, you learn how to install the Visual Studio Tools for Unity extension and configure it for developing cross-platform games and apps with Unity. The Visual Studio Tools for Unity extension is free and provides support for writing and debugging C# and more. Visit the [Tools for Unity overview](./visual-studio-tools-for-unity.md) for a complete list of what that workload includes.

> [!NOTE]
> For Visual Studio Code & Unity, visit the [Unity Development with VS Code documentation](https://code.visualstudio.com/docs/other/unity).

## Install Visual Studio and Unity

:::zone pivot="windows"

1. [Download the Visual Studio installer](/visualstudio/install/install-visual-studio), or open it if already installed.
1. Select **Install**, or **Modify** if Visual Studio is already installed.
1. Select the **Workloads** tab, then select the **Game development with Unity** workload.
1. If Unity isn't already installed, select **Unity Hub** under **Optional**.
1. Select **Modify** or **Install** to complete the installation.

   :::image type="content" source="../media/vs/unity-workload.png" alt-text="Screenshot of the game development with Unity workload checkbox in the installer.":::

When Visual Studio completes the installation process, you're ready to set up Unity.

1. Open the Unity Hub, which was installed during the Visual Studio Tools for Unity installation.
1. On the left of the Unity Hub window, select the **Installs** tab.
1. Select the **Add** button.
1. In the **Add Unity Version** window, select a version of Unity to install.
1. Select **Next** to continue the installation.
1. In the **Add modules to your install** step, select **Done**.

   > [!NOTE]
   > If you've already installed Visual Studio 2022, you can deselect the **Microsoft Visual Studio Community 2019** option.

The Unity Hub continues installing Unity in the background. When it's complete, you can create a new project by selecting the **Projects** tab and selecting **New**.

> [!TIP]
> Projects are created using the Unity Editor and not Visual Studio.

:::zone-end

:::zone pivot="macos"

> [!NOTE]
> This installation guide is for Visual Studio for Mac. If you're using Visual Studio Code, please visit the [Unity Development with VS Code documentation](https://code.visualstudio.com/docs/other/unity).

Visual Studio for Mac Tools for Unity is included with the installation of Visual Studio for Mac. It requires no separate installation steps. You can verify the installation in the **Visual Studio for Mac** > **Extensions** > **Game Development** menu. **Visual Studio for Mac Tools for Unity** should be enabled.

:::image type="content" source="../media/vsm/unity-workload.png" alt-text="Screenshot of the Extension Manager view showing Visual Studio for Mac Tools for Unity enabled.":::

:::zone-end

## Configure Unity to use Visual Studio

By default, Unity should already be configured to use Visual Studio or Visual Studio for Mac as a script editor. You can confirm this option or change the external script editor to a specific version of Visual Studio from the Unity Editor.

:::zone pivot="windows"

1. In the Unity Editor, select the **Edit > Preferences** menu.
1. On the left, select the **External Tools** tab.

   :::image type="content" source="../media/vs/preferences-external-tools.png" alt-text="Screenshot of the External Tools preference menu in the Unity Editor on Windows.":::

### Add a version of Visual Studio that isn't listed

It's possible to select other versions of Visual Studio that are unlisted and installed in a custom directory.

1. Select **Browse...** from the dropdown list.
1. Navigate to the *Common7/IDE* directory inside your Visual Studio installation directory and select *devenv.exe*. Then select **Open**.
1. For Unity 2019 and older only, confirm that **Editor Attaching** is selected.
1. Close the **Preferences** dialog to complete the configuration process.

:::zone-end

:::zone pivot="macos"

1. In the Unity Editor, select the **Unity** > **Preferences** menu.
1. On the left, select the **External Tools** tab.
1. Use the **External Script Editor** dropdown list to choose different installations of Visual Studio for Mac.

   :::image type="content" source="../media/vsm/preferences-external-tools.png" alt-text="Screenshot of the External Tools preference menu in the Unity Editor on macOS.":::

1. Close the **Preferences** dialog to complete the configuration process.

:::zone-end

### Install or update the Visual Studio Editor package

:::zone pivot="windows"

In Unity versions 2020 and later, a separate Unity Package is required for the best experience working with IDEs like Visual Studio and Visual Studio for Mac. This package should be included by default, but updates are released to this package that you can install to at any time.

1. In the Unity Editor, select the **Windows** > **Package Manager** menu.
1. Select the **Visual Studio Editor** package.
1. If a new version is available, select **Update**.

   :::image type="content" source="../media/vs/unity-package-manager.png" alt-text="Screenshot of the Package Manager window in the Unity Editor on Windows.":::

:::zone-end

:::zone pivot="macos"

In Unity versions 2020 and later, a separate Unity Package is required for the best experience working with IDEs like Visual Studio and Visual Studio for Mac. This package should be included by default, but updates are released to this package that you can install to at any time.

1. In the Unity Editor, select the **Windows** > **Package Manager** menu.
1. Select the **Visual Studio Editor** package.
1. If a new version is available, select **Update**.

   :::image type="content" source="../media/vsm/unity-package-manager.png" alt-text="Screenshot of the Package Manager window in the Unity Editor on Mac.":::

:::zone-end

## Check for updates

We recommend that you keep Visual Studio and Visual Studio for Mac updated for the latest bug fixes, features, and Unity support. Updating Visual Studio doesn't require an update of Unity versions.

:::zone pivot="windows"

1. Select the **Help** > **Check for Updates** menu.

   :::image type="content" source="../media/vs/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, the Visual Studio Installer shows a new version. Select **Update**.

   :::image type="content" source="../media/vs/click-to-update.png" alt-text="Screenshot of Visual Studio Installer with the Updates.":::

:::zone-end

:::zone pivot="macos"

1. Select the **Visual Studio for Mac** > **Check for Updates...** menu to open the **Visual Studio Update** dialog.

   :::image type="content" source="../media/vsm/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, Visual Studio Update shows a new version, select **Restart and Install Updates**.

   :::image type="content" source="../media/vsm/restart-and-install-updates.png" alt-text="Screenshot of Visual Studio Updates with the Updates.":::

:::zone-end

## Next steps

Learn about this extension's [integration and productivity features, and how to use the Visual Studio debugger for Unity development](using-visual-studio-tools-for-unity.md).
