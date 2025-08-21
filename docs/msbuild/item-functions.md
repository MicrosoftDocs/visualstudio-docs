---
title: Call item functions from MSBuild code
description: Explore how MSBuild code in tasks and targets can call item functions to get information about the items in the project.
ms.date: 7/2/2025
ms.topic: how-to
helpviewer_keywords:
- msbuild, Item functions
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Work with item functions

Code in tasks and targets can call item functions to get information about the items in the project (in MSBuild 4.0 and later). These functions simplify getting distinct items and are faster than looping through the items.

## String item functions

You can use string methods and properties in the .NET Framework to operate on any item value. For <xref:System.String> methods, specify the method name. For <xref:System.String> properties, specify the property name after "get_".

For items that have multiple strings, the string method or property runs on each string.

The following example shows how to use these string item functions.

```xml
<ItemGroup>
    <theItem Include="andromeda;tadpole;cartwheel" />
</ItemGroup>

<Target Name = "go">
    <Message Text="IndexOf  @(theItem->IndexOf('r'))" />
    <Message Text="Replace  @(theItem->Replace('tadpole', 'pinwheel'))" />
    <Message Text="Length   @(theItem->get_Length())" />
    <Message Text="Chars    @(theItem->get_Chars(2))" />
</Target>

  <!--
  Output:
    IndexOf  3;-1;2
    Replace  andromeda;pinwheel;cartwheel
    Length   9;7;9
    Chars    d;d;r
  -->
```

## Intrinsic item functions

The table below lists the intrinsic functions available for items.

|Function|Example|Description|
|--------------|-------------|-----------------|
|`Combine`|`@(MyItems->Combine('path'))`|Returns a new set of items with a given relative path appended to all the input items.|
|`Count`|`@(MyItems->Count())`|Returns the count of the items.|
|`DirectoryName`|`@(MyItems->DirectoryName())`|Returns the equivalent of `Path.DirectoryName` for each item.|
|`Distinct`|`@(MyItems->Distinct())`|Returns items that have distinct `Include` values. Metadata is ignored. The comparison is case insensitive.|
|`DistinctWithCase`|`@(MyItems->DistinctWithCase())`|Returns items that have distinct `itemspec` values. Metadata is ignored. The comparison is case sensitive.|
|`Exists`|`@(MyItems->Exists())`|Filters a set of items to those that actually exist on disk.|
|`GetPathsOfAllDirectoriesAbove`| `@(MyItems->GetPathsOfAllFilesAbove())`|Given a set of items, returns items representing all the ancestor directories. No order is guaranteed.|
|`Reverse`|`@(MyItems->Reverse())`|Returns the items in reverse order.|
|`AnyHaveMetadataValue`|`@(MyItems->AnyHaveMetadataValue('MetadataName', 'MetadataValue'))` | Returns a `boolean` to indicate whether any item has the given metadata name and value. The comparison is case insensitive. |
|`ClearMetadata`|`@(MyItems->ClearMetadata())` |Returns items with their metadata cleared. Only the `itemspec` is retained.|
|`HasMetadata`|`@(MyItems->HasMetadata('MetadataName'))`|Returns items that have the given metadata name. The comparison is case insensitive.|
|`Metadata`|`@(MyItems->Metadata('MetadataName'))`|Returns the values of the metadata that have the metadata name. The items returned have the same metadata as the source values.|
|`WithMetadataValue`|`@(MyItems->WithMetadataValue('MetadataName', 'MetadataValue'))`|Returns items that have the given metadata name and value. The comparison is case insensitive.|
|`WithoutMetadataValue`|`@(MyItems->WithoutMetadataValue('MetadataName', 'MetadataValue'))`| (VS 17.8+) Returns items that have don't have the given metadata value. The comparison is case insensitive.|

> [!NOTE]
> `Exists` can also be used in other contexts; in [MSBuild conditions](msbuild-conditions.md), for example `Condition="Exists('path')"`; or in [Static property functions](property-functions.md), for example `$([System.IO.File]::Exists("path"))`.

The following example shows how to use intrinsic item functions.

```xml
<ItemGroup>
    <TheItem Include="first">
        <Plant>geranium</Plant>
    </TheItem>
    <TheItem Include="second">
        <Plant>algae</Plant>
    </TheItem>
    <TheItem Include="third">
        <Plant>geranium</Plant>
    </TheItem>
</ItemGroup>

<Target Name="go">
    <Message Text="MetaData:    @(TheItem->Metadata('Plant'))" />
    <Message Text="HasMetadata: @(theItem->HasMetadata('Plant'))" />
    <Message Text="WithMetadataValue: @(TheItem->WithMetadataValue('Plant', 'geranium'))" />
    <Message Text=" " />
    <Message Text="Count:   @(theItem->Count())" />
    <Message Text="Reverse: @(theItem->Reverse())" />
</Target>

  <!--
  Output:
    MetaData:    geranium;algae;geranium
    HasMetadata: first;second;third
    WithMetadataValue: first;third

    Count:   3
    Reverse: third;second;first
  -->
```
## Calling a String method

If an item function isn't available that matches your scenario, you can achieve a similar effect by creating a string object from the metadata using the `new` property function, and call any `String` method on it. For example, the following code uses a substring search to filter an item list in a target.

```xml
<Project>
  <PropertyGroup>
    <SearchString>abc</SearchString>
  </PropertyGroup>

  <ItemGroup>
    <UnfilteredList Include="abcdef;abc;def;xyz"></UnfilteredList>
  </ItemGroup>

  <Target Name="FilterItemList">

    <ItemGroup>
      <FilteredList Include="@(UnfilteredList)" Condition="$([System.String]::new('%(UnfilteredList.Identity)').Contains($(SearchString)))"></FilteredList>
    </ItemGroup>

    <Message Text="Result: @(FilteredList)"/>
  </Target>
</Project>
```
## Detecting duplicates when using the Metadata item function

The `Metadata` item function preserves the original metadata of the source items. This has some implications when considering whether the items returned are duplicates or not. To control how duplicate items are handled, you can use the attribute [KeepDuplicates](./msbuild-items.md#BKMK_KeepDuplicates). You can also remove the metadata, if it's not needed, by adding the [RemoveMetadata](./msbuild-items.md#BKMK_RemoveMetadata), in which case only the values themselves are considered when detecting duplicates.

```xml
  <Target Name="MetadataToItem">
    <ItemGroup>
      <Sample Include="AAA" SomeItems="1;2;3" />
      <Sample Include="BBB" SomeItems="3;4;5" />
    </ItemGroup>

    <ItemGroup>
      <AllSomeItems Include="@(Sample->Metadata('SomeItems'))" KeepDuplicates="false" />
    </ItemGroup>
    <Message Text="AllSomeItems is @(AllSomeItems)" />
  </Target>
```

The output is as follows:

```output
MetadataToItem:
  AllSomeItems is 1;2;3;3;4;5
```

The following change to the code results in the duplicate item value being successfully detected and removed:

```xml
    <ItemGroup>
      <AllSomeItems Include="@(Sample->Metadata('SomeItems'))" KeepDuplicates="false" RemoveMetadata="SomeItems" />
    </ItemGroup>
```

## MSBuild condition functions

The function `HasTrailingSlash` is not an item function. It is available for use with the `Condition` attribute. See [MSBuild conditions](msbuild-conditions.md).

## Related content

You can also use attributes to perform operations on item lists, such as filtering on item metadata. For more information, see [Items](../msbuild/msbuild-items.md).
