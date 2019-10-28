---
title: "Expressions in the debugger | Microsoft Docs"
ms.date: "02/07/2018"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.expressions"
helpviewer_keywords:
  - "expressions [debugger]"
  - "debugging [Visual Studio], expressions"
  - "expression evaluation, debugger evaluator"
  - "native expression evaluation"
  - "expression evaluators"
  - "debugger, evaluating expressions"
  - "debugging [Visual Studio], expression evaluation"
  - "debugging [Visual Studio], variable evaluation"
ms.assetid: 70f9b531-44c7-4d77-980d-5eddbf2bff41
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Expressions in the Visual Studio debugger
The Visual Studio debugger includes expression evaluators that work when you enter an expression in the **QuickWatch** dialog box, **Watch** window, or **Immediate** window. The expression evaluators are also at work in the **Breakpoints** window and many other places in the debugger.

The following sections describes limitations of expression evaluation for languages supported by Visual Studio.

## F# expressions are not supported
F# expressions are not recognized. If you are debugging F# code, you need to translate your expressions into C# syntax before entering the expressions into a debugger window or dialog box. When you translate expressions from F# to C#, be sure to remember that C# uses the `==` operator to test for equality, while F# uses the single `=`.

## C++ Expressions
For information about using context operators with expressions in C++, see [Context Operator (C++)](../debugger/context-operator-cpp.md).

### Unsupported Expressions in C++

#### Constructors, destructors, and conversions
You cannot call a constructor or destructor for an object, either explicitly or implicitly. For example, the following expression explicitly calls a constructor and results in an error message:

```C++
my_date( 2, 3, 1985 )
```

You cannot call a conversion function if the destination of the conversion is a class. Such a conversion involves the construction of an object. For example, if `myFraction` is an instance of `CFraction`, which defines the conversion function operator `FixedPoint`, the following expression results in an error:

```C++
(FixedPoint)myFraction
```

You cannot call the new or delete operators. For example, the following expression is not supported:

```C++
new Date(2,3,1985)
```

#### Preprocessor Macros
Preprocessor macros are not supported in the debugger. For instance, if a constant `VALUE` is declared as: `#define VALUE 3`, you cannot use `VALUE` in the **Watch** window. To avoid this limitation, you should replace `#define`'s with enums and functions whenever possible.

### using namespace declarations
You cannot use `using namespace` declarations.  In order to access a type name or variable outside of the current namespace, you must use the fully-qualified name.

### Anonymous namespaces
Anonymous namespaces are not supported. If you have the following code, you cannot add `test` to the watch window:

```C++
namespace mars
{
    namespace
    {
        int test = 0;
    }
}
int main()
{
    // Adding a watch on test does not work.
    mars::test++;
    return 0;
}

```

### <a name="BKMK_Using_debugger_intrinisic_functions_to_maintain_state"></a> Using debugger intrinsic functions to maintain state
The debugger intrinsic functions give you a way to call certain C/C++ functions in expressions without changing the state of the application.

Debugger intrinsic functions:

- Are guaranteed to be safe: executing a debugger intrinsic function will not corrupt the process that is being debugged.

- Are allowed in all expressions , even in scenarios where side effects and function evaluation are not allowed.

- Work in scenarios where the regular function calls are not possible, such as debugging a minidump.

  Debugger intrinsic functions can also make evaluating expressions more convenient. For example, `strncmp(str, "asd")` is much easier to write in a breakpoint condition than `str[0] == 'a' && str[1] == 's' && str[2] == 'd'`. )

|Area|Intrinsic functions|
|----------|-------------------------|
|**String length**|strlen, wcslen, strnlen, wcsnlen|
|**String comparison**|strcmp, wcscmp, stricmp, _stricmp, _strcmpi, wcsicmp, _wcscmpi, _wcsnicmp, strncmp, wcsncmp, strnicmp, wcsnicmp|
|**String search**|strchr, wcschr, strstr, wcsstr|
|**Win32**|GetLastError(), TlsGetValue()|
|**Windows 8**|WindowsGetStringLen(), WindowsGetStringRawBuffer()<br /><br /> These functions require the process that is being debugged to be running on Windows 8. Debugging dump files generated from a Windows 8 device also requires that the Visual Studio computer be running Windows 8. However, if you are debugging a Windows 8 device remotely, the Visual Studio computer can be running Windows 7.|
|**Miscellaneous**|__log2<br /><br /> Returns the log base 2 of a specified integer, rounded to the nearest lower integer.|

## C++/CLI - Unsupported Expressions

- Casts that involve pointers, or user-defined casts, are not supported.

- Object comparison and assignment are not supported.

- Overloaded operators and overloaded functions are not supported.

- Boxing and unboxing are not supported.

- `Sizeof` operator is not supported.

## C# - Unsupported Expressions

### Dynamic Objects
You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement <xref:System.Dynamic.IDynamicMetaObjectProvider> are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.

The following features of dynamic objects are not supported:

- The compound operators `+=`, `-=`, `%=`, `/=`, and `*=`

- Many casts, including numeric casts and type-argument casts

- Method calls with more than two arguments

- Property getters with more than two arguments

- Property setters with arguments

- Assigning to an indexer

- Boolean operators `&&` and `||`

### Anonymous Methods
Creation of new anonymous methods is not supported.

## Visual Basic - Unsupported Expressions

### Dynamic Objects
You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement the <xref:System.Dynamic.IDynamicMetaObjectProvider> are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.

The following features of dynamic objects are not supported:

- The compound operators `+=`, `-=`, `%=`, `/=`, and `*=`

- Many casts, including numeric casts and type-argument casts

- Method calls with more than two arguments

- Property getters with more than two arguments

- Property setters with arguments

- Assigning to an indexer

- Boolean operators `&&` and `||`

### Local Constants
Local constants are not supported.

### Import Aliases
Import aliases are not supported.

### Variable Declarations
You cannot declare explicit new variables in debugger windows. However, you can assign new implicit variables inside the **Immediate** window. These implicit variables are scoped to the debug session and are not accessible outside of the debugger. For example, the statement `o = 5` implicitly creates a new variable `o` and assign the value 5 to it. Such implicit variables are of type **Object** unless the type can be inferred by the debugger.

### Unsupported Keywords

- `AddressOf`

- `End`

- `Error`

- `Exit`

- `Goto`

- `On Error`

- `Resume`

- `Return`

- `Select/Case`

- `Stop`

- `SyncLock`

- `Throw`

- `Try/Catch/Finally`

- `With`

- Namespace or module level keywords, such as `End Sub` or `Module`.

## See also
- [Format Specifiers in C++](../debugger/format-specifiers-in-cpp.md)
- [Context Operator (C++)](../debugger/context-operator-cpp.md)
- [Format Specifiers in C#](../debugger/format-specifiers-in-csharp.md)
- [Pseudovariables](../debugger/pseudovariables.md)
