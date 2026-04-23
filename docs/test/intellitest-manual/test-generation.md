---
title: Generate tests with IntelliTest Test Tool
description: Learn how IntelliTest generates test cases from methods of your implementation, then generates inputs for the methods and check assertions over the data.
ms.date: 05/02/2017
ms.topic: how-to
helpviewer_keywords:
- IntelliTest, Test generation
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Test generation

In traditional unit testing, a test consists of several things:

* A [sequence of method calls](test-generation.md#test-generators)
* The arguments with which the methods are called; the arguments are the [test inputs](input-generation.md)
* Validation of the intended behavior of the tested application by stating a set of [assertions](#assumptions-and-assertions)

Following is an example test structure:

```csharp
[Test]
void MyTest() {
    // data
    ArrayList a = new ArrayList();

    // method sequence
    a.Add(5);

    // assertions
    Assert.IsTrue(a.Count==1);
    Assert.AreEqual(a[0], 5);
}
```

IntelliTest can often automatically determine relevant argument values for more general [Parameterized Unit Tests](#parameterized-unit-testing), which provide the sequence of method calls and assertions.

<a name="test-generators"></a>
## Test generators

IntelliTest generates test cases by selecting a sequence of methods of the implementation under test to execute, and then generating inputs for the methods while checking assertions over the derived data.

A [parameterized unit test](#parameterized-unit-testing) directly states a sequence of method calls in its body.

When IntelliTest needs to construct objects, calls to constructors and factory methods will be added automatically to the sequence as required.

<a name="parameterized-unit-testing"></a>
## Parameterized unit testing

*Parameterized Unit Tests* (PUTs) are tests that take parameters. Unlike traditional unit tests, which are usually closed methods, PUTs take any set of parameters. Is it that simple? Yes - from there, IntelliTest will try to [generate the (minimal) set of inputs](input-generation.md) that [fully cover](input-generation.md#dynamic-code-coverage) the code reachable from the test.

PUTs are defined using the [PexMethod](attribute-glossary.md#pexmethod) custom attribute in a similar fashion to MSTest (or NUnit, xUnit). PUTs are instance methods logically grouped in classes tagged with [PexClass](attribute-glossary.md#pexclass). The following example shows a simple PUT stored in the **MyPexTest** class:

```csharp
[PexMethod]
void ReplaceFirstChar(string target, char c) {

    string result = StringHelper.ReplaceFirstChar(target, c);

    Assert.AreEqual(result[0], c);
}
```

where **ReplaceFirstChar** is a method that replaces the first character of a string:

```csharp
class StringHelper {
    static string ReplaceFirstChar(string target, char c) {
        if (target == null) throw new ArgumentNullException();
        if (target.Length == 0) throw new ArgumentOutOfRangeException();
        return c + target.Substring(1);
    }
}
```

From this test, IntelliTest can automatically [generate inputs](input-generation.md) for a PUT that covers many execution paths of the tested code. Each input that covers a different execution path gets "serialized" as a unit test:

```csharp
[TestMethod, ExpectedException(typeof(ArgumentNullException))]
void ReplaceFirstChar0() {
    this.ReplaceFirstChar(null, 0);
}
...
[TestMethod]
void ReplaceFirstChar10() {
    this.ReplaceFirstChar("a", 'c');
}
```

<a name="generic-parameterized"></a>
## Generic parameterized unit testing

Parameterized unit tests can be generic methods. In this case, the user must specify the types used to instantiate the method by using [PexGenericArguments](attribute-glossary.md#pexgenericarguments).

```csharp
[PexClass]
public partial class ListTest {
    [PexMethod]
    [PexGenericArguments(typeof(int))]
    [PexGenericArguments(typeof(object))]
    public void AddItem<T>(List<T> list, T value)
    { ... }
}
```

<a name="allowing-exceptions"></a>
## Allowing exceptions

IntelliTest provides numerous validation attributes to help triage exceptions into expected exceptions and unexpected exceptions.

Expected exceptions generate negative test cases with the appropriate annotation such as **ExpectedException(typeof(*xxx*))**, while unexpected exceptions generate failing test cases.

```csharp
[PexMethod, PexAllowedException(typeof(ArgumentNullException))]
void SomeTest() {...}
```

The validators are:

* [PexAllowedException](attribute-glossary.md#pexallowedexception): allows a particular exception type from anywhere
* [PexAllowedExceptionFromAssembly](attribute-glossary.md#pexallowedexceptionfromassembly): allows a particular exception type from a specified assembly
* [PexAllowedExceptionFromType](attribute-glossary.md#pexallowedexceptionfromtype): allows a particular exception type from a specified type
* [PexAllowedExceptionFromTypeUnderTest](attribute-glossary.md#pexallowedexceptionfromtypeundertest): allows a particular exception type from the type under test

<a name="internal-types"></a>
## Testing internal types

IntelliTest can "test" internal types, as long as it can see them. For IntelliTest to see the types, the following attribute is added to your product or test project by the Visual Studio IntelliTest wizards:

```csharp
[assembly: InternalsVisibleTo("Microsoft.Pex, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
```

<a name="assumptions-and-assertions"></a>
## Assumptions and assertions

Users can use assumptions and assertions to express [preconditions](#precondition) (assumptions) and [postconditions](#postcondition) (assertions) about their tests. When IntelliTest generates a set of parameter values and "explores" the code, it might violate an assumption of the test. When that happens, it will not generate a test for that path but will silently ignore it.

Assertions are a well known concept in regular unit test frameworks, so IntelliTest already "understands" the built-in **Assert** classes provided by each supported test framework. However, most frameworks do not provide an **Assume** class. In that case, IntelliTest provides the [PexAssume](static-helper-classes.md#pexassume) class. If you do not want to use an existing test framework, IntelliTest also has the [PexAssert](static-helper-classes.md#pexassert) class.

```csharp
[PexMethod]
public void Test1(object o) {
    // precondition: o should not be null
    PexAssume.IsNotNull(o);

    ...
}
```

In particular, the non-nullness assumption can be encoded as a custom attribute:

```csharp
[PexMethod]
public void Test2([PexAssumeNotNull] object o)
// precondition: o should not be null
{
   ...
}
```

<a name="precondition"></a>
## Precondition

A precondition of a method expresses the conditions under which the method will succeed.

Usually, the precondition is enforced by checking the parameters and the object state, and throwing an **ArgumentException** or **InvalidOperationException** if it is violated.

In IntelliTest, a precondition of a [parameterized unit test](#parameterized-unit-testing) is expressed with [PexAssume](static-helper-classes.md#pexassume).

<a name="postcondition"></a>
## Postcondition

A postcondition of a method expresses the conditions which should hold during and after execution of the method, assuming that its preconditions were initially valid.

Usually, the postcondition is enforced by calls to **Assert** methods.

With IntelliTest, a postcondition of a [parameterized unit test](#parameterized-unit-testing) is expressed with [PexAssert](static-helper-classes.md#pexassert).

<a name="test-failures"></a>
## Test failures
When does a generated test case fail?

1. If it does not terminate within the [configured path bounds](exploration-bounds.md), it is considered as a failure unless the [TestExcludePathBoundsExceeded](exploration-bounds.md#testexcludepathboundsexceeded) option is set

1. If the test throws a **PexAssumeFailedException**, it succeeds. However, it is usually filtered out unless [TestEmissionFilter](exploration-bounds.md#testemissionfilter) is set to **All**

1. If the test violates an [assertion](#assumptions-and-assertions); for example, by throwing an assertion violation exception of a unit testing framework, it fails

If none of the above produce a decision, a test succeeds if and only if it does not throw an exception. Assertion violations are treated in the same way as exceptions.

<a name="setup-teardown"></a>
## Setup and tear down

As part of the integration with test frameworks, IntelliTest supports detecting and running setup and tear down methods.

**Example**

```csharp
using Microsoft.Pex.Framework;
using NUnit.Framework;

namespace MyTests
{
    [PexClass]
    [TestFixture]
    public partial class MyTestClass
    {
        [SetUp]
        public void Init()
        {
            // monitored
        }

        [PexMethod]
        public void MyTest(int i)
        {
        }

        [TearDown]
        public void Dispose()
        {
            // monitored
        }
    }
}
```

<a name="further-reading"></a>
## Further reading

* [Test to code binding](https://devblogs.microsoft.com/devops/smart-unit-tests-test-to-code-binding-test-case-management/)
* [One test to rule them all](https://devblogs.microsoft.com/devops/intellitest-one-test-to-rule-them-all/)

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://aka.ms/feedback/suggest?space=8).
