---
title: "IntelliTest Reference Manual | Microsoft Developer Test Tools"
ms.date: 05/02/2017
ms.topic: conceptual
helpviewer_keywords:
  - "IntelliTest Reference Manual, IntelliTest"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# IntelliTest Reference Manual

## Contents

* **[Overview of IntelliTest](introduction.md)**
  - [The Hello World of IntelliTest](introduction.md#the-hello-world-of-intellitest)
  - [Limitations](introduction.md#limitations)
    * [Nondeterminism](introduction.md#nondeterminism)
    * [Concurrency](introduction.md#concurrency)
    * [Native code](introduction.md#native-code)
    * [Platform](introduction.md#platform)
    * [Language](introduction.md#language)
    * [Symbolic reasoning](introduction.md#symbolic-reasoning)
    * [Incorrect stack traces](introduction.md#incorrect-stack-traces)
  - [Further reading](introduction.md#further-reading)

* **[Get started with IntelliTest](getting-started.md)**
  - [Important attributes](getting-started.md#important-attributes)
  - [Important static helper classes](getting-started.md#helper-classes)

* **[Test Generation](test-generation.md)**
  - [Test generators](test-generation.md#test-generators)
  - [Parameterized unit testing](test-generation.md#parameterized-unit-testing)
  - [Generic parameterized unit testing](test-generation.md#generic-parameterized)
  - [Allowing exceptions](test-generation.md#allowing-exceptions)
  - [Testing internal types](test-generation.md#internal-types)
  - [Assumptions and assertions](test-generation.md#assumptions-and-assertions)
  - [Precondition](test-generation.md#precondition)
  - [Postcondition](test-generation.md#postcondition)
  - [Test failures](test-generation.md#test-failures)
  - [Setup and tear down](test-generation.md#setup-teardown)
  - [Further reading](test-generation.md#further-reading)

* **[Input Generation](input-generation.md)**
  - [Constraint solver](input-generation.md#constraint-solver)
  - [Dynamic code coverage](input-generation.md#dynamic-code-coverage)
  - [Integers and floats](input-generation.md#integers-and-floats)
  - [Objects](input-generation.md#objects)
  - [Instantiating existing classes](input-generation.md#existing-classes)
  - [Visibility](input-generation.md#visibility)
  - [Parameterized mocks](input-generation.md#parameterized-mocks)
  - [Structs](input-generation.md#structs)
  - [Arrays and strings](input-generation.md#arrays-and-strings)
  - [Obtaining additional inputs](input-generation.md#additional-inputs)
  - [Further reading](input-generation.md#further-reading)

* **[Exploration Bounds](exploration-bounds.md)**
  - [MaxConstraintSolverTime](exploration-bounds.md#maxconstraintsolvertime)
  - [MaxConstraintSolverMemory](exploration-bounds.md#maxconstraintsolvermemory)
  - [MaxBranches](exploration-bounds.md#maxbranches)
  - [MaxCalls](exploration-bounds.md#maxcalls)
  - [MaxStack](exploration-bounds.md#maxstack)
  - [MaxConditions](exploration-bounds.md#maxconditions)
  - [MaxRuns](exploration-bounds.md#maxruns)
  - [MaxRunsWithoutNewTests](exploration-bounds.md#maxrunswithoutnewtests)
  - [MaxRunsWithUniquePaths](exploration-bounds.md#maxrunswithuniquepaths)
  - [MaxExceptions](exploration-bounds.md#maxexceptions)
  - [TestExcludePathBoundsExceeded](exploration-bounds.md#testexcludepathboundsexceeded)
  - [TestEmissionFilter](exploration-bounds.md#testemissionfilter)
  - [TestEmissionBranchHits](exploration-bounds.md#testemissionbranchhits)

* **[Attribute Glossary](attribute-glossary.md)**
  - [PexAssumeNotNull](attribute-glossary.md#pexassumenotnull)
  - [PexClass](attribute-glossary.md#pexclass)
  - [PexGenericArguments](attribute-glossary.md#pexgenericarguments)
  - [PexMethod](attribute-glossary.md#pexmethod)
  - [PexExplorationAttributeBase](attribute-glossary.md#pexexplorationattributebase)
  - [PexAssemblySettings](attribute-glossary.md#pexassemblysettings)
  - [PexAssemblyUnderTest](attribute-glossary.md#pexassemblyundertest)
  - [PexInstrumentAssemblyAttribute](attribute-glossary.md#pexinstrumentassemblyattribute)
  - [PexUseType](attribute-glossary.md#pexusetype)
  - [PexAllowedException](attribute-glossary.md#pexallowedexception)
  - [PexAllowedExceptionFromAssembly](attribute-glossary.md#pexallowedexceptionfromassembly)
  - [PexAllowedExceptionFromType](attribute-glossary.md#pexallowedexceptionfromtype)
  - [PexAllowedExceptionFromTypeUnderTest](attribute-glossary.md#pexallowedexceptionfromtypeundertest)

* **[Settings Waterfall](settings-waterfall.md)**

* **[Static Helper Classes](static-helper-classes.md)**
  - [PexAssume](static-helper-classes.md#pexassume)
  - [PexAssert](static-helper-classes.md#pexassert)
  - [PexChoose](static-helper-classes.md#pexchoose)
  - [PexObserve](static-helper-classes.md#pexobserve)
  - [PexSymbolicValue](static-helper-classes.md#pexsymbolicvalue)

* **[Warnings and Errors](warnings-and-errors.md)**
  - [MaxBranches exceeded](warnings-and-errors.md#maxbranches-exceeded)
  - [MaxConstraintSolverTime exceeded](warnings-and-errors.md#maxconstraintsolvertime-exceeded)
  - [MaxConditions exceeded](warnings-and-errors.md#maxconditions-exceeded)
  - [MaxCalls exceeded](warnings-and-errors.md#maxcalls-exceeded)
  - [MaxStack exceeded](warnings-and-errors.md#maxstack-exceeded)
  - [MaxRuns exceeded](warnings-and-errors.md#maxruns-exceeded)
  - [MaxRunsWithoutNewTests exceeded](warnings-and-errors.md#maxrunswithoutnewtests-exceeded)
  - [Cannot concretize solution](warnings-and-errors.md#cannot-concretize-solution)
  - [Need help to construct object](warnings-and-errors.md#help-construct)
  - [Need help to find types](warnings-and-errors.md#help-types)
  - [Usable type guessed](warnings-and-errors.md#usable-type-guessed)
  - [Unexpected failure during exploration](warnings-and-errors.md#unexpected-exploration)
  - [TargetInvocationException](warnings-and-errors.md#targetinvocationexception)
  - [Uninstrumented method called](warnings-and-errors.md#uninstrumented-method-called)
  - [External method called](warnings-and-errors.md#external-method-called)
  - [Uninstrumentable method called](warnings-and-errors.md#uninstrumentable-method-called)
  - [Testability issue](warnings-and-errors.md#testability-issue)
  - [Limitation](warnings-and-errors.md#limitation)
  - [Observed call mismatch](warnings-and-errors.md#observed-call-mismatch)
  - [Value stored in static field](warnings-and-errors.md#value-static-field)

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://developercommunity.visualstudio.com/content/idea/post.html?space=8).