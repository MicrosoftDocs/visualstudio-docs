---
title: Comparing Properties and Items
description: Learn how MSBuild properties and items pass information to tasks, evaluate conditions, and store values that the project file can reference.
ms.date: 11/04/2016
ms.topic: language-reference
helpviewer_keywords:
- msbuild, msbuild properties
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Compare properties and items

MSBuild properties and items are both used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file.

- Properties are name-value pairs. For more information, see [MSBuild properties](../msbuild/msbuild-properties.md).

- Items are objects that typically represent files. Item objects can have associated metadata collections. Metadata are name-value pairs. For more information, see [Items](../msbuild/msbuild-items.md).

## Scalars and vectors

Because MSBuild properties are name-value pairs that have just one string value, they are often described as *scalar*. Because MSBuild item types are lists of items, they are often described as *vector*. However, in practice, properties can represent multiple values, and item types can have zero or one items.

### Target dependency injection

To see how properties can represent multiple values, consider a common usage pattern for adding a target to a list of targets to be built. This list is typically represented by a property value, with the target names separated by semicolons.

```xml
<PropertyGroup>
    <BuildDependsOn>
        BeforeBuild;
        CoreBuild;
        AfterBuild
    </BuildDependsOn>
</PropertyGroup>
```

The `BuildDependsOn` property is typically used as the argument of a target `DependsOnTargets` attribute, effectively converting it to an item list. This property can be overridden to add a target or to change the target execution order. For example,

```xml
<PropertyGroup>
    <BuildDependsOn>
        $(BuildDependsOn);
        CustomBuild;
    </BuildDependsOn>
</PropertyGroup>
```

adds the CustomBuild target to the target list, giving `BuildDependsOn` the value `BeforeBuild;CoreBuild;AfterBuild;CustomBuild`.

Starting with MSBuild 4.0, target dependency injection is deprecated. Use the `AfterTargets` and `BeforeTargets` attributes instead. For more information, see [Target build order](../msbuild/target-build-order.md).

### Conversions between strings and item lists

MSBuild performs conversions to and from item types and string values as needed. To see how an item list can become a string value, consider what happens when an item type is used as the value of an MSBuild property:

```xml
<ItemGroup>
    <OutputDir Include="KeyFiles\;Certificates\" />
</ItemGroup>
<PropertyGroup>
    <OutputDirList>@(OutputDir)</OutputDirList>
</PropertyGroup>
```

The item type OutputDir has an `Include` attribute with the value "KeyFiles\\;Certificates\\". MSBuild parses this string into two items: KeyFiles\ and Certificates\\. When the item type OutputDir is used as the value of the OutputDirList property, MSBuild converts or "flattens" the item type into to the semicolon-separated string "KeyFiles\\;Certificates\\".

## Properties and items in tasks

Properties and items are used as inputs and outputs to MSBuild tasks. For more information, see [Tasks](../msbuild/msbuild-tasks.md).

Properties are passed to tasks as attributes. Within the task, an MSBuild property is represented by a property type whose value can be converted to and from a string. The supported property types include `bool`, `char`, `DateTime`, `Decimal`, `Double`, `int`, `string`, and any type that <xref:System.Convert.ChangeType%2A> can handle.

Items are passed to tasks as <xref:Microsoft.Build.Framework.ITaskItem> objects. Within the task, <xref:Microsoft.Build.Framework.ITaskItem.ItemSpec%2A> represents the value of the item and <xref:Microsoft.Build.Framework.ITaskItem.GetMetadata%2A> retrieves its metadata.

The item list of an item type can be passed as an array of `ITaskItem` objects. Items can be removed from an item list in a target by using the `Remove` attribute. Because items can be removed from an item list, it is possible for an item type to have zero items. If an item list is passed to a task, the code in the task should check for this possibility.

## Property and item evaluation order

During the evaluation phase of a build, imported files are incorporated into the build in the order in which they appear. Properties and items are defined in three passes in the following order:

- Properties are defined and modified in the order in which they appear.

