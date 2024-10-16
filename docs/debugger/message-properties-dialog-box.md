---
title: "Message Properties dialog box in Spy++"
description: Consult Message Properties to find more about a message than is shown in Messages View.
ms.date: 02/05/2024
ms.topic: "ui-reference"
helpviewer_keywords:
  - "message options"
  - "message options, General"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Message Properties dialog box

Use this dialog box to find out more about a specific message. To display this dialog box, move the focus to a [Messages view](messages-view.md) window. Select any message node in the tree, then choose **Properties** from the **View** menu.

The **General** tab is the only tab displayed. The following settings are available:

- **Window Handle**: The unique ID of this window. Window handle numbers are reused; they identify a window only for the lifetime of that window. Click this value to view the properties of this window.
- **Nesting Level**: Depth of nesting of this message, where 0 is no nesting.
- **Message**: Number, status, and name of the selected windows message.
- **lResult**: The value of the *lResult* parameter, if any.
- **wParam**: The value of the *wParam* parameter, if any.
- **lParam**: The value of the *lParam* parameter, if any. This value is decoded if it is a pointer to a string or structure.

## Related sections

- [Message Options dialog box](message-options-dialog-box.md): Used to select which messages are listed in the active Messages view.
- [Message Search dialog box](search-tools-for-spy-increment-views.md#message-search): Used to find the node for a specific message in Messages view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.
- [Opening Messages view from Find window](how-to-use-messages-view.md#open-messages-view-from-find-window): Explains how to open Messages view from the Find Window dialog box.
- [Searching for a message in Messages view](how-to-use-messages-view.md#search-for-a-message-in-messages-view): Explains how to find a specific message in Messages view.
- [Messages view](messages-view.md): Displays the message stream associated with a window, process, or thread.
- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.