---
title: "MSBuild Targets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "MSBuild, targets"
ms.assetid: 8060b4d2-e4a9-48cf-a437-852649ceb417
caps.latest.revision: 29
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Targets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Targets group tasks together in a particular order and allow the build process to be factored into smaller units. For example, one target may delete all files in the output directory to prepare for the build, while another compiles the inputs for the project and places them in the empty directory. For more information on tasks, see [Tasks](../msbuild/msbuild-tasks.md).  
  
## Declaring Targets in the Project File  
 Targets are declared in a project file with the [Target](../msbuild/target-element-msbuild.md) element. For example, the following XML creates a target named Construct, which then calls the Csc task with the Compile item type.  
  
```  
<Target Name="Construct">  
    <Csc Sources="@(Compile)" />  
</Target>  
```  
  
 Like MSBuild properties, targets can be redefined. For example,  
  
```  
<Target Name="AfterBuild" >  
    <Message Text="First occurrence" />  
</Target>  
<Target Name="AfterBuild" >  
    <Message Text="Second occurrence" />  
</Target>  
```  
  
 If AfterBuild executes, it displays only "Second occurrence".  
  
## Target Build Order  
 Targets must be ordered if the input to one target depends on the output of another target. There are several ways to specify the order in which targets run.  
  
- Initial targets  
  
- Default targets  
  
- First target  
  
- Target dependencies  
  
- `BeforeTargets` and `AfterTargets` (MSBuild 4.0)  
  
  A target never runs twice during a single build, even if a subsequent target in the build depends on it. Once a target runs, its contribution to the build is complete.  
  
  For details and more information about the target build order, see [Target Build Order](../msbuild/target-build-order.md).  
  
## Target Batching  
 A target element may have an `Outputs` attribute which specifies metadata in the form %(Metadata). If so, MSBuild runs the target once for each unique metadata value, grouping or "batching" the items that have that metadata value. For example,  
  
```  
<ItemGroup>  
    <Reference Include="System.Core">  
      <RequiredTargetFramework>3.5</RequiredTargetFramework>  
    </Reference>  
    <Reference Include="System.Xml.Linq">  
      <RequiredTargetFramework>3.5</RequiredTargetFramework>  
    </Reference>  
    <Reference Include="Microsoft.CSharp">  
      <RequiredTargetFramework>4.0</RequiredTargetFramework>  
    </Reference>  
</ItemGroup>  
<Target Name="AfterBuild"  
    Outputs="%(Reference.RequiredTargetFramework)">  
    <Message Text="Reference:  
      @(Reference->'%(RequiredTargetFramework)')" />  
</Target>  
```  
  
 batches the Reference items by their RequiredTargetFramework metadata. The output of the target looks like this:  
  
```  
Reference: 3.5;3.5  
Reference: 4.0  
```  
  
 Target batching is seldom used in real builds. Task batching is more common. For more information, see [Batching](../msbuild/msbuild-batching.md).  
  
## Incremental Builds  
 Incremental builds are builds that are optimized so that targets with output files that are up-to-date with respect to their corresponding input files are not executed. A target element can have both `Inputs` and `Outputs` attributes, indicating what items the target expects as input, and what items it produces as output.  
  
 If all output items are up-to-date, MSBuild skips the target, which significantly improves the build speed. This is called an incremental build of the target. If only some files are up-to-date, MSBuild executes the target without the up-to-date items. This is called a partial incremental build of the target. For more information, see [Incremental Builds](../msbuild/incremental-builds.md).  
  
## See Also  
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)   
 [How to: Use the Same Target in Multiple Project Files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md)
