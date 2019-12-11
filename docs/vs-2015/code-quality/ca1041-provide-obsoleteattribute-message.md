---
title: "CA1041: Provide ObsoleteAttribute message | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1041"
  - "ProvideObsoleteAttributeMessage"
helpviewer_keywords:
  - "ProvideObsoleteAttributeMessage"
  - "CA1041"
ms.assetid: be5bee69-d2d2-44e1-be2e-3ea451969003
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1041: Provide ObsoleteAttribute message
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ProvideObsoleteAttributeMessage|
|CheckId|CA1041|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A type or member is marked by using a <xref:System.ObsoleteAttribute?displayProperty=fullName> attribute that does not have its <xref:System.ObsoleteAttribute.Message%2A?displayProperty=fullName> property specified.

## Rule Description
 <xref:System.ObsoleteAttribute> is used to mark deprecated library types and members. Library consumers should avoid the use of any type or member that is marked obsolete. This is because it might not be supported and will eventually be removed from later versions of the library. When a type or member marked by using <xref:System.ObsoleteAttribute> is compiled, the <xref:System.ObsoleteAttribute.Message%2A> property of the attribute is displayed. This gives the user information about the obsolete type or member. This information generally includes how long the obsolete type or member will be supported by the library designers and the preferred replacement to use.

## How to Fix Violations
 To fix a violation of this rule, add the `message` parameter to the <xref:System.ObsoleteAttribute> constructor.

## When to Suppress Warnings
 Do not suppress a warning from this rule because the <xref:System.ObsoleteAttribute.Message%2A> property provides critical information about the obsolete type or member.

## Example
 The following example shows an obsolete member that has a correctly declared <xref:System.ObsoleteAttribute>.

 [!code-cpp[FxCop.Design.ObsoleteAttributeOnMember#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.ObsoleteAttributeOnMember/cpp/FxCop.Design.ObsoleteAttributeOnMember.cpp#1)]
 [!code-csharp[FxCop.Design.ObsoleteAttributeOnMember#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.ObsoleteAttributeOnMember/cs/FxCop.Design.ObsoleteAttributeOnMember.cs#1)]
 [!code-vb[FxCop.Design.ObsoleteAttributeOnMember#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.ObsoleteAttributeOnMember/vb/FxCop.Design.ObsoleteAttributeOnMember.vb#1)]

## See Also
 <xref:System.ObsoleteAttribute?displayProperty=fullName>
