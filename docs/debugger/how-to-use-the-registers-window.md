---
title: "View register values in the debugger | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/19/2018"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.registers"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "registers, debugging"
  - "register contents"
  - "flags, Registers window"
  - "register groups"
  - "debugging [Visual Studio], Registers window"
  - "Registers window"
ms.assetid: 2918ffa2-562f-40d6-9053-ef321bbeb767
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# View register values in the Registers window (C#, C++, Visual Basic, F#)

The **Registers** window displays register contents during Visual Studio debugging. For a high-level introduction to concepts behind registers and the **Registers** window, see [Debugging basics: Registers window](../debugger/debugging-basics-registers-window.md).

> [!NOTE]
> Register information is not available for script or SQL apps.

During debugging, register values change as code executes in your app. Values that have changed recently appear in red in the **Registers** window.

To reduce clutter, the **Registers** window organizes registers into groups, which vary according to platform and processor type. You can display or hide register groups. For more information, see [How to: Display and hide register groups](../debugger/how-to-display-and-hide-register-groups.md).

For info on the flags you see in the **Registers** window, see [About the Registers window](../debugger/debugging-basics-registers-window.md)

You can edit register values. For more information, see [How to: Edit a register value](../debugger/how-to-edit-a-register-value.md).

**To open the Registers window**

1. Enable address-level debugging, by selecting **Enable address-level debugging** in **Tools** (or **Debug**) > **Options** > **Debugging**.

1. While debugging is running or at a breakpoint, select **Debug** > **Windows** > **Registers**, or press **Alt**+**5**.

>[!NOTE]
>Dialog boxes and menu commands might differ depending on your Visual Studio edition or settings. To change your settings, select **Import and Export Settings** on the Visual Studio **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

### See also

- [Debugging basics: Registers window](../debugger/debugging-basics-registers-window.md)
- [Viewing data in the debugger](../debugger/viewing-data-in-the-debugger.md)
