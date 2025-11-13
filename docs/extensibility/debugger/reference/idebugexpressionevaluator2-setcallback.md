---
description: "Enables the expression evaluator (EE) to specify the callback interface that the debugger engine (DE) will use to read metric settings."
title: IDebugExpressionEvaluator2::SetCallback
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExpressionEvaluator2::SetCallback
- SetCallback
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::SetCallback

Enables the expression evaluator (EE) to specify the callback interface that the debugger engine (DE) will use to read metric settings.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetCallback (
    IDebugSettingsCallback2 pCallback
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetCallback (
    IDebugSettingsCallback2* pCallback
);
```
---

## Parameters
`pCallback`\
[in] Interface to use for the settings callback.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
This method provides an interface to the session debug manager that an expression evaluator can use to read metric settings. It is useful in remote debugging to read metrics on the Visual Studio computer.

## Example
The following examples shows how to implement this method for a **CEE** object that exposes the [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md) interface.

```cpp
HRESULT CEE::SetCallback(IDebugSettingsCallback2* in_pCallback)
{
    // precondition
    INVARIANT( this );

    // function body
    if (NULL != this->m_LanguageSpecificUseCases.pfSetCallback)
    {
        EEDomain::fSetCallback DomainVal =
        {
            in_pCallback
        };

        BOOL bSuccess = (*this->m_LanguageSpecificUseCases.pfSetCallback)(DomainVal);
        ENSURE( bSuccess );
    }

    // postcondition
    INVARIANT( this );

    return S_OK;
}
```

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
