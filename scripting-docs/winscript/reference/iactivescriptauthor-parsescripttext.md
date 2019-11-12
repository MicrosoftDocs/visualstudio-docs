---
title: "IActiveScriptAuthor::ParseScriptText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.ParseScriptText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::ParseScriptText"
ms.assetid: ebe212e8-6789-423d-ad22-92be984dc7ad
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::ParseScriptText
Parses script text, adds the text to the script authoring engine, and creates an `IScriptEntry` object that corresponds to the script block.  
  
## Syntax  
  
```cpp
HRESULT ParseScriptText(  
   LPCOLESTR pszCode,  
   LPCOLESTR pszItemName,  
   LPCOLESTR pszDelimiter,  
   DWORD dwCookie,  
   DWORD dwFlags  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in] The script text to parse.  
  
 `pszItemName`  
 [in] The buffer address that contains the item name associated with the script block.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script-block delimiter. When `pszCode` is parsed from a stream of text, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the script block. Set this parameter to NULL if there is no delimiter to identify the end of the script block.  
  
 `dwCookie`  
 [in] An application-defined value that is associated with the new `IScriptEntry` object.  
  
 `dwFlags`  
 [in] Not used.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)