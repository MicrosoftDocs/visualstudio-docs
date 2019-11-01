---
title: "IObjectIdentity::IsEqualObject | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IObjectIdentity.IsEqualObject"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IsEqualObject method"
ms.assetid: 78c5c5c2-d299-4036-986c-7c1d87cbe7cd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IObjectIdentity::IsEqualObject
Determines if an object is equal to the current object.  
  
## Syntax  
  
```cpp
HRESULT IsEqualObject(  
  IUnknown*punk  
);  
```  
  
#### Parameters  
 `punk`  
 [in] Address of the object to compare with the current object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The objects are equal.|  
|`S_FALSE`|The objects are not equal.|  
  
## Remarks  
 An implementation of the `IsEqualObject` method should return `S_OK` only if the objects are identical.  
  
## See also  
 [IObjectIdentity Interface](../../winscript/reference/iobjectidentity-interface.md)