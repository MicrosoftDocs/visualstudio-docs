---
title: "CONNECTION_PROTOCOL"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CONNECTION_PROTOCOL"
helpviewer_keywords: 
  - "CONNECTION_PROTOCOL enumeration"
ms.assetid: 99df5865-8b36-486d-9f4c-d10ae2bc688a
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# CONNECTION_PROTOCOL
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
  
```c#  
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
 These values are returned from the [GetConnectionProtocol](../extensibility/idebugcoreserver3--getconnectionprotocol.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [GetConnectionProtocol](../extensibility/idebugcoreserver3--getconnectionprotocol.md)