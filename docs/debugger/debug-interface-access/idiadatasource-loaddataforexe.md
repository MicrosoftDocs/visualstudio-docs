---
title: "IDiaDataSource::loadDataForExe | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::loadDataForExe method"
ms.assetid: d94a1068-f53f-44b5-b6fb-00dec361a7f2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaDataSource::loadDataForExe
Opens and prepares the debug data associated with the .exe/.dll file.

## Syntax

```C++
HRESULT loadDataForExe (
   LPCOLESTR executable,
   LPCOLESTR searchPath,
   IUnknown* pCallback
);
```

#### Parameters
executable

[in] Path to the .exe or .dll file.

searchPath

[in] Alternate path to search for debug data.

pCallback

[in] An `IUnknown` interface for an object that supports a debug callback interface, such as the [IDiaLoadCallback](../../debugger/debug-interface-access/idialoadcallback.md), [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md), the [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md), and/or the [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md) interfaces.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code. The following table shows some of the possible error codes for this method.

|Value|Description|
|-----------|-----------------|
|E_PDB_NOT_FOUND|Failed to open the file, or the file has an invalid format.|
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|
|E_PDB_INVALID_SIG|Signature does not match.|
|E_PDB_INVALID_AGE|Age does not match.|
|E_INVALIDARG|Invalid parameter.|
|E_UNEXPECTED|Data source has already been prepared.|

## Remarks
The debug header of the .exe/.dll file names the associated debug data location.

This method reads the debug header and then searches for and prepares the debug data. The progress of the search may, optionally, be reported and controlled through callbacks. For example, the [IDiaLoadCallback::NotifyDebugDir](../../debugger/debug-interface-access/idialoadcallback-notifydebugdir.md) is invoked when the `IDiaDataSource::loadDataForExe` method finds and processes a debug directory.

The [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md) and [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md) interfaces allow the client application to provide alternative methods for reading data from the executable file when the file cannot be accessed directly through standard file I/O.

To load a .pdb file without validation, use the [IDiaDataSource::loadDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md) method.

To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md) method.

To load a .pdb file directly from memory, use the [IDiaDataSource::loadDataFromIStream](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md) method.

## Example

```C++
class MyCallBack: public IDiaLoadCallback
{
...
};
MyCallBack callback;
...
HRESULT hr = pSource->loadDataForExe( L"myprog.exe", L".\debug", (IUnknown*)&callback);
if (FAILED(hr))
{
    // Report error
}
```

## See also
- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
- [IDiaLoadCallback](../../debugger/debug-interface-access/idialoadcallback.md)
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
- [IDiaLoadCallback::NotifyDebugDir](../../debugger/debug-interface-access/idialoadcallback-notifydebugdir.md)
- [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)
- [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
- [IDiaDataSource::loadDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md)
- [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md)
- [IDiaDataSource::loadDataFromIStream](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md)
