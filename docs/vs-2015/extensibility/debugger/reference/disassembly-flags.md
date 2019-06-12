---
title: "DISASSEMBLY_FLAGS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "DISASSEMBLY_FLAGS"
helpviewer_keywords: 
  - "DISASSEMBLY_FLAGS enumeration"
ms.assetid: c1ec5a4d-5d42-4660-932c-7348550140cb
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# DISASSEMBLY_FLAGS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the flags for disassembly.  
  
## Syntax  
  
```cpp#  
enum enum_DISASSEMBLY_FLAGS {   
   DF_DOCUMENTCHANGE     = 0x00000001,  
   DF_DISABLED           = 0x00000002,  
   DF_INSTRUCTION_ACTIVE = 0x00000004,  
   DF_DATA               = 0x00000008,  
   DF_HASSOURCE          = 0x00000010,  
   DF_DOCUMENT_CHECKSUM  = 0x00000020  
};  
typedef DWORD DISASSEMBLY_FLAGS;  
```  
  
```csharp  
public enum enum_DISASSEMBLY_FLAGS {   
   DF_DOCUMENTCHANGE     = 0x00000001,  
   DF_DISABLED           = 0x00000002,  
   DF_INSTRUCTION_ACTIVE = 0x00000004,  
   DF_DATA               = 0x00000008,  
   DF_HASSOURCE          = 0x00000010,  
   DF_DOCUMENT_CHECKSUM  = 0x00000020  
};  
```  
  
## Members  
 DF_DOCUMENTCHANGE  
 Indicates that this instruction is in a different document than the previous one.  
  
 DF_DISABLED  
 Indicates that this instruction will not be executed.  
  
 DF_INSTRUCTION_ACTIVE  
 Indicates that this instruction is one of the next instructions to be executed (there may be more than one).  
  
 DF_DATA  
 Indicates that this instruction is really data (not code).  
  
 DF_HASSOURCE  
 Indicates that this instruction has source. Some instructions, such as profiling or garbage collection code, have no corresponding source.  
  
 DF_DOCUMENT_CHECKSUM  
 Indicates that `bstrDocumentUrl` field contains checksum data after the document URL. See the Remarks section for the [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure for how the checksum data is stored.  
  
## Remarks  
 Used as the `dwFlags` member of the [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure.  
  
 These flags may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
