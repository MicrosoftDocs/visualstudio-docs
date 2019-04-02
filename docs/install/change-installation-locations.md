---
title: "Select installation locations"
description: "Learn how to reduce the installation footprint of Visual Studio on your system drive by changing the location of the download cache, shared components, SDKs, and tools to different drives. For example, move some files from the C drive to the D drive."
ms.date: 03/30/2019
ms.custom: "seodec18"
ms.topic: conceptual
helpviewer_keywords:
  - "change installation locations for Visual Studio"
  - "select an installation location for Visual Studio files"
  - "move installation files to different drives"
  - "use the D drive"
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Select the installation locations in Visual Studio

::: moniker range="vs-2019"

You can reduce the installation footprint of Visual Studio on your system drive by changing the location for some of its files. Specifically, you can use a different location for the download cache, shared components, SDKs, and tools files.

::: moniker-end

::: moniker range="vs-2017"

**New in version 15.7**: You can reduce the installation footprint of Visual Studio on your system drive by changing the location for some of its files. Specifically, you can use a different location for the download cache, shared components, SDKs, and tools files.

::: moniker-end

   > [!NOTE]
   > There are some tools and SDKs that have different rules on where they can be installed. Such tools and SDKs are installed on your system drive even if you choose another location.

Ready to get started? Here's how.

::: moniker range="vs-2017"

1. When you install Visual Studio, choose the **Installation locations** tab.

   ![Visual Studio 2017 - Select the installation location](media/vs-installation-locations.png "Select the installation location.")

1. In the **Visual Studio IDE** section, accept the default. Visual Studio installs the core product and includes files that are specific to this version of Visual Studio.

   ![Visual Studio IDE section of the Installation Locations tab](media/vs-installation-locations-ide.png "Accept the default for the Visual Studio IDE section of the Installations Location tab.")

   > [!TIP]
   > If your system drive is a solid-state drive (SSD), we recommend that you accept the default location on your system drive. The reason? When you develop with Visual Studio, you read from and write to a lot of files, which increases the disk I/O activity. It's best to choose your fastest drive to handle the load.

1. In the **Download cache** section, decide if you want to keep the download cache, and then decide where you want to store its files.

     ![Download Cache section of the Installation Locations tab](media/vs-installation-locations-cache.png "Choose whether to keep the download cache after installation, and then specify the drive where you want to store files.")

    1. Check or uncheck **Keep download cache after the installation**.

       If you decide not to keep the download cache, the location is used only temporarily. This action won't affect or delete files from previous installations.

    1. Specify the drive where you want to store installation files and manifests from the download cache.

        For example, if you select the "Desktop development with C++" workload, the temporarily required size is 1.58 GB on your system drive, which is then freed as soon as the installation completes.

       > [!IMPORTANT]
       > This location is set with your first installation and cannot be changed later from the installer UI. Instead, you must [use command-line parameters](use-command-line-parameters-to-install-visual-studio.md) to move the download cache.

1. In the **Shared components, tools, and SDKs** section, specify the drive where you want to store the files that are shared by side-by-side Visual Studio installations. SDKs and tools are also stored in this directory.

   ![Shared Components, Tools, And SDKs section of the Installation Locations tab](media/vs-installation-locations-shared.png "Specify the location where you want to store shared components, tools, and SDKs.")

::: moniker-end

::: moniker range="vs-2019"

1. When you install Visual Studio, choose the **Installation locations** tab.

   ![Visual Studio 2019 - Select the installation location](media/vs-2019/vs-installer-installation-locations.png "Select the installation location.")

1. In the **Visual Studio IDE** section, accept the default. Visual Studio installs the core product and includes files that are specific to this version of Visual Studio.

   > [!TIP]
   > If your system drive is a solid-state drive (SSD), we recommend that you accept the default location on your system drive. The reason? When you develop with Visual Studio, you read from and write to a lot of files, which increases the disk I/O activity. It's best to choose your fastest drive to handle the load.

1. In the **Download cache** section, decide if you want to keep the download cache, and then decide where you want to store its files.

    * Check or uncheck **Keep download cache after the installation**.

       If you decide not to keep the download cache, the location is used only temporarily. This action won't affect or delete files from previous installations.

    * Specify the drive where you want to store installation files and manifests from the download cache.

        For example, if you select the "Desktop development with C++" workload, the temporarily required size is 1.58 GB on your system drive, which is then freed as soon as the installation completes.

       > [!IMPORTANT]
       > This location is set with your first installation and cannot be changed later from the installer UI. Instead, you must [use command-line parameters](use-command-line-parameters-to-install-visual-studio.md) to move the download cache.

1. In the **Shared components, tools, and SDKs** section, note that it uses the same drive that you chose in the "Download cache" section. The \Microsoft\VisualStudio\Shared directory is where Visual Studio stores the files that are shared by side-by-side Visual Studio installations. SDKs and tools are also stored in this directory.

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Modify Visual Studio](update-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
