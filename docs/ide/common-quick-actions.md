---
title: Common Quick Actions
description: Most popular Quick Actions for C# and Visual Basic including fixing misspelled keywords or symbols, resolving merge conflicts, removing necessary imports, generating types, introducing local variables, etc.
ms.date: 05/20/2022
ms.topic: reference
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
- CSharp
- VB
---
# Common Quick Actions

The sections in this topic list some of the common **Quick Actions** that are applicable to both C# and Visual Basic code. These actions are *code fixes* for either compiler diagnostics, or the built-in [.NET Compiler Platform analyzers](../code-quality/roslyn-analyzers-overview.md) in Visual Studio.

## Actions that fix errors

The Quick Actions in this section fix errors in code that would cause a build to fail. When Quick Actions are available to fix an error on a line of code, the icon that's displayed in the margin or underneath the red squiggle is a light bulb with a red 'x' on it.

![Quick Actions error icon and menu](media/error-light-bulb-with-code.png)

### Correct misspelled symbol or keyword

If you accidentally misspell a type or keyword in Visual Studio, this Quick Action automatically corrects it for you. You'll see these items in the light bulb menu as **"Change '\<misspelled word>' to '\<correct word>'"**. For example:

### [C#](#tab/csharp)
```csharp
// Before
private viod MyMethod()
{
}

// Change 'viod' to 'void'

// After
private void MyMethod()
{
}
```

### [VB](#tab/vb)
```vb
' Before
Function MyFunction as Intger
End Function

' Change 'Intger' to 'Integer'

' After
Function MyFunction as Integer
End Function
```
---

| Error ID | Applicable Languages |
| - | - |
| CS0103, BC30002 | C# and Visual Basic |

### Resolve git merge conflict

These Quick Actions enable you to resolve git merge conflicts by "taking a change", which removes the conflicting code and markers.

```csharp
// Before
private void MyMethod()
{
    if (false)
    {

    }
}

// Take changes from 'HEAD'

// After
private void MyMethod()
{
    if (true)
    {

    }
}
```

| Error ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| CS8300, BC37284 | C# and Visual Basic | Visual Studio 2017 version 15.3 and later |

## Actions that remove unnecessary code

### Remove unnecessary usings/Imports

The **Remove Unnecessary Usings/Imports** Quick Action removes any unused `using` and `Import` directives for the current file. When you select this item, unused namespace imports are removed.

### Remove unnecessary cast

If you cast a type to another type that doesn't require a cast, the **Remove Unnecessary Cast** Quick Action item removes the unnecessary cast.

### [C#](#tab/csharp)
```csharp
// before
int number = (int)3;

// Remove Unnecessary Cast

// after
int number = 3;
```

### [VB](#tab/vb)
```vb
' Before
Dim number as Integer = CType(3, Integer)

' Remove Unnecessary Cast

' After
Dim number as Integer = 3
```
---

### Remove unused variables

This Quick Action enables you to remove variables that have been declared but never used in your code.

```csharp
// Before
public MyMethod()
{
    var unused = 8;
    var used = 1;
    return DoStuff(used);
}

// Remove unused variables

// After
public MyMethod()
{
    var used = 1;
    return DoStuff(used);
}
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| CS0219, BC42024 | C# and Visual Basic | Visual Studio 2017 version 15.3 and later |

### Remove type from default value expression

This Quick Action removes the value type from a default value expression and uses the [default literal](/dotnet/csharp/language-reference/operators/default#default-literal) when the compiler can infer the type of the expression.

```csharp
// Before
void DoWork(CancellationToken cancellationToken = default(CancellationToken)) { ... }

// Simplify default expression

// After
void DoWork(CancellationToken cancellationToken = default) { ... }
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0034 | C# 7.1+ | Visual Studio 2017 version 15.3 and later |

## Actions that add missing code

### Add usings/imports for types in reference assemblies, NuGet packages, or other types in your solution

::: moniker range=">=vs-2022"

