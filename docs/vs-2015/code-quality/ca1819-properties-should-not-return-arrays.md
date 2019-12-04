---
title: "CA1819: Properties should not return arrays | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "PropertiesShouldNotReturnArrays"
  - "CA1819"
helpviewer_keywords:
  - "PropertiesShouldNotReturnArrays"
  - "CA1819"
ms.assetid: 85fcf312-57f8-438a-8b10-34441fe0bdeb
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1819: Properties should not return arrays
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PropertiesShouldNotReturnArrays|
|CheckId|CA1819|
|Category|Microsoft.Performance|
|Breaking Change|Breaking|

## Cause
 A public or protected property in a public type returns an array.

## Rule Description
 Arrays returned by properties are not write-protected, even if the property is read-only. To keep the array tamper-proof, the property must return a copy of the array. Typically, users will not understand the adverse performance implications of calling such a property. Specifically, they might use the property as an indexed property.

## How to Fix Violations
 To fix a violation of this rule, either make the property a method or change the property to return a collection.

## When to Suppress Warnings
 Attributes can contain properties that return arrays, but cannot contain properties that return collections. You can suppress a warning that is raised for a property of an attribute that is derived from the [System.Attribute](<!-- TODO: review code entity reference <xref:assetId:///System.Attribute?qualifyHint=False&amp;autoUpgrade=True>  -->) class. Otherwise, do not suppress a warning from this rule.

## Example Violation

### Description
 The following example shows a property that violates this rule.

### Code
 [!code-csharp[FxCop.Performance.PropertyArrayViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayViolation/cs/FxCop.Performance.PropertyArrayViolation.cs#1)]
 [!code-vb[FxCop.Performance.PropertyArrayViolation#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayViolation/vb/FxCop.Performance.PropertyArrayViolation.vb#1)]

### Comments
 To fix a violation of this rule, either make the property a method or change the property to return a collection instead of an array.

## Change the Property to a Method Example

### Description
 The following example fixes the violation by changing the property to a method.

### Code
 [!code-csharp[FxCop.Performance.PropertyArrayFixedMethod#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedMethod/cs/FxCop.Performance.PropertyArrayFixedMethod.cs#1)]
 [!code-vb[FxCop.Performance.PropertyArrayFixedMethod#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedMethod/vb/FxCop.Performance.PropertyArrayFixedMethod.vb#1)]

## Return a Collection Example

### Description
 The following example fixes the violation by changing the property to return a

 <xref:System.Collections.ObjectModel.ReadOnlyCollection%601?displayProperty=fullName>.

### Code
 [!code-csharp[FxCop.Performance.PropertyArrayFixedCollection#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedCollection/cs/FxCop.Performance.PropertyArrayFixedCollection.cs#1)]
 [!code-vb[FxCop.Performance.PropertyArrayFixedCollection#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyArrayFixedCollection/vb/FxCop.Performance.PropertyArrayFixedCollection.vb#1)]

## Allowing Users to Modify a Property

### Description
 You might want to allow the consumer of the class to modify a property. The following example shows a read/write property that violates this rule.

### Code
 [!code-csharp[FxCop.Performance.PropertyModifyViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyViolation/cs/FxCop.Performance.PropertyModifyViolation.cs#1)]
 [!code-vb[FxCop.Performance.PropertyModifyViolation#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyViolation/vb/FxCop.Performance.PropertyModifyViolation.vb#1)]

### Comments
 The following example fixes the violation by changing the property to return a <xref:System.Collections.ObjectModel.Collection%601?displayProperty=fullName>.

### Code
 [!code-csharp[FxCop.Performance.PropertyModifyFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyFixed/cs/FxCop.Performance.PropertyModifyFixed.cs#1)]
 [!code-vb[FxCop.Performance.PropertyModifyFixed#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Performance.PropertyModifyFixed/vb/FxCop.Performance.PropertyModifyFixed.vb#1)]

## Related Rules
 [CA1024: Use properties where appropriate](../code-quality/ca1024-use-properties-where-appropriate.md)
