---
title: "IDebugGenericFieldInstance::TypeArgumentCount | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "TypeArgumentCount"
  - "IDebugGenericFieldInstance::TypeArgumentCount"
ms.assetid: e662c5ea-a5c1-478e-a268-5980dadffcd1
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugGenericFieldInstance::TypeArgumentCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns the number of type parameter arguments for this instance.  
  
## Syntax  
  
```cpp#  
HRESULT TypeArgumentCount(  
   ULONG32* pcArgs  
);  
```  
  
```csharp  
int TypeArgumentCount(  
   ref uint pcArgs  
);  
```  
  
#### Parameters  
 `pcArgs`  
 [in, out] Number of type parameter arguments for this instance.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 For example, if List\<int>, this method returns 1, and, if List\<int,float2> this method returns 2. This method returns 0 if there are no type arguments.  
  
## See Also  
 [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)
