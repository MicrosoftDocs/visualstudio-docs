---
title: View DLLs and executables in Visual Studio
description: View DLLs and executables (.exe files) that your app uses in the Modules window during a debugging session in Visual Studio.
titleSuffix: Visual Studio Modules window
ms.date: 04/16/2025
ms.topic: how-to
f1_keywords: 
  - vs.debug.modules
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - debugger, Modules window
  - Modules window
  - executable files, displaying while debugging
  - debugging [Visual Studio], displaying modules
  - DLLs, displaying while debugging
  - modules, displaying
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# View DLLs and executables in the Modules window (C#, C++, Visual Basic, F#)

During Visual Studio debugging, the **Modules** window lists and shows information about the DLLs and executables (*.exe* files) your app uses.

> [!NOTE]
> The Modules window is not available for SQL or script debugging.

## View modules

To open the Modules window, while you're debugging, select **Debug** > **Windows** > **Modules** (or press **Ctrl + Alt + U**).

By default, the **Modules** window sorts modules by load order. To sort by any window column, select the header at the top of the column.

## Load symbols

The **Symbol Status** column in the **Modules** window shows which modules have debugging symbols loaded. If the status is **Skipped loading symbols**, **Cannot find or open the PDB file**, or **Loading disabled by include/exclude setting**, you can load symbols manually.

- For more information about loading and using symbols, see [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

**To load symbols manually:**

1. In the **Modules** window, right-click the module for which symbols haven't loaded.

   - Select **Symbol Load Information** for details about why the symbols didn't load.

   - Select **Load Symbols** to load the symbols manually.

   - For .NET code, you can choose **Decompile Source to Symbol File** and then follow instructions in [Generate and embed sources for an assembly](../debugger/decompilation.md#generate-and-embed-sources-for-an-assembly).
   
     ::: moniker range=">=vs-2022"
     Starting in Visual Studio 2022 version 17.7, you can also autodecompile .NET code. For more information, see [Autodecompile code](../debugger/decompilation.md#autodecompile-code).
     ::: moniker-end

1. If the symbols don't load, select **Symbol Settings** to open the **Options** dialog, and specify or change symbol loading locations.

   You can download symbols from the public Microsoft Symbol Servers or other servers, or load symbols from a folder on your computer. For details, see [Configure location of symbol files and loading behavior](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md#configure-location-of-symbol-files-and-loading-options).

**To change symbol loading behavior settings:**

1. In the **Modules** window, right-click any module.

1. Select **Symbol Settings**.

1. Select **Load all symbols**, or select which modules to include or exclude.

1. Select **OK**. Changes take effect in the next debugging session.

**To change symbol loading behavior for a specific module:**

1. In the **Modules** window, right-click the module.

1. In the right-click menu, select or deselect **Always Load Automatically**. Changes take effect in the next debugging session.

## Related content
- [Breaking execution](/previous-versions/visualstudio/visual-studio-2010/7z9se2d8(v=vs.100))
- [Viewing data in the debugger](../debugger/viewing-data-in-the-debugger.md)
- [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)