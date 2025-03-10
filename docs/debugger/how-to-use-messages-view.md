---
title: Use Messages view
description: Learn how to use Messages view, and how to choose the windows and messages types shown in a Messages view window.
ms.date: 02/05/2024
ms.topic: how-to
helpviewer_keywords: 
  - Spy++, Messages view
  - controlling
  - opening Messages view in Spy++
  - Message Search dialog box
  - logs, starting message log display
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# How to use Messages view

You can choose the windows and message types shown in a Messages view window.

Each window has an associated message stream. A Messages view window displays this message stream. The window handle, message code, and message are shown. You can create a Messages view for a thread or process as well. This allows you to view messages sent to all windows owned by a specific process or thread, which is useful for capturing window initialization messages.

The following image shows a typical Messages view window.

:::image type="content" source="media/spy-messages-view.png" alt-text="Screenshot of Messages view in Spy++.":::

The first column contains the window handle, and the second column contains a [message code](message-codes.md). Decoded message parameters and return values are on the right.

## Control Messages view

With Spy++, you have considerable control over the content of a Messages view window. You can [start and stop](#start-and-stop-the-message-log-display) displaying the messages at any time, and you can specify:

- Which message types you want to see.

- Which windows you want to monitor.

- The display format for message lines.

  These settings are available from the [Message Options dialog box](/previous-versions/visualstudio/visual-studio-2017/debugger/message-options-dialog-box), and they apply only to the active Messages view window. To open this dialog box, choose **Log Messages** from the **Spy** menu.

  Three tabbed panes of message options are available. For further information, see [Windows tab, Message Options dialog box](message-options-dialog-box.md#windows-tab-message-options), [Messages tab, Message Options dialog box](message-options-dialog-box.md#messages-tab-message-options), and [Output tab, Message Options dialog box](message-options-dialog-box.md#output-tab-message-options).

## Open Messages view from Find Window

You might find it convenient to use the **Find Window** dialog box to select a target window, and then open a Messages view of that window.

To open a Messages view window using the Find Window dialog box:

1. Arrange your windows so that both Spy++ and the target window are visible.

2. From the **Spy** menu, choose **Find Window**.

    The [Find Window dialog box](search-tools-for-spy-increment-views.md#find-window) opens.

3. From the **Windows** tab, drag the **Finder Tool** over the target window. As you drag the tool, the **Find Window** dialog box displays details on the selected window.

    Or, if you have the handle of the window you want to examine (for example, copied from the debugger), you can type it into the **Handle** text box.

4. Under **Show**, select **Messages**.

5. Press **OK**.

    A blank [Messages view](/previous-versions/visualstudio/visual-studio-2017/debugger/messages-view) window opens, and a **Messages** menu is added to the Spy++ toolbar.

6. From the **Messages** menu, choose **Logging Options**.

    The [Message Options dialog box](/previous-versions/visualstudio/visual-studio-2017/debugger/message-options-dialog-box) opens.

7. Select the options for the messages you want to display.

8. Press **OK** to begin logging messages.

    Depending upon the options selected, messages begin streaming into the active Messages view window.

9. When you have enough messages, choose **Stop Logging** from the **Messages** menu.

## Search for a message in Messages view

You can search for a specific message in Messages view by using its handle, type, or message ID as search criteria. Any one of these, or a combination, is valid search criteria. The initial direction of the search can also be specified. The fields in the dialog box are preloaded with the attributes of the message currently selected.

To search for a message in Messages view:

1. Arrange your windows so that Spy++ and an active Messages view window are visible.

2. From the **Search** menu, choose **Find Message**.

    The [Message Search dialog box](search-tools-for-spy-increment-views.md#window-search) opens.

3. Drag the **Finder Tool** over the desired window. As you drag the tool, the **Message Search** dialog box displays details on the selected window.

    - Alternatively, if you have the handle of the window whose messages you want to examine, type it into the **Handle** text box.
    - Or, if you know the message type and/or message ID you want, select them from the **Type** and **Message** dropdown menus, and clear the **Handle** text box.

4. Clear any fields for which you do not want to specify values.

   > [!TIP]
   > To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window, leaving only the **Find Window** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.

5. Choose **Up** or **Down** for the initial direction of the search.

6. Click **OK**.

   If a matching message is found, it's highlighted in the Messages view window.

## Start and stop the message log display

When a Messages view window is active, a **Start Logging** or **Stop Logging** choice appears on the Spy++ **Messages** menu, and the corresponding **Start Logging** or **Stop Logging** toolbar button becomes active.

To start the message log display:

- From the **Messages** menu, choose **Start Logging**.

To stop the message log display:

- From the **Messages** menu, choose **Stop Logging**.
