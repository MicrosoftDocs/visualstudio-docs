---
title: "IDebugSymbolProvider::GetClassTypeByName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugSymbolProvider::GetClassTypeByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetClassTypeByName method"
ms.assetid: 2c748909-51dc-49b7-b193-19f96fca1138
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolProvider::GetClassTypeByName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the class field type representing a fully qualified class name.  
  
## Syntax  
  
```cpp#  
HRESULT GetClassTypeByName(   
   LPCOLESTR          pszClassName,  
   NAME_MATCH         nameMatch,  
   IDebugClassField** ppField  
);  
```  
  
```csharp  
int GetClassTypeByName(  
   string               pszClassName,   
   NAME_MATCH           nameMatch,   
   out IDebugClassField ppField  
);  
```  
  
#### Parameters  
 `pszClassName`  
 [in] The class name.  
  
 `nameMatch`  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md) enumeration.  
  
 `ppField`  
 [out] Returns the class type as represented by the [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)   
 [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md)   
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
