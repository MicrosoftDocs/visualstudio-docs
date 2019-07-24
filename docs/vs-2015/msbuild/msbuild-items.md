---
title: "MSBuild Items | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "MSBuild, Items"
ms.assetid: d762eff4-c92a-4b5f-a944-1ca30aa22319
caps.latest.revision: 38
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Items
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

MSBuild items are inputs into the build system, and they typically represent files. Items are grouped into item types based on their element names. Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process.  
  
 Because items are named by the item type to which they belong, the terms "item" and "item value" can be used interchangeably.  
  
 **In this topic**  
  
- [Creating Items in a Project File](#BKMK_Creating1)  
  
- [Creating Items During Execution](#BKMK_Creating2)  
  
- [Referencing Items in a Project File](#BKMK_ReferencingItems)  
  
- [Using Wildcards to Specify Items](#BKMK_Wildcards)  
  
- [Using the Exclude Attribute](#BKMK_ExcludeAttribute)  
  
- [Item Metadata](#BKMK_ItemMetadata)  
  
  - [Referencing Item Metadata in a Project File](#BKMK_ReferencingItemMetadata)  

  - [Well-known Item Metadata](#BKMK_WellKnownItemMetadata)  

  - [Transforming Item Types By Using Metadata](#BKMK_Transforming)  
  
- [Item Definitions](#BKMK_ItemDefinitions)  
  
- [Attributes for Items in an ItemGroup of a Target](#BKMK_AttributesWithinTargets)  
  
  - [Remove Attribute](#BKMK_RemoveAttribute)  

  - [KeepMetadata Attribute](#BKMK_KeepMetadata)  

  - [RemoveMetadata Attribute](#BKMK_RemoveMetadata)  

  - [KeepDuplicates Attribute](#BKMK_KeepDuplicates)  
  
## <a name="BKMK_Creating1"></a> Creating Items in a Project File  
 You declare items in the project file as child elements of an [ItemGroup](../msbuild/itemgroup-element-msbuild.md) element. The name of the child element is the type of the item. The `Include` attribute of the element specifies the items (files) to be included with that item type. For example, the following XML creates an item type that’s named `Compile`, which includes two files.  
  
```  
<ItemGroup>  
    <Compile Include = "file1.cs"/>  
    <Compile Include = "file2.cs"/>  
</ItemGroup>  
```  
  
 The item "file2.cs" doesn’t replace the item "file1.cs"; instead, the file name is appended to the list of values for the `Compile` item type. You can’t remove an item from an item type during the evaluation phase of a build.  
  
 The following XML creates the same item type by declaring both files in one `Include` attribute. Notice that the file names are separated by a semicolon.  
  
```  
<ItemGroup>  
    <Compile Include = "file1.cs;file2.cs"/>  
</ItemGroup>  
```  
  
## <a name="BKMK_Creating2"></a> Creating Items During Execution  
 Items that are outside [Target](../msbuild/target-element-msbuild.md) elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, items can be created or modified in the following ways:  
  
- Any task can emit an item. To emit an item, the [Task](../msbuild/task-element-msbuild.md) element must have a child [Output](../msbuild/output-element-msbuild.md) element that has an `ItemName` attribute.  
  
- The [CreateItem](../msbuild/createitem-task.md) task can emit an item. This usage is deprecated.  
  
- Starting in the .NET Framework 3.5, `Target` elements may contain [ItemGroup](../msbuild/itemgroup-element-msbuild.md) elements that may contain item elements.  
  
## <a name="BKMK_ReferencingItems"></a> Referencing Items in a Project File  
 To reference item types throughout the project file, you use the syntax @(`ItemType`). For example, you would reference the item type in the previous example by using `@(Compile)`. By using this syntax, you can pass items to tasks by specifying the item type as a parameter of that task. For more information, see [How to: Select the Files to Build](../msbuild/how-to-select-the-files-to-build.md).  
  
 By default, the items of an item type are separated by semicolons (;) when it’s expanded. You can use the syntax @(*ItemType*, '*separator*') to specify a separator other than the default. For more information, see [How to: Display an Item List Separated with Commas](../msbuild/how-to-display-an-item-list-separated-with-commas.md).  
  
## <a name="BKMK_Wildcards"></a> Using Wildcards to Specify Items  
 You can use the **, \*, and ? wildcard characters to specify a group of files as inputs for a build instead of listing each file separately.  
  
- The ? wildcard character matches a single character.  
  
- The * wildcard character matches zero or more characters.  
  
- The ** wildcard character sequence matches a partial path.  
  
  For example, you can specify all the .cs files in the directory that contains the project file by using the following element in your project file.  
  
```  
<CSFile Include="*.cs"/>  
```  
  
 The following element selects all .vb files on the D: drive:  
  
```  
<VBFile Include="D:/**/*.vb"/>  
```  
  
 For more information about wildcard characters, see [How to: Select the Files to Build](../msbuild/how-to-select-the-files-to-build.md).  
  
## <a name="BKMK_ExcludeAttribute"></a> Using the Exclude Attribute  
 Item elements can contain the `Exclude` attribute, which excludes specific items (files) from the item type. The `Exclude` attribute is typically used together with wildcard characters. For example, the following XML adds every .cs file in the directory to the CSFile item type, except the `DoNotBuild.cs` file.  
  
```  
<ItemGroup>  
    <CSFile  Include="*.cs"  Exclude="DoNotBuild.cs"/>  
</ItemGroup>  
```  
  
 The `Exclude` attribute affects only the items that are added by the `Include` attribute in the item element that contains them both. The following example wouldn’t exclude the file Form1.cs, which was added in the preceding item element.  
  
```  
<Compile Include="*.cs" />  
<Compile Include="*.res" Exclude="Form1.cs">  
```  
  
 For more information, see [How to: Exclude Files from the Build](../msbuild/how-to-exclude-files-from-the-build.md).  
  
## <a name="BKMK_ItemMetadata"></a> Item Metadata  
 Items may contain metadata in addition to the information in the `Include` and `Exclude` attributes. This metadata can be used by tasks that require more information about the items or to batch tasks and targets. For more information, see [Batching](../msbuild/msbuild-batching.md).  
  
 Metadata is a collection of key-value pairs that are declared in the project file as child elements of an item element. The name of the child element is the name of the metadata, and the value of the child element is the value of the metadata.  
  
 The metadata is associated with the item element that contains it. For example, the following XML adds `Culture` metadata that has the value `Fr` to both the "one.cs" and the "two.cs" items of the CSFile item type.  
  
```  
<ItemGroup>  
    <CSFile Include="one.cs;two.cs">  
        <Culture>Fr</Culture>  
    </CSFile>  
</ItemGroup>  
```  
  
 An item can have zero or more metadata values. You can change metadata values at any time. If you set metadata to an empty value, you effectively remove it from the build.  
  
### <a name="BKMK_ReferencingItemMetadata"></a> Referencing Item Metadata in a Project File  
 You can reference item metadata throughout the project file by using the syntax %(`ItemMetadataName`). If ambiguity exists, you can qualify a reference by using the name of the item type. For example, you can specify %(*ItemType.ItemMetaDataName*).The following example uses the Display metadata to batch the Message task. For more information about how to use item metadata for batching, see [Item Metadata in Task Batching](../msbuild/item-metadata-in-task-batching.md).  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
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
  
### <a name="BKMK_WellKnownItemMetadata"></a> Well-known Item Metadata  
 When an item is added to an item type, that item is assigned some well-known metadata. For example, all items have the well-known metadata `%(Filename)`, whose value is the file name of the item. For more information, see [Well-known Item Metadata](../msbuild/msbuild-well-known-item-metadata.md).  
  
### <a name="BKMK_Transforming"></a> Transforming Item Types By Using Metadata  
 You can transform item lists into new item lists by using metadata. For example, you can transform an item type `CppFiles` that has items that represent .cpp files into a corresponding list of .obj files by using the expression `@(CppFiles -> '%(Filename).obj')`.  
  
 The following code creates a `CultureResource` item type that contains copies of all `EmbeddedResource` items with `Culture` metadata. The `Culture` metadata value becomes the value of the new metadata `CultureResource.TargetDirectory`.  
  
```  
<Target Name="ProcessCultureResources">  
    <ItemGroup>  
        <CultureResource Include="@(EmbeddedResource)"  
            Condition="'%(EmbeddedResource.Culture)' != ''">  
            <TargetDirectory>%(EmbeddedResource.Culture) </TargetDirectory>  
        </CultureResource>  
    </ItemGroup>  
</Target>  
```  
  
 For more information, see [Transforms](../msbuild/msbuild-transforms.md).  
  
## <a name="BKMK_ItemDefinitions"></a> Item Definitions  
 Starting in the .NET Framework 3.5, you can add default metadata to any item type by using the [ItemDefinitionGroup element](../msbuild/itemdefinitiongroup-element-msbuild.md). Like well-known metadata, the default metadata is associated with all items of the item type that you specify. You can explicitly override default metadata in an item definition. For example, the following XML gives the `Compile` items "one.cs" and "three.cs" the metadata `BuildDay` with the value "Monday". The code gives the item "two.cs" the metadata `BuildDay` with the value "Tuesday".  
  
```  
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
  
 For more information, see [Item Definitions](../msbuild/item-definitions.md).  
  
## <a name="BKMK_AttributesWithinTargets"></a> Attributes for Items in an ItemGroup of a Target  
 Starting in the .NET Framework 3.5, `Target` elements may contain [ItemGroup](../msbuild/itemgroup-element-msbuild.md) elements that may contain item elements. The attributes in this section are valid when they are specified for an item in an `ItemGroup` that's in a `Target`.  
  
### <a name="BKMK_RemoveAttribute"></a> Remove Attribute  
 Items in an `ItemGroup` of a target may contain the `Remove` attribute, which removes specific items (files) from the item type. This attribute was introduced in the .NET Framework 3.5.  
  
 The following example removes every .config file from the Compile item type.  
  
```  
<Target>  
    <ItemGroup>  
        <Compile Remove="*.config"/>  
    </ItemGroup>  
</Target>  
```  
  
### <a name="BKMK_KeepMetadata"></a> KeepMetadata Attribute  
 If an item is generated within a target, the item element can contain the `KeepMetadata` attribute. If this attribute is specified, only the metadata that is specified in the semicolon-delimited list of names will be transferred from the source item to the target item. An empty value for this attribute is equivalent to not specifying it. The `KeepMetadata` attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the `KeepMetadata` attribute.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"  
ToolsVersion="4.0">  
  
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
  
### <a name="BKMK_RemoveMetadata"></a> RemoveMetadata Attribute  
 If an item is generated within a target, the item element can contain the `RemoveMetadata` attribute. If this attribute is specified, all metadata is transferred from the source item to the target item except metadata whose names are contained in the semicolon-delimited list of names. An empty value for this attribute is equivalent to not specifying it. The `RemoveMetadata` attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the `RemoveMetadata` attribute.  
  
```  
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
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
  
### <a name="BKMK_KeepDuplicates"></a> KeepDuplicates Attribute  
 If an item is generated within a target, the item element can contain the `KeepDuplicates` attribute. `KeepDuplicates` is a `Boolean` attribute that specifies whether an item should be added to the target group if the item is an exact duplicate of an existing item.  
  
 If the source and target item have the same Include value but different metadata, the item is added even if `KeepDuplicates` is set to `false`. An empty value for this attribute is equivalent to not specifying it. The `KeepDuplicates` attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the `KeepDuplicates` attribute.  
  
```  
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
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
  
## See Also  
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)  
 [MSBuild](msbuild.md)   
 [How to: Select the Files to Build](../msbuild/how-to-select-the-files-to-build.md)   
 [How to: Exclude Files from the Build](../msbuild/how-to-exclude-files-from-the-build.md)   
 [How to: Display an Item List Separated with Commas](../msbuild/how-to-display-an-item-list-separated-with-commas.md)   
 [Item Definitions](../msbuild/item-definitions.md)   
 [Batching](../msbuild/msbuild-batching.md)   
 [Item Element (MSBuild)](../msbuild/item-element-msbuild.md)
