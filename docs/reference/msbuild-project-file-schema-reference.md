---
title: "MSBuild Project File Schema Reference"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, file schema"
ms.assetid: d9a68146-1f43-4621-ac78-2c8c3f400936
caps.latest.revision: 18
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# MSBuild Project File Schema Reference
Provides a table of all the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] XML Schema elements with their available attributes and child elements.  
  
 [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] uses project files to instruct the build engine what to build and how to build it. [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project files are XML files that adhere to the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] XML schema. This section documents the XML schema definition (.xsd) file for [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)].  
  
## MSBuild XML Schema Elements  
 The following table lists all of the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] XML schema elements along with their child elements and attributes.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[Choose Element (MSBuild)](../reference/choose-element--msbuild-.md)|Otherwise<br /><br /> When|--|  
|[Import Element (MSBuild)](../reference/import-element--msbuild-.md)|--|Condition<br /><br /> Project|  
|[ImportGroup Element](../reference/importgroup-element.md)|Import|Condition|  
|[Item Element (MSBuild)](../reference/item-element--msbuild-.md)|*ItemMetaData*|Condition<br /><br /> Exclude<br /><br /> Include<br /><br /> Remove|  
|[ItemDefinitionGroup Element (MSBuild)](../reference/itemdefinitiongroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemGroup Element (MSBuild)](../reference/itemgroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemMetadata Element (MSBuild)](../reference/itemmetadata-element--msbuild-.md)|*Item*|Condition|  
|[OnError Element (MSBuild)](../reference/onerror-element--msbuild-.md)|--|Condition<br /><br /> ExecuteTargets|  
|[Otherwise Element (MSBuild)](../reference/otherwise-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|--|  
|[Output Element (MSBuild)](../reference/output-element--msbuild-.md)|--|Condition<br /><br /> ItemName<br /><br /> PropertyName<br /><br /> TaskParameter|  
|[Parameter Element](../reference/parameter-element.md)|--|Output<br /><br /> ParameterType<br /><br /> Required|  
|[ParameterGroup Element](../reference/parametergroup-element.md)|*Parameter*|--|  
|[Project Element (MSBuild)](../reference/project-element--msbuild-.md)|Choose<br /><br /> Import<br /><br /> ItemGroup<br /><br /> ProjectExtensions<br /><br /> PropertyGroup<br /><br /> Target<br /><br /> UsingTask|DefaultTargets<br /><br /> InitialTargets<br /><br /> ToolsVersion<br /><br /> TreatAsLocalProperty<br /><br /> xmlns|  
|[ProjectExtensions Element (MSBuild)](../reference/projectextensions-element--msbuild-.md)|--|--|  
|[Property Element (MSBuild)](../reference/property-element--msbuild-.md)|--|Condition|  
|[PropertyGroup Element (MSBuild)](../reference/propertygroup-element--msbuild-.md)|*Property*|Condition|  
|[Target Element (MSBuild)](../reference/target-element--msbuild-.md)|OnError<br /><br /> *Task*|AfterTargets<br /><br /> BeforeTargets<br /><br /> Condition<br /><br /> DependsOnTargets<br /><br /> Inputs<br /><br /> KeepDuplicateOutputs<br /><br /> Name<br /><br /> Outputs<br /><br /> Returns|  
|[Task Element (MSBuild)](../reference/task-element--msbuild-.md)|Output|Condition<br /><br /> ContinueOnError<br /><br /> *Parameter*|  
|[TaskBody Element (MSBuild)](../reference/taskbody-element--msbuild-.md)|*Data*|Evaluate|  
|[UsingTask Element (MSBuild)](../reference/usingtask-element--msbuild-.md)|ParameterGroup<br /><br /> TaskBody|AssemblyFile<br /><br /> AssemblyName<br /><br /> Condition<br /><br /> TaskFactory<br /><br /> TaskName|  
|[When Element (MSBuild)](../reference/when-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|Condition|  
  
## See Also  
 [Task Reference](../reference/msbuild-task-reference.md)   
 [Conditions](../reference/msbuild-conditions.md)   
 [MSBuild Reference](../reference/msbuild-reference.md)