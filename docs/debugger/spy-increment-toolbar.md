---
title: "Spy++ Toolbar"
description: Learn about the user interface elements in the Spy++ toolbar, which appears under the menu bar.
ms.date: 02/05/2024
ms.topic: "conceptual"
helpviewer_keywords:
  - "Spy++ toolbar"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Spy++ Toolbar

The toolbar appears under the menu bar in Spy++. To display or hide the toolbar, on the **View** menu, select **Toolbar**.

 The following controls are available on the toolbar.

## UIElement List

|Button|Effect|
|------------|------------|
|![Spy++ Windows Button](media/icon-spy-windows.gif "Icon-Spy++Windows")|Displays a tree view of the windows and controls in the system. For more information, see [Windows view](/previous-versions/visualstudio/visual-studio-2017/debugger/windows-view).|
|![Spy++ Processes Button](media/icon-spy-processes.gif "Icon-Spy++Processes")|Displays a tree view of the processes in the system. For more information, see [Processes view](/previous-versions/visualstudio/visual-studio-2017/debugger/processes-view).|
|![Spy++ Threads Button](media/icon-spy-threads.gif "Icon-Spy++Threads")|Displays a tree view of the threads in the system. For more information, see [Threads view](/previous-versions/visualstudio/visual-studio-2017/debugger/threads-view).|
|![Spy++ Messages Button](media/icon-spy-messages.gif "Icon-Spy++Messages")|Creates a window to display window messages and opens the **Message Options** dialog box so that you can select the window whose messages are displayed and also select other options. For more information, see [Messages view](/previous-versions/visualstudio/visual-studio-2017/debugger/messages-view).|
|![Spy++ Start Log Button](media/icon-spy-start-log.gif "Icon-Spy++Start-Log")|Starts message logging and displays the message stream. This control is available only when a **Messages** window is the active window. For more information, see [Start and stop the message log display](how-to-use-messages-view.md#start-and-stop-the-message-log-display).|
|![Spy++ Stop Log Button](media/icon-spy-stop-log.gif "Icon-Spy++Stop-Log")|Stops message logging and the display of the message stream. This control is available only when a **Messages** window is the active window. For more information, see [Start and stop the message log display](how-to-use-messages-view.md#start-and-stop-the-message-log-display).|
|![Spy++ Log Options Button](media/icon-spy-log-options.gif "Icon-Spy++Log-Options")|Displays the [Message Options](/previous-versions/visualstudio/visual-studio-2017/debugger/message-options-dialog-box) dialog box. Use this dialog box to select windows and message types for viewing. This control is available only when a **Messages** window is the active window.|
|![Spy++ Clear Log Button](media/spy-clear-log.gif "Spy++Clear-Log")|Clears the contents of the active **Messages** window. This control is available only when a **Messages** window is the active window.|
|![Spy++ Find Window Button](media/icon-spy-find-window.gif "Icon-Spy++Find-Window")|Opens the [Find Window](search-tools-for-spy-increment-views.md#find-window) dialog box, which lets you set window search criteria and display properties or messages. For more information, see [Use the Finder Tool](how-to-use-windows-view.md#use-the-finder-tool).|
|![Spy++ Find First Window Button](media/icon-spy-window.gif "Icon-Spy++Window")|Searches the current view for a matching window, process, thread, or message.|
|![Spy++ Find Next Window Button](media/icon-spy-next-window.gif "Icon-Spy++Next-Window")|Searches the current view for the next matching window, process, thread, or message. This control (and the related menu command) is available only when there's a valid search result that's not unique. For example, when you use a window handle as the search criterion in the window tree, it produces unique results because there's only one window in the window tree that has that handle; in this instance, **Find Next** isn't available.|
|![Spy++ Find Previous Window Button](media/icon-spy-prev-window.gif "Icon-Spy++Prev-Window")|Searches the current view for the previous matching window, process, thread, or message. This control (and the related menu command) is available only when there's a valid search result that isn't unique. For example, when you use a window handle as the search criterion in the window tree, it produces unique results because there's only one window in the window tree that has that handle; in this instance, **Find Previous** isn't available.|
|![Spy++ Property Explorer Button](media/icon-spy-prop-exp.gif "Icon-Spy++Prop-Exp")|Displays the properties of the window that is selected in the Windows view.|
|![Spy++ Refresh Button](media/icon-spy-refresh.gif "Icon-Spy++Refresh")|Refreshes the system views.|

## Related content

- [Using Spy++](using-spy-increment.md)
- [Spy++ reference](spy-increment-reference.md)