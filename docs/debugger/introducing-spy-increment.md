---
title: Introducing the Spy++ debugging tool
description: Read about the Spy++ debugging tool. Display a graphical tree of system object relationships. Get properties for selected windows, threads, processes, or messages.
ms.date: 02/28/2025
ms.topic: concept-article
helpviewer_keywords:
  - "Spy++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Introducing Spy++

Spy++ (SPYXX.EXE) is a Win32-based utility that gives you a graphical view of the system's processes, threads, windows, and window messages. Spy++ lets you perform the following tasks:

- Display a graphical tree of relationships among system objects. These include the [Processes view](../debugger/using-spy-increment.md#processes-view), [Threads view](../debugger/using-spy-increment.md#threads-view), and [Windows view](../debugger/how-to-use-windows-view.md).

- Search for specified [windows](how-to-use-windows-view.md#search-for-a-window-in-windows-view), [threads](search-tools-for-spy-increment-views.md#thread-search), [processes](how-to-search-for-a-process-in-processes-view.md), or [messages](how-to-use-messages-view.md#search-for-a-message-in-messages-view).

- View the properties of selected windows, threads, processes, or messages.

- Select a window, thread, process, or message directly in the view.

- Use the [Finder Tool](how-to-use-windows-view.md#use-the-finder-tool) to select a window by mouse pointer positioning.

- Set [message option](how-to-use-messages-view.md#open-messages-view-from-find-window) by using complex message log selection parameters.

  Spy++ has a toolbar and hyperlinks to help you work faster. It also provides a **Refresh** command to update the active view, a **Window Finder Tool** to make spying easier, and a **Font** dialog box to customize view windows. Additionally, Spy++ lets you save and restore user preferences.

  In various Spy++ windows, you can right-click to display a shortcut menu of frequently used commands. Which commands are displayed depends on where the pointer is. For example, if you right-click an entry in the Window view and the selected window is visible, then clicking **Highlight** on the shortcut menu causes the border of the selected window to flash so that it can be located more easily.

To install required components for Spy++, see [Start Spy++](../debugger/how-to-start-spy-increment.md).

> [!NOTE]
> There are two other utilities that resemble Spy++: PView, which shows details about processes and threads, and DDESPY.EXE, which lets you monitor Dynamic Data Exchange (DDE) messages.

## 64-bit operating systems

There are two versions of Spy++. The first version, named Spy++ (spyxx.exe), is designed to display messages sent to a window that is running in a 32-bit process. For example, Visual Studio runs in a 32-bit process. Therefore, you can use Spy++ to display messages sent to **Solution Explorer**. Because the default configuration for most builds in Visual Studio is to run in a 32-bit process, this first version of Spy++ is the one that is available on the **Tools** menu in Visual Studio, if [required components are installed](how-to-start-spy-increment.md).

The second version, named Spy++ (64-bit) (spyxx_amd64.exe), is designed to display messages sent to a window that is running in a 64-bit process. For example, on a 64-bit operating system, Notepad runs in a 64-bit process. Therefore, you can use Spy++ (64-bit) to display messages sent to Notepad. Spy++ (64-bit) is typically located in

 ..\\*Visual Studio installation folder*\Common7\Tools\spyxx_amd64.exe.

You can run either version of Spy++ directly from the command line.

> [!NOTE]
> Although the Spy++ (64-bit) file name contains *amd*, it runs on any x64 Windows operating system.

## Related content

- [Start Spy++](how-to-start-spy-increment.md)
- [Using Spy++](using-spy-increment.md)
- [Spy++ reference](spy-increment-reference.md)
