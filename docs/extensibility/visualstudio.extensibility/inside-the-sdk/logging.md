---
title: Logging Reference
description: A reference for Logging
date: 2021-8-16
---

# Logging extension diagnostics

Each extension part can inject a `TraceSource` instance that is created as part of the extensibility framework. Extension developers are strongly recommended to utilize this instance for diagnostics as it will allow integration with future tools on Visual Studio diagnostics.

## Accessing log entries

Currently the logs are output to `%TEMP%\VSLogs` directory in `svclog` XML format. This format allows logs from multiple processes to be correlated to each other and can be opened by [Microsoft Service Trace Viewer](https://docs.microsoft.com/dotnet/framework/wcf/service-trace-viewer-tool-svctraceviewer-exe) tool. This tool should already be available on machines with Visual Studio as it is part of .NET Framework tools.
