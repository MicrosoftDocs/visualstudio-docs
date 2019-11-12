---
title: "CA2228: Do not ship unreleased resource formats | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotShipUnreleasedResourceFormats"
  - "CA2228"
helpviewer_keywords:
  - "CA2228"
  - "DoNotShipUnreleasedResourceFormats"
ms.assetid: 2c614edc-4e94-4b4f-8067-eea677a75cd9
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2228: Do not ship unreleased resource formats
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotShipUnreleasedResourceFormats|
|CheckId|CA2228|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A resource file was built using a version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] that is not currently supported.

## Rule Description
 Resource files that were built by using pre-release versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] might not be usable by supported versions of the .NET Framework.

## How to Fix Violations
 To fix a violation of this rule, build the resource using a supported version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)]k.

## When to Suppress Warnings
 Do not suppress a warning from this rule.