Using types located in other projects in your solution will display the Quick Action automatically, however the others need to be enabled from the **Tools > Options > Text Editor > C#** or **Visual Basic > Advanced** tab:

::: moniker-end

::: moniker range="<=vs-2019"

Using types located in other projects in your solution will display the Quick Action automatically, however the others need to be enabled from the **Tools > Options > Text Editor > C#** or **Basic > Advanced** tab:

::: moniker-end

- Suggest usings/imports for types in reference assemblies
- Suggest usings/imports for types in NuGet packages

When enabled, if you use a type in a namespace that is currently not imported but exists in a reference assembly or NuGet package, the using or import directive is created.

### [C#](#tab/csharp)
```csharp
// Before
Debug.WriteLine("Hello");

// using System.Diagnostics;

// After
using System.Diagnostics;

Debug.WriteLine("Hello");
```

### [VB](#tab/vb)
```vb
' Before
Debug.WriteLine("Hello")

' Imports System.Diagnostics

' After
Imports System.Diagnostics

Debug.WriteLine("Hello")
```
---

| Diagnostic ID | Applicable Languages |
| - | - |
| CS0103, BC30451 | C# and Visual Basic|

### Add missing cases/default case/both

When creating a `switch` statement in C#, or `Select Case` statement in Visual Basic, you can use a Code Action to automatically add missing case items, a default case statement, or both.

Consider the following enumeration and empty `switch` or `Select Case` statement:

### [C#](#tab/csharp)
```csharp
enum MyEnum
{
    Item1,
    Item2,
    Item3
}

...

MyEnum myEnum = MyEnum.Item1;

switch(myEnum)
{
}
```

### [VB](#tab/vb)
```vb
Enum MyEnum
    Item1
    Item2
    Item3
End Enum

...

Dim myEnum as MyEnum = MyEnum.Item1

Select Case myEnum
End Select
```
---

Using the **Add Both** Quick Action fills in missing cases and adds a default case:

### [C#](#tab/csharp)
```csharp
switch(myEnum)
{
    case MyEnum.Item1:
        break;
    case MyEnum.Item2:
        break;
    case MyEnum.Item3:
        break;
    default:
        break;
}
```

### [VB](#tab/vb)
```vb
Select Case myEnum
    Case MyEnum.Item1
        Exit Select
    Case MyEnum.Item2
        Exit Select
    Case Else
        Exit Select
End Select
```
---

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0010 | C# and Visual Basic| Visual Studio 2017 version 15.3 and later |

### Add null checks for parameters

This Quick Action enables you to add a check in your code to tell whether a parameter is null.

```csharp
// Before
class MyClass
{
    public string MyProperty { get; set; }

    public MyClass(string myProperty) // cursor inside myProperty
    {
        MyProperty = myProperty;
    }
}

// Add null check

// After
class MyClass
{
    public string MyProperty { get; set; }

    public MyClass(string myProperty)
    {
        MyProperty = myProperty ?? throw new ArgumentNullException(nameof(myProperty));
    }
}
```

| Applicable Languages | Supported Version |
| -------------------- | ---------------- |
| C# and Visual Basic| Visual Studio 2017 version 15.3 and later |

### Add argument name

```csharp
// Before
var date = new DateTime(1997, 7, 8);

// Include argument name 'year' (include trailing arguments)

// After
var date = new DateTime(year: 1997, month: 7, day: 8);
```

| Applicable Languages | Supported Version |
| -------------------- | ---------------- |
| C# and Visual Basic| Visual Studio 2017 version 15.3 and later |

### Add braces

The Add braces Quick Action wraps braces around single-line `if` statements.

```csharp
// Before
if (true)
    return "hello,world";

// Add braces

// After
if (true)
{
    return "hello,world";
}
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0011 | C# | Visual Studio 2017 and later |

### Add and order modifiers

These Quick Actions help organize modifiers by enabling you to sort existing and add missing accessibility modifiers.

```csharp
// Before
enum Color
{
    Red, White, Blue
}

// Add accessibility modifiers

