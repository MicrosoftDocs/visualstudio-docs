---
title: "IDebugGenericParamField::GetIndex | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugGenericParamField::GetIndex"
ms.assetid: 8e0bdb26-1247-44d9-8d80-ec6e35187fb4
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugGenericParamField::GetIndex
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the index of this generic parameter.  
  
## Syntax  
  
```cpp#  
HRESULT GetIndex(  
   DWORD* pIndex  
);  
```  
  
```csharp  
int GetIndex(  
   out uint pIndex  
);  
```  
  
#### Parameters  
 `pIndex`  
 [out] Index value of this generic parameter.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 For example, for Dictionary(K,V), K is index 0, V is index 1.  
  
## Example  
 The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md) interface.  
  
```cpp#  
HRESULT CDebugGenericParamFieldType::GetIndex(DWORD* pIndex)  
{  
    HRESULT hr = S_OK;  
  
    METHOD_ENTRY( CDebugGenericParamFieldType::GetIndex );  
  
    IfFalseGo(pIndex, E_INVALIDARG );  
    IfFailGo( this->LoadProps() );  
    *pIndex = m_index;  
  
Error:  
  
    METHOD_EXIT( CDebugGenericParamFieldType::GetIndex, hr );  
    return hr;  
}  
```  
  
## See Also  
 [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)
