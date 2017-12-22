---
title: "Quick Actions | Microsoft Docs"
ms.custom: ""
ms.date: "11/30/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
dev_langs: 
  - CSharp
  - VB
ms.workload: 
  - "multiple"
---
# Quick Actions

[Quick Actions](refactoring-code-generation-quick-actions.md#quick-actions) let you easily refactor, generate, or otherwise modify code with a single action. Quick Actions are available for C#, [C++](/cpp/ide/writing-and-refactoring-code-cpp), and Visual Basic code files. Some actions are specific to a language, and others apply to all languages. Quick Actions can be applied using the Light Bulb icon ![Small Light Bulb Icon](media/vs2015_lightbulbsmall.png "VS2017_LightBulbSmall"), or by pressing **Ctrl** + **.** when your cursor is on the appropriate line of code.

You will see a light bulb if there is a red squiggle and Visual Studio has a suggestion for how to fix the issue. For instance if you have an error indicated by a red squiggle, a light bulb will appear when fixes are available for that error. For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs will light up based on those rules.

## To see a light bulb

1. In many cases, light bulbs spontaneously appear when you hover the mouse at the point of an error, or in the left margin of the editor when you move the caret into a line that has an error in it. When you see a red squiggle, you can hover over it to display the light bulb. You can also cause a light bulb to display when you use the mouse or keyboard to go to anywhere in the line where the issue occurs.

1. Press **Ctrl** + **.** anywhere on a line to invoke the light bulb and go directly to the list of potential fixes.

   ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png "VS2017_LightBulb_Hover")

## To see potential fixes

Either click on the down arrow or the Show potential fixes link to display a list of quick actions that the light bulb can take for you.

![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png "VS2017_LightBulb_hover_expanded")

## Common Quick Actions

Here are some of the common Quick Actions which are applicable to both C# and Visual Basic code:

