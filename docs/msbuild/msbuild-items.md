---
title: Use MSBuild items and item types
description: Use the MSBuild items and item types, work with lists of items by using and modifying item metadata and review the Exclude attribute.
ms.date: 06/01/2023
ms.topic: language-reference
helpviewer_keywords:
- MSBuild, Items
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild items

MSBuild items are inputs into the build system, and they typically represent files (the files are specified in the `Include` attribute). Items are grouped into item types based on their element names. Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process.

 Because items are named by the item type to which they belong, the terms "item" and "item value" can be used interchangeably.

## Create items in a project file

 You declare items in the project file as child elements of an [ItemGroup](../msbuild/itemgroup-element-msbuild.md) element. Valid item names begin with an uppercase or lowercase letter or underscore (`_`); valid subsequent characters include alphanumeric characters (letters or digits), underscore, and hyphen (`-`). The name of the child element is the type of the item. The `Include` attribute of the element specifies the items (files) to be included with that item type. For example, the following XML creates an item type that's named `Compile`, which includes two files.

```xml
<ItemGroup>
    <Compile Include = "file1.cs"/>
    <Compile Include = "file2.cs"/>
</ItemGroup>
```

 The item *file2.cs* doesn't replace the item *file1.cs*; instead, the file name is appended to the list of values for the `Compile` item type.

 The following XML creates the same item type by declaring both files in one `Include` attribute. Notice that the file names are separated by a semicolon.

```xml
<ItemGroup>
    <Compile Include = "file1.cs;file2.cs"/>
</ItemGroup>
```

The `Include` attribute is a path that is interpreted relative to the project file's folder, `$(MSBuildProjectPath)`, even if the item is in an imported file such as a `.targets` file.

## Create items during execution

 Items that are outside [Target](../msbuild/target-element-msbuild.md) elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, items can be created or modified in the following ways:

- Any task can emit an item. To emit an item, the [Task](../msbuild/task-element-msbuild.md) element must have a child [Output](../msbuild/output-element-msbuild.md) element that has an `ItemName` attribute.

- The [CreateItem](../msbuild/createitem-task.md) task can emit an item. This usage is deprecated.

- `Target` elements may contain [ItemGroup](../msbuild/itemgroup-element-msbuild.md) elements that may contain item elements.

## Reference items in a project file

 To reference item types throughout the project file, you use the syntax `@(ItemType)`. For example, you would reference the item type in the previous example by using `@(Compile)`. By using this syntax, you can pass items to tasks by specifying the item type as a parameter of that task. For more information, see [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md).

 By default, the items of an item type are separated by semicolons (;) when it's expanded. You can use the syntax `@(ItemType, 'separator')` to specify a separator other than the default. For more information, see [How to: Display an item list separated with commas](../msbuild/how-to-display-an-item-list-separated-with-commas.md).

## Use wildcards to specify items

You can use the `**`, `*`, and `?` wildcard characters to specify a group of files as inputs for a build instead of listing each file separately.

- The `?` wildcard character matches a single character.
- The `*` wildcard character matches zero or more characters.
- The `**` wildcard character sequence matches a partial path.

For example, you can specify all the `.cs` files in the directory that contains the project file by using the following element in your project file.

```xml
<CSFile Include="*.cs"/>
```

The following element selects all `.vb` files on the `D:` drive:

```xml
<VBFile Include="D:/**/*.vb"/>
```

If you would like to include literal `*` or `?` characters in an item without wildcard expansion, you must [escape the wildcard characters](../msbuild/how-to-escape-special-characters-in-msbuild.md).

For more information about wildcard characters, see [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md).

## Use the Exclude attribute

 Item elements can contain the `Exclude` attribute, which excludes specific items (files) from the item type. The `Exclude` attribute is typically used together with wildcard characters. For example, the following XML adds every *.cs* file in the directory to the `CSFile` item type, except the *DoNotBuild.cs* file.

```xml
<ItemGroup>
    <CSFile  Include="*.cs"  Exclude="DoNotBuild.cs"/>
</ItemGroup>
```

 The `Exclude` attribute affects only the items that are added by the `Include` attribute in the item element that contains them both. The following example wouldn't exclude the file *Form1.cs*, which was added in the preceding item element.

