---
title: "IDebugModOpt::GetModOpts | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugModOpt::GetModOpts"
  - "GetModOpts"
ms.assetid: cb513fa9-d521-4a65-b968-f55f53a368df
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugModOpt::GetModOpts
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves a list of optional modifiers.  
  
## Syntax  
  
```cpp#  
HRESULT GetModOpts(  
   ULONG  celt,  
   BSTR*  rgelt,  
   ULONG* pceltFetched  
);  
```  
  
```csharp  
int GetModOpts(  
   uint         celt,  
   out string[] rgelt,  
   ref uint     pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of elements to be returned.  
  
 `rgelt`  
 [out] Returns an array that contains the options.  
  
 `pceltFetched`  
 [in, out] Number of elements returned in the `rgelt` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugModOpt](../../../extensibility/debugger/reference/idebugmodopt.md)
