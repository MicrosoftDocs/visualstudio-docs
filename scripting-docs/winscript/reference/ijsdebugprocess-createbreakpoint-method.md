---
title: "IJsDebugProcess::CreateBreakPoint Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugProcess.CreateBreakPoint"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: a2cb4233-2846-4d11-aa13-21de43abda9f
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProcess::CreateBreakPoint Method
Sets the breakpoint at the specified document position.  
  
## Syntax  
  
```cpp
HRESULT CreateBreakPoint(  
   UINT64 documentId,  
   DWORD characterOffset,  
   DWORD characterCount,  
   BOOL isEnabled,  
   IJsDebugBreakPoint **ppDebugBreakPoint  
);  
```  
  
#### Parameters  
 `documentId`  
 [in] Pointer to IDebugDocumentText.  
  
 `characterOffset`  
 [in] Character offset from the beginning of the file.  
  
 `characterCount`  
 [in] Length of the document text within which the breakpoint should be inserted.  
  
 `isEnabled`  
 [in] Specifies whether the breakpoint is enabled.  
  
 `ppDebugBreakPoint`  
 [out] Object representing the breakpoint that was created.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugProcess Interface](../../winscript/reference/ijsdebugprocess-interface.md)