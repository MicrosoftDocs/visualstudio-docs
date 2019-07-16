---
title: "IDebugProcess2::Detach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess2::Detach"
helpviewer_keywords: 
  - "IDebugProcess2::Detach"
ms.assetid: ee2b9084-2db1-4e49-a1d9-387284b7c3f8
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess2::Detach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Detaches the debugger from this process by detaching all of the programs in the process.  
  
## Syntax  
  
```cpp#  
HRESULT Detach(   
   void   
);  
```  
  
```csharp  
int Detach();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 All programs and the process continue running, but are no longer part of the debug session. After the detach operation is complete, no more debug events for this process (and its programs) will be sent.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
