---
title: "IDebugSymbolProvider::GetMethodFieldsByName"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugSymbolProvider::GetMethodFieldsByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetMethodFieldsByName method"
ms.assetid: 1f781320-81ef-4037-b068-f1864b271258
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugSymbolProvider::GetMethodFieldsByName
This method gets the field representing a fully qualified method name.  
  
## Syntax  
  
```cpp#  
HRESULT GetMethodFieldsByName(   
   LPCOLESTR          pszFullName,  
   NAME_MATCH         nameMatch,  
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int GetMethodFieldsByName(  
   string               pszFullName,   
   NAME_MATCH           nameMatch,   
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `pszFullName`  
 [in] The method name.  
  
 `nameMatch`  
 [in] Selects the type of match, for example, case-sensitive.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../extensibility/ienumdebugfields.md) enumerator for the fields associated with this method.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A method can be associated with multiple fields if it is overloaded, for example.  
  
## See Also  
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)   
 [IEnumDebugFields](../extensibility/ienumdebugfields.md)