---
title: "IDebugGenericFieldDefinition::GetFormalTypeParams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetFormalTypeParams"
  - "IDebugGenericFieldDefinition::GetFormalTypeParams"
ms.assetid: cadbd6a1-bc7c-4aff-8777-5396b7a23c3e
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugGenericFieldDefinition::GetFormalTypeParams
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the type parameters given the number of parameters.  
  
## Syntax  
  
```cpp#  
HRESULT GetFormalTypeParams(  
   ULONG32                   cParams,  
   IDebugGenericParamField** ppParams,  
   ULONG32*                  pcParams  
);  
```  
  
```csharp  
int GetFormalTypeParams(  
   uint                          cParams,  
   out IDebugGenericParamField[] ppParams,  
   ref uint                      pcParams  
);  
```  
  
#### Parameters  
 `cParams`  
 [in] Number of parameters.  
  
 `ppParams`  
 [out] Array of type parameters.  
  
 `pcParams`  
 [in, out] Number of parameters in the `ppParams` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Return the type parameters in order from left to right. For example, Dictionary\<K,V> returns IDebugFormalGenericParameters {K,V}.  
  
## See Also  
 [IDebugGenericFieldDefinition](../../../extensibility/debugger/reference/idebuggenericfielddefinition.md)
