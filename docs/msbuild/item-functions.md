---
title: "Item Functions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "msbuild, Item functions"
ms.assetid: 5e6df3cc-2db8-4cbd-8fdd-3ffd03ac0876
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Item functions
Starting with MSBuild 4.0, code in tasks and targets can call item functions to get information about the items in the project. These functions simplify getting Distinct() items and are faster than looping through the items.

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
|`Count`|`@(MyItem->Count())`|Returns the count of the items.|
|`DirectoryName`|`@(MyItem->DirectoryName())`|Returns the equivalent of `Path.DirectoryName` for each item.|
|`Distinct`|`@(MyItem->Distinct())`|Returns items that have distinct `Include` values. Metadata is ignored. The comparison is case insensitive.|
|`DistinctWithCase`|`@(MyItem->DistinctWithCase())`|Returns items that have distinct `itemspec` values. Metadata is ignored. The comparison is case sensitive.|
|`Reverse`|`@(MyItem->Reverse())`|Returns the items in reverse order.|
|`AnyHaveMetadataValue`|`@(MyItem->AnyHaveMetadataValue("MetadataName", "MetadataValue"))`|Returns a `boolean` to indicate whether any item has the given metadata name and value. The comparison is case insensitive.|
|`ClearMetadata`|`@(MyItem->ClearMetadata())`|Returns items with their metadata cleared. Only the `itemspec` is retained.|
|`HasMetadata`|`@(MyItem->HasMetadata("MetadataName"))`|Returns items that have the given metadata name. The comparison is case insensitive.|
|`Metadata`|`@(MyItem->Metadata("MetadataName"))`|Returns the values of the metadata that have the metadata name.|
|`WithMetadataValue`|`@(MyItem->WithMetadataValue("MetadataName", "MetadataValue"))`|Returns items that have the given metadata name and value. The comparison is case insensitive.|

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

## See also
- [Items](../msbuild/msbuild-items.md)
