---
title: "CA1405: COM visible type base types should be COM visible | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CA1405"
  - "ComVisibleTypeBaseTypesShouldBeComVisible"
helpviewer_keywords: 
  - "CA1405"
  - "ComVisibleTypeBaseTypesShouldBeComVisible"
ms.assetid: a762ea2f-5285-4f73-bfb9-9eb10aea4290
caps.latest.revision: 18
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA1405: COM visible type base types should be COM visible
|||  
|-|-|  
|TypeName|ComVisibleTypeBaseTypesShouldBeComVisible|  
|CheckId|CA1405|  
|Category|Microsoft.Interoperability|  
|Breaking Change|DependsOnFix|  
  
## Cause  
 A Component Object Model (COM) visible type derives from a type that is not COM visible.  
  
## Rule Description  
 When a COM visible type adds members in a new version, it must abide by strict guidelines to avoid breaking COM clients that bind to the current version. A type that is invisible to COM presumes it does not have to follow these COM versioning rules when it adds new members. However, if a COM visible type derives from the COM invisible type and exposes a class interface of <xref:System.Runtime.InteropServices.ClassInterfaceType?displayProperty=fullName> or <xref:System.Runtime.InteropServices.ClassInterfaceType> (the default), all public members of the base type (unless they are specifically marked as COM invisible, which would be redundant) are exposed to COM. If the base type adds new members in a subsequent version, any COM clients that bind to the class interface of the derived type might break. COM visible types should derive only from COM visible types to reduce the chance of breaking COM clients.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the base types COM visible or the derived type COM invisible.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!code-vb[FxCop.Interoperability.ComBaseTypes#1](../code-quality/codesnippet/VisualBasic/ca1405-com-visible-type-base-types-should-be-com-visible_1.vb)]
 [!code-csharp[FxCop.Interoperability.ComBaseTypes#1](../code-quality/codesnippet/CSharp/ca1405-com-visible-type-base-types-should-be-com-visible_1.cs)]  
  
## See Also  
 <xref:System.Runtime.InteropServices.ClassInterfaceAttribute?displayProperty=fullName>   
 [Interoperating with Unmanaged Code](/dotnet/framework/interop/index)