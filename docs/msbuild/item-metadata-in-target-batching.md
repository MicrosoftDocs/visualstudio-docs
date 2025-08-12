---
title: Item Metadata in Target Batching
description: Learn how MSBuild uses item metadata in target batching to perform dependency analysis on the inputs and outputs of a build target.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- batching [MSBuild]
- MSBuild, target batching
- target batching [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Work with item metadata in target batching

MSBuild has the ability to perform dependency analysis on the inputs and outputs of a build target. If it is determined that the inputs or outputs of the target are up-to-date, the target will be skipped and the build will proceed. `Target` elements use the `Inputs` and `Outputs` attributes to specify the items to inspect during dependency analysis.

If a target contains a task that uses batched items as inputs or outputs, the `Target` element of the target should use batching in its `Inputs` or `Outputs` attributes to enable MSBuild to skip batches of items that are already up-to-date.

## Batch targets

The following example contains an item list named `Res` that is divided into two batches based on the `Culture` item metadata. Each of these batches is passed into the `AL` task, which creates an output assembly for each batch. By using batching on the `Outputs` attribute of the `Target` element, MSBuild can determine if each of the individual batches is up-to-date before running the target. Without using target batching, both batches of items would be run by the task every time the target was executed.

```xml
<Project>

    <ItemGroup>
        <Res Include="Strings.fr.resources">
            <Culture>fr</Culture>
        </Res>
        <Res Include="Strings.jp.resources">
            <Culture>jp</Culture>
        </Res>
        <Res Include="Menus.fr.resources">
            <Culture>fr</Culture>
        </Res>
        <Res Include="Dialogs.fr.resources">
            <Culture>fr</Culture>
        </Res>
        <Res Include="Dialogs.jp.resources">
            <Culture>jp</Culture>
        </Res>
        <Res Include="Menus.jp.resources">
            <Culture>jp</Culture>
        </Res>
    </ItemGroup>

    <Target Name="Build"
        Inputs="@(Res)"
        Outputs="%(Culture)\MyApp.resources.dll">

        <AL Resources="@(Res)"
            TargetType="library"
            OutputAssembly="%(Culture)\MyApp.resources.dll">
        </AL>

    </Target>

</Project>
```

## Related content

- [How to: Build incrementally](../msbuild/how-to-build-incrementally.md)
- [Batching](../msbuild/msbuild-batching.md)
- [Target element (MSBuild)](../msbuild/target-element-msbuild.md)
- [Item metadata in task batching](../msbuild/item-metadata-in-task-batching.md)
