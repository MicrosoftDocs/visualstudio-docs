---
title: Display and Hide Register Groups | Microsoft Docs
description: The Registers window, which is available if address-level debugging is enabled, organizes registers into groups. Learn how to set which groups appear.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.registergroups
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - Registers window, displaying and hiding register groups
  - register groups, displaying and hiding
ms.assetid: 6be5dfb4-4cfe-4daf-b538-60405640857d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Display and Hide Register Groups (C#, C++, Visual Basic, F#)

The **Registers** window is available only if address-level debugging is enabled in the **Options** dialog box, **Debugging** node, **General** category.

To reduce clutter, the **Registers** window organizes registers into groups. If you right-click the **Registers** window, you will see a shortcut menu containing these groups, which you can display or hide as you see fit following the procedure below.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## Display or hide register groups

1. Right-click the **Registers** window.

2. On the shortcut menu, select the register groups you want to show or hide.

     Register groups that are not supported by the hardware you are debugging on are disabled on the shortcut menu, so they cannot be selected.

## See also

- [How to: Use the Registers Window](../debugger/how-to-use-the-registers-window.md)