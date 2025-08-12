---
title: Item Metadata in Task Batching
description: Learn how MSBuild uses item metadata in task batching to divide item lists into different categories, or batches, and run a task one time with each batch.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- batching [MSBuild]
- MSBuild, batching
- task batching [MSBuild]
- MSBuild, task batching
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Item metadata in task batching

MSBuild has the ability to divide item lists into different categories, or batches, based on item metadata, and run a task one time with each batch. It can be confusing to understand exactly what items are being passed with which batch. This topic covers the following common scenarios that involve batching.

- Dividing an item list into batches

- Dividing several item lists into batches

- Batching one item at a time

- Filtering item lists

For more information on batching with MSBuild, see [Batching](../msbuild/msbuild-batching.md).

## Divide an item list into batches

Batching allows you to divide an item list into different batches based on item metadata, and pass each of the batches into a task separately. This is useful for building satellite assemblies.

The following example shows how to divide an item list into batches based on item metadata. The `ExampColl` item list is divided into three batches based on the `Number` item metadata. The presence of `%(ExampColl.Number)`in the `Text` attribute notifies MSBuild that batching should be performed. The `ExampColl` item list is divided into three batches based on the `Number` metadata, and each batch is passed separately into the task.

```xml
<Project>

    <ItemGroup>
        <ExampColl Include="Item1">
            <Number>1</Number>
        </ExampColl>
        <ExampColl Include="Item2">
            <Number>2</Number>
        </ExampColl>
        <ExampColl Include="Item3">
            <Number>3</Number>
        </ExampColl>
        <ExampColl Include="Item4">
            <Number>1</Number>
        </ExampColl>
        <ExampColl Include="Item5">
            <Number>2</Number>
        </ExampColl>
        <ExampColl Include="Item6">
            <Number>3</Number>
        </ExampColl>
    </ItemGroup>

    <Target Name="ShowMessage">
        <Message
            Text = "Number: %(ExampColl.Number) -- Items in ExampColl: @(ExampColl)"/>
    </Target>

</Project>
```

The [Message task](../msbuild/message-task.md) displays the following information:

`Number: 1 -- Items in ExampColl: Item1;Item4`

`Number: 2 -- Items in ExampColl: Item2;Item5`

`Number: 3 -- Items in ExampColl: Item3;Item6`

## Divide several item lists into batches

MSBuild can divide multiple item lists into batches based on the same metadata. This makes it easy to divide different item lists into batches to build multiple assemblies. For example, you could have an item list of *.cs* files divided into an application batch and an assembly batch, and an item list of resource files divided into an application batch and an assembly batch. You could then use batching to pass these item lists into one task and build both the application and the assembly.

> [!NOTE]
> If an item list being passed into a task contains no items with the referenced metadata, every item in that item list is passed into every batch.

The following example shows how to divide multiple item lists into batches based on item metadata. The `ExampColl` and `ExampColl2` item lists are each divided into three batches based on the `Number` item metadata. The presence of `%(Number)`in the `Text` attribute notifies MSBuild that batching should be performed. The `ExampColl` and `ExampColl2` item lists are divided into three batches based on the `Number` metadata, and each batch is passed separately into the task.

```xml
<Project>

    <ItemGroup>

        <ExampColl Include="Item1">
            <Number>1</Number>
        </ExampColl>
        <ExampColl Include="Item2">
            <Number>2</Number>
        </ExampColl>
        <ExampColl Include="Item3">
            <Number>3</Number>
        </ExampColl>

        <ExampColl2 Include="Item4">
            <Number>1</Number>
        </ExampColl2>
        <ExampColl2 Include="Item5">
            <Number>2</Number>
        </ExampColl2>
        <ExampColl2 Include="Item6">
            <Number>3</Number>
        </ExampColl2>

    </ItemGroup>

    <Target Name="ShowMessage">
        <Message
            Text = "Number: %(Number) -- Items in ExampColl: @(ExampColl) ExampColl2: @(ExampColl2)"/>
    </Target>

</Project>
```

The [Message task](../msbuild/message-task.md) displays the following information:

`Number: 1 -- Items in ExampColl: Item1 ExampColl2: Item4`

`Number: 2 -- Items in ExampColl: Item2 ExampColl2: Item5`

