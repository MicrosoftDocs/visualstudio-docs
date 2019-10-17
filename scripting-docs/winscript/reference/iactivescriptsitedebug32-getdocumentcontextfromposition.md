---
title: "IActiveScriptSiteDebug32::GetDocumentContextFromPosition | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 53348dff-35a6-4303-b263-90c10af06bf3
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptSiteDebug32::GetDocumentContextFromPosition
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
 [IActiveScriptSiteDebug32 Interface](../../winscript/reference/iactivescriptsitedebug32-interface.md)