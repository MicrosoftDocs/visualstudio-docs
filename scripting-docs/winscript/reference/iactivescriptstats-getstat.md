---
title: "IActiveScriptStats::GetStat | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptStats.GetStat"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptStats::GetStat"
ms.assetid: 31fd15b3-0713-4b55-b4f7-bfd7ea198493
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptStats::GetStat
Returns one of the standard script statistics.  
  
## Syntax  
  
```cpp
HRESULT GetStat(  
   DWORD   stid,  
   ULONG*  pluHi,  
   ULONG*  pluLo  
);  
```  
  
#### Parameters  
 `stid`  
 [in] Specifies which statistic to return. Must be the value:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|SCRIPTSTAT_STATEMENT_COUNT|1|Return the number of statements executed since the script started or the statistics were reset.|  
  
 `pluHi`  
 [out] The high 32 bits of a 64-bit unsigned integer representing the statistic.  
  
 `pluLo`  
 [out] The low 32 bits of a 64-bit unsigned integer representing the statistic.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to the values in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns one of the standard script statistics.  
  
## See also  
 [IActiveScriptStats::GetStatEx](../../winscript/reference/iactivescriptstats-getstatex.md)   
 [IActiveScriptStats Interface](../../winscript/reference/iactivescriptstats-interface.md)