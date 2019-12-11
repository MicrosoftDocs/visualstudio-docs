---
title: "CA1001: Types that own disposable fields should be disposable | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1001"
  - "TypesThatOwnDisposableFieldsShouldBeDisposable"
helpviewer_keywords:
  - "CA1001"
  - "TypesThatOwnDisposableFieldsShouldBeDisposable"
ms.assetid: c85c126c-2b16-4505-940a-b5ddf873fb22
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1001: Types that own disposable fields should be disposable
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|TypesThatOwnDisposableFieldsShouldBeDisposable|
|CheckId|CA1001|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking - If the type is not visible outside the assembly.<br /><br /> Breaking - If the type is visible outside the assembly.|

## Cause
 A class declares and implements an instance field that is a <xref:System.IDisposable?displayProperty=fullName> type and the class does not implement <xref:System.IDisposable>.

## Rule Description
 A class implements the <xref:System.IDisposable> interface to dispose of unmanaged resources that it owns. An instance field that is an <xref:System.IDisposable> type indicates that the field owns an unmanaged resource. A class that declares an <xref:System.IDisposable> field indirectly owns an unmanaged resource and should implement the <xref:System.IDisposable> interface. If the class does not directly own any unmanaged resources, it should not implement a finalizer.

## How to Fix Violations
 To fix a violation of this rule, implement <xref:System.IDisposable> and from the <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> method call the <xref:System.IDisposable.Dispose%2A> method of the field.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a class that violates the rule and a class that satisfies the rule by implementing <xref:System.IDisposable>. The class does not implement a finalizer because the class does not directly own any unmanaged resources.

 [!code-csharp[FxCop.Design.DisposableFields#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.DisposableFields/cs/FxCop.Design.DisposableFields.cs#1)]
 [!code-vb[FxCop.Design.DisposableFields#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.DisposableFields/vb/FxCop.Design.DisposableFields.vb#1)]

## Related Rules
 [CA2213: Disposable fields should be disposed](../code-quality/ca2213-disposable-fields-should-be-disposed.md)

 [CA2216: Disposable types should declare finalizer](../code-quality/ca2216-disposable-types-should-declare-finalizer.md)

 [CA2215: Dispose methods should call base class dispose](../code-quality/ca2215-dispose-methods-should-call-base-class-dispose.md)

 [CA1049: Types that own native resources should be disposable](../code-quality/ca1049-types-that-own-native-resources-should-be-disposable.md)
