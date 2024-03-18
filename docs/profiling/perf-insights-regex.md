---
title: Perf insights for regex
description: Learn how to improve performance for regex by using .NET 5+.
ms.date: 8/10/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Improve regex performance with .NET 5+

## Cause

Regex performance has been significantly improved in .NET 5 and above. Applications that utilize a large amount of Regex processing can see improved performance by switching to .NET 5+.

## Performance insight description

Significant improvements to the [.NET Regex](/dotnet/api/system.text.regularexpressions.regex) implementation have been completed in .NET 5+. Detailed descriptions of the improvements can be found on the following .NET blogs.

- [Regex improvements in .NET 5](https://devblogs.microsoft.com/dotnet/regex-performance-improvements-in-net-5/)
- [Regex improvements in .NET 7](https://devblogs.microsoft.com/dotnet/regular-expression-improvements-in-dotnet-7/)

By testing your regex pattern against strings with [BenchmarkDotNet](https://benchmarkdotnet.org/), you can get insights into potential performance improvements.

## How to investigate a warning

For .NET Framework apps, click on the **How to update** link to go to the [.NET upgrade assistant](https://dotnet.microsoft.com/platform/upgrade-assistant), which will help migrate your project to .NET 5+. Also, please be aware that some technologies are unavailable in .NET 5+ and require more effort to update. For details, see [.NET Framework technologies unavailable on .NET Core and .NET 5+](/dotnet/core/porting/net-framework-tech-unavailable).

For .NET Core apps, the process is simpler; [download and install](https://dotnet.microsoft.com/download/dotnet) the .NET SDK version you want to use and update the target framework of your application.

Make sure your app's deployment environment has the corresponding .NET runtime version installed to prevent incompatibility issues.
