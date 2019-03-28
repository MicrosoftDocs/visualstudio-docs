---
title: "IDebugEnumField::GetValueFromStringCaseInsensitive | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEnumField::GetValueFromStringCaseInsensitive"
helpviewer_keywords: 
  - "IDebugEnumField::GetValueFromStringCaseInsensitive method"
ms.assetid: ef95b38e-d9b2-4fb5-a166-7c2e14641dc7
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugEnumField::GetValueFromStringCaseInsensitive
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method uses a case-insensitive search to return the value associated with the name of an enumeration constant.  
  
## Syntax  
  
```cpp#  
HRESULT GetValueFromStringCaseInsensitive(  
   LPCOLESTR  pszValue,  
   ULONGLONG* pvalue  
);  
```  
  
```csharp  
int GetValueFromStringCaseInsensitive(  
   string    pszValue,   
   out ulong pValue  
);  
```  
  
#### Parameters  
 `pszValue`  
 [in] A string specifying the name for which to get the value. Note that for C++, this is a wide character string.  
  
 `pValue`  
 [out] Returns the associated numerical value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE`, if the name is not part of the enumeration, or an error code.  
  
## Remarks  
 This method is case-insensitive. If a case-sensitive search is needed (for example, in a language such as C++ where names are case-sensitive), use [GetValueFromString](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstring.md).  
  
## See Also  
 [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)   
 [GetValueFromString](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstring.md)
