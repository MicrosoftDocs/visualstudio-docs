---
title: "How to: Manage Build Configurations with Visual Basic Developer Settings Applied | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, building with Visual Basic settings"
  - "MSBuild, debug build"
  - "advanced build configurations"
  - "building with Visual Basic developer settings"
  - "debug builds"
  - "MSBuild, release build"
  - "release builds"
ms.assetid: eaea6e0b-6c61-4869-8d63-d372c745a23c
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Manage Build Configurations with Visual Basic Developer Settings Applied
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, all advanced build configuration options are hidden with [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] Developer settings applied. This topic explains how to manually enable these settings.

## Enabling advanced build configurations
 By default, the [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] Developer settings hide the option to open the **Configuration Manager** dialog box and the **Configuration** and **Platform** lists in the [Project Designer](https://msdn.microsoft.com/898dd854-c98d-430c-ba1b-a913ce3c73d7).

#### To enable advanced build configurations

1. On the **Tools** menu, click **Options**.

2. Expand **Projects and Solutions**, and click **General**.

    > [!NOTE]
    > The **General** node is visible even if the **Show all settings** option is unchecked. If you want to see every option available, click **Show all settings**.

3. Click **Show advanced build configurations**.

4. Click **OK**.

     On the **Build** menu, **Configuration Manager** is now available, and the **Configuration** and **Platform** lists are visible in the Project Designer.

## See Also
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
