---
title: "IDebugGenericFieldDefinition::TypeParamCount | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "TypeParamCount"
  - "IDebugGenericFieldDefinition::TypeParamCount"
ms.assetid: d41dd5ea-aa25-4bf3-bcfd-e0bf451ead49
caps.latest.revision: 8
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugGenericFieldDefinition::TypeParamCount
Retrieves the number of type parameters that are associated with the generic field.  
  
## Syntax  
  
```cpp  
HRESULT TypeParamCount(  
   ULONG32* pcParams  
);  
```  
  
```csharp  
int TypeParamCount(  
   ref uint pcParams  
);  
```  
  
#### Parameters  
 `pcParams`  
 [in, out] Number of type parameters.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If List\<T>, this method returns 1, and, if List\<T1,T2>, this method returns 2. This method returns 0 if there are no type parameters.  
  
## See Also  
 [IDebugGenericFieldDefinition](../../../extensibility/debugger/reference/idebuggenericfielddefinition.md)