// After
internal enum Color
{
    Red, White, Blue
}
```

```csharp
// Before
static private int thisFieldIsPublic;

// Order modifiers

// After
private static int thisFieldIsPublic;
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0036 | C# and Visual Basic| Visual Studio 2017 version 15.5 and later |
| IDE0040 | C# and Visual Basic| Visual Studio 2017 version 15.5 and later |

## Code transformations

### Convert 'if' construct to 'switch'

This Quick Action enables you to convert an **if-then-else** construct to a **switch** construct.

### [C#](#tab/csharp)
```csharp
// Before
if (obj is string s)
{
  Console.WriteLine("obj is a string: " + s);
}

else if (obj is int i && i > 10)
{
  Console.WriteLine("obj is an int greater than 10");
}

// Convert to switch

// After
switch (obj)
{
  case string s:
    Console.WriteLine("Obj is a string: " + s);
    break;
  case int i when i > 10:
    Console.WriteLine("obj is an int greater than 10");
    break;
}
```

### [VB](#tab/vb)
```vb
' Before
If TypeOf obj Is String s Then
    Console.WriteLine("obj is a string: " + s)
Else If TypeOf obj Is Integer i And i > 10 Then
    Console.WriteLine("obj is an int greater than 10")
End If

' Convert to switch

' After
Select Case obj
  Case String s
    Console.WriteLine("Obj is a string: " + s)
    Exit Sub
  Case Integer i when i > 10
    Console.WriteLine("obj is an int greater than 10")
    Exit Sub
End Select
```
---

| Applicable Languages | Supported Version |
| -------------------- | ---------------- |
| C# and Visual Basic| Visual Studio 2017 version 15.3 and later |

### Convert to interpolated string

