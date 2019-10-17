---
title: "IActiveScriptDebug::GetScriptTextAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptDebug.GetScriptTextAttributes"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IActiveScriptDebug::GetScriptTextAttributes"
ms.assetid: 2e8bda34-db0c-4b2e-a17f-82c4e0dbbc8c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptDebug::GetScriptTextAttributes
Returns the text attributes for an arbitrary block of script text.  
  
## Syntax  
  
```cpp
HRESULT GetScriptTextAttributes(  
   LPCOLESTR          pstrCode,  
   ULONG              uNumCodeChars,  
   LPCOLESTR          pstrDelimiter,  
   DWORD              dwFlags,  
   SOURCE_TEXT_ATTR*  pattr  
);  
```  
  
#### Parameters  
 `pstrCode`  
 [in] The script block text. This string need not be null terminated.  
  
 `uNumCodeChars`  
 [in] The number of characters in the script block text.  
  
 `pstrDelimiter`  
 [in] Address of the end-of-script-block delimiter. When `pstrCode` is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the script block. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine uses this information depends on the scripting engine. Set this parameter to NULL if the host did not use a delimiter to mark the end of the script block.  
  
 `dwFlags`  
 [in] Flags associated with the script block. Can be a combination of these values:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|GETATTRTYPE_DEPSCAN|0x0001|Indicates that identifiers and dot operators should be identified with the SOURCETEXT_ATTR_IDENTIFIER and SOURCETEXT_ATTR_MEMBERLOOKUP flags, respectively.|  
|GETATTRFLAG_THIS|0x0100|Indicates that the identifier for the current object should be identified with the SOURCETEXT_ATTR_THIS flag.|  
|GETATTRFLAG_HUMANTEXT|0x8000|Indicates that string content and comment text should be identified with the SOURCETEXT_ATTR_HUMANTEXT flag.|  
  
 `pattr`  
 [in, out] Buffer to contain the returned attributes.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A smart host that implements `IDebugDocumentText` interface can use this method to delegate calls to the `IDebugDocumentText::GetText` method.  
  
 This method for script blocks; the `GetScriptletTextAttributes` method is for scriptlets.  
  
## See also  
 [IActiveScriptDebug Interface](../../winscript/reference/iactivescriptdebug-interface.md)   
 [IActiveScriptDebug::GetScriptletTextAttributes](../../winscript/reference/iactivescriptdebug-getscriptlettextattributes.md)   
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)   
 [IDebugDocumentText::GetText](../../winscript/reference/idebugdocumenttext-gettext.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)