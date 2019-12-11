---
title: "Exploration bounds | Microsoft IntelliTest Developer Test Tool"
ms.date: 05/02/2017
ms.topic: reference
helpviewer_keywords:
  - "IntelliTest, Exploration bounds"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Exploration bounds

**PexSettingsAttributeBase** is the abstract base class for settings bounds as attributes. See [Settings Waterfall](settings-waterfall.md) for an overview of settings in IntelliTest.

You can modify the settings by using named properties of this and its derived attributes:

```csharp
[PexClass(MaxRuns = 10)]
public partial class FooTest {...}
```

* **Constraint solving bounds**
  * [MaxConstraintSolverTime](#maxconstraintsolvertime) - The number of seconds the [constraint solver](input-generation.md#constraint-solver) has to discover inputs that will cause a new and different execution path to be followed.
  * [MaxConstraintSolverMemory](#maxconstraintsolvermemory) - The size in Megabytes that the [constraint solver](input-generation.md#constraint-solver) may use to discover inputs.
* **Exploration Path Bounds**
  * [MaxBranches](#maxbranches) - The maximum number of branches that may be taken along a single execution path.
  * [MaxCalls](#maxcalls) - The maximum number of calls that may be made during a single execution path.
  * [MaxStack](#maxstack) - The maximum size of the stack at any time during a single execution path, measured as the number of active call frames.
  * [MaxConditions](#maxconditions) - The maximum number of conditions over the inputs that may be checked during a single execution path.
* **Exploration Bounds**
  * [MaxRuns](#maxruns) - The maximum number of runs that will be attempted during an exploration.
  * [MaxRunsWithoutNewTests](#maxrunswithoutnewtests) - The maximum number of consecutive runs without a new test being emitted.
  * [MaxRunsWithUniquePaths](#maxrunswithuniquepaths) - The maximum number of runs with unique execution paths that will be attempted during an exploration.
  * [MaxExceptions](#maxexceptions) - The maximum number of exceptions that may be found for a combination of all discovered execution paths.
* **Test Suite Code Generation Settings**
  * [TestExcludePathBoundsExceeded](#testexcludepathboundsexceeded) - When true, execution paths which exceed any of the path bounds ([MaxCalls](#maxcalls), [MaxBranches](#maxbranches), [MaxStack](#maxstack), [MaxConditions](#maxconditions)) are ignored.
  * [TestEmissionFilter](#testemissionfilter) - Indicates under which circumstances IntelliTest should emit tests.
  * [TestEmissionBranchHits](#testemissionbranchhits) - Controls how many tests IntelliTest emits.

<a name="maxconstraintsolvertime"></a>
## MaxConstraintSolverTime

The number of seconds the
[constraint solver](input-generation.md#constraint-solver) has to calculate inputs that will cause a new and different execution path to be taken. This is an option of the **PexSettingsAttributeBase** and its derived types.

The deeper that IntelliTest explores the execution paths of a program, the more complex the constraint systems that IntelliTest builds from the control-flow and data-flow of the program become. Depending on your time limitation, you can set this value to allow IntelliTest to take more or less time discovering new execution paths.

Typically, the reason for a timeout is that IntelliTest is trying to find a solution for a constraint system that does not have a solution, but it is not aware of this fact. Since this is the most common case for a timeout, it may not make sense to increase the bound.

<a name="maxconstraintsolvermemory"></a>
## MaxConstraintSolverMemory

The number of Megabytes that the [constraint solver](input-generation.md#constraint-solver) has to calculate inputs that will cause a new and different execution path to be taken. This is an option of the *PexSettingsAttributeBase** and its derived types.

The deeper IntelliTest explores the execution paths of a program, the more complex the constraint systems that IntelliTest builds from the control-flow and data-flow of the program become. Depending on the available memory of your computer, you can set this value to allow IntelliTest to tackle more complex constraint systems.

Typically, the reason for a timeout is that IntelliTest is trying to find a solution for a constraint system that does not have a solution, but it is not aware of this fact. Since this is the most common cause of an out-of-memory situation, it may not make sense to increase the bound.

<a name="maxbranches"></a>
## MaxBranches

The maximum number of branches that may be taken along a single execution path.

The motivation behind this exploration bound is to limit the length of any execution path that IntelliTest explores during [input generation](input-generation.md). In particular, it prevents IntelliTest from becoming unresponsive
if the program goes into an infinite loop.

Each conditional and unconditional branch of the executed and monitored code is counted towards this limit, including branches which do not depend on the inputs of the parameterized test.

For example, the following code consumes branches in of the order 100:

```csharp
for (int i=0; i<100; i++) { }
```

<a name="maxcalls"></a>
## MaxCalls

The maximum number of calls that may be made during a single execution path.

The motivation behind this exploration bound is to limit the length of any execution path that IntelliTest explores during [input generation](input-generation.md). In particular, it prevents IntelliTest from becoming unresponsive
if the program calls a method recursively an infinite number of times, which would cause a stack overflow that IntelliTest cannot recover from.

Each call (direct, indirect, virtual, jump) of the executed and monitored code is counted towards this limit.

<a name="maxstack"></a>
## MaxStack

The maximum size of the stack at any time during a single execution path, measured by the number of active call frames.

The motivation behind this exploration bound is to limit the size of the stack of any execution path that IntelliTest explores during [input generation](input-generation.md). In particular, it prevents IntelliTest from using all available stack space, which would cause a stack overflow that IntelliTest cannot recover from.

<a name="maxconditions"></a>
## MaxConditions

The emaximum number of conditions over the inputs that may be checked during a single execution path.

The motivation behind this exploration bound is to limit the complexity of any execution path that IntelliTest explores during [input generation](input-generation.md). Each conditional branch that depends on the inputs of the parameterized test is counted towards this limit.

For example, each path in the following code consumes n+1 conditions:

```csharp
[PexMethod]
void ParameterizedTest(int n)
{
     for (int i=0; i<n; i++) { // conditions are "0<n", "1<n", ..., "!(n<n)"
          ...
     }
     for (int i=0; i<100; i++) { // irrelevant for MaxConditions, since conditions do not depend on input
          ...
     }
}
```

<a name="maxruns"></a>
## MaxRuns

Th emaximum number of runs that IntelliTest will try during the exploration of a test.

The motivation behind this exploration bound is that any code which contains loops or recursion might have an infinite number of execution paths, and thus IntelliTest needs to be limited during [input generation](input-generation.md).

The two settings **MaxRuns** and **MaxRunsWithUniquePaths** are related as follows:

* IntelliTest will call a parameterized test method   up to **MaxRuns** times with different test inputs.
* If the executed code is deterministic, IntelliTest will take a different execution path each time. However, under some conditions the executed code might follow an execution path it has already taken before, with different inputs.
* IntelliTest counts how many unique execution paths it finds; this number is limited by the **MaxRunsWithUniquePaths** option.

<a name="maxrunswithoutnewtests"></a>
## MaxRunsWithoutNewTests

The maximum number of consecutive runs without a new test being emitted.

While IntelliTest can often find many interesting test inputs within a short time, after a while it will not find any more new test inputs and will emit no more unit tests. This configuration option places a bound on the number of consecutive attempts IntelliTest may perform without emitting a new test. When reached, it will halt the exploration.

<a name="maxrunswithuniquepaths"></a>
## MaxRunsWithUniquePaths

The maximum number of unique paths that IntelliTest will consider during an exploration.

The motivation behind this exploration bound is that any code containing loops or recursion might have an infinite number of execution paths, and so IntelliTest must be limited during [input generation](input-generation.md).

The two settings **MaxRuns** and **MaxRunsWithUniquePaths** are related as follows:

* IntelliTest will call a parameterized test method up to **MaxRuns** times with different test inputs.
* If the executed code is deterministic, IntelliTest will take a different execution path each time. However, under some conditions the executed code might follow an execution path it has already taken before, with different inputs.
* IntelliTest counts how many unique execution paths it finds; this number is limited by the **MaxRunsWithUniquePaths** option.

<a name="maxexceptions"></a>
## MaxExceptions

The maximum number of exceptions that can be encountered before exploration is halted.

The motivation behind this exploration bound is to stop the exploration of code that contains many bugs. If IntelliTest finds too many errors in the code, exploration is stopped.

<a name="testexcludepathboundsexceeded"></a>
## TestExcludePathBoundsExceeded

Execution paths that exceed the configured path bounds [MaxCalls](#maxcalls), [MaxBranches](#maxbranches), [MaxStack](#maxstack), and [MaxConditions](#maxconditions) are ignored.

The motivation behind this exploration bound is to deal with (most likely) non-terminating tests. When IntelliTest reaches an exploration bound such as [MaxCalls](#maxcalls), [MaxBranches](#maxbranches), [MaxStack](#maxstack), or [MaxConditions](#maxconditions), it assumes that the test will not be a non-terminating process, and will not cause a stack overflow later on. Such test cases may pose problems to other test frameworks, and this attribute provides a way to prevent IntelliTest from emitting test cases for potentially non-terminating processes or test cases that will cause a stack overflow.

<a name="testemissionfilter"></a>
## TestEmissionFilter

Indicates the types of tests that IntelliTest should emit. The possible values are:

* **All** - Emit tests for everything, including assumption violations.
* **FailuresAndIncreasedBranchHits** (the default) - Emit tests for all unique failures, and whenever a test case increases coverage as controlled by [TestEmissionBranchHits](#testemissionbranchhits).
* **FailuresAndUniquePaths** - Emit tests for all failures IntelliTest finds, and also for each test input that causes a unique execution path.
* **Failures** - Emit tests for failures only.

<a name="testemissionbranchhits"></a>
## TestEmissionBranchHits

Depending on the current [TestEmissionFilter](#testemissionfilter) setting, IntelliTest emits new test cases when they cover a branch in the program that was not covered before.

The **TestEmissionBranchHits** setting determines if IntelliTest should just consider whether a branch was covered at all (**TestEmissionBranchHits=1**), if a test covered it either once or twice (**TestEmissionBranchHits=2**), and so on.

**TestEmissionBranchHits=1** will produce a very small test suite that will cover all branches IntelliTest could reach. In particular, this test suite will also cover all basic blocks and statements it reached.

The default for this option is **TestEmissionBranchHits=2**, which generates a more expressive test suite that is also better suited to detecting future regression errors.

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://developercommunity.visualstudio.com/content/idea/post.html?space=8).
