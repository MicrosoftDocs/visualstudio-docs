---
title: "OnError Element (MSBuild) | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#OnError"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "OnError Element [MSBuild]"
  - "<OnError Element [MSBuild]"
ms.assetid: 765767d3-ecb7-4cd9-ba1e-d9468964dddc
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: "ghogen"
---
# OnError Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [OnError Element (MSBuild)](https://docs.microsoft.com/visualstudio/msbuild/onerror-element-msbuild).  
  
  
Causes one or more targets to execute, if the `ContinueOnError` attribute is `false` for a failed task.  
  
 \<Project>  
 \<Target>  
 \<OnError>  
  
## Syntax  
  
```  
<OnError ExecuteTargets="TargetName"  
    Condition="'String A'=='String B'" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|  
|`ExecuteTargets`|Required attribute.<br /><br /> The targets to execute if a task fails. Separate multiple targets with semicolons. Multiple targets are executed in the order specified.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Target](../msbuild/target-element-msbuild.md)|Container element for [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] tasks.|  
  
## Remarks  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] executes the `OnError` element if one of the `Target` element's tasks fails with the `ContinueOnError` attribute set to `ErrorAndStop` (or `false`). When the task fails, the targets specified in the `ExecuteTargets` attribute is executed. If there is more than one `OnError` element in the target, the `OnError` elements are executed sequentially when the task fails.  
  
 For information about the `ContinueOnError` attribute, see [Task Element (MSBuild)](../msbuild/task-element-msbuild.md). For information about targets, see [Targets](../msbuild/msbuild-targets.md).  
  
## Example  
 The following code executes the `TaskOne` and `TaskTwo` tasks. If `TaskOne` fails, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] evaluates the `OnError` element and executes the `OtherTarget` target.  
  
```  
<Target Name="ThisTarget">  
    <TaskOne ContinueOnError="ErrorAndStop">  
    </TaskOne>  
    <TaskTwo>  
    </TaskTwo>  
    <OnError ExecuteTargets="OtherTarget" />  
</Target>  
```  
  
## See Also  
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)   
 [Targets](../msbuild/msbuild-targets.md)



