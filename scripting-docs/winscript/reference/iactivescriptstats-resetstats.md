---
title: "IActiveScriptStats::ResetStats | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptStats.ResetStats"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptStats::ResetStats"
ms.assetid: d98276fc-ad47-4e7b-aae4-254d63aece77
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptStats::ResetStats
Resets the statistics for this script.  
  
## Syntax  
  
```cpp
HRESULT ResetStats();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method resets the statistics for this script.  
  
## See also  
 [IActiveScriptStats Interface](../../winscript/reference/iactivescriptstats-interface.md)