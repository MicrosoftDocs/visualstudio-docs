---
title: Static helper classes | Microsoft IntelliTest Developer Test Tool
description: Learn about the static helper classes that IntelliTest provides for authoring parameterized unit tests.
ms.date: 05/02/2017
ms.topic: reference
helpviewer_keywords:
- IntelliTest, Static helper classes
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Static helper classes

IntelliTest provides a set of static helper class that can be used when authoring [parameterized unit tests](test-generation.md#parameterized-unit-testing):

* [PexAssume](#pexassume): used to define assumptions on inputs, and is useful for filtering undesirable inputs
* [PexAssert](#pexassert): a simple assertion class for use if your test framework does not provide one
* [PexChoose](#pexchoose): a stream of additional test inputs that IntelliTest manages
* [PexObserve](#pexobserve): logs concrete values and, optionally, validates them in the generated code

Some classes allow you to interact with the IntelliTest reasoning engine at a low-level:

* [PexSymbolicValue](#pexsymbolicvalue): utilities to inspect or modify symbolic constraints on variables

<a name="pexassume"></a>
## PexAssume

A static class used to express assumptions, such as [preconditions](test-generation.md#precondition), in [parameterized unit tests](test-generation.md#parameterized-unit-testing). The methods of this class can be used to filter out undesirable test inputs.

If the assumed condition does not hold for some test input, a **PexAssumeFailedException** is thrown. This will cause the test to be silently ignored.

**Example**

The following parameterized test will not consider **j=0**:

```csharp
public void TestSomething(int i, int j) {
     PexAssume.AreNotEqual(j, 0);
     int k = i/j;
     ...
}
```

**Remarks**

The code above is almost equivalent to:

```csharp
     if (j==0)
          return;
```

except that a failing **PexAssume** results in no test cases. In the case of an **if** statement, IntelliTest generates a separate test case to cover the **then** branch of the **if** statement.

**PexAssume** also contains specialized nested classes for assumptions on string, arrays, and collections.

<a name="pexassert"></a>
## PexAssert

A static class used to express assertions, such as [postconditions](test-generation.md#postcondition), in [parameterized unit tests](test-generation.md#parameterized-unit-testing).

If the asserted condition does not hold for some test input, a **PexAssertFailedException** is thrown, which causes the test to fail.

**Example**

The following asserts that the absolute value of an integer is positive:

```csharp
public void TestSomething(int i) {
     int j = Maths.Abs(i);
     PexAssert.IsTrue(j >= 0);
     ...
}
```

<a name="pexchoose"></a>
## PexChoose

A static class that supplies auxiliary input values to a test, which can be used to implement
[Parameterized Mocks](input-generation.md#parameterized-mocks).

The **PexChoose** class does not help in determining whether a test passes or fails for particular input values. **PexChoose** simply provides input values, which are also referred to as *choices*. It is still up to the user to restrict the input values, and to write assertions that define when a test passes or fails.

**Modes of operation**

The **PexChoose** class can operate in two modes:

* While IntelliTest is performing a symbolic analysis of the test and the tested code during
  [input generation](input-generation.md), the chooser returns arbitrary values and IntelliTest tracks how each value is used in the test and the tested code. IntelliTest will generate relevant values to trigger different execution paths in the test and the tested code.

* The generated code for particular test cases sets up the choice provider in a specific way, so that the re-execution of such a test case will make specific choices to trigger a particular execution path.

**Usage**

* Simple call **PexChoose.Value** to generate a new value:

```csharp
public int Foo() {
    return PexChoose.Value<int>("foo");
}
```

<a name="pexobserve"></a>
## PexObserve

A static class to log named values.

When IntelliTest explores the code, **PexObserve**
is used to record computed values using their formatted string representations. The values are associated with unique names.

```csharp
PexObserve.Value<string>("result", result);
```

**Example**

```csharp
// product code
public static class MathEx {
     public static int Square(int value) { return value * value; }
}

// fixture
[TestClass]
public partial class MathExTests {
     [PexMethod]
     public int SquareTest(int a) {
        int result = MathEx.Square(a);
        // storing result
        return result;
     }
}
```

<a name="pexsymbolicvalue"></a>
## PexSymbolicValue

A static class used to ignore constraints on parameters, and to print the symbolic information associated with values.

**Usage**

Normally, IntelliTest tries to cover all execution paths of the code during execution. However, especially when computing assumption and assertion conditions, it should not explore all possible cases.

**Example**

This example shows the implementation of the **PexAssume.Arrays.ElementsAreNotNull** method.
In the method, you ignore the constraints on the length of the array value to avoid IntelliTest trying to generate different sizes of array. The constraints are ignored only here. If the tested code behaves differently for different array lengths, IntelliTest cannot generate different sized arrays from the constraints of the tested code.

```csharp
public static void AreElementsNotNull<T>(T[] value)
    where T : class
{
    PexAssume.NotNull(value);
    // the following prevents the exploration of all array lengths
    int len = PexSymbolicValue.Ignore<int>(value.Length);

    // building up a boolean value as follows prevents exploration
    // of all combinations of non-null (instead, there are just two cases)
    bool anyNull = false;
    for (int i = 0; i < len; ++i)
        anyNull |= value[i] == null;

    // was any element null?
    if (anyNull)
        PexAssume.Fail("some element of array is a null reference");
}
```

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://aka.ms/feedback/suggest?space=8).
