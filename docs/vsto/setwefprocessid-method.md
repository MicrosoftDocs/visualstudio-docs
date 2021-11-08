---
title: "SetWefProcessId method"
description: Learn how the SetWefProcessId method provides the process identifier that will run Web Extensions Framework (WEF) content.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# SetWefProcessId method
  Provides the process identifier that will run Web Extensions Framework (WEF) content.

## Syntax

```csharp
HRESULT SetWefProcessId(
    [in] DWORD dwProcessId
);
```

#### Parameters

|Parameter|Description|
|---------------|-----------------|
|*dwProcessId*|The process identifier that will be used to run WEF content.|

## Return value
 An HRESULT value that indicates whether the method completed successfully.

## Remarks
 This method must be called after the WEF content process is created but before any WEF content runs.

 If you want the development environment to attach a debugger to the WEF content process, the environment must perform this operation in your implementation of this method.
