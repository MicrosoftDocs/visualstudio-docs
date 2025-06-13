---
title: Logging extension diagnostics
description: Learn how to use logging to store information about the execution of an extension at runtime in VisualStudio.Extensibility
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Logging extension diagnostics

Each extension part can inject a [`TraceSource`](/dotnet/api/microsoft.visualstudio.extensibility.extensibilitypoint.tracesource) instance that is created as part of the extensibility framework. Extension developers are recommended to utilize this instance for diagnostics as it will allow integration with future tools on Visual Studio diagnostics.

## Accessing log entries

Currently the logs are output to `%TEMP%\VSLogs` directory in `svclog` XML format. This format allows logs from multiple processes to be correlated to each other and can be opened by [Microsoft Service Trace Viewer](/dotnet/framework/wcf/service-trace-viewer-tool-svctraceviewer-exe) tool. This tool should already be available on machines with Visual Studio as it is part of .NET Framework tools.

## Related content

- [Components of a VisualStudio.Extensibility extension](./extension-anatomy.md).
