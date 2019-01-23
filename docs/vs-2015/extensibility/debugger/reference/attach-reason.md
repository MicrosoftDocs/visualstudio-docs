---
title: "ATTACH_REASON | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "ATTACH_REASON"
helpviewer_keywords: 
  - "ATTACH_REASON enumeration"
ms.assetid: 159fb70b-a344-4ba6-9115-b7eaa16e228f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# ATTACH_REASON
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the reason for the debug engine (DE) to attach to a program node.  
  
## Syntax  
  
```cpp#  
enum enum_ATTACH_REASON {   
   ATTACH_REASON_LAUNCH = 0x0001,  
   ATTACH_REASON_USER   = 0x0002,  
   ATTACH_REASON_AUTO   = 0x0003  
};  
typedef DWORD ATTACH_REASON;  
```  
  
```csharp  
public enum enum_ATTACH_REASON {   
   ATTACH_REASON_LAUNCH = 0x0001,  
   ATTACH_REASON_USER   = 0x0002,  
   ATTACH_REASON_AUTO   = 0x0003  
};  
```  
  
## Members  
 ATTACH_REASON_AUTO  
 Attach because the process is currently in debug mode.  
  
 ATTACH_REASON_LAUNCH  
 Attach because the process has been launched.  
  
 ATTACH_REASON_USER  
 Attach because of a user request.  
  
## Remarks  
 These values are used as a parameter to the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) and [Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)   
 [Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md)
