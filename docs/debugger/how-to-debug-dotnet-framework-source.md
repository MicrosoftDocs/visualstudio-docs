---
title: "How to: Debug .NET Framework source | Microsoft Docs"
ms.date: "11/19/2018"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging, .NET Framework source"
ms.assetid: fc12e472-ac6a-4e77-8e22-a769e13a03b8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Debug .NET Framework source

To debug .NET Framework source, you must:

- Enable stepping into .NET Framework source.

- Have access to debugging symbols for the code.

  You can choose to download debugging symbols immediately, or set options for later downloading. If you don't download symbols immediately, they'll download the next time you start debugging your app. While debugging, you can also use the **Modules** or **Call Stack** windows to download and load symbols.

### To enable stepping into .NET Framework source

1. Under **Tools** (or **Debug**) > **Options** > **Debugging** > **General**, select **Enable .NET Framework source stepping**.

   - If you had Just My Code enabled, a warning dialog box tells you that Just My Code is now disabled. Select **OK**.

   - If you did not have a local symbol cache set, a warning dialog box tells you that a default symbol cache has been set. Select **OK**.

1. Select **OK** to close the **Options** dialog.

### To set or change symbol source locations and loading behavior

1. Select the **Symbols** category under **Tools** (or **Debug**) > **Options** > **Debugging**.

1. On the **Symbols** page, under **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers** to access symbols from the public Microsoft Symbol Servers. Select the toolbar buttons to add other symbol locations and change the loading order.

1. To change your local symbols cache, edit or browse to a different location under **Cache symbols in this directory**.

1. To download symbols immediately, select **Load all symbols**. This button is available only while debugging.

   If you don't download symbols now, they'll be downloaded the next time you start debugging.

1. Select **OK** to close the **Options** dialog.

### To load symbols from the Modules or Call Stack windows

1. During debugging, open the window by selecting **Debug** > **Windows** > **Modules** (or press **Ctrl + Alt + U**) or **Debug** > **Windows** > **Call Stack** (**Ctrl + Alt + C**).

1. Right-click a module for which symbols weren't loaded. In the **Modules** window, symbol loading status is in the **Symbols Status** column. In the **Call Stack** window, status is in the **Frame Status** column, and the frame is grayed-out.

   - Select **Load Symbols** from the menu to locate and load symbol files from a folder on your machine.

   - Select **Symbol Load Information** to show the locations the debugger searched for symbols.

   - Select **Symbol Settings** to open the **Symbols** page. On the **Symbols** page, under **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers** to access symbols from the public Microsoft Symbol Servers. Select the toolbar buttons to add other symbol locations and change the loading order. Select **OK** to close the dialog.

### See also
- [Debugging managed code](../debugger/debugging-managed-code.md)
- [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)