---
title: "IDebugApplication::CreateApplicationNode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.CreateApplicationNode"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::CreateApplicationNode"
ms.assetid: 1a1414f6-df14-4c56-b39a-8384cf16174a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::CreateApplicationNode
Creates a new application node that is associated with a specific document provider.  
  
## Syntax  
  
```cpp
HRESULT CreateApplicationNode(  
   IDebugApplicationNode**  ppdanNew  
);  
```  
  
#### Parameters  
 `ppdanNew`  
 [out] The application node associated with this document provider.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The new application node is not visible until it is attached to a parent node.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)