- [Actions that fix errors](#fix)
- [Actions that remove unnecessary code](#remove)
- [Actions that add missing code](#add)
- [Code transformations](#transform)

### <a id="fix"></a> Actions that fix errors

#### Correct misspelled symbol or keyword

|  Error ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS0103, BC30002 | C# and Visual Basic | Visual Studio 2015 Update 2 |

If you accidentally misspell a type or keyword in Visual Studio, this Quick Action will automatically correct it for you. You'll see these items in the light bulb menu as **"Change '*misspelled word*' to '*correct word*'**.  For example:

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

```vb
' Before
Function MyFunction as Intger
End Function

' Change 'Intger' to 'Integer'

' After
Function MyFunction as Integer
End Function
```

#### Resolve git merge conflict

|  Error ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS8300, BC37284  | C# and Visual Basic | Visual Studio 2017 version 15.3 |

These Quick Actions enable you to resolve git merge conflicts by "taking a change", which removes the conflicting code and markers.  

```csharp
// Before
private void MyMethod()
{
<<<<<<< HEAD
    if (true)
    {

    }
=======
    if (false)
    {

    }
>>>>>>> upstream
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

#### Make method synchronous

|  Error ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS1998, BC42356 | C# and Visual Basic | Visual Studio 2015 Update 2 |

When using the `async` or `Async` keyword on a method, it is expected that somewhere inside that method the `await` or `Await` keyword will also be used.  However, if this isn't the case, a Quick Action will appear that will allow you to make the method synchronous by removing the `async` or `Async` keyword and changing the return type. Use the **Make method synchronous** option from the Quick Actions menu.

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

#### Make method asynchronous

|  Error ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS4032, BC37057 | C# and Visual Basic | Visual Studio 2017 |

When using the `await` or `Await` keyword inside of a method, it is expected that the method itself is marked with the `async` or `Async` keyword.  However, if this isn't the case, a Quick Action will appear that will allow you to make the method asynchronous. Use the **Make method/Function asynchronous** option from the Quick Actions menu.

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

### <a id="remove"></a> Actions that remove unnecessary code

#### Remove unnecesary usings/Imports

|  Applicable Languages |  Supported Version |
|  -------------------- | ----------------  |
|  C# and Visual Basic | Visual Studio 2015 RTW |

The **Remove Unnecessary Usings/Imports** Quick Action will remove any unused `using` and `Import` statements for the current file.  When you select this item, unused namespace imports will be immediately removed.

#### Remove unnecessary cast

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0004 | C# and Visual Basic | Visual Studio 2015 RTW |

If you cast a type to another type which doesn't require a cast, the **Remove Unnecessary Cast** Quick Action item will remove the cast from your code.

```csharp
// before
int number = (int)3;

// Remove Unnecessary Cast

// after
int number = 3;
```

```vb
' Before
Dim number as Integer = CType(3, Integer)

' Remove Unnecessary Cast

' After
Dim number as Integer = 3
```

#### Remove unused variables

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS0219, BC42024 | C# and Visual Basic | Visual Studio 2017 version 15.3 |

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

#### Remove type from **default** value expression

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0034 | C# 7.1+ | Visual Studio 2017 version 15.3 |

This Quick Action removes the value type from a default value expression and uses the [`default` literal](/dotnet/csharp/programming-guide/statements-expressions-operators/default-value-expressions#default-literal-and-type-inference) when the compiler can infer the type of the expression.

```csharp
// Before
void DoWork(CancellationToken cancellationToken = default(CancellationToken)) { ... }

// Simplify default expression

// After
void DoWork(CancellationToken cancellationToken = default) { ... }

```

### <a id="add"></a> Actions that add missing code

#### Add usings/Imports for types in reference assemblies, NuGet packages, or other types in your solution

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| CS0103, BC30451 | C# and Visual Basic| Visual Studio 2015 Update 2 |

Using types located in other projects in your solution will display the Quick Action automatically, however the others need to be enabled from the **Tools > Options > C#** or **Basic > Advanced** tab:

- Suggest usings/imports for types in reference assemblies
- Suggest usings/imports for types in NuGet packages

When enabled, if you use a type in a namespace that is currently not imported, but exists in a reference assembly or NuGet package, the using/import statement will be created.

```csharp
// Before
Debug.WriteLine("Hello");

// using System.Diagnostics;

// After
using System.Diagnostics;

Debug.WriteLine("Hello");
```

```vb
' Before
Debug.WriteLine("Hello")

' Imports System.Diagnostics

// After
Imports System.Diagnostics

Debug.WriteLine("Hello")
```

#### Add missing cases/default case/both

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0010 | C# and Visual Basic| Visual Studio 2017 version 15.3 |

When creating a `switch` statement in C#, or `Select Case` statement in Visual Basic, you can use a Code Action to automatically add missing case items, a default case statement, or both.

Consider the following enumeration and empty `switch` or `Select Case` statement:

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

Using the **Add Both** Quick Action fills in missing cases and adds a default case:

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

#### Add null checks for parameters

| Applicable Languages |  Supported Version |
| -------------------- | ----------------  |
| C# and Visual Basic| Visual Studio 2017 version 15.3 |

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

#### Add argument name

| Applicable Languages |  Supported Version |
| -------------------- | ----------------  |
| C# and Visual Basic| Visual Studio 2017 version 15.3 |

```csharp
// Before
var date = new DateTime(1997, 7, 8);

// Include argument name 'year' (include trailing arguments)

// After
var date = new DateTime(year: 1997, month: 7, day: 8);
```

#### Add braces

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0011 | C# | Visual Studio 2017 RTW |

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

#### Add and order modifiers

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0036 | C# and Visual Basic| Visual Studio 2017 version 15.5 |
| IDE0040 | C# and Visual Basic| Visual Studio 2017 version 15.5 |

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

### <a id="transform"></a> Code transformations

#### Convert **if** construct to **switch**

| Applicable Languages |  Supported Version |
| -------------------- | ----------------  |
| C# and Visual Basic| Visual Studio 2017 version 15.3 |

This Quick Action enables you to convert an **if-then-else** construct to a **switch** construct.

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

#### Convert to interpolated string

| Applicable Languages |  Supported Version |
| -------------------- | ----------------  |
| C# 6.0+ and Visual Basic 14+ | Visual Studio 2017 RTW |

[Interpolated strings](/dotnet/csharp/language-reference/keywords/interpolated-strings) are an easy way to express strings with embedded variables, similar to the **[String.Format](https://msdn.microsoft.com/library/system.string.format.aspx)** method.  This Quick Action recognizes cases where strings are concatenated, or using **String.Format**, and changes the usage to an interpolated string.

```csharp
// Before
int num = 3;
string s = string.Format("My string with {0} in the middle", num);

// Convert to interpolated string

// After
int num = 3;
string s = $"My string with {num} in the middle";
```

```vb
' Before
Dim num as Integer = 3
Dim s as String = String.Format("My string with {0} in the middle", num)

' Convert to interpolated string

' After
Dim num as Integer = 3
Dim s As String = $"My string with {num} in the middle"
```

#### Use object initializers

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0017 | C# and Visual Basic | Visual Studio 2017 RTW |

This Quick Action enables you to use [object initializers](/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers.md) rather than invoking tne constructor and having additional lines of assignment statements.

```csharp
// Before
var c = new Customer();
c.Age = 21;

// Object initialization can be simplified

// After
var c = new Customer() { Age = 21 };
```

```vb
' Before
Dim c = New Customer()
c.Age = 21

' Object initialization can be simplified

' After
Dim c = New Customer() With {.Age = 21}
```

#### Use collection initializers

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0028 | C# and Visual Basic | Visual Studio 2017 RTW |

This Quick Action lets you use [collection initializers](/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers.md) rather than multiple calls to the `Add` method of your class.

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

#### Convert auto property to full property

|  Applicable Languages |  Supported Version |
|  -------------------- | ----------------  |
| C# and Visual Basic | Visual Studio 2017 version 15.5 |

This Quick Action enables you to convert an auto property to a full property, and vice versa.

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

#### Convert block body to expression-bodied member

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0021-27 | C# 6.0+ | Visual Studio 2017 RTW |

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

#### Convert anonymous function to local function

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0039 | C# 7.0+ | Visual Studio 2017 version 15.5 |

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

#### Convert `ReferenceEquals` to `is null`

|  Diagnostic ID | Applicable Languages |  Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0041 | C# 7.0+ | Visual Studio 2017 version 15.5 |

This Quick Action suggests the use of [pattern matching](/dotnet/csharp/pattern-matching) rather than the ```ReferenceEquals``` coding-pattern, where possible.

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

#### Introduce pattern matching

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0020 | C# 7.0+ | Visual Studio 2017 RTW |
| IDE0019 | C# 7.0+ | Visual Studio 2017 RTW |

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

#### Change base for numeric literals

| Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| C# 7.0+ and Visual Basic 14+ | Visual Studio 2017 version 15.3 |

This Quick Action enables you to convert a numeric literal from one base numeric system to another. For example, you can change a number to hexadecimal or to binary format. 

```csharp
// Before
int countdown = 2097152;

// Convert to hex

// After
int countdown = 0x200000;
```

```vb
' Before
Dim countdown As Integer = 2097152

' Convert to hex

' After
Dim countdown As Integer = &H200000
```

#### Insert digit separators into literals

| Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| C# 7.0+ and Visual Basic 14+ | Visual Studio 2017 version 15.3 |

This Quick Action enables you to add separator characters into literal values.

```csharp
// Before
int countdown = 1000000;

// Separate thousands

// After
int countdown = 1_000_000;
```

```vb
' Before
Dim countdown As Integer = 1000000

' Separate thousands

' After
Dim countdown As Integer = 1_000_000
```

#### Use explicit tuple names

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0033 | C# 7.0+ and Visual Basic 15+ | Visual Studio 2017 RTW |

This Quick Action identifies areas where the explicit tuple name can be used rather than Item1, Item2, etc.

```csharp
// Before
(string name, int age) customer = GetCustomer();
var name = customer.Item1;

// Use explicit tuple name

// After
(string name, int age) customer = GetCustomer();
var name = customer.name;
```

```vb
' Before
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.Item1

' Use explicit tuple name

' After
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.name
```

#### Use inferred names

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0037 | C# | Visual Studio 2017 v. 15.5 |
| IDE0037 | C# 7.1+ | Visual Studio 2017 v. 15.5 |

These Quick Actions point out when users can use inferred member names in anonymous types or use C# 7.1's inferred tuple element names.

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

#### Deconstruct tuple declaration

| Diagnostic ID | Applicable Languages | Supported Version |
| ------- | -------------------- | ----------------  |
| IDE0042 | C# 7.0+ | Visual Studio 2017 v. 15.5 |

This Quick Action enables you to deconstruct tuple variable declarations. 

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

## See also

[Code Styles and Quick Actions](code-styles-and-quick-actions.md)  
[Writing and refactoring code (C++)](/cpp/ide/writing-and-refactoring-code-cpp)
