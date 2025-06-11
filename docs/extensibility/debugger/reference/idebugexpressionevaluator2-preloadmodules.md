---
description: "Preloads the modules designated by the specified symbol provider."
title: IDebugExpressionEvaluator2::PreloadModules
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExpressionEvaluator2::PreloadModules
- PreloadModules
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::PreloadModules

Preloads the modules designated by the specified symbol provider.

## Syntax

### [C#](#tab/csharp)
```csharp
int PreloadModules (
    IDebugSymbolProvider pSym
);
```
### [C++](#tab/cpp)
```cpp
HRESULT PreloadModules (
    IDebugSymbolProvider* pSym
);
```
---

## Parameters
`pSym`\
[in] Symbol provider for which the modules will be preloaded.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
This optional method is used when you do a hosting-process attach. It gives the EE a chance to 'warm up' as part of the attach.

## Example
The following example shows how to implement this method for an **ExpressionEvaluatorPackage** object that exposes the [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md) interface.

```cpp
STDMETHODIMP ExpressionEvaluatorPackage::PreloadModules
(
    IDebugSymbolProvider *pSym
)
{
    HRESULT hr = NOERROR;
    RuntimeMemberDescriptor  * prtMemberDesc;
    RuntimeClassDescriptor *prtClassDesc;
    CComPtr<IDebugClassField> pClassField;
    IfFalseGo(pSym,E_INVALIDARG);

    prtMemberDesc = &(g_rgRTLangMembers[StandardModuleAttributeCtor]);
    prtClassDesc = &(g_rgRTLangClasses[prtMemberDesc->rtParent]);
    pSym->GetClassTypeByName(prtClassDesc->wszClassName, nmCaseSensitive, &pClassField);

    pClassField = NULL;
    prtMemberDesc = &(g_rgRTLangMembers[LoadAssembly]);
    prtClassDesc = &(g_rgRTLangClasses[prtMemberDesc->rtParent]);
    pSym->GetClassTypeByName(prtClassDesc->wszClassName, nmCaseSensitive, &pClassField);

Error:
    return hr;
}
```

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
