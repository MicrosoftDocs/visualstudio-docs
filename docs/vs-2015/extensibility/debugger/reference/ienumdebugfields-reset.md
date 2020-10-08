---
title: "IEnumDebugFields::Reset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugFields::Reset"
helpviewer_keywords: 
  - "IEnumDebugFields::Reset method"
ms.assetid: 38ff61e4-0120-42e8-971a-16be6050b425
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugFields::Reset
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(void);  
```  
  
```csharp  
int Reset();  
```  
  
#### Parameters  
 None  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugfields-next.md) returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)   
 [Next](../../../extensibility/debugger/reference/ienumdebugfields-next.md)
