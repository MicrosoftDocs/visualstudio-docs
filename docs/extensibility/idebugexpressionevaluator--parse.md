---
title: "IDebugExpressionEvaluator::Parse"
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
  - "IDebugExpressionEvaluator::Parse"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator::Parse method"
ms.assetid: e6e31b3a-63a7-4293-bcda-267eb78dffb6
caps.latest.revision: 12
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
# IDebugExpressionEvaluator::Parse
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
  
```c#  
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
 [in] A collection of [PARSEFLAGS](../extensibility/parseflags.md) constants that determine how the expression is to be parsed.  
  
 `nRadix`  
 [in] Radix to be used to interpret any numerical information.  
  
 `pbstrError`  
 [out] Returns the  error as human-readable text.  
  
 `pichError`  
 [out] Returns the character position of the start of the error in the expression string.  
  
 `ppParsedExpression`  
 [out] Returns the parsed expression in an [IDebugParsedExpression](../extensibility/idebugparsedexpression.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method produces a parsed expression, not an actual value. A parsed expression is ready to be evaluated, that is, converted to a value.  
  
## See Also  
 [IDebugExpressionEvaluator](../extensibility/idebugexpressionevaluator.md)   
 [IDebugParsedExpression](../extensibility/idebugparsedexpression.md)   
 [PARSEFLAGS](../extensibility/parseflags.md)