---
title: Remove Visual Studio
titleSuffix: ''
description: Learn how to completely remove Visual Studio from your computer, step by step.
ms.date: 08/24/2021
ms.custom: vs-acquisition
ms.topic: how-to
f1_keywords:
- uninstall
- uninstall Visual Studio
- remove
- remove Visual Studio
- cleanup
- cleanup Visual Studio
- clean up
- clean up Visual Studio
ms.assetid: 9c81a777-9c95-4934-b517-c60c6dc78799
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Remove Visual Studio

If you experience a catastrophic error and can't repair or uninstall Visual Studio, you can run the `InstallCleanup.exe` tool to remove installation files and product information for all installed instances of Visual Studio 2017, Visual Studio 2019, or Visual Studio 2022.

> [!WARNING]
> Use the InstallCleanup tool **only as a last resort** if repair or uninstall fail. This tool might uninstall features from other Visual Studio installations or other products, which then might also need to be repaired or reinstalled.

## Run InstallCleanup.exe

You can use either of the following command-line switches with the `InstallCleanup.exe` tool:

| Switch | Behavior |
|-----------------|--------------------|
|  `-i [version]`   | This switch is the default if no other switch is passed. It removes only the main installation directory and product information. Use this switch if you intend to reinstall the same version of Visual Studio after you run the `InstallCleanup.exe` tool. If a `[version]` value is specified, only products with a version that start with this string value will be removed. |
|   `-f`           | This switch removes the main installation directory, product information, and most other features installed outside the installation directory, that might also be shared with other Visual Studio installations or other products. Use this switch if you intend to remove Visual Studio without reinstalling it later. |

Here's how to run the `InstallCleanup.exe` tool:

1. Close the Visual Studio Installer.
1. Open an administrator command prompt. To open an administrator command prompt, follow these steps:
   * Type **cmd** in the "Type here to search" box.
   * Right-click **Command Prompt**, and then choose **Run as administrator**.
1. Enter the full path of the `InstallCleanup.exe` tool and add the command-line switch you prefer. By default, the path of the tool is as follows. The double quotes enclose a command containing spaces:

   ```shell
   "C:\Program Files (x86)\Microsoft Visual Studio\Installer\InstallCleanup.exe"
   ```

   > [!NOTE]
   > If you can't find `InstallCleanup.exe` under the Visual Studio Installer directory, which is always located at `%ProgramFiles(x86)%\Microsoft Visual Studio`, here's what to do next. Follow the instructions to [install Visual Studio](install-visual-studio.md). Then, when the workload selection screen is displayed, close the window and follow the steps on this page again.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Modify Visual Studio](modify-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
