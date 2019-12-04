---
title: "Introducing Spy++ | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Spy++"
ms.assetid: 733b514b-63a9-402d-89aa-4f0416766655
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Introducing Spy++
Spy++ lets you perform the following tasks:

- Display a graphical tree of relationships among system objects. These include [processes](../debugger/processes-view.md), [threads](../debugger/threads-view.md), and [windows](../debugger/windows-view.md).

- Search for specified [windows](../debugger/how-to-search-for-a-window-in-windows-view.md), [threads](../debugger/how-to-search-for-a-thread-in-threads-view.md), [processes](../debugger/how-to-search-for-a-process-in-processes-view.md), or [messages](../debugger/how-to-search-for-a-message-in-messages-view.md).

- View the properties of selected [windows](../debugger/how-to-display-window-properties.md), [threads](../debugger/how-to-display-thread-properties.md), [processes](../debugger/how-to-display-process-properties.md), or [messages](../debugger/how-to-display-message-properties.md).

- Select a window, thread, process, or message directly in the view.

- Use the [Finder Tool](../debugger/how-to-use-the-finder-tool.md) to select a window by mouse pointer positioning.

- Set [message option](../debugger/how-to-open-messages-view-from-find-window.md) by using complex message log selection parameters.

  Spy++ has a toolbar and hyperlinks to help you work faster. It also provides a **Refresh** command to update the active view, a **Window Finder Tool** to make spying easier, and a **Font** dialog box to customize view windows. Additionally, Spy++ lets you save and restore user preferences.

  In various Spy++ windows, you can right-click to display a shortcut menu of frequently used commands. Which commands are displayed depends on where the pointer is. For example, if you right-click an entry in the Window view and the selected window is visible, then clicking **Highlight** on the shortcut menu causes the border of the selected window to flash so that it can be located more easily.

> [!NOTE]
> There are two other utilities that resemble Spy++: PView, which shows details about processes and threads, and DDESPY.EXE, which lets you monitor Dynamic Data Exchange (DDE) messages.

## 64-Bit Operating Systems
 There are two versions of Spy++. The first version, named Spy++ (spyxx.exe), is designed to display messages sent to a window that is running in a 32-bit process. For example, Visual Studio runs in a 32-bit process. Therefore, you can use Spy++ to display messages sent to **Solution Explorer**. Because the default configuration for most builds in Visual Studio is to run in a 32-bit process, this first version of Spy++ is the one that is available on the **Tools** menu in Visual Studio, if [required components are installed](../debugger/how-to-start-spy-increment.md).

 The second version, named Spy++ (64-bit) (spyxx_amd64.exe), is designed to display messages sent to a window that is running in a 64-bit process. For example, on a 64-bit operating system, Notepad runs in a 64-bit process. Therefore, you can use Spy++ (64-bit) to display messages sent to Notepad. Spy++ (64-bit) is typically located in

 ..\\*Visual Studio installation folder*\Common7\Tools\spyxx_amd64.exe.

 You can run either version of Spy++ directly from the command line.

> [!NOTE]
> Although the Spy++ (64-bit) file name contains "amd", it runs on any x64 Windows operating system.

## See also
- [How to: Start Spy++](../debugger/how-to-start-spy-increment.md)
- [Using Spy++](../debugger/using-spy-increment.md)
- [Spy++ Views](../debugger/spy-increment-views.md)
- [Spy++ Reference](../debugger/spy-increment-reference.md)