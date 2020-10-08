---
title: "Spy++ Toolbar | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Spy++ toolbar"
ms.assetid: 949c18fb-bb25-42ed-9130-c4a47869f24d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Spy++ Toolbar
The toolbar appears under the menu bar in Spy++. To display or hide the toolbar, on the **View** menu, click **Toolbar**.

 The following controls are available on the toolbar.

## UIElement List

|Button|Effect|
|------------|------------|
|![Spy&#43;&#43; Windows Button](../debugger/media/icon_spy--_windows.gif "Icon_Spy++_Windows")|Displays a tree view of the windows and controls in the system. For more information, see [Windows View](../debugger/windows-view.md).|
|![Spy&#43;&#43; Processes Button](../debugger/media/icon_spy--_processes.gif "Icon_Spy++_Processes")|Displays a tree view of the processes in the system. For more information, see [Processes View](../debugger/processes-view.md).|
|![Spy&#43;&#43; Threads Button](../debugger/media/icon_spy--_threads.gif "Icon_Spy++_Threads")|Displays a tree view of the threads in the system. For more information, see [Threads View](../debugger/threads-view.md).|
|![Spy&#43;&#43; Messages Button](../debugger/media/icon_spy--_messages.gif "Icon_Spy++_Messages")|Creates a window to display window messages and opens the **Message Options** dialog box so that you can select the window whose messages will be displayed and also select other options. For more information, see [Messages View](../debugger/messages-view.md).|
|![Spy&#43;&#43; Start Log Button](../debugger/media/icon_spy--_startlog.gif "Icon_Spy++_StartLog")|Starts message logging and displays the message stream. This control is available only when a **Messages** window is the active window. For more information, see [How to: Start and Stop the Message Log Display](../debugger/how-to-start-and-stop-the-message-log-display.md).|
|![Spy&#43;&#43; Stop Log Button](../debugger/media/icon_spy--_stoplog.gif "Icon_Spy++_StopLog")|Stops message logging and the display of the message stream. This control is available only when a **Messages** window is the active window. For more information, see [How to: Start and Stop the Message Log Display](../debugger/how-to-start-and-stop-the-message-log-display.md).|
|![Spy&#43;&#43; Log Options Button](../debugger/media/icon_spy--_logoptions.gif "Icon_Spy++_LogOptions")|Displays the [Message Options](../debugger/message-options-dialog-box.md) dialog box. Use this dialog box to select windows and message types for viewing. This control is available only when a **Messages** window is the active window.|
|![Spy&#43;&#43; Clear Log Button](../debugger/media/spy--_clearlog.gif "Spy++_ClearLog")|Clears the contents of the active **Messages** window. This control is available only when a **Messages** window is the active window.|
|![Spy&#43;&#43; Find Window Button](../debugger/media/icon_spy--_findwindow.gif "Icon_Spy++_FindWindow")|Opens the [Find Window](../debugger/find-window-dialog-box.md) dialog box, which lets you set window search criteria and display properties or messages. For more information, see [How to: Use the Finder Tool](../debugger/how-to-use-the-finder-tool.md).|
|![Spy&#43;&#43; Find First Window Button](../debugger/media/icon_spy--_window.gif "Icon_Spy++_Window")|Searches the current view for a matching window, process, thread, or message.|
|![Spy&#43;&#43; Find Next Window Button](../debugger/media/icon_spy--_nextwindow.gif "Icon_Spy++_NextWindow")|Searches the current view for the next matching window, process, thread, or message. This control (and the related menu command) is available only when there is a valid search result that is not unique. For example, when you use a window handle as the search criterion in the window tree, it produces unique results because there is only one window in the window tree that has that handle; in this instance, **Find Next** is not available.|
|![Spy&#43;&#43; Find Previous Window Button](../debugger/media/icon_spy--_prevwindow.gif "Icon_Spy++_PrevWindow")|Searches the current view for the previous matching window, process, thread, or message. This control (and the related menu command) is available only when there is a valid search result that is not unique. For example, when you use a window handle as the search criterion in the window tree, it produces unique results because there is only one window in the window tree that has that handle; in this instance, **Find Previous** is not available.|
|![Spy&#43;&#43; Property Explorer Button](../debugger/media/icon_spy--_propexp.gif "Icon_Spy++_PropExp")|Displays the properties of the window that is selected in the Windows view.|
|![Spy&#43;&#43; Refresh Button](../debugger/media/icon_spy--_refresh.gif "Icon_Spy++_Refresh")|Refreshes the system views.|

## See also
- [Using Spy++](../debugger/using-spy-increment.md)
- [Spy++ Views](../debugger/spy-increment-views.md)
- [Spy++ Reference](../debugger/spy-increment-reference.md)