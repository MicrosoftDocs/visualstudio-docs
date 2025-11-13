---
title: Uninstall or Remove Visual Studio
titleSuffix: ''
description: Uninstall or remove your installation of Visual Studio along with its integrated suite of productivity tools for developers.
ms.date: 09/09/2025
ms.custom: vs-acquisition
ms.topic: how-to
f1_keywords:
- uninstall
- uninstall Visual Studio
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
#customer intent: As a developer, I want to uninstall a version of Visual Studio because I no longer need that version or as part of troubleshooting.
---
# Uninstall or remove Visual Studio

This article walks you through uninstalling Visual Studio, the integrated suite of productivity tools for developers.

> [!TIP]
> If you're having trouble with your instance of Visual Studio, try the [Repair  Visual Studio](../install/repair-visual-studio.md) tool.
>
> To change the location for some of your Visual Studio files, you can do so without uninstalling your current instance. For more information, see [Select the installation locations](../install/change-installation-locations.md).

## Uninstall by using Visual Studio Installer

You can use Visual Studio Installer to uninstall versions of Visual Studio.

::: moniker range="vs-2019"

1. Find the Visual Studio Installer on your computer.

   On the Windows Start menu, you can search for *installer*.

   :::image type="content" source="media/vs-2019/visual-studio-installer.png" alt-text="Screenshot that shows searching for the Visual Studio Installer on the Start menu.":::

   > [!NOTE]
   > You can also find the Visual Studio Installer at *C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe*.

   You might have to update the installer before you continue. If you do, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed. Next, select **More**, and then select **Uninstall**.

   :::image type="content" source="media/vs-2019/vs-installer-uninstall.png" alt-text="Screenshot that shows how to uninstall Visual Studio by using the Visual Studio Installer.":::

1. Select **OK** to confirm your choice.

   :::image type="content" source="media/vs-2019/uninstall-visualstudio-confirm.png" alt-text="Screenshot that shows the dialog to confirm that you want to uninstall Visual Studio 2019.":::

If you change your mind later and want to reinstall Visual Studio 2019, start the Visual Studio Installer again, select the **Available** tab, choose the edition of Visual Studio that you want to install, and then select **Install**.

::: moniker-end

::: moniker range=">=vs-2022"

1. Find the Visual Studio Installer on your computer.

   On the Windows Start menu, you can search for *installer*.

   :::image type="content" source="media/vs-2019/visual-studio-installer.png" alt-text="Screenshot that shows the Visual Studio Installer on the Start menu.":::

   > [!NOTE]
   > You can also find the Visual Studio Installer in the following location:
   >
   > *C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe*

   You might have to update the installer before you continue. If you do, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed. Next, select **More**, and then select **Uninstall**.

   :::image type="content" source="media/vs-2022/vs-installer-uninstall.png" alt-text="Screenshot that shows how to uninstall Visual Studio by using the Visual Studio Installer.":::

1. Select **OK** to confirm your choice.

   :::image type="content" source="media/vs-2022/uninstall-visualstudio-confirm.png" alt-text="Screenshot that shows the dialog to confirm that you want to uninstall Visual Studio 2022.":::

If you change your mind later and want to reinstall Visual Studio, start the Visual Studio Installer again, select the **Available** tab,  choose the edition of Visual Studio that you want to install, and then select **Install**.

::: moniker-end

## Uninstall Visual Studio

::: moniker range="vs-2019"

To remove all installations of Visual Studio 2019 and the Visual Studio Installer from your machine, uninstall Visual Studio from **Installed apps**.

1. In Windows 10 or later, enter **Add or remove programs** in the Windows search box.
1. Find Visual Studio 2019.
1. In the ellipsis menu (**...**) next to **Microsoft Visual Studio 2019**, select **Uninstall**.
1. Find Visual Studio Installer.
1. In the ellipsis menu next to **Microsoft Visual Studio Installer**, select **Uninstall**.

::: moniker-end

::: moniker range=">=vs-2022"

To remove all installations of Visual Studio and the Visual Studio Installer from your machine, uninstall Visual Studio from **Installed apps**.

1. In Windows 10 or later, enter **Add or remove programs** in the Windows search box.
1. Find Visual Studio.
1. In the ellipsis menu (**...**) next to the **Visual Studio** version you want to uninstall, select **Uninstall**.
1. Find Visual Studio Installer.
1. In the ellipsis menu next to **Microsoft Visual Studio Installer**, select **Uninstall**.

::: moniker-end

<a name="remove"></a>

## Remove all by using InstallCleanup.exe

If you experience an error and can't repair or uninstall Visual Studio, you can run the `InstallCleanup.exe` tool to remove installation files and product information for all installed instances of a Visual Studio version.

> [!WARNING]
> Use the InstallCleanup tool only as a last resort if repair or uninstallation fails. This tool might uninstall features from other Visual Studio installations or other products, which you then might need to repair or reinstall.

To run the `InstallCleanup.exe` tool:

1. Close the Visual Studio Installer.
1. Open an administrator command prompt. To open an administrator command prompt, follow these steps:

   1. Type *cmd* in the Windows search box.
   1. Right-click **Command Prompt**, and then select **Run as administrator**.

1. Enter the full path of the InstallCleanup.exe tool and add the command-line parameters that you prefer. By default, the path of the tool is as shown in the following command. Double quotation marks are used to enclose a command that contains spaces.

   ```cmd
   "C:\Program Files (x86)\Microsoft Visual Studio\Installer\InstallCleanup.exe"
   ```

   > [!NOTE]
   > The Visual Studio Installer directory is always located at *%ProgramFiles(x86)%\Microsoft Visual Studio*. If you can't find *InstallCleanup.exe* there, follow the instructions to [install Visual Studio](install-visual-studio.md). Then, when the workload selection screen is displayed, close the window and follow the steps in this section again.

   These options are available:

   | Parameter | Behavior |
   |-----------------|--------------------|
   | `-i [version]`  | If you don't specify a value, the tool uses the default version. Removes only the main installation directory and product information. Use this parameter if you intend to reinstall the same version of Visual Studio. If you specify a `[version]` value, the tool removes only products with a version that start with this string value. For example, use the value `-i 17` to remove all version 17 products.  |
   | `-f`            | Removes the main installation directory, product information, and most other features installed outside the installation directory, which might also be shared with other Visual Studio installations or other products. Use this parameter if you intend to remove Visual Studio without reinstalling it later.|

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Modify Visual Studio](modify-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Install Visual Studio](install-visual-studio.md)
