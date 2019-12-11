---
title: "CA2221: Finalizers should be protected | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2221"
  - "FinalizersShouldBeProtected"
helpviewer_keywords:
  - "FinalizersShouldBeProtected"
  - "CA2221"
ms.assetid: bda03aee-4cce-45d3-907d-17f4ee030acc
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2221: Finalizers should be protected
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|FinalizersShouldBeProtected|
|CheckId|CA2221|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A public type implements a finalizer that does not specify family (protected) access.

## Rule Description
 Finalizers must use the family access modifier. This rule is enforced by the C#, Visual Basic, and Visual C++ compilers.

## How to Fix Violations
 To fix a violation of this rule, change the finalizer to be family-accessible.

## When to Suppress Warnings
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

## See Also
 [Dispose Pattern](https://msdn.microsoft.com/library/31a6c13b-d6a2-492b-9a9f-e5238c983bcb)
