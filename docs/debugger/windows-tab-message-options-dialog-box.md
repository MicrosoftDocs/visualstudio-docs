---
title: "Windows Tab, Message Options Dialog Box | Microsoft Docs"
description: Use the Windows tab of Message Options to specify which windows have their messages displayed. See this article for descriptions of the settings.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "message options, Windows"
ms.assetid: 6e9cc5ca-24cc-49cf-aa22-c89733828f8c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Windows Tab, Message Options Dialog Box
Use the **Windows** tab to set the scope of the messages listed in [Messages View](../debugger/messages-view.md). To display the [Message Options Dialog Box](../debugger/message-options-dialog-box.md), choose **Log Messages** from the **Spy** menu.

 The following settings are available on the **Windows** tab:

 **Finder Tool**
 The drag and drop tool used to select a window.

 **Hide Spy++**
 Removes the main Spy++ window and leaves the **MessageOptions** dialog box visible on top of your other applications.

 **Parent Window**
 Display messages for the selected window and its immediate parent window.

 **Child Window**
 Display messages for the selected window and all its child windows, including nested child windows.

 **Windows of Same Thread**
 Display messages for the selected window and all other windows owned by the same thread.

 **Windows of Same Process**
 Display messages for the selected window and all other windows owned by the same process.

 **All Windows in System**
 Display messages for all windows.

 **Save Settings as Default**
 Save the preceding settings for new message stream windows. These settings are also saved when exiting Spy++.