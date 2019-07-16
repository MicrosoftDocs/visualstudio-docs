---
title: "Project Element (MSBuild) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Project"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ToolsVersion attribute [MSBuild]"
  - "<Project> element [MSBuild]"
  - "Project element [MSBuild]"
ms.assetid: d1cda56a-dbef-4109-9201-39e962e3f653
caps.latest.revision: 34
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Project Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Required root element of an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file.  
  
## Syntax  
  
```  
<Project InitialTargets="TargetA;TargetB"  
         DefaultTargets="TargetC;TargetD"  
         TreatAsLocalProperty="PropertyA;PropertyB"  
         ToolsVersion=<version number>  
         xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Choose>... </Choose>  
    <PropertyGroup>... </PropertyGroup>  
    <ItemGroup>... </ItemGroup>  
    <Target>... </Target>  
    <UsingTask.../>  
    <ProjectExtensions>... </ProjectExtensions>  
    <Import... />  
</Project>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|       Attribute        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
|------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|    `DefaultTargets`    |                                                                                                                                                                                                                                                                                                 Optional attribute.<br /><br /> The default target or targets to be the entry point of the build if no target has been specified. Multiple targets are semi-colon (;) delimited.<br /><br /> If no default target is specified in either the `DefaultTargets` attribute or the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] command line, the engine executes the first target in the project file after the [Import](../msbuild/import-element-msbuild.md) elements have been evaluated.                                                                                                                                                                                                                                                                                                  |
|    `InitialTargets`    |                                                                                                                                                                                                                                                                                                                                                                                                                                             Optional attribute.<br /><br /> The initial target or targets to be run before the targets specified in the `DefaultTargets` attribute or on the command line. Multiple targets are semi-colon (;) delimited.                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|     `ToolsVersion`     |                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Optional attribute.<br /><br /> The version of the toolset MSBuild uses to determine the values for $(MSBuildBinPath) and $(MSBuildToolsPath).                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `TreatAsLocalProperty` | Optional attribute.<br /><br /> Property names that won't be considered to be global. This attribute prevents specific command-line properties from overriding property values that are set in a project or targets file and all subsequent imports. Multiple properties are semi-colon (;) delimited.<br /><br /> Normally, global properties override property values that are set in the project or targets file. If the property is listed in the `TreatAsLocalProperty` value, the global property value doesn't override property values that are set in that file and any subsequent imports. For more information, see [How to: Build the Same Source Files with Different Options](../msbuild/how-to-build-the-same-source-files-with-different-options.md). **Note:**  You set global properties  at a command prompt by using the **/property** (or **/p**) switch. You can also set or modify global properties for child projects in a multi-project build by using the `Properties` attribute of the MSBuild task. For more information, see [MSBuild Task](../msbuild/msbuild-task.md). |
|        `Xmlns`         |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Required attribute.<br /><br /> The `xmlns` attribute must have the value of "<http://schemas.microsoft.com/developer/msbuild/2003>".                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose](../msbuild/choose-element-msbuild.md)|Optional element.<br /><br /> Evaluates child elements to select one set of `ItemGroup` elements and/or `PropertyGroup` elements to evaluate.|  
|[Import](../msbuild/import-element-msbuild.md)|Optional element.<br /><br /> Enables a project file to import another project file. There may be zero or more `Import` elements in a project.|  
|[ItemGroup](../msbuild/itemgroup-element-msbuild.md)|Optional element.<br /><br /> A grouping element for individual items. Items are specified by using the [Item](../msbuild/item-element-msbuild.md) element. There may be zero or more `ItemGroup` elements in a project.|  
|[ProjectExtensions](../msbuild/projectextensions-element-msbuild.md)|Optional element.<br /><br /> Provides a way to persist non-[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] information in an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file. There may be zero or one `ProjectExtensions` elements in a project.|  
|[PropertyGroup](../msbuild/propertygroup-element-msbuild.md)|Optional element.<br /><br /> A grouping element for individual properties. Properties are specified by using the [Property](../msbuild/property-element-msbuild.md) element. There may be zero or more `PropertyGroup` elements in a project.|  
|[Target](../msbuild/target-element-msbuild.md)|Optional element.<br /><br /> Contains a set of tasks for [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] to sequentially execute. Tasks are specified by using the [Task](../msbuild/task-element-msbuild.md) element. There may be zero or more `Target` elements in a project.|  
|[UsingTask](../msbuild/usingtask-element-msbuild.md)|Optional element.<br /><br /> Provides a way to register tasks in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)]. There may be zero or more `UsingTask` elements in a project.|  
  
### Parent Elements  
 None.  
  
## See Also  
 [How to: Specify Which Target to Build First](../msbuild/how-to-specify-which-target-to-build-first.md)   
 [Command-Line Reference](../msbuild/msbuild-command-line-reference.md)   
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)   
 [MSBuild](msbuild.md)
