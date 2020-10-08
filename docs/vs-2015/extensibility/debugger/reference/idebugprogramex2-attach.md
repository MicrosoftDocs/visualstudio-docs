---
title: "IDebugProgramEx2::Attach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramEx2::Attach"
helpviewer_keywords: 
  - "IDebugProgramEx2::Attach"
ms.assetid: 33b22b2f-431e-4205-9441-d28a9c928c97
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramEx2::Attach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Attach a session to a program.  
  
## Syntax  
  
```cpp#  
HRESULT Attach(   
   IDebugEventCallback2* pCallback,  
   DWORD                 dwReason,  
   IDebugSession2*       pSession  
);  
```  
  
```  
[C#]  
int Attach(   
   IDebugEventCallback2 pCallback,  
   uint                 dwReason,  
   IDebugSession2       pSession  
);  
```  
  
#### Parameters  
 `pCallback`  
 [in] An [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) object that represents the callback function that the attached debug engine sends events to.  
  
 `dwReason`  
 [in] A value from the [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md) enumeration that describes the reason for the attach operation.  
  
 `pSession`  
 [in] A value that uniquely identifies the session that is attaching to the program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code. This method should return `E_ATTACH_DEBUGGER_ALREADY_ATTACHED` if the program is already attached.  
  
## Remarks  
 The port that contains the program can use the value in `pSession` to determine which session is attempting to attach to the program. For example, if a port allows only one debug session to attach to a process at a time, the port can determine if the same session is already attached to other programs in the process.  
  
> [!NOTE]
> The interface passed in `pSession` is to be treated only as a cookie, a value that uniquely identifies the session debug manager attaching to this program; none of the methods on the supplied interface are functional.  
  
## See Also  
 [IDebugProgramEx2](../../../extensibility/debugger/reference/idebugprogramex2.md)
