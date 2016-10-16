---
title: "ProjectExtensions Element (MSBuild)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
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
caps.latest.revision: 17
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
# ProjectExtensions Element (MSBuild)
Allows [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project files to contain non-[!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] information. Anything inside of a `ProjectExtensions` element will be ignored by [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)].  
  
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
|[Project](../reference/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project file.|  
  
## Remarks  
 Only one `ProjectExtensions` element may be used in an [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project.  
  
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
 [Project File Schema Reference](../reference/msbuild-project-file-schema-reference.md)