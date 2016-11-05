---
title: "How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window | Microsoft Docs"
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
caps.latest.revision: 19
author: "mikejo5000"
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
# How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window
If your code has native frames that are invisible in the **Call Stack** window, stepping out of managed code can produce unexpected results. As a workaround, you can use a breakpoint instead of **Step Out**.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To step out of managed code when native frames are missing from the call stack display  
  
1.  In the native code, set a location breakpoint after the call to managed code.  
  
2.  On the **Debug** menu, choose **Continue**.  
  
     When the managed call is completed, execution will stop at the breakpoint in native code.  
  
## See Also  
 [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md)