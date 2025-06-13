---
description: "Gets the language associated with this document context."
title: IDebugDocumentContext2::GetLanguageInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2::GetLanguageInfo
helpviewer_keywords:
- IDebugDocumentContext2::GetLanguageInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentContext2::GetLanguageInfo

Gets the language associated with this document context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLanguageInfo(
    out string pbstrLanguage,
    out Guid   pguidLanguage
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLanguageInfo(
    BSTR* pbstrLanguage,
    GUID* pguidLanguage
);
```
---

## Parameters
`pbstrLanguage`\
[out] Returns the name of the language that implements the code at this document context.

`pguidLanguage`\
[out] Returns the GUID of the language that implements the code at this document context. For example, `guidVBScriptLang` or `guidCPPLang`. This GUID is not limited to the languages supplied by Visual Studio.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a simple `CDebugContext` object that exposes the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface.

```cpp
HRESULT CDebugContext::GetLanguageInfo(BSTR* pbstrLanguage, GUID* pguidLanguage)
{
    HRESULT hr;

    // Check for a valid language argument pointers.
    if (pbstrLanguage && pguidLanguage)
    {
        *pguidLanguage = GUID_NULL;
        *pbstrLanguage = SysAllocString(L"Batch File");
        if (*pbstrLanguage)
        {
            *pguidLanguage = guidBatLang;
            hr = S_OK;
        }
        else
        {
            hr = E_OUTOFMEMORY;
        }
    }
    else
    {
        hr = E_INVALIDARG;
    }

    return hr;
}
```

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
