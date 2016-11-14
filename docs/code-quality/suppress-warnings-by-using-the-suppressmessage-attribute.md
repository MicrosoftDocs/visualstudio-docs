---
title: "Suppress Warnings By Using the SuppressMessage Attribute | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VC.Project.VCFxCopTool.InputAssemblyFileName"
  - "VC.Project.VCFxCopTool.FxCopModuleSuppressionsFile"
  - "VC.Project.VCFxCopTool.FxCopUseTypeNameInSuppression"
  - "VC.Project.VCFxCopTool.OutputFile"
helpviewer_keywords: 
  - "code analysis, source suppression"
  - "source suppression"
  - "SuppressMessage attribute"
  - "code analysis, SuppressMessage attribute"
ms.assetid: a38c57a2-d29d-43c0-84ff-3308b2484ce6
caps.latest.revision: 19
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# Suppress Warnings By Using the SuppressMessage Attribute
It is often useful to indicate that the warning is nonapplicable to let team members know that the code was reviewed and it was determined that the warning should be suppressed. In Source Suppression (ISS) lets a developer to put the attribute that suppresses a warning close to the location that generated the warning. You can add the ISS attribute directly to the source file or you can use the shortcut menu in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE.  
  
## In This Section  
  
|||  
|-|-|  
|[In Source Suppression Overview](../code-quality/in-source-suppression-overview.md)|Learn about ISS and how to use it in your code.|  
|[How to: Suppress Warnings by Using the Menu Item](../code-quality/how-to-suppress-warnings-by-using-the-menu-item.md)|Learn how to suppress warnings in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE by using the shortcut menu.|  
  
## Related Sections  
 [Analyzing Managed Code Quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)