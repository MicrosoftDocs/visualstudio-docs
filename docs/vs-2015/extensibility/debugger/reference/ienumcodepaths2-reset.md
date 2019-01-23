---
title: "IEnumCodePaths2::Reset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumCodePaths2::Reset"
helpviewer_keywords: 
  - "IEnumCodePaths2::Reset"
ms.assetid: 490c0e19-ff4b-4673-bd06-cdee996ac226
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IEnumCodePaths2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumcodepaths2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md)
