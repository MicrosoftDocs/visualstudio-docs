---
title: "IDebugProgram2::CanDetach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::CanDetach"
helpviewer_keywords: 
  - "IDebugProgram2::CanDetach"
ms.assetid: dcd9ab6c-49e5-447e-aa7c-89f571f4a052
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::CanDetach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines if a debug engine (DE) can detach from the program.  
  
## Syntax  
  
```cpp#  
HRESULT CanDetach(  
   void  
);  
```  
  
```csharp  
int CanDetach();  
```  
  
## Return Value  
 If can detach, returns `S_OK`; otherwise, returns an error code. Returns `S_FALSE` if the DE cannot detach from the program.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
