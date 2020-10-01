---
title: "Visual Studio docs: History of what's new "
titleSuffix: ""
description: "History of what's new in Visual Studio docs"
ms.date: 09/01/2020
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
ms.assetid: 511DAFC7-896E-449A-BFF7-0E8F7BBA8A78
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: conceptual
ms.workload:
  - "multiple"
---

# History of what's new in Visual Studio docs

Welcome to the history of what's new in Visual Studio docs. This topic contains the major changes to the docs prior to August 2020 (starting July 2020). For the latest What's New, see [Visual Studio docs: What's new in the docs](whats-new-visual-studio-docs.md).

## July 2020
### Code quality

**New articles**

- [CA1417: Do not use `OutAttribute` on string parameters for P/Invokes](../code-quality/ca1417.md) - Add documentation for CA1417
- [CA1805: Do not initialize unnecessarily.](../code-quality/ca1805.md) - Add docs for CA1805
- [CA1836: Prefer IsEmpty over Count when available](../code-quality/ca1836.md) - Add documentation for CA1836 (Prefer IsEmpty over Count)
- [CA2016: Forward the CancellationToken parameter to methods that take one](../code-quality/ca2016.md) - Document CA2016 - Forward the CancellationToken parameter to methods that take one
- [CA2350: Ensure DataTable.ReadXml()'s input is trusted](../code-quality/ca2350.md) - Initial DataSet / DataTable deserialization rules docs
- [CA2351: Ensure DataSet.ReadXml()'s input is trusted](../code-quality/ca2351.md) - Initial DataSet / DataTable deserialization rules docs
- [CA2352: Unsafe DataSet or DataTable in serializable type can be vulnerable to remote code execution attacks](../code-quality/ca2352.md) - Initial DataSet / DataTable deserialization rules docs
- [CA2353: Unsafe DataSet or DataTable in serializable type](../code-quality/ca2353.md) - Initial DataSet / DataTable deserialization rules docs
- [CA2354: Unsafe DataSet or DataTable in deserialized object graph can be vulnerable to remote code execution attack](../code-quality/ca2354.md) - Initial DataSet / DataTable deserialization rules docs
- [CA2355: Unsafe DataSet or DataTable in deserialized object graph](/dotnet/fundamentals/code-analysis/quality-rules/ca2355) - Initial DataSet / DataTable deserialization rules docs
- [CA2356: Unsafe DataSet or DataTable type in web deserialized object graph](/dotnet/fundamentals/code-analysis/quality-rules/ca2356) - Initial DataSet / DataTable deserialization rules docs

### Containers

**New articles**

- [Configure Local Process with Kubernetes](/visualstudio/containers/configure-bridge-to-kubernetes) - Local Process with Kubernetes: yaml configuration
- [Use Local Process with Kubernetes (preview)](/visualstudio/containers/bridge-to-kubernetes) - Dev spaces migration
- [How Local Process with Kubernetes works](/visualstudio/containers/overview-bridge-to-kubernetes)
  - Local Process for Kubernetes: Add routing section
  - Dev spaces migration

### Cross platform

**Updated articles**

- [Change log (Visual Studio Tools for Unity, Windows)](../cross-platform/change-log-visual-studio-tools-for-unity.md) - Bump VSTU changelog to 4.7.1.0
- [Change Log (Visual Studio Tools for Unity, Mac)](../cross-platform/change-log-visual-studio-tools-for-unity-mac.md) - Bump VSTUM changelog to 2.7.1.0

### Get started

**New articles**

- [Tutorial: Extend a simple C# console app](../get-started/csharp/tutorial-console-part-2.md) - Release extend sidewalk tutorial first version

### IDE

**New articles**

- [Developer Community guidelines](./developer-community-guidelines.md) - Added DevCom Guidelines
- [IntelliSense completion for unimported types and extension methods](./reference/intellisense-completion-unimported-types-extension-methods.md)

### Install

**New articles**

- [Update Visual Studio using a minimal offline layout](../install/update-minimal-layout.md) - Document minimal layout feature
- [Visual Studio enterprise guide](../install/visual-studio-enterprise-guide.md) - Enterprise guide

### JavaScript

**New articles**

- [Compile TypeScript code (Node.js)](../javascript/compile-typescript-code-npm.md) - TypeScript compile and build
- [Compile TypeScript code (ASP.NET Core)](../javascript/compile-typescript-code-nuget.md) - TypeScript compile and build

### MSBuild

**New articles**

- [Common MSBuild item metadata](../msbuild/common-msbuild-item-metadata.md) - MSBuild: add table for optional metadata with Link and LinkBase
- [Solution filters in MSBuild](../msbuild/solution-filters.md) - MSBuild solution filters

### Test

**New articles**

- [Debug and analyze unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md) - Test Explorer performance work

**Updated articles**

- [Configure unit tests by using a *.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
  - Updates to configuring unit tests using a runsettings file
  - Blame option description was changed and example was added.