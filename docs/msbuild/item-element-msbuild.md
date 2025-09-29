---
title: Item Element (MSBuild)
description: Learn how MSBuild uses the Item element to contain a user-defined item and its metadata. Every item must be a child of an ItemGroup element.
ms.date: 9/29/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- Item Element [MSBuild]
- <Item> Element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Item element (MSBuild)

Contains a user-defined item and its metadata. Every item that is used in an MSBuild project must be specified as a child of an `ItemGroup` element.

\<Project>\
&nbsp;\<ItemGroup>\
&nbsp;&nbsp;\<Item>

## Syntax

```xml
<Item Include="*.cs"
        Exclude="MyFile.cs"
        Condition="'String A'=='String B'">
    <ItemMetadata1>...</ItemMetadata1>
    <ItemMetadata2>...</ItemMetadata2>
</Item>
```

## Specify metadata as attributes

You can specify item metadata as attributes for as child elements. Any metadata with a name that doesn't conflict with the current list of attributes can be expressed as an attribute.

For example, to specify a list of NuGet packages, you would normally use something like the following syntax.

```xml
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json">
    <Version>9.0.1-beta1<Version>
  </PackageReference>
</ItemGroup>
```

Now, however, you can pass the `Version` metadata as an attribute, such as in the following syntax:

```xml
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="9.0.1-beta1" />
</ItemGroup>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Include`|Optional attribute.<br /><br /> The file or wildcard to include in the list of items.|
|`Exclude`|Optional attribute.<br /><br /> The file or wildcard to exclude from the list of items.|
|`Condition`|Optional attribute.<br /><br /> The condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|
|`Remove`|Optional attribute.<br /><br /> The file or wildcard to remove from the list of items.<br /><br />|
|`MatchOnMetadata`|Optional attribute.<br /><br /> Modifies `Remove` attributes that reference other items to match on the specified metadata names instead of matching on the referenced items' values. <br /><br /> This attribute is valid only if it's specified together with a `Remove` attribute that only contains references to other items (for example, `Remove="@(Compile);@(Content)"`). More details in [Items](../msbuild/msbuild-items.md).
|`MatchOnMetadataOptions`|Optional attribute.<br /><br /> Specifies the string matching strategy used by `MatchOnMetadata`. Possible values are `CaseSensitive`, `CaseInsensitive`, or `PathLike`. The default value is `CaseInsensitive`. |  
|`KeepDuplicates`|Optional attribute.<br /><br /> Specifies whether an item should be added to the target group if it's an exact duplicate of an existing item. If the source and target item have the same `Include` value but different metadata, the item is added even if `KeepDuplicates` is set to `false`. For more information, see [Items](../msbuild/msbuild-items.md).<br /><br /> This attribute is valid only if it's specified for an item in an `ItemGroup` that's in a `Target`.|
|`KeepMetadata`|Optional attribute.<br /><br /> The metadata for the source items to add to the target items. Only the metadata whose names are specified in the semicolon-delimited list are transferred from a source item to a target item. For more information, see [Items](../msbuild/msbuild-items.md).<br /><br /> This attribute is valid only if it's specified for an item in an `ItemGroup` that's in a `Target`.|
|`RemoveMetadata`|Optional attribute.<br /><br /> The metadata for the source items to not transfer to the target items. All metadata is transferred from a source item to a target item except metadata whose names are contained in the semicolon-delimited list of names. For more information, see [Items](../msbuild/msbuild-items.md).<br /><br /> This attribute is valid only if it's specified for an item in an `ItemGroup` that's in a `Target`.|
|`Update`|Optional attribute. (Available only for .NET Core projects in Visual Studio 2017 or later.)<br /><br /> Enables you to modify metadata of an item; typically used to override the default metadata of specific items after a group of items is initially specified (such as with a wildcard).<br /><br /> This attribute is valid only if it's specified for an item in an `ItemGroup` that is not in a `Target`.|

### Child elements

|Element|Description|
|-------------|-----------------|
|[ItemMetadata](../msbuild/itemmetadata-element-msbuild.md)|A user-defined item metadata key, which contains the item metadata value. There may be zero or more `ItemMetadata` elements in an item.|

MSBuild interprets child elements on item elements as item metadata.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ItemGroup](../msbuild/itemgroup-element-msbuild.md)|Grouping element for items.|

## Remarks

`Item` elements define inputs into the build system, and are grouped into item collections based on their user-defined collection names. These item collections can be used as parameters for [tasks](../msbuild/msbuild-tasks.md), which use the individual items in the collections to perform the steps of the build process. For more information, see [Items](../msbuild/msbuild-items.md).

Using the notation @(\<myType>) enables a collection of items of type \<myType> to be expanded into a semicolon-delimited list of strings, and passed to a parameter. If the parameter is of type `string`, then the value of the parameter is the list of elements, separated by semicolons. If the parameter is an array of strings (`string[]`), then each element is inserted into the array based on the location of the semicolons. If the task parameter is of type <xref:Microsoft.Build.Framework.ITaskItem>`[]`, then the value is the contents of the item collection together with any metadata attached. To delimit each item by using a character other than a semicolon, use the syntax @(\<myType>, '\<separator>').

The MSBuild engine can evaluate wildcards such as `*` and `?` and recursive wildcards such as */\*\*/\*.cs*. For more information, see [Items](../msbuild/msbuild-items.md).

## Examples

The following code example shows how to declare two items of type `CSFile`. The second declared item contains metadata that has `MyMetadata` set to `HelloWorld`.

```xml
<ItemGroup>
    <CSFile Include="engine.cs; form.cs" />
    <CSFile Include="main.cs" >
        <MyMetadata>HelloWorld</MyMetadata>
    </CSFile>
</ItemGroup>
```

The following code example shows how to use the `Update` attribute to modify the metadata in a file called *somefile.cs* that was included via a glob. (Available only for .NET Core projects in Visual Studio 2017 or later.)

```xml
<ItemGroup>
    <Compile Update="somefile.cs">  // or Update="*.designer.cs"
        <MetadataKey>MetadataValue</MetadataKey>
    </Compile>
</ItemGroup>
```

## See also

- [Items](../msbuild/msbuild-items.md)
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
- [MSBuild properties](../msbuild/msbuild-properties.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
