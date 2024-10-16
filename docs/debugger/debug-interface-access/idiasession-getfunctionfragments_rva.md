---
description: Retrieves the addresses and lengths of discontiguous fragments for the function at the specified relative virtual address (RVA).
title: "IDiaSession::getFunctionFragments_RVA"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getFunctionFragments_RVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getFunctionFragments_RVA

Retrieves the addresses and lengths of discontiguous fragments for the function at the specified relative virtual address (RVA).

## Syntax

```C++
HRESULT getFunctionFragments_RVA(
    DWORD rvaFunc,
    DWORD cbFunc,
    DWORD cFragments,
    DWORD *pRvaFragment,
    DWORD *pLenFragment
);
```

#### Parameters

 `rvaFunc`

[in] The relative virtual address of the function.

 `cbFunc`

[in] The total size in bytes of the function (that is, the length of the function).

`cFragments`

[in] The count of elements allocated for `pRvaFragment` and `pLenFragment`.

 `pRvaFragment`

[out] Array buffer to receive the relative virtual addresses of each fragment. This must be at least `cFragments` long.

 `pLenFragment`

[out] Array buffer to receive the length, in bytes, of each fragment. This must be at least `cFragments` long.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

 ## Example

 This shows how to retrieve the address and length of a function via `IDiaSymbol`, then the number of fragments, retrieve the set of function fragments and then print them as a list of start and end addresses.

 ```C++
HRESULT PrintFunctionFragments(CComPtr<IDiaSymbol> pFunc) {
    DWORD rvaStart = 0;
    ULONGLONG cbFunc = 0;

    HRESULT hr = pFunc->get_relativeVirtualAddress(&rvaStart);
    if (FAILED(hr)) {
        return hr;
    }
    hr = pFunc->get_length(&cbFunc);
    if (FAILED(hr)) {
        return hr;
    }

    DWORD cFragments = 0;

    hr = pSession->getNumberOfFunctionFragments_RVA(rvaStart, (DWORD) cbFunc, &cFragments);
    if (FAILED(hr)) {
        return hr;
    }

    DWORD * rgRVA = new (std::nothrow) DWORD[cFragments];
    if (rgRVA == nullptr) {
        return E_OUTOFMEMORY;
    }

    DWORD * rgLen = new (std::nothrow) DWORD[cFragments];
    if (rgLen == nullptr) {
        delete[] rgRVA;
        return E_OUTOFMEMORY;
    }

    hr = pSession->getFunctionFragments_RVA(rvaStart, (DWORD) cbFunc, cFragments, rgRVA, rgLen);
    if (FAILED(hr)) {
        delete[] rgRVA;
        delete[] rgLen;
        return hr;

    }
    for (DWORD i = 0; i < cFragments; i++) {
        printf("  %08X -- %08X\n", rgRVA[i], rgRVA[i] + rgLen[i] - 1);
    }

    delete [] rgRVA;
    delete [] rgLen;

    return S_OK;
}
```

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::getNumberOfFunctionFragments_RVA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_rva.md)
