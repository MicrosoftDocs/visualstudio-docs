---
title: "CA1000: Do not declare static members on generic types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1000"
  - "DoNotDeclareStaticMembersOnGenericTypes"
helpviewer_keywords:
  - "DoNotDeclareStaticMembersOnGenericTypes"
  - "CA1000"
ms.assetid: 5c0da594-f8d0-4f40-953d-56bf7fbd2087
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1000: Do not declare static members on generic types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotDeclareStaticMembersOnGenericTypes|
|CheckId|CA1000|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 An externally visible generic type contains a `static` (`Shared` in Visual Basic) member.

## Rule Description
 When a `static` member of a generic type is called, the type argument must be specified for the type. When a generic instance member that does not support inference is called, the type argument must be specified for the member. The syntax for specifying the type argument in these two cases is different and easily confused, as the following calls demonstrate:

```vb
' Shared method in a generic type.
GenericType(Of Integer).SharedMethod()

' Generic instance method that does not support inference.
someObject.GenericMethod(Of Integer)()
```

```csharp
// Static method in a generic type.
GenericType<int>.StaticMethod();

// Generic instance method that does not support inference.
someObject.GenericMethod<int>();
```

 Generally, both of the prior declarations should be avoided so that the type argument does not have to be specified when the member is called. This results in a syntax for calling members in generics that is no different from the syntax for non-generics. For more information, see [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md).

## How to Fix Violations
 To fix a violation of this rule, remove the static member or change it to an instance member.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.

## Related Rules
 [CA1005: Avoid excessive parameters on generic types](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)

 [CA1010: Collections should implement generic interface](../code-quality/ca1010-collections-should-implement-generic-interface.md)

 [CA1002: Do not expose generic lists](../code-quality/ca1002-do-not-expose-generic-lists.md)

 [CA1006: Do not nest generic types in member signatures](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)

 [CA1004: Generic methods should provide type parameter](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)

 [CA1003: Use generic event handler instances](../code-quality/ca1003-use-generic-event-handler-instances.md)

 [CA1007: Use generics where appropriate](../code-quality/ca1007-use-generics-where-appropriate.md)

## See Also
 [Generics](https://msdn.microsoft.com/library/75ea8509-a4ea-4e7a-a2b3-cf72482e9282)
