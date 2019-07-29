---
title: "How to: Build a Project That Has Resources | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "resource files, compiling with MSBuild"
  - "resources [Visual Studio], compiling with MSBuild"
  - "projects [.NET Framework], building"
  - "MSBuild, building a project with resources"
ms.assetid: d07ac73f-2c2d-4e9a-812a-6dcb632bafe2
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Build a Project That Has Resources
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you are building localized versions of a project, all user interface elements must be separated into resource files for the different languages. If the project uses only strings, the resource files can use text files. Alternatively, you can use .resx files as the resource files.  
  
## Compiling Resources with MSBuild  
 The library of common tasks that is provided with [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] includes a `GenerateResource` task that you can use to compile resources in either .resx or text files. This task includes the `Sources` parameter to specify which resource files to compile and the `OutputResources` parameter to specify names for the output resource files. For more information on the `GenerateResource` task, see [GenerateResource Task](../msbuild/generateresource-task.md).  
  
#### To compile resources with MSBuild  
  
1. Identify the project's resource files and pass them to the `GenerateResource` task, either as item lists, or as file names.  
  
2. Specify the `OutputResources` parameter of the `GenerateResource` task, which allows you to set the names for the output resource files.  
  
3. Use the `Output` element of the task to store the value of the `OutputResources` parameter in an item.  
  
4. Use the item created from the `Output` element as an input into another task.  
  
## Example  
 The following code example shows how the `Output` element specifies that the `OutputResources` attribute of the `GenerateResource` task will contain the compiled resource files `alpha.resources` and `beta.resources` and that those two files will be placed inside the `Resources` item list. By identifying those .resources files as a collection of items of the same name, you can easily use them as inputs for another task, such as the [Csc](../msbuild/csc-task.md) task.  
  
 This task is equivalent to using the **/compile** switch for [Resgen.exe](https://msdn.microsoft.com/library/8ef159de-b660-4bec-9213-c3fbc4d1c6f4):  
  
 `Resgen.exe /compile alpha.resx,alpha.resources /compile beta.txt,beta.resources`  
  
```  
<GenerateResource  
    Sources="alpha.resx; beta.txt"  
    OutputResources="alpha.resources; beta.resources">  
    <Output TaskParameter="OutputResources"  
        ItemName="Resources"/>  
</GenerateResource>  
```  
  
## Example  
 The following example project contains two tasks: the `GenerateResource` task to compile resources and the `Csc` task to compile both the source code files and the compiled resources files. The resource files compiled by the `GenerateResource` task are stored in the `Resources` item and passed to the `Csc` task.  
  
```  
<Project DefaultTargets = "Build"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >  
  
    <Target Name="Resources">  
        <GenerateResource  
            Sources="alpha.resx; beta.txt"  
            OutputResources="alpha.resources; beta.resources">  
            <Output TaskParameter="OutputResources"  
                ItemName="Resources"/>  
        </GenerateResource>  
    </Target>  
  
    <Target Name="Build" DependsOnTargets="Resources">  
        <Csc Sources="hello.cs"  
                Resources="@(Resources)"  
                OutputAssembly="hello.exe"/>  
    </Target>  
</Project>  
```  
  
## See Also  
[MSBuild](msbuild.md)  
 [GenerateResource Task](../msbuild/generateresource-task.md)   
 [Csc Task](../msbuild/csc-task.md)   
 [Resgen.exe (Resource File Generator)](https://msdn.microsoft.com/library/8ef159de-b660-4bec-9213-c3fbc4d1c6f4)
