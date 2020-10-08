---
title: "IDebugDocumentContext2::GetSourceRange | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentContext2::GetSourceRange"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetSourceRange"
ms.assetid: 5903c75e-5390-4d13-9314-1ee276255313
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentContext2::GetSourceRange
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the source code range of this document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetSourceRange(   
   TEXT_POSITION* pBegPosition,  
   TEXT_POSITION* pEndPosition  
);  
```  
  
```csharp  
int GetSourceRange(   
   TEXT_POSITION[] pBegPosition,  
   TEXT_POSITION[] pEndPosition  
);  
```  
  
#### Parameters  
 `pBegPosition`  
 [in, out] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that is filled in with the starting position. Set this argument to a null value if this information is not needed.  
  
 `pEndPosition`  
 [in, out] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that is filled in with the ending position. Set this argument to a null value if this information is not needed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A source range is the entire range of source code, from the current statement back to just after the previous statement that contributed code. The source range is typically used for mixing source statements, including comments, with code in the disassembly window.  
  
 To get the range for just the code statements contained within this document context, call the [GetStatementRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md) method.  
  
## See Also  
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)   
 [GetStatementRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md)   
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
