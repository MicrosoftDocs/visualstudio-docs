---
title: "GetVstoSolutionMetadata function"
description: Learn how the GetVstoSolutionMetadata API supports the Office infrastructure and isn't intended to be used directly from your code.
ms.date: "02/02/2017"
ms.topic: "reference"
f1_keywords:
  - GetVstoSolutionMetadata
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# GetVstoSolutionMetadata function

  This API supports the Office infrastructure and isn't intended to be used directly from your code.

## Syntax

```csharp
HRESULT WINAPI GetVstoSolutionMetadata(
    LPCWSTR lpwszSolutionMetadataKey,
    ISolutionMetadata** ppSolutionInfo
);
```

### Parameters

|Parameter|Description|
|---------------|-----------------|
|*lpwszSolutionMetadataKey*|Don't use.|
|*ppSolutionInfo*|Don't use.|

## Return value
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.
