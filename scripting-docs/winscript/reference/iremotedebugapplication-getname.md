---
title: "IRemoteDebugApplication::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.GetName"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::GetName"
ms.assetid: 3a8e8a4b-d7d4-40e5-97a1-f6d18db2e9c4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::GetName
Returns the name of this application node.  
  
## Syntax  
  
```cpp
HRESULT GetName(  
   BSTR*  pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Name of this application node.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the name of this application node.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)