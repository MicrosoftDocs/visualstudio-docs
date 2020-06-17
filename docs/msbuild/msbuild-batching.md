---
title: MSBuild Batching | Microsoft Docs
ms.date: 06/09/2020
ms.topic: conceptual
helpviewer_keywords:
- batching [MSBuild]
- MSBuild, batching
ms.assetid: d35c085b-27b8-49d7-b6f8-8f2f3a0eec38
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# MSBuild batching

MSBuild divides item lists into different categories, or batches, based on item metadata, and runs a target or task one time with each batch.

## Task batching

Task batching allows you to simplify your project files by providing a way to divide item lists into different batches and pass each of those batches into a task separately. This means that a project file only needs to have the task and its attributes declared once, even though it can be run several times.

You specify that you want MSBuild to perform batching with a task by using the `%(ItemMetaDataName)` notation in one of the task attributes. The following example splits the `Example` item list into batches based on the `Color` item metadata value, and passes each of the batches to the `MyTask` task separately.

> [!NOTE]
> If you do not reference the item list elsewhere in the task attributes, or the metadata name may be ambiguous, you can use the %(<ItemCollection.ItemMetaDataName>) notation to fully qualify the item metadata value to use for batching.

```xml
<Project
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <ItemGroup>
        <Example Include="Item1">
            <Color>Blue</Color>
        </Example>
        <Example Include="Item2">
            <Color>Red</Color>
        </Example>
    </ItemGroup>

    <Target Name="RunMyTask">
        <MyTask
            Sources = "@(Example)"
            Output = "%(Color)\MyFile.txt"/>
    </Target>

</Project>
```

For more specific batching examples, see [Item metadata in task batching](../msbuild/item-metadata-in-task-batching.md).

## Target batching

MSBuild checks if the inputs and outputs of a target are up to date before it runs the target. If both inputs and outputs are up to date, the target is skipped. If a task inside of a target uses batching, MSBuild needs to determine if the inputs and outputs for each batch of items is up to date. Otherwise, the target is executed every time it's hit.

The following example shows a `Target` element that contains an `Outputs` attribute with the `%(ItemMetadataName)` notation. MSBuild will divide the `Example` item list into batches based on the `Color` item metadata, and analyze the timestamps of the output files for each batch. If the outputs from a batch aren't up to date, the target is run. Otherwise, the target is skipped.

```xml
<Project
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <ItemGroup>
        <Example Include="Item1">
            <Color>Blue</Color>
        </Example>
        <Example Include="Item2">
            <Color>Red</Color>
        </Example>
    </ItemGroup>

    <Target Name="RunMyTask"
        Inputs="@(Example)"
        Outputs="%(Color)\MyFile.txt">
        <MyTask
            Sources = "@(Example)"
            Output = "%(Color)\MyFile.txt"/>
    </Target>

</Project>
```

For another example of target batching, see [Item metadata in target batching](../msbuild/item-metadata-in-target-batching.md).

## Item and property mutations

This section describes how to understand the effects of changing properties and/or item metadata, when using target batching or task batching.

Because target batching and task batching are two different MSBuild operations, it is important to understand exactly which form of batching MSBuild uses in each case. When the batching syntax `%(ItemMetadataName)` appears in a task in a target, but not in an attribute on the Target, then MSBuild uses task batching. The only way to specify target batching is by using the batching syntax on a Target attribute, usually the `Outputs` attribute.

With both target batching and task batching, batches can be considered to run independently. All batches begin with a copy of the same initial state of property and item metadata values. Any mutations of property values during batch execution is not visible to other batches. Consider the following example:

```xml
  <ItemGroup>
    <Thing Include="2" Color="blue" />
    <Thing Include="1" Color="red" />
  </ItemGroup>

  <Target Name="DemoIndependentBatches">
    <ItemGroup>
      <Thing Condition=" '%(Color)' == 'blue' ">
        <Color>red</Color>
        <NeededColorChange>true</NeededColorChange>
      </Thing>
    </ItemGroup>
    <Message Importance="high"
             Text="Things: @(Thing->'%(Identity) is %(Color); needed change=%(NeededColorChange)')"/>
  </Target>
```

The output is:

```output
Target DemoIndependentBatches:
  Things: 2 is red; needed change=true;1 is red; needed change=
```

The `ItemGroup` in the target is implicitly a task, and with the `%(Color)` in the `Condition` attribute, task batching is performed. There are two batches: one for red and the other for blue. The property `%(NeededColorChange)` is only set if the `%(Color)` metadata is blue, and the setting only affects the individual item that matched the condition when the blue batch was run. The `Message` task's `Text` attribute does not trigger batching, despite the `%(ItemMetadataName)` syntax, because it is used inside an item transform.

