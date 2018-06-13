---
title: "How to: Manage build configurations with Visual Basic developer settings applied"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-compile
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
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Manage build configurations with Visual Basic developer settings applied

By default, all advanced build configuration options are hidden with Visual Basic developer settings applied. This topic explains how to manually enable these settings.

## Enable advanced build configurations

By default, the Visual Basic developer settings hide the option to open the **Configuration Manager** dialog box and the **Configuration** and **Platform** lists in the [Project Designer](..//ide/reference/application-page-project-designer-visual-basic.md).

1.  On the **Tools** menu, click **Options**.

2.  Expand **Projects and Solutions**, and click **General**.

    > [!NOTE]
    > The **General** node is visible even if the **Show all settings** option is unchecked. If you want to see every option available, click **Show all settings**.

3.  Click **Show advanced build configurations**.

4.  Click **OK**.

     On the **Build** menu, **Configuration Manager** is now available, and the **Configuration** and **Platform** lists are visible in the **Project Designer**.

## See also

- [Understand build configurations](../ide/understanding-build-configurations.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)