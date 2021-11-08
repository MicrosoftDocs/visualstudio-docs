---
description: "Defines the default file name of the graphics log file."
title: "VSG_DEFAULT_RUN_FILENAME | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: ea549d2f-c857-458c-93c7-bc5a2d11d15d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# VSG_DEFAULT_RUN_FILENAME
Defines the default file name of the graphics log file.

## Syntax

```C++
#define VSG_DEFAULT_FILENAME filename
```

#### Parameters
 `filename`
 The file name given by default to the graphics log file when graphics information is captured programmatically.

## Value
 A string literal that represents the file name of the graphics log file. By default, L"default.vsglog".

```C++
#define VSG_DEFAULT_FILENAME L"default.vsglog"
```

## Remarks
 If the preprocessor symbol `DONT_SAVE_VSGLOG_TO_TEMP` is defined, then the file name is relative to the current directory of the captured app, or is an absolute path; otherwise, it's relative to the user's temporary files directory and can't be an absolute path.

 To change the defined file name, you must redefine it before you include `vsgcapture.h` in your program.

## Example
 This example shows how to change the capture file's default file name:

```C++
// Redefine the default capture filename before including vsgcapture.h
#define VSG_DEFAULT_FILENAME L"capture.vsglog"

#include <vsgcapture.h>
```

## See also
- [DONT_SAVE_VSGLOG_TO_TEMP](dont-save-vsglog-to-temp.md)
