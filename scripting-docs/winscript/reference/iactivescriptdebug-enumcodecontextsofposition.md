---
title: "IActiveScriptDebug::EnumCodeContextsOfPosition | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptDebug.EnumCodeContextsOfPosition"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IActiveScriptDebug::EnumCodeContextsOfPosition"
ms.assetid: 19f44420-bcc8-4c10-8c38-378d96044117
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptDebug::EnumCodeContextsOfPosition
Used by a smart host to delegate the `IDebugDocumentContext::EnumCodeContexts` method.  
  
## Syntax  
  
```cpp
HRESULT EnumCodeContextsOfPosition(  
   DWORD_PTR                 dwSourceContext,  
   ULONG                     uCharacterOffset,  
   ULONG                     uNumChars,  
   IEnumDebugCodeContexts**  ppescc  
);  
```  
  
#### Parameters  
 `dwSourceContext`  
 [in] The source context as provided to `IActiveScriptParse::ParseScriptText` or `IActiveScriptParse::AddScriptlet`.  
  
 `uCharacterOffset`  
 [in] Character offset relative to start of script text.  
  
 `uNumChars`  
 [in] Number of characters in this context.  
  
 `ppescc`  
 [out] An enumerator of the code contexts in the specified range.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Smart hosts use this method to delegate the `IDebugDocumentContext::EnumCodeContexts` method.  
  
## See also  
 [IActiveScriptDebug Interface](../../winscript/reference/iactivescriptdebug-interface.md)   
 [IDebugDocumentContext::EnumCodeContexts](../../winscript/reference/idebugdocumentcontext-enumcodecontexts.md)