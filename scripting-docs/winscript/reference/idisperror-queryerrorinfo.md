---
title: "IDispError::QueryErrorInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispError.QueryErrorInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDispError::QueryErrorInfo"
ms.assetid: e7e71a14-77e2-4331-9ffc-1dace041fa84
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError::QueryErrorInfo
Retrieves a particular type of error information.  
  
## Syntax  
  
```cpp
HRESULT QueryErrorInfo(  
   GUID  guidErrorType,  
   IDispError**  ppde  
);  
```  
  
#### Parameters  
 `guidErrorType`  
 [in] GUID specifying error type.  
  
 `ppde`  
 [out] Specifies the IDispError object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `QueryErrorInfo` method retrieves a particular type of error information.  
  
> [!NOTE]
> This method is not implemented.  
  
## See also  
 [IDispError Interface](../../winscript/reference/idisperror-interface.md)