---
title: 'How to: Escape Special Characters in MSBuild | Microsoft Docs'
description: Learn how to escape special characters so you can use these characters as literals in MSBuild project files.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- special characters, escaping
- characters, escapes
- escape characters
- MSBuild, escaping special characters
ms.assetid: 1aa3669c-1647-4960-b770-752e2532102f
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# How to: Escape special characters in MSBuild

Certain characters have special meaning in MSBuild project files. Examples of the characters include semicolons (`;`) and asterisks (`*`). For a complete list of these special characters, see [MSBuild special characters](../msbuild/msbuild-special-characters.md).

In order to use these special characters as literals in a project file, they must be specified by using the syntax `%<xx>`, where `<xx>` represents the ASCII hexadecimal value of the character.

## MSBuild special characters

One example of where special characters are used is in the `Include` attribute of item lists. For example, the following item list declares two items: *MyFile.cs* and *MyClass.cs*.

```xml
<Compile Include="MyFile.cs;MyClass.cs"/>
```

If you want to declare an item that contains a semicolon in the name, you must use the `%<xx>` syntax to escape the semicolon and prevent MSBuild from declaring two separate items. For example, the following item escapes the semicolon and declares one item named `MyFile.cs;MyClass.cs`.

```xml
<Compile Include="MyFile.cs%3BMyClass.cs"/>
```

You can also use a [property function](../msbuild/property-functions.md) to escape strings. For example, this is equivalent to the example above.

```xml
<Compile Include="$([MSBuild]::Escape('MyFile.cs;MyClass.cs'))" />
```

### To use an MSBuild special character as a literal character

Use the notation `%<xx>` in place of the special character, where `<xx>` represents the hexadecimal value of the ASCII character. For example, to use an asterisk (`*`) as a literal character, use the value `%2A`.

## See also
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild](../msbuild/msbuild.md)
- [Items](../msbuild/msbuild-items.md)
