---
title: "What’s New for the Debugger in Visual Studio 2017 | Microsoft Docs"
ms.custom: ""
ms.date: "03/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, what's new"
  - "what's new [debugger]"
  - "debugging [Visual Studio], what's new"
  - "what's new [Visual Studio], debugging"
ms.assetid: 2aed9caa-2384-4e49-8595-82d8b06cf271
caps.latest.revision: 81
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# What’s New for the Debugger in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]

The debugger includes these new features:

- The **Exception Helper** replaces the Exception Assistant and appears in a non-modal dialog box where the error occurred. The **Exception Helper** provides quicker access to any inner exceptions, additional analysis by the debugger (if available), and immediate access to the **Exception Settings** for the exception. The Exception Helper can also be dragged to a floating view if it is blocking something that you need to see.

    For example, a **NullReferenceException** now shows the variable that has the null reference (extra information).

    ![Debugger's Exception Helper](../debugger/media/dbg-exception-helper.png "DbgExceptionHelper")

    For more information, see the [Using the New Exception Helper in Visual Studio](https://blogs.msdn.microsoft.com/visualstudioalm/2016/03/31/using-the-new-exception-helper-in-visual-studio-15-preview/) blog post.

- You can now run to a line of code while paused in the debugger by selecting the **Run execution to here** green arrow icon (you see the icon while hovering over a line of code). This eliminates the need to set temporary breakpoints.

    ![Debugger's Run to Click](../debugger/media/dbg-run-to-click.png "DbgRunToClick") 

- You can set conditions on exceptions in the **Exception Settings** dialog box (You can do this by using the **Edit condition** icon in the Exception Settings dialog box or by using the right-click menu on the exception.) Currently supported conditions include the module name(s) to include or exclude for the exception.

    ![Conditions on an Exception](../debugger/media/dbg-conditional-exception.png "DbgConditionalException")

- Attach to Process dialog box includes a new search feature that can help you more quickly identify the process that you need to attach to.

    ![Search in Attach to Process](../debugger/media/dbg-attach-to-process-search.png "DbgAttachToProcessSearch") 

For more information on these new features, see the [Release Notes for [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]](https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#debuggingdiag).
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)