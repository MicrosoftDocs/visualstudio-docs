---
title: "Messages View"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.externaltools.spyplus.messagesview"
helpviewer_keywords: 
  - "Messages view"
ms.assetid: 14c2a786-c23a-4b2d-acad-8c32a856c70d
caps.latest.revision: 6
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
# Messages View
Each window has an associated message stream. A Messages view window displays this message stream. The window handle, message code, and message are shown. You can create a Messages view for a thread or process as well. This allows you to view messages sent to all windows owned by a specific process or thread, which is particularly useful for capturing window initialization messages.  
  
 A typical Messages view window appears below. Note that the first column contains the window handle, and the second column contains a message code (explained in [Message Codes](../debugger/message-codes.md)). Decoded message parameters and return values are on the right.  
  
 ![Spy&#43;&#43; Messages View](../debugger/media/spy--_messagesview.png "Spy++_MessagesView")  
Spy++ Messages View  
  
## Procedures  
  
#### To open a Messages view for a window, process, or thread  
  
1.  Move the focus to a [Windows View](../debugger/windows-view.md), [Processes View](../debugger/processes-view.md), or [Threads View](../debugger/threads-view.md) window.  
  
2.  Find the node for the item whose messages you want to examine, and select it.  
  
3.  From the **Spy** menu, choose **Log Messages**.  
  
     The [Message Options Dialog Box](../debugger/message-options-dialog-box.md) opens.  
  
4.  Select the options for the message you want to display.  
  
5.  Press **OK** to begin logging messages.  
  
     A Messages view window opens, and a **Messages** menu is added to the Spy++ toolbar. Depending upon the options selected, messages begin streaming into the active Messages view window.  
  
6.  When you have enough messages, choose **Stop Logging** from the **Messages** menu.  
  
## In This Section  
 [Controlling Messages View](../debugger/how-to--control-messages-view.md)  
 Explains how to manage Messages view.  
  
 [Opening Messages View from Find Window](_asug_choosing_message_options)  
 Explains how to open Messages view from the Find Window dialog box.  
  
 [Searching for a Message in Messages View](../debugger/how-to--search-for-a-message-in-messages-view.md)  
 Explains how to find a specific message in Messages view.  
  
 [Starting and Stopping the Message Log Display](../debugger/how-to--start-and-stop-the-message-log-display.md)  
 Explains how to start and stop message logging.  
  
 [Message Codes](../debugger/message-codes.md)  
 Defines the codes for messages listed in Messages view.  
  
 [Displaying Message Properties](../debugger/how-to--display-message-properties.md)  
 How to show more information about a message.  
  
## Related Sections  
 [Spy++ Views](../debugger/spy---views.md)  
 Explains the Spy++ tree views of windows, messages, processes, and threads.  
  
 [Using Spy++](../debugger/using-spy--.md)  
 Introduces the Spy++ tool and explains how it can be used.  
  
 [Message Options Dialog Box](../debugger/message-options-dialog-box.md)  
 Used to select which messages are listed in the active Messages view.  
  
 [Message Search Dialog Box](../debugger/message-search-dialog-box.md)  
 Used to find the node for a specific message in Messages view.  
  
 [Message Properties Dialog Box](../debugger/message-properties-dialog-box.md)  
 Used to display the properties of a message selected in Message view.  
  
 [Spy++ Reference](../debugger/spy---reference.md)  
 Includes sections describing each Spy++ menu and dialog box.