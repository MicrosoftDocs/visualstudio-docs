---
title: "Item Metadata in Target Batching | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "batching [MSBuild]"
  - "MSBuild, target batching"
  - "target batching [MSBuild]"
ms.assetid: f3cc4186-6a4c-4161-bbe5-1ec638b4925b
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Item Metadata in Target Batching
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] has the ability to perform dependency analysis on the inputs and outputs of a build target. If it is determined that the inputs or outputs of the target are up-to-date, the target will be skipped and the build will procede. `Target` elements use the `Inputs` and `Outputs` attributes to specify the items to inspect during dependency analysis.  
  
 If a target contains a task that uses batched items as inputs or outputs, the `Target` element of the target should use batching in its `Inputs` or `Outputs` attributes to enable [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] to skip batches of items that are already up-to-date.  
  
## Batching Targets  
 The following example contains an item list named `Res` that is divided into two batches based on the `Culture` item metadata. Each of these batches is passed into the `AL` task, which creates an output assembly for each batch. By using batching on the `Outputs` attribute of the `Target` element, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] can determine if each of the individual batches is up-to-date before running the target. Without using target batching, both batches of items would be run by the task every time the target was executed.  
  
```  
<Project  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
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
            OutputAssembly="%(Culture)\MyApp.resources.dll"  
  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [How to: Build Incrementally](../msbuild/how-to-build-incrementally.md)   
 [Batching](../msbuild/msbuild-batching.md)   
 [Target Element (MSBuild)](../msbuild/target-element-msbuild.md)   
 [Item Metadata in Task Batching](../msbuild/item-metadata-in-task-batching.md)
