---
title: ".NET Code Style Settings For Editorconfig | Microsoft Docs"
uid: editorconfig-code-style-settings-reference.md
ms.custom: ""
ms.date: "12/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "editor"  
ms.assetid:
caps.latest.revision: 01
author: "kaseyu"
ms.author: "kaseyu"
manager: "davidcsa"
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

# .NET Code Style Settings For Editorconfig

## Possible values

`options_name = false|true : none|suggestion|warning|error`

For code style option you must specify **true** (prefer this option) or **false** (do not prefer this option) a colon (`:`) and a severity (`none`, `suggestion`, `warning`, or `error`). Severity means the level of enforcement for that style you want in your code base

Severity | effect
------------ | -------------
none | Do not show anything to the user when this style is not being followed, however code generation features will generate in this style 
suggestion | When this style is not being followed, show it to the user as a suggestion (underlying dots on the first two characters)
warning | When this style is not being followed, show a compiler warning 
error | When this style is not being followed, show a compiler error

## "This." and "Me." Qualification

### Prefer "this." and "Me." for field qualification
#### Option Name:
```
dotnet_style_qualification_for_field
```
#### Applicable Languages: C# and Visual Basic

#### Description: 

**true:** Prefer the all non-static fields used in non-static methods to be prefaced with `this` in C# or `Me` in Visual Basic.

C#:
```C#
this.capacity = 0;
```
Visual Basic:
```VB
Me.capacity = 0
```

**false:** Prefer all non-static fields used in non-static methods to not be prefaced with `this` in C#E of `Me` in Visual Basic.

C#:
```C#
capacity = 0;
```
Visual Basic:
```VB
capacity = 0
```
#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs,*.vb]
dotnet_style_qualification_for_field = false:suggestion
```

### Prefer "this." and "Me." for property qualification
#### Options Name
```
dotnet_style_qualification_for_property
```

#### Applicable Languages: C# and Visual Basic

#### Description: 

**true:** Prefer the all non-static properties used in non-static methods to be prefaced with `this` in C# or `Me` in Visual Basic.

C#:
```C#
this.ID = 0;
```
Visual Basic:
```VB
Me.ID = 0
```

**false:** Prefer all non-static properties used in non-static methods to *not* be prefaced with `this` in C# or `Me` in Visual Basic.

C#:
```C#
ID = 0
```
Visual Basic:
```VB
ID = 0
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs,*.vb]
dotnet_style_qualification_for_property = false:suggestion
```


### Prefer "this." and "Me." for method qualification
#### Option Name:
```
dotnet_style_qualification_for_method
```
#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer the all non-static methods called from within non-static methods to be prefaced with `this` in C# and `Me` in VB.

C#:
```C#
this.Display();
```
Visual Basic: 
```VB
Me.Display()
```

**false:** Prefer the all non-static methods called from within non-static methods to *not* be prefaced with `this`in C# and `Me` in VB.

C#:
```C#
Display();
```
Visual Basic: 
```VB
Display()
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_qualification_for_method = false:suggestion
```

### Prefer "this." and "Me." for event qualification
#### Option Name:
```
dotnet_style_qualification_for_event
```
#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer the all non-static events referenced from within non-static methods to be prefaced with `this` in C# and `Me` in VB.

C#:
```C#
this.Elapsed += Handler;
```
Visual Basic: 
```VB
AddHandler Me.Elapsed, AddressOf Handler
```

**false:**  Prefer the all non-static events referenced from within non-static methods to *not* be prefaced with `this`in C# and `Me` in VB.

C#:
```C#
Elapsed += Handler;
```
Visual Basic: 
```VB
AddHandler Elapsed, AddressOf Handler
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_qualification_for_event = false:suggestion
```

## Language keywords (int, string, etc. ) vs framework type names for type references
### Prefer language keywords instead of framework type names for locals, parameters, and members
#### Option Name:
```
dotnet_style_predefined_type_for_locals_parameters_members
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the keyword instead of the type name.

C#:
```C#
private int _member;
```
Visual Basic: 
```VB
Private _member As Integer
```

**false:** For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the type name instead of the keyword. 

C#:
```C#
private Int32 _member;
```
Visual Basic: 
```VB
Private _member As Int32
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_predefined_type_for_locals_parameters_members = true:suggestion
``` 

### Prefer language keywords instead of framework type names for member access expressions
#### Option Name:
```
dotnet_style_predefined_type_for_member_access
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer the keyword whenever a member access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`)

C#:
```C#
void M() { var local = int.MaxValue; }
```
Visual Basic: 
```VB
Sub M()
    Dim local = Integer.MaxValue
End Sub
```

**false:** Prefer the typename whenever a member access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`)

C#:
```C#
void M() { var local = Int32.MaxValue; }
```
Visual Basic: 
```VB
Sub M()
    Dim local = Int32.MaxValue
