---
title: "Sample Implementation of Expression Evaluation"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "expression evaluators"
  - "debugging [Debugging SDK], expression evaluators"
  - "expression evaluation, examples"
ms.assetid: 2a5f04b8-6c65-4232-bddd-9093653a22c4
caps.latest.revision: 9
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
# Sample Implementation of Expression Evaluation
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 For a **Watch** window expression, Visual Studio calls [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md) to produce an [IDebugExpression2](../extensibility/idebugexpression2.md) object. `IDebugExpressionContext2::ParseText` instantiates an expression evaluator (EE) and calls [Parse](../extensibility/idebugexpressionevaluator--parse.md) to obtain an [IDebugParsedExpression](../extensibility/idebugparsedexpression.md) object.  
  
 This implementation of `IDebugExpressionEvaluator::Parse` performs the following tasks:  
  
1.  [C++ only] Parses the expression to look for errors.  
  
2.  Instantiates a class (called `CParsedExpression` in this example) that implements the `IDebugParsedExpression` interface and stores in the class the expression to be parsed.  
  
3.  Returns the `IDebugParsedExpression` interface from the `CParsedExpression` object.  
  
> [!NOTE]
>  In the examples that follow and in the MyCEE sample, the expression evaluator does not separate the parsing from the evaluation.  
  
## Managed Code  
 This is an implementation of `IDebugExpressionEvaluator::Parse` in managed code. Note that this version of the method defers the parsing to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) as the code for parsing also evaluates at the same time (see [Evaluating a Watch Expression](../extensibility/evaluating-a-watch-expression.md)).  
  
```c#  
namespace EEMC  
{  
    public class CParsedExpression : IDebugParsedExpression  
    {  
        public HRESULT Parse(  
                string                 expression,   
                uint                   parseFlags,  
                uint                   radix,  
            out string                 errorMessage,   
            out uint                   errorPosition,   
            out IDebugParsedExpression parsedExpression)  
        {   
            errorMessage = "";  
            errorPosition = 0;  
  
            parsedExpression =  
                new CParsedExpression(parseFlags, radix, expression);  
            return COM.S_OK;  
        }  
    }  
}  
```  
  
## Unmanaged Code  
 This is an implementation of `IDebugExpressionEvaluator::Parse` in unmanaged code. This method calls a helper function, `Parse`, to parse the expression and check for errors but this method ignores the resulting value. The formal evaluation is deferred to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) where the expression is parsed while it is evaluated (see [Evaluating a Watch Expression](../extensibility/evaluating-a-watch-expression.md)).  
  
```cpp#  
STDMETHODIMP CExpressionEvaluator::Parse(  
        in    LPCOLESTR                 pszExpression,  
        in    PARSEFLAGS                flags,  
        in    UINT                      radix,  
        out   BSTR                     *pbstrErrorMessages,  
        inout UINT                     *perrorCount,  
        out   IDebugParsedExpression  **ppparsedExpression  
    )  
{  
    if (pbstrErrorMessages == NULL)  
        return E_INVALIDARG;  
    else  
        *pbstrErrormessages = 0;  
  
    if (pparsedExpression == NULL)  
        return E_INVALIDARG;  
    else  
        *pparsedExpression = 0;  
  
    if (perrorCount == NULL)  
        return E_INVALIDARG;  
  
    HRESULT hr;  
    // Look for errors in the expression but ignore results  
    hr = ::Parse( pszExpression, pbstrErrorMessages );  
    if (hr != S_OK)  
        return hr;  
  
    CParsedExpression* pparsedExpr = new CParsedExpression( radix, flags, pszExpression );  
    if (!pparsedExpr)  
        return E_OUTOFMEMORY;  
  
    hr = pparsedExpr->QueryInterface( IID_IDebugParsedExpression,  
                                      reinterpret_cast<void**>(ppparsedExpression) );  
    pparsedExpr->Release();  
  
    return hr;  
}  
```  
  
## See Also  
 [Evaluating a Watch Window Expression](../extensibility/evaluating-a-watch-window-expression.md)   
 [Evaluating a Watch Expression](../extensibility/evaluating-a-watch-expression.md)