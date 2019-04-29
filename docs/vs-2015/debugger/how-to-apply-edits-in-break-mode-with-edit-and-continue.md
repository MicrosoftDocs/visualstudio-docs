---
title: "How to: Apply Edits in Break Mode with Edit and Continue | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.variables.failededit"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
helpviewer_keywords: 
  - "Edit and Continue [Visual Basic], applying edits in break mode"
  - "break mode, applying code changes"
  - "Edit and Continue, applying edits in break mode"
  - "editing, break mode"
  - "coding, editing in break mode"
  - "code, editing in break mode"
ms.assetid: 1eef7498-6a1f-4fba-8146-510adc6375c9
caps.latest.revision: 33
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Apply Edits in Break Mode with Edit and Continue
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use Edit and Continue to edit your code in Break mode, and then continue without stopping and restarting execution.  
  
 Edit and Continue is not available in the following debugging scenarios:  
  
- Mixed-mode (native/managed) debugging.  
  
- SQL debugging.  
  
- Debugging a Dr. Watson dump.  
  
- Editing code after an unhandled exception, when the **Unwind the call stack on unhandled exceptions** option is not selected.  
  
- Debugging an embedded runtime application.  
  
- Debugging an application with **Attach to** rather than running the application with **Start** from the **Debug** menu.  
  
- Debugging optimized code.  
  
- Debugging managed code when the target is a 64-bit application. If you want to use Edit and Continue, you must set the target to x86. (_Project_**Properties**, **Compile** tab, **Advanced Compiler** setting.).  
  
- Debugging an old version of your code after a new version failed to build due to build errors.  
  
### To edit code in Break mode  
  
1. Enter Break mode by doing one of the following:  
  
    - Set a breakpoint in your code, then choose **Start Debugging** from the **Debug** menu and wait for the application to hit the breakpoint.  
  
         –or–  
  
    - Start debugging, and then select **Break All** from the **Debug** menu.  
  
         –or–  
  
    - When an exception occurs, choose **Enable Editing** on the**Exception Assistant**.  
  
2. Make any desired and legal code changes.  
  
     For more information, see [Unsupported Edits in Visual Basic Edit and Continue](../debugger/unsupported-edits-in-visual-basic-edit-and-continue.md).  
  
    > [!NOTE]
    > If you attempt to make a code change that is not allowed by Edit and Continue, your edit will be underlined by a purple wavy line and a task will appear in the Task List. You will not be able to continue code execution unless you undo the illegal code change.  
  
3. On the **Debug** menu, click **Continue** to resume execution.  
  
     Your code now executes with your applied edits incorporated into the project.  
  
## See Also  
 [Unsupported Edits in Visual Basic Edit and Continue](../debugger/unsupported-edits-in-visual-basic-edit-and-continue.md)   
 [Edit and Continue (Visual Basic)](../debugger/edit-and-continue-visual-basic.md)