End Sub
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_predefined_type_for_member_access = true:suggestion
``` 

## Expression-level Preferences
### Prefer object initializers
#### Option Name:
```
dotnet_style_object_initializer
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer objects to be initialized using object initializers when possible.

C#:
```C#
var c = new Customer(){ Age = 21 };
```
Visual Basic: 
```VB
Dim c = New Customer() With {
    .Age = 21
}
```

**false:** Prefer objects to *not* be initialized using object initializers.

C#:
```C#
var c = new Customer(); c.Age = 21;
```
Visual Basic: 
```VB
Dim c = new Customer()
c.Age = 21
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_object_initializer = true:suggestion
``` 

### Prefer collection initializers
#### Option Name:
```
dotnet_style_collection_initializer
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer collections to be initialized using collection initializers when possible.

C#:
```C#
var list = new List<int>{ 1, 2, 3 };
```
Visual Basic: 
```VB
Dim list = new List(Of Integer) From {
    1,
    2,
    3
}
```

**false:** Prefer objects to *not* be initialized using collection initializers.

C#:
```C#
var list = new List<int>(); 
list.Add(1);
list.Add(2);
list.Add(3);
```
Visual Basic: 
```VB
Dim list = new List(Of Integer)
list.Add(1)
list.Add(2)
list.Add(3)
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_collection_initializer = true:suggestion
```

### Prefer explicit tuple names
#### Option Name:
```
dotnet_style_explicit_tuple_names
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer tuple names to ItemX properties.

C#:
```C#
(string name, int age) customer = GetCustomer(); var name = customer.name;
```
Visual Basic: 
```VB
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.name;
```

**false:** Prefer ItemX properties to tuple names.
C#:
```C#
(string name, int age) customer = GetCustomer(); var name = customer.Item1;
```
Visual Basic: 
```VB
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.Item1
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_explicit_tuple_names = true:suggestion
``` 

### Prefer coalescing expressions in "null" checking
#### Option Name:
```
dotnet_style_coalesce_expression
```

#### Applicable Languages: C# and Visual Basic

#### Description:
**true:** Prefer null coalescing expression to ternary operator checking.

C#:
```C#
var v = x ?? y
```
Visual Basic: 
```VB
Dim v = If(x, y)
```

**false:** Prefer ternary operator checking to null coalescing expression.

C#:
```C#
var v = x != null ? x : y; // or
var v = x == null ? y : x;
```
Visual Basic: 
```VB
Dim v = If(x Is Nothing, y, x) ' or
Dim v = IF(x IsNot Nothing, x, y)
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_coalesce_expression = true:suggestion
``` 

### Prefer null propagation in "null" checking
#### Option Name:
```
dotnet_style_null_propagation
```

#### Applicable Languages: C# and Visual Basic

#### Description: 
**true:** Prefer to use null-conditional operator where possible.

C#:
```C#
var v = o?.ToString();
```
Visual Basic: 
```VB
Dim v = o?.ToString()
```

**false:** Prefer to use ternary null checking where possible.

C#:
```C#
var v = o == null ? null : o.ToString(); // or
var v = o != null ? o.String() : null;
```
Visual Basic: 
```VB
Dim v = If(o Is Nothing, Nothing, o.ToString()) ' or
Dim v = If(o IsNot Nothing, o.ToString(), Nothing)
```

#### Example:
```editorconfig
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_null_propagation = true:suggestion
``` 

# CSharp Code Style Settings
## Prefer "var"
### Prefer "var" for built-in types
#### Option Name:
```
csharp_style_var_for_built_in_types
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer `var` is used for built-in system types such as `int` 

C#:
```C#
var x = 5;
```

**false:** Prefer `var` not be used for built-in system types such as `int`

C#:
```C#
int x = 5;
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_var_for_built_in_types = true:suggestion
``` 

### Prefer "var" when type is apparent
#### Option Name:
```
csharp_style_var_when_type_is_apparent
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer `var` when the type is already mentioned on the left hand side of a declaration expression.

C#:
```C#
var obj = new C();
```

**false:** Prefer to not use `var` when the type is already mentioned on the left hand side of a declaration expression.

C#:
```C#
C obj = new C();
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_var_when_type_is_apparent = true:suggestion
``` 

### Prefer "var" elsewhere
#### Option Name:
```
csharp_style_var_elsewhere
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer `var` in all cases unless overridden by another code style rule.

C#:
```C#
var f = this.Init();
```

**false:** Prefer to not use var in all cases unless overridden by another code style rule.

C#:
```C#
bool f = this.Init();
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_var_elsewhere = true:suggestion
``` 

## Code Block Preferences
### Prefer expression-bodied members for methods
#### Option Name:
```
csharp_style_expression_bodied_methods
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for methods.
C#:
```C#
public int GetAge() => this.Age;
```

