---
title: MSBuild Best Practices
description: Learn about best practices for writing MSBuild scripts, such as using Condition attributes and not using wildcards.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- best practices, MSBuild
- MSBuild, best practices
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
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

## Related content

- [How MSBuild builds projects](./build-process-overview.md)
