---
title: MSBuild Project File Schema Reference | Microsoft Docs
description: See a table listing all the MSBuild XML Schema elements with their available attributes and child elements.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, file schema
ms.assetid: d9a68146-1f43-4621-ac78-2c8c3f400936
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild project file schema reference

Provides a table of all the MSBuild XML Schema elements with their available attributes and child elements.

 MSBuild uses project files to instruct the build engine what to build and how to build it. MSBuild project files are XML files that adhere to the MSBuild XML schema. This section documents the XML schema definition (*.xsd*) file for MSBuild.

The schema link in an MSBuild project file is not required in Visual Studio 2017 and later. If present, it should be ` http://schemas.microsoft.com/developer/msbuild/2003` regardless of the version of Visual Studio.

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
