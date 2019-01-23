---
title: "IDebugEngine2::SetException | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine2::SetException"
helpviewer_keywords: 
  - "IDebugEngine2::SetException"
ms.assetid: e6f5ec48-09e8-4b9b-9dc9-55f8d883f1b7
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine2::SetException
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies how the debug engine (DE) should handle a given exception.  
  
## Syntax  
  
```cpp#  
HRESULT SetException(   
   EXCEPTION_INFO* pException  
);  
```  
  
```csharp  
int SetException(   
   EXCEPTION_INFO[] pException  
);  
```  
  
#### Parameters  
 `pException`  
 [in] An [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) structure that describes the exception and how to debug it.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A DE could be instructed to stop the program generating an exception at first chance, second chance, or not at all.  
  
## See Also  
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)   
 [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md)
