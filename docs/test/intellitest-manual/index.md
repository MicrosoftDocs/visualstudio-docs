---
title: Microsoft IntelliTest Developer Test Tool
description: Learn how IntelliTest uses an automated and transparent testing approach, IntelliTest can generate a candidate suite of tests for your .NET code.
ms.date: 12/04/2023
ms.topic: conceptual
helpviewer_keywords:
- IntelliTest, Visual Studio IntelliTest developer testing tool
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Overview of Microsoft IntelliTest

IntelliTest enables you to find bugs early, and reduces test maintenance costs. Using an automated and transparent testing approach, IntelliTest can generate a candidate suite of tests for your .NET code. Test suite generation can be further guided by
*correctness properties* you specify. IntelliTest will even evolve the test suite automatically as the code under test evolves.

::: moniker range="visualstudio"
[!INCLUDE [intellitest-deprecation](../includes/intellitest-deprecation.md)]
::: moniker-end
::: moniker range="vs-2022"
[!INCLUDE [intellitest-visual-studio-2022](../includes/intellitest-visual-studio-2022.md)]
::: moniker-end

**Characterization tests**
IntelliTest enables you to determine the behavior of code in terms of a suite of traditional unit tests. Such a test suite can be used as a regression suite, forming the basis for tackling the complexity associated with refactoring legacy or unfamiliar code.

**Guided test input generation**
IntelliTest uses an open code analysis and constraint solving approach to automatically generate precise test input values; usually without the need for any user intervention. For complex object types, it automatically generates factories. You can guide test input generation by extending and configuring the factories to suit your requirements. Correctness properties specified as assertions in code are used automatically to further guide test input generation.

**IDE integration**
IntelliTest is fully integrated into the Visual Studio IDE. All of the information gathered during test suite generation (such as the automatically generated inputs, the output from your code, the generated test cases, and their pass or fail status) appears within the Visual Studio IDE. You can easily iterate between fixing your code and rerunning IntelliTest, without leaving the Visual Studio IDE.
The tests can be saved into the solution as a Unit Test Project, and are automatically detected afterwards by Visual Studio Test Explorer.

**Complement existing testing practices**
Use IntelliTest to complement any existing testing practices that you may already follow.

If you want to test:

