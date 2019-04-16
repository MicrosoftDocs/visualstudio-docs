---
title: "MSBuild Project File Schema Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, file schema"
ms.assetid: d9a68146-1f43-4621-ac78-2c8c3f400936
caps.latest.revision: 22
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Project File Schema Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Provides a table of all the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] XML Schema elements with their available attributes and child elements.  
  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] uses project files to instruct the build engine what to build and how to build it. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project files are XML files that adhere to the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] XML schema. This section documents the XML schema definition (.xsd) file for [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)].  
  
## MSBuild XML Schema Elements  
 The following table lists all of the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] XML schema elements along with their child elements and attributes.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[Choose Element (MSBuild)](../msbuild/choose-element-msbuild.md)|Otherwise<br /><br /> When|--|  
|[Import Element (MSBuild)](../msbuild/import-element-msbuild.md)|--|Condition<br /><br /> Project|  
|[ImportGroup Element](../msbuild/importgroup-element.md)|Import|Condition|  
|[Item Element (MSBuild)](../msbuild/item-element-msbuild.md)|*ItemMetaData*|Condition<br /><br /> Exclude<br /><br /> Include<br /><br /> Remove|  
|[ItemDefinitionGroup Element (MSBuild)](../msbuild/itemdefinitiongroup-element-msbuild.md)|*Item*|Condition|  
|[ItemGroup Element (MSBuild)](../msbuild/itemgroup-element-msbuild.md)|*Item*|Condition|  
|[ItemMetadata Element (MSBuild)](../msbuild/itemmetadata-element-msbuild.md)|*Item*|Condition|  
|[OnError Element (MSBuild)](../msbuild/onerror-element-msbuild.md)|--|Condition<br /><br /> ExecuteTargets|  
|[Otherwise Element (MSBuild)](../msbuild/otherwise-element-msbuild.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|--|  
|[Output Element (MSBuild)](../msbuild/output-element-msbuild.md)|--|Condition<br /><br /> ItemName<br /><br /> PropertyName<br /><br /> TaskParameter|  
|[Parameter Element](../msbuild/parameter-element.md)|--|Output<br /><br /> ParameterType<br /><br /> Required|  
|[ParameterGroup Element](../msbuild/parametergroup-element.md)|*Parameter*|--|  
|[Project Element (MSBuild)](../msbuild/project-element-msbuild.md)|Choose<br /><br /> Import<br /><br /> ItemGroup<br /><br /> ProjectExtensions<br /><br /> PropertyGroup<br /><br /> Target<br /><br /> UsingTask|DefaultTargets<br /><br /> InitialTargets<br /><br /> ToolsVersion<br /><br /> TreatAsLocalProperty<br /><br /> xmlns|  
|[ProjectExtensions Element (MSBuild)](../msbuild/projectextensions-element-msbuild.md)|--|--|  
|[Property Element (MSBuild)](../msbuild/property-element-msbuild.md)|--|Condition|  
|[PropertyGroup Element (MSBuild)](../msbuild/propertygroup-element-msbuild.md)|*Property*|Condition|  
|[Target Element (MSBuild)](../msbuild/target-element-msbuild.md)|OnError<br /><br /> *Task*|AfterTargets<br /><br /> BeforeTargets<br /><br /> Condition<br /><br /> DependsOnTargets<br /><br /> Inputs<br /><br /> KeepDuplicateOutputs<br /><br /> Name<br /><br /> Outputs<br /><br /> Returns|  
|[Task Element (MSBuild)](../msbuild/task-element-msbuild.md)|Output|Condition<br /><br /> ContinueOnError<br /><br /> *Parameter*|  
|[TaskBody Element (MSBuild)](../msbuild/taskbody-element-msbuild.md)|*Data*|Evaluate|  
|[UsingTask Element (MSBuild)](../msbuild/usingtask-element-msbuild.md)|ParameterGroup<br /><br /> TaskBody|AssemblyFile<br /><br /> AssemblyName<br /><br /> Condition<br /><br /> TaskFactory<br /><br /> TaskName|  
|[When Element (MSBuild)](../msbuild/when-element-msbuild.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|Condition|  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Conditions](../msbuild/msbuild-conditions.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)  
 [MSBuild](msbuild.md)
