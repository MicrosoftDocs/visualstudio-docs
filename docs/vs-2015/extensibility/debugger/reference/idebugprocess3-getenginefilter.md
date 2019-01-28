---
title: "IDebugProcess3::GetEngineFilter | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetEngineFilter"
  - "IDebugProcess3::GetEngineFilter"
ms.assetid: ccb7ecb0-f189-4e80-b5b2-221a095e01f5
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess3::GetEngineFilter
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves an array of unique identifiers for available debug engines.  
  
## Syntax  
  
```cpp#  
HRESULT GetEngineFilter(  
   GUID_ARRAY *pEngineArray  
);  
```  
  
```csharp  
public int GetEngineFilter(  
   out GUID_ARRAY[] pEngineArray  
);  
```  
  
#### Parameters  
 `pEngineArray`  
 [out] Reference to a structure that contains unique identifiers for debug engines.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)   
 [GUID_ARRAY](../../../extensibility/debugger/reference/guid-array.md)
