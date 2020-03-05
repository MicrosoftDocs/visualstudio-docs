---
title: "How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "SQL"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Call Stack window, missing native frames"
  - "code, managed code"
  - "native frames"
  - "stepping, out of managed code"
  - "managed code, stepping out of"
ms.assetid: 97cdd2a8-02a9-4a06-a5b1-c92b1e431979
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If your code has native frames that are invisible in the **Call Stack** window, stepping out of managed code can produce unexpected results. As a workaround, you can use a breakpoint instead of **Step Out**.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To step out of managed code when native frames are missing from the call stack display  
  
1. In the native code, set a location breakpoint after the call to managed code.  
  
2. On the **Debug** menu, choose **Continue**.  
  
     When the managed call is completed, execution will stop at the breakpoint in native code.  
  
## See Also  
 [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md)
