---
title: "IDebugProperty::GetParent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugProperty.GetParent"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugProperty::GetParent"
ms.assetid: 673d625b-acca-45c4-88f4-b72275042f8f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty::GetParent
Gets the parent property of a property.  
  
## Syntax  
  
```cpp
HRESULT GetParent (  
   IDebugProperty** ppParent  
);  
```  
  
#### Parameters  
 `ppParent`  
 [out] Returns the `IDebugProperty` interface that represents the parent of the property.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)