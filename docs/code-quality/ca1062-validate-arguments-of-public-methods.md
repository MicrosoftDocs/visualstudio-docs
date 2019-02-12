---
title: "CA1062: Validate arguments of public methods"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "CA1062"
  - "ValidateArgumentsOfPublicMethods"
  - "Validate arguments of public methods"
helpviewer_keywords:
  - "CA1062"
  - "ValidateArgumentsOfPublicMethods"
author: gewarren
ms.author: gewarren
manager: jillfra
dev_langs:
 - CSharp
 - VB
ms.workload:
  - "multiple"
---
# CA1062: Validate arguments of public methods

|||
|-|-|
|TypeName|ValidateArgumentsOfPublicMethods|
|CheckId|CA1062|
|Category|Microsoft.Design|
|Breaking Change|Non Breaking|

## Cause

An externally visible method dereferences one of its reference arguments without verifying whether that argument is `null` (`Nothing` in Visual Basic).

## Rule description

All reference arguments that are passed to externally visible methods should be checked against `null`. If appropriate, throw a <xref:System.ArgumentNullException> when the argument is `null`.

If a method can be called from an unknown assembly because it is declared public or protected, you should validate all parameters of the method. If the method is designed to be called only by known assemblies, you should make the method internal and apply the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute to the assembly that contains the method.

## How to fix violations

To fix a violation of this rule, validate each reference argument against `null`.

## When to suppress warnings

You can suppress a warning from this rule if you are sure that the dereferenced parameter has been validated by another method call in the function.

## Example

The following example shows a method that violates the rule and a method that satisfies the rule.

 ```csharp
 using System;

namespace DesignLibrary
{
    public class Test
    {
        // This method violates the rule.
        public void DoNotValidate(string input)
        {
            if (input.Length != 0)
            {
                Console.WriteLine(input);
            }
        }

        // This method satisfies the rule.
        public void Validate(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            if (input.Length != 0)
            {
                Console.WriteLine(input);
            }
        }
    }
}
```

```vb
Imports System

Namespace DesignLibrary

    Public Class Test

        ' This method violates the rule.
        Sub DoNotValidate(ByVal input As String)

            If input.Length <> 0 Then
                Console.WriteLine(input)
            End If

        End Sub

        ' This method satisfies the rule.
        Sub Validate(ByVal input As String)

            If input Is Nothing Then
                Throw New ArgumentNullException("input")
            End If

            If input.Length <> 0 Then
                Console.WriteLine(input)
            End If

        End Sub

    End Class

End Namespace
```

## Example

Copy constructors that populate field or properties that are reference objects can also violate the CA1062 rule. The violation occurs because the copied object that is passed to the copy constructor might be `null` (`Nothing` in Visual Basic). To resolve the violation, use a static (Shared in Visual Basic) method to check that the copied object is not null.

In the following `Person` class example, the `other` object that is passed to the `Person` copy constructor might be `null`.

```csharp
public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy constructor CA1062 fires because other is dereferenced
    // without being checked for null
    public Person(Person other)
        : this(other.Name, other.Age)
    {
    }
}
```

## Example

In the following revised `Person` example, the `other` object that is passed to the copy constructor is first checked for null in the `PassThroughNonNull` method.

```csharp
public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy constructor
    public Person(Person other)
        : this(PassThroughNonNull(other).Name,
          PassThroughNonNull(other).Age)
    {
    }

    // Null check method
    private static Person PassThroughNonNull(Person person)
    {
        if (person == null)
            throw new ArgumentNullException("person");
        return person;
    }
}
```