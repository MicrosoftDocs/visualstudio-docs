---
title: "IDebugDisassemblyStream2::GetCodeContext"
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
  - "IDebugDisassemblyStream2::GetCodeContext"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetCodeContext"
ms.assetid: a6d0ae82-7617-4915-9713-369abe3e2e53
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
# IDebugDisassemblyStream2::GetCodeContext
Returns a code context object corresponding to a specified code location identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetCodeContext(   
   UINT64               uCodeLocationId,  
   IDebugCodeContext2** ppCodeContext  
);  
```  
  
```c#  
int GetCodeContext(   
   ulong                  uCodeLocationId,  
   out IDebugCodeContext2 ppCodeContext  
);  
```  
  
#### Parameters  
 `uCodeLocationId`  
 [in] Specifies the code location identifier. See the Remarks section for the [GetCodeLocationId](../extensibility/idebugdisassemblystream2--getcodelocationid.md) method for a description of a code location identifier.  
  
 `ppCodeContext`  
 [out] Returns an [IDebugCodeContext2](../extensibility/idebugcodecontext2.md) object that represents the associated code context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The code location identifier can be returned from a call to the [GetCurrentLocation](../extensibility/idebugdisassemblystream2--getcurrentlocation.md) method and can appear in the [DisassemblyData](../extensibility/disassemblydata.md) structure.  
  
 To convert a code context into a code location identifier, call the [GetCodeLocationId](../extensibility/idebugdisassemblystream2--getcodelocationid.md) method.  
  
## See Also  
 [IDebugDisassemblyStream2](../extensibility/idebugdisassemblystream2.md)   
 [IDebugCodeContext2](../extensibility/idebugcodecontext2.md)   
 [GetCodeLocationId](../extensibility/idebugdisassemblystream2--getcodelocationid.md)   
 [GetCurrentLocation](../extensibility/idebugdisassemblystream2--getcurrentlocation.md)   
 [DisassemblyData](../extensibility/disassemblydata.md)