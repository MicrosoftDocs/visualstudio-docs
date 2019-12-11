---
title: "IActiveScriptSiteDebug::GetDocumentContextFromPosition | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteDebug.GetDocumentContextFromPosition"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteDebug::GetDocumentContextFromPosition"
ms.assetid: ba5f7348-0107-4b12-b949-79a012476cf7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebug::GetDocumentContextFromPosition
Used by the language engine to delegate `IDebugCodeContext::GetSourceContext`.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentContextFromPosition(  
   DWORD_PTR                dwSourceContext,  
   ULONG                    uCharacterOffset,  
   ULONG                    uNumChars,  
   IDebugDocumentContext**  ppsc  
);  
```  
  
#### Parameters  
 `dwSourceContext`  
 [in] The source content as provided to `ParseScriptText` or `AddScriptlet`.  
  
 `uCharacterOffset`  
 [in] Character offset relative to start of script block or scriptlet.  
  
 `uNumChars`  
 [in] Number of characters in this context.  
  
 `ppsc`  
 [out] The document context corresponding to this character-position range.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Language engines use this method to delegate `IDebugCodeContext::GetSourceContext`.  
  
## See also  
 [IActiveScriptSiteDebug Interface](../../winscript/reference/iactivescriptsitedebug-interface.md)