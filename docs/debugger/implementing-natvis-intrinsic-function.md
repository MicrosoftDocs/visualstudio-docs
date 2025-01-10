---
title: Implement NatVis custom intrinsic function
description: Learn how to use the Natvis framework to implement a custom intrinsic function.
ms.date: 01/09/2025
ms.topic: how-to
f1_keywords:
  - natvis, intrinsic function
dev_langs:
  - C++
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Implement NatVis custom intrinsic function for native code

In this article, you learn about the guidelines for implementing a NatVis Intrinsic expansion. For more information, see [Intrinsic expansion](../debugger/create-custom-views-of-native-objects.md#intrinsic-expansion).

## Syntax

A NatVis file may define an intrinsic function using the following syntax:

```xml
<Intrinsic Name="Func" Expression="arg + 1">
  <Parameter Name="arg" Type="int" />
</Intrinsic>
```

Once the definition exists, any debugger expression may call the function, like any other function. For example, using the preceding NatVis definition, the expression `Func(3)` evaluates to 4.

An `<Intrinsic>` element may appear either on the file-level, or inside a `<Type>` element, before any other elements. Intrinsic functions defined within a `<Type>` define member functions of that type, while intrinsic functions defined outside a `<Type>` define global functions. For example:

```xml
<?xml version="1.0" encoding="utf-8"?>
<AutoVisualizer xmlns="http://schemas.microsoft.com/vstudio/debugger/natvis/2010">
  <Type Name="std::vector&lt;*&gt;">
    <Intrinsic Name="size" Expression="_Mypair._Myval2._Mylast - _Mypair._Myval2._Myfirst" />
    <Intrinsic Name="capacity" Expression="_Mypair._Myval2._Myend - _Mypair._Myval2._Myfirst" />
  </Type>
  <Intrinsic Name="LOWORD" Expression="arg & 0xFFFF">
    <Parameter Name="arg" Type="unsigned int" />
  </Intrinsic>
</AutoVisualizer>
```

In the preceding example, `size()` and `capacity()` are defined as member functions of the `std::vector` class,
so whenever an expression evaluates `vector.size()`, it will actually evaluate
`vector._Mypair._Myval2._Mylast - vector._Mypair._Myval2._Myfirst`, rather than perform a func-eval.
Similarly, `LOWORD(0x12345678)` returns `0x5678`, also without func-eval.

## Guidelines for using an intrinsic function

Be aware of the following guidelines when using an intrinsic function:

- Intrinsic functions may be overloaded, either with PDB-defined functions, or with each other.

- When an intrinsic function conflicts with a PDB-defined function with the same name and argument list, the intrinsic function will win. You cannot func-eval the PDB function if an equivelant intrinsic function exists.

- You can't take the address of an intrinsic function; you can only call it.

- Intrinsic member functions must belong to the default view of the respective type in order to be evaluated in an expression. For example, a type entry with an `IncludeView` constraint may not specify an intrinsic function.

- Intrinsic functions may be called from any expression, including NatVis expressions. Intrinsic functions may also call each other. However, intrinsic functions that use recursion are currently not supported. For example:

    ```xml
    <!-- OK -->
        <Intrinsic Name="Func2" Expression="this-&gt;Func3(arg + 1)">
          <Parameter Name="arg" Type="int" />
        </Intrinsic>
        <Intrinsic Name="Func3" Expression="arg + 1">
          <Parameter Name="arg" Type="int"/>
        </Intrinsic>
    
    <!-- Unsupported -->
        <Intrinsic Name="Func2" Expression="this-&gt;Func3(arg + 1)">
          <Parameter Name="arg" Type="int" />
        </Intrinsic>
        <Intrinsic Name="Func3" Expression="Func2(arg + 1)">
          <Parameter Name="arg" Type="int"/>
        </Intrinsic>
    
    <!-- Also unsupported-->
        <Intrinsic Name="Fib" Expression="(n &lt;= 1) ? 1 : Fib(n - 1) + Fib(n - 2)">
          <Parameter Name="n" Type="int"/>
        </Intrinsic>
    ```

- By default, intrinsic functions are assumed to be side-effect free.  That is, they can be called in contexts that disallow side effects, and the implementation expression is not allowed to contain side effects.

  The definition can override this behavior by specifying the `SideEffect` attribute in the declaration. If the function is marked as having side effects, side effects in the implementation expression become permitted. However, invoking the function in contexts where side effects are prohibited is no longer permitted.

- When the definitions of two intrinsic functions conflict with each other (same name, same signature), the last one wins (within the same file).

   Within different files, the instance in the file with higher priority wins (project is higher than user directory, which is higher than install directory).  If a higher-priority definition contains an expression that does not parse, that definition is ignored, and the next-highest priority definition is used instead.

## Guidelines to implement an Intrinsic function

Intrinsic functions support two possible forms of implementation:

- Expression-based 

  The NatVis file defines an expression that evaluates to the return value of the function. The expression may use any arguments passed into it declared as <Parameter> elements.Functions defined within a class are also assumed to be "instance" functions, and may access the "this" pointer as well.

- Extension-based

  The NatVis file provides instructions for invoking a debugger extension to actually evaluate the function.  A debugger extension has full access to the Concord API, and has the ability to perform tasks that are not possible within a NatVis expression.

To provide an extension-based implementation, the <Intrinsic> element should omit the `Expression` attribute and, instead, provide `SourceId`, `LanguageId`, `Id`, and `ReturnType` attributes, as provided in the following example:

```xml
<Intrinsic Name="MyFunc" SourceId="a665fa54-6e7d-480e-a80b-1fc1202e9646" LanguageId="3a12d0b7-c26c-11d0-b442-00a0244a1dd2" Id="1000" ReturnType="double">
  <Parameter Type="int" />
  <Parameter Type="int" />
  <Parameter Type="int" />
</Intrinsic>
```

To implement the function, the debugger extension must implement the `IDkmIntrinsicFunctionEvaluator140` interface, using `LanguageId` and
`SourceId` filters that match the corresponding values of the <Intrinsic> element in the NatVis file.  When the function is called, the call translates into the component's `Execute()` method:

```cpp
STDMETHOD(Execute)(
    _In_ Evaluation::IL::DkmILExecuteIntrinsic* pExecuteIntrinsic,
    _In_ Evaluation::DkmILContext* pILContext,
    _In_ Evaluation::IL::DkmCompiledILInspectionQuery* pInspectionQuery,
    _In_ const DkmArray<Evaluation::IL::DkmILEvaluationResult*>& Arguments,
    _In_opt_ DkmReadOnlyCollection<Evaluation::DkmCompiledInspectionQuery*>* pSubroutines,
    _Out_ DkmArray<Evaluation::IL::DkmILEvaluationResult*>* pResults,
    _Out_ Evaluation::IL::DkmILFailureReason* pFailureReason
    );
```

The component receives the bytes of each argument via the `Arguments` argument.  If the function in question is a member function,
the `this` pointer comes first, followed by the explicit arguments.  The component should return the result by allocating
a single-element array in `pResults`, storing the bytes of the return value.

Use the following guidelines to implement functions:

- It is illegal to "mix and match" the two implementation forms.  That is, you cannot include both an expression and a source id.

- Specifying a return type for an expression-based implementation is allowed, but not required.  If a return type is specified, the return type of the expression must exactly match it (no implicit casting allowed). If a return type is not specified, the return type is inferred from the expression. Any extension-based implementation must state a return type in the NatVis file.

- Non-recursive calls to other intrinsic functions are allowed.  Recursion is not allowed.

- If the function has side effects, you must specify `SideEffect="true"` in the declaration.  It is illegal for an expression-based
implementation to have side effects in the expression without declaring the function to have side effects.  Invoking an extension-based
implementation to have side effects without declaring the function as having side effects is undefined behavior, and should be avoided.

- Varargs intrinsic functions are allowed.  To declare a varargs function, specify `Varargs="true"` in the declaration.  While it is legal for an expression-based implementation to declare a `vararg` function, currently, only extension-based implementations have a way to access the variable arguments.  With an extension-based implementation, the `Execute()` function receives all the arguments that are actually passed in, not just the declared arguments.

- Intrinsic functions consuming a class/struct/union type as an argument type are not supported. Returning a class/struct/union type is OK. (A pointer or reference to a class/struct/union type is OK as an argument type).

## Customize the icon for calls to intrinsic functions.

By default, when you call an intrinsic function, the expression is given the pink diamond icon in the **Watch** window associated with function calls. You can override this behavior by specifying the `Category` attribute using one of the following values:

- Method. Use the pink diamond icon, typically used with method calls (default).

- Property. Use the black wrench icon, typically used with properties.

- Data. Use the blue diamond icon, typically used with data.

By combining intrinsic functions with the <Item> element, it's possible to author a NatVis file where item expressions have the wrench property icon:  

```xml
<Type Name="MyClass">
  <Intrinsic Name="GetValue" ReturnType="int" Expression="m_value" Category="Property" />
  <Expand>
    <Item Name="Value">this-&gt;GetValue()</Item>
  </Expand>
</Type>
```

> ![NOTE]
> Placing the icon choice on the function level, rather than the <Item> level, avoids issues where the icon customization is lost when the full name is evaluated. Because the full name includes a call to the function, it has the same icon customization as the <Item> itself.

