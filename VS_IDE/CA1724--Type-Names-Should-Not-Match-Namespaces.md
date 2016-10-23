---
title: "CA1724: Type Names Should Not Match Namespaces"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 329af3b5-5600-4101-831d-531ab3eb7060
caps.latest.revision: 17
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1724: Type Names Should Not Match Namespaces
|||  
|-|-|  
|TypeName|TypeNamesShouldNotMatchNamespaces|  
|CheckId|CA1724|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 A type name matches a .NET Framework namespace names in a case-insensitive comparison.  
  
## Rule Description  
 Type names should not match the names of namespaces that are defined in the .NET Framework class library. Violating this rule can reduce the usability of the library.  
  
## How to Fix Violations  
 Select a type name that does not match the name of a .NET Framework class library namespace.  
  
## When to Suppress Warnings  
 For new development, no known scenarios occur where you must suppress a warning from this rule. Before you suppress the warning, carefully consider how the users of your library might be confused by the matching name. For shipping libraries, you might have to suppress a warning from this rule.