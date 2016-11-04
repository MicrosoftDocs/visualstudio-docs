---
title: "What’s New for the Debugger in Visual Studio 2015 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
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
# What’s New for the Debugger in Visual Studio 2015
For information about everything that’s new in Visual Studio 2015 Update 1 debugging and diagnostics, see [Visual Studio 2015 Update 1 Release Notes](https://www.visualstudio.com/news/vs2015-update1-vs#debug).  
  
 For information about everything that’s new in Visual Studio 2015 RTM debugging and diagnostics, see [Visual Studio 2015 Release Notes](https://www.visualstudio.com/news/vs2015-vs#debug).  
  
## Visual Studio 2015 Update 1 Changes  
 C++ Edit and Continue supports more features. For more information, see [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md).  
  
 For debugging Visual C++ access violations, a new exception dialog specifies the pointer that caused the exception. For more information, please see [How Can I Debug an Access Violation?](../debugger/how-can-i-debug-an-access-violation-q.md) and [Improvement to Debugging C++ Access Violations in Visual Studio 2015 Update 1](http://blogs.msdn.com/b/visualstudioalm/archive/2015/10/29/improvement-to-debugging-c-access-violations-in-visual-studio-2015-update-1.aspx)  
  
## Visual Studio 2015 RTM Debugger UI and Hotkey Changes  
 There are significant UI changes in the Exceptions and Breakpoints UI.  
  
### Breakpoints  
 In Visual Studio 2015 there is a new way to configure breakpoints, which is the **Breakpoint Settings** window.  
  
 Here is a summary of the main Breakpoints windows and hotkeys:  
  
|Feature|Menu Location|Hotkey|  
|-------------|-------------------|------------|  
|New breakpoint, toggle breakpoint|**Debug / Toggle Breakpoint**<br /><br /> context menu in editor / **Insert breakpoint**<br /><br /> click in left margin|F9|  
|New function breakpoint|**Debug / New Breakpoint / Function Breakpoint**|In Visual Studio 2015 RTM (with no updates), use ALT + F9, B<br /><br /> In Visual Studio 2015 Update 1 and later, use CTRL + B|  
|**Breakpoints** window|**Debug / Windows / Breakpoints**|CTRL + ALT + B|  
|**Breakpoint Settings**, **Conditions**|context menu on the breakpoint / **Conditions**|ALT + F9, C|  
|**Breakpoint Settings**, **Actions**|context menu on the breakpoint / **Actions**|No hotkey|  
  
 For more information, see the following articles:  
  
1.  [Using Breakpoints](../debugger/using-breakpoints.md)  
  
2.  [New Breakpoint Configuration Experience](http://blogs.msdn.com/b/visualstudioalm/archive/2014/10/06/new-breakpoint-configuration-experience.aspx)  
  
3.  [Breakpoint Configuration Experience](http://channel9.msdn.com/Events/Visual-Studio/Connect-event-2014/711)  
  
### Exception Settings  
 The new **Exception Settings** window allows you to specify the kind of exception handling you want for single exceptions or categories of exceptions.  
  
|Feature|Menu Location|Hotkey|  
|-------------|-------------------|------------|  
|**Exception Settings** window|**Debug / Windows / Exception Settings**|CTRL + ALT + E|  
  
 For more information, see the following articles:  
  
1.  [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)  
  
2.  [The New Exceptions Window](http://blogs.msdn.com/b/visualstudioalm/archive/2015/02/23/the-new-exception-settings-window-in-visual-studio-2015.aspx)  
  
### Edit and Continue  
 In Visual Studio 2015, you can set Edit and Continue in the **Tools / Options / Debugging / General** page. In previous versions, these settings were in a separate options category.  
  
### Attach to Process  
 In Visual Studio 2015 the Attach to Process command is available only from the Debug menu. In previous version it had been available from the Tools menu as well. The CTRL + ALT + P hotkey works in all versions.  
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)