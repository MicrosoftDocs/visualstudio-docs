---
title: "ISimpleConnectionPoint::GetEventCount | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISimpleConnectionPoint.GetEventCount"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "ISimpleConnectionPoint::GetEventCount"
ms.assetid: f1527d5b-6076-4536-8e59-e55da741ef39
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISimpleConnectionPoint::GetEventCount
Returns the number of events exposed on this interface.  
  
## Syntax  
  
```cpp
HRESULT GetEventCount(  
   ULONG*  pulCount  
);  
```  
  
#### Parameters  
 `pulCount`  
 [out] Number of events exposed on this interface count.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the number of events exposed on this interface.  
  
## See also  
 [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)