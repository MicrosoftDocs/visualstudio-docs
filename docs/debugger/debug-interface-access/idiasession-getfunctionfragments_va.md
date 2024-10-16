---
description: Retrieves the addresses and lengths of discontiguous fragments for the function at the specified virtual address (VA).
title: "IDiaSession::getFunctionFragments_VA"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getFunctionFragments_VA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getFunctionFragments_VA

Retrieves the addresses and lengths of discontiguous fragments for the function at the specified virtual address (VA).

## Syntax

```C++
HRESULT getFunctionFragments_VA(
    ULONGLONG vaFunc,
    DWORD cbFunc,
    DWORD cFragments,
    ULONGLONG *pVaFragment,
    DWORD *pLenFragment
);
```

#### Parameters

 `vaFunc`

[in] The virtual address of the function.

 `cbFunc`

[in] The total size in bytes of the function (that is, the length of the function).

`cFragments`

[in] The count of elements allocated for `pVaFragment` and `pLenFragment`.

 `pVaFragment`

[out] Array buffer to receive the virtual addresses of each fragment. This must be at least `cFragments` long.

 `pLenFragment`

[out] Array buffer to receive the length, in bytes, of each fragment. This must be at least `cFragments` long.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

 ## Example

 This shows how to retrieve the address and length of a function via `IDiaSymbol`, then the number of fragments, retrieve the set of function fragments and then print them as a list of start and end addresses.

 ```C++
HRESULT PrintFunctionFragments(CComPtr<IDiaSymbol> pFunc) {
    ULONGLONG vaStart = 0;
    ULONGLONG cbFunc = 0;

    HRESULT hr = pFunc->get_relativeVirtualAddress(&vaStart);
    if (FAILED(hr)) {
        return hr;
    }
    hr = pFunc->get_length(&cbFunc);
    if (FAILED(hr)) {
        return hr;
    }

    DWORD cFragments = 0;

    hr = pSession->getNumberOfFunctionFragments_VA(vaStart, (DWORD) cbFunc, &cFragments);
    if (FAILED(hr)) {
        return hr;
    }

    ULONGLONG * rgVA = new (std::nothrow) ULONGLONG[cFragments];
    if (rgVA == nullptr) {
        return E_OUTOFMEMORY;
    }

    DWORD * rgLen = new (std::nothrow) DWORD[cFragments];
    if (rgLen == nullptr) {
        delete[] rgVA;
        return E_OUTOFMEMORY;
    }

    hr = pSession->getFunctionFragments_VA(vaStart, (DWORD) cbFunc, cFragments, rgVA, rgLen);
    if (FAILED(hr)) {
        delete[] rgVA;
        delete[] rgLen;
        return hr;

    }
    for (DWORD i = 0; i < cFragments; i++) {
        printf("  %016llX -- %016llX\n", rgVA[i], rgVA[i] + rgLen[i] - 1);
    }

    delete [] rgVA;
    delete [] rgLen;

    return S_OK;
}
```

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::getNumberOfFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_va.md)
