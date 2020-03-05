---
title: "CA1019: Define accessors for attribute arguments | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1019"
  - "DefineAccessorsForAttributeArguments"
helpviewer_keywords:
  - "CA1019"
  - "DefineAccessorsForAttributeArguments"
ms.assetid: 197f2378-3c43-427e-80de-9ec25006c05c
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1019: Define accessors for attribute arguments
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DefineAccessorsForAttributeArguments|
|CheckId|CA1019|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 In its constructor, an attribute defines arguments that do not have corresponding properties.

## Rule Description
 Attributes can define mandatory arguments that must be specified when you apply the attribute to a target. These are also known as positional arguments because they are supplied to attribute constructors as positional parameters. For every mandatory argument, the attribute should also provide a corresponding read-only property so that the value of the argument can be retrieved at execution time. This rule checks that for each constructor parameter, you have defined the corresponding property.

 Attributes can also define optional arguments, which are also known as named arguments. These arguments are supplied to attribute constructors by name and should have a corresponding read/write property.

 For mandatory and optional arguments, the corresponding properties and constructor parameters should use the same name but different casing. Properties use Pascal casing, and parameters use camel casing.

## How to Fix Violations
 To fix a violation of this rule, add a read-only property for each constructor parameter that does not have one.

## When to Suppress Warnings
 Suppress a warning from this rule if you do not want the value of the mandatory argument to be retrievable.

## Custom Attributes Example

### Description
 The following example shows two attributes that define a mandatory (positional) parameter. The first implementation of the attribute is incorrectly defined. The second implementation is correct.

### Code
 [!code-csharp[FxCop.Design.AttributeAccessors#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeAccessors/cs/FxCop.Design.AttributeAccessors.cs#1)]
 [!code-vb[FxCop.Design.AttributeAccessors#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeAccessors/vb/FxCop.Design.AttributeAccessors.vb#1)]

## Positional and Named Arguments

### Description
 Positional and named arguments make to clear to consumers of your library which arguments are mandatory for the attribute and which arguments are optional.

 The following example shows an implementation of an attribute that has both positional and named arguments.

### Code
 [!code-csharp[FxCop.Design.AttributeAccessorsNamed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeAccessorsNamed/cs/FxCop.Design.AttributeAccessorsNamed.cs#1)]

### Comments
 The following example shows how to apply the custom attribute to two properties.

### Code
 [!code-csharp[FxCop.Design.AttributeAccessorsNamedApplied#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.AttributeAccessorsNamedApplied/cs/FxCop.Design.AttributeAccessorsNamedApplied.cs#1)]

## Related Rules
 [CA1813: Avoid unsealed attributes](../code-quality/ca1813-avoid-unsealed-attributes.md)

## See Also
 [Attributes](https://msdn.microsoft.com/library/ee0038ef-b247-4747-a650-3c5c5cd58d8b)
