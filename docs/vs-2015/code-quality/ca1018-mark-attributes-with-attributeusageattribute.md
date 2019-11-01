---
title: "CA1018: Mark attributes with AttributeUsageAttribute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1018"
  - "MarkAttributesWithAttributeUsage"
helpviewer_keywords:
  - "CA1018"
  - "MarkAttributesWithAttributeUsage"
ms.assetid: 6ab70ec0-220f-4880-af31-45067703133c
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1018: Mark attributes with AttributeUsageAttribute
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkAttributesWithAttributeUsage|
|CheckId|CA1018|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 The <xref:System.AttributeUsageAttribute?displayProperty=fullName> attribute is not present on the custom attribute.

## Rule Description
 When you define a custom attribute, mark it by using <xref:System.AttributeUsageAttribute> to indicate where in the source code the custom attribute can be applied. The meaning and intended usage of an attribute will determine its valid locations in code. For example, you might define an attribute that identifies the person who is responsible for maintaining and enhancing each type in a library, and that responsibility is always assigned at the type level. In this case, compilers should enable the attribute on classes, enumerations, and interfaces, but should not enable it on methods, events, or properties. Organizational policies and procedures would dictate whether the attribute should be enabled on assemblies.

 The <xref:System.AttributeTargets?displayProperty=fullName> enumeration defines the targets that you can specify for a custom attribute. If you omit <xref:System.AttributeUsageAttribute>, your custom attribute will be valid for all targets, as defined by the `All` value of <xref:System.AttributeTargets> enumeration.

## How to Fix Violations
 To fix a violation of this rule, specify targets for the attribute by using <xref:System.AttributeUsageAttribute>. See the following example.

## When to Suppress Warnings
 You should fix a violation of this rule instead of excluding the message. Even if the attribute inherits <xref:System.AttributeUsageAttribute>, the attribute should be present to simplify code maintenance.

## Example
 The following example defines two attributes. `BadCodeMaintainerAttribute` incorrectly omits the <xref:System.AttributeUsageAttribute> statement, and `GoodCodeMaintainerAttribute` correctly implements the attribute that is described earlier in this section. Note that the property `DeveloperName` is required by the design rule [CA1019: Define accessors for attribute arguments](../code-quality/ca1019-define-accessors-for-attribute-arguments.md) and is included for completeness.

 [!code-csharp[FxCop.Design.AttributeUsage#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeUsage/cs/FxCop.Design.AttributeUsage.cs#1)]
 [!code-vb[FxCop.Design.AttributeUsage#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeUsage/vb/FxCop.Design.AttributeUsage.vb#1)]

## Related Rules
 [CA1019: Define accessors for attribute arguments](../code-quality/ca1019-define-accessors-for-attribute-arguments.md)

 [CA1813: Avoid unsealed attributes](../code-quality/ca1813-avoid-unsealed-attributes.md)

## See Also
 [Attributes](https://msdn.microsoft.com/library/ee0038ef-b247-4747-a650-3c5c5cd58d8b)
