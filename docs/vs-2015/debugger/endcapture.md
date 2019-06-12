---
title: "EndCapture | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 06084c3b-e065-49b6-968e-d578762fb871
caps.latest.revision: 9
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# EndCapture
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Ends a capture interval that was started with `BeginCapture`.  
  
## Syntax  
  
```cpp  
void EndCapture();  
```  
  
## Remarks  
 A capture interval typically spans a subset of one frame, such as when you want to capture graphics information only about a certain kind of draw call. If the capture interval spans a call to present, then two frames of graphics information are captured. The first frame spans the interval between the call to `BeginCapture` and the call to present; the second frame spans the interval between the first Direct3D event after the call to present and the call to `EndCapture`.  
  
 To capture an interval, you must prepare your app to capture and record graphics information—that is, you must have called [Init](../debugger/init.md) through an instance of the `VsgDbg` class before you call `BeginCapture` or `EndCapture`.  
  
## See Also  
 [BeginCapture](../debugger/begincapture.md)   
 [CaptureCurrentFrame](../debugger/capturecurrentframe.md)
