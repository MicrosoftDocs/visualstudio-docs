---
title: MSBuild Special Characters | Microsoft Docs
description: Learn about the MSBuild reserved characters for special use in specific contexts, and when and how to escape these characters.
ms.custom: SEO-VS-2020
ms.date: 06/12/2019
ms.topic: conceptual
helpviewer_keywords:
- escape characters
- escape
- MSBuild Escape Characters
ms.assetid: 545e6a59-1093-4514-935e-78679a46fb3c
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild special characters

MSBuild reserves some characters for special use in specific contexts. You only have to escape such characters if you want to use them literally in the context in which they are reserved. For example, an asterisk has special meaning only in the `Include` and `Exclude` attributes of an item definition, and in calls to `CreateItem`. If you want an asterisk to appear as an asterisk in one of those contexts, you must escape it. In every other context, just type the asterisk where you want it to appear.

 To escape a special character, use the syntax %\<xx>, where \<xx> represents the ASCII hexadecimal value of the character. For more information, see [How to: Escape special characters in MSBuild](../msbuild/how-to-escape-special-characters-in-msbuild.md).

## Special characters

 The following table lists MSBuild special characters:

|**Character**|**ASCII**|**Reserved usage**|
|-------------------|---------------|------------------------|
|%|%25|Referencing metadata|
|$|%24|Referencing properties|
|@|%40|Referencing item lists|
|'|%27|Conditions and other expressions|
|(|%28|Multiple uses|
|)|%29|Multiple uses|
|;|%3B|List separator|
|?|%3F|Wildcard character for file names in `Include` and `Exclude` attributes|
|*|%2A|Wildcard character for use in file names in `Include` and `Exclude` attributes|

## See also

- [Advanced concepts](../msbuild/msbuild-advanced-concepts.md)
- [Items](../msbuild/msbuild-items.md)
