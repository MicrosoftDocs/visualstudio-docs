---
title: "How to: Debug .NET Framework source | Microsoft Docs"
ms.custom: ""
ms.date: "11/19/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "debugging, .NET Framework source"
ms.assetid: fc12e472-ac6a-4e77-8e22-a769e13a03b8
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "dotnet"
---
# How to: Debug .NET Framework source

To debug .NET Framework source, you must:

- Enable stepping into .NET Framework source.  
  
- Have access to debugging symbols for the code. 
  
  When you enable symbol downloading, you can choose to download symbols immediately, or just enable the option for later downloading. If you do not download the symbols immediately, they will download the next time you start debugging your app. While debugging, you can also download symbols from the **Modules** or **Call Stack** windows.  
  
### To enable stepping into .NET Framework source 
  
1. Under **Tools** (or **Debug**) > **Options** > **Debugging** > **General**, select **Enable .NET Framework source stepping**.  
   
   - If you had Just My Code enabled, a warning dialog box tells you that Just My Code is now disabled. Select **OK**.  
   
   - If you did not have a symbol cache location set, a warning dialog box tells you that a default symbol cache location has been set. Select **OK**.  
   
1. Select **OK** to close the **Options** dialog.
  
### To set or change symbol source locations and loading behavior

1. Select the **Symbols** category under **Tools** (or **Debug**) > **Options** > **Debugging**.  
  
1. On the *Symbols** page, under **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers** to access symbols from the public Microsoft Symbol Servers. Select the toolbar buttons to add other symbol locations and change the loading order. 
   
1. To change your local symbols cache location, edit or browse to a different location under **Cache symbols in this directory**.  
   
1. To download symbols immediately, select **Load all symbols**. This button is available only while debugging.  
   
   If you do not download symbols now, they will be downloaded the next time you start debugging.  
   
1. Select **OK** to close the **Options** dialog.  
  
### To load .NET Framework symbols from the Modules window  
  
1. During debugging, you can open the **Modules** window from **Debug** > **Windows** > **Modules**. 
   
1. In the **Modules** window, right-click a module for which symbols were not loaded, according to the **Symbols Status** column.  
   
   - Select **Load Symbols** from the menu to try to locate and load symbol files from a folder on your machine. 
   
   - Select **Symbol Load Information** to show the locations the debugger searched for symbols.  
   
   - Select **Symbol Settings** to open the **Symbols** page. On the *Symbols** page, under **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers** to access symbols from the public Microsoft Symbol Servers. Select the toolbar buttons to add other symbol locations and change the loading order.  
  
### To load .NET Framework symbols from the Call Stack window  
  
1. During debugging, you can open the **Call Stack** window from **Debug** > **Windows** > **Call Stack**. 
   
1.  In the **Call Stack** window, right-click a frame for which symbols are not loaded. The frame will be grayed-out.  
  
1. In the **Modules** window, right-click a module for which symbols were not loaded, according to the **Symbols Status** column.  
   
   - Select **Load Symbols** from the menu to try to locate and load symbol files from a folder on your machine. 
   
   - Select **Symbol Load Information** to show the locations the debugger searched for symbols.  
   
   - Select **Symbol Settings** to open the **Symbols** page. On the *Symbols** page, under **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers** to access symbols from the public Microsoft Symbol Servers. Select the toolbar buttons to add other symbol locations and change the loading order.  
  
### See also  
 [Debugging managed code](../debugger/debugging-managed-code.md)   
 [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)