---
title: ".NET Code Style Settings For Editorconfig | Microsoft Docs"
ms.custom: ""
ms.date: "12/14/2016"
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

For code style option you must specify **true** (prefer this option) or **false** (do not prefer this option), a colon (`:`), and a severity (`none`, `suggestion`, `warning`, or `error`). Severity means the level of enforcement for that style you want in your code base.

Severity | effect
------------ | -------------
none | Do not show anything to the user when this style is not being followed, however code generation features will generate in this style. 
suggestion | When this style is not being followed, show it to the user as a suggestion (underlying dots on the first two characters).
warning | When this style is not being followed, show a compiler warning.
error | When this style is not being followed, show a compiler error.

## .NET Code Style Options

- [Dotnet Code Style Settings](#this_and_me)
    - ["This." and "Me." Qualification](#this_and_me)
        - [Fields](#this_and_me_fields)
        - [Properties](#this_and_me_properties)
        - [Methods](#this_and_me_methods)
        - [Events](#this_and_me_events)
    - [Language keywords (int, string, etc. ) vs framework type names for type references](#language_keywords)
        - [Locals, parameters, and members](#language_keywords_variables)
        - [Member access expressions](#language_keywords_member_access)
    - [Expression-level Preferences](#expression_level)
        - [Object initializers](#expression_level_object_initializers)
        - [Collection initializers](#expression_level_collection_initializers)
        - [Explicit tuple names](#expression_level_tuple_names)
        - [Coalescing expressions in "null" checking](#expression_level_null_checking)
        - [Null propagation in "null" checking](#expression_level_null_propogation)
- [CSharp Code Style Settings](#csharp_codestyle)
    - ["var"](#var)
        - ["var" for built-in types](#var_built_in)
        - ["var" when type is apparent](#var_apparent)
        - ["var" elsewhere](#var_elsewhere)
    - [Expression-bodied members](#expression_bodied_members)
        - [Methods](#expression_bodied_members_methods)
        - [Constructors](#expression_bodied_members_constructors)
        - [Operators](#expression_bodied_members_operators)
        - [Properties](#expression_bodied_members_properties)
        - [Indexers](#expression_bodied_members_indexers)
        - [Accessors](#expression_bodied_members_accessors)
    - [Pattern matching](#pattern_matching)
        - ["is" with "cast" checking](#pattern_matching_is_cast)
        - ["as" with "null" checking](#pattern_matching_as_null)
    - [Inlined variable declarations](#inlined_variable_declarations)
    - ["Null" Checking Preferences](#null_checking)
        - [Throw-expressions](#null_checking_throw_expressions)
        - [Conditional delegate calls](#null_checking_conditional_delegate_calls)

## <a name="this_and_me">"This." and "Me." Qualification</a>

### <a name="this_and_me_fields">Fields</a>

|  Option Name | `dotnet_style_qualification_for_field` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static fields used in non-static methods to be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`this.capacity = 0;` <br><br> **Visual Basic:** `Me.capacity = 0`
| False | Prefer all non-static fields used in non-static methods to not be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`capacity = 0;` <br><br> **Visual Basic:** `capacity = 0`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs,*.vb]
dotnet_style_qualification_for_field = false:suggestion
```

### <a name="this_and_me_properties">Properties</a>

|  Option Name | `dotnet_style_qualification_for_property` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer the all non-static properties used in non-static methods to be prefaced with `this.` in C# or `Me.` in Visual Basic.| **C#:** <br>`this.ID = 0;` <br><br> **Visual Basic:** `Me.ID = 0`
| False | Prefer all non-static properties used in non-static methods to *not* be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`ID = 0;` <br><br> **Visual Basic:** `ID = 0`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs,*.vb]
dotnet_style_qualification_for_property = false:suggestion
```


### <a name="this_and_me_methods">Methods</a>
|  Option Name | `dotnet_style_qualification_for_method` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static methods called from within non-static methods to be prefaced with `this.` in C# and `Me.` in VB.| **C#:** <br>`this.Display();` <br><br> **Visual Basic:** `Me.Display()`
| False | Prefer all non-static methods called from within non-static methods to *not* be prefaced with `this.`in C# and `Me.` in VB. | **C#:** <br>`Display();` <br><br> **Visual Basic:** `Display()`


#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_qualification_for_method = false:suggestion
```

### <a name="this_and_me_events">Events</a>
|  Option Name | `dotnet_style_qualification_for_event` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static events referenced from within non-static methods to be prefaced with `this.` in C# and `Me.` in VB.| **C#:** <br>`this.Elapsed += Handler;` <br><br> **Visual Basic:** `AddHandler Me.Elapsed, AddressOf Handler`
| False | Prefer all non-static events referenced from within non-static methods to *not* be prefaced with `this.`in C# and `Me.` in VB. | **C#:** <br>`Elapsed += Handler;` <br><br> **Visual Basic:** `AddHandler Elapsed, AddressOf Handler`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_qualification_for_event = false:suggestion
```

## <a name="language_keywords">Language keywords (int, string, etc. ) vs framework type names for type references </a>
### <a name="language_keywords_variables">Locals, parameters, and members</a>
|  Option Name | `dotnet_style_predefined_type_for_locals_parameters_members` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the keyword instead of the type name (`Int32`, `Int64`, etc.).| **C#:** <br>`private int _member;` <br><br> **Visual Basic:** `Private _member As Integer`
| False | For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the type name (`Int32`, `Int64`, etc.) instead of the keyword.  | **C#:** <br>`private Int32 _member;` <br><br> **Visual Basic:** `Private _member As Int32`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_predefined_type_for_locals_parameters_members = true:suggestion
``` 

### <a name="language_keywords_member_access">Member access expressions</a>
|  Option Name | `dotnet_style_predefined_type_for_member_access` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer the keyword whenever a member-access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`).| **C#:** <br>`var local = int.MaxValue;` <br><br> **Visual Basic:** `Dim local = Integer.MaxValue`
| False | Prefer the type name whenever a member access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`). | **C#:** <br>`var local = Int32.MaxValue;` <br><br> **Visual Basic:** `Dim local = Int32.MaxValue`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_predefined_type_for_member_access = true:suggestion
``` 

## <a name="expression_level">Expression-level Preferences</a>
### <a name="expression_level_object_initializers">Object initializers</a>
|  Option Name | `dotnet_style_object_initializer` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer objects to be initialized using object initializers when possible.| **C#:** <br>`var c = new Customer(){ Age = 21 };` <br><br> **Visual Basic:** `Dim c = New Customer() With { .Age = 21 }`
| False | Prefer objects to *not* be initialized using object initializers. | **C#:** <br>`var c = new Customer();`<br>`c.Age = 21;` <br><br> **Visual Basic:** <br>`Dim c = new Customer() `<br>`c.Age = 21`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_object_initializer = true:suggestion
``` 

### <a name="expression_level_collection_initializers">Collection initializers</a>
|  Option Name | `dotnet_style_collection_initializer` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer collections to be initialized using collection initializers when possible.| **C#:** <br>`var list = new List<int>{ 1, 2, 3 };` <br><br> **Visual Basic:** <br> `Dim list = new List(Of Integer) From { 1, 2, 3}`
| False | Prefer objects to *not* be initialized using collection initializers. | **C#:** <br>`var list = new List<int>();`<br>`list.Add(1);`<br>`list.Add(2);`<br>`list.Add(3);` <br><br> **Visual Basic:** <br>`Dim list = new List(Of Integer)`<br>`list.Add(1)`<br>`list.Add(2)`<br>`list.Add(3)`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_collection_initializer = true:suggestion
```

### <a name="expression_level_tuple_names">Explicit tuple names</a>
|  Option Name | `dotnet_style_explicit_tuple_names` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer tuple names to ItemX properties.| **C#:** <br>`(string name, int age) customer = GetCustomer();`<br>`var name = customer.name;` <br><br> **Visual Basic:** <br> `Dim customer As (name As String, age As Integer) = GetCustomer()`<br>`Dim name = customer.name`
| False | Prefer ItemX properties to tuple names. | **C#:** <br>`(string name, int age) customer = GetCustomer();`<br>`var name = customer.Item1;` <br><br> **Visual Basic:** <br>`Dim customer As (name As String, age As Integer) = GetCustomer()`<br> `Dim name = customer.Item1`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_explicit_tuple_names = true:suggestion
``` 

### <a name="expression_level_null_checking">Coalescing expressions in "null" checking</a>
|  Option Name | `dotnet_style_coalesce_expression` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer null coalescing expression to ternary operator checking.| **C#:** <br>`var v = x ?? y;` <br><br> **Visual Basic:** <br> `Dim v = If(x, y)`
| False | Prefer ternary operator checking to null coalescing expression. | **C#:** <br>`var v = x != null ? x : y; // or`<br>`var v = x == null ? y : x;` <br><br> **Visual Basic:** <br>`Dim v = If(x Is Nothing, y, x) ' or`<br> `Dim v = If(x IsNot Nothing, x, y)`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_coalesce_expression = true:suggestion
``` 

### <a name="expression_level_null_propogation">Null propagation in "null" checking</a>
|  Option Name | `dotnet_style_null_propagation` |
| ------------- |:-------------:|
| **Applicable Languages** | C# and Visual Basic

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use null-conditional operator where possible.| **C#:** <br>`var v = o?.ToString();` <br><br> **Visual Basic:** <br> `Dim v = o?.ToString()`
| False | Prefer to use ternary null checking where possible. | **C#:** <br>`var v = o == null ? null : o.ToString(); // or`<br>`var v = o != null ? o.String() : null;` <br><br> **Visual Basic:** <br>`Dim v = If(o Is Nothing, Nothing, o.ToString()) ' or`<br> `Dim v = If(o IsNot Nothing, o.ToString(), Nothing)`

#### Example editorconfig file:
```
# CSharp and VisualBasic code style settings:
[*.cs, *.vb]
dotnet_style_null_propagation = true:suggestion
``` 

# <a name="csharp_codestyle">CSharp Code Style Settings</a>
## <a name="var">"var"</a>
### <a name="var_built_in">"var" for built-in types</a>
|  Option Name | `csharp_style_var_for_built_in_types` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `var` is used for built-in system types such as `int`.| **C#:** <br>`var x = 5;`
| False | Prefer `var` not be used for built-in system types such as `int`. | **C#:** <br>`int x = 5;`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_var_for_built_in_types = true:suggestion
``` 

### <a name="var_apparent">"var" when type is apparent</a>
|  Option Name | `csharp_style_var_when_type_is_apparent` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `var` when the type is already mentioned on the right-hand side of a declaration expression.| **C#:** <br>`var obj = new C();`
| False | Prefer to not use `var` when the type is already mentioned on the right-hand side of a declaration expression. | **C#:** <br>`C obj = new C();`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_var_when_type_is_apparent = true:suggestion
``` 

### <a name="var_elsewhere">"var" elsewhere</a>
|  Option Name | `csharp_style_var_elsewhere` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `var` in all cases unless overridden by another code style rule.| **C#:** <br>`var f = this.Init();`
| False | Prefer to not use var in all cases unless overridden by another code style rule.| **C#:** <br>`bool f = this.Init();`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_var_elsewhere = true:suggestion
``` 

### <a name="expression_bodied_members">Methods</a>
|  Option Name | `csharp_style_expression_bodied_methods` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for methods.| **C#:** <br>`public int GetAge() => this.Age;`
| False | Do not prefer expression-bodied members for methods.| **C#:** <br>`public int GetAge() { return this.Age; }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_methods = false:none
``` 

### <a name="expression_bodied_members_constructors">Constructors</a>
|  Option Name | `csharp_style_expression_bodied_constructors` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for constructors.| **C#:** <br>`public Customer(int age) => Age = age;`
| False | Do not prefer expression-bodied members for constructors.| **C#:** <br>`public Customer(int age) { Age = age; }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_constructors = false:none
``` 

### <a name="expression_bodied_members_operators">Operators</a>
|  Option Name | `csharp_style_expression_bodied_operators` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for operators.| **C#:** <br>`public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)`<br>`=> new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);`
| False | Do not prefer expression-bodied members for operators.| **C#:** <br>`public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)`<br>`{ return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary); }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_operators = false:none
``` 

### <a name="expression_bodied_members_properties">Properties</a>
|  Option Name | `csharp_style_expression_bodied_properties` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for properties.| **C#:** <br>`public int Age => _age;`
| False | Do not prefer expression-bodied members for properties.| **C#:** <br>`public int Age { get { return _age; }}`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_properties = false:none
``` 

### <a name="expression_bodied_members_indexers">Indexers</a>
|  Option Name | `csharp_style_expression_bodied_indexers` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for indexers.| **C#:** <br>`public T this[int i] => _value[i];`
| False | Do not prefer expression-bodied members for indexers.| **C#:** <br>`public T this[int i] { get { return _values[i]; } }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_indexers = false:none
``` 

### <a name="expression_bodied_members_accessors">Accessors</a>
|  Option Name | `csharp_style_expression_bodied_accessors` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for accessors.| **C#:** <br>`public int Age { get => _age; set => _age = value; }`
| False | Do not prefer expression-bodied members for accessors.| **C#:** <br>`public int Age { get { return _age; } set { _age = value; } }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_accessors = false:none
``` 

## <a name="pattern_matching">Pattern matching</a>
### <a name="pattern_matching_is_cast">"is" with "cast" checking</a>
|  Option Name | `csharp_style_pattern_matching_over_is_with_cast_check` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer pattern matching instead of `is` expressions with type casts.| **C#:** <br>`if (o is int i) {...}`
| False | Prefer `is` expressions with type casts instead of pattern matching.| **C#:** <br>`if (o is int) {var i = (int)o; ... }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_pattern_matching_over_is_with_cast_check = true:suggestion
```

### <a name="pattern_matching_as_null">"as" with "null" checking</a>
|  Option Name | `csharp_style_pattern_matching_over_as_with_null_check` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer pattern matching instead of `as` expressions with null checks to determine if something is of a particular type.| **C#:** <br>`if (o is string s) {...}`
| False | Prefer `as` expressions with null checks instead of pattern matching to determine if something is of a particular type.| **C#:** <br>`var s = o as string; if (s != null) {...}`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_pattern_matching_over_as_with_null_check = true:suggestion
```

### <a name="inlined_variable_declarations">Inlined variable declarations</a>
|  Option Name | `csharp_style_inlined_variable_declaration` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `out` variables to be declared inline when possible. | **C#:** <br>`if (int.TryParse(value out int i) {...}`
| False | Prefer `out` variables to be declared explicitly.| **C#:** <br>`int i; if (int.TryParse(value, out i) {...}`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_inlined_variable_declaration = true:suggestion
```

## <a name="null_checking">"Null" Checking Preferences</a>
### <a name="null_checking_throw_expressions">Throw-expressions</a>
|  Option Name | `csharp_style_throw_expression` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use throw expressions instead of throw statements. | **C#:** <br>`this.s = ss ?? throw new ArgumentNullException(nameof(s));`
| False | Prefer to use throw statements instead of throw expressions.| **C#:** <br>`if (s==null) {throw new ArgumentNullException(nameof(s));} this.s = s;`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_throw_expression = true:suggestion
```

### <a name="null_checking_conditional_delegate_calls">Prefer conditional delegate calls</a>
|  Option Name | `csharp_style_conditional_delegate_call` |
| ------------- |:-------------:|
| **Applicable Languages** | C#

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use conditional coalescing operation (`?.`) when invoking a lambda instead of performing a null check. | **C#:** <br>`func?.Invoke(args);`
| False | Prefer to preform a null check before invoking a lambda instead of using the conditional coalescing operator (`?.`).| **C#:** <br>`if (func!=null) { func(args); }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_conditional_delegate_call = false:suggestion
```