**false:** Do not prefer expression bodied members for methods.

C#:
```C#
public int GetAge() { return this.Age; }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_methods = false:none
``` 

### Prefer expression-bodied members for constructors
#### Option Name:
```
csharp_style_expression_bodied_constructors
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for constructors.
C#:
```C#
public Customer(int age) => Age = age;
```

**false:** Do not prefer expression bodied members for constructors.

C#:
```C#
public Customer(int age) { Age = age; }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_constructors = false:none
``` 

### Prefer expression-bodied members for operators
#### Option Name:
```
csharp_style_expression_bodied_operators
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for operators.
C#:
```C#
public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
```

**false:** Do not prefer expression bodied members for operators.

C#:
```C#
public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2) { return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary); }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_operators = false:none
``` 

### Prefer expression-bodied members for properties
#### Option Name:
```
csharp_style_expression_bodied_properties
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for properties.
C#:
```C#
public int Age => _age;
```

**false:** Do not prefer expression bodied members for properties.

C#:
```C#
public int Age { get { return _age; } }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_properties = false:none
``` 

### Prefer expression-bodied members for indexers
#### Option Name:
```
csharp_style_expression_bodied_indexers
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for indexers.
C#:
```C#
public T this[int i] => _value[i];
```

**false:** Do not prefer expression bodied members for indexers.

C#:
```C#
public T this[int i] { get { return _values[i]; } }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_indexers = false:none
``` 

### Prefer expression-bodied members for accessors
#### Option Name:
```
csharp_style_expression_bodied_accessors
```

#### Applicable Languages: C#

#### Description:
**true:** Prefer expression-bodied members for accessors.
C#:
```C#
public int Age { get => _age; set => _age = value; }
```

**false:** Do not prefer expression bodied members for accessors.

C#:
```C#
public int Age { get { return _age; } set { _age = value; } }
```

#### Example:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_accessors = false:none
``` 

## Expression preferences
### Prefer pattern matching over "is" with "cast" checking
#### Option Name:
```
csharp_style_pattern_matching_over_is_with_cast_check
```
#### Applicable Languages: C#

#### Description: 

**true:** Prefer pattern matching instead of `is` expressions with type casts.
```C#
if (o is int i) { ... }
```

**false:** Prefer `is` expressions with type casts instead of pattern matching.
```C#
if (o is int) { var i = (int)o; ... }
```

#### Example editorconfig file:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_pattern_matching_over_is_with_cast_check = true:suggestion
```

### Prefer pattern matching over "as" with "null" checking

#### Option Name:
```
csharp_style_pattern_matching_over_as_with_null_check
```
#### Applicable Languages: C#

#### Description: 

**true:** Prefer pattern matching instead of `as` expressions with null checks to determine if something is of a particular type.
```C#
if (o is string s) { ... }
```
**false:** Prefer `as` expressions with null checks instead of pattern matching to determine if something is of a particular type.
```C#
var s = o as string; if (s != null) { ... }
```

#### Example editorconfig file:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_pattern_matching_over_as_with_null_check = true:suggestion
```

## Variable Preferences
### Prefer inlined variable declarations
#### Option Name:
```
csharp_style_inlined_variable_declaration
```
#### Applicable Languages: C#

#### Description: 

**true:** Prefer `out` variables to be declared inline when possible. 
```C#
if (int.TryParse(value out int i) { ... }
```

**false:** Prefer `out` variables to be declared explicitly.
```C#
int i; if (int.TryParse(value, out i) { ... }
```

#### Example editorconfig file:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_inlined_variable_declaration = true:suggestion
```

## "Null" Checking Preferences
### Prefer throw-expressions
#### Option Name:
```
csharp_style_throw_expression
```
#### Applicable Languages: C#

#### Description: 

**true:** Prefer to use throw expressions instead of throw statements.

```C#
this.s = ss ?? throw new ArguementNullException(nameof(s));
```

**false:** Prefer to use throw statements instead of throw expressions.

```C#
if (s==null) { throw new ArgumentNullException(nameof(s));} this.s = s;
```

#### Example editorconfig file:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_throw_expression = true:suggestion
```

### Prefer conditional delegate calls
#### Option Name:
```
csharp_style_conditional_delegate_call
```
#### Applicable Languages: C#

#### Description:

**true:** Prefer to use conditional coalescing operation (`?.`) when invoking a lambda instead of performing a null check.

```C#
func?.Invoke(args);
```

**false:"** Prefer to preform a null check before invoking a lambda instead of using the conditional coalescing operator (`?.`).

```C#
if (func!=null) { func(args); }
```

#### Example editorconfig file:
```editorconfig
# CSharp code style settings:
[*.cs]
csharp_style_conditional_delegate_call = false:suggestion
```