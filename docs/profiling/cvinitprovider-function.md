---
title: CvInitProvider Function | Microsoft Docs
description: See reference information for the Concurrency Visualizer SDK function CvInitProvider (C library).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvInitProvider
helpviewer_keywords: 
  - CvInitProvider method
ms.assetid: ba1863ad-e35f-4d34-a2f2-5e68957d1915
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
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