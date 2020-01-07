---
title: "IDispError::GetHresult | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispError.GetHresult"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDispError::GetHresult"
ms.assetid: a14d566e-473f-497b-a2f9-85331433e6c9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError::GetHresult
Retrieves the error code from the `IDispError` object.  
  
## Syntax  
  
```cpp
HRESULT GetHresult(  
   HRESULT*  phr  
);  
```  
  
#### Parameters  
 `phr`  
 [out] Specifies the error code.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method retrieves the error code from the `IDispError` object.  
  
> [!NOTE]
> This method is not implemented.  
  
## See also  
 [IDispError Interface](../../winscript/reference/idisperror-interface.md)