- Item definitions are defined and modified in the order in which they appear.

- Items are defined and modified in the order in which they appear.

During the execution phase of a build, properties and items that are defined within targets are evaluated together in a single phase in the order in which they appear.

However, this is not the full story. When a property, item definition, or item is defined, its value is evaluated. The expression evaluator expands the string that specifies the value. The string expansion is dependent on the build phase. Here is a more detailed property and item evaluation order:

- During the evaluation phase of a build:

  - Properties are defined and modified in the order in which they appear. Property functions are executed. Property values in the form $(PropertyName) are expanded within expressions. The property value is set to the expanded expression.

  - Item definitions are defined and modified in the order in which they appear. Property functions have already been expanded within expressions. Metadata values are set to the expanded expressions.

  - Item types are defined and modified in the order in which they appear. Item values in the form @(ItemType) are expanded. Item transformations are also expanded. Property functions and values have already been expanded within expressions. The item list and metadata values are set to the expanded expressions.

- During the execution phase of a build:

  - Properties and items that are defined within targets are evaluated together in the order in which they appear. Property functions are executed and property values are expanded within expressions. Item values and item transformations are also expanded. The property values, item type values, and metadata values are set to the expanded expressions.

### Subtle effects of the evaluation order

In the evaluation phase of a build, property evaluation precedes item evaluation. Nevertheless, properties can have values that appear to depend on item values. Consider the following script.

```xml
<ItemGroup>
    <KeyFile Include="KeyFile.cs">
        <Version>1.0.0.3</Version>
    </KeyFile>
</ItemGroup>
<PropertyGroup>
    <KeyFileVersion>@(KeyFile->'%(Version)')</KeyFileVersion>
</PropertyGroup>
<Target Name="AfterBuild">
    <Message Text="KeyFileVersion: $(KeyFileVersion)" />
</Target>
```

Executing the Message task displays this message:

```
KeyFileVersion: 1.0.0.3
```

This is because the value of `KeyFileVersion` is actually the string "\@(KeyFile->'%(Version)')". Item and item transformations were not expanded when the property was first defined, so the `KeyFileVersion` property was assigned the value of the unexpanded string.

During the execution phase of the build, when it processes the Message task, MSBuild expands the string "\@(KeyFile->'%(Version)')" to yield "1.0.0.3".

Notice that the same message would appear even if the property and item groups were reversed in order.

As a second example, consider what can happen when property and item groups are located within targets:

```xml
<Target Name="AfterBuild">
    <PropertyGroup>
        <KeyFileVersion>@(KeyFile->'%(Version)')</KeyFileVersion>
    </PropertyGroup>
    <ItemGroup>
        <KeyFile Include="KeyFile.cs">
            <Version>1.0.0.3</Version>
        </KeyFile>
    </ItemGroup>
    <Message Text="KeyFileVersion: $(KeyFileVersion)" />
</Target>
```

The Message task displays this message:

```
KeyFileVersion:
```

This is because during the execution phase of the build, property and item groups defined within targets are evaluated top to bottom at the same time. When `KeyFileVersion` is defined, `KeyFile` is unknown. Therefore, the item transformation expands to an empty string.

In this case, reversing the order of the property and item groups restores the original message:

```xml
<Target Name="AfterBuild">
    <ItemGroup>
        <KeyFile Include="KeyFile.cs">
            <Version>1.0.0.3</Version>
        </KeyFile>
    </ItemGroup>
    <PropertyGroup>
        <KeyFileVersion>@(KeyFile->'%(Version)')</KeyFileVersion>
    </PropertyGroup>
    <Message Text="KeyFileVersion: $(KeyFileVersion)" />
</Target>
```

The value of `KeyFileVersion` is set to "1.0.0.3" and not to "\@(KeyFile->'%(Version)')". The Message task displays this message:

```
KeyFileVersion: 1.0.0.3
```

## Related content

- [MSBuild properties](msbuild-properties.md)
- [MSBuild items](msbuild-items.md)
