---
title: "Output Tab, Message Options Dialog Box"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "message options, Output"
ms.assetid: 22dd48c2-6d17-41b1-b84c-9ddeaef68411
caps.latest.revision: 4
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Output Tab, Message Options Dialog Box
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