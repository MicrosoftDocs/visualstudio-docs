---
title: "CA1052: Static holder types should be sealed"
ms.date: 03/11/2019
ms.topic: reference
f1_keywords:
  - "StaticHolderTypesShouldBeSealed"
  - "CA1052"
helpviewer_keywords:
  - "CA1052"
  - "StaticHolderTypesShouldBeSealed"
ms.assetid: 51a3165d-781e-4a55-aa0d-ea25fee7d4f2
author: gewarren
ms.author: gewarren
manager: jillfra
dev_langs:
 - CPP
 - CSharp
 - VB
ms.workload:
  - "multiple"
---
# CA1052: Static holder types should be sealed

|||
|-|-|
|TypeName|StaticHolderTypesShouldBeSealed|
|CheckId|CA1052|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause

A non-abstract type contains only static members and is not declared with the [sealed](/dotnet/csharp/language-reference/keywords/sealed) ([NotInheritable](/dotnet/visual-basic/language-reference/modifiers/notinheritable)) modifier.

By default, this rule only looks at externally visible types, but this is [configurable](#configurability).

## Rule description

Rule CA1052 assumes that a type that contains only static members is not designed to be inherited, because the type does not provide any functionality that can be overridden in a derived type. A type that is not meant to be inherited should be marked with the `sealed` or `NotInheritable` modifier to prohibit its use as a base type. This rule does not fire for abstract classes.

## How to fix violations

To fix a violation of this rule, mark the type as `sealed` or `NotInheritable`. If you're targeting .NET Framework 2.0 or later, a better approach is to mark the type as `static` or `Shared`. In this manner, you don't have to declare a private constructor to prevent the class from being created.

## When to suppress warnings

Suppress a warning from this rule only if the type is designed to be inherited. The absence of the `sealed` or `NotInheritable` modifier suggests that the type is useful as a base type.

## Configurability

If you're running this rule from [FxCop analyzers](install-fxcop-analyzers.md) (and not through static code analysis), you can configure which parts of your codebase to run this rule on, based on their accessibility. For example, to specify that the rule should run only against the non-public API surface, add the following key-value pair to an .editorconfig file in your project:

```
dotnet_code_quality.ca1052.api_surface = private, internal
```

You can configure this option for just this rule, for all rules, or for all rules in this category (Design). For more information, see [Configure FxCop analyzers](configure-fxcop-analyzers.md).

## Example of a violation

The following example shows a type that violates the rule:

[!code-csharp[FxCop.Design.StaticMembers#1](../code-quality/codesnippet/CSharp/ca1052-static-holder-types-should-be-sealed_1.cs)]
[!code-vb[FxCop.Design.StaticMembers#1](../code-quality/codesnippet/VisualBasic/ca1052-static-holder-types-should-be-sealed_1.vb)]
[!code-cpp[FxCop.Design.StaticMembers#1](../code-quality/codesnippet/CPP/ca1052-static-holder-types-should-be-sealed_1.cpp)]

## Fix with the static modifier

The following example shows how to fix a violation of this rule by marking the type with the `static` modifier in C#:

[!code-csharp[FxCop.Design.StaticMembersFixed#1](../code-quality/codesnippet/CSharp/ca1052-static-holder-types-should-be-sealed_2.cs)]

## Related rules

- [CA1053: Static holder types should not have constructors](../code-quality/ca1053-static-holder-types-should-not-have-constructors.md)