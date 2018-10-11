---
title: "IEnumDebugPorts2::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugPorts2::Reset"
helpviewer_keywords: 
  - "IEnumDebugPorts2::Reset"
ms.assetid: 67da406c-eadb-421e-ae12-e26e9866f262
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugPorts2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugports2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)

