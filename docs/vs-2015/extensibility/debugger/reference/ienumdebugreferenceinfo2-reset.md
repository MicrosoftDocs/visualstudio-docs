---
title: "IEnumDebugReferenceInfo2::Reset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugReferenceInfo2::Reset"
helpviewer_keywords: 
  - "IEnumDebugReferenceInfo2::Reset"
ms.assetid: cf8ce649-5ce1-44a6-9d5a-89760021bde4
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugReferenceInfo2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md)
