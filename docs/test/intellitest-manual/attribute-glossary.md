---
title: "Attribute glossary | Microsoft IntelliTest Developer Test Tool"
ms.date: 05/02/2017
ms.topic: reference
helpviewer_keywords:
  - "IntelliTest, Attribute glossary"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Attribute glossary

## Attributes by namespace

* **Microsoft.Pex.Framework**
  * [PexAssumeNotNull](#pexassumenotnull)
  * [PexClass](#pexclass)
  * [PexGenericArguments](#pexgenericarguments)
  * [PexMethod](#pexmethod)
    * [PexExplorationAttributeBase](#pexexplorationattributebase)

* **Microsoft.Pex.Framework.Settings**
  * [PexAssemblySettings](#pexassemblysettings)

* **Microsoft.Pex.Framework.Instrumentation**
  * [PexAssemblyUnderTest](#pexassemblyundertest)
  * [PexInstrumentAssembly](#pexinstrumentassemblyattribute)

* **Microsoft.Pex.Framework.Using**
  * [PexUseType](#pexusetype)

* **Microsoft.Pex.Framework.Validation**
  * [PexAllowedException](#pexallowedexception)
  * [PexAllowedExceptionFromAssembly](#pexallowedexceptionfromassembly)
  * [PexAllowedExceptionFromType](#pexallowedexceptionfromtype)
  * [PexAllowedExceptionFromTypeUnderTest](#pexallowedexceptionfromtypeundertest)

<a name="pexassumenotnull"></a>
## PexAssumeNotNull

This attribute asserts that the governed value
cannot be **null**. It can be attached to:

* a **parameter** of a parameterized test method

  ```csharp
  // assume foo is not null
  [PexMethod]
  public void SomeTest([PexAssumeNotNull]IFoo foo, ...) {}
  ```

* a **field**

  ```csharp
  public class Foo {
     // this field should not be null
     [PexAssumeNotNull]
     public object Bar;
  }
  ```

* a **type**

  ```csharp
  // never consider null for Foo types
  [PexAssumeNotNull]
  public class Foo {}
  ```

It can also be attached to a test assembly, test
fixture or test method; in this case the first
arguments must indicate to which field or type the
assumptions apply. When the attribute applies to a
type, it applies to all fields with this formal type.

<a name="pexclass"></a>
## PexClass

This attribute marks a class that contains
*explorations*. It is the equivalent of the MSTest
**TestClassAttribute** (or the NUnit
**TestFixtureAttribute**). This attribute is optional.

The classes marked with [PexClass](#pexclass) must
be *default constructible*:

* publicly exported type
* default constructor
* not abstract

If the class does not meet those requirements, an
error is reported and the exploration fails.

It is also strongly advised to make those classes
**partial** so that IntelliTest can generate new
tests that are part of the class, but in a separate
file. This approach solves many problems due to
[visibility](input-generation.md#visibility)
and is a typical technique in C#.

**Additional suite and categories**:

```csharp
[TestClass] // MSTest test fixture attribute
[PexClass(Suite = "checkin")] // fixture attribute
public partial class MyTests { ... }
```

**Specifying the type under test**:

```csharp
[PexClass(typeof(Foo))] // this is a test for Foo
public partial class FooTest { ... }
```

The class may contain methods annotated with
[PexMethod](#pexmethod). IntelliTest also understands
[set up and tear down methods](test-generation.md#setup-teardown).

<a name="pexgenericarguments"></a>
## PexGenericArguments

This attribute provides a type tuple for instantiating a
[generic parameterized unit test](test-generation.md#generic-parameterized).

<a name="pexmethod"></a>
## PexMethod

This attribute marks a method as a
[parameterized unit test](test-generation.md#parameterized-unit-testing).
The method must reside within a class marked with the
[PexClass](#pexclass) attribute.

IntelliTest will generate traditional, parameterless
tests, which call the
[parameterized unit test](test-generation.md#parameterized-unit-testing)
with different parameters.

The parameterized unit test:

* must be an instance method
* must be [visible](input-generation.md#visibility)
  to the test class into which the generated tests
  are placed according to the
  [Settings Waterfall](settings-waterfall.md)
* may take any number of parameters
* may be generic

**Example**

```csharp
[PexClass]
public partial class MyTests {
     [PexMethod]
     public void MyTest(int i)
     { ... }
}
```

<a name="pexexplorationattributebase"></a>
## PexExplorationAttributeBase

[More information](xref:Microsoft.Pex.Framework.PexExplorationAttributeBase)

<a name="pexassemblysettings"></a>
## PexAssemblySettings

This attribute can be set at the assembly level to
override default setting values for all explorations.

```csharp
using Microsoft.Pex.Framework;
// overriding the test framework selection
[assembly: PexAssemblySettings(TestFramework = "MSTestv2")]
```

<a name="pexassemblyundertest"></a>
## PexAssemblyUnderTest

This attribute specifies an assembly that
is being tested by the current test project.

```csharp
[assembly: PexAssemblyUnderTest("MyAssembly")]
```

<a name="pexinstrumentassemblyattribute"></a>
## PexInstrumentAssemblyAttribute

This attribute is used to specify an assembly to be
instrumented.

**Example**

```csharp
using Microsoft.Pex.Framework;

// the assembly containing ATypeFromTheAssemblyToInstrument should be instrumented
[assembly: PexInstrumentAssembly(typeof(ATypeFromTheAssemblyToInstrument))]

// the assembly name can be used as well
[assembly: PexInstrumentAssembly("MyAssemblyName")]
```

<a name="pexusetype"></a>
## PexUseType

This attribute tells IntelliTest that it can use a
particular type to instantiate (abstract) base types
or interfaces.

**Example**

```csharp
[PexMethod]
[PexUseType(typeof(A))]
[PexUseType(typeof(B))]
public void MyTest(object testParameter)
{
     ... // IntelliTest will consider types A and B to instantiate 'testParameter'
}
```

<a name="pexallowedexception"></a>
## PexAllowedException

If this attribute is attached to a
[PexMethod](#pexmethod) (or to a
[PexClass](#pexclass), it changes the default IntelliTest
logic that indicates when tests fails. The test will
not be considered as failed, even if it throws the
specified exception.

**Example**

The following test specifies that the constructor of
**Stack** may throw an **ArgumentOutOfRangeException**:

```csharp
class Stack {
  int[] _elements;
  int _count;
  public Stack(int capacity) {
    if (capacity<0) throw new ArgumentOutOfRangeException();
    _elements = new int[capacity];
    _count = 0;
  }
  ...
}
```

The filter is attached to a fixture as follows (it
can also be defined at the assembly or test level):

```csharp
[PexMethod]
[PexAllowedException(typeof(ArgumentOutOfRangeException))]
class CtorTest(int capacity) {
  Stack s = new Stack(capacity); // may throw ArgumentOutOfRangeException
}
```

<a name="pexallowedexceptionfromassembly"></a>
## PexAllowedExceptionFromAssembly

[More information](xref:Microsoft.Pex.Framework.Validation.PexAllowedExceptionFromAssemblyAttribute)

<a name="pexallowedexceptionfromtype"></a>
## PexAllowedExceptionFromType

[More information](xref:Microsoft.Pex.Framework.Validation.PexAllowedExceptionFromTypeAttribute)

<a name="pexallowedexceptionfromtypeundertest"></a>
## PexAllowedExceptionFromTypeUnderTest

[More information](xref:Microsoft.Pex.Framework.Validation.PexAllowedExceptionFromTypeUnderTestAttribute)

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://developercommunity.visualstudio.com/content/idea/post.html?space=8).
