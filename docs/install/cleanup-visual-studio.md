---
title: "Clean up Visual Studio 2017 | Microsoft Docs"
description: "Learn how to clean up Visual Studio, step-by-step."
ms.custom: ""
ms.date: "09/12/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "uninstall"
  - "uninstall Visual Studio"
  - "cleanup"
  - "cleanup Visual Studio"
  - "clean up"
  - "clean up Visual Studio"
ms.assetid: 9c81a777-9c95-4934-b517-c60c6dc78799
author: "heaths"
ms.author: "heaths"
manager: "erickn"
---

# Clean up Visual Studio

If you encounter a catastrophic error and cannot repair or uninstall Visual Studio, you can run the `InstallCleanup.exe` tool to remove installation files and product information. This is to be done as a last resort if repair or uninstall fail, and may uninstall features from other Visual Studio installations or other products which will need to be repaired.

In the instructions below, you can run the tool with different command line switches with the following behavior.

| Switch | Behavior |
| ------ | -------- |
| `-i`   | This is the default if no other switch is passed and will remove only the main installation directory and product information. This behavior is preferable if you intend to reinstall the same version after you run the `InstallCleanup.exe` tool. |
| `-f`   | This will remove the main installation directory, product information, and most other features installed outside the installation directory that may be shared with other Visual Studio installations or other products. This behavior is preferable if you intend to remove Visual Studio without reinstalling later. |

1. Close the Visual Studio Installer.
2. Open an administrator command prompt. To do this, follow these steps:
   * On the **Start** menu, click **Run** (Start + R).
   * Type **cmd**.
   * Right-click **Command Prompt**, and then click **Run as administrator**.
3. Type the full path of the `InstallCleanup.exe` utility and pass whichever command line switch you desire. By default, the path of the utility is as follows:
   ```
   C:\Program Files (x86)\Microsoft Visual Studio\Installer\resources\app\layout\InstallCleanup.exe
   ```

If you do not find `InstallCleanup.exe` under the Visual Studio Installer directory - always located at `%ProgramFiles(x86)%\Microsoft Visual Studio` - please follow the instructions to [install Visual Studio](install-visual-studio.md) and when the workload selection screen is displayed, close the window and follow the steps above again.

## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Update Visual Studio 2017](update-visual-studio.md)
* [Modify Visual Studio 2017](modify-visual-studio.md)
* [Uninstall Visual Studio 2017](uninstall-visual-studio.md)
* [How to Report a Problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