```xml
<Compile Include="*.cs" />
<Compile Include="*.res" Exclude="Form1.cs">
```

 For more information, see [How to: Exclude files from the build](../msbuild/how-to-exclude-files-from-the-build.md).

## Item metadata

 Items may contain metadata in addition to the information in the `Include` and `Exclude` attributes. This metadata can be used by tasks that require more information about the items or to batch tasks and targets. For more information, see [Batching](../msbuild/msbuild-batching.md).

 Metadata is a collection of key-value pairs that are declared in the project file as child elements of an item element. The name of the child element is the name of the metadata, and the value of the child element is the value of the metadata.

 The metadata is associated with the item element that contains it. For example, the following XML adds `Culture` metadata that has the value `Fr` to both the *one.cs* and the *two.cs* items of the `CSFile` item type.

```xml
<ItemGroup>
    <CSFile Include="one.cs;two.cs">
        <Culture>Fr</Culture>
    </CSFile>
</ItemGroup>
```

 An item can have zero or more metadata values. You can change metadata values at any time. If you set metadata to an empty value, you effectively remove it from the build.

### <a name="BKMK_ReferencingItemMetadata"></a> Reference item metadata in a project file

 You can reference item metadata throughout the project file by using the syntax `%(ItemMetadataName)`. If ambiguity exists, you can qualify a reference by using the name of the item type. For example, you can specify `%(ItemType.ItemMetaDataName)`. The following example uses the `Display` metadata to batch the `Message` task. For more information about how to use item metadata for batching, see [Item metadata in task batching](../msbuild/item-metadata-in-task-batching.md).

```xml
<Project>
    <ItemGroup>
        <Stuff Include="One.cs" >
            <Display>false</Display>
        </Stuff>
        <Stuff Include="Two.cs">
            <Display>true</Display>
        </Stuff>
    </ItemGroup>
    <Target Name="Batching">
        <Message Text="@(Stuff)" Condition=" '%(Display)' == 'true' "/>
    </Target>
</Project>
```

### <a name="BKMK_WellKnownItemMetadata"></a> Well-known item metadata

 When an item is added to an item type, that item is assigned some well-known metadata. For example, all items have the well-known metadata `%(Filename)`, whose value is the file name of the item (without the extension). For more information, see [Well-known item metadata](../msbuild/msbuild-well-known-item-metadata.md).

### <a name="BKMK_Transforming"></a> Transform item types by using metadata

 You can transform item lists into new item lists by using metadata. For example, you can transform an item type `CppFiles` that has items that represent `.cpp` files into a corresponding list of `.obj` files by using the expression `@(CppFiles -> '%(Filename).obj')`.

 The following code creates a `CultureResource` item type that contains copies of all `EmbeddedResource` items with `Culture` metadata. The `Culture` metadata value becomes the value of the new metadata `CultureResource.TargetDirectory`.

```xml
<Target Name="ProcessCultureResources">
    <ItemGroup>
        <CultureResource Include="@(EmbeddedResource)"
            Condition="'%(EmbeddedResource.Culture)' != ''">
            <TargetDirectory>%(EmbeddedResource.Culture) </TargetDirectory>
        </CultureResource>
    </ItemGroup>
</Target>
```

For more operations on items, see [MSBuild item functions](item-functions.md) and [Transforms](../msbuild/msbuild-transforms.md).

## Item definitions

 You can add default metadata to any item type by using the [ItemDefinitionGroup element](../msbuild/itemdefinitiongroup-element-msbuild.md). Like well-known metadata, the default metadata is associated with all items of the item type that you specify. You can explicitly override default metadata in an item definition. For example, the following XML gives the `Compile` items *one.cs* and *three.cs* the metadata `BuildDay` with the value "Monday". The code gives the item *two.cs* the metadata `BuildDay` with the value "Tuesday".

