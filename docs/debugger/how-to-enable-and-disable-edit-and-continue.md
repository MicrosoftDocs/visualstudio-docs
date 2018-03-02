---
title: "How to: Enable and Disable Edit and Continue (C#, VB, C++) | Microsoft Docs"
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
  - "/INCREMENTAL linker option"
  - "Apply Code Changes command"
  - "Edit and Continue, disabling"
  - "code changes, applying in break mode"
  - "INCREMENTAL linker option"
  - "Edit and Continue, enabling"
  - "break mode, applying code changes"
  - "Edit and Continue, applying code changes"
  - "Step command"
  - "Go command"
ms.assetid: fd961a1c-76fa-420d-ad8f-c1a6c003b0db
caps.latest.revision: 26
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "dotnet"
  - "cplusplus"
---
# How to: Enable and Disable Edit and Continue (C#, VB, C++)
You can disable or enable Edit and Continue in the **Options** dialog box at design time. You cannot change this setting while you are debugging.  
  
Edit and Continue works only in debug builds. For native C++, Edit and Continue requires using the /INCREMENTAL option. For more information about feature requirements in C++, see this [blog post](https://blogs.msdn.microsoft.com/vcblog/2016/07/01/c-edit-and-continue-in-visual-studio-2015-update-3/) and [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md).
  
#### To enable/disable Edit and Continue  
  
1.  If you are in a debugging session, stop debugging (**Shift + F5**).

2.  Open debugging options page (**Tools > Options > Debugging**).
  
3.  Select **General**, and scroll down to **Edit and Continue** category (right pane).  
  
4.  To enable, select the **Enable Edit and Continue** check box. To disable, clear the check box.  
  
    > [!NOTE]
    >  If IntelliTrace is enabled and you collect both IntelliTrace events and call information, Edit and Continue is disabled. For more information, see [IntelliTrace](../debugger/intellitrace.md).

5. (C++) To enable, select **Enable Native Edit and Continue**. To disable, clear the check box.

6. (C++) Set additional options for native code.

    - **Apply changes on continue (Native only)**  
        Visual Studio automatically compiles and applies any outstanding code changes you have made when continuing the process from a break state. If not selected, you can choose to apply changes using the "Apply Code Changes" item under the Debug menu.  
  
    - **Warn about stale code (Native only)**  
        Get warnings about stale code. 
  
7.  Click **OK**.    
  
## See Also  
 [Edit and Continue](../debugger/edit-and-continue.md)