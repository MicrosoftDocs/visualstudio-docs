---
title: Evaluating a Watch Expression
description: Learn how Visual Studio uses EvaluateSync when it is ready to display the value of a watch expression.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- expression evaluation, watch expressions
- watch expressions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Evaluate a watch expression

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

When Visual Studio is ready to display the value of a watch expression, it calls [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md), which in turn calls [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md). This process produces an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object that contains the value and type of the expression.

In this implementation of `IDebugParsedExpression::EvaluateSync`, the expression is parsed and evaluated at the same time. This implementation performs the following tasks:

1. Parses and evaluates the expression to produce a generic object that holds the value and its type. In C#, this is represented as an `object` while in C++, this is represented as a `VARIANT`.

2. Instantiates a class (called `CValueProperty` in this example) that implements the `IDebugProperty2` interface and stores in the class the value to be returned.

3. Returns the `IDebugProperty2` interface from the `CValueProperty` object.

## Managed code
This is an implementation of the `IDebugParsedExpression::EvaluateSync` in managed code. The helper method `Tokenize` parses the expression into a parse tree. The helper function `EvalToken` converts the token to a value. The helper function `FindTerm` recursively traverses the parse tree, calling `EvalToken` for each node representing a value and applying any operations (addition or subtraction) in the expression.

```csharp
namespace EEMC
{
    public class CParsedExpression : IDebugParsedExpression
    {
        public HRESULT EvaluateSync(
            uint evalFlags,
            uint timeout,
            IDebugSymbolProvider provider,
            IDebugAddress address,
            IDebugBinder binder,
            string resultType,
            out IDebugProperty2 result)
        {
            HRESULT retval = COM.S_OK;
            this.evalFlags = evalFlags;
            this.timeout = timeout;
            this.provider = provider;
            this.address = address;
            this.binder = binder;
            this.resultType = resultType;

            try
            {
                IDebugField field = null;
                // Tokenize, then parse.
                tokens = Tokenize(expression);
                result = new CValueProperty(
                        expression,
                        (int) FindTerm(EvalToken(tokens[0], out field),1),
                        field,
                        binder);
            }
            catch (ParseException)
            {
                result = new CValueProperty(expression, "Huh?");
                retval = COM.E_INVALIDARG;
            }
            return retval;
        }
    }
}
```

## Unmanaged code
This is an implementation of the `IDebugParsedExpression::EvaluateSync` in unmanaged code. The helper function `Evaluate` parses and evaluates the expression, returning a `VARIANT` holding the resulting value. The helper function `VariantValueToProperty` bundles the `VARIANT` into a `CValueProperty` object.

```cpp
STDMETHODIMP CParsedExpression::EvaluateSync(
    in  DWORD                 evalFlags,
    in  DWORD                 dwTimeout,
    in  IDebugSymbolProvider* pprovider,
    in  IDebugAddress*        paddress,
    in  IDebugBinder*         pbinder,
    in  BSTR                  bstrResultType,
    out IDebugProperty2**     ppproperty )
{
    // dwTimeout parameter is ignored in this implementation.
    if (pprovider == NULL)
        return E_INVALIDARG;

    if (paddress == NULL)
        return E_INVALIDARG;

    if (pbinder == NULL)
        return E_INVALIDARG;

    if (ppproperty == NULL)
        return E_INVALIDARG;
    else
        *ppproperty = 0;

    HRESULT hr;
    VARIANT value;
    BSTR    bstrErrorMessage = NULL;
    hr = ::Evaluate( pprovider,
                     paddress,
                     pbinder,
                     m_expr,
                     &bstrErrorMessage,
                     &value );
    if (hr != S_OK)
    {
        if (bstrErrorMessage == NULL)
            return hr;

        //we can display better messages ourselves.
        HRESULT hrLocal = S_OK;
        VARIANT varType;
        VARIANT varErrorMessage;

        VariantInit( &varType );
        VariantInit( &varErrorMessage );
        varErrorMessage.vt      = VT_BSTR;
        varErrorMessage.bstrVal = bstrErrorMessage;

        CValueProperty* valueProperty = new CValueProperty();
        if (valueProperty != NULL)
        {
            hrLocal = valueProperty->Init(m_expr, varType, varErrorMessage);
            if (SUCCEEDED(hrLocal))
            {
                hrLocal = valueProperty->QueryInterface( IID_IDebugProperty2,
                        reinterpret_cast<void**>(ppproperty) );
            }
        }

        VariantClear(&varType);
        VariantClear(&varErrorMessage); //frees BSTR
        if (!valueProperty)
            return hr;
        valueProperty->Release();
        if (FAILED(hrLocal))
            return hr;
    }
    else
    {
        if (bstrErrorMessage != NULL)
            SysFreeString(bstrErrorMessage);

        hr = VariantValueToProperty( pprovider,
                                     paddress,
                                     pbinder,
                                     m_radix,
                                     m_expr,
                                     value,
                                     ppproperty );
        VariantClear(&value);
        if (FAILED(hr))
            return hr;
    }

    return S_OK;
}
```

## Related content
- [Evaluate a watch window expression](../../extensibility/debugger/evaluating-a-watch-window-expression.md)
- [Sample implementation of expression evaluation](../../extensibility/debugger/sample-implementation-of-expression-evaluation.md)
