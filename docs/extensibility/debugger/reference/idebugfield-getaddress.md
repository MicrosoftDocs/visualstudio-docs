---
title: "IDebugField::GetAddress | Microsoft Docs"
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
  - "IDebugField::GetAddress"
helpviewer_keywords: 
  - "IDebugField::GetAddress method"
ms.assetid: 6981bf03-66ef-4bf9-87ea-f6c9624486cb
caps.latest.revision: 11
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
# IDebugField::GetAddress
This method gets the debug address of a field.  
  
## Syntax  
  
```cpp#  
HRESULT GetAddress(   
   IDebugAddress** ppAddress  
);  
```  
  
```c#  
int GetAddress(  
   out IDebugAddress ppAddress  
);  
```  
  
#### Parameters  
 `ppAddress`  
 [out] Returns the address as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, return an error code.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)