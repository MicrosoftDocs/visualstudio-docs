---
title: "CA2221: Finalizers should be protected"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "CA2221"
  - "FinalizersShouldBeProtected"
helpviewer_keywords:
  - "FinalizersShouldBeProtected"
  - "CA2221"
ms.assetid: bda03aee-4cce-45d3-907d-17f4ee030acc
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# CA2221: Finalizers should be protected

|||
|-|-|
|TypeName|FinalizersShouldBeProtected|
|CheckId|CA2221|
|Category|Microsoft.Usage|
|Breaking change|Non-breaking|

## Cause
A public type implements a finalizer that does not specify family (protected) access.

## Rule description
Finalizers must use the family access modifier. This rule is enforced by the C#, Visual Basic, and Visual C++ compilers.

## How to fix violations
To fix a violation of this rule, change the finalizer to be family-accessible.

## When to suppress warnings
Do not suppress a warning from this rule.

## Example
This rule cannot be violated in any high-level .NET language; it can be violated if you are writing Microsoft Intermediate Language.

```
// =============== CLASS MEMBERS DECLARATION ===================
//   note that class flags, 'extends' and 'implements' clauses
//          are provided here for information only

.namespace UsageLibrary
{
  .class public auto ansi beforefieldinit FinalizeMethodNotProtected
         extends [mscorlib]System.Object
  {
    .method public hidebysig instance void
            Finalize() cil managed
    {

      // Code size       1 (0x1)
      .maxstack  0
      IL_0000:  ret
    } // end of method FinalizeMethodNotProtected::Finalize

    .method public hidebysig specialname rtspecialname
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  1
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method FinalizeMethodNotProtected::.ctor

  } // end of class FinalizeMethodNotProtected
} // end of namespace
```

## See also

- [Dispose Pattern](/dotnet/standard/design-guidelines/dispose-pattern)