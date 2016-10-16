---
title: "IDebugDocumentPosition2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugDocumentPosition2"
helpviewer_keywords: 
  - "IDebugDocumentPosition2 interface"
ms.assetid: 0e838ced-12bb-4efc-b811-2b7c034b77b0
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugDocumentPosition2
This interface represents an abstract position in a source file.  
  
## Syntax  
  
```  
IDebugDocumentPosition2 : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio typically implements this interface. A debug engine (DE) would also implement this interface if it must supply its own source code (as when the DE implements the [IDebugDocument2](../extensibility/idebugdocument2.md) interface).  
  
## Notes for Callers  
 This interface is passed in as an argument to [EnumCodeContexts](../extensibility/idebugprogram2--enumcodecontexts.md). It is also supplied as part of a [BP_LOCATION](../extensibility/bp_location.md) union (specifically, a [BP_LOCATION_CODE_FILE_LINE](../extensibility/bp_location_code_file_line.md) structure) that is in turn part of the [BP_REQUEST_INFO](../extensibility/bp_request_info.md) structure, that is used in creating a pending breakpoint.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDocumentPosition2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFileName](../extensibility/idebugdocumentposition2--getfilename.md)|Gets the file name of the source file that contains this document position.|  
|[GetDocument](../extensibility/idebugdocumentposition2--getdocument.md)|Gets the containing document.|  
|[IsPositionInDocument](../extensibility/idebugdocumentposition2--ispositionindocument.md)|Determines if this position is contained in the given document.|  
|[GetRange](../extensibility/idebugdocumentposition2--getrange.md)|Gets the range for this document position.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [EnumCodeContexts](../extensibility/idebugprogram2--enumcodecontexts.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [BP_LOCATION_CODE_FILE_LINE](../extensibility/bp_location_code_file_line.md)