---
title: "How to: Get Back to the Function that Called MFC If Halted"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d254a5a9-afbd-4923-9d7a-7422d824cabf
caps.latest.revision: 18
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
# How to: Get Back to the Function that Called MFC If Halted
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 If you used the **Break** command on the **Debug** menu to halt the program and ended up in MFC, and you are sure the problem is in your code, you can use the Call Stack window to navigate back to your function. For more information, see [How to: Use the Call Stack Window](../VS_debugger/How-to--Use-the-Call-Stack-Window.md).  
  
 Sometimes your code may break in the message pump. In that case, there is no user code on the call stack. To avoid this problem, you can use breakpoints (possibly with conditions and hit counts) instead of the **Break** command. For more information, see [Breakpoints and Tracepoints](assetId:///fe4eedc1-71aa-4928-962f-0912c334d583)).  
  
### To navigate to the function from which MFC was called  
  
-   Use the **Call Stack** window.  
  
## See Also  
 [Debugging Native Code FAQs](../VS_debugger/Debugging-Native-Code-FAQs.md)   
 [Debugging Native Code](../VS_debugger/Debugging-Native-Code.md)