---
title: "How to: Debug COM Clients and Servers Using RPC Debugging"
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
ms.assetid: 3e8526c8-43b5-4b87-8e0d-b22c24f0a3ea
caps.latest.revision: 23
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
# How to: Debug COM Clients and Servers Using RPC Debugging
You can use remote procedure call (RPC) debugging to debug COM client/server applications. You must enable RPC debugging to use it. With RPC debugging enabled, when you step into the server call from the client, the debugger attaches to the server and lets you debug its code. When the debugger is attached, you can use all debugger features with both the client and server processes.  
  
### To enable RPC debugging  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  In the **Options** dialog box, click the **Debugging** folder.  
  
3.  Click the **Native** page.  
  
4.  Select the **RPC debugging** check box.  
  
    > [!NOTE]
    >  To debug RPC calls, you must have Administrator or Power User privileges.  
  
    > [!NOTE]
    >  RPC stepping into a remote server that runs Microsoft Windows Vista will work only if a native debugger is attached to the remote server. Otherwise, the RPC call will fail without an error message. Otherwise the RPC call will complete, but the step-into the RPC call will not work.  
  
## See Also  
 [COM Server and Container Debugging](../VS_debugger/COM-Server-and-Container-Debugging.md)   
 [Debugging in Visual Studio](../VS_debugger/Debugging-in-Visual-Studio.md)