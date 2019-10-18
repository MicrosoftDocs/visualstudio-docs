---
title: "How to: Use the Same Target in Multiple Project Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, importing"
  - "MSBuild, using the same target in multiple project files"
ms.assetid: 163734bd-1bfd-4093-a730-7741fc21742d
caps.latest.revision: 16
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use the Same Target in Multiple Project Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you have authored several [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project files, you might have discovered that you need to use the same tasks and targets in different project files. Instead of including the complete description of those tasks or targets in every project file, you can save a target in a separate project file and then import that project into any other project that needs to use the target.  
  
## Using the Import Element  
 The `Import` element is used to insert one project file into another project file. The project file that is being imported must be a valid [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file and contain well-formed XML. The `Project` attribute specifies the path to the imported project file. For more information on the `Import` element, see [Import Element (MSBuild)](../msbuild/import-element-msbuild.md).  
  
#### To import a project  
  
1. Define, in the importing project file, all properties and items that are used as parameters for properties and items in the imported project.  
  
2. Use the `Import` element to import the project. For example:  
  
     `<Import Project="MyCommon.targets"/>`  
  
3. Following the `Import` element, define all properties and items that must override default definitions of properties and items in the imported project.  
  
## Order of Evaluation  
 When [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] reaches an `Import` element, the imported project is effectively inserted into the importing project at the location of the `Import` element. Therefore, the location of the `Import` element can affect the values of properties and items. It is important to understand the properties and items that are set by the imported project, and the properties and items that the imported project uses.  
  
 When the project builds, all properties are evaluated first, followed by items. For example, the following XML defines the imported project file MyCommon.targets:  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <Name>MyCommon</Name>  
    </PropertyGroup>  
  
    <Target Name="Go">  
        <Message Text="Name=$(Name)"/>  
    </Target>  
</Project>  
```  
  
 The following XML defines MyApp.proj, which imports MyCommon.targets:  
  
```  
<Project  
    DefaultTargets="Go"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <Name>MyApp</Name>  
    </PropertyGroup>  
    <Import Project="MyCommon.targets"/>  
</Project>  
```  
  
 When the project builds, the following message is displayed:  
  
 `Name="MyCommon"`  
  
 Because the project is imported after the property `Name` has been defined in MyApp.proj, the definition of `Name` in MyCommon.targets overrides the definition in MyApp.proj. If, the project is imported before the property Name is defined, the build would display the following message:  
  
 `Name="MyApp"`  
  
#### Use the following approach when importing projects  
  
1. Define, in the project file, all properties and items that are used as parameters for properties and items in the imported project.  
  
2. Import the project.  
  
3. Define in the project file all properties and items that must override default definitions of properties and items in the imported project.  
  
## Example  
 The following code example shows the MyCommon.targets file that the second code example imports. The .targets file evaluates properties from the importing project to configure the build.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <Flavor Condition="'$(Flavor)'==''">DEBUG</Flavor>  
        <Optimize Condition="'$(Flavor)'=='RETAIL'">yes</Optimize>  
        <appname>$(MSBuildProjectName)</appname>  
    <PropertyGroup>  
    <Target Name="Build">  
        <Csc Sources="hello.cs"  
            Optimize="$(Optimize)"  
            OutputAssembly="$(appname).exe"/>  
    </Target>  
</Project>  
```  
  
## Example  
 The following code example imports the MyCommon.targets file.  
  
```  
<Project DefaultTargets="Build"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <Flavor>RETAIL</Flavor>  
    </PropertyGroup>  
    <Import Project="MyCommon.targets"/>  
</Project>  
```  
  
## See also  
 [Import Element (MSBuild)](../msbuild/import-element-msbuild.md)   
 [Targets](../msbuild/msbuild-targets.md)
