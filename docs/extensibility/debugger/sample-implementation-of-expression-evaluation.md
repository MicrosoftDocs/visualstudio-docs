---
title: Sample Implementation of Expression Evaluation
description: Learn how Visual Studio calls ParseText to produce an IDebugExpression2 object for a Watch windows expression.
ms.date: 11/04/2016
ms.topic: sample
helpviewer_keywords:
- expression evaluators
- debugging [Debugging SDK], expression evaluators
- expression evaluation, examples
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Sample implementation of expression evaluation

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 For a **Watch** window expression, Visual Studio calls [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) to produce an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) object. `IDebugExpressionContext2::ParseText` instantiates an expression evaluator (EE) and calls [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) to get an [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) object.

 The `IDebugExpressionEvaluator::Parse` performs the following tasks:

1. [C++ only] Parses the expression to look for errors.

2. Instantiates a class (called `CParsedExpression` in this example) that runs the `IDebugParsedExpression` interface and stores in the class the expression to be parsed.

3. Returns the `IDebugParsedExpression` interface from the `CParsedExpression` object.

> [!NOTE]
> In the examples that follow and in the MyCEE sample, the expression evaluator does not separate the parsing from the evaluation.

## Managed code
 The following code shows an implementation of `IDebugExpressionEvaluator::Parse` in managed code. This version of the method defers the parsing to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) as the code for parsing also evaluates at the same time (see [Evaluate a Watch expression](../../extensibility/debugger/evaluating-a-watch-expression.md)).

```csharp
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

## Unmanaged code
The following code is an implementation of `IDebugExpressionEvaluator::Parse` in unmanaged code. This method calls a helper function, `Parse`, to parse the expression and check for errors, but this method ignores the resulting value. The formal evaluation is deferred to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) where the expression is parsed while it is evaluated (see [Evaluate a Watch expression](../../extensibility/debugger/evaluating-a-watch-expression.md)).

```cpp
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

## See also
- [Evaluate a Watch window expression](../../extensibility/debugger/evaluating-a-watch-window-expression.md)
- [Evaluate a Watch expression](../../extensibility/debugger/evaluating-a-watch-expression.md)
