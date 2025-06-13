---
description: "Sets the path to the common language runtime (CLR) loaded in the debugger."
title: IDebugExpressionEvaluator2::SetCorPath
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- SetCorPath
- IDebugExpressionEvaluator2::SetCorPath
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::SetCorPath

Sets the path to the common language runtime (CLR) loaded in the debugger.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetCorPath(
   string pcstrCorPath
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetCorPath(
   LPCOLESTR pcstrCorPath
);
```
---

## Parameters
`pcstrCorPath`\
[in] Path to the CLR loaded in the debugger.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example
 The following example shows how to implement this method for an **ExpressionEvaluatorPackage** object that exposes the [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md) interface.

```cpp
STDMETHODIMP ExpressionEvaluatorPackage::SetCorPath(LPCOLESTR pcstrCorPath)
{
    VerifyInPtr(pcstrCorPath);
    HRESULT hr = E_FAIL;

    VBEECompilerSingleton *pVBEECompilerSingleton = VBEECompilerSingleton::Instance();

    if (pVBEECompilerSingleton)
    {
        pVBEECompilerSingleton->LockEECompiler();

        try
        {
            if (!m_pCompiler->FindEECompilerHost(pcstrCorPath, &m_pCompilerHost))
            {
                CComObject<CVBEECompilerHost> *pEECompilerHost;

                if (SUCCEEDED(CComObject<CVBEECompilerHost>::CreateInstance(&pEECompilerHost)))
                {
                    pEECompilerHost->AddRef();
                    pEECompilerHost->Init(pcstrCorPath);

                    CComPtr<IVbCompilerHost> srpVBHost;
                    HRESULT hr2 = pEECompilerHost->QueryInterface(IID_IVbCompilerHost, (void **)&srpVBHost);

                    pEECompilerHost->Release();

                    if (SUCCEEDED(hr2))
                    {
                        m_pCompiler->RegisterEECompilerHost(srpVBHost);
                    }
                }
            }
            else
            {
                hr = S_OK;
            }

            if (m_pCompiler->FindEECompilerHost(pcstrCorPath, &m_pCompilerHost))
            {
                ULONG cErrors = 0;
                ULONG cWarnings = 0;

                m_pCompiler->CompileToBound(m_pCompilerHost, &cErrors, &cWarnings, NULL);

                // This needs to happen after bound
                if (m_pCompilerHost->GetVbLibraryType() == TLB_AutoDetect)
                {
                    m_pCompilerHost->AutoSetVbLibraryType();
                }

                VSASSERT(m_pCompiler && m_pCompilerHost && m_pCompilerHost->GetIntrinsicSymbol(t_i4) != NULL, "Invalid state");

                if (cErrors + cWarnings > 0)
                {
                    VSFAIL("Errors from mscorlib.dll and vb runtime!");
                    __leave;
                }

                hr = S_OK;
            }
            else
            {
                VSFAIL("FindCompilerHost shouldn't have failed!");
            }
        }
        catch_hresult;

        VSASSERT(m_pCompilerHost->GetComPlusProject()->GetCompState() >= CS_Bound, "Debugger mscorlib not in bound state");

        pVBEECompilerSingleton->UnlockEECompiler();
    }

    return hr;
}
```

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