Batches run independently, but not in parallel. That makes a difference when you access metadata values that change in the batched execution. In the case where you set a property based on some metadata in the batched execution, the property would take the *last* value set:

```xml
   <PropertyGroup>
       <SomeProperty>%(SomeItem.MetadataValue)</SomeProperty>
   </PropertyGroup>
```

After batch execution, the property retains the final value of `%(MetadataValue)`.

Although batches run independently, it's important to consider the difference between target batching and task batching and know which type applies to your situation. Consider the following example to understand better the importance of this distinction.

Tasks can be implicit, rather than explicit, which can be confusing when task batching occurs with implicit tasks. When a `PropertyGroup` or `ItemGroup` element appears in a `Target`, each property declaration in the group is implicitly treated somewhat like a separate [CreateProperty](createproperty-task.md) or [CreateItem](createitem-task.md) task. This means that the behavior is different when the target is batched, versus when the target is not batched (that is, when it lacks the `%(ItemMetadataName)` syntax in the `Outputs` attribute). When the target is batched, the `ItemGroup` executes once per target, but when the target is not batched, the implicit equivalents of the `CreateItem` or `CreateProperty` tasks are batched using task batching, so the target only executes once, and each item or property in the group is batched separately using task batching.

The following example illustrates target batching vs. task batching in the case where metadata is mutated. Consider a situation where you have folders A and B with some files:

```
A\1.stub
B\2.stub
B\3.stub
```

Now look at the output of these two similar projects.

```xml
    <ItemGroup>
      <StubFiles Include="$(MSBuildThisFileDirectory)**\*.stub"/>

      <StubDirs Include="@(StubFiles->'%(RecursiveDir)')"/>
    </ItemGroup>

    <Target Name="Test1" AfterTargets="Build" Outputs="%(StubDirs.Identity)">
      <PropertyGroup>
        <ComponentDir>%(StubDirs.Identity)</ComponentDir>
        <ComponentName>$(ComponentDir.TrimEnd('\'))</ComponentName>
      </PropertyGroup>

      <Message Text=">> %(StubDirs.Identity) '$(ComponentDir)' '$(ComponentName)'"/>
    </Target>
```

The output is:

```output
Test1:
  >> A\ 'A\' 'A'
Test1:
  >> B\ 'B\' 'B'
```

Now remove the `Outputs` attribute that specified target batching.

```xml
    <ItemGroup>
      <StubFiles Include="$(MSBuildThisFileDirectory)**\*.stub"/>

      <StubDirs Include="@(StubFiles->'%(RecursiveDir)')"/>
    </ItemGroup>

    <Target Name="Test1" AfterTargets="Build">
      <PropertyGroup>
        <ComponentDir>%(StubDirs.Identity)</ComponentDir>
        <ComponentName>$(ComponentDir.TrimEnd('\'))</ComponentName>
      </PropertyGroup>

      <Message Text=">> %(StubDirs.Identity) '$(ComponentDir)' '$(ComponentName)'"/>
    </Target>
```

The output is:

```output
Test1:
  >> A\ 'B\' 'B'
  >> B\ 'B\' 'B'
```

Notice that the heading `Test1` is only printed once, but in the previous example, it was printed twice. That means the target is not batched.  And as a result, the output is confusingly different.

The reason is that when using target batching, each target batch executes everything in the target with its own independent copy of all the properties and items, but when you omit the `Outputs` attribute, the individual lines in the property group are treated as distinct, potentially batched tasks. In this case, the `ComponentDir` task is batched (it uses the `%(ItemMetadataName)` syntax), so that by the time the `ComponentName` line executes, both batches of the `ComponentDir` line have completed, and the second one that ran determined the value as seen in the second line.

## Property functions using metadata

Batching can be controlled by property functions that include metadata. For example,

`$([System.IO.Path]::Combine($(RootPath),%(Compile.Identity)))`

uses <xref:System.IO.Path.Combine%2A> to combine a root folder path with a Compile item path.

Property functions may not appear within metadata values. For example,

`%(Compile.FullPath.Substring(0,3))`

is not allowed.

For more information about property functions, see [Property functions](../msbuild/property-functions.md).

## See also

- [ItemMetadata element (MSBuild)](../msbuild/itemmetadata-element-msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Advanced concepts](../msbuild/msbuild-advanced-concepts.md)
