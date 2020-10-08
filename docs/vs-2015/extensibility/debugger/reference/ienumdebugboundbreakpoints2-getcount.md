---
title: "IEnumDebugBoundBreakpoints2::GetCount | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugBoundBreakpoints2::GetCount"
helpviewer_keywords: 
  - "IEnumDebugBoundBreakpoints2::GetCount"
ms.assetid: 5a572eeb-beb7-4fc7-8259-792d277069be
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugBoundBreakpoints2::GetCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetCount(  
   ULONG* pcelt  
);  
```  
  
```csharp  
int GetCount(  
   out uint pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of elements in the enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.  
  
## See Also  
 [IEnumDebugBoundBreakpoints2](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md)
