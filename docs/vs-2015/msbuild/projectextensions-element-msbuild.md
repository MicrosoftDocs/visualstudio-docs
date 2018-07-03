---
title: "ProjectExtensions Element (MSBuild) | Microsoft Docs"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ProjectExtensions"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<ProjectExtensions> element [MSBuild]"
  - "ProjectExtensions element [MSBuild]"
ms.assetid: f95f312f-ff92-41eb-9469-ad99e236a307
caps.latest.revision: 21
author: mikejo5000
ms.author: mikejo
manager: "ghogen"
---
# ProjectExtensions Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [ProjectExtensions Element (MSBuild)](https://docs.microsoft.com/visualstudio/msbuild/projectextensions-element-msbuild).  
  
  
Allows [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project files to contain non-[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] information. Anything inside of a `ProjectExtensions` element will be ignored by [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)].  
  
 \<Project>  
 \<ProjectExtensions>  
  
## Syntax  
  
```  
<ProjectExtensions>  
    Non-MSBuild information to include in file.  
</ProjectExtensions>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../msbuild/project-element-msbuild.md)|Required root element of an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file.|  
  
## Remarks  
 Only one `ProjectExtensions` element may be used in an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project.  
  
## Example  
 The following code example shows information from the integrated development environment being stored in a `ProjectExtensions` element.  
  
```  
<ProjectExtensions>  
    <VSIDE>  
        <External>  
            <!--  
            Raw XML passed to the IDE by an external source  
            -->  
        </External>  
    </VSIDE>  
</ProjectExtensions>  
```  
  
## See Also  
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)  
 [MSBuild](MSBuild1.md)


