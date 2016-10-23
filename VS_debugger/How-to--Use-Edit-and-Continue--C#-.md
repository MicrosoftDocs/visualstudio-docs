---
title: "How to: Use Edit and Continue (C#)"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 40e136d8-a08c-43bd-b313-fb821c55eb3c
caps.latest.revision: 19
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
# How to: Use Edit and Continue (C#)
With Edit and Continue for C#, you can make changes to your code in break mode while debugging. The changes can be applied without having to stop and restart the debugging session.  
  
 Edit and Continue is invoked automatically when you make changes in break mode, then choose a debugger execution command, such as **Continue**, **Step**, or **Set Next Statement**, or evaluate a function in a debugger window.  
  
> [!NOTE]
>  Edit and Continue is not supported when debugging the Compact Framework, optimized code, mixed native/managed code, or SQL Server common language runtime (CLR) integration code. If you try to apply code changes in one of these scenarios, the debugger puts up a dialog box explaining that Edit and Continue is not supported.  
  
### To invoke Edit and Continue automatically  
  
1.  In break mode, make a change to your source code.  
  
2.  From the **Debug** menu, click **Continue**, **Step**, or **Set Next Statement** or evaluate a function in a debugger window.  
  
     The new code is compiled and the debugging continues with the new code. Some changes are not supported by Edit and Continue. For more information, see [Supported Code Changes (C#)](../VS_debugger/Supported-Code-Changes--C#-.md).  
  
### To enable/disable Edit and Continue  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  In the **Options** dialog box, expand the **Debugging** node, and select **Edit and Continue**.  
  
3.  In the **Options** dialog box **Edit and Continue** page, select or clear the **Enable Edit and Continue** check box.  
  
     The setting takes effect when you restart the debugging session.  
  
## See Also  
 [Edit and Continue (Visual C#)](../VS_debugger/Edit-and-Continue--Visual-C#-.md)   
 [Supported Code Changes (C#)](../VS_debugger/Supported-Code-Changes--C#-.md)   
 [Edit and Continue Errors and Warnings (C#)](../VS_not_in_toc/Edit-and-Continue-Errors-and-Warnings--C#-.md)