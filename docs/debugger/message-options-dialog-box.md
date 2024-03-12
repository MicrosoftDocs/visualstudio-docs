---
title: "Message Options dialog box in Spy++"
description: Specify in Message Options which messages are listed in Messages View, and what message data to display.
ms.date: 02/05/2024
ms.topic: "ui-reference"
helpviewer_keywords:
  - "message options, Spy++"
  - "Spy++, message options"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Message Options dialog box

Use this dialog box to select which messages are listed in [Messages view](messages-view.md). To display this dialog box, choose **Log Messages** from the **Spy** menu.

## Windows tab, Message Options

Use the **Windows** tab to set the scope of the messages listed in [Messages view](messages-view.md). The following settings are available:

- **Finder Tool**: The drag and drop tool used to select a window.
- **Hide Spy++**: Removes the main Spy++ window and leaves the **MessageOptions** dialog box visible on top of your other applications.
- **Parent Window**: Display messages for the selected window and its immediate parent window.
- **Child Window**: Display messages for the selected window and all its child windows, including nested child windows.
- **Windows of Same Thread**: Display messages for the selected window and all other windows owned by the same thread.
- **Windows of Same Process**: Display messages for the selected window and all other windows owned by the same process.
- **All Windows in System**: Display messages for all windows.
- **Save Settings as Default**: Save the preceding settings for new message stream windows. These settings are also saved when exiting Spy++.

## Messages tab, Message Options

Use the **Messages** tab to select which message types to list in [Messages view](messages-view.md), and to specify message search criteria. Typically, you first select **Message Groups**, and then fine-tune the selection by selecting individual **Messages to View**. The **All** button selects all message types, and the **None** button clears all types.

The following settings are available on the **Messages** tab:

- **Messages to View**: Select specific messages for viewing. When you create a new Messages window, it can display all messages. When you filter messages from the **Messages** tab, that filter only applies to new messages, not messages that have already been displayed in the Windows view.
- **Message Groups**: Select message groups for viewing. The available groups include:
    - WM_USER: with a code greater than or equal to WM_USER
    - Registered: registered with the **RegisterWindowMessage** call
    - Unknown: unknown messages in the range 0 to (WM_USER - 1)

  Note that these **Message Groups** do not map to specific entries under **Messages To View**. When you select a group, the selection is applied directly to the message stream.

  A grayed check box within **Message Groups** indicates that the **Messages To View** list box has been modified for messages in that group; not all of the message types in that group are selected.
- **Save Settings as Default**: Save the current settings for later use as message search options. These settings are also saved when exiting Spy++.

## Output tab, Message Options

Use the **Output** tab to specify what data from each message to list in [Messages view](messages-view.md). The following settings are available:

- **Line Numbers**: Display line numbers.
- **Message Nesting Level**: Prefix nested messages with one period per level.
- **Raw Message Parameters**: Display the hexadecimal **wParam** and **lParam** values.
- **Decoded Message Parameters**: Display the results of message-specific decoding of the **wParam** and **lParam** values.
- **Raw Return Values**: Display the hexadecimal **lResult** return value.
- **Decoded Return Values**: Display the results of message-specific decoding of the **lResult** return value.
- **Message Origin Time**: The elapsed time since the Windows system was started (for posted messages only).
- **Message Mouse Position**: The screen coordinates of the mouse when the message was posted (for posted messages only).
- **Lines maximum**: Limit the number of lines that are retained in the currently selected Messages view.
- **Also Log Messages to File**: Specify an output file for the message log. This output file is written simultaneously with the message log window.
- **Save Settings as Default**: Save the preceding settings for new message stream windows. These settings are saved when you quit Spy++.

## Related sections

- [Message Search dialog box](search-tools-for-spy-increment-views.md#message-search): Used to find the node for a specific message in Message View.
- [Message Properties dialog box](message-properties-dialog-box.md): Used to display the properties of a message selected in Message View.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.
- [Searching for a message in Messages view](how-to-use-messages-view.md#search-for-a-message-in-messages-view): Explains how to find a specific message in Messages View.
- [Opening Messages view from Find window](how-to-use-messages-view.md#open-messages-view-from-find-window): Explains how to open Messages View from the Find Window dialog box.
- [Messages view](messages-view.md): Displays the message stream associated with a window, process, or thread.
- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.