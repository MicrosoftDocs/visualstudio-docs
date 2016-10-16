---
title: "IDebugExpressionContext2::ParseText"
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
  - "IDebugExpressionContext2::ParseText"
helpviewer_keywords: 
  - "IDebugExpressionContext2::ParseText"
ms.assetid: f58575db-f926-4ac8-83ff-7b3b86ab61e2
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
# IDebugExpressionContext2::ParseText
Parses an expression in text form for later evaluation.  
  
## Syntax  
  
```cpp#  
HRESULT ParseText(   
   LPCOLESTR           pszCode,  
   PARSEFLAGS          dwFlags,  
   UINT                nRadix,  
   IDebugExpression2** ppExpr,  
   BSTR*               pbstrError,  
   UINT*               pichError  
);  
```  
  
```c#  
int ParseText(   
   string                pszCode,  
   enum_PARSEFLAGS       dwFlags,  
   uint                  nRadix,  
   out IDebugExpression2 ppExpr,  
   out string            pbstrError,  
   out uint              pichError  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in] The expression to be parsed.  
  
 `dwFlags`  
 [in] A combination of flags from the [PARSEFLAGS](../extensibility/parseflags.md) enumeration that controls parsing.  
  
 `nRadix`  
 [in] The radix to be used in parsing any numerical information in `pszCode`.  
  
 `ppExpr`  
 [out] Returns the [IDebugExpression2](../extensibility/idebugexpression2.md) object that represents the parsed expression, which is ready for binding and evaluation.  
  
 `pbstrError`  
 [out] Returns the error message if the expression contains an error.  
  
 `pichError`  
 [out] Returns the character index of the error in `pszCode` if the expression contains an error.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 When this method is called, a debug engine (DE) should parse the expression and validate it for correctness. The `pbstrError` and `pichError` parameters may be filled in if the expression is invalid.  
  
 Note that the expression is not evaluated, only parsed. A later call to the [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) or [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md) methods evaluates the parsed expression.  
  
## Example  
 The following example shows how to implement this method for a simple `CEnvBlock` object that exposes the [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md) interface. This example considers the expression to be parsed as the name of an environment variable and retrieves the value from that variable.  
  
```cpp#  
HRESULT CEnvBlock::ParseText(  
   LPCOLESTR           pszCode,  
   PARSEFLAGS          dwFlags,  
   UINT                nRadix,  
   IDebugExpression2 **ppExpr,  
   BSTR               *pbstrError,  
   UINT               *pichError)  
{  
   HRESULT hr = E_OUTOFMEMORY;    
   // Create an integer variable with a value equal to one plus    
   // twice the length of the passed expression to be parsed.    
   int iAnsiLen      = 2 * (wcslen(pszCode)) + 1;    
   // Allocate a character string of the same length.    
   char *pszAnsiCode = (char *) malloc(iAnsiLen);    
  
   // Check for successful memory allocation.    
   if (pszAnsiCode) {    
      // Map the wide-character pszCode string to the new pszAnsiCode character string.    
      WideCharToMultiByte(CP_ACP, 0, pszCode, -1, pszAnsiCode, iAnsiLen, NULL, NULL);    
      // Check to see if the app can succesfully get the environment variable.    
      if (GetEnv(pszAnsiCode)) {    
  
         // Create and initialize a CExpression object.    
         CComObject<CExpression> *pExpr;    
         CComObject<CExpression>::CreateInstance(&pExpr);    
            pExpr->Init(pszAnsiCode, this, NULL);    
  
         // Assign the pointer to the new object to the passed argument  
         // and AddRef the object.    
         *ppExpr = pExpr;    
         (*ppExpr)->AddRef();    
         hr = S_OK;    
      // If the program cannot succesfully get the environment variable.    
      } else {    
         // Set the errror message and return E_FAIL.    
         *pbstrError = SysAllocString(L"No such environment variable.");    
         hr = E_FAIL;    
      }    
      // Free the local character string.    
      free(pszAnsiCode);    
   }    
   return hr;    
}    
```  
  
## See Also  
 [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md)   
 [PARSEFLAGS](../extensibility/parseflags.md)   
 [IDebugExpression2](../extensibility/idebugexpression2.md)   
 [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md)   
 [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md)