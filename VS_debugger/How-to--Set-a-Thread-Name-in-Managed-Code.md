---
title: "How to: Set a Thread Name in Managed Code"
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
ms.assetid: c0c4d74a-0314-4b71-81c9-b0b019347ab8
caps.latest.revision: 28
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
# How to: Set a Thread Name in Managed Code
Thread naming is possible in any edition of Visual Studio. Thread naming is useful for keeping track of threads in the **Threads** window. Because the **Threads** window is not available in the Visual Studio Express editions, thread naming has little utility in Express editions.  
  
 To set a thread name in managed code, use the <xref:System.Threading.Thread.Name?qualifyHint=False> property.  
  
## Example  
  
```  
Public Class Needle  
    ' This method will be called when the thread is started.  
    Sub Baz()  
        Console.WriteLine("Needle Baz is running on another thread")  
    End Sub  
End Class  
  
Sub Main()  
    Console.WriteLine("Thread Simple Sample")  
    Dim oNeedle As New Needle()  
   ' Create a Thread object.   
    Dim oThread As New System.Threading.Thread(AddressOf oNeedle.Baz)  
    ' Set the Thread name to "MainThread".  
    oThread.Name = "MainThread"  
    ' Starting the thread invokes the ThreadStart delegate  
    oThread.Start()  
End Sub  
```  
  
## See Also  
 [Debug Multithreaded Applications](../VS_debugger/Debug-Multithreaded-Applications-in-Visual-Studio.md)   
 [How to: Set a Thread Name in Native Code](../VS_debugger/How-to--Set-a-Thread-Name-in-Native-Code.md)