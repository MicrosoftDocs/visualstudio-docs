---
title: "TEXT_POSITION"
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
  - "TEXT_POSITION"
helpviewer_keywords: 
  - "TEXT_POSITION structure"
ms.assetid: 6dcec574-a852-49fa-8c2e-2e71cbb5e3c6
caps.latest.revision: 8
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
# TEXT_POSITION
Describes the line and column location in the given text.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTEXT_POSITION {   
   DWORD dwLine;  
   DWORD dwColumn;  
} TEXT_POSITION;  
```  
  
```c#  
public struct TEXT_POSITION {   
   public uint dwLine;  
   public uint dwColumn;  
};  
```  
  
## Members  
 dwLine  
 Index of line in source file.  
  
 dwColumn  
 Character offset into line.  
  
## Remarks  
 This structure is used in the [CONTEXT_INFO](../extensibility/context_info.md) and [DisassemblyData](../extensibility/disassemblydata.md) structures.  
  
 This structure is filled in by a call to the following methods:  
  
-   [GetStatementRange](../extensibility/idebugdocumentcontext2--getstatementrange.md)  
  
-   [GetSourceRange](../extensibility/idebugdocumentcontext2--getsourcerange.md)  
  
-   [GetRange](../extensibility/idebugdocumentposition2--getrange.md)  
  
-   [GetOffset](../extensibility/idebugfunctionposition2--getoffset.md)  
  
 This structure is passed as a parameter to the following methods:  
  
-   [GetText](../extensibility/idebugdocumenttext2--gettext.md)  
  
-   [onInsertText](../extensibility/idebugdocumenttextevents2--oninserttext.md)  
  
-   [onRemoveText](../extensibility/idebugdocumenttextevents2--onremovetext.md)  
  
-   [onReplaceText](../extensibility/idebugdocumenttextevents2--onreplacetext.md)  
  
-   [onUpdateTextAttributes](../extensibility/idebugdocumenttextevents2--onupdatetextattributes.md)  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [GetStatementRange](../extensibility/idebugdocumentcontext2--getstatementrange.md)   
 [GetSourceRange](../extensibility/idebugdocumentcontext2--getsourcerange.md)   
 [GetRange](../extensibility/idebugdocumentposition2--getrange.md)   
 [GetOffset](../extensibility/idebugfunctionposition2--getoffset.md)   
 [GetText](../extensibility/idebugdocumenttext2--gettext.md)   
 [IDebugDocumentTextEvents2](../extensibility/idebugdocumenttextevents2.md)   
 [CONTEXT_INFO](../extensibility/context_info.md)   
 [DisassemblyData](../extensibility/disassemblydata.md)