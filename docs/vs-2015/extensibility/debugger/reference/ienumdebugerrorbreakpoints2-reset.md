---
title: "IEnumDebugErrorBreakpoints2::Reset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugErrorBreakpoints2::Reset"
helpviewer_keywords: 
  - "IEnumDebugErrorBreakpoints2::Reset"
ms.assetid: d5b04bba-a8b9-4141-94fb-250c77f0534c
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugErrorBreakpoints2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md)
