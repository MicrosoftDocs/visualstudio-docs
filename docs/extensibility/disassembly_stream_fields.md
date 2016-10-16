---
title: "DISASSEMBLY_STREAM_FIELDS"
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
  - "DISASSEMBLY_STREAM_FIELDS"
helpviewer_keywords: 
  - "DISASSEMBLY_STREAM_FIELDS enumeration"
ms.assetid: cfc9b4de-c756-4844-bea7-d9f186a51d1b
caps.latest.revision: 11
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
# DISASSEMBLY_STREAM_FIELDS
Specifies what information to retrieve about a disassembly field.  
  
## Syntax  
  
```cpp#  
enum enum_DISASSEMBLY_STREAM_FIELDS {   
   DSF_ADDRESS          = 0x00000001,  
   DSF_ADDRESSOFFSET    = 0x00000002,  
   DSF_CODEBYTES        = 0x00000004,  
   DSF_OPCODE           = 0x00000008,  
   DSF_OPERANDS         = 0x00000010,  
   DSF_SYMBOL           = 0x00000020,  
   DSF_CODELOCATIONID   = 0x00000040,  
   DSF_POSITION         = 0x00000080,  
   DSF_DOCUMENTURL      = 0x00000100,  
   DSF_BYTEOFFSET       = 0x00000200,  
   DSF_FLAGS            = 0x00000400,  
   DSF_OPERANDS_SYMBOLS = 0x00010000,  
   DSF_ALL              = 0x000107ff  
};  
typedef DWORD DISASSEMBLY_STREAM_FIELDS;  
```  
  
```c#  
public enum enum_DISASSEMBLY_STREAM_FIELDS {   
   DSF_ADDRESS          = 0x00000001,  
   DSF_ADDRESSOFFSET    = 0x00000002,  
   DSF_CODEBYTES        = 0x00000004,  
   DSF_OPCODE           = 0x00000008,  
   DSF_OPERANDS         = 0x00000010,  
   DSF_SYMBOL           = 0x00000020,  
   DSF_CODELOCATIONID   = 0x00000040,  
   DSF_POSITION         = 0x00000080,  
   DSF_DOCUMENTURL      = 0x00000100,  
   DSF_BYTEOFFSET       = 0x00000200,  
   DSF_FLAGS            = 0x00000400,  
   DSF_OPERANDS_SYMBOLS = 0x00010000,  
   DSF_ALL              = 0x000107ff  
};  
```  
  
## Members  
 DSF_ADDRESS  
 Initialize/use the `bstrAddress` field.  
  
 DSF_ADDRESSOFFSET  
 Initialize/use the `bstrAddressOffset` field.  
  
 DSF_CODEBYTES  
 Initialize/use the `bstrCodeBytes` field.  
  
 DSF_OPCODE  
 Initialize/use the `bstrOpCode` field.  
  
 DSF_OPERANDS  
 Initialize/use the `bstrOperands` field.  
  
 DSF_SYMBOL  
 Initialize/use the `bstrSymbol` field.  
  
 DSF_CODELOCATIONID  
 Initialize/use the `uCodeLocationId` field.  
  
 DSF_POSITION  
 Initialize/use the `posBeg` and `posEnd` fields.  
  
 DSF_DOCUMENTURL  
 Initialize/use the `bstrDocumentUrl` field.  
  
 DSF_BYTEOFFSET  
 Initialize/use the `dwByteOffset` field.  
  
 DSF_FLAGS  
 Initialize/use the `dwFlags` ([DISASSEMBLY_FLAGS](../extensibility/disassembly_flags.md)) field.  
  
 DSF_OPERANDS_SYMBOLS  
 Include symbol names in the `bstrOperands` field.  
  
 DSF_ALL  
 Specifies all fields for the disassembly stream.  
  
## Remarks  
 Passed as a parameter to the [Read](../extensibility/idebugdisassemblystream2--read.md) method to indicate which fields of the [DisassemblyData](../extensibility/disassemblydata.md) structure are to be initialized.  
  
 Used for the `dwFields` member of the `DisassemblyData` structure to indicate which fields are used and valid when the structure is returned.  
  
 These values may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [DisassemblyData](../extensibility/disassemblydata.md)   
 [Read](../extensibility/idebugdisassemblystream2--read.md)   
 [DISASSEMBLY_FLAGS](../extensibility/disassembly_flags.md)