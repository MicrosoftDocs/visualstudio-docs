---
title: "Output Tab, Message Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "message options, Output"
ms.assetid: 22dd48c2-6d17-41b1-b84c-9ddeaef68411
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Output Tab, Message Options Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use the **Output** tab to specify what data from each message to list in [Messages View](../debugger/messages-view.md). To display the [Message Options Dialog Box](../debugger/message-options-dialog-box.md), choose **Log Messages** from the **Spy** menu.  
  
 The following settings are available on the **Output** tab:  
  
 **Line Numbers**  
 Display line numbers.  
  
 **Message Nesting Level**  
 Prefix nested messages with one period per level.  
  
 **Raw Message Parameters**  
 Display the hexadecimal **wParam** and **lParam** values.  
  
 **Decoded Message Parameters**  
 Display the results of message-specific decoding of the **wParam** and **lParam** values.  
  
 **Raw Return Values**  
 Display the hexadecimal **lResult** return value.  
  
 **Decoded Return Values**  
 Display the results of message-specific decoding of the **lResult** return value.  
  
 **Message Origin Time**  
 The elapsed time since the Windows system was started (for posted messages only).  
  
 **Message Mouse Position**  
 The screen coordinates of the mouse when the message was posted (for posted messages only).  
  
 **Lines maximum**  
 Limit the number of lines that are retained in the currently selected Messages view.  
  
 **Also Log Messages to File**  
 Specify an output file for the message log. This output file is written simultaneously with the message log window.  
  
 **Save Settings as Default**  
 Save the preceding settings for new message stream windows. These settings are saved when you quit Spy++.
