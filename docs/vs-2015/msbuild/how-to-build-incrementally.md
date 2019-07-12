---
title: "How to: Build Incrementally | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, incremental builds"
  - "incremental builds"
  - "MSBuild, building incrementally"
ms.assetid: 8d82d7d8-a2f1-4df6-9d2f-80b9e0cb3ac3
caps.latest.revision: 24
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Build Incrementally
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you build a large project, it is important that previously built components that are still up-to-date are not rebuilt. If all targets are built every time, each build will take a long time to complete. To enable incremental builds (builds in which only those targets that have not been built before or targets that are out of date, are rebuilt), the [!INCLUDE[vstecmsbuildengine](../includes/vstecmsbuildengine-md.md)] ([!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)]) can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target. However, there must be a one-to-one mapping between inputs and outputs. You can use transforms to enable targets to identify this direct mapping. For more information on transforms, see [Transforms](../msbuild/msbuild-transforms.md).  
  
## Specifying Inputs and Outputs  
 A target can be built incrementally if the inputs and outputs are specified in the project file.  
  
#### To specify inputs and outputs for a target  
  
- Use the `Inputs` and `Outputs` attributes of the `Target` element. For example:  
  
  ```  
  <Target Name="Build"  
      Inputs="@(CSFile)"  
      Outputs="hello.exe">  
  ```  
  
  [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target. In the following example, if any file in the `@(CSFile)` item list is newer than the hello.exe file, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] will run the target; otherwise it will be skipped:  
  
```  
<Target Name="Build"   
    Inputs="@(CSFile)"   
    Outputs="hello.exe">  
  
    <Csc  
        Sources="@(CSFile)"   
        OutputAssembly="hello.exe"/>  
</Target>  
```  
  
 When inputs and outputs are specified in a target, either each output can map to only one input or there can be no direct mapping between the outputs and inputs. In the previous [Csc Task](../msbuild/csc-task.md), for example, the output, hello.exe, cannot be mapped to any single input – it depends on all of them.  
  
> [!NOTE]
> A target in which there is no direct mapping between the inputs and outputs will always build more often than a target in which each output can map to only one input because [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] cannot determine which outputs need to be rebuilt if some of the inputs have changed.  
  
 Tasks in which you can identify a direct mapping between the outputs and inputs, such as the [LC Task](../msbuild/lc-task.md), are most suitable for incremental builds, unlike tasks such as `Csc` and [Vbc](../msbuild/vbc-task.md), which produce one output assembly from a number of inputs.  
  
## Example  
 The following example uses a project that builds Help files for a hypothetical Help system. The project works by converting source .txt files into intermediate .content files, which then are combined with XML metadata files to produce the final .help file used by the Help system. The project uses the following hypothetical tasks:  
  
- `GenerateContentFiles`: Converts .txt files into .content files.  
  
- `BuildHelp`: Combines .content files and XML metadata files to build the final .help file.  
  
  The project uses transforms to create a one-to-one mapping between inputs and outputs in the `GenerateContentFiles` task. For more information, see [Transforms](../msbuild/msbuild-transforms.md). Also, the `Output` element is set to automatically use the outputs from the `GenerateContentFiles` task as the inputs for the `BuildHelp` task.  
  
  This project file contains both the `Convert` and `Build` targets. The `GenerateContentFiles` and `BuildHelp` tasks are placed in the `Convert` and `Build` targets respectively so that each target can be built incrementally. By using the `Output` element, the outputs of the `GenerateContentFiles` task are placed in the `ContentFile` item list, where they can be used as inputs for the `BuildHelp` task. Using the `Output` element in this way automatically provides the outputs from one task as the inputs for another task so that you do not have to list the individual items or item lists manually in each task.  
  
> [!NOTE]
> Although the `GenerateContentFiles` target can build incrementally, all outputs from that target always are required as inputs for the `BuildHelp` target. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] automatically provides all the outputs from one target as inputs for another target when you use the `Output` element.  
  
```  
<Project DefaultTargets="Build"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >  
  
    <ItemGroup>  
        <TXTFile Include="*.txt"/>  
        <XMLFile Include="\metadata\*.xml"/>  
    </ItemGroup>  
  
    <Target Name = "Convert"  
        Inputs="@(TXTFile)"  
        Outputs="@(TXTFile->'%(Filename).content')">  
  
        <GenerateContentFiles  
            Sources = "@(TXTFile)">  
            <Output TaskParameter = "OutputContentFiles"  
                ItemName = "ContentFiles"/>  
        </GenerateContentFiles>  
    </Target>  
  
    <Target Name = "Build" DependsOnTargets = "Convert"  
        Inputs="@(ContentFiles);@(XMLFiles)"  
        Outputs="$(MSBuildProjectName).help">  
  
        <BuildHelp  
            ContentFiles = "@(ContentFiles)"  
            MetadataFiles = "@(XMLFile)"  
            OutputFileName = "$(MSBuildProjectName).help"/>  
    </Target>  
</Project>  
```  
  
## See Also  
 [Targets](../msbuild/msbuild-targets.md)   
 [Target Element (MSBuild)](../msbuild/target-element-msbuild.md)   
 [Transforms](../msbuild/msbuild-transforms.md)   
 [Csc Task](../msbuild/csc-task.md)   
 [Vbc Task](../msbuild/vbc-task.md)
