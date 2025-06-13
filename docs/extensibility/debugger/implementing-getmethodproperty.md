---
title: Implementing GetMethodProperty
description: Learn how Visual Studio obtains information about the current method on the stack frame by using the GetDebugProperty of the debug engine.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- GetMethodProperty method
- IDebugExpressionEvaluator2 property
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Implement GetMethodProperty

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

Visual Studio calls the debug engine's (DE) [GetDebugProperty](../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md), which in turn calls [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) to obtain information about the current method on the stack frame.

This implementation of `IDebugExpressionEvaluator::GetMethodProperty` performs the following tasks:

1. Calls [GetContainerField](../../extensibility/debugger/reference/idebugsymbolprovider-getcontainerfield.md), passing in the [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md) object. The symbol provider (SP) returns an [IDebugContainerField](../../extensibility/debugger/reference/idebugcontainerfield.md) representing the method that contains the specified address.

2. Obtains the [IDebugMethodField](../../extensibility/debugger/reference/idebugmethodfield.md) from the `IDebugContainerField`.

3. Instantiates a class (called `CFieldProperty` in this example) that implements the [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface and contains the `IDebugMethodField` object returned from the SP.

4. Returns the `IDebugProperty2` interface from the `CFieldProperty` object.

## Managed code
This example shows an implementation of `IDebugExpressionEvaluator::GetMethodProperty` in managed code.

```csharp
namespace EEMC
{
    [GuidAttribute("462D4A3D-B257-4AEE-97CD-5918C7531757")]
    public class EEMCClass : IDebugExpressionEvaluator
    {
        public HRESULT GetMethodProperty(
                IDebugSymbolProvider symbolProvider,
                IDebugAddress        address,
                IDebugBinder         binder,
                int                  includeHiddenLocals,
            out IDebugProperty2      property)
        {
            IDebugContainerField containerField = null;
            IDebugMethodField methodField       = null;
            property = null;

            // Get the containing method field.
            symbolProvider.GetContainerField(address, out containerField);
            methodField = (IDebugMethodField) containerField;

            // Return the property of method field.
            property = new CFieldProperty(symbolProvider, address, binder, methodField);
            return COM.S_OK;
        }
    }
}
```

## Unmanaged code
This example shows an implementation of `IDebugExpressionEvaluator::GetMethodProperty` in unmanaged code.

```
[CPP]
STDMETHODIMP CExpressionEvaluator::GetMethodProperty(
        in IDebugSymbolProvider *pprovider,
        in IDebugAddress        *paddress,
        in IDebugBinder         *pbinder,
        in BOOL                  includeHiddenLocals,
        out IDebugProperty2    **ppproperty
    )
{
    if (pprovider == NULL)
        return E_INVALIDARG;

    if (ppproperty == NULL)
        return E_INVALIDARG;
    else
        *ppproperty = 0;

    HRESULT hr;
    IDebugContainerField* pcontainer = NULL;

    hr = pprovider->GetContainerField(paddress, &pcontainer);
    if (FAILED(hr))
        return hr;

    IDebugMethodField*    pmethod    = NULL;
    hr = pcontainer->QueryInterface( IID_IDebugMethodField,
            reinterpret_cast<void**>(&pmethod));
    pcontainer->Release();
    if (FAILED(hr))
        return hr;

    CFieldProperty* pfieldProperty = new CFieldProperty( pprovider,
                                                         paddress,
                                                         pbinder,
                                                         pmethod );
    pmethod->Release();
    if (!pfieldProperty)
        return E_OUTOFMEMORY;

    hr = pfieldProperty->Init();
    if (FAILED(hr))
    {
        pfieldProperty->Release();
        return hr;
    }

    hr = pfieldProperty->QueryInterface( IID_IDebugProperty2,
            reinterpret_cast<void**>(ppproperty));
    pfieldProperty->Release();

    return hr;
}
```

## Related content
- [Sample implementation of locals](../../extensibility/debugger/sample-implementation-of-locals.md)
