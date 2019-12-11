---
title: "IDebugDocumentHelper::GetScriptBlockInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.GetScriptBlockInfo"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::GetScriptBlockInfo"
ms.assetid: 332d7540-bbbe-4747-95ec-e47384d4f4e6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::GetScriptBlockInfo
Retrieves the range of characters and the script engine corresponding to a script block.  
  
## Syntax  
  
```cpp
HRESULT GetScriptBlockInfo(  
   DWORD_PTR        dwSourceContext,  
   IActiveScript**  ppasd,  
   ULONG*           piCharPos,  
   ULONG*           pcChars  
);  
```  
  
#### Parameters  
 `dwSourceContext`  
 [in] The source context for the script block.  
  
 `ppasd`  
 [out] The script engine for this script block.  
  
 `piCharPos`  
 [out] Location of the start of the script block.  
  
 `cChars`  
 [out] Number of characters in the script block.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method retrieves the range of characters and the script engine corresponding to a script block.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)