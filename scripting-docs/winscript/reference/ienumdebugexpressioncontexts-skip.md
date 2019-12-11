---
title: "IEnumDebugExpressionContexts::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExpressionContexts.Skip"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugExpressionContexts::Skip"
ms.assetid: 3498cbb5-8581-4dcd-b016-e86b049c7831
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExpressionContexts::Skip
Skips a specified number of segments in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Skip(  
   ULONG  celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of segments in the enumeration sequence to skip.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method skips a specified number of segments in an enumeration sequence.  
  
## See also  
 [IEnumDebugExpressionContexts Interface](../../winscript/reference/ienumdebugexpressioncontexts-interface.md)