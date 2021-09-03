---
description: "Retrieves the file name for the last load error."
title: "IDiaDataSource::get_lastError | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::get_lastError method"
ms.assetid: cf08850b-8b75-4e8c-90bd-bd0214756f99
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaDataSource::get_lastError
Retrieves the file name for the last load error.

## Syntax

```C++
HRESULT get_lastError (
   BSTR* pRetVal
);
```

#### Parameters
 pRetVal

[out] Returns a string that contains the .pdb file name associated with the last load error.

## Return Value
 Returns the last error code caused by a load operation. Returns `E_INVALIDARG` if the `pRetVal` parameter is `NULL`.

## Example

```C++
BSTR    fileName;
HRESULT errorCode = pSource->get_lastError( &fileName );
```

## See also
- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
