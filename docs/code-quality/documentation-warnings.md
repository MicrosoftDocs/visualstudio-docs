---
title: Documentation Warnings
ms.date: 09/16/2019
ms.topic: reference
f1_keywords:
  - "vs.codeanalysis.documentationrules"
helpviewer_keywords:
  - "documentation warnings"
  - "managed code analysis warnings, documentation warnings"
  - "warnings, documentation"
author: mavasani
ms.author: mavasani
manager: jillfra
ms.workload:
  - "multiple"
---
# Documentation warnings

Documentation warnings aid writing well documented libraries through the correct use of [xml documentation comments](https://docs.microsoft.com/dotnet/csharp/codedoc) for the externally visible APIs.

## In This Section

| Rule | Description |
| - | - |
| [CA1200: Avoid using cref tags with a prefix](../code-quality/ca1200.md) | The [cref](https://docs.microsoft.com/dotnet/csharp/programming-guide/xmldoc/cref-attribute) attribute in an XML documentation tag means "code reference." It specifies that the inner text of the tag is a code element, such as a type, method, or property. Use of cref tags with prefixes should be avoided, since it prevents the compiler from verifying references and the Visual Studio IDE from finding these symbol references and updating them during refactorings. |