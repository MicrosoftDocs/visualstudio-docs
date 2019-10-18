---
title: Supported Roslyn package version mappings
ms.date: 04/29/2019
ms.topic: reference
helpviewer_keywords:
  - "roslyn package versions"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "vssdk"
---
# .NET compiler platform package version reference

The following table shows which [.NET compiler platform (Roslyn) package](https://www.nuget.org/packages/Microsoft.Net.Compilers/) versions are supported for different versions of Visual Studio.

As an example, to ensure that your custom analyzer works on all versions of Visual Studio 2017, it should target version 2.0 of Microsoft.Net.Compilers.

| Roslyn package version | Minimum supported Visual Studio version |
| - | - |
| 3.x | Visual Studio 2019 |
| 2.10.0 | Visual Studio 2017 version 15.9 |
| 2.9.0 | Visual Studio 2017 version 15.8 |
| 2.8.2 | Visual Studio 2017 version 15.7 |
| 2.7.0 | Visual Studio 2017 version 15.6 |
| 2.6.1 | Visual Studio 2017 version 15.5 |
| 2.4.0 | Visual Studio 2017 version 15.4 |
| 2.3.2 | Visual Studio 2017 version 15.3 |
| 2.2.0 | Visual Studio 2017 version 15.2 |
| 2.1.0 | Visual Studio 2017 version 15.1 |
| 2.0.0 | Visual Studio 2017 RTM |
| 1.3.2 | Visual Studio 2015 update 3 |
| 1.2.2 | Visual Studio 2015 update 2 |
| 1.1.1 | Visual Studio 2015 update 1 |
| 1.0.1 | Visual Studio 2015 RTM |

> [!TIP]
> For Roslyn packages where the minimum supported Visual Studio version is a Visual Studio 2017 version, all versions of Visual Studio 2019 are also supported because they came later.

## See also

- [.NET Compiler Platform SDK](/dotnet/csharp/roslyn-sdk/)
- [Get started with Roslyn analyzers](getting-started-with-roslyn-analyzers.md)