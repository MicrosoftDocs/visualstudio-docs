---
title: "IDispError::GetSource | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispError.GetSource"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDispError::GetSource"
ms.assetid: 20def54c-a67c-4102-babf-6f0704e5fc5c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError::GetSource
Returns the language-dependent programmatic identifier for the class or application that raised the error.  
  
## Syntax  
  
```cpp
HRESULT GetSource(  
   BSTR*  pbstrSource  
);  
```  
  
#### Parameters  
 `pbstrSource`  
 [out] String that contains a programmatic identifier, in the form `progname.objectname`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is used to determine the class or application where the exception occurred. The programmatic identifier may be returned in the language specified by the locale identifier (LCID) supplied at the time of invocation.  
  
> [!NOTE]
> This method is not implemented.  
  
## See also  
 [IDispError Interface](../../winscript/reference/idisperror-interface.md)