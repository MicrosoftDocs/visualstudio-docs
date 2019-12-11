---
title: "Remove Visual Studio"
titleSuffix: ""
description: "Learn how to completely remove Visual Studio from your computer, step-by-step."
ms.date: 03/30/2019
ms.custom: "seodec18"
ms.topic: conceptual
f1_keywords:
  - "uninstall"
  - "uninstall Visual Studio"
  - "remove"
  - "remove Visual Studio"
  - "cleanup"
  - "cleanup Visual Studio"
  - "clean up"
  - "clean up Visual Studio"
ms.assetid: 9c81a777-9c95-4934-b517-c60c6dc78799
author: heaths
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Remove Visual Studio

If you encounter a catastrophic error and cannot repair or uninstall Visual Studio, you can run the `InstallCleanup.exe` tool to remove installation files and product information for all installed instances of Visual Studio 2017 or Visual Studio 2019. Running this tool should be done only as a last resort if repair or uninstall fail, and may uninstall features from other Visual Studio installations or other products that might then also need to be repaired.

In the following instructions, you can run the tool with different command-line switches with the following behavior:

| Switch | Behavior |
| ------ | -------- |
| `-i`   | This switch is the default if no other switch is passed and removes only the main installation directory and product information. This behavior is preferable if you intend to reinstall the same version after you run the `InstallCleanup.exe` tool. |
| `-f`   | Specifying this switch removes the main installation directory, product information, and most other features installed outside the installation directory that may be shared with other Visual Studio installations or other products. This behavior is preferable if you intend to remove Visual Studio without reinstalling later. |

1. Close the Visual Studio Installer.
2. Open an administrator command prompt. To open an administrator command prompt, follow these steps:
   * Type **cmd** in the "Type here to search" box.
   * Right-click **Command Prompt**, and then click **Run as administrator**.
3. Type the full path of the `InstallCleanup.exe` utility and pass whichever command-line switch you desire. By default, the path of the utility is as follows:

   ```
   C:\Program Files (x86)\Microsoft Visual Studio\Installer\resources\app\layout\InstallCleanup.exe
   ```

If you do not find `InstallCleanup.exe` under the Visual Studio Installer directory - always located at `%ProgramFiles(x86)%\Microsoft Visual Studio` - follow the instructions to [install Visual Studio](install-visual-studio.md) and when the workload selection screen is displayed, close the window and follow the preceding steps again.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Modify Visual Studio](modify-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
