---
description: "Gets the displayable name of the document that contains this document context."
title: IDebugDocumentContext2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2::GetName
helpviewer_keywords:
- IDebugDocumentContext2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentContext2::GetName

Gets the displayable name of the document that contains this document context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName(
    enum_GETNAME_TYPE  gnType,
    out string         pbstrFileName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName(
    GETNAME_TYPE gnType,
    BSTR*        pbstrFileName
);
```
---

## Parameters
`gnType`\
[in] A value from the [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md) enumeration that specifies the type of name to return.

`pbstrFileName`\
[out] Returns the name of the file.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
This method typically forwards the call to the [GetName](../../../extensibility/debugger/reference/idebugdocument2-getname.md) method, unless the document context is written to store the document name itself (as the Example show).

## Example
The following example shows how to implement this method for a simple `CDebugContext` object that exposes the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface.

```cpp
HRESULT CDebugContext::GetName(GETNAME_TYPE gnType, BSTR* pbstrFileName)
{
    HRESULT hr;

    // Check for a valid file name argument.
    if (pbstrFileName)
    {
        *pbstrFileName = NULL;

        switch (gnType)
        {
            case GN_NAME:
            case GN_FILENAME:
            {
                // Copy the member file name into the local file name.
                *pbstrFileName = SysAllocString(m_sbstrFileName);
                // Check for successful copy.
                hr = (*pbstrFileName) ? S_OK : E_OUTOFMEMORY;
                break;
            }
            default:
            {
                hr = E_FAIL;
                break;
            }
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
- [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md)
