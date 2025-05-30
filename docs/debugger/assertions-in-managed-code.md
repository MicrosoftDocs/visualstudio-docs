---
title: Assertions in Managed Code
description: Explore how to work with assertions as a debugging tool for C#, Visual Basic, or F# managed code applications in Visual Studio.
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], assertions in managed code"
  - "Trace.Assert method"
  - "debugging managed code, assertions"
  - "Debug.Assert method"
  - "Debug.Listeners property"
  - "assertions, side effects"
  - "Trace.Listeners property"
  - "assertions, managed code"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Assertions in Managed Code

An assertion, or `Assert` statement, tests a condition, which you specify as an argument to the `Assert` statement. If the condition evaluates to true, no action occurs. If the condition evaluates to false, the assertion fails. If you're running with a debug build, your program enters break mode.

## <a name="BKMK_In_this_topic"></a> In this topic

 [Asserts in the System.Diagnostics Namespace](#BKMK_Asserts_in_the_System_Diagnostics_Namespace)

The [Debug.Assert method](#BKMK_The_Debug_Assert_method)

 [Side effects of Debug.Assert](#BKMK_Side_effects_of_Debug_Assert)

 [Trace and Debug Requirements](#BKMK_Trace_and_Debug_Requirements)

 [Assert arguments](#BKMK_Assert_arguments)

 [Customizing Assert behavior](#BKMK_Customizing_Assert_behavior)

 [Setting assertions in configuration files](#BKMK_Setting_assertions_in_configuration_files)

## <a name="BKMK_Asserts_in_the_System_Diagnostics_Namespace"></a> Asserts in the System.Diagnostics Namespace

In Visual Basic and Visual C#, you can use the `Assert` method from either <xref:System.Diagnostics.Debug> or <xref:System.Diagnostics.Trace>, which are in the <xref:System.Diagnostics> namespace. <xref:System.Diagnostics.Debug> class methods aren't included in a Release version of your program, so they don't increase the size or reduce the speed of your release code.

C++ doesn't support the <xref:System.Diagnostics.Debug> class methods. You can achieve the same effect by using the <xref:System.Diagnostics.Trace> class with conditional compilation, such as `#ifdef DEBUG`... `#endif`.

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_The_Debug_Assert_method"></a> The Debug.Assert method

Use the <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> method freely to test conditions that should hold true if your code is correct. For example, suppose you have written an integer divide function. By the rules of mathematics, the divisor can never be zero. You might test this using an assertion:

### [C#](#tab/csharp)

```csharp
int IntegerDivide ( int dividend , int divisor )
{
    Debug.Assert ( divisor != 0 );
    return ( dividend / divisor );
}
```

### [VB](#tab/vb)

```vb
Function IntegerDivide(ByVal dividend As Integer, ByVal divisor As Integer) As Integer
    Debug.Assert(divisor <> 0)
    Return CInt(dividend / divisor)
End Function
```

---

When you run this code under the debugger, the assertion statement is evaluated, but in the Release version, the comparison is not made, so there is no additional overhead.

Here is another example. You have a class that implements a checking account, as follows:

### [C#](#tab/csharp)

```csharp
float balance = savingsAccount.Balance;
Debug.Assert ( amount <= balance );
savingsAccount.Withdraw ( amount );
```

### [VB](#tab/vb)

```vb
Dim amount, balance As Double
balance = savingsAccount.balance
Debug.Assert(amount <= balance)
SavingsAccount.Withdraw(amount)
```

---

Before you withdraw money from the account, you want to make sure that the account balance is sufficient to cover the amount you're preparing to withdraw. You might write an assertion to check the balance:

### [C#](#tab/csharp)

```csharp
float balance = savingsAccount.Balance;
Trace.Assert ( amount <= balance );
savingsAccount.Withdraw ( amount );
```

### [VB](#tab/vb)

```vb
Dim amount, balance As Double
balance = savingsAccount.balance
Trace.Assert(amount <= balance)
SavingsAccount.Withdraw(amount)
```

---

Note that calls to the <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> method disappear when you create a Release version of your code. That means that the call that checks the balance disappears in the Release version. To solve this problem, you should replace <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> with <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName>, which doesn't disappear in the Release version:

Calls to <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> add overhead to your Release version, unlike calls to <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName>.

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Side_effects_of_Debug_Assert"></a> Side effects of Debug.Assert

When you use <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName>, make sure that any code inside `Assert` doesn't change the results of the program if `Assert` is removed. Otherwise, you might accidentally introduce a bug that only shows up in the Release version of your program. Be especially careful about asserts that contain function or procedure calls, such as the following example:

### [C#](#tab/csharp)

```csharp
// unsafe code
Debug.Assert (meas(i) != 0 );
```

### [VB](#tab/vb)

```vb
' unsafe code
Debug.Assert (meas(i) <> 0 )
```

---

This use of <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> might appear safe at first glance, but suppose the function meas updates a counter each time it is called. When you build the Release version, this call to meas is eliminated, so the counter doesn't get updated. This is an example of a function with a side effect. Eliminating a call to a function that has side effects could result in a bug that only appears in the Release version. To avoid such problems, don't place function calls in a <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> statement. Use a temporary variable instead:

### [C#](#tab/csharp)

```csharp
temp = meas( i );
Debug.Assert ( temp != 0 );
```

### [VB](#tab/vb)

```vb
temp = meas( i )
Debug.Assert (temp <> 0)
```

---

Even when you use <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName>, you might still want to avoid placing function calls inside an `Assert` statement. Such calls should be safe, because <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> statements aren't eliminated in a Release build. However, if you avoid such constructs as a matter of habit, you're less likely to make a mistake when you use <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName>.

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Trace_and_Debug_Requirements"></a> Trace and Debug Requirements

If you create your project using the Visual Studio wizards, the TRACE symbol is defined by default in both Release and Debug configurations. The DEBUG symbol is defined by default only in the Debug build.

Otherwise, for <xref:System.Diagnostics.Trace> methods to work, your program must have one of the following at the top of the source file:

- `#Const TRACE = True` in Visual Basic

- `#define TRACE` in Visual C# and C++

  Or your program must be built with the TRACE option:

- `/d:TRACE=True` in Visual Basic

- `/d:TRACE` in Visual C# and C++

  If you need to use the Debug methods in a C# or Visual Basic Release build, you must define the DEBUG symbol in your Release configuration.

  C++ doesn't support the <xref:System.Diagnostics.Debug> class methods. You can achieve the same effect by using the <xref:System.Diagnostics.Trace> class with conditional compilation, such as `#ifdef DEBUG`... `#endif`. You can define these symbols in the **\<Project> Property Pages** dialog box. For more information, see [Changing Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md) or [Changing Project Settings for a C or C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md).

## <a name="BKMK_Assert_arguments"></a> Assert arguments

 <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> and <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> take up to three arguments. The first argument, which is mandatory, is the condition you want to check. If you call <xref:System.Diagnostics.Trace.Assert(System.Boolean)?displayProperty=fullName> or <xref:System.Diagnostics.Debug.Assert(System.Boolean)?displayProperty=fullName> with only one argument, the `Assert` method checks the condition and, if the result is false, outputs the contents of the call stack to the **Output** window. The following example shows <xref:System.Diagnostics.Trace.Assert(System.Boolean)?displayProperty=fullName> and <xref:System.Diagnostics.Debug.Assert(System.Boolean)?displayProperty=fullName>:

### [C#](#tab/csharp)

```csharp
Debug.Assert ( stacksize > 0 );
Trace.Assert ( stacksize > 0 );
```

### [VB](#tab/vb)

```vb
Debug.Assert(stacksize > 0)
Trace.Assert(stacksize > 0)
```

---

  The second and third arguments, if present, must be strings. If you call <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> or <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName> with two or three arguments, the first argument is a condition. The method checks the condition and, if the result is false, outputs the second string and third strings. The following example shows <xref:System.Diagnostics.Debug.Assert(System.Boolean,System.String)?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Assert(System.Boolean,System.String)?displayProperty=fullName> used with two arguments:

### [C#](#tab/csharp)

```csharp
Debug.Assert ( stacksize > 0, "Out of stack space" );
Trace.Assert ( stacksize > 0, "Out of stack space" );
```

### [VB](#tab/vb)

```vb
Debug.Assert(stacksize > 0, "Out of stack space")
Trace.Assert(stacksize > 0, "Out of stack space")
```

---

  The following example shows <xref:System.Diagnostics.Debug.Assert(System.Boolean,System.String,System.String)?displayProperty=fullName> and <xref:System.Diagnostics.Trace.Assert(System.Boolean,System.String,System.String)?displayProperty=fullName> used with three arguments:

### [C#](#tab/csharp)

```csharp
Debug.Assert ( stacksize > 100, "Out of stack space" , "Failed in inctemp" );
Trace.Assert ( stacksize > 0, "Out of stack space", "Failed in inctemp" );
```

### [VB](#tab/vb)

```vb
Debug.Assert(stacksize > 100, "Out of stack space" , "Failed in inctemp")
Trace.Assert(stacksize > 0, "Out of stack space" , "Failed in inctemp")
```

---

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Customizing_Assert_behavior"></a> Customizing Assert behavior

If you run your application in user interface mode, the `Assert` method displays the **Assertion Failed** dialog box when the condition fails. The actions that occur when an assertion fails are controlled by the <xref:System.Diagnostics.Debug.Listeners%2A> or <xref:System.Diagnostics.Trace.Listeners%2A> property.

You can customize the output behavior by adding a <xref:System.Diagnostics.TraceListener> object to the `Listeners` collection, by removing a <xref:System.Diagnostics.TraceListener> from the `Listeners` collection, or by overriding the <xref:System.Diagnostics.TraceListener.Fail%2A?displayProperty=fullName> method of an existing `TraceListener` to make it behave differently.

For example, you could override the <xref:System.Diagnostics.TraceListener.Fail%2A?displayProperty=fullName> method to write to an event log instead of displaying the **Assertion Failed** dialog box.

To customize the output in this way, your program must contain a listener, and you must inherit from <xref:System.Diagnostics.TraceListener> and override its <xref:System.Diagnostics.TraceListener.Fail%2A?displayProperty=fullName> method.

For more Information, see [Trace Listeners](/dotnet/framework/debug-trace-profile/trace-listeners).

 [In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Setting_assertions_in_configuration_files"></a> Setting assertions in configuration files

You can set assertions in your program configuration file as well as in your code. For more information, see <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName> or <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName>.

## Related content

- <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=fullName>
- <xref:System.Diagnostics.Trace.Assert%2A?displayProperty=fullName>
- [Debugger Security](../debugger/debugger-security.md)
- [Tracing and Instrumenting Applications](/dotnet/framework/debug-trace-profile/tracing-and-instrumenting-applications)
- [How to: Compile Conditionally with Trace and Debug](/dotnet/framework/debug-trace-profile/how-to-compile-conditionally-with-trace-and-debug)
- [Managed debugging: Recommended project settings](../debugger/managed-debugging-recommended-property-settings.md)
- [Debugging Managed Code](/visualstudio/debugger/)
