---
title: ItemGroup Element (MSBuild) | Microsoft Docs
description: Learn about the MSBuild ItemGroup element, which contains a set of user-defined Item elements. Every item must be a child of an ItemGroup.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ItemGroup
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- ItemGroup element [MSBuild]
- <ItemGroup> element [MSBuild]
ms.assetid: aac894e3-a9f1-4bbc-a796-6ef07001f35b
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# ItemGroup element (MSBuild)

Contains a set of user-defined [Item](../msbuild/item-element-msbuild.md) elements. Every item used in an MSBuild project must be specified as a child of an `ItemGroup` element.

\<Project>
\<ItemGroup>

## Syntax

```xml
<ItemGroup Condition="'String A' == 'String B'"
           Label="Label">
    <Item1>... </Item1>
    <Item2>... </Item2>
</ItemGroup>
```

## Attributes and elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Condition`|Optional attribute. Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|
|`Label`|Optional attribute. Identifies the `ItemGroup`. |

### Child elements

|Element|Description|
|-------------|-----------------|
|[Item](../msbuild/item-element-msbuild.md)|Defines the inputs for the build process. There may be zero or more `Item` elements in an `ItemGroup`.|

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an MSBuild project file. |
| [Target](../msbuild/target-element-msbuild.md) | Starting with .NET Framework 3.5, the `ItemGroup` element can appear inside a `Target` element. For more information, see [Targets](../msbuild/msbuild-targets.md). |

## Example

The following code example shows the user-defined item collections `Res` and `CodeFiles` declared inside of an `ItemGroup` element. Each of the items in the `Res` item collection contains a user-defined child [ItemMetadata](../msbuild/itemmetadata-element-msbuild.md) element.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <ItemGroup>
        <Res Include = "Strings.fr.resources" >
            <Culture>fr</Culture>
        </Res>
        <Res Include = "Dialogs.fr.resources" >
            <Culture>fr</Culture>
        </Res>

        <CodeFiles Include="**\*.cs" Exclude="**\generated\*.cs" />
        <CodeFiles Include="..\..\Resources\Constants.cs" />
    </ItemGroup>
...
</Project>
```

In a simple project file, you normally use a single `ItemGroup` element, but you can also use multiple `ItemGroup` elements. When multiple `ItemGroup` elements are used, items are combined into a single `ItemGroup`. For example, some items might be included by a separate `ItemGroup` element that's defined in an imported file.

ItemGroups can have conditions applied by using the `Condition` attribute. In that case, the items are only added to the item list if the condition is satisfied. See [MSBuild conditions](msbuild-conditions.md)

The `Label` attribute is used in some build systems as a way to control build behaviors. You can use it only in declarations, as a way to create more understandable MSBuild scripts, or as a control setting to affect build actions.

## See also

- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [Items](../msbuild/msbuild-items.md)
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
