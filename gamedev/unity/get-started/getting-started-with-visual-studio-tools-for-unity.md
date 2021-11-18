---
title: "Getting Started with Visual Studio Tools for Unity | Microsoft Docs"
description: "Learn how to install and setup Visual Studio for Unity development."
ms.date: "01/27/2021"
ms.technology: vs-unity-tools
ms.prod: visual-studio-dev16
ms.topic: how-to
ms.assetid: 66b5b4eb-13b5-4071-98d2-87fafa4598a8
author: "therealjohn"
ms.author: "johmil"
manager: crdun
ms.workload:
  - "unity"
zone_pivot_groups: platform
---
# Get started with Visual Studio and Unity

> [!NOTE]
> This guide assumes you already have installed Unity using the Unity Hub program. If you are new to Unity, we recommend visiting Unity Learn and complete the [Unity Essentials learning path](https://learn.unity.com/pathway/unity-essentials) first.

## Install Unity support for Visual Studio

Visual Studio Tools for Unity is a free extension that provides support for writing and debugging C# and more. Visit the [Tools for Unity overview](./visual-studio-tools-for-unity.md) for a complete list of what the extensions includes.

:::zone pivot="windows"

> [!NOTE]
> This installation guide is for Visual Studio. If you're using Visual Studio Code, please visit the [Unity Development with VS Code documentation](https://code.visualstudio.com/docs/other/unity).

1. [Download the Visual Studio installer](/visualstudio/install/install-visual-studio), or run it if already installed.
2. Click **Modify** (if already installed) or **Install** (for new installations) for your desired version of Visual Studio.
3. On the **Workloads** tab, scroll to the **Gaming** section and select the **Game development with Unity** workload.

    ![Game development with Unity workload box in the installer](../media/vs/unity-workload.png)

:::zone-end
:::zone pivot="macos"

> [!NOTE]
> This installation guide is for Visual Studio for Mac. If you're using Visual Studio Code, please visit the [Unity Development with VS Code documentation](https://code.visualstudio.com/docs/other/unity).

Tools for Unity is included with the installation of Visual Studio for Mac and no separate installation steps are required. You can verify this in the **Visual Studio for Mac > Extensions > Game Development** menu. **Visual Studio for Mac Tools for Unity** should be enabled.

![Extension Manager view showing Visual Studio for Mac Tools for Unity enabled](../media/vsm/unity-workload.png)

:::zone-end

## Check for updates

It's recommended to keep Visual Studio and Visual Studio for Mac updated so you have the latest bug fixes, features, and Unity support. This doesn't require an update of Unity versions.

:::zone pivot="windows"

1. Click the **Help > Check for Updates** menu.

    ![The Check for Updates menu in Visual Studio 2019](../media/vs/check-for-updates.png)

2. If there is an update available, the Visual Studio Installer will show a new version. Click the **Update** button.

:::zone-end
:::zone pivot="macos"

1. Click the **Visual Studio for Mac > Check for Updates...** menu to open the **Visual Studio Update** dialog.
2. If there is an update available, click the **Install** button.

:::zone-end

## Configure Unity to use Visual Studio

By default, Unity should already be configured to use Visual Studio or Visual Studio for Mac as a script editor. You can confirm this or change the external script editor to a specific version of Visual Studio from the Unity Editor.

:::zone pivot="windows"

1. In the Unity Editor, select the **Edit > Preferences** menu..
2. Select the **External Tools** tab on the left.
3. The **External Script Editor** dropdown list provides a way to choose different installations of Visual Studio. You can also click **Browse...** from the dropdown list to add an unlisted version.

    ![The External Tools preference menu in the Unity Editor on Windows](../media/vs/preferences-external-tools.png)

4. If **Browse...** was selected, navigate to the **Common7/IDE** directory inside your Visual Studio installation directory and select **devenv.exe**. Then, click **Open**.
5. Once Visual Studio is selected in the **External Script Editor** list, confirm that the **Editor Attaching** checkbox is selected.
6. Close the **Preferences** dialog to complete the configuration process.

:::zone-end
:::zone pivot="macos"

1. In the Unity Editor, select the **Unity > Preferences** menu..
2. Select the **External Tools** tab on the left.
3. The **External Script Editor** dropdown list provides a way to choose different installations of Visual Studio. You can also click **Browse...** from the dropdown list to add an unlisted version.

    ![The External Tools preference menu in the Unity Editor on macOS](../media/vsm/preferences-external-tools.png)

4. Close the **Preferences** dialog to complete the configuration process.

:::zone-end

## Next steps

 To learn how to work with and debug your Unity project in Visual Studio, visit [Using Visual Studio Tools for Unity](using-visual-studio-tools-for-unity.md).
