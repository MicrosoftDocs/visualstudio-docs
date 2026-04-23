---
title: Dynamic symbolic execution | Microsoft IntelliTest Developer Test Tool
description: Learn how IntelliTest generates inputs for parameterized unit tests by analyzing the branch conditions in the program. 
ms.date: 05/02/2017
ms.topic: how-to
helpviewer_keywords:
- IntelliTest, Dynamic symbolic execution
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Input generation using dynamic symbolic execution

IntelliTest generates inputs for [parameterized unit tests](test-generation.md#parameterized-unit-testing) by analyzing the branch conditions in the program. Test inputs are chosen based on whether they can trigger new branching behaviors of the program. The analysis is an incremental process. It refines a predicate `q: I -> {true, false}` over the formal test input parameters `I`. `q` represents the set of behaviors that IntelliTest has already observed. Initially, `q := false`, since nothing has yet been observed.

The steps of the loop are:

1. IntelliTest determines inputs `i` such that `q(i)=false` using a [constraint solver](#constraint-solver). By construction, the input `i` will take an execution path not seen before. Initially, this means that `i` can be any input, because no execution path has yet been discovered.

1. IntelliTest executes the test with the chosen input `i`, and monitors the execution of the test and the program under test.

1. During the execution, the program takes a particular path that is determined by all the conditional branches of the program. The set of all conditions that determine the execution is called the *path condition*, written as the predicate `p: I -> {true, false}` over the formal input parameters. IntelliTest computes a representation of this predicate.

1. IntelliTest sets `q := (q or p)`. In other words, it records the fact that it has seen the path represented by `p`.

1. Go to step 1.

IntelliTest's [constraint solver](#constraint-solver) can deal with values of all types that may appear in .NET programs:

* [Integers](#integers-and-floats) and [Floats](#integers-and-floats)
* [Objects](#objects)
* [Structs](#structs)
* [Arrays](#arrays-and-strings) and [Strings](#arrays-and-strings)

IntelliTest filters out inputs that violate stated assumptions.

Besides the immediate inputs (arguments to [parameterized unit tests](test-generation.md#parameterized-unit-testing)), a test can draw further input values from the [PexChoose](static-helper-classes.md#pexchoose) static class. The choices also determine the behavior of [parameterized mocks](#parameterized-mocks).

## Constraint solver

IntelliTest uses a constraint solver to determine the relevant input values of a test and the program under test.

IntelliTest uses the [Z3](https://github.com/Z3Prover/z3/wiki) constraint solver.

## Dynamic code coverage

As a side-effect of the runtime monitoring, IntelliTest collects dynamic code coverage data.
This is called *dynamic* because IntelliTest knows only about code that has been executed, therefore it cannot give absolute values for coverage in the same way as other coverage tool usually do.

For example, when IntelliTest reports the dynamic coverage as 5/10 basic blocks, this means that five blocks out of ten were covered, where the total number of blocks in all methods that have been reached so far by the analysis (as opposed to all methods that exist in the assembly under test) is ten.
Later in the analysis, as more reachable methods are discovered, both the numerator (5 in this example) and the denominator (10) may increase.

## Integers and floats

IntelliTest's [constraint solver](#constraint-solver) determines test input values of primitives types such as **byte**, **int**, **float**, and others in order to trigger different execution paths for the test and the program under test.

## Objects

IntelliTest can either
[create instances of existing .NET classes](#existing-classes), or you can use IntelliTest to automatically [create mock objects](#parameterized-mocks) that implement a specific interface and behave in different ways depending on usage.

<a name="existing-classes"></a>
## Instantiate existing classes

**What's the problem?**

IntelliTest monitors the executed instructions when it runs a test and the program under test. In particular, it monitors all access to fields. It then uses a [constraint solver](#constraint-solver) to determine new test inputs, including objects and their field values, such that the test and the program under test will behave in other interesting ways.

This means that IntelliTest must create objects of certain types and set their field values. If the class is [visible](#visibility) and has a
[visible](#visibility) default constructor, IntelliTest can create an instance of the class.
If all the fields of the class are [visible](#visibility), IntelliTest can set the fields automatically.

If the type is not visible, or the fields are not
[visible](#visibility), IntelliTest needs help to create objects and bring them into interesting states in order to achieve maximal code coverage. IntelliTest could use reflection to create and initialize instances in arbitrary ways, but this is not usually desirable because it might bring the object into a state that can never occur during normal program execution. Instead, IntelliTest relies on hints from the user.

## Visibility

.NET has an elaborate visibility model: types, methods, fields, and other members can be **private**, **public**, **internal**, and more.

When IntelliTest generates tests, it will attempt to perform only actions (such as calling constructors, methods, and setting fields) that are legal with regard to .NET visibility rules from within the context of the generated tests.

The rules are as follows:

* **Visibility of internal members**
  * IntelliTest assumes that the generated tests will have access to internal members that were visible to the enclosing [PexClass](attribute-glossary.md#pexclass).
  .NET has the **InternalsVisibleToAttribute** to extend the visibility of internal members to other assemblies.

* **Visibility of private and family (protected in C#) members of the
  [PexClass](attribute-glossary.md#pexclass)**
  * IntelliTest always places the generated tests directly in the [PexClass](attribute-glossary.md#pexclass) or into a subclass. Therefore, IntelliTest assumes that it may use all visible family members (**protected** in C#).
  * If the generated tests are placed directly into the [PexClass](attribute-glossary.md#pexclass) (usually by using partial classes), IntelliTest assumes that it may also use all private members of the     [PexClass](attribute-glossary.md#pexclass).

* **Visibility of public members**
  * IntelliTest assumes that it may use all exported members visible in the context of the [PexClass](attribute-glossary.md#pexclass).

## Parameterized mocks

How to test a method that has a parameter of an interface type? Or of a non-sealed class? IntelliTest does not know which implementations will later be used when this method is called. And perhaps there isn't even a real implementation available at test time.

The conventional answer is to use *mock objects* with explicit behavior.

A mock object implements an interface (or extends a non-sealed class). It does not represent a real implementation, but just a shortcut that allows the execution of tests using the mock object. Its behavior is defined manually as part of each test case where it is used. Many tools exist that make it easy to define mock objects and their expected behavior, but this behavior must still be manually defined.

Instead of hard-coded values in mock objects, IntelliTest can generate the values. Just as it enables [parameterized unit testing](test-generation.md#parameterized-unit-testing), IntelliTest  also enables parameterized mocks.

Parameterized mocks have two different execution modes:

* **choosing**: when exploring code, parameterized mocks are a source of additional test inputs, and IntelliTest will attempt to choose interesting values
* **replay**: when executing a previously generated test, parameterized mocks behave like stubs with behavior (in other words, predefined behavior).

Use [PexChoose](static-helper-classes.md#pexchoose) to obtain values for parameterized mocks.

## Structs

IntelliTest's reasoning about **struct** values is similar to the way it deals with [objects](#objects).

## Arrays and strings

IntelliTest monitors the executed instructions as it runs a test and the program under test. In particular, it observes when the program depends on the length of a string or an array (and the lower bounds and lengths of a multi-dimensional array).
It also observes how the program uses the different elements of a string or array. It then uses a [constraint solver](#constraint-solver) to determine which lengths and element values might cause the test and the program under test to behave in interesting ways.

IntelliTest attempts to minimize the size of the arrays and strings required to trigger interesting program behaviors.

<a name="additional-inputs"></a>
## Obtain additional inputs

The [PexChoose](static-helper-classes.md#pexchoose) static class can be used to obtain additional inputs to a test, and can be used to implement [parameterized mocks](#parameterized-mocks).

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://aka.ms/feedback/suggest?space=8).

## Related content

* [How does it work?](https://devblogs.microsoft.com/devops/smart-unit-tests-a-mental-model/)
