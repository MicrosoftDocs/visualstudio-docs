---
title: FxCopCmd errors
ms.date: 10/19/2016
description: Learn about the error codes that the FxCopCmd command returns. See which type of error each code represents, and find out how to recognize fatal errors.
ms.custom: SEO-VS-2020
ms.topic: reference
helpviewer_keywords:
  - "FxCopCmd errors"
ms.assetid: bb614ed0-1b7c-4b56-99ae-da50ef6cfef9
ms.author: mikejo
author: mikejo5000
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
  - "multiple"
---
# FxCopCmd tool errors

FxCopCmd does not consider all errors to be fatal. If FxCopCmd has sufficient information to perform a partial analysis, it performs the analysis and reports errors that occurred. The error code, which is a 32-bit integer, contains a bitwise combination of numeric values that correspond to errors.

The following table describes the error codes returned by FxCopCmd:

|Error|Numeric value|
|-----------|-------------------|
|No errors|0x0|
|Analysis error|0x1|
|Rule exceptions|0x2|
|Project load error|0x4|
|Assembly load error|0x8|
|Rule library load error|0x10|
|Import report load error|0x20|
|Output error|0x40|
|Command line switch error|0x80|
|Initialization error|0x100|
|Assembly references error|0x200|
|BuildBreakingMessage|0x400|
|Unknown error|0x1000000|

**Analysis error** is returned for fatal errors. It indicates that the analysis could not be completed. When applicable, the error code also contains the underlying cause of the fatal error. The following conditions generate fatal errors:

- The analysis could not be performed because of insufficient input.

- The analysis threw an exception that is not handled by FxCopCmd.

- The specified project file could not be found or is corrupted.

- The output option was not specified or the file could not be written.

> [!NOTE]
> The FxCopCmd return code **Assembly references error** 0x200 by itself is a warning rather than an error. This return code indicates that there are missing indirect references, but that FxCopCmd was able to handle them. The warning means there's a possibility that some analysis results might have been compromised. Treat **Assembly references error** as an error when it is combined with any other return code.

## See also

- [Code Analysis Application Errors](../code-quality/code-analysis-application-errors.md)
