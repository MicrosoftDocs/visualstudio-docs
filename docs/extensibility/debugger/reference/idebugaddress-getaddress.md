---
title: "IDebugAddress::GetAddress | Microsoft Docs"
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
  - "IDebugAddress::GetAddress"
helpviewer_keywords: 
  - "IDebugAddress:GetAddress method"
ms.assetid: 2590387b-5d36-4116-9a75-737957b8898e
caps.latest.revision: 6
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
# IDebugAddress::GetAddress
Returns a structure describing an object and its location within its scope or container.  
  
## Syntax  
  
```cpp  
HRESULT GetAddress (  
   DEBUG_ADDRESS * pAddress  
);  
```  
  
```c#  
int GetAddress(  
   DEBUG_ADDRESS[] pAddress  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in, out] A [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure that is filled in by this method.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure is passed to this method, which then fills it in with the appropriate information. How this information is interpreted depends on the kind of information returned and the symbol handler itself. See [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) for more details.  
  
## See Also  
 [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)