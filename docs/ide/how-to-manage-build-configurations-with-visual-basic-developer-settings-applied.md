---
title: Manage build configurations with Visual Basic developer settings
description: Learn about advanced build configuration options that are hidden when Visual Basic developer settings are applied and how to manually enable these build settings.
titleSuffix: ""
ms.date: 11/21/2018
ms.technology: vs-ide-compile
ms.topic: how-to
helpviewer_keywords:
- advanced build configurations
- building with Visual Basic developer settings (Visual Studio)
- debug builds
- release builds
ms.assetid: eaea6e0b-6c61-4869-8d63-d372c745a23c
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- multiple
---
# How to: Manage build configurations with Visual Basic developer settings applied

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

By default, all advanced build configuration options are hidden when Visual Basic developer settings are applied. This article explains how to manually enable these build settings.

## Enable advanced build configurations

By default, the Visual Basic developer settings hide the option to open the **Configuration Manager** dialog box and the **Configuration** and **Platform** lists in the [Project Designer](../ide/reference/application-page-project-designer-visual-basic.md).

1. On the **Tools** menu, click **Options**.

2. Expand **Projects and Solutions**, and click **General**.

3. Click **Show advanced build configurations**.

4. Click **OK**.

     **Configuration Manager** is now available on the **Build** menu, and the **Configuration** and **Platform** lists are visible in the **Project Designer**.

## See also

- [Understand build configurations](../ide/understanding-build-configurations.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [Environment settings](../ide/environment-settings.md)
