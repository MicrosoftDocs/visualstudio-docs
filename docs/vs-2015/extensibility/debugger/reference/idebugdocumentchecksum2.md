---
title: "IDebugDocumentChecksum2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugDocumentChecksum2 interface"
ms.assetid: 6d22fa94-21aa-46cb-b5b5-32a6399ebb20
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentChecksum2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Represents a checksum for a debug document and enables passing the checksum between components.  
  
## Syntax  
  
```  
IDebugDocumentChecksum2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface can be implemented by any component that exposes the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface. However, it is principally implemented by debug engines so that the checksum embedded in a symbol file (*.pdb) can be passed back to the IDE and used when finding a source.  
  
## Methods  
 The following table shows the methods of `IDebugDocumentChecksum2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetChecksumAndAlgorithmId](../../../extensibility/debugger/reference/idebugdocumentchecksum2-getchecksumandalgorithmid.md)|Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