```xml
<ItemDefinitionGroup>
    <Compile>
        <BuildDay>Monday</BuildDay>
    </Compile>
</ItemDefinitionGroup>
<ItemGroup>
    <Compile Include="one.cs;three.cs" />
    <Compile Include="two.cs">
        <BuildDay>Tuesday</BuildDay>
    </Compile>
</ItemGroup>
```

For more information, see [Item definitions](../msbuild/item-definitions.md).

## Attributes for items in an ItemGroup of a Target

`Target` elements may contain [ItemGroup](../msbuild/itemgroup-element-msbuild.md) elements that may contain item elements. The attributes in this section are valid when they're specified for an item in an `ItemGroup` that's in a `Target`.

### <a name="BKMK_RemoveAttribute"></a> Remove attribute

The `Remove` attribute removes specific items (files) from the item type. This attribute was introduced in the .NET Framework 3.5 (inside targets only). Both inside and outside targets are supported starting in MSBuild 15.0.

The following example removes every `.config` file from the `Compile` item type.

```xml
<Target>
    <ItemGroup>
        <Compile Remove="*.config"/>
    </ItemGroup>
</Target>
```

#### MatchOnMetadata attribute

The `MatchOnMetadata` attribute is applicable only to `Remove` attributes that reference other items (for example, `Remove="@(Compile);@(Content)"`) and instructs the `Remove` operation to match items based on the values of specified metadata names, instead of matching based on the item values.

Matching rule for `B Remove="@(A)" MatchOnMetadata="M"`: remove all items from `B` that have metadata `M`, whose metadata value `V` for `M` matches any item from `A` with metadata `M` of value `V`.

```xml
<Project>
  <ItemGroup>
    <A Include='a1' M1='1' M2='a' M3="e"/>
    <A Include='b1' M1='2' M2='x' M3="f"/>
    <A Include='c1' M1='3' M2='y' M3="g"/>
    <A Include='d1' M1='4' M2='b' M3="h"/>

    <B Include='a2' M1='x' m2='c' M3="m"/>
    <B Include='b2' M1='2' m2='x' M3="n"/>
    <B Include='c2' M1='2' m2='x' M3="o"/>
    <B Include='d2' M1='3' m2='y' M3="p"/>
    <B Include='e2' M1='3' m2='Y' M3="p"/>
    <B Include='f2' M1='4'        M3="r"/>
    <B Include='g2'               M3="s"/>

    <B Remove='@(A)' MatchOnMetadata='M1;M2'/>
  </ItemGroup>

  <Target Name="PrintEvaluation">
    <Message Text="%(B.Identity) M1='%(B.M1)' M2='%(B.M2)' M3='%(B.M3)'" />
  </Target>
</Project>
```

In the example, item values `b2`, `c2`, and `d2` are removed from item `B` because:
 - `b2` and `c2` from `B` match against `b1` from `A` on `M1=2` and `M2=x`
 - `d2` from `B` matches against `c1` from `A` on `M1=3` and `M2=y`

The `Message` task outputs the following:
```
  a2 M1='x' M2='c' M3='m'
  e2 M1='3' M2='Y' M3='p'
  f2 M1='4' M2='' M3='r'
  g2 M1='' M2='' M3='s'
```

