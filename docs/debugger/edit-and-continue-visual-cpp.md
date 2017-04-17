---
title: "Edit and Continue (Visual C++) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
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
  - "Edit and Continue [C++]"
  - "debugging [C++], Edit and Continue"
  - "C/C++, Edit and Continue"
ms.assetid: 1815251e-a877-433e-9e5e-69bd9ba254c7
caps.latest.revision: 25
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
# Edit and Continue (Visual C++)
You can use Edit and Continue in Visual C++ projects. See [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md) for information about the limitations of Edit and Continue.  
  
 Starting in Visual Studio 2015 Update 1, you can now use Edit and Continue in Windows Store C++ apps and DirectX apps, because it now supports the **/ZI** compiler switch with **/bigobj** switch. You can also use Edit  and Continue with binaries compiled with the **/FASTLINK** switch.  
  
 Other Update 1 improvements include a new, cancelable wait dialog, and notification when a file does not support Edit and Continue. For more information about Update 1 improvements, see [Improvements for C++ Edit and Continue in Visual Studio 2015 Update 1](http://blogs.msdn.com/b/vcblog/archive/2015/11/30/improvements-for-c-edit-and-continue-in-visual-studio-2015-update-1.aspx).  
  
 The [/Zo (Enhance Optimized Debugging)](/cpp/build/reference/zo-enhance-optimized-debugging) compiler option that was introduced in Visual Studio 2013 Update 3 adds additional information to .pdb (symbol) files for binaries compiled without the [/Od (Disable (Debug))](http://msdn.microsoft.com/library/aafb762y.aspx) option.  
  
 **/Zo** disables Edit and Continue. See [How to: Debug Optimized Code](../debugger/how-to-debug-optimized-code.md).  
  
##  <a name="BKMK_Enable_or_disable_automatic_invocation_of_Edit_and_Continue"></a> Enable or disable Edit and Continue  
 You may want to  disable the automatic invocation of Edit and Continue if you are making edits to the code that you do not want applied during the current debugging session. You can also re-enable automatic Edit and Continue.  
  
1.  On the **Tools** menu, choose **Options**.  
  
2.  In the **Options** dialog box, select **Debugging / General**.  
  
3.  In the **Edit and Continue** group, select or clear the **Enable Native Edit and Continue** check box.  
  
 Altering this setting affects all projects you work on. You do not need to rebuild your application after changing this setting. You can change the setting even while you are debugging. If you build your application from the command line or from a makefile, but you debug in the Visual Studio  environment, you can still use Edit and Continue if you set the **/ZI** option.  
  
##  <a name="BKMK_How_to_apply_code_changes_explicitly"></a> How to apply code changes explicitly  
 In Visual C++, Edit and Continue can apply code changes in two ways. Code changes can be applied implicitly, when you choose an execution command, or explicitly, using the **Apply Code Changes** command.  
  
 When you apply code changes explicitly, your program remains in break mode – no execution occurs.  
  
-   To apply code changes explicitly, on the **Debug** menu, choose **Apply Code Changes**.  
  
##  <a name="BKMK_How_to_stop_code_changes"></a> How to stop code changes  
 While Edit and Continue is in the process of applying code changes, you can stop the operation.  
  
 To stop applying code changes:  
  
-   On the **Debug** menu, choose **Stop Applying Code Changes**.  
  
 This menu item is visible only when code changes are being applied.  
  
 If you choose this option, none of the code changes are committed.  
  
##  <a name="BKMK_How_to_reset_the_point_of_execution"></a> How to reset the point of execution  
 Some code changes can cause the point of execution to move to a new location when Edit and Continue applies the changes. Edit and Continue places the point of execution as accurately as possible, but the results may not be correct in all cases.  
  
 In Visual C++, a dialog box informs you when the point of execution changes. You should verify that the location is correct before you continue debugging. If it is not correct, use the **Set Next Statement** command. For more information, see [Set the next statement to execute](http://msdn.microsoft.com/library/y740d9d3.aspx#BKMK_Set_the_next_statement_to_execute).  
  
##  <a name="BKMK_How_to_work_with_stale_code"></a> How to work with stale code  
 In some cases, Edit and Continue cannot apply code changes to the executable immediately, but might be able to apply the code changes later if you continue debugging. This happens if you edit a function that calls the current function or if you add more than 64 bytes of new variables to a function on the call stack  
  
 In such cases, the debugger continues executing the original code until the changes can be applied. The stale code appears as a temporary source file window in a separate source window, with a title such as `enc25.tmp`. The edited source continues to appear in the original source window. If you try to edit the stale code, a warning message appears.  
  
## See Also  
 [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md)