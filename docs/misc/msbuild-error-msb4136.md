---
title: "MSBuild Error MSB4136"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSB4136"
ms.assetid: 6f0543d3-f8c0-44e1-8748-8a71be599bf4
caps.latest.revision: 10
ms.author: "mblome"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# MSBuild Error MSB4136
**MSB4136: Error reading the configuration information.**  
  
 [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] received an error when it tried to read the Toolset information in the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] configuration file (msbuild.exe.config).  
  
### To correct this error  
  
-   Make sure that the configuration file is correct and well-formed. For example, if you have customized the .config file by adding a Toolset, check the Toolset definition.  
  
## See Also  
 [Overriding ToolsVersion Settings](../reference/overriding-toolsversion-settings.md)   
 [Project Element (MSBuild)](../reference/project-element--msbuild-.md)   
 [Additional Resources](../reference/additional-msbuild-resources.md)