---
title: Uninstall Visual Studio
titleSuffix: ''
description: Learn how to uninstall Visual Studio, step-by-step.
ms.date: 10/12/2020
ms.custom: vs-acquisition
ms.topic: how-to
f1_keywords:
- uninstall
- uninstall Visual Studio
ms.assetid: 0e445255-b796-426d-ad93-a4d8e36da2c5
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Uninstall Visual Studio

This page walks you through uninstalling Visual Studio, our integrated suite of productivity tools for developers.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Uninstall Visual Studio for Mac](/visualstudio/mac/uninstall).

> [!TIP]
> If you're having trouble with your instance of Visual Studio, try the **Repair** tool. For more information, see [Repair Visual Studio](../install/repair-visual-studio.md). 
>
> If you want to change the location for some of your Visual Studio files, it's possible to do so without uninstalling your current instance. For more information, see [Select the installation locations in Visual Studio](../install/change-installation-locations.md).
>
> For general troubleshooting tips, see [Troubleshoot Visual Studio installation and upgrade issues](../install/troubleshooting-installation-issues.md).

::: moniker range="vs-2017"

1. Find the Visual Studio Installer on your computer.

     For example, on a computer running Windows 10 Anniversary Update or later, select **Start** and scroll to the letter **V**, where it's listed as **Visual Studio Installer**.

     ![Visual Studio Installer](media/locate-the-visual-studio-installer.png "Locate the Microsoft Visual Studio Installer")

   > [!NOTE]
   > On some computers, the Visual Studio Installer might be listed under the letter **"M"** as the **Microsoft Visual Studio Installer**.<br/><br/> Alternatively, you can find the Visual Studio Installer in the following location: `C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

1. In the installer, look for the edition of Visual Studio that you installed. Next, choose **More**, and then choose **Uninstall**.

     ![Uninstall Visual Studio 2017](media/uninstall-visual-studio.png "Uninstall Visual Studio 2017")

1. Click **OK** to confirm your choice.

If you change your mind later and want to reinstall Visual Studio 2017, start the Visual Studio Installer again, and then select **Install** from the selection screen.

## Uninstall Visual Studio Installer

To completely remove all installations of Visual Studio 2017 and the Visual Studio Installer from your machine, uninstall it from Apps & Features.

1. In Windows 10 or later, type **Apps and Features** in the "Type here to search" box.
1. Find **Microsoft Visual Studio 2017** (or, **Visual Studio 2017**).
1. Choose **Uninstall**.
1. Then, find **Microsoft Visual Studio Installer**.
1. Choose **Uninstall**.

::: moniker-end

::: moniker range="vs-2019"

1. Find the **Visual Studio Installer** on your computer.

     In the Windows Start menu, you can search for "installer".

     ![Visual Studio Installer](media/vs-2019/visual-studio-installer.png "Search for the Visual Studio Installer")

     > [!NOTE]
     > You can also find the Visual Studio Installer in the following location:
     >
     > `C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

    You might have to update the installer before continuing. If so, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed. Next, choose **More**, and then choose **Uninstall**.

     ![Uninstall Visual Studio 2019](media/vs-2019/vs-installer-uninstall.png "Uninstall Visual Studio 2019")

1. Click **OK** to confirm your choice.

     ![Uninstall Visual Studio confirmation](media/vs-2019/uninstall-visualstudio-confirm.png "Confirm that you want to uninstall Visual Studio 2019")

If you change your mind later and want to reinstall Visual Studio 2019, start the Visual Studio Installer again, choose the **Available** tab,  choose the edition of Visual Studio that you want to install, and then select **Install**.

## Uninstall Visual Studio Installer

To remove all installations of Visual Studio 2019, and the Visual Studio Installer from your machine, uninstall it from Apps & Features.

1. In Windows 10 or later, type **Apps and Features** in the "Type here to search" box.
1. Find **Visual Studio 2019**.
1. Choose **Uninstall**.
1. Then, find **Microsoft Visual Studio Installer**.
1. Choose **Uninstall**.

::: moniker-end

::: moniker range=">=vs-2022"

1. Find the **Visual Studio Installer** on your computer.

     In the Windows Start menu, you can search for "installer".

     ![Visual Studio Installer](media/vs-2019/visual-studio-installer.png "Search for the Visual Studio Installer")

     > [!NOTE]
     > You can also find the Visual Studio Installer in the following location:
     >
     > `C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe`

    You might have to update the installer before continuing. If so, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed. Next, choose **More**, and then choose **Uninstall**.

     ![Uninstall Visual Studio 2019](media/vs-2022/vs-installer-uninstall.png "Uninstall Visual Studio 2019")

1. Click **OK** to confirm your choice.

     ![Uninstall Visual Studio confirmation](media/vs-2022/uninstall-visualstudio-confirm.png "Confirm that you want to uninstall Visual Studio 2019")

If you change your mind later and want to reinstall 2022, start the Visual Studio Installer again, choose the **Available** tab,  choose the edition of Visual Studio that you want to install, and then select **Install**.

## Uninstall Visual Studio Installer

To remove all installations of Visual Studio 2022, and the Visual Studio Installer from your machine, uninstall it from Apps & Features.

1. In Windows 10 or later, type **Apps and Features** in the "Type here to search" box.
1. Find **Visual Studio 2022**.
1. Choose **Uninstall**.
1. Then, find **Microsoft Visual Studio Installer**.
1. Choose **Uninstall**.

::: moniker-end

## Remove all files

If you experience a catastrophic error and can't uninstall Visual Studio by using the previous instructions, there is a "last resort" option that you can consider using instead. For more information about how to remove all Visual Studio installation files and product information completely, see the [Remove Visual Studio](remove-visual-studio.md) page.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Modify Visual Studio](modify-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
