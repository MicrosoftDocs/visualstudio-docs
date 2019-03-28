---
title: "CONNECTION_PROTOCOL | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "CONNECTION_PROTOCOL"
helpviewer_keywords: 
  - "CONNECTION_PROTOCOL enumeration"
ms.assetid: 99df5865-8b36-486d-9f4c-d10ae2bc688a
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# CONNECTION_PROTOCOL
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Indicates the protocol being used to communicate between a debug server and the debug package (DE).  
  
## Syntax  
  
```cpp  
typedef enum tagCONNECTION_PROTOCOL {  
   CONNECTION_NONE    = 0,  
   CONNECTION_UNKNOWN = 1,  
   CONNECTION_LOCAL   = 2,  
   CONNECTION_PIPE    = 3,  
   CONNECTION_TCPIP   = 4,  
   CONNECTION_HTTP    = 5,  
   CONNECTION_OTHER   = 6  
} CONNECTION_PROTOCOL;  
```  
  
```csharp  
public enum CONNECTION_PROTOCOL {  
   CONNECTION_NONE    = 0,  
   CONNECTION_UNKNOWN = 1,  
   CONNECTION_LOCAL   = 2,  
   CONNECTION_PIPE    = 3,  
   CONNECTION_TCPIP   = 4,  
   CONNECTION_HTTP    = 5,  
   CONNECTION_OTHER   = 6  
};  
```  
  
#### Parameters  
 CONNECTION_NONE  
 No connection has been made to a server.  
  
 CONNECTION_UNKNOWN  
 A connection has been made, but it is of an unknown type.  
  
 CONNECTION_LOCAL  
 Connection is to a local server.  
  
 CONNECTION_PIPE  
 Connection is through a named pipe.  
  
 CONNECTION_TCPIP  
 Connection uses TCP/IP.  
  
 CONNECTION_HTTP  
 Connection uses HTTP (through a Web server).  
  
 CONNECTION_OTHER  
 Some other type of connection has been established (this value is not currently used).  
  
## Remarks  
 These values are returned from the [GetConnectionProtocol](../../../extensibility/debugger/reference/idebugcoreserver3-getconnectionprotocol.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [GetConnectionProtocol](../../../extensibility/debugger/reference/idebugcoreserver3-getconnectionprotocol.md)
