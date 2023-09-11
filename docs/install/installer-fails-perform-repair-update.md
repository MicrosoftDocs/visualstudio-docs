---
title: Installer fails to perform repair or update
titleSuffix: ''
description: Learn how to repair or update Visual Studio.
ms.date: 09/08/2023
ms.custom: vs-acquisition
ms.topic:
f1_keywords:
- repair or update
- repair or update Visual Studio
author:
ms.author:
ms.reviewer: khgupta, raviuppa, aartigoyle, v-sidong
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Installer fails to perform repair or update

_Applies to:_ &nbsp; Visual Studio 2022

## Symptoms

You may see the following error when you try to repair or update Visual Studio:

```output
A product matching the following parameters cannot be found:channelId: VisualStudio.17.Release

productId: Microsoft.VisualStudio.Product.Enterprise
```

## Cause

This issue can occur if the Visual Studio instance on the machine is corrupt.

## Solution

If you've been unsuccessful in your previous attempts to repair or update Visual Studio, you can run the [InstallCleanup.exe](uninstall-visual-studio.md#remove-all-with-installcleanupexe) tool to remove installation files and product information for all installed instances of Visual Studio, and then reinstall Visual Studio 2022. This process ensures a fresh installation of Visual Studio, which should allow for successful repairs or updates.

To solve this issue, follow these steps: 

1. Open a command prompt with administrator privileges.
1. Run the following command to execute the [InstallCleanup](uninstall-visual-studio.md#remove-all-with-installcleanupexe) tool:

   `"C:\Program Files (x86)\Microsoft Visual Studio\Installer\InstallCleanup.exe" -f`

   > [!NOTE]
   > The `-f` option removes the main installation directory, product information, and most other features installed outside the installation directory, that might also be shared with other Visual Studio installations or other products.
 
   This command will perform a cleanup of the Visual Studio installation, removing any corrupted or incomplete components.

1. Once the cleanup process is completed, reinstall Visual Studio 2022. You can download the Visual Studio 2022 installer from the Visual Studio download page.
1. Launch the Visual Studio 2022 installer and follow the prompts to reinstall Visual Studio. Make sure to select the desired workloads and components during the installation.

## More information

- [Update Visual Studio](/visualstudio/install/update-visual-studio)
- [Repair Visual Studio](/visualstudio/install/repair-visual-studio)
- [Troubleshoot installation and upgrade issues](/troubleshoot/developer/visualstudio/installation/troubleshoot-installation-issues)