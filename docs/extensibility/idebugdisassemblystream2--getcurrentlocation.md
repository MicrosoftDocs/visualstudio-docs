---
title: "IDebugDisassemblyStream2::GetCurrentLocation"
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
  - "IDebugDisassemblyStream2::GetCurrentLocation"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetCurrentLocation"
ms.assetid: 512302f1-12b1-4107-8a6e-c5bc878ce1c3
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
# IDebugDisassemblyStream2::GetCurrentLocation
Returns a code location identifier that represents the current code location.  
  
## Syntax  
  
```cpp#  
HRESULT GetCurrentLocation(   
   UINT64* puCodeLocationId  
);  
```  
  
```c#  
int GetCurrentLocation(   
   out ulong puCodeLocationId  
);  
```  
  
#### Parameters  
 `puCodeLocationId`  
 [out] Returns the code location identifier. See the Remarks section for the [GetCodeLocationId](../extensibility/idebugdisassemblystream2--getcodelocationid.md) method for a description of a code location identifier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The code location identifier can be converted to a code context by calling the [GetCodeContext](../extensibility/idebugdisassemblystream2--getcodecontext.md) method.  
  
## See Also  
 [IDebugDocumentContext2](../extensibility/idebugdocumentcontext2.md)   
 [GetCodeLocationId](../extensibility/idebugdisassemblystream2--getcodelocationid.md)   
 [GetCodeContext](../extensibility/idebugdisassemblystream2--getcodecontext.md)