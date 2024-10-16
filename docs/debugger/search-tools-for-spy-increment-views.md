---
title: "Search tools for Spy++ views"
description: See dialog boxes that specify what data a Spy++ views window display. Dialog boxes include Find Window, Window Search, Message Search, Process Search, and Thread Search.
ms.date: 02/05/2024
ms.topic: "ui-reference"
helpviewer_keywords:
  - "searching, Spy++"
  - "Spy++, searching"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Search tools for Spy++ views

Use these dialog boxes to specify what data a Spy++ views window displays.

## Find Window

Use this dialog box to select a window and display its properties or messages. To display this dialog box, choose **Find Window** from the **Spy** menu.

- **Finder Tool**: The drag and drop tool used to select a window.
- **Hide Spy++**: Removes the main Spy++ window and leaves the **Find Window** dialog box visible on top of your other applications.
- **Handle**: The unique ID of the window to find.
- **Caption**: The text of the window caption.
- **Class**: The class of the window.
- **Style**: The style of the window.
- **Rect**: The bounding rectangle for the window.
- **Show Properties or Messages**: Determines whether pressing OK displays the [Window Properties dialog box](window-properties-dialog-box.md) or opens a [Messages view](messages-view.md).

## Window Search

Use this dialog box to find and select the node for a specific window in [Windows view](windows-view.md). To display this dialog box, move the focus to the Windows view window. Then choose **Find Window** from the **Search** menu.

You can use the **Finder Tool** to select a window, or you can enter the window handle, or identify the window by caption and class.

- **Finder Tool**: The drag and drop tool used to select a window.
- **Hide Spy++**: Removes the main Spy++ window and leaves the **WindowSearch** dialog box visible on top of your other applications.
- **Handle**: The unique ID of the window to search for.
- **Caption**: The text in the window caption to search for.
- **Class**: The class of the window to search for.
- **Search Direction Up or Down**: The initial direction of the search.

## Message Search

Use this dialog box to find and select the node for a specific message in [Messages view](messages-view.md). To display this dialog box, move the focus to a Messages view window. Then choose **Find Message** from the **Search** menu.

- **Finder Tool**: The drag and drop tool used to select a window.
- **Hide Spy++**: Removes the main Spy++ window and leaves the **MessageSearch** dialog box visible on top of your other applications.
- **Handle**: The unique ID of the message to search for.
- **Type**: The message type to search for.
- **Message**: The message ID to search for.
- **Search Direction Up or Down**: The initial direction of the search.

## Process Search

Use this dialog box to find and select the node for a specific process in [Processes view](processes-view.md). To display this dialog box, move the focus to a **Processes** view window. Then choose **Find Process** from the **Search** menu.

- **Process**: The process ID to search for.
- **Module**: The module string to search for.
- **Search Direction Up or Down**: The initial direction of the search.

## Thread Search

Use this dialog box to find and select the node for a specific thread in [Threads view](threads-view.md). To display this dialog box, move the focus to a **Threads** view window. Then choose **Find Thread** from the **Search** menu.

- **Thread**: The thread ID to search for.
- **Module**: The module string to search for.
- **Search Direction Up or Down**: The initial direction of the search.

## Related sections

- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.
- [Using the Finder tool](how-to-use-windows-view.md#use-the-finder-tool): Shows how this tool scans windows for properties or messages.
