---
title: "CaptureCurrentFrame"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 4509311d-6fe2-4b65-9b4a-ff0522585d6a
caps.latest.revision: 5
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
# CaptureCurrentFrame
Captures the remainder of the current frame to the graphics log file.  
  
## Syntax  
  
```cpp  
void CaptureCurrentFrame();  
```  
  
## Remarks  
 If another capture is currently in progress—such as a capture that was started by the `BeginCapture` function—then that capture is completed and recorded to the graphics log as a distinct frame. Immediately afterwards, graphics diagnostics begins capturing the remainder of the current frame, which is also recorded as a distinct frame. The current frame's end is marked by a call to present.  
  
 To capture a frame, you must prepare your app to capture and record graphics information—that is, you must have called [Init](../debugger/init.md) through an instance of the `VsgDbg` class before you call `CaptureCurrentFrame`.  
  
## See Also  
 [Init](../debugger/init.md)   
 [BeginCapture](../debugger/begincapture.md)