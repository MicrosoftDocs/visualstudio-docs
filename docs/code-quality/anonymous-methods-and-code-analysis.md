---
title: Anonymous method code analysis warnings
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "methods, anonymous"
  - "code analysis, anonymous methods"
  - "anonymous methods, code analysis"
ms.assetid: bf0a1a9b-b954-4d46-9c0b-cee65330ad00
dev_langs:
 - CSharp
 - VB
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Anonymous Methods and Code Analysis

An *anonymous method* is a method that has no name. Anonymous methods are most frequently used to pass a code block as a delegate parameter. This article explains how code analysis handles warnings and metrics for anonymous methods.

## Anonymous Methods Declared In a Member

Warnings and metrics for an anonymous method that's declared in a member, such as a method or accessor, are associated with the member that declares the method. They are not associated with the member that calls the method.

For example, in the following class, any warnings that are found in the declaration of **anonymousMethod** should be raised against **Method1** and not **Method2**.

```vb
Delegate Function ADelegate(ByVal value As Integer) As Boolean

Class AClass
    Sub Method1()
        Dim anonymousMethod As ADelegate = Function(ByVal value As Integer) value > 5
        Method2(anonymousMethod)
    End Sub
    Sub Method2(ByVal anonymousMethod As ADelegate)
        anonymousMethod(10)
    End Sub
End Class
```

```csharp
delegate void Delegate();

class Class
{
    void Method1()
    {
        Delegate anonymousMethod = delegate()
        {
          Console.WriteLine("");
        }
        Method2(anonymousMethod);
    }

    void Method2(Delegate anonymousMethod)
    {
        anonymousMethod();
    }
}
```

## Inline Anonymous Methods

Warnings and metrics for an anonymous method that's declared as an inline assignment to a field are associated with the constructor. If the field is declared as `static` (`Shared` in Visual Basic), the warnings and metrics are associated with the class constructor. Otherwise, they're associated with the instance constructor.

For example, in the following class, any warnings that are found in the declaration of **anonymousMethod1** will be raised against the implicitly generated default constructor of **Class**. Warnings that are found in **anonymousMethod2** will be applied against the implicitly generated class constructor.

```vb
Delegate Function ADelegate(ByVal value As Integer) As Boolean
Class AClass
    Dim anonymousMethod1 As ADelegate = Function(ByVal value As Integer) value > 5
    Shared anonymousMethod2 As ADelegate = Function(ByVal value As Integer) value > 5

    Sub Method1()
        anonymousMethod1(10)
        anonymousMethod2(10)
    End Sub
End Class
```

```csharp
delegate void Delegate();

class Class
{
    Delegate anonymousMethod1 = delegate()
    {
       Console.WriteLine("");
    }

    static Delegate anonymousMethod2 = delegate()
    {
       Console.WriteLine("");
    }

    void Method()
    {
       anonymousMethod1();
       anonymousMethod2();
    }
}
```

A class could contain an inline anonymous method that assigns a value to a field that has multiple constructors. In this case, warnings and metrics are associated with all the constructors unless that constructor chains to another constructor in the same class.

For example, in the following class, any warnings that are found in the declaration of **anonymousMethod** should be raised against **Class(int)** and **Class(string)**, but not against **Class()**.

```vb
Delegate Function ADelegate(ByVal value As Integer) As Boolean

Class AClass

    Dim anonymousMethod As ADelegate = Function(ByVal value As Integer) value > 5

    SubNew()
        New(CStr(Nothing))
    End Sub

    Sub New(ByVal a As Integer)
    End Sub

    Sub New(ByVal a As String)
    End Sub
End Class
```

```csharp
delegate void Delegate();

class Class
{
    Delegate anonymousMethod = delegate()
    {
       Console.WriteLine("");
    }

    Class() : this((string)null)
    {
    }

    Class(int a)
    {
    }

    Class(string a)
    {
    }
}
```

The warnings are raised against the constructors because the compiler outputs a unique method for every constructor that's not chained to another constructor. Because of this behavior, any violation that occurs in **anonymousMethod** must be suppressed separately. This also means that if a new constructor is introduced, warnings that were previously suppressed against **Class(int)** and **Class(string)** must also be suppressed against the new constructor.

You can work around this issue in one of two ways:

- Declare **anonymousMethod** in a common constructor that all constructors chain.
- Declare **anonymousMethod** in an initialization method that's called by all constructors.

## See also

- [Analyzing Managed Code Quality](../code-quality/code-analysis-for-managed-code-overview.md)