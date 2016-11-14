---
title: "CA2228: Do not ship unreleased resource formats | Microsoft Docs"
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
  - "DoNotShipUnreleasedResourceFormats"
  - "CA2228"
helpviewer_keywords: 
  - "CA2228"
  - "DoNotShipUnreleasedResourceFormats"
ms.assetid: 2c614edc-4e94-4b4f-8067-eea677a75cd9
caps.latest.revision: 14
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
# CA2228: Do not ship unreleased resource formats
|||  
|-|-|  
|TypeName|DoNotShipUnreleasedResourceFormats|  
|CheckId|CA2228|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A resource file was built using a version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] that is not currently supported.  
  
## Rule Description  
 Resource files that were built by using pre-release versions of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] might not be usable by supported versions of the .NET Framework.  
  
## How to Fix Violations  
 To fix a violation of this rule, build the resource using a supported version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)]k.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.