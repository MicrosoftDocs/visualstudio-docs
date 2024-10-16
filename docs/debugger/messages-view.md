---
title: "Messages view"
description: Learn how each window, thread, and process have an associated message stream that can be viewed in a Messages view window.
ms.date: 02/05/2024
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.messagesview"
helpviewer_keywords:
  - "Messages view"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Messages view

Each window has an associated message stream. A Messages view window displays this message stream. The window handle, message code, and message are shown. You can create a Messages view for a thread or process as well. This allows you to view messages sent to all windows owned by a specific process or thread, which is useful for capturing window initialization messages.

The following image shows a typical Messages view window.

:::image type="content" source="media/spy-messages-view.png" alt-text="Screenshot of Messages view in Spy++.":::

The first column contains the window handle, and the second column contains a [message code](message-codes.md). Decoded message parameters and return values are on the right.

## Procedures

### To open Messages view for a window, process, or thread

1. Move the focus to a [Windows view](windows-view.md), [Processes view](processes-view.md), or [Threads view](threads-view.md) window.

2. Find the node for the item whose messages you want to examine, and select it.

3. From the **Spy** menu, choose **Log Messages**.

     The [Message Options dialog box](message-options-dialog-box.md) opens.

4. Select the options for the message you want to display.

5. Press **OK** to begin logging messages.

     A Messages view window opens, and a **Messages** menu is added to the Spy++ toolbar. Depending upon the options selected, messages begin streaming into the active Messages view window.

6. When you have enough messages, choose **Stop Logging** from the **Messages** menu.

### To open properties for a message

To find out more about a message listed in Messages view, use the [Message Properties dialog box](message-properties-dialog-box.md).

1. Select a message from the tree displayed in Messages view.

2. From the **View** menu, choose **Properties**.

   Properties dialog boxes aren't modal, so you can select another item in a view window and the dialog box shows information on the selected item.

## Related sections

- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.
- [Message Options dialog box](message-options-dialog-box.md): Used to select which messages are listed in the active Messages view.
- [Message Search dialog box](search-tools-for-spy-increment-views.md#message-search): Used to find the node for a specific message in Messages view.
- [Message Properties dialog box](message-properties-dialog-box.md): Used to display the properties of a message selected in Message view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.