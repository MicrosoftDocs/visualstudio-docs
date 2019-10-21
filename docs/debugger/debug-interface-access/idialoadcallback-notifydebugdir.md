---
title: "IDiaLoadCallback::NotifyDebugDir | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback::NotifyDebugDir method"
ms.assetid: bd04e2f6-0dbf-4742-a556-96f2cd99aa19
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLoadCallback::NotifyDebugDir
Called when a debug directory was found in the .exe file.

## Syntax

```C++
HRESULT NotifyDebugDir ( 
   BOOL  fExecutable,
   DWORD cbData,
   BYTE  data[]
);
```

#### Parameters
 `fExecutable`

[in] `TRUE` if the debug directory is read from an executable (rather than a .dbg file).

 `cbData`

[in] Count of bytes of data in the debug directory.

 `data[]`

[in] An array that is filled in with the debug directory.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. The return code is typically ignored.

## Remarks
 The [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method invokes this callback when it finds a debug directory while processing the executable file.

 This method removes the need for the client to reverse engineer the executable and/or debug file to support debug information other than that found in the .pdb file. With this data, the client can recognize the type of debug information available and whether it resides in the executable file or the .dbg file.

 Most clients will not need this callback because the `IDiaDataSource::loadDataForExe` method transparently opens both .pdb and .dbg files when necessary to serve symbols.

## See also
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)