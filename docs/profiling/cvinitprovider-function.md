---
title: CvInitProvider Function
description: See reference information for the Concurrency Visualizer SDK function CvInitProvider (C library).
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvInitProvider
helpviewer_keywords: 
  - CvInitProvider method
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# CvInitProvider function

Initializes marker provider. Must be called before any other Concurrency Visualizer SDK functions.

## Syntax

```C
HRESULT CvInitProvider(
   _In_ const GUID* pGuid,
   _Out_ PCV_PROVIDER* ppProvider
);
```

#### Parameters
 `pGuid`
 Provider guid. Cannot be NULL.

 `ppProvider`
 Address of an output variable which will store provider context. Cannot be NULL.

## Return value
 S_OK when provider is successfully initialized or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)