* Algorithms over primitive data, or arrays of primitive data:
  * write [parameterized unit tests](test-generation.md#parameterized-unit-testing)
* Algorithms over complex data, such as compiler:
  * let IntelliTest first generate an abstract representation of the data, and then feed it to the algorithm
  * let IntelliTest build instances using [custom object creation](input-generation.md#objects) and data invariants, and then invoke the algorithm
* Data containers:
  * write [parameterized unit tests](test-generation.md#parameterized-unit-testing)
  * let IntelliTest build instances using [custom object creation](input-generation.md#objects) and data invariants, and then invoke a method of the container and recheck invariants afterwards
  * write [parameterized unit tests](test-generation.md#parameterized-unit-testing) that call different methods of the implementation, depending on the parameter values
* An existing code base:
  * use Visual Studio's IntelliTest Wizard to get started by generating a set of [parameterized unit tests (PUTs)](test-generation.md#parameterized-unit-testing)

## The Hello World of IntelliTest

IntelliTest finds inputs relevant to the tested program, which means you can use it to generate the famous **Hello World!** string. This assumes that you have created a C# MSTest-based test project and added a reference to **Microsoft.Pex.Framework**. If you're using a different test framework, create a C# class library and refer to the test framework documentation on how to set up the project.

The following example creates two constraints on the parameter named **value** so that IntelliTest generates the required string:

```csharp
using System;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public partial class HelloWorldTest {
    [PexMethod]
    public void HelloWorld([PexAssumeNotNull]string value) {
        if (value.StartsWith("Hello")
            && value.EndsWith("World!")
            && value.Contains(" "))
            throw new Exception("found it!");
    }
}
```

Once compiled and executed, IntelliTest generates a set of tests such as the following set:

1. ""
2. "\0\0\0\0\0"
3. "Hello"
4. "\0\0\0\0\0\0"
5. "Hello\0"
6. "Hello\0\0"
7. "Hello\0World!"
8. "Hello World!"

> [!NOTE]
> For build issues, try replacing Microsoft.VisualStudio.TestPlatform.TestFramework and Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions references with a reference to  Microsoft.VisualStudio.QualityTools.UnitTestFramework.

Read [Generate unit tests with IntelliTest](../../test/generate-unit-tests-for-your-code-with-intellitest.md) to understand where the generated tests are saved. The generated test code should include a test such as the following code:

```csharp
[TestMethod]
[PexGeneratedBy(typeof(global::HelloWorldTest))]
[PexRaisedException(typeof(Exception))]
public void HelloWorldThrowsException167()
{
    this.HelloWorld("Hello World!");
}
```

It's that easy!

Additional resources:
  * Read this [overview on MSDN Magazine](/archive/msdn-magazine/2015/february/visual-studio-2015-build-better-software-with-smart-unit-tests)

## Important attributes

* [PexClass](attribute-glossary.md#pexclass) marks a type containing **PUT**
* [PexMethod](attribute-glossary.md#pexmethod) marks a **PUT**
* [PexAssumeNotNull](attribute-glossary.md#pexassumenotnull) marks a non-null parameter

```csharp
using Microsoft.Pex.Framework;

[..., PexClass(typeof(Foo))]
public partial class FooTest {
    [PexMethod]
    public void Bar([PexAssumeNotNull]Foo target, int i) {
        target.Bar(i);
    }
}
```

* [PexAssemblyUnderTest](attribute-glossary.md#pexassemblyundertest) binds a test project to a project
* [PexInstrumentAssembly](attribute-glossary.md#pexinstrumentassemblyattribute) specifies an assembly to instrument

```csharp
[assembly: PexAssemblyUnderTest("MyAssembly")] // also instruments "MyAssembly"
[assembly: PexInstrumentAssembly("Lib")]
```

## <a name="helper-classes"></a> Important static helper classes

* [PexAssume](static-helper-classes.md#pexassume) evaluates assumptions (input filtering)
* [PexAssert](static-helper-classes.md#pexassert) evaluates assertions
* [PexChoose](static-helper-classes.md#pexchoose) generates new choices (additional inputs)
* [PexObserve](static-helper-classes.md#pexobserve) logs live values to the generated tests

```csharp
[PexMethod]
void StaticHelpers(Foo target) {
    PexAssume.IsNotNull(target);

    int i = PexChoose.Value<int>("i");
    string result = target.Bar(i);

    PexObserve.ValueForViewing<string>("result", result);
    PexAssert.IsNotNull(result);
}
```

## Limitations

This section describes the limitations of IntelliTest:

* [Nondeterminism](#nondeterminism)
* [Concurrency](#concurrency)
* [Native .NET code](#native-code)
* [Platform](#platform)
* [Language](#language)
* [Symbolic reasoning](#symbolic-reasoning)
* [Stack traces](#incorrect-stack-traces)

### Nondeterminism

IntelliTest assumes that the analyzed program is deterministic. If it isn't, IntelliTest cycles until it reaches an exploration bound.

IntelliTest considers a program to be non-determistic if it relies on inputs that IntelliTest can't control.

IntelliTest controls inputs provided to
[parameterized unit tests](test-generation.md#parameterized-unit-testing) and obtained from the
[PexChoose](static-helper-classes.md#pexchoose).
In that sense, results of calls to unmanaged or uninstrumented code are also considered as "inputs"
to the instrumented program, but IntelliTest can't control them. If the control flow of the program depends on specific values coming from these external sources, IntelliTest can't "steer" the program towards previously uncovered areas.

In addition, the program is considered to be non-determistic if the values from external sources change when rerunning the program. In such cases IntelliTest loses control over the execution of the program and its search becomes inefficient.

Sometimes it isn't obvious when this happens. Consider the following examples:

* The result of the **GetHashCode()** method is provided by unmanaged code, and isn't predictable.
* The **System.Random** class uses the current system time to deliver truly random values.
* The **System.DateTime** class provides the current time, which isn't under the control of IntelliTest.

### Concurrency

IntelliTest doesn't handle multithreaded programs.

### Native code

IntelliTest doesn't understand native code, such as x86 instructions called through **P/Invoke**. It does not know how to translate such calls into constraints that can be passed to the [constraint solver](input-generation.md#constraint-solver). Even for .NET code, it can only analyze code it instruments. IntelliTest can't instrument certain parts of **mscorlib**, including the reflection library. **DynamicMethod** can't be instrumented.

The suggested workaround is to have a test mode where such methods are located in types in a dynamic assembly. However, even if some methods are uninstrumented, IntelliTest tries to cover as much of the instrumented code as possible.

### Platform

IntelliTest is supported only on the X86, 32-bit .NETframework.

### Language

In principle, IntelliTest can analyze arbitrary .NET programs, written in any .NET language. However, in Visual Studio it supports only C#.

### Symbolic reasoning

IntelliTest uses an automatic [constraint solver](input-generation.md#constraint-solver) to determine which values are relevant for the test and the program under test. However, the abilities of the constraint solver are, and always will be, limited.

### Incorrect stack traces

Because IntelliTest catches and "rethrows" exceptions in each instrumented method, the line numbers in stack traces won't be correct. This is a limitation by design of the "rethrow" instruction.

## Related content

* [Introductory blog post](https://devblogs.microsoft.com/devops/introducing-smart-unit-tests/).
* [Generate unit tests for your code with IntelliTest](../../test/generate-unit-tests-for-your-code-with-intellitest.md)
