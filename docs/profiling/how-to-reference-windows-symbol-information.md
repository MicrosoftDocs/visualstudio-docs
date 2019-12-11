---
title: "How to: Reference Windows Symbol Information | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "performance tools, symbol servers"
  - "servers, symbol servers"
  - "profiling tools, symbol servers"
  - "symbol servers"
ms.assetid: b7c67318-6be2-4b1e-a161-077b1f4a7c30
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Reference Windows symbol information
The Visual Studio Profiling Tools use symbol (.*pdb*) files to resolve symbolic names such as function names in program binaries. You can follow these steps to automatically download and update the correct .*pdb* files for the version of Windows on the local computer.

> [!NOTE]
> This setting does not affect existing reports. Only reports created after specifying the symbol server will have the symbol information.

 For more information, see [Specify symbol (.*pdb*) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

### To use the Microsoft symbol server

1. Create a folder to contain the symbol file information, such as C:\SymbolCache.

2. On the **Tools** menu, click **Options**.

     The **Options** dialog box appears.

3. Expand the **Debugging** tree, and then click **Symbols**.

4. In the **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers**

5. In the **Cache symbols from the symbol server to this directory**, type the path of the folder that was created in step 1, for example:

     **C:\SymbolCache**

     You can also click the ellipsis button (**...**) and then select a directory from the **Browse for Folder** dialog box.

## See also
- [Configure performance sessions](../profiling/configuring-performance-sessions.md)
- [How to: Serialize symbol information](../profiling/how-to-serialize-symbol-information.md)
