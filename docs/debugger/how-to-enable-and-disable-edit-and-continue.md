---
title: "How to: Enable and disable Edit and Continue (C#, VB, C++) | Microsoft Docs"
ms.custom: ""
ms.date: "10/04/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
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
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "dotnet"
  - "cplusplus"
---
# How to: Enable and disable Edit and Continue (C#, VB, C++)

You can disable or enable **Edit and Continue** in the Visual Studio **Options** dialog box at design time. **Edit and Continue** works only in debug builds, but you can't enable or disable **Edit and Continue** while you're debugging. For more information, see [Edit and Continue](../debugger/edit-and-continue.md). 
  
For native C++, **Edit and Continue** requires using the `/INCREMENTAL` option. For more information about feature requirements in C++, see this [blog post](https://blogs.msdn.microsoft.com/vcblog/2016/07/01/c-edit-and-continue-in-visual-studio-2015-update-3/) and [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md).
  
**To enable or disable Edit and Continue:**  
  
1.  If you're in a debugging session, stop debugging (**Debug** > **Stop Debugging** or **Shift**+**F5**).

1.  In **Tools** > **Options** > **Debugging** (or **Debug** > **Options**), select **General**, and scroll down to **Edit and Continue** in the right pane.  
  
    - For managed code, select or deselect the **Enable Edit and Continue** check box. 
  
    > [!NOTE]
    >  If IntelliTrace is enabled and you collect both IntelliTrace events and call information, Edit and Continue is disabled. For more information, see [IntelliTrace](../debugger/intellitrace.md).
    
    - For C++:
      1. Select or deselect the **Enable Native Edit and Continue** check box.
      1. Set additional options:
         - **Apply changes on continue (Native only)**  
           
           If selected, Visual Studio automatically compiles and applies any outstanding code changes when continuing from a break state. If not selected, you can choose to apply changes using **Debug** > **Apply Code Changes**.  
           
         - **Warn about stale code (Native only)**  
           
           If selected, gives warnings about stale code. 
  
1.  Click **OK**.    
