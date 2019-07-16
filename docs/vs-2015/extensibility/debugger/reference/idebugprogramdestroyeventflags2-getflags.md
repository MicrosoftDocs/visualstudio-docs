---
title: "IDebugProgramDestroyEventFlags2::GetFlags | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetFlags"
  - "IDebugProgramDestroyEventFlags2::GetFlags"
ms.assetid: dd53bd0c-459a-4077-ba81-780defb71e87
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramDestroyEventFlags2::GetFlags
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the program destroy flags.  
  
## Syntax  
  
```cpp#  
HRESULT GetFlags(  
   PROGRAM_DESTROY_FLAGS* pdwFlags  
);  
```  
  
```csharp  
public int GetFlags(  
   out enum_PROGRAM_DESTROY_FLAGS pdwFlags  
);  
```  
  
#### Parameters  
 `pdwFlags`  
 [out] Represents the program destroy flags.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramDestroyEventFlags2](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2.md)   
 [PROGRAM_DESTROY_FLAGS](../../../extensibility/debugger/reference/program-destroy-flags.md)
