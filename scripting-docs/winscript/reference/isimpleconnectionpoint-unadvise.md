---
title: "ISimpleConnectionPoint::Unadvise | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISimpleConnectionPoint.Unadvise"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "ISimpleConnectionPoint::Unadvise"
ms.assetid: eae06a58-ed42-4839-aad4-14420b15343f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISimpleConnectionPoint::Unadvise
Terminates an advisory connection previously established through `ISimpleConnectionPoint::Advise`.  
  
## Syntax  
  
```cpp
HRESULT Unadvise(  
   DWORD  dwCookie  
);  
```  
  
#### Parameters  
 `dwCookie`  
 [in] Token of the connection to terminate, as returned from `ISimpleConnectionPoint::Advise`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 When an advisory connection is terminated, the connection point calls the `Release` method on the pointer that was saved for the connection during the `ISimpleConnectionPoint::Advise` method. That call reverses the `AddRef` that was performed during the `ISimpleConnectionPoint::Advise` when the connection point calls the advisory sink's `QueryInterface`.  
  
## See also  
 [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)