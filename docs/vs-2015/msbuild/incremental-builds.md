---
title: "Incremental Builds | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "msbuild, incremental builds"
ms.assetid: 325e28c7-4838-4e3f-b672-4586adc7500c
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Incremental Builds
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Incremental builds are builds that are optimized so that targets that have output files that are up-to-date with respect to their corresponding input files are not executed. A target element can have both an `Inputs` attribute, which indicates what items the target expects as input, and an `Outputs` attribute, which indicates what items it produces as output. MSBuild attempts to find a 1-to-1 mapping between the values of these attributes. If a 1-to-1 mapping exists, MSBuild compares the time stamp of every input item to the time stamp of its corresponding output item. Output files that have no 1-to-1 mapping are compared to all input files. An item is considered up-to-date if its output file is the same age or newer than its input file or files.  
  
 If all output items are up-to-date, MSBuild skips the target. This *incremental build* of the target can significantly improve the build speed. If only some files are up-to-date, MSBuild executes the target but skips the up-to-date items, and thereby brings all items up-to-date. This is known as a *partial incremental build*.  
  
 1-to-1 mappings are typically produced by item transformations. For more information, see [Transforms](../msbuild/msbuild-transforms.md).  
  
 Consider the following target.  
  
```  
<Target Name="Backup" Inputs="@(Compile)"   
    Outputs="@(Compile->'$(BackupFolder)%(Identity).bak')">  
    <Copy SourceFiles="@(Compile)" DestinationFiles=  
        "@(Compile->'$(BackupFolder)%(Identity).bak')" />  
</Target>  
```  
  
 The set of files represented by the `Compile` item type are copied to a backup directory. The backup files have the .bak file name extension. If the files represented by the `Compile` item type, or the corresponding backup files, are not deleted or modified after the Backup target is run, then the Backup target is skipped in subsequent builds.  
  
## Output Inference  
 MSBuild compares the `Inputs` and `Outputs` attributes of a target to determine whether the target has to execute. Ideally, the set of files that exists after an incremental build is completed should remain the same whether or not the associated targets are executed. Because properties and items that are created or altered by tasks can affect the build, MSBuild must infer their values even if the target that affects them is skipped. This is known as *output inference*.  
  
 There are three cases:  
  
- The target has a `Condition` attribute that evaluates to `false`. In this case, the target is not run, and has no effect on the build.  
  
- The target has out-of-date outputs and is run to bring them up to date.  
  
- The target has no out-of-date outputs and is skipped. MSBuild evaluates the target and makes changes to items and properties as if the target had been run.  
  
  To support incremental compilation, tasks must ensure that the `TaskParameter` attribute value of any `Output` element is equal to a task input parameter. Here are some examples:  
  
```  
<CreateProperty Value="123">  
    <Output PropertyName="Easy" TaskParameter="Value" />  
</CreateProperty>  
```  
  
 This creates the property Easy, which has the value "123" whether or not the target is executed or skipped.  
  
```  
<CreateItem Include="a.cs;b.cs">  
    <Output ItemName="Simple" TaskParameter="Include" />  
</CreateItem>  
```  
  
 This creates the item type Simple, which has two items, "a.cs" and "b.cs", whether or not the target is executed or skipped.  
  
 Starting in MSBuild 3.5, output inference is performed automatically on item and property groups in a target. `CreateItem` tasks are not required in a target and should be avoided. Also, `CreateProperty` tasks should be used in a target only to determine whether a target has been executed.  
  
## Determining Whether a Target Has Been Run  
 Because of output inference, you have to add a `CreateProperty` task to a target to examine properties and items so that you can determine whether the target has been executed. Add the `CreateProperty` task to the target and give it an `Output` element whose `TaskParameter` is "ValueSetByTask".  
  
```  
<CreateProperty Value="true">  
    <Output TaskParameter="ValueSetByTask" PropertyName="CompileRan" />  
</CreateProperty>  
```  
  
 This creates the property CompileRan and gives it the value `true`, but only if the target is executed. If the target is skipped, CompileRan is not created.  
  
## See Also  
 [Targets](../msbuild/msbuild-targets.md)
