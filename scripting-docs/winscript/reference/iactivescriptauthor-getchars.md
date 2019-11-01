---
title: "IActiveScriptAuthor::GetChars | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetChars"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetChars"
ms.assetid: a73ba263-12f7-4d5f-b4c8-9ad7e2d5d3cb
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetChars
Returns the set of completion characters for a requested completion context.  
  
## Syntax  
  
```cpp
HRESULT GetChars(  
   DWORD            fRequestedList,  
   BSTR             *pbstrChars  
);  
```  
  
#### Parameters  
 `fRequestedList`  
 [in] The requested completion context.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|SCRIPT_CMPL_ENUM_TRIGGER|0x0001|Requests the left side enumeration.|  
|SCRIPT_CMPL_MEMBER_TRIGGER|0x0002|Requests the member completion context.|  
|SCRIPT_CMPL_PARAM_TRIGGER|0x0003|Requests the parameter list.|  
|SCRIPT_CMPL_COMMIT|0x0004|Requests completion of the parameter list.|  
  
 `pbstrChars`  
 [out] The characters that correspond to the requested completion context.  
  
|`fRequestedList` parameter|Characters returned|  
|--------------------------------|-------------------------|  
|SCRIPT_CMPL_ENUM_TRIGGER|"."|  
|SCRIPT_CMPL_MEMBER_TRIGGER|"="|  
|SCRIPT_CMPL_PARAM_TRIGGER|"(,"|  
|SCRIPT_CMPL_COMMIT|"()"|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)