`Number: 3 -- Items in ExampColl: Item3 ExampColl2: Item6`

## Batch one item at a time

Batching can also be performed on well-known item metadata that is assigned to every item upon creation. This guarantees that every item in a collection will have some metadata to use for batching. The `Identity` metadata value is useful for dividing every item in an item list into a separate batch. For a complete list of well-known item metadata, see [Well-known item metadata](../msbuild/msbuild-well-known-item-metadata.md).

The following example shows how to batch each item in an item list one at a time. The `ExampColl` item list is divided into six batches, each batch containing one item of the item list. The presence of `%(Identity)`in the `Text` attribute notifies MSBuild that batching should be performed.

```xml
<Project>

    <ItemGroup>

        <ExampColl Include="Item1"/>
        <ExampColl Include="Item2"/>
        <ExampColl Include="Item3"/>
        <ExampColl Include="Item4"/>
        <ExampColl Include="Item5"/>
        <ExampColl Include="Item6"/>

    </ItemGroup>

    <Target Name="ShowMessage">
        <Message
            Text = "Identity: '%(Identity)' -- Items in ExampColl: @(ExampColl)"/>
    </Target>

</Project>
```

The [Message task](../msbuild/message-task.md) displays the following information:

```output
Identity: 'Item1' -- Items in ExampColl: Item1
Identity: 'Item2' -- Items in ExampColl: Item2
Identity: 'Item3' -- Items in ExampColl: Item3
Identity: 'Item4' -- Items in ExampColl: Item4
Identity: 'Item5' -- Items in ExampColl: Item5
Identity: 'Item6' -- Items in ExampColl: Item6
```

However, `Identity` is not guaranteed to be unique; its value is the evaluated final value of the `Include` attribute. Therefore, if any `Include` attributes are used multiple times, they are batched together. As the following example shows, this technique requires the `Include` attributes to be unique for each item in the group. To illustrate this point, consider the following code:

```xml
<Project>
  <ItemGroup>
    <Item Include="1">
      <M>1</M>
    </Item>
    <Item Include="1">
      <M>2</M>
    </Item>
    <Item Include="2">
      <M>3</M>
    </Item>
  </ItemGroup>

  <Target Name="Batching">
    <Warning Text="@(Item->'%(Identity): %(M)')" Condition=" '%(Identity)' != '' "/>
  </Target>
</Project>
```

The output shows that the first two items are in the same batch, because the `Include` attribute is the same for them:

```output
test.proj(15,5): warning : 1: 1;1: 2
test.proj(15,5): warning : 2: 3
```

## Filter item lists

Batching can be used to filter out certain items from an item list before passing it to a task. For example, filtering on the `Extension` well-known item metadata value allows you to run a task on only files with a specific extension.

The following example shows how to divide an item list into batches based on item metadata, and then filter those batches when they are passed into a task. The `ExampColl` item list is divided into three batches based on the `Number` item metadata. The `Condition` attribute of the task specifies that only batches with a `Number` item metadata value of `2` will be passed into the task

```xml
<Project>

    <ItemGroup>

        <ExampColl Include="Item1">
            <Number>1</Number>
        </ExampColl>
        <ExampColl Include="Item2">
            <Number>2</Number>
        </ExampColl>
        <ExampColl Include="Item3">
            <Number>3</Number>
        </ExampColl>
        <ExampColl Include="Item4">
            <Number>1</Number>
        </ExampColl>
        <ExampColl Include="Item5">
            <Number>2</Number>
        </ExampColl>
        <ExampColl Include="Item6">
            <Number>3</Number>
        </ExampColl>

    </ItemGroup>

    <Target Name="Exec">
        <Message
            Text = "Items in ExampColl: @(ExampColl)"
            Condition="'%(Number)'=='2'"/>
    </Target>

</Project>
```

The [Message task](../msbuild/message-task.md) displays the following information:

```
Items in ExampColl: Item2;Item5
```

## Related content

- [Well-known item metadata](../msbuild/msbuild-well-known-item-metadata.md)
- [Item element (MSBuild)](../msbuild/item-element-msbuild.md)
- [ItemMetadata element (MSBuild)](../msbuild/itemmetadata-element-msbuild.md)
- [Batching](../msbuild/msbuild-batching.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
