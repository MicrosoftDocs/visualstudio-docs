---
title: "IActiveScriptStats::GetStatEx | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptStats.GetStatEx"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptStats::GetStatEx"
ms.assetid: f526f51d-8ab5-49ef-a8f7-ae0ac1cb46e4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptStats::GetStatEx
Returns a custom script statistic.  
  
## Syntax  
  
```cpp
HRESULT GetStatEx(  
   REFGUID  guid,  
   ULONG*   pluHi,  
   ULONG*   pluLo  
);  
```  
  
#### Parameters  
 `guid`  
 [in] Specifies which statistic to return. The semantics of which statistic corresponds to a particular GUID is entirely engine defined.  
  
 `pluHi`  
 [out] The high 32 bits of a 64-bit unsigned integer representing the statistic.  
  
 `pluLo`  
 [out] The low 32 bits of a 64-bit unsigned integer representing the statistic.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The method is not implemented.|  
  
## Remarks  
 This method allows a custom script engine to return statistics meaningful to a custom host.  
  
> [!NOTE]
> This method is not currently implemented.  
  
## See also  
 [IActiveScriptStats::GetStat](../../winscript/reference/iactivescriptstats-getstat.md)   
 [IActiveScriptStats Interface](../../winscript/reference/iactivescriptstats-interface.md)