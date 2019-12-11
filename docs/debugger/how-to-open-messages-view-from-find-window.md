---
title: "How to: Open Messages View from Find Window | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Messages View in Spy++, opening"
  - "opening Messages View in Spy++"
ms.assetid: 601a193e-432a-417b-9406-6fec9e401264
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Open Messages View from Find Window
You might find it convenient to use the **Find Window** dialog box to select a target window, and then open a Messages view of that window.

### To open a Messages view window using the Find Window dialog box

1. Arrange your windows so that both Spy++ and the target window are visible.

2. From the **Spy** menu, choose **Find Window**.

    The [Find Window Dialog Box](../debugger/find-window-dialog-box.md) opens.

3. From the **Windows** tab, drag the **Finder Tool** over the target window. As you drag the tool, the **Find Window** dialog box displays details on the selected window.

   - or -

     If you have the handle of the window you want to examine (for example, copied from the debugger), you can type it into the **Handle** text box.

4. Under **Show**, select **Messages**.

5. Press **OK**.

    A blank [Messages View](../debugger/messages-view.md) window opens, and a **Messages** menu is added to the Spy++ toolbar.

6. From the **Messages** menu, choose **Logging Options**.

    The [Message Options Dialog Box](../debugger/message-options-dialog-box.md) opens.

7. Select the options for the messages you want to display.

8. Press **OK** to begin logging messages.

    Depending upon the options selected, messages begin streaming into the active Messages view window.

9. When you have enough messages, choose **Stop Logging** from the **Messages** menu.
