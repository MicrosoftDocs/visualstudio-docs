---
title: MSBuild Best Practices | Microsoft Docs
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- best practices, MSBuild
- MSBuild, best practices
ms.assetid: 90ef8693-e921-410a-a377-fe4d13f58c48
author: ghogen
ms.author: ghogen
manager: jillfra
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

- Any custom `.props` files should be simple and single-purpose, and `.props` files should not include other `.props` files.

  The only exception to this is *Directory.Build.props*. Because property values can be overridden, the value at any time in the process depends on the order in which MSBuild processes a script. It can be difficult to trace why property values have the values they do at various stages in the build process, and this practice helps you more easily diagnose such issues.

## See also
- [Advanced concepts](../msbuild/msbuild-advanced-concepts.md)
