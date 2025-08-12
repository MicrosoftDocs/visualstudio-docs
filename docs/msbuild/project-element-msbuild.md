---
title: Project Element (MSBuild)
description: Learn about the MSBuild Project element, which is the required root element of an MSBuild project file.
ms.date: 03/13/2017
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Project
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- ToolsVersion attribute [MSBuild]
- <Project> element [MSBuild]
- Project element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Project element (MSBuild)

Required root element of an MSBuild project file.

## Syntax

```xml
<Project InitialTargets="TargetA;TargetB"
         DefaultTargets="TargetC;TargetD"
         TreatAsLocalProperty="PropertyA;PropertyB"
         ToolsVersion="<version number>"
         Sdk="name[/version]">
    <Sdk... />
    <Choose>... </Choose>
    <PropertyGroup>... </PropertyGroup>
    <ItemGroup>... </ItemGroup>
    <Target>... </Target>
    <UsingTask.../>
    <ProjectExtensions>... </ProjectExtensions>
    <Import... />
</Project>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

| Attribute | Description |
|------------------------| - |
| `DefaultTargets` | Optional attribute.<br /><br /> The default target or targets to be the entry point of the build if no target has been specified. Multiple targets are semi-colon (;) delimited.<br /><br /> If no default target is specified in either the `DefaultTargets` attribute or the MSBuild command line, the engine executes the first target in the project file after the [Import](../msbuild/import-element-msbuild.md) elements have been evaluated. |
| `InitialTargets` | Optional attribute.<br /><br /> The initial target or targets to be run before the targets specified in the `DefaultTargets` attribute or on the command line. Multiple targets are semi-colon (`;`) delimited. If multiple imported files define `InitialTargets`, all targets mentioned will be run, in the order the imports are encountered. |
| `Sdk` | Optional attribute. <br /><br /> The SDK name and optional version to use to create implicit Import statements that are added to the .proj file. If no version is specified, MSBuild will attempt to resolve a default version.  For example, `<Project Sdk="Microsoft.NET.Sdk" />` or `<Project Sdk="My.Custom.Sdk/1.0.0" />`. |
| `ToolsVersion` | Optional attribute.<br /><br /> The version of the Toolset MSBuild uses to determine the values for $(MSBuildBinPath) and $(MSBuildToolsPath). |
| `TreatAsLocalProperty` | Optional attribute.<br /><br /> Property names that won't be considered to be global. This attribute prevents specific command-line properties from overriding property values that are set in a project or targets file and all subsequent imports. Multiple properties are semi-colon (;) delimited.<br /><br /> Normally, global properties override property values that are set in the project or targets file. If the property is listed in the `TreatAsLocalProperty` value, the global property value doesn't override property values that are set in that file and any subsequent imports. For more information, see [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md). **Note:**  You set global properties  at a command prompt by using the **-property** (or **-p**) switch. You can also set or modify global properties for child projects in a multi-project build by using the `Properties` attribute of the MSBuild task. For more information, see [MSBuild task](../msbuild/msbuild-task.md). |
| `xmlns` | Optional attribute.<br /><br /> When specified, the `xmlns` attribute must have the value of `http://schemas.microsoft.com/developer/msbuild/2003`. |

### Child elements

| Element | Description |
| - | - |
| [Choose](../msbuild/choose-element-msbuild.md) | Optional element.<br /><br /> Evaluates child elements to select one set of `ItemGroup` elements and/or `PropertyGroup` elements to evaluate. |
| [Import](../msbuild/import-element-msbuild.md) | Optional element.<br /><br /> Enables a project file to import another project file. There may be zero or more `Import` elements in a project. |
| [ImportGroup](../msbuild/importgroup-element.md) | Optional element.<br /><br /> Contains a collection of `Import` elements that are grouped under an optional condition. |
| [ItemGroup](../msbuild/itemgroup-element-msbuild.md) | Optional element.<br /><br /> A grouping element for individual items. Items are specified by using the [Item](../msbuild/item-element-msbuild.md) element. There may be zero or more `ItemGroup` elements in a project. |
| [ItemDefinitionGroup](../msbuild/itemdefinitiongroup-element-msbuild.md) | Optional element.<br /><br /> Lets you define a set of Item Definitions, which are metadata values that are applied to all items in the project, by default. ItemDefinitionGroup supersedes the need to use the `CreateItem` task and the `CreateProperty` task. |
| [ProjectExtensions](../msbuild/projectextensions-element-msbuild.md) | Optional element.<br /><br /> Provides a way to persist non-MSBuild information in an MSBuild project file. There may be zero or one `ProjectExtensions` elements in a project. |
| [PropertyGroup](../msbuild/propertygroup-element-msbuild.md) | Optional element.<br /><br /> A grouping element for individual properties. Properties are specified by using the [Property](../msbuild/property-element-msbuild.md) element. There may be zero or more `PropertyGroup` elements in a project. |
| [Sdk](../msbuild/sdk-element-msbuild.md) | Optional element.<br /><br /> References an MSBuild project SDK.  This element can be used as an alternative to the Sdk attribute. |
| [Target](../msbuild/target-element-msbuild.md) | Optional element.<br /><br /> Contains a set of tasks for MSBuild to sequentially execute. Tasks are specified by using the [Task](../msbuild/task-element-msbuild.md) element. There may be zero or more `Target` elements in a project. |
| [UsingTask](../msbuild/usingtask-element-msbuild.md) | Optional element.<br /><br /> Provides a way to register tasks in MSBuild. There may be zero or more `UsingTask` elements in a project. |

### Parent elements

 None.

## See also

- [How to: Specify which target to build first](../msbuild/how-to-specify-which-target-to-build-first.md)
- [Command-line reference](../msbuild/msbuild-command-line-reference.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [MSBuild](../msbuild/msbuild.md)