---
title: "BP_LOCATION_CODE_FILE_LINE | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "BP_LOCATION_CODE_FILE_LINE"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_FILE_LINE structure"
ms.assetid: 3ff32032-d412-44d3-91bf-870cc354a09e
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# BP_LOCATION_CODE_FILE_LINE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [BP_LOCATION_CODE_FILE_LINE](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/bp-location-code-file-line).  
  
Contains the data for the location of a breakpoint at a specific line in a code source file.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_FILE_LINE {   
   BSTR                     bstrContext;  
   IDebugDocumentPosition2* pDocPos;  
} BP_LOCATION_CODE_FILE_LINE;  
```  
  
## Members  
 `bstrContext`  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 `pDocPos`  
 The [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md) object that represents the document position of the breakpoint.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)