Example usage of `MatchOnMetadata` from [MSBuild](https://github.com/dotnet/msbuild/blob/808b2ae2a176679d15f8c3299e551a63cb55b799/src/Tasks/Microsoft.Common.CurrentVersion.targets#L5019):
```xml
      <_TransitiveItemsToCopyToOutputDirectory Remove="@(_ThisProjectItemsToCopyToOutputDirectory)" MatchOnMetadata="TargetPath" MatchOnMetadataOptions="PathLike" />
```
This line removes items from `_TransitiveItemsToCopyToOutputDirectory` that have the same `TargetPath` metadata values from items in `_ThisProjectItemsToCopyToOutputDirectory`

#### MatchOnMetadataOptions attribute

Specifies the string matching strategy used by `MatchOnMetadata` for matching the metadata values between items (metadata names are always matched case insensitive). Possible values are `CaseSensitive`, `CaseInsensitive`, or `PathLike`. The default value is `CaseSensitive`.

`PathLike` applies path-aware normalization to the values like normalizing slash orientations, ignoring trailing slashes, eliminating `.` and `..`, and making all relative paths absolute against the current directory.

### <a name="BKMK_KeepMetadata"></a> KeepMetadata attribute

 If an item is generated within a target, the item element can contain the `KeepMetadata` attribute. If this attribute is specified, only the metadata that is specified in the semicolon-delimited list of names will be transferred from the source item to the target item. An empty value for this attribute is equivalent to not specifying it. The `KeepMetadata` attribute was introduced in the .NET Framework 4.5.

 The following example illustrates how to use the `KeepMetadata` attribute.

```xml
<Project>
    <ItemGroup>
        <FirstItem Include="rhinoceros">
            <Class>mammal</Class>
            <Size>large</Size>
        </FirstItem>

    </ItemGroup>
    <Target Name="MyTarget">
        <ItemGroup>
            <SecondItem Include="@(FirstItem)" KeepMetadata="Class" />
        </ItemGroup>

        <Message Text="FirstItem: %(FirstItem.Identity)" />
        <Message Text="  Class: %(FirstItem.Class)" />
        <Message Text="  Size:  %(FirstItem.Size)"  />

        <Message Text="SecondItem: %(SecondItem.Identity)" />
        <Message Text="  Class: %(SecondItem.Class)" />
        <Message Text="  Size:  %(SecondItem.Size)"  />
    </Target>
</Project>

<!--
Output:
  FirstItem: rhinoceros
    Class: mammal
    Size:  large
  SecondItem: rhinoceros
    Class: mammal
    Size:
-->
```

### <a name="BKMK_RemoveMetadata"></a> RemoveMetadata attribute

 If an item is generated within a target, the item element can contain the `RemoveMetadata` attribute. If this attribute is specified, all metadata is transferred from the source item to the target item except metadata whose names are contained in the semicolon-delimited list of names. An empty value for this attribute is equivalent to not specifying it. The `RemoveMetadata` attribute was introduced in the .NET Framework 4.5.

 The following example illustrates how to use the `RemoveMetadata` attribute.

```xml
<Project>

    <PropertyGroup>
        <MetadataToRemove>Size;Material</MetadataToRemove>
    </PropertyGroup>

    <ItemGroup>
        <Item1 Include="stapler">
            <Size>medium</Size>
            <Color>black</Color>
            <Material>plastic</Material>
        </Item1>
    </ItemGroup>

    <Target Name="MyTarget">
        <ItemGroup>
            <Item2 Include="@(Item1)" RemoveMetadata="$(MetadataToRemove)" />
        </ItemGroup>

        <Message Text="Item1: %(Item1.Identity)" />
        <Message Text="  Size:     %(Item1.Size)" />
        <Message Text="  Color:    %(Item1.Color)" />
        <Message Text="  Material: %(Item1.Material)" />
        <Message Text="Item2: %(Item2.Identity)" />
        <Message Text="  Size:     %(Item2.Size)" />
        <Message Text="  Color:    %(Item2.Color)" />
        <Message Text="  Material: %(Item2.Material)" />
    </Target>
</Project>

<!--
Output:
  Item1: stapler
    Size:     medium
    Color:    black
    Material: plastic
  Item2: stapler
    Size:
    Color:    black
    Material:
-->
```

For more operations on items, see [MSBuild item functions](item-functions.md).

### <a name="BKMK_KeepDuplicates"></a> KeepDuplicates attribute

 If an item is generated within a target, the item element can contain the `KeepDuplicates` attribute. `KeepDuplicates` is a `Boolean` attribute that specifies whether an item should be added to the target group if the item is an exact duplicate of an existing item.

 If the source and target item have the same `Include` value but different metadata, the item is added even if `KeepDuplicates` is set to `false`. An empty value for this attribute is equivalent to not specifying it. The `KeepDuplicates` attribute was introduced in the .NET Framework 4.5.

 The following example illustrates how to use the `KeepDuplicates` attribute.

```xml
<Project>

    <ItemGroup>
        <Item1 Include="hourglass;boomerang" />
        <Item2 Include="hourglass;boomerang" />
    </ItemGroup>

    <Target Name="MyTarget">
        <ItemGroup>
            <Item1 Include="hourglass" KeepDuplicates="false" />
            <Item2 Include="hourglass" />
        </ItemGroup>

        <Message Text="Item1: @(Item1)" />
        <Message Text="  %(Item1.Identity)  Count: @(Item1->Count())" />
        <Message Text="Item2: @(Item2)" />
        <Message Text="  %(Item2.Identity)  Count: @(Item2->Count())" />
    </Target>
</Project>

<!--
Output:
  Item1: hourglass;boomerang
    hourglass  Count: 1
    boomerang  Count: 1
  Item2: hourglass;boomerang;hourglass
    hourglass  Count: 2
    boomerang  Count: 1
-->
```

Because the `KeepDuplicates` attribute considers the metadata of items in addition to the item values, it's important to know what's happening with the metadata. For example, see [Detecting duplicates when using the Metadata item function](./item-functions.md#detecting-duplicates-when-using-the-metadata-item-function).

## Updating metadata on items in an ItemGroup outside of a Target

Items outside of targets can have their existing metadata updated via the `Update` attribute. This attribute is **not** available for items under targets.

```xml
<Project>
    <PropertyGroup>
        <MetadataToUpdate>pencil</MetadataToUpdate>
    </PropertyGroup>

    <ItemGroup>
        <Item1 Include="stapler">
            <Size>medium</Size>
            <Color>black</Color>
            <Material>plastic</Material>
        </Item1>
        <Item1 Include="pencil">
            <Size>small</Size>
            <Color>yellow</Color>
            <Material>wood</Material>
        </Item1>
        <Item1 Include="eraser">
            <Color>red</Color>
        </Item1>
        <Item1 Include="notebook">
            <Size>large</Size>
            <Color>white</Color>
            <Material>paper</Material>
        </Item1>

        <Item2 Include="notebook">
            <Size>SMALL</Size>
            <Color>YELLOW</Color>
        </Item2>

        <!-- Metadata can be expressed either as attributes or as elements -->
        <Item1 Update="$(MetadataToUpdate);stapler;er*r;@(Item2)" Price="10" Material="">
            <Color>RED</Color>
        </Item1>
    </ItemGroup>

    <Target Name="MyTarget">
        <Message Text="Item1: %(Item1.Identity)
    Size: %(Item1.Size)
    Color: %(Item1.Color)
    Material: %(Item1.Material)
    Price: %(Item1.Price)" />
    </Target>
</Project>

<!--  
Item1: stapler
    Size: medium
    Color: RED
    Material:
    Price: 10
Item1: pencil
    Size: small
    Color: RED
    Material:
    Price: 10
Item1: eraser
    Size:
    Color: RED
    Material:
    Price: 10
Item1: notebook
    Size: large
    Color: RED
    Material:
    Price: 10
-->
```

In MSBuild version 16.6 and later, the `Update` attribute supports qualified metadata references to facilitate importing metadata from two or more items.

```xml
<Project>
    <ItemGroup>
        <Item1 Include="stapler">
            <Size>medium</Size>
            <Color>black</Color>
            <Material>plastic</Material>
        </Item1>
        <Item1 Include="pencil">
            <Size>small</Size>
            <Color>yellow</Color>
            <Material>wood</Material>
        </Item1>
        <Item1 Include="eraser">
            <Size>small</Size>
            <Color>red</Color>
            <Material>gum</Material>
        </Item1>
        <Item1 Include="notebook">
            <Size>large</Size>
            <Color>white</Color>
            <Material>paper</Material>
        </Item1>

        <Item2 Include="pencil">
            <Size>MEDIUM</Size>
            <Color>RED</Color>
            <Material>PLASTIC</Material>
            <Price>10</Price>
        </Item2>

        <Item3 Include="notebook">
            <Size>SMALL</Size>
            <Color>BLUE</Color>
            <Price>20</Price>
        </Item3>

        <!-- Metadata can be expressed either as attributes or as elements -->
        <Item1 Update="@(Item2);er*r;@(Item3)" Size="%(Size)" Color="%(Item2.Color)" Price="%(Item3.Price)" Model="2020">
            <Material Condition="'%(Item2.Material)' != ''">Premium %(Item2.Material)</Material>
        </Item1>
    </ItemGroup>

    <Target Name="MyTarget">
        <Message Text="Item1: %(Item1.Identity)
    Size: %(Item1.Size)
    Color: %(Item1.Color)
    Material: %(Item1.Material)
    Price: %(Item1.Price)
    Model: %(Item1.Model)" />
    </Target>
</Project>

<!--  
Item1: stapler
    Size: medium
    Color: black
    Material: plastic
    Price:
    Model:
Item1: pencil
    Size: small
    Color: RED
    Material: Premium PLASTIC
    Price:
    Model: 2020
Item1: eraser
    Size: small
    Color:
    Material: gum
    Price:
    Model: 2020
Item1: notebook
    Size: large
    Color:
    Material: paper
    Price: 20
    Model: 2020
-->
```

Remarks:
- Unqualified metadata (`%(MetadataName)`) binds to the item type being updated (`Item1` in above example). Qualified metadata (`%(Item2.Color)`) binds inside the set of captured matching item types from the Update expression.
- If an item matches multiple times within and between multiple referenced items:
  - The last occurrence from each referenced item type gets captured (so one captured item per item type).
  - This matches the behavior of task item batching under targets.
- Where one can put %() references:
  - Metadata
  - Metadata conditions
- Metadata name matching is case-insensitive.

## Updating metadata on items in an ItemGroup of a Target

Metadata can be modified inside targets too, by a less expressive syntax than `Update`:

```xml
<Project>
    <ItemGroup>
        <Item1 Include="stapler">
            <Size>medium</Size>
            <Color>black</Color>
            <Material>plastic</Material>
        </Item1>
        <Item1 Include="pencil">
            <Size>small</Size>
            <Color>yellow</Color>
            <Material>wood</Material>
        </Item1>
        <Item1 Include="eraser">
            <Size>small</Size>
            <Color>red</Color>
            <Material>gum</Material>
        </Item1>
        <Item1 Include="notebook">
            <Size>large</Size>
            <Color>white</Color>
            <Material>paper</Material>
        </Item1>

        <Item2 Include="pencil">
            <Size>MEDIUM</Size>
            <Color>RED</Color>
            <Material>PLASTIC</Material>
            <Price>10</Price>
        </Item2>

        <Item2 Include="ruler">
            <Color>GREEN</Color>
        </Item2>

    </ItemGroup>

    <Target Name="MyTarget">
        <ItemGroup>
            <!-- Metadata can be expressed either as attributes or as elements -->
            <Item1 Size="GIGANTIC" Color="%(Item2.Color)">
                <Material Condition="'%(Item2.Material)' != ''">Premium %(Item2.Material)</Material>
            </Item1>
        </ItemGroup>

        <Message Text="Item1: %(Item1.Identity)
    Size: %(Item1.Size)
    Color: %(Item1.Color)
    Material: %(Item1.Material)
    Price: %(Item1.Price)
    Model: %(Item1.Model)" />
    </Target>
</Project>

<!--  
Item1: stapler
    Size: GIGANTIC
    Color: GREEN
    Material: Premium PLASTIC
    Price:
    Model:
Item1: pencil
    Size: GIGANTIC
    Color: GREEN
    Material: Premium PLASTIC
    Price:
    Model:
Item1: eraser
    Size: GIGANTIC
    Color: GREEN
    Material: Premium PLASTIC
    Price:
    Model:
Item1: notebook
    Size: GIGANTIC
    Color: GREEN
    Material: Premium PLASTIC
    Price:
    Model:
-->
```

## Related content

- [Item element (MSBuild)](../msbuild/item-element-msbuild.md)
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild](../msbuild/msbuild.md)
- [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md)
- [How to: Exclude files from the build](../msbuild/how-to-exclude-files-from-the-build.md)
- [How to: Display an item list separated with commas](../msbuild/how-to-display-an-item-list-separated-with-commas.md)
- [Item definitions](../msbuild/item-definitions.md)
- [Batching](../msbuild/msbuild-batching.md)
