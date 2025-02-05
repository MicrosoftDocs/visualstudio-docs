---
description: Retrieves all names of named streams within the datasource that match the optionally given pattern.
title: "IDiaDataSourceEx2::findNamedStreams"
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx2::findNamedStreams method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx2::findNamedStreams

Retrieves all the names of named streams within the datasource that match the optionally given pattern.

## Syntax

```C++
HRESULT findNamedStreams ( 
   [in, optional] LPCOLESTR              name,
   [in]           DWORD                  compareFlags,
   [out]          IDiaEnumNamedStreams** ppResult
);
```

## Parameters

 `[in, optional] name`

Optionally specifies the name of the streams to be retrieved. Set to `NULL` for all streams to be retrieved.

 `[in] compareFlags`

Specifies the comparison options applied to name matching. Values from the [`NameSearchOptions` Enumeration](../../debugger/debug-interface-access/namesearchoptions.md) enumeration can be used alone or in combination. If `name` is `NULL`, this parameter must be `nsNone`.

 `[out] ppResult`

Returns an [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md) object that contains the list of named streams retrieved.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

 The following example shows how to find all named streams that begin with `"sourcelink"` and dump their length.

```C++
CComPtr<IDiaEnumNamedStreams> pEnum;
HRESULT hr = pDataSource->findNamedStreams( L"sourcelink*", nsCaseSensitive | nsRegularExpression, &pEnum );
do {
    CComBSTR name;
    hr = pEnum->Next(&name);
    if (FAILED(hr)) {
        // report the error
        return hr;
    }
    if (hr != S_OK) {
        // End of the matches
        return S_OK;
    }
    ULONGLONG cb = 0;
    hr = pDataSource->getStreamSize(name.m_str, &cb);
    if (FAILED(hr)) {
        // report the error
        return hr;
    }
    printf("Stream Name: \"%ls\", Stream Size: %llu byte(s)\n", name.m_str, cb);
} while (true);
```

## See also

- [Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)
- [`IDiaEnumNamedSstreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
- [`IDiaDataSourceEx2`](../../debugger/debug-interface-access/idiadatasourceex2.md)
- [`NameSearchOptions` Enumeration](../../debugger/debug-interface-access/namesearchoptions.md)
- [`IDiaDataSourceEx::getStreamSize`](../../debugger/debug-interface-access/idiadatasourceex-getstreamsize.md)