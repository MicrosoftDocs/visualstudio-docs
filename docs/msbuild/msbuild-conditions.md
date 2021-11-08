---
title: MSBuild Conditions | Microsoft Docs
description: Learn how MSBuild supports a specific set of conditions that can be applied wherever a Condition attribute is allowed.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, conditions
- conditions [MSBuild]
- Exists, MSBuild condition function
- HasTrailingSlash, MSBuild condition function
ms.assetid: 9d7aa308-b667-48ed-b4c9-a61e49eb0a85
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild conditions

MSBuild supports a specific set of conditions that can be applied wherever a `Condition` attribute is allowed. The following table explains those conditions.

|Condition|Description|
|---------------|-----------------|
|'`stringA`' == '`stringB`'|Evaluates to `true` if `stringA` equals `stringB`.<br /><br /> For example:<br /><br /> `Condition="'$(Configuration)'=='DEBUG'"`<br /><br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values. This check is case insensitive.|
|'`stringA`' != '`stringB`'|Evaluates to `true` if `stringA` is not equal to `stringB`.<br /><br /> For example:<br /><br /> `Condition="'$(Configuration)'!='DEBUG'"`<br /><br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values. This check is case insensitive.|
|\<, >, \<=, >=|Evaluates the numeric values of the operands. Returns `true` if the relational evaluation is true. Operands must evaluate to a decimal or hexadecimal number or a four-part dotted version. Hexadecimal numbers must begin with "0x". **Note:**  In XML, the characters `<` and `>` must be escaped. The symbol `<` is represented as `&lt;`. The symbol `>` is represented as `&gt;`.|
|Exists('`stringA`')|Evaluates to `true` if a file or folder with the name `stringA` exists.<br /><br /> For example:<br /><br /> `Condition="!Exists('$(Folder)')"`<br /><br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|
|HasTrailingSlash('`stringA`')|Evaluates to `true` if the specified string contains either a trailing backward slash (\\) or forward slash (/) character.<br /><br /> For example:<br /><br /> `Condition="!HasTrailingSlash('$(OutputPath)')"`<br /><br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|
|!|Evaluates to `true` if the operand evaluates to `false`.|
|`And`|Evaluates to `true` if both operands evaluate to `true`.|
|`Or`|Evaluates to `true` if at least one of the operands evaluates to `true`.|
|()|Grouping mechanism that evaluates to `true` if expressions contained inside evaluate to `true`.|
|$if$ ( %expression% ), $else$, $endif$|Checks whether the specified `%expression%` matches the string value of the passed custom template parameter. If the `$if$` condition evaluates to `true`, then its statements are run; otherwise, the `$else$` condition is checked. If the `$else$` condition is `true`, then its statements are run; otherwise, the `$endif$` condition ends expression evaluation.<br /><br /> For examples of usage, see [Visual Studio project/item template parameter logic](https://stackoverflow.com/questions/6709057/visual-studio-project-item-template-parameter-logic).|

You can use string methods in conditions, as shown in the following example, in which the [TrimEnd()](/dotnet/api/system.string.trimend) function is used to compare only the relevant part of the string, to differentiate between .NET Framework and .NET Core target frameworks.

```xml
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFrameworks>net45;net48;netstandard2.1;netcoreapp2.1;netcoreapp3.1</TargetFrameworks>
    </PropertyGroup>

    <PropertyGroup Condition="'$(TargetFramework.TrimEnd(`0123456789`))' == 'net'">
        <!-- Properties for .NET Framework -->
    </PropertyGroup>

</Project>
```

In MSBuild project files, there's no true Boolean type. Boolean data is represented in properties that might be empty or set to any value. Therefore, `'$(Prop)' == 'true'` means "if Prop is `true`," but `'$(Prop)' != 'false'` means "if Prop is `true` or unset or set to something else."

Boolean logic is only evaluated in the context of conditions, so property settings such as `<Prop2>'$(Prop1)' == 'true'</Prop>` are represented as a string (after variable expansion), not evaluated as Boolean values.  

MSBuild implements a few special processing rules to make it easier to work with string properties that are used as Boolean values. Boolean literals are accepted, so `Condition="true"` and `Condition="false"` work as expected. MSBuild also includes special rules to support the Boolean negation operator. So, if `$(Prop)` is 'true', `!$(Prop)` expands to `!true` and this compares equal to `false`, as you would expect.

## Comparing versions

The relational operators `<`, `>`, `<=`, and `>=` support versions as parsed by <xref:System.Version?displayProperty=fullName>, so you can compare versions that have four numeric parts to each other. For instance `'1.2.3.4' < '1.10.0.0'` is `true`.

> [!CAUTION]
> `System.Version` comparisons can produce surprising results when one or both versions do not specify all four parts. For instance, version 1.1 is older than version 1.1.0.

MSBuild provides [property functions to compare versions](property-functions.md#msbuild-version-comparison-functions) that have a different set of rules compatible with semantic versioning (semver).

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Conditional constructs](../msbuild/msbuild-conditional-constructs.md)
- [Walkthrough: Creating an MSBuild project file from scratch](../msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch.md)
