---
description: "Opens a session for querying symbols."
title: "IDiaDataSource::openSession | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::openSession method"
ms.assetid: a3319ed0-3979-483b-9852-c0af96852c48
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaDataSource::openSession
Opens a session for querying symbols.

## Syntax

```C++
HRESULT openSession ( 
   IDiaSession** ppSession
);
```

#### Parameters
ppSession

[out] Returns an [IDiaSession](../../debugger/debug-interface-access/idiasession.md) object representing the open session.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|E_UNEXPECTED|The [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md) object has not previously been initialized with a source of symbols.|
|E_INVALIDARG|Invalid `ppSession` parameter.|
|E_OUTOFMEMORY|Insufficient memory to open the session.|

## Remarks
This method opens an [IDiaSession](../../debugger/debug-interface-access/idiasession.md) object for a data source.

`IDiaSession` objects implement queries into the data source. A session manages one address space for each set of debug symbols. If the .exe or .dll file described by the data source symbols is active in multiple address ranges (for example, because multiple processes have it loaded), then one session for each address range should be used.

## Example

```C++
IDiaSession* pSession;
HRESULT hr = pSource->openSession( &pSession );
if (FAILED(hr))
{
   // report error
}
```

## See also
- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
- [Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [Querying the .Pdb File](../../debugger/debug-interface-access/querying-the-dot-pdb-file.md)
