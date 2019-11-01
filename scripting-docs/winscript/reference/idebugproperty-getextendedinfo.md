---
title: "IDebugProperty::GetExtendedInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugProperty.GetExtendedInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugProperty::GetExtendedInfo"
ms.assetid: a989ade5-16d5-4ee6-8d8a-8dcbfad24034
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty::GetExtendedInfo
Gets extended information for the property.  
  
## Syntax  
  
```cpp
HRESULT GetExtendedInfo (  
   ULONG  cInfos,  
   GUID*  rgguidExtendedInfo,  
   VARIANT* pExtendedInfo  
);  
```  
  
#### Parameters  
 `cInfos`  
 [in] Count of extended information objects.  
  
 `rgguidExtendedInfo`  
 [in] An array of `GUID`s is passed so that multiple items of extended info can be retrieved at the same time.  
  
 `pExtendedInfo`  
 [out] Returns an array of `VARIANT`s that can be used to retrieve the extended property information.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## Remarks  
 This interface gets extended info for this object. The API exists only for the purpose of retrieving info that does not lend itself to being retrieved by the use of `IDebugProperty::GetPropertyInfo`).  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)