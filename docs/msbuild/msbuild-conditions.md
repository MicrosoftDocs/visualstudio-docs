---
title: MSBuild Conditions
description: Learn how MSBuild supports a specific set of conditions that can be applied wherever a Condition attribute is allowed.
ms.date: 11/01/2023
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, conditions
- conditions [MSBuild]
- Exists, MSBuild condition function
- HasTrailingSlash, MSBuild condition function
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild conditions

MSBuild supports a specific set of conditions that can be applied wherever a `Condition` attribute is allowed; see [Supported elements](#supported-elements). The following table explains those conditions.

|Condition|Description|
|---------------|-----------------|
|'`stringA`' == '`stringB`'|Evaluates to `true` if `stringA` equals `stringB`.<br /><br /> For example:<br /><br /> `Condition="'$(Configuration)'=='DEBUG'"`<br /><br /> Single quotes aren't required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values. This check is case insensitive.|
|`'stringA' != 'stringB'`|Evaluates to `true` if `stringA` isn't equal to `stringB`.<br /><br /> For example:<br /><br /> `Condition="'$(Configuration)'!='DEBUG'"`<br /><br /> Single quotes aren't required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values. This check is case insensitive.|
|\<, >, \<=, >=|Evaluates the numeric values of the operands. Returns `true` if the relational evaluation is true. Operands must evaluate to a decimal or hexadecimal number or a four-part dotted version. Hexadecimal numbers must begin with `0x`. **Note:**  In XML, the characters `<` and `>` must be escaped. The symbol `<` is represented as `&lt;`. The symbol `>` is represented as `&gt;`.|
|Exists('`stringA`')|Evaluates to `true` if a file or folder with the name `stringA` exists.<br /><br /> For example:<br /><br /> `Condition="!Exists('$(Folder)')"`<br /><br /> Single quotes aren't required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values. This condition doesn't expand wildcards such as `*`.|
|HasTrailingSlash('`stringA`')|Evaluates to `true` if the specified string contains either a trailing backward slash (\\) or forward slash (/) character.<br /><br /> For example:<br /><br /> `Condition="!HasTrailingSlash('$(OutputPath)')"`<br /><br /> Single quotes aren't required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|
|!|Evaluates to `true` if the operand evaluates to `false`.|
|`And`|Evaluates to `true` if both operands evaluate to `true`.|
|`Or`|Evaluates to `true` if at least one of the operands evaluates to `true`.|
|()|Grouping mechanism that evaluates to `true` if expressions contained inside evaluate to `true`.|
|`$if$ ( %expression% ), $else$, $endif$`|Checks whether the specified `%expression%` matches the string value of the passed custom template parameter. If the `$if$` condition evaluates to `true`, then its statements are run; otherwise, the `$else$` condition is checked. If the `$else$` condition is `true`, then its statements are run; otherwise, the `$endif$` condition ends expression evaluation.<br /><br /> For examples of usage, see [Visual Studio project/item template parameter logic](https://stackoverflow.com/questions/6709057/visual-studio-project-item-template-parameter-logic).|

The `Condition` element is a single string, and so any strings that are used in the expression, including around property values, need to be enclosed with a single-quote. Spaces between operators are allowed and commonly used for readability, but they're not required.

To use the Boolean `And` and `Or` operators, specify operands inside the `Condition` element's string value, as in the following example:

```xml
Condition="'$(Configuration)' == 'Debug' And '$(MSBuildProjectExtension)' == '.csproj'"
```

You can chain the Boolean operators. Operator `And` has higher precedence than `Or`, but for clarity, we recommend that you use parentheses when you use multiple Boolean operators to make the order of evaluation explicit. If you don't, MSBuild gives warning MSB4130.

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

MSBuild implements a few special processing rules to make it easier to work with string properties that are used as Boolean values. Boolean literals are accepted, so `Condition="true"` and `Condition="false"` work as expected. MSBuild also includes special rules to support the Boolean negation operator. So, if `$(Prop)` is 'true', `!$(Prop)` expands to `!true` and this value compares equal to `false`, as you would expect.

## Comparing versions

The relational operators `<`, `>`, `<=`, and `>=` support versions as parsed by <xref:System.Version?displayProperty=fullName>, so you can compare versions that have four numeric parts to each other. For instance, `'1.2.3.4' < '1.10.0.0'` is `true`.

> [!CAUTION]
> `System.Version` comparisons can produce surprising results when one or both versions do not specify all four parts. For instance, version 1.1 is older than version 1.1.0.

MSBuild provides [property functions to compare versions](property-functions.md#msbuild-version-comparison-functions) that have a different set of rules compatible with semantic versioning (semver).

## Expansions in conditions

Depending on the position in the project file, you can use expansions for properties ($), item lists (@), and item metadata (%). The expansions depend on [how MSBuild processes project files](./build-process-overview.md).

### Properties

A condition that contains an expression such as `$(SomeProperty)` is evaluated and converted to the property value. If the condition is outside of a target, the expression is evaluated during the evaluation of the project file. The value of the property is dependent on the position in the project file after expanding all imports. If the condition is in a target, then it's evaluated when the target executes, and the value is affected by any changes that occur during execution of the build. 

A property that isn't defined at the point in the expanded project file where the condition expression occurs evaluates to an empty string, without any diagnostic error or warning.

### Item lists

A condition that contains an @-expression such as `@(SomeItems)` is expanded in item groups at the top level and in targets.

Items can depend on any property, and can depend on items that are already defined in sequence.

The reason is that MSBuild processes project files in several passes. The item evaluation pass occurs after the initial property evaluation and import expansion pass. Therefore, @-expressions are allowed in any condition that is evaluated after items have begun to be defined. That is, in items, item groups, and in targets.

### Metadata

A condition that contains a metadata expression such as `%(ItemMetadata)` is expanded in the same contexts as item lists, that is, in item groups at the top level and in targets. However, expansion can have different behavior in an item group depending on whether the item group is outside of a target or inside of a target. Also, of the various forms of metadata expressions, `%(ItemName.MetadataName)`, `%(JustTheMetadataName)`, and `@(ItemName->'%(MetadataName)')`, only the item transform (the last one) is allowed outside of a target. The value of an %-expression in a target is evaluated at run-time and depends on any state changes during target execution. The execution of the target and the value of any %-expressions contained within it is also dependent on the batching of the target and can also trigger batching; see [MSBuild batching](msbuild-batching.md).

## Supported elements

The following elements support the `Condition` attribute:

- Import
- ImportGroup
- Item
- ItemDefinitionGroup
- ItemGroup
- ItemMetadata
- OnError
- Output
- Property
- PropertyGroup
- Target
- Task
- UsingTask
- When

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Conditional constructs](../msbuild/msbuild-conditional-constructs.md)
- [Walkthrough: Creating an MSBuild project file from scratch](../msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch.md)
