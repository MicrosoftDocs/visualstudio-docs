---
title: Debug .NET Framework source
description: Debug .NET Framework source by enabling stepping into .NET Framework source code and allowing access to debugging symbols for the code.
ms.date: 10/30/2025
ms.topic: how-to
helpviewer_keywords: 
  - debugging, .NET Framework source
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug .NET Framework source

To debug .NET Framework source, you must:

- Enable stepping into .NET Framework source.

- Have access to debugging symbols for the code.

  You can choose to download debugging symbols immediately, or set options for later downloading. If you don't download symbols immediately, they'll download the next time you start debugging your app. While debugging, you can also use the **Modules** or **Call Stack** windows to download and load symbols.

## Enable stepping into .NET Framework source

:::moniker range="visualstudio"

1. Open the **Tools** (or **Debug**) > **Options** pane and expand the **All Settings** > **Debugging** > **General** section.

1. Configure the following options:

   - Clear the **Enable Just My Code** checkbox.
   - Select the **Enable Source Link support** checkbox.

1. Expand the **Debugging** > **Symbols** > **Search Locations** section.

1. Select the **Download symbols from the Microsoft Symbol Servers** checkbox.

:::moniker-end
:::moniker range="vs-2022"
      
1. Open the **Tools** (or **Debug**) > **Options** dialog and expand the **Debugging** > **General** section.

1. Configure the following general options:

   - Clear the **Enable Just My Code** checkbox.
   - Select the **Enable Source Link support** checkbox.

1. Expand the **Debugging** > **Symbols** section.

1. In the **Symbol file (.pdb) search locations** group, select the **Microsoft Symbol Servers** checkbox.

1. Select **OK**.

::: moniker-end
::: moniker range="vs-2019"

1. Under **Tools** (or **Debug**) > **Options** > **Debugging** > **General**, select **Enable .NET Framework source stepping**.

   - If you had Just My Code enabled, a warning dialog box tells you that Just My Code is now disabled. Select **OK**.

   - If you didn't have a local symbol cache set, a warning dialog tells you a default symbol cache is set. Select **OK**.

1. Select **OK** to close the **Options** dialog.

::: moniker-end

## Set or change symbol source locations and loading behavior

:::moniker range="visualstudio"

1. Open the **Tools** (or **Debug**) > **Options** pane and expand the **All Settings** > **Debugging** > **Symbols** > **Search Locations** section.

2. Select the **Download symbols from the Microsoft Symbol Servers** checkbox.

:::moniker-end
:::moniker range="<=vs-2022"

1. Open the **Tools** (or **Debug**) > **Options** dialog and expand the **Debugging** > **Symbols** section.

2. In the **Symbol file (.pdb) search locations** group, select the **Microsoft Symbol Servers** checkbox. This option accesses symbols from the public Microsoft Symbol Server.

:::moniker-end

3. To add other symbol locations, select **Add** and update existing locations by selecting **Edit**. Change the loading order of the locations with **Move up** and **Move down**.

4. To change your local symbols cache, edit or browse to a different location by selecting **More actions** (**...**) for the **Cache symbols in this directory** option.

5. To download symbols immediately, select **Load all symbols**. This button is available only while debugging.

   If you don't download symbols now, the download happens the next time you start debugging.

:::moniker range="<=vs-2022"

6. Select **OK**.

::: moniker-end

## Load symbols from the Modules or Call Stack windows

1. During debugging, open the window by selecting **Debug** > **Windows** > **Modules** (or press **Ctrl + Alt + U**) or **Debug** > **Windows** > **Call Stack** (**Ctrl + Alt + C**).

1. Right-click a module for which symbols weren't loaded. In the **Modules** window, symbol loading status is in the **Symbols Status** column. In the **Call Stack** window, status is in the **Frame Status** column, and the frame is grayed-out.

   - Select **Load Symbols** from the menu to locate and load symbol files from a folder on your machine.

   - Select **Symbol Load Information** to show the locations the debugger searched for symbols.

   :::moniker range="visualstudio"

   - Select **Symbol Settings**, which opens the **Tools** (or **Debug**) > **Options** pane to the **All Settings** > **Debugging** > **Symbols** > **Search Locations** section. Select the **Download symbols from the Microsoft Symbol Servers** checkbox. This option accesses symbols from the public Microsoft Symbol Server. You can add other symbol locations by selecting **Add** and update existing locations with **Edit**. You can change the loading order of the locations by using **Move up** and **Move down**.

   :::moniker-end
   :::moniker range="<=vs-2022"

   - Select **Symbol Settings**, which opens the **Tools** (or **Debug**) > **Options** dialog to the **Debugging** > **Symbols** section. In the **Symbol file (.pdb) search locations** group, select **Microsoft Symbol Servers**. This option accesses symbols from the public Microsoft Symbol Server. You can add other symbol locations by selecting **Add** and update existing locations with **Edit**. You can change the loading order of the locations by using **Move up** and **Move down**. Select **OK** to apply your changes.

   :::moniker-end

## Related content

- [Debugging managed code](/visualstudio/debugger/)
- [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Debug .NET and ASP.NET Core source code with Visual Studio](/aspnet/core/test/debug-aspnetcore-source)
