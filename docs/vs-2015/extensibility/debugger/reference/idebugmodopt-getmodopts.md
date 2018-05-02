---
title: "IDebugModOpt::GetModOpts | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugModOpt::GetModOpts"
  - "GetModOpts"
ms.assetid: cb513fa9-d521-4a65-b968-f55f53a368df
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugModOpt::GetModOpts
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugModOpt::GetModOpts](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugmodopt-getmodopts).  
  
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