[Interpolated strings](/dotnet/csharp/language-reference/keywords/interpolated-strings) are an easy way to express strings with embedded variables, similar to the **[String.Format](/dotnet/api/system.string.format#overloads)** method.  This Quick Action recognizes cases where strings are concatenated, or using **String.Format**, and changes the usage to an interpolated string.

### [C#](#tab/csharp)
```csharp
// Before
int num = 3;
string s = string.Format("My string with {0} in the middle", num);

// Convert to interpolated string

// After
int num = 3;
string s = $"My string with {num} in the middle";
```

### [VB](#tab/vb)
```vb
' Before
Dim num as Integer = 3
Dim s as String = String.Format("My string with {0} in the middle", num)

' Convert to interpolated string

' After
Dim num as Integer = 3
Dim s As String = $"My string with {num} in the middle"
```
---

| Applicable Languages | Supported Version |
| -------------------- | ---------------- |
| C# 6.0+ and Visual Basic 14+ | Visual Studio 2017 and later |

### Use object initializers

This Quick Action enables you to use [object initializers](/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers) rather than invoking the constructor and having additional lines of assignment statements.

### [C#](#tab/csharp)
```csharp
// Before
var c = new Customer();
c.Age = 21;

// Object initialization can be simplified

// After
var c = new Customer() { Age = 21 };
```

### [VB](#tab/vb)
```vb
' Before
Dim c = New Customer()
c.Age = 21

' Object initialization can be simplified

' After
Dim c = New Customer() With {.Age = 21}
```
---

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0017 | C# and Visual Basic | Visual Studio 2017 and later |

### Use collection initializers

This Quick Action lets you use [collection initializers](/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers) rather than multiple calls to the `Add` method of your class.

### [C#](#tab/csharp)
```csharp
// Before
var list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);

// Collection initialization can be simplified

// After
var list = new List<int> { 1, 2, 3 };
```

### [VB](#tab/vb)
```vb
' Before
Dim list = New List(Of Integer)
list.Add(1)
list.Add(2)
list.Add(3)

' Collection initialization can be simplified

' After
Dim list = New List(Of Integer) From {1, 2, 3}
```
---

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0028 | C# and Visual Basic | Visual Studio 2017 and later |

### Convert auto property to full property

This Quick Action enables you to convert an auto property to a full property, and vice versa.

### [C#](#tab/csharp)
```csharp
// Before
private int MyProperty { get; set; }

// Convert to full property

// After
private int MyProperty
{
    get { return _myProperty; }
    set { _myProperty = value; }
}
```

### [VB](#tab/vb)
```vb
' Before
Public Property Name As String

' Convert to full property

' After
Private _Name As String

Public Property Name As String
    Get
        Return _Name
    End Get
    Set
        _Name = Value
    End Set
End Property
```
---

| Applicable Languages | Supported Version |
| -------------------- | ---------------- |
| C# and Visual Basic | Visual Studio 2017 version 15.5 and later |

### Convert block body to expression-bodied member

This Quick Action allows you to convert block bodies into expression-bodied members for methods, constructors, operators, properties, indexers, and accessors.

```csharp
//Before
class MyClass4
{
    private int _myProperty;

    public int MyProperty
    {
        get { return _myProperty; }
        set
        {
            _myProperty = value;
        }
    }

    public MyClass4(int myProperty)
    {
        MyProperty = myProperty;
    }

    public void PrintProperty()
    {
        Console.WriteLine(MyProperty);
    }
}

// Use expression body for accessors/constructors/methods

// After
class MyClass4
{
    private int _myProperty;

    public int MyProperty
    {
        get => _myProperty;
        set => _myProperty = value;
    }

    public MyClass4(int myProperty) => MyProperty = myProperty;

    public void PrintProperty() => Console.WriteLine(MyProperty);
}
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0021-27 | C# 6.0+ | Visual Studio 2017 and later |

### Convert anonymous function to local function

This Quick Action converts anonymous functions into local functions.

```csharp
// Before
Func<int, int> fibonacci = null;
fibonacci = (int n) =>
{
    return n <= 1 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
};

// Use local function

// After
int fibonacci(int n)
{
    return n <= 1 ? 1 : fibonacci(n-1) + fibonacci(n-2);
}
```

### Convert 'ReferenceEquals' to 'is null'

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0041 | C# 7.0+ | Visual Studio 2017 version 15.5 and later |

This Quick Action suggests the use of [pattern matching](/dotnet/csharp/pattern-matching) rather than the `ReferenceEquals` coding-pattern, where possible.

```csharp
// Before
var value = "someString";
if (object.ReferenceEquals(value, null))
{
    return;
}

// Use 'is null' check

// After
var value = "someString";
if (value is null)
{
    return;
}
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0039 | C# 7.0+ | Visual Studio 2017 version 15. and later |

### Introduce pattern matching

This Quick Action suggests the use of [pattern matching](/dotnet/csharp/pattern-matching) with casts and null checks in C#.

```csharp
// Before
if (o is int)
{
    var i = (int)o;
    ...
}

// Use pattern matching

// After
if (o is int i)
{
    ...
}
```

```csharp
// Before
var s = o as string;
if (s != null)
{
    ...
}

// Use pattern matching

// After
if (o is string s)
{
    ...
}
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0020 | C# 7.0+ | Visual Studio 2017 and later |
| IDE0019 | C# 7.0+ | Visual Studio 2017 and later |

### Change base for numeric literals

This Quick Action enables you to convert a numeric literal from one base numeric system to another. For example, you can change a number to hexadecimal or to binary format.

### [C#](#tab/csharp)
```csharp
// Before
int countdown = 2097152;

// Convert to hex

// After
int countdown = 0x200000;
```

### [VB](#tab/vb)
```vb
' Before
Dim countdown As Integer = 2097152

' Convert to hex

' After
Dim countdown As Integer = &H200000
```
---

| Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| C# 7.0+ and Visual Basic 14+ | Visual Studio 2017 version 15.3 and later |

### Insert digit separators into literals

This Quick Action enables you to add separator characters into literal values.

### [C#](#tab/csharp)
```csharp
// Before
int countdown = 1000000;

// Separate thousands

// After
int countdown = 1_000_000;
```

### [VB](#tab/vb)
```vb
' Before
Dim countdown As Integer = 1000000

' Separate thousands

' After
Dim countdown As Integer = 1_000_000
```
---

| Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| C# 7.0+ and Visual Basic 14+ | Visual Studio 2017 version 15.3 and later |

### Use explicit tuple names

This Quick Action identifies areas where the explicit tuple name can be used rather than Item1, Item2, etc.

### [C#](#tab/csharp)
```csharp
// Before
(string name, int age) customer = GetCustomer();
var name = customer.Item1;

// Use explicit tuple name

// After
(string name, int age) customer = GetCustomer();
var name = customer.name;
```

### [VB](#tab/vb)
```vb
' Before
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.Item1

' Use explicit tuple name

' After
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.name
```
---

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0033 | C# 7.0+ and Visual Basic 15+ | Visual Studio 2017 and later |

### Use inferred names

This Quick Action points out when code can be simplified to use inferred member names in anonymous types, or inferred element names in tuples.

```csharp
// Before
var anon = new { age = age, name = name };

// Use inferred member name

// After
var anon = new { age, name };
```

```csharp
// Before
var tuple = (age: age, name: name);

// Use inferred tuple element name

// After
var tuple = (age, name);
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0037 | C# | Visual Studio 2017 version 15.5 and later |
| IDE0037 | C# 7.1+ | Visual Studio 2017 version 15.5 and later |

### Deconstruct tuple declaration

This Quick Action enables deconstructing tuple variable declarations.

```csharp
// Before
var person = GetPersonTuple();
Console.WriteLine($"{person.name} {person.age}");

(int x, int y) point = GetPointTuple();
Console.WriteLine($"{point.x} {point.y}");

//Deconstruct variable declaration

// After
var (name, age) = GetPersonTuple();
Console.WriteLine($"{name} {age}");

(int x, int y) = GetPointTuple();
Console.WriteLine($"{x} {y}");
```

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| IDE0042 | C# 7.0+ | Visual Studio 2017 version 15.5 and later |

### Make method synchronous

When using the `async` or `Async` keyword on a method, it's expected that inside that method the `await` or `Await` keyword is also used. However, if this isn't the case, a Quick Action appears that makes the method synchronous by removing the `async` or `Async` keyword and changing the return type. Use the **Make method synchronous** option from the Quick Actions menu.

### [C#](#tab/csharp)
```csharp
// Before
async Task<int> MyAsyncMethod()
{
    return 3;
}

// Make method synchronous

// After
int MyAsyncMethod()
{
    return 3;
}
```

### [VB](#tab/vb)
```vb
' Before
Async Function MyAsyncMethod() As Task(Of Integer)
    Return 3
End Function

' Make method synchronous

' After
Function MyAsyncMethod() As Integer
    Return 3
End Function
```
---

| Error ID | Applicable Languages |
| ------- | -------------------- |
| CS1998, BC42356 | C# and Visual Basic |

### Make method asynchronous

When using the `await` or `Await` keyword inside of a method, it's expected that the method is marked with the `async` or `Async` keyword. However, if this isn't the case, a Quick Action appears that makes the method asynchronous. Use the **Make method/Function asynchronous** option from the Quick Actions menu.

### [C#](#tab/csharp)
```csharp
// Before
int MyAsyncMethod()
{
    return await Task.Run(...);
}

// Make method asynchronous

// After
async Task<int> MyAsyncMethod()
{
    return await Task.Run(...);
}
```

### [VB](#tab/vb)
```vb
' Before
Function MyAsyncMethod() as Integer
    Return  Await Task.Run(...)
End Function

' Make method asynchronous

' After
Async Function MyAsyncMethod() As Task(Of Integer)
    Return Await Task.Run(...)
End Function
```
---

| Error ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ---------------- |
| CS4032, BC37057 | C# and Visual Basic | Visual Studio 2017 and later |

## See also

- [Quick Actions](../ide/quick-actions.md)
