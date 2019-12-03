---
title: "How to: Use Native Run-Time Checks | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "c.runtime.errorchecks"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "/RTC compiler option [C++], /O compiler option"
  - "run-time checks, native"
  - "stack, pointer corruption"
  - "stack pointers, corruption"
  - "/O compiler option, /RTC option"
  - "run-time errors, error checks"
  - "O compiler option, /RTC option"
  - "debugger, runtime errors"
  - "variables [debugger], loss of data"
  - "runtime_checks pragma"
  - "variables [debugger], catching dependencies on uninitialized local variables"
  - "run-time errors, debugging"
  - "debugger, native run-time checks"
  - "optimized build option"
  - "RTC compiler option, /O compiler option"
  - "native run-time checks"
  - "run-time checks"
  - "debugging arrays"
  - "stack pointers"
  - "arrays [Visual Studio], debugging"
ms.assetid: dc7b2f1e-5ff6-42e0-89b3-dc9dead83ee1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "cplusplus"
---
# How to: Use Native Run-Time Checks
In a Visual Studio C++ project, you can use native [runtime_checks](/cpp/preprocessor/runtime-checks) to catch common run-time errors such as:

- Stack pointer corruption.

- Overruns of local arrays.

- Stack corruption.

- Dependencies on uninitialized local variables.

- Loss of data on an assignment to a shorter variable.

  If you use **/RTC** with an optimized (**/O**) build, a compiler error results. If you use a `runtime_checks` pragma in an optimized build, the pragma has no effect.

  When you debug a program that has run-time checks enabled, the default action is for the program to stop and break to the debugger when a run-time error occurs. You can change this default behavior for any run-time check. For more information, see [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md).

  The following procedures describe how to enable native run-time checks in a debug build, and how to modify native run-time check behavior.

  Other topics in this section provide information about:

- [Customizing Run-Time Checks with the C Run-Time Library](../debugger/native-run-time-checks-customization.md)

- [Using Run-Time Checks without the C Run-Time Library](../debugger/using-run-time-checks-without-the-c-run-time-library.md)

### To enable native run-time checks in a debug build

- Use the **/RTC** option and link with the debug version of a C run-time library (/MDd, for example).

### To modify native run-time check behavior

- Use the `runtime_checks` pragma.

## See also
- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [runtime_checks](/cpp/preprocessor/runtime-checks)
- [Run-Time Error Checking](/cpp/c-runtime-library/run-time-error-checking)