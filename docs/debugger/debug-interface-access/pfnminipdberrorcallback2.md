---
description: Provides the file name and error code for the last load error for fastlink PDBs.
title: "PFNMINIPDBERRORCALLBACK2"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "PFNMINIPDBERRORCALLBACK2 typedef"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# PFNMINIPDBERRORCALLBACK2

Provides the file name and error code for the last load error for fastlink PDBs.

## Syntax

```c++
typedef HRESULT __cdecl (*PFNMINIPDBERRORCALLBACK2)(
  void* pvContext, 
  DWORD dwErrorCode, 
  const LPCOLESTR szObjOrPdb, 
  const LPCOLESTR szLib
);
```

#### Parameters

pvContext

[in] The context that was passed into the call to the [IDiaDataSourceEx::setPfnMiniPDBErrorCallback2](../../debugger/debug-interface-access/idiadatasourceex-setpfnminipdberrorcallback2.md) method.

dwErrorCode

[in] The error code describing the particular error. Although typed as a `DWORD` this is really a `HRESULT`. The most common values are `E_PDB_CORRUPT`, `E_DIA_COFF_ACCESS`, and `E_DIA_COMP_PDB_ACCESS`.

szObjOrPdb

[in] The name of the OBJ or PDB file that is related to the error.

szLib

[in] If `szObjOrPdb` refers to an OBJ file within a LIB file, this is the name of the LIB. Otherwise it is `nullptr`.

## Return Value

The return value is ignored. 

## Example

```c++
HRESULT __cdecl ReportMiniPDBError(void *pvContext, DWORD hr, const wchar_t *szObjOrPdb, const wchar_t *szLib)
{
  wprintf(L"Callback on fastlink PDB: hr = 0x%08x, szObjOrPdb=\"%ls\", szLib=\"%ls\"\n", hr, szObjOrPdb, szLib);
  *reinterpret_cast<bool*>(pvContext) = true;
  return S_OK;
}
...
  bool callbackCalled = false;
  HRESULT hr = pSourceEx->setPfnMiniPDBErrorCallback2(&callbackCalled, ReportMiniPDBError);
...
```

## See also

- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
- [IDiaDataSourceEx](../../debugger/debug-interface-access/idiadatasourceex.md)
- [IDiaDataSourceEx::setPfnMiniPDBErrorCallback2](../../debugger/debug-interface-access/idiadatasourceex-setpfnminipdberrorcallback2.md)
- [Common HRESULT Values (Debug Interface Access SDK)](../../debugger/debug-interface-access/common-hresult-values.md)
