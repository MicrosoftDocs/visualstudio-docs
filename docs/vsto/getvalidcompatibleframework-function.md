---
title: "GetValidCompatibleFramework function"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# GetValidCompatibleFramework function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.

## Syntax

```csharp
HRESULT WINAPI GetValidCompatibleFramework(
    LPCWSTR lpwszCompatibleFrameworksXML,
    BSTR* pbstrValidFrameworkTag
);
```

### Parameters

|Parameter|Description|
|---------------|-----------------|
|*lpwszCompatibleFrameworksXML*|Don't use.|
|*pbstrValidFrameworkTag*|Don't use.|

## Return value
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.
