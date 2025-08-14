---
title: MSBuild Project File Schema Reference
description: See a table listing all the MSBuild XML Schema elements with their available attributes and child elements.
ms.date: 8/14/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, file schema
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild project file schema reference

Provides a table of all the MSBuild XML Schema elements with their available attributes and child elements.

MSBuild uses project files to instruct the build engine what to build and how to build it. MSBuild project files are XML files that adhere to the MSBuild XML schema. This section documents the XML schema definition (*.xsd*) file for MSBuild.

## MSBuild XSD schema definition files

The schema link in an MSBuild project file is not required in Visual Studio 2017 and later. If present, it should be ` http://schemas.microsoft.com/developer/msbuild/2003` regardless of the version of Visual Studio. This value is not a live web destination; the most current MSBuild schema definition file (`.xsd` file) can be found at [Microsoft.Build.xsd](https://github.com/dotnet/msbuild/blob/main/src/MSBuild/Microsoft.Build.xsd).

The following table shows links to each version of the XSD schema:

| MSBuild Version | GitHub link | Raw link (for tooling) |
| - | - |
| 17.14 | [Microsoft.Build.xsd version 17.14.13](https://github.com/dotnet/msbuild/blob/v17.14.13/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.14.13/src/MSBuild/Microsoft.Build.xsd) |
| 17.13 | [Microsoft.Build.xsd version 17.13.26](https://github.com/dotnet/msbuild/blob/v17.13.26/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.13.26/src/MSBuild/Microsoft.Build.xsd) |
| 17.12 | [Microsoft.Build.xsd version 17.12.41](https://github.com/dotnet/msbuild/blob/v17.12.41/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.12.41/src/MSBuild/Microsoft.Build.xsd) |
| 17.11 | [Microsoft.Build.xsd version 17.11.31](https://github.com/dotnet/msbuild/blob/v17.11.31/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.11.31/src/MSBuild/Microsoft.Build.xsd) |
| 17.10 | [Microsoft.Build.xsd version 17.10.29](https://github.com/dotnet/msbuild/blob/v17.10.29/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.10.29/src/MSBuild/Microsoft.Build.xsd) |
| 17.9 | [Microsoft.Build.xsd version 17.9.8](https://github.com/dotnet/msbuild/blob/v17.9.8/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.9.8/src/MSBuild/Microsoft.Build.xsd) |
| 17.8 | [Microsoft.Build.xsd version 17.8.32](https://github.com/dotnet/msbuild/blob/v17.8.32/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.8.32/src/MSBuild/Microsoft.Build.xsd) |
| 17.7 | [Microsoft.Build.xsd version 17.7.4](https://github.com/dotnet/msbuild/blob/v17.7.4/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.7.4/src/MSBuild/Microsoft.Build.xsd) |
| 17.6 | [Microsoft.Build.xsd version 17.6.11](https://github.com/dotnet/msbuild/blob/v17.6.11/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.6.11/src/MSBuild/Microsoft.Build.xsd) |
| 17.5 | [Microsoft.Build.xsd version 17.5.1](https://github.com/dotnet/msbuild/blob/v17.5.1/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.5.1/src/MSBuild/Microsoft.Build.xsd) |
| 17.4 | [Microsoft.Build.xsd version 17.4.4](https://github.com/dotnet/msbuild/blob/v17.4.4/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.4.4/src/MSBuild/Microsoft.Build.xsd) |
| 17.3 | [Microsoft.Build.xsd version 17.3.1](https://github.com/dotnet/msbuild/blob/v17.3.1/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.3.1/src/MSBuild/Microsoft.Build.xsd) |
| 17.2 | [Microsoft.Build.xsd version 17.2.1](https://github.com/dotnet/msbuild/blob/v17.2.1/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.2.1/src/MSBuild/Microsoft.Build.xsd) |
| 17.1 | [Microsoft.Build.xsd version 17.1.1](https://github.com/dotnet/msbuild/blob/v17.1.1/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.1.1/src/MSBuild/Microsoft.Build.xsd) |
| 17.0 | [Microsoft.Build.xsd version 17.0.0](https://github.com/dotnet/msbuild/blob/v17.0.0/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v17.0.0/src/MSBuild/Microsoft.Build.xsd) |
| 16.11 | [Microsoft.Build.xsd version 16.11.2](https://github.com/dotnet/msbuild/blob/v16.11.2/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.11.2/src/MSBuild/Microsoft.Build.xsd) |
| 16.10 | [Microsoft.Build.xsd version 16.10.2](https://github.com/dotnet/msbuild/blob/v16.10.2/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.10.2/src/MSBuild/Microsoft.Build.xsd) |
| 16.9 | [Microsoft.Build.xsd version 16.9.2](https://github.com/dotnet/msbuild/blob/v16.9.2/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.9.2/src/MSBuild/Microsoft.Build.xsd) |
| 16.8 | [Microsoft.Build.xsd version 16.8.3](https://github.com/dotnet/msbuild/blob/v16.8.3/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.8.3/src/MSBuild/Microsoft.Build.xsd) |
| 16.7 | [Microsoft.Build.xsd version 16.7.0.37604](https://github.com/dotnet/msbuild/blob/v16.7.0.37604/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.7.0.37604/src/MSBuild/Microsoft.Build.xsd) |
| 16.4 | [Microsoft.Build.xsd version 16.4.0.56107](https://github.com/dotnet/msbuild/blob/v16.4.0.56107/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v16.4.0.56107/src/MSBuild/Microsoft.Build.xsd) |
| 15.9 | [Microsoft.Build.xsd version 15.9.21.664](https://github.com/dotnet/msbuild/blob/v15.9.21.664/src/MSBuild/Microsoft.Build.xsd) | [raw](https://raw.githubusercontent.com/dotnet/msbuild/v15.9.21.664/src/MSBuild/Microsoft.Build.xsd) |

The top-level XSD file includes two other child XSD files, *Microsoft.Build.CommonTypes.xsd* and *Microsoft.Build.Core.xsd*. You can also find all the MSBuild XSD schema definition files in the Visual Studio installation folder under *Xml\Schemas\1033\MSBuild*.

For more about MSBuild versions, including a table of corresponding .NET SDK versions, see [Overview of .NET, MSBuild, and Visual Studio versioning](/dotnet/core/porting/versioning-sdk-msbuild-vs).

## MSBuild XML schema elements

 The following table lists all of the MSBuild XML schema elements along with their child elements and attributes.

|Element|Child elements|Attributes|
|-------------|--------------------|----------------|
|[Choose element (MSBuild)](../msbuild/choose-element-msbuild.md)|Otherwise<br /><br /> When|--|
|[Import element (MSBuild)](../msbuild/import-element-msbuild.md)|--|Condition<br /><br /> Project|
|[ImportGroup element](../msbuild/importgroup-element.md)|Import|Condition|
|[Item element (MSBuild)](../msbuild/item-element-msbuild.md)|*ItemMetaData*|Condition<br /><br /> Exclude<br /><br /> Include<br /><br /> Remove|
|[ItemDefinitionGroup element (MSBuild)](../msbuild/itemdefinitiongroup-element-msbuild.md)|*Item*|Condition|
|[ItemGroup element (MSBuild)](../msbuild/itemgroup-element-msbuild.md)|*Item*|Condition|
|[ItemMetadata element (MSBuild)](../msbuild/itemmetadata-element-msbuild.md)|*Item*|Condition|
|[OnError element (MSBuild)](../msbuild/onerror-element-msbuild.md)|--|Condition<br /><br /> ExecuteTargets|
|[Otherwise element (MSBuild)](../msbuild/otherwise-element-msbuild.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|--|
|[Output element (MSBuild)](../msbuild/output-element-msbuild.md)|--|Condition<br /><br /> ItemName<br /><br /> PropertyName<br /><br /> TaskParameter|
|[Parameter element](../msbuild/parameter-element.md)|--|Output<br /><br /> ParameterType<br /><br /> Required|
|[ParameterGroup element](../msbuild/parametergroup-element.md)|*Parameter*|--|
|[Project element (MSBuild)](../msbuild/project-element-msbuild.md)|Choose<br /><br /> Import<br /><br /> ItemGroup<br /><br /> ProjectExtensions<br /><br /> PropertyGroup<br /><br /> Target<br /><br /> UsingTask|DefaultTargets<br /><br /> InitialTargets<br /><br /> Sdk<br /><br /> ToolsVersion<br /><br /> TreatAsLocalProperty<br /><br /> xmlns|
|[ProjectExtensions element (MSBuild)](../msbuild/projectextensions-element-msbuild.md)|--|--|
|[Property element (MSBuild)](../msbuild/property-element-msbuild.md)|--|Condition|
|[PropertyGroup element (MSBuild)](../msbuild/propertygroup-element-msbuild.md)|*Property*|Condition|
|[Sdk element (MSBuild)](../msbuild/sdk-element-msbuild.md)|--|Name<br /><br /> Version|
|[Target element (MSBuild)](../msbuild/target-element-msbuild.md)|OnError<br /><br /> *Task*|AfterTargets<br /><br /> BeforeTargets<br /><br /> Condition<br /><br /> DependsOnTargets<br /><br /> Inputs<br /><br /> KeepDuplicateOutputs<br /><br /> Name<br /><br /> Outputs<br /><br /> Returns|
|[Task element of Target (MSBuild)](../msbuild/task-element-msbuild.md)|Output|Condition<br /><br /> ContinueOnError<br /><br /> *Parameter*|
|[Task element of UsingTask (MSBuild)](../msbuild/taskbody-element-msbuild.md)|*Data*|Evaluate|
|[UsingTask element (MSBuild)](../msbuild/usingtask-element-msbuild.md)|ParameterGroup<br /><br /> Task|AssemblyFile<br /><br /> AssemblyName<br /><br /> Condition<br /><br /> TaskFactory<br /><br /> TaskName|
|[When element (MSBuild)](../msbuild/when-element-msbuild.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|Condition|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Conditions](../msbuild/msbuild-conditions.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
