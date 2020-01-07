---
title: "IActiveScriptAuthor::GetScriptTextAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetScriptTextAttributes"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetScriptTextAttributes"
ms.assetid: a53451de-cc5c-4b53-8e5f-81e196364caf
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetScriptTextAttributes
Returns the text attributes for a script block.  
  
## Syntax  
  
```cpp
HRESULT GetScriptTextAttributes(  
    LPCOLESTR        pszCode,  
    ULONG            cch,  
    LPCOLESTR        pszDelimiter,  
    DWORD            dwFlags,  
    SOURCE_TEXT_ATTR *pattr);  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in, size_is(`cch`)] The text of the script block. This string does not have to be null terminated.  
  
 `cch`  
 [in] The size used for the `pszCode` and `pattr` parameters.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script delimiter. When `pszCode` is parsed from a stream of text, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the scriptlet. Set this parameter to NULL if there is no delimiter to identify the end of the script block.  
  
 `dwFlags`  
 [in] The flags that are associated with the text attributes of the script block. Can be a combination of the following values:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|GETATTRTYPE_DEPSCAN|0x0001|Identify identifiers that have the SOURCETEXT_ATTR_IDENTIFIER attribute, and identify dot operators that have the SOURCETEXT_ATTR_MEMBERLOOKUP attribute.|  
|GETATTRFLAG_THIS|0x0100|Identify the current object that has the SOURCETEXT_ATTR_THIS attribute.|  
|GETATTRFLAG_HUMANTEXT|0x8000|Identify string content and comment text that has the SOURCETEXT_ATTR_HUMANTEXT attribute.|  
  
 `pattr`  
 [in, out, size_is(`cch`)] The color information for the script block code.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)