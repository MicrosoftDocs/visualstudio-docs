---
title: "CA1812: Avoid uninstantiated internal classes"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "CA1812"
  - "AvoidUninstantiatedInternalClasses"
helpviewer_keywords:
  - "AvoidUninstantiatedInternalClasses"
  - "CA1812"
ms.assetid: 1bb92a42-322a-44cc-98a8-8858212c1e1f
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# CA1812: Avoid uninstantiated internal classes

|||
|-|-|
|TypeName|AvoidUninstantiatedInternalClasses|
|CheckId|CA1812|
|Category|Microsoft.Performance|
|Breaking Change|Non-breaking|

## Cause

An instance of an assembly-level type is not created by code in the assembly.

## Rule description

This rule tries to locate a call to one of the constructors of the type, and reports a violation if no call is found.

The following types are not examined by this rule:

- Value types

- Abstract types

- Enumerations

- Delegates

- Compiler-emitted array types

- Types that cannot be instantiated and that define `static` (`Shared` in Visual Basic) methods only.

If you apply <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute?displayProperty=fullName> to the assembly that is being analyzed, this rule will not occur on any constructors that are marked as `internal` because you cannot tell whether a field is being used by another `friend` assembly.

Even though you cannot work around this limitation in Visual Studio Code Analysis, the external stand-alone FxCop will occur on internal constructors if every `friend` assembly is present in the analysis.

## How to fix violations

To fix a violation of this rule, remove the type or add the code that uses it. If the type contains only static methods, add one of the following to the type to prevent the compiler from emitting a default public instance constructor:

- A private constructor for types that target .NET Framework versions 1.0 and 1.1.

- The `static` (`Shared` in Visual Basic) modifier for types that target [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)].

## When to suppress warnings

It is safe to suppress a warning from this rule. We recommend that you suppress this warning in the following situations:

- The class is created through late-bound reflection methods such as <xref:System.Activator.CreateInstance%2A?displayProperty=fullName>.

- The class is created automatically by the runtime or [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)]. For example, classes that implement <xref:System.Configuration.IConfigurationSectionHandler?displayProperty=fullName> or <xref:System.Web.IHttpHandler?displayProperty=fullName>.

- The class is passed as a generic type parameter that has a new constraint. For example, the following example will raise this rule.

    ```csharp
    internal class MyClass
    {
        public DoSomething()
        {
        }
    }
    public class MyGeneric<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    // [...]
    MyGeneric<MyClass> mc = new MyGeneric<MyClass>();
    mc.Create();
    ```

  In these situations, we recommended you suppress this warning.

## Related rules

[CA1811: Avoid uncalled private code](../code-quality/ca1811-avoid-uncalled-private-code.md)

[CA1801: Review unused parameters](../code-quality/ca1801-review-unused-parameters.md)

[CA1804: Remove unused locals](../code-quality/ca1804-remove-unused-locals.md)