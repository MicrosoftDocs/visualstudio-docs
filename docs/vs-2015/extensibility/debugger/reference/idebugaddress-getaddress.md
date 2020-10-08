---
title: "IDebugAddress::GetAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugAddress::GetAddress"
helpviewer_keywords: 
  - "IDebugAddress:GetAddress method"
ms.assetid: 2590387b-5d36-4116-9a75-737957b8898e
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugAddress::GetAddress
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns a structure describing an object and its location within its scope or container.  
  
## Syntax  
  
```cpp  
HRESULT GetAddress (  
   DEBUG_ADDRESS * pAddress  
);  
```  
  
```csharp  
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
