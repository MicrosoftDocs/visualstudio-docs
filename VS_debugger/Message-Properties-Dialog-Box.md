---
title: "Message Properties Dialog Box"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 58e9dc24-baf6-4ab8-916c-aea28b72e3b0
caps.latest.revision: 4
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Message Properties Dialog Box
Use this dialog box to find out more about a specific message. To display this dialog box, move the focus to a [Messages View](../VS_debugger/Messages-View.md) window. Select any message node in the tree, then choose **Properties** from the **View** menu.  
  
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
 [Message Options Dialog Box](../VS_debugger/Message-Options-Dialog-Box.md)  
 Used to select which messages are listed in the active Messages view.  
  
 [Message Search Dialog Box](../VS_debugger/Message-Search-Dialog-Box.md)  
 Used to find the node for a specific message in Messages view.  
  
 [Spy++ Reference](../VS_debugger/Spy---Reference.md)  
 Includes sections describing each Spy++ menu and dialog box.  
  
 [Opening Messages View from Find Window](_asug_choosing_message_options)  
 Explains how to open Messages view from the Find Window dialog box.  
  
 [Searching for a Message in Messages View](../VS_debugger/How-to--Search-for-a-Message-in-Messages-View.md)  
 Explains how to find a specific message in Messages view.  
  
 [Messages View](../VS_debugger/Messages-View.md)  
 Displays the message stream associated with a window, process, or thread.  
  
 [Spy++ Views](../VS_debugger/Spy---Views.md)  
 Explains the Spy++ tree views of windows, messages, processes, and threads.  
  
 [Using Spy++](../VS_debugger/Using-Spy--.md)  
 Introduces the Spy++ tool and explains how it can be used.