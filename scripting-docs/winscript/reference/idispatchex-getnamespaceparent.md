---
title: "IDispatchEx::GetNameSpaceParent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.GetNameSpaceParent"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "GetNameSpaceParent method"
ms.assetid: 0b077d39-2fd6-4390-8cd5-128d9b8dc90c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::GetNameSpaceParent
Retrieves the interface for the namespace parent of an object.  
  
## Syntax  
  
```cpp
HRESULT GetNameSpaceParent(  
   IUnknown **ppunk  
);  
```  
  
#### Parameters  
 `ppunk`  
 Address of an `IUnknown` interface pointer that receives the namespace parent's interface.  
  
## Return Value  
 Returns `S_OK` if successful or an OLE-defined error code otherwise.  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)