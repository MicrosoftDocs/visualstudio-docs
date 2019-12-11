---
title: "Message Properties Dialog Box | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "message options"
  - "message options, General"
ms.assetid: 58e9dc24-baf6-4ab8-916c-aea28b72e3b0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Message Properties Dialog Box
Use this dialog box to find out more about a specific message. To display this dialog box, move the focus to a [Messages View](../debugger/messages-view.md) window. Select any message node in the tree, then choose **Properties** from the **View** menu.

 The **General** tab is the only tab displayed. The following settings are available:

 **Window Handle**
 The unique ID of this window. Window handle numbers are reused; they identify a window only for the lifetime of that window. Click this value to view the properties of this window.

 **Nesting Level**
 Depth of nesting of this message, where 0 is no nesting.

 **Message**
 Number, status, and name of the selected windows message.

 **lResult**
 The value of the *lResult* parameter, if any.

 **wParam**
 The value of the *wParam* parameter, if any.

 **lParam**
 The value of the *lParam* parameter, if any. This value is decoded if it is a pointer to a string or structure.

## Related Sections
 [Message Options Dialog Box](../debugger/message-options-dialog-box.md)
 Used to select which messages are listed in the active Messages view.

 [Message Search Dialog Box](../debugger/message-search-dialog-box.md)
 Used to find the node for a specific message in Messages view.

 [Spy++ Reference](../debugger/spy-increment-reference.md)
 Includes sections describing each Spy++ menu and dialog box.

 [Opening Messages View from Find Window](../debugger/how-to-open-messages-view-from-find-window.md)
 Explains how to open Messages view from the Find Window dialog box.

 [Searching for a Message in Messages View](../debugger/how-to-search-for-a-message-in-messages-view.md)
 Explains how to find a specific message in Messages view.

 [Messages View](../debugger/messages-view.md)
 Displays the message stream associated with a window, process, or thread.

 [Spy++ Views](../debugger/spy-increment-views.md)
 Explains the Spy++ tree views of windows, messages, processes, and threads.

 [Using Spy++](../debugger/using-spy-increment.md)
 Introduces the Spy++ tool and explains how it can be used.