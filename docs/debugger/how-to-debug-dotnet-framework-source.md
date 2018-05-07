---
title: "How to: Debug .NET Framework Source | Microsoft Docs"
ms.custom: ""
ms.date: "02/23/2018"
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
# How to: Debug .NET Framework Source
To debug .NET Framework source, you must have access to debugging symbols for the code. You also need to enable stepping into .NET Framework source.  
  
 You can enable .NET Framework stepping and symbol downloading in the **Options** dialog box. When you enable symbol downloading, you can choose to download symbols immediately or just enable the option for later downloading. If you do not download the symbols immediately, symbols will be downloaded the next time that you start debugging your application. You also can do a manual download from the **Modules** window or the **Call Stack** window.  
  
### To enable .NET Framework source debugging  
  
1.  On the **Tools** menu, click **Option**s.  
  
2.  In the **Options** dialog box, click the **Debugging** category.  
  
3.  In the **General** box, set **Enable .NET Framework source stepping.**  
  
    1.  If you had Just My Code enabled, a warning dialog box tells you that Just My Code is now disabled. Click **OK**.  
  
    2.  If you did not have a symbol cache location set, another warning dialog box tells you that a default symbol cache location is now set. Click **OK**.  
  
4.  Under the **Debugging** category, click **Symbols**.  
  
5.  If you want to change the symbols cache location, edit the location in **Cache symbols in this directory** or click **Browse** to choose a location.  
  
6.  If you want to download symbols immediately, click **Load Symbols using above locations**.  
  
     This button is not available in design mode, but is available while debugging.  
  
     If you do not choose to download symbols now, symbols will be downloaded automatically the next time that you start the debugging your program.  
  
7.  Click **OK** to close the **Options** dialog box.  
  
### To load Framework symbols using the Modules window  
  
1.  In the **Modules** window (while debugging, choose **Debug** > **Windows** > **Modules**), right-click a module for which symbols are not loaded. You can tell if symbols are loaded or not by looking at the **Symbols Status** column.  
  
2.  Point to **Symbol Settings** and click **Microsoft Symbol Servers** to download symbols from the Microsoft public symbols server. Or, you can right-click the module and choose **Load Symbols** to load from a directory where you have previously stored symbols.  
  
### To load Framework symbols using the Call Stack window  
  
1.  In the **Call Stack** window, right-click a frame for which symbols are not loaded. The frame will be dimmed out.  
  
2.  Point to **Symbol Settings** and click **Microsoft Symbol Servers**, or right-click the module and choose **Symbol Path**.  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)