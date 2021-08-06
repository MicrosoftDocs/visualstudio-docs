---
title: "Copy (Programmatic Capture) | Microsoft Docs"
description: Use the Copy method of the VsgDbg class to copy the contents of the active graphics log (.vsglog) file into a new file.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 30ec235a-0abb-44b9-8852-61bc9e67ce22
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Copy (Programmatic Capture)
Copies the contents of the active graphics log (.vsglog) file into a new file.

## Syntax

```C++
void Copy(
  wchar_t const * szNewVSGLog
);
```

#### Parameters
 `szNewVSGLog`
 The file name of the new graphics log file.

## Remarks
 To copy the graphics information to a new file, you must already have captured some graphics information; otherwise, nothing happens.