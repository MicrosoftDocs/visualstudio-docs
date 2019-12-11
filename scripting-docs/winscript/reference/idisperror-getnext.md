---
title: "IDispError::GetNext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispError.GetNext"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDispError::GetNext"
ms.assetid: 3e5267f8-ba62-41c3-bd3e-eced2ad85e8e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError::GetNext
Retrieves the next `IDispError` object.  
  
## Syntax  
  
```cpp
HRESULT GetNext(  
   IDispError**  ppde  
);  
```  
  
#### Parameters  
 `ppde`  
 [out] Specifies next `IDispError` object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method retrieves the next `IDispError` object. If this is the last `IDispError` object, this method returns NULL.  
  
> [!NOTE]
> This method is not implemented.  
  
## See also  
 [IDispError Interface](../../winscript/reference/idisperror-interface.md)