---
title: MSBuild Best Practices | Microsoft Docs
description: Learn about best practices for writing MSBuild scripts, such as using Condition attributes and not using wildcards.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- best practices, MSBuild
- MSBuild, best practices
ms.assetid: 90ef8693-e921-410a-a377-fe4d13f58c48
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild best practices

We recommend the following best practices for writing MSBuild scripts:

- Default property values are best handled by using the `Condition` attribute, and not by declaring a property whose default value can be overridden on the command line. For example, use

```xml
<MyProperty Condition="'$(MyProperty)' == ''">
   MyDefaultValue
</MyProperty>
```

- In general, avoid the use of wildcards when you select items. Instead, specify files explicitly. This is because in most project types, MSBuild expands wildcards at various times, such as when adding or removing items, which can lead to unexpected behavior. An exception to this is in .NET Core SDK-style projects, which do process wildcards correctly.

## See also

- [Advanced concepts](../msbuild/msbuild-advanced-concepts.md)
