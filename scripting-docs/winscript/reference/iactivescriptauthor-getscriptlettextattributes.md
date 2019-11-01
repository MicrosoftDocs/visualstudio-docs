---
title: "IActiveScriptAuthor::GetScriptletTextAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetScriptletTextAttributes"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetScriptletTextAttributes"
ms.assetid: 082edfce-6c5b-4e5e-b942-31b423a4fa1d
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetScriptletTextAttributes
Returns the text attributes of a scriptlet.  
  
## Syntax  
  
```cpp
HRESULT GetScriptletTextAttributes(  
   LPCOLESTR pszCode,  
   ULONG cch,  
   LPCOLESTR pszDelimiter,  
   DWORD dwFlags,  
   SOURCE_TEXT_ATTR *pattr  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in, size_is(`cch`)] The scriptlet text. This string does not have to be null terminated.  
  
 `cch`  
 [in] The size used for the `pszCode` and `pattr` parameters.  
  
 `pszDelimiter`  
 [in] The address of the end-of-scriptlet delimiter. When `pszCode` is parsed from a stream of text, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the scriptlet. Set this parameter to NULL if no delimiter is used to identify the end of the scriptlet.  
  
 `dwFlags`  
 [in] The flags that are associated with the text attributes of the scriptlet. Can be a combination of the following values.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|GETATTRTYPE_DEPSCAN|0x0001|Identify identifiers that have the SOURCETEXT_ATTR_IDENTIFIER attribute, and identify dot operators that have the SOURCETEXT_ATTR_MEMBERLOOKUP attribute.|  
|GETATTRFLAG_THIS|0x0100|Identify the current object that has the SOURCETEXT_ATTR_THIS attribute.|  
|GETATTRFLAG_HUMANTEXT|0x8000|Identify string content and comment text that has the SOURCETEXT_ATTR_HUMANTEXT attribute.|  
  
 `pattr`  
 [in, out, size_is(`cch`)] The color information for the scriptlet code.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IActiveScriptAuthor::GetScriptTextAttributes](../../winscript/reference/iactivescriptauthor-getscripttextattributes.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)