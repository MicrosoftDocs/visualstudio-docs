---
title: "Repair Visual Studio"
titleSuffix: ""
description: "Learn how to repair an installation of Visual Studio 2017"
ms.date: 07/31/2019
ms.custom: "seodec18"
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---

# Repair Visual Studio

::: moniker range="vs-2017"

Sometimes your Visual Studio installation becomes damaged or corrupted. A repair can fix this.

1. Find the **Visual Studio Installer** on your computer.

     For example, on a computer running Windows 10 Anniversary Update or later, select **Start**, and then scroll to the letter **V**, where it's listed as **Visual Studio Installer**.

   > [!NOTE]
   > On some computers, the Visual Studio Installer might be listed under the letter **"M"** as the **Microsoft Visual Studio Installer**.
   >
   > Alternatively, you can find the Visual Studio Installer in the following location:
   >`C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

1. Open the installer, choose **More**, and then choose **Repair**.

    ![Repair Visual Studio from the Visual Studio Installer](media/repair-visual-studio.png "Repair Visual Studio from the Visual Studio Installer")

   > [!NOTE]
   > Repairing Visual Studio will reset the environment. Local customizations like per-user extensions installed without elevation, user settings, and profiles will be removed. Your synchronized settings such as themes, colors, key bindings will be restored.
   >

   > [!TIP]
   > The **Repair** option appears only for installed instances of Visual Studio. If you do not see the **Repair** option, chances are that you've selected **More** in a version that's listed in the Visual Studio Installer as "Available" rather than "Installed".

::: moniker-end

::: moniker range="vs-2019"

1. Find the Visual Studio Installer on your computer.

     For example, on a computer running Windows 10, select **Start**, and then scroll to the letter **V**, where it's listed as **Visual Studio Installer**.

     ![Open the Visual Studio Installer](media/vs-2019/vs-installer-windows-start.png "Open the Visual Studio Installer")

     > [!NOTE]
     > You can also find the Visual Studio Installer in the following location:
     >
     > `C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

    You might have to update the installer before continuing. If so, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed. Next, choose **More**, and then choose **Repair**.

     ![Repair Visual Studio 2019](media/vs-2019/vs-installer-repair.png "Repair Visual Studio 2019")

   > [!NOTE]
   > Repairing Visual Studio will reset the environment. Local customizations like per-user extensions installed without elevation, user settings, and profiles will be removed. Your synchronized settings such as themes, colors, key bindings will be restored.
   >

   > [!TIP]
   > The **Repair** option appears only for installed instances of Visual Studio. If you do not see the **Repair** option, chances are that you've selected **More** in a version that's listed in the Visual Studio Installer as "Available" rather than "Installed".

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
* [Troubleshooting Visual Studio installation and upgrade issues](troubleshooting-installation-issues.md)
