---
title: "IDebugEnumField::GetValueFromString | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEnumField::GetValueFromString"
helpviewer_keywords: 
  - "IDebugEnumField::GetValueFromString method"
ms.assetid: 1ef8ac5e-a3e0-4078-b876-7f5615aedcbb
caps.latest.revision: 7
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
# IDebugEnumField::GetValueFromString
This method returns the value associated with the name of an enumeration constant.  
  
## Syntax  
  
```cpp#  
HRESULT GetValueFromString(  
   LPCOLESTR  pszValue,  
   ULONGLONG* pvalue  
);  
```  
  
```c#  
int GetValueFromString(  
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
 This method is case-sensitive. If a case-insensitive search is needed (for example, in a language such as Visual Basic where names are not case sensitive), use [GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md).  
  
## See Also  
 [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)   
 [GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md)