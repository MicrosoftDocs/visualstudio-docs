---
title: "Quick Actions | Microsoft Docs"
ms.custom: ""
ms.date: "05/08/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.devlang: csharp
ms.assetid: e173fb7d-c5bd-4568-ba0f-aa61913b3244
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
dev_langs: 
  - CSharp
  - VB
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Quick Actions

[Quick Actions](refactoring-code-generation-quick-actions.md#quick-actions) let you easily refactor, generate, or otherwise modify code with a single action.  While there are many Quick Actions that apply specifically to C# or Visual Basic, there are also some that apply to both C# and Visual Basic projects.  These can be applied using the Light Bulb icon ![Small Light Bulb Icon](media/vs2015_lightbulbsmall.png "VS2017_LightBulbSmall"), or pressing **Ctrl + .** when your cursor is on the appropriate line of code.

You will see a light bulb if there is a red squiggle and Visual Studio has a suggestion for how to fix the issue. For instance if you have an error indicated by a red squiggle, a light bulb will appear when fixes are available for that error. For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs will light up based on those rules.  

### To see a light bulb  

1. In many cases, light bulbs spontaneously appear when you hover the mouse at the point of an error, or in the left margin of the editor when you move the caret into a line that has an error in it. When you see a red squiggle, you can hover over it to display the light bulb. You can also cause a light bulb to display when you use the mouse or keyboard to go to anywhere in the line where the issue occurs.  

2. Press **Ctrl + .** anywhere on a line to invoke the light bulb and go directly to the list of potential fixes.  

   ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png "VS2017_LightBulb_Hover")  

### To see potential fixes  
Either click on the down arrow or the Show potential fixes link to display a list of quick actions that the light bulb can take for you.  

![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png "VS2017_LightBulb_hover_expanded")

## Common Quick Actions
Here are some of the common Quick Actions which are applicable to both C# and Visual Basic code.

### Add missing cases/default case/both
When creating a `switch` statement in C#, or `Select Case` statement in Visual Basic, you can use a Code Action to automatically add missing case items, a default case statement, or both.  For an empty statement like the following:

```CSharp
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

```VB
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

Using the **Add Both** Quick Action to fill in both missing cases and a default case will create the following:

```CSharp
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

```VB
Select Case myEnum
    Case MyEnum.Item1
        Exit Select
    Case MyEnum.Item2
        Exit Select
    Case Else
        Exit Select
End Select
```

### Correct misspelled type
If you accidentally misspell a type in Visual Studio, this Quick Action will automatically correct it for you.  You will see these items in the light bulb menu as **"Change '*misspelled type*' to '*correct type*'**.  For example:

```CSharp
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

```VB
' Before
Function MyFunction as Intger
End Function

' Change 'Intger' to 'Integer'

' After
Function MyFunction as Integer
End Function
```

### Remove unnecessary cast
If you cast a type to another type which doesn't require a cast, the **Remove Unnecessary Cast** Quick Action item will remove the cast from your code.

```CSharp
// before
int number = (int)3;

// Remove Unnecessary Cast

// after
int number = 3;
```

```VB
' Before
Dim number as Integer = CType(3, Integer)

' Remove Unnecessary Cast

' After
Dim number as Integer = 3
```

### Replace method with property / Replace property with method
These Quick Actions will convert a method to a property, or vice versa.  The example below shows the change from a method to a property.  For the opposite case, simply invert the *Before* and *After* sections.

```CSharp
private int MyValue;

// Before
public int GetMyValue()
{
    return MyValue;
}

// Replace 'GetMyValue' with property

// After
public int MyValue
{
    get { return MyValue; }
}
```

```VB
Dim MyValue As Integer

' Before
Function GetMyValue() As Integer
    Return MyValue
End Function

' Replace 'GetMyValue' with property

' After
ReadOnly Property MyValue As Integer
    Get
        Return MyValue
    End Get
End Property
```

### Make Method Synchronous
When using the `async`/`Async` keyword on a method, it is expected that somewhere inside that method the `await`/`Await` keyword will also be used.  However, if this isn't the case, a Quick Action will appear that will allow you to make the method synchronous by removing the `async`/`Async` keyword and changing the return type.  Use the **Make method synchronous** option from the Quick Actions menu.

```CSharp
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

```VB
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

### Make Method Asynchronous
When using the `await`/`Await` keyword inside of a method, it is expected that the method itself is marked with the `async`/`Async` keyword.  However, if this isn't the case, a Quick Action will appear that will allow you to make the method asynchronous.  Use the **Make method/Function asynchronous** option from the Quick Actions menu.

```CSharp
// Before
int MyAsyncMethod()
{
    return await Task.Run(...);
}

// Make method synchronous

// After
async Task<int> MyAsyncMethod()
{
    return await Task.Run(...);
}
```

```VB
' Before
Function MyAsyncMethod() as Integer
    Return  Await Task.Run(...)
End Function

' Make method synchronous

' After
Async Function MyAsyncMethod() As Task(Of Integer)
    Return Await Task.Run(...)
End Function
```

### Remove Unnecesary usings/Imports
The **Remove Unnecessary Usings/Imports** Quick Action will remove any unused `using` and `Import` statements for the current file.  When you select this item, unused namespace imports will be immediately removed.

### Add usings/Imports for types in reference assemblies, NuGet packages, or other types in your solution
Using types located in other projects in your solution will display the Quick Action automatically, however the others need to be enabled from the **Tools > Options > C#** or **Basic > Advanced** tab:  

* Suggest usings/imports for types in reference assemblies
* Suggest usings/imports for types in NuGet packages

When enabled, if you use a type in a namespace that is currently not imported, but exists in a reference assembly or NuGet package, the using/import statement will be created.

```CSharp
// Before
Debug.WriteLine("Hello");

// using System.Diagnostics;

// After
using System.Diagnostics;

Debug.WriteLine("Hello");
```

```VB
' Before
Debug.WriteLine("Hello")

' Imports System.Diagnostics

// After
Imports System.Diagnostics

Debug.WriteLine("Hello")
```

### Convert to Interpolated String
[Interpolated strings](/dotnet/csharp/language-reference/keywords/interpolated-strings) are an easy way to express strings with embedded variables, similar to the **[String.Format](https://msdn.microsoft.com/library/system.string.format.aspx)** method.  This Quick Action recognizes cases where strings are concatenated, or using **String.Format**, and changes the usage to an interpolated string.

```CSharp
// Before
int num = 3;
string s = string.Format("My string with {0} in the middle", num);

// Convert to interpolated string

// After
int num = 3;
string s = $"My string with {num} in the middle";
```

```VB
' Before
Dim num as Integer = 3
Dim s as String = String.Format("My string with {0} in the middle", num)

' Convert to interpolated string

' After
Dim num as Integer = 3
Dim s As String = $"My string with {num} in the middle"
```

### Remove merge conflict markers
These Quick Actions enable you to resolve merge conflicts by "taking a change", which removes the conflicting code and markers. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - resolve merge conflicts](../ide/media/vside-refactoring-merge-conflicts.png)

### Add null checks for parameters
This Quick Action enables you to add a check in your code to tell whether a parameter is null. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - add null check](../ide/media/vside-refactoring-nullcheck.png)

### Constructor generator improvements
When you're creating a constructor, this Quick Action enables you to select the properties or fields to generate, or you can generate the constructor from an empty body. You can also use it to add parameters to an existing constructor from the call-site. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - generate constructors](../ide/media/vside-refactoring-constructors.png)

### Remove unused variables
This Quick Action enables you to remove variables that have been declared but never used in your code. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - unused variables](../ide/media/vside-refactoring-unusedvars.png)

### Generate overrides
This Quick Action enables you to create an override from a blank line in a class or struct. The **Pick Members** dialog box lets you choose the members to override. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - overrides](../ide/media/vside-refactoring-overrides.png)

![Refactoring - overrides dialog box](../ide/media/vside-refactoring-overrides-dialog.png)

### Change base for numeric literals
This Quick Action enables you to convert a numeric literal from one base numeric system to another. For example, you can change a number to hexadecimal or to binary format. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - change base](../ide/media/vside-refactoring-changebase1.png)

![Refactoring - change base](../ide/media/vside-refactoring-changebase2.png)

### Insert digit separators into literals
This Quick Action enables you to add separator characters into literal values. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

![Refactoring - change digit separators](../ide/media/vside-refactoring-separators.png)

### Convert **if** construct to **switch**
This Quick Action enables you to convert an **if-then-else** construct to a **switch** construct. (Available only in Visual Studio 2017 (version 15.3 - Preview).)

```CSharp
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

```VB
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

# See Also
* [Code Styles and Quick Actions](code-styles-and-quick-actions.md)
