---
title: "IDebugDocumentHelper::DefineScriptBlock | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.DefineScriptBlock"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::DefineScriptBlock"
ms.assetid: e4120377-f04f-44b1-950b-2beba06c9c12
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::DefineScriptBlock
Indicates to the helper that a particular range of characters is a script block that is handled by the given script engine.  
  
## Syntax  
  
```cpp
HRESULT DefineScriptBlock(  
   ULONG           ulCharOffset,  
   ULONG           cChars,  
   IActiveScript*  pas,  
   BOOL            fScriptlet,  
   DWORD_PTR*      pdwSourceContext  
);  
```  
  
#### Parameters  
 `ulCharOffset`  
 [in] Location of the start of the script block.  
  
 `cChars`  
 [in] Number of characters in the script block.  
  
 `pas`  
 [in] The script engine for this script block.  
  
 `fScriptlet`  
 [in] Flag that indicates if the script block is a scriptlet.  
  
 `pdwSourceContext`  
 [out] The source context for the script block.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A smart host can use this method when its documents contain embedded script blocks. A language engine can use this method when its code contains embedded scripts for other languages.  
  
 The script engine is responsible for all syntax coloring and code context lookups in the script block.  
  
 The `DefineScriptBlock` method should be called after the text has been added (for example, using the `IDebugDocumentHelper::AddDBCSText` method) but before the script block has been parsed (for example, using the `IActiveScriptParse ::ParseScriptText` method).  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)   
 [IDebugDocumentHelper::AddDBCSText](../../winscript/reference/idebugdocumenthelper-adddbcstext.md)   
 [IDebugDocumentHelper::AddUnicodeText](../../winscript/reference/idebugdocumenthelper-addunicodetext.md)