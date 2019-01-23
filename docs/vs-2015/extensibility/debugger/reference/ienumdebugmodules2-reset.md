---
title: "IEnumDebugModules2::Reset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugModules2::Reset"
helpviewer_keywords: 
  - "IEnumDebugModules2::Reset"
ms.assetid: f6ff364c-2644-4919-b950-3cb82eb6f601
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugModules2::Reset
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(  
   void  
);  
```  
  
```csharp  
int Reset();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugmodules2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
