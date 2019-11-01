---
title: "IActiveScriptErrorDebug::GetDocumentContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptErrorDebug.GetDocumentContext"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IActiveScriptErrorDebug::GetDocumentContext"
ms.assetid: 567601a1-551a-4905-bda1-1f54610174f4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptErrorDebug::GetDocumentContext
Provides the document context for this error.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentContext(  
   IDebugDocumentContext**  ppssc  
);  
```  
  
#### Parameters  
 `ppssc`  
 [out] The document context for this error.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The document context character-position range should include all the characters corresponding to the error.  
  
## See also  
 [IActiveScriptErrorDebug Interface](../../winscript/reference/iactivescripterrordebug-interface.md)