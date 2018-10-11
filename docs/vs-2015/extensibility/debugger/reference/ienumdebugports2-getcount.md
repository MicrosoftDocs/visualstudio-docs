---
title: "IEnumDebugPorts2::GetCount | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugPorts2::GetCount"
helpviewer_keywords: 
  - "IEnumDebugPorts2::GetCount"
ms.assetid: d714455c-e4fc-48dc-a6d4-7e8b5d7c1bce
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugPorts2::GetCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugPorts2::GetCount](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugports2-getcount).  
  
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
 [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)

