---
title: "IDebugExpressionEvaluator::Parse | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugExpressionEvaluator::Parse"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator::Parse method"
ms.assetid: e6e31b3a-63a7-4293-bcda-267eb78dffb6
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugExpressionEvaluator::Parse
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method converts an expression string to a parsed expression.  
  
## Syntax  
  
```cpp#  
HRESULT Parse(   
   LPCOLESTR                upstrExpression,  
   PARSEFLAGS               dwFlags,  
   UINT                     nRadix,  
   BSTR*                    pbstrError,  
   UINT*                    pichError,  
   IDebugParsedExpression** ppParsedExpression  
);  
```  
  
```csharp  
int Parse(  
   string                     upstrExpression,   
   enum_PARSEFLAGS            dwFlags,   
   uint                       nRadix,   
   out string                 pbstrError,   
   out uint                   pichError,   
   out IDebugParsedExpression ppParsedExpression  
);  
```  
  
#### Parameters  
 `upstrExpression`  
 [in] The expression string to be parsed.  
  
 `dwFlags`  
 [in] A collection of [PARSEFLAGS](../../../extensibility/debugger/reference/parseflags.md) constants that determine how the expression is to be parsed.  
  
 `nRadix`  
 [in] Radix to be used to interpret any numerical information.  
  
 `pbstrError`  
 [out] Returns the  error as human-readable text.  
  
 `pichError`  
 [out] Returns the character position of the start of the error in the expression string.  
  
 `ppParsedExpression`  
 [out] Returns the parsed expression in an [IDebugParsedExpression](../../../extensibility/debugger/reference/idebugparsedexpression.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method produces a parsed expression, not an actual value. A parsed expression is ready to be evaluated, that is, converted to a value.  
  
## See also  
 [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)   
 [IDebugParsedExpression](../../../extensibility/debugger/reference/idebugparsedexpression.md)   
 [PARSEFLAGS](../../../extensibility/debugger/reference/parseflags.md)
