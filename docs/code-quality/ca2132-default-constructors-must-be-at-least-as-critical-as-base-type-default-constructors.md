---
title: "CA2132: Default constructors must be at least as critical as base type default constructors | Microsoft Docs"
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
  - "CA2132"
ms.assetid: e758afa1-8bde-442a-8a0a-bd1ea7b0ce4d
caps.latest.revision: 11
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
# CA2132: Default constructors must be at least as critical as base type default constructors
|||  
|-|-|  
|TypeName|DefaultConstructorsMustHaveConsistentTransparency|  
|CheckId|CA2132|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
> [!NOTE]
>  This warning is only applied to code that is running the CoreCLR (the version of the CLR that is specific to Silverlight Web applications).  
  
## Cause  
 The transparency attribute of the default constructor of a derived class is not as critical as the transparency of the base class.  
  
## Rule Description  
 Types and members that have the <xref:System.Security.SecurityCriticalAttribute> cannot be used by Silverlight application code. Security-critical types and members can be used only by trusted code in the .NET Framework for Silverlight class library. Because a public or protected construction in a derived class must have the same or greater transparency than its base class, a class in an application cannot be derived from a class marked SecurityCritical.  
  
 For CoreCLR platform code, if a base type has a public or protected non-transparent default constructor then the derived type must obey the default constructor inheritance rules. The derived type must also have a default constructor and that constructor must be at least as critical default constructor of the base type.  
  
## How to Fix Violations  
 To fix the violation, remove the type or do not derive from security non-transparent type.  
  
## When to Suppress Warnings  
 Do not suppress warnings from this rule. Violations of this rule by application code will result in the CoreCLR refusing to load the type with a <xref:System.TypeLoadException>.  
  
### Code  
 [!code-cs[FxCop.Security.CA2132.DefaultConstructorsMustHaveConsistentTransparency#1](../code-quality/codesnippet/CSharp/ca2132-default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors_1.cs)]  
  
### Comments