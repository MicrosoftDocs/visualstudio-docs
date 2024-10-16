---
description: Opens and prepares the debug data associated with the .exe/.dll file, with optional record prefetching.
title: "IDiaDataSourceEx::loadDataForExeEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::loadDataForExeEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::loadDataForExeEx

Opens and prepares the debug data associated with the .exe/.dll file, with optional record prefetching.

## Syntax

```c++
HRESULT loadDataForExeEx (
   LPCOLESTR executable,
   LPCOLESTR searchPath,
   IUnknown* pCallback,
   BOOL      fPdbPrefetching
);
```

#### Parameters

`executable`

[in] Path to the .exe or .dll file.

`searchPath`

[in] Alternate path to search for debug data. Multiple paths should be semicolon delimited. Paths may contain a trailing `\`.

`pCallback`

[in] An `IUnknown` interface for an object that supports a debug callback interface, such as the [`IDiaLoadCallback`](../../debugger/debug-interface-access/idialoadcallback.md), [`IDiaLoadCallback2`](../../debugger/debug-interface-access/idialoadcallback2.md), the [`IDiaReadExeAtOffsetCallback`](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md), and/or the [`IDiaReadExeAtRVACallback`](../../debugger/debug-interface-access/idiareadexeatrvacallback.md) interfaces.

`fPdbPrefetching`

[in] If set to `TRUE`, adjacent debug records are prefetched into memory, potentially replacing many smaller file I/O operations with fewer, larger operations, and thus improving overall throughput as those records are subsequently accessed, at the expense of potentially increased memory usage. If set to `FALSE`, this behaves identically to [`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md). If set to some other value, behavior is unspecified.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The following table shows some of the possible error codes for this method.

|Value|Description|
|-----------|-----------------|
|`E_PDB_NOT_FOUND`|Failed to open the file, or the file has an invalid format.|
|`E_PDB_FORMAT`|Attempted to access a file with an obsolete format.|
|`E_PDB_INVALID_SIG`|Signature does not match.|
|`E_PDB_INVALID_AGE`|Age does not match.|
|`E_INVALIDARG`|Invalid parameter.|
|`E_UNEXPECTED`|Data source has already been prepared.|

## Remarks

The debug header of the .exe/.dll file names the associated debug data location.

If you are loading debug data from a symbol server, *symsrv.dll* must be present in the same directory where either the user's application or *msdia140.dll* is installed, or it must be present in the system directory.

This method reads the debug header and then searches for and prepares the debug data. The progress of the search may, optionally, be reported and controlled through callbacks. For example, the [`IDiaLoadCallback::NotifyDebugDir`](../../debugger/debug-interface-access/idialoadcallback-notifydebugdir.md) is invoked when the `IDiaDataSourceEx::loadDataForExeEx` method finds and processes a debug directory.

The [`IDiaReadExeAtOffsetCallback`](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md) and [`IDiaReadExeAtRVACallback`](../../debugger/debug-interface-access/idiareadexeatrvacallback.md) interfaces allow the client application to provide alternative methods for reading data from the executable file when the file cannot be accessed directly through standard file I/O.

To load a .pdb file without validation, use the [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md) method.

To validate the .pdb file against specific criteria, use the [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md) method.

To load a .pdb file directly from memory, use the [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md) method.

To validate a .pdb file without loading it, use the [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md) method.

## Example

```c++
class MyCallBack: public IDiaLoadCallback
{
...
};
MyCallBack callback;
...
HRESULT hr = pSource->loadDataForExeEx( L"myprog.exe", L".\debug", (IUnknown*)&callback, TRUE);
if (FAILED(hr))
{
    // Report error
}
```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceEx.md)
- [`IDiaLoadCallback`](../../debugger/debug-interface-access/idialoadcallback.md)
- [`IDiaLoadCallback2`](../../debugger/debug-interface-access/idialoadcallback2.md)
- [`IDiaLoadCallback::NotifyDebugDir`](../../debugger/debug-interface-access/idialoadcallback-notifydebugdir.md)
- [`IDiaReadExeAtOffsetCallback`](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)
- [`IDiaReadExeAtRVACallback`](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
- [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md)
- [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)
- [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md)
- [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md)
