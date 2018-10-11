---
title: "IEnumDebugObjects::GetCount | Microsoft Docs"
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
  - "IEnumDebugObjects::GetCount"
helpviewer_keywords: 
  - "IEnumDebugObjects::GetCount method"
ms.assetid: 9cbc5db4-03ae-479f-a664-13cad66ad210
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugObjects::GetCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugObjects::GetCount](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugobjects-getcount).  
  
This method returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetCount(  
   [out] ULONG* pcelt  
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
 This method is not part of the customary COM enumeration interface which specifies that only Next, Clone, Skip, and Reset need to be implemented.  
  
## See Also  
 [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)

