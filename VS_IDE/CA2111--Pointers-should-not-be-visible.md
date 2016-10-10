---
title: "CA2111: Pointers should not be visible"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b3a8d466-895b-43bc-a2df-5d7058fe915f
caps.latest.revision: 14
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA2111: Pointers should not be visible
|||  
|-|-|  
|TypeName|PointersShouldNotBeVisible|  
|CheckId|CA2111|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected <xref:System.IntPtr?qualifyHint=True> or <xref:System.UIntPtr?qualifyHint=True> field is not read-only.  
  
## Rule Description  
 <xref:System.IntPtr?qualifyHint=False> and <xref:System.UIntPtr?qualifyHint=False> are pointer types that are used to access unmanaged memory. If a pointer is not private, internal, or read-only, malicious code can change the value of the pointer, potentially allowing access to arbitrary locations in memory or causing application or system failures.  
  
 If you intend to secure access to the type that contains the pointer field, see [CA2112: Secured types should not expose fields](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md).  
  
## How to Fix Violations  
 Secure the pointer by making it read-only, internal, or private.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if you do not rely on the value of the pointer.  
  
## Example  
 The following code shows pointers that violate and satisfy the rule. Notice that the non-private pointers also violate the rule [CA1051: Do not declare visible instance fields](../VS_IDE/CA1051--Do-not-declare-visible-instance-fields.md).  
  
 [!CODE [FxCop.Security.PointersArePrivate#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.PointersArePrivate#1)]  
  
## Related Rules  
 [CA2112: Secured types should not expose fields](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md)  
  
 [CA1051: Do not declare visible instance fields](../VS_IDE/CA1051--Do-not-declare-visible-instance-fields.md)  
  
## See Also  
 <xref:System.IntPtr?qualifyHint=True>   
 <xref:System.UIntPtr?qualifyHint=True>