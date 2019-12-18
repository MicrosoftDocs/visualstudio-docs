---
title: "VsgDbg::VsgDbg (Constructor) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 670651e6-5e79-4845-b0c2-671beb7055a8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# VsgDbg::VsgDbg (Constructor)
Constructs an instance of the `VsgDbg` class with or without preparing the in-app component of graphics diagnostics to actively capture and record graphics information by default, based on the specified Boolean parameter.

## Syntax

```C++
VsgDbg(
  bDefaultInit
);
```

#### Parameters
 `bDefaultInit`
 `true` to specify that the in-app component of graphics diagnostics is to be prepared to actively capture and record graphics information; `false` to specify that the app should not be prepared to actively capture and record graphics information at this time.

## Remarks
 When the constructor is called with `bDefaultInit` set to `true`, the file name of the graphics log file is determined by how the `DONT_SAVE_VSGLOG_TO_TEMP` and `VSG_DEFAULT_RUN_FILENAME` preprocessor symbols are defined before `vsgcapture.h` is included in your app.

 When the constructor is called with `bDefaultInit` set to `false`, the in-app component of graphics diagnostics can be prepared to actively capture and record graphics information at a later time by calling the `Init` function.

## See also
- [VsgDbg::~VsgDbg (Destructor)](vsgdbg-tilde-vsgdbg-destructor.md)
- [Init](init.md)
- [DONT_SAVE_VSGLOG_TO_TEMP](dont-save-vsglog-to-temp.md)
- [VSG_DEFAULT_RUN_FILENAME](vsg-default-run-filename.md)