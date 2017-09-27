---
title: ".NET Coding Convention Settings For EditorConfig | Microsoft Docs"
ms.custom: ""
ms.date: "08/16/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
helpviewer_keywords: 
  - "editor"
ms.assetid: 
caps.latest.revision: 01
author: "kuhlenh"
ms.author: "kaseyu"
manager: "ghogen"
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
ms.technology: 
  - "vs-ide-general"
---

# .NET Coding Convention Settings For EditorConfig
.NET coding conventions are configured using an [EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options) file. EditorConfig files allow you to **enable/disable individual .NET coding conventions** and **configure the degree at which you want the convention enforced** (via a severity level). To learn more about how to use EditorConfig to enforce consistency on your codebase, read [this article](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options).

There are three supported .NET coding convention categories:
- **[Language Conventions](#language)** are rules pertaining to the C# or Visual Basic language, for example, `var`/explicit type, use expression-bodied member.
- **[Formatting Rules](#formatting)** are rules regarding the layout and structure of your code in order to make it easier to read, for example, Allman braces, spaces in control blocks.
- **[Naming Conventions](#naming)** are rules respecting the way objects are named, for example, `async` methods must end in "Async". 

# <a name="language"> Language Conventions </a>
## Overview
**Rule Format:**
`options_name = false|true : none|suggestion|warning|error`

For code style option, you must specify **true** (prefer this option) or **false** (do not prefer this option), a colon (`:`), and a severity (`none`, `silent`, `suggestion`, `warning`, or `error`). Severity means the level of enforcement for that style you want in your code base.

`none` and `silent` are synonymous and mean that no indication of any kind should be shown to the user. This has the effect of disabling this rule.

Severity | effect
------------ | -------------
none/silent | Do not show anything to the user when this style is not being followed, however code generation features generate in this style. 
suggestion | When this style is not being followed, show it to the user as a suggestion (underlying dots on the first two characters).
warning | When this style is not being followed, show a compiler warning.
error | When this style is not being followed, show a compiler error.

## .NET Language Convention Options

- **[.NET Code Style Settings](#this_and_me)**
    - ["This." and "Me." Qualification](#this_and_me)
        - [Fields](#this_and_me_fields)
        - [Properties](#this_and_me_properties)
        - [Methods](#this_and_me_methods)
        - [Events](#this_and_me_events)
    - [Language keywords (int, string, etc.) vs framework type names for type references](#language_keywords)
        - [Locals, parameters, and members](#language_keywords_variables)
        - [Member access expressions](#language_keywords_member_access)
    - [Expression-level Preferences](#expression_level)
        - [Object initializers](#expression_level_object_initializers)
        - [Collection initializers](#expression_level_collection_initializers)
        - [Explicit tuple names](#expression_level_tuple_names)
        - [Coalescing expressions in "null" checking](#expression_level_null_checking)
        - [Null propagation in "null" checking](#expression_level_null_propogation)
- **[CSharp Code Style Settings](#csharp_codestyle)**
    - ["var"](#var)
        - ["var" for built-in types](#var_built_in)
        - ["var" when type is apparent](#var_apparent)
        - ["var" elsewhere](#var_elsewhere)
    - [Expression-bodied members](#expression_body)
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
    - [Expression-level Preferences](#expression_level_csharp)
        -[Simplify `default` expressions](#expression_level_default)
    - ["Null" Checking Preferences](#null_checking)
        - [Throw-expressions](#null_checking_throw_expressions)
        - [Conditional delegate calls](#null_checking_conditional_delegate_calls)
    - [Code Block Preferences](#code_block)
        - [Prefer braces](#prefer_braces)

## <a name="this_and_me">"This." and "Me." Qualification</a>
### <a name="this_and_me_fields">Fields (IDE0003/IDE0009)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|  `dotnet_style_qualification_for_field` | C# and Visual Basic | false:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static fields used in non-static methods to be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`this.capacity = 0;` <br><br> **Visual Basic:** <br> `Me.capacity = 0`
| False | Prefer all non-static fields used in non-static methods to not be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`capacity = 0;` <br><br> **Visual Basic:** <br>`capacity = 0`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_qualification_for_field = false:suggestion
```

### <a name="this_and_me_properties">Properties (IDE0003/IDE0009) </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_qualification_for_property`| C# and Visual Basic | false:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer the all non-static properties used in non-static methods to be prefaced with `this.` in C# or `Me.` in Visual Basic.| **C#:** <br>`this.ID = 0;` <br><br> **Visual Basic:** <br>`Me.ID = 0`
| False | Prefer all non-static properties used in non-static methods to *not* be prefaced with `this.` in C# or `Me.` in Visual Basic. | **C#:** <br>`ID = 0;` <br><br> **Visual Basic:** <br> `ID = 0`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_qualification_for_property = false:suggestion
```

### <a name="this_and_me_methods">Methods (IDE0003/IDE0009) </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_qualification_for_method`| C# and Visual Basic | false:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static methods called from within non-static methods to be prefaced with `this.` in C# and `Me.` in VB.| **C#:** <br>`this.Display();` <br><br> **Visual Basic:** <br> `Me.Display()`
| False | Prefer all non-static methods called from within non-static methods to *not* be prefaced with `this.`in C# and `Me.` in VB. | **C#:** <br>`Display();` <br><br> **Visual Basic:** <br> `Display()`


#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_qualification_for_method = false:suggestion
```

### <a name="this_and_me_events">Events (IDE0003/IDE0009) </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_qualification_for_event`| C# and Visual Basic | false:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer all non-static events referenced from within non-static methods to be prefaced with `this.` in C# and `Me.` in VB.| **C#:** <br>`this.Elapsed += Handler;` <br><br> **Visual Basic:** <br> `AddHandler Me.Elapsed, AddressOf Handler`
| False | Prefer all non-static events referenced from within non-static methods to *not* be prefaced with `this.`in C# and `Me.` in VB. | **C#:** <br>`Elapsed += Handler;` <br><br> **Visual Basic:** <br>`AddHandler Elapsed, AddressOf Handler`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_qualification_for_event = false:suggestion
```

## <a name="language_keywords">Language keywords (int, string, etc.) vs framework type names for type references </a>
### <a name="language_keywords_variables"> Locals, parameters, and members (IDE0012/IDE0014)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_predefined_type_for_locals_parameters_members`| C# and Visual Basic | true:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the keyword instead of the type name (`Int32`, `Int64`, etc.).| **C#:** <br>`private int _member;` <br><br> **Visual Basic:** `Private _member As Integer`
| False | For locals, parameters and type members, prefer types that have a language keyword to represent them (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`) to use the type name (`Int32`, `Int64`, etc.) instead of the keyword.  | **C#:** <br>`private Int32 _member;` <br><br> **Visual Basic:** <br> `Private _member As Int32`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_predefined_type_for_locals_parameters_members = true:suggestion
``` 

### <a name="language_keywords_member_access">Member access expressions (IDE0013/IDE0015)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_predefined_type_for_member_access`| C# and Visual Basic | true:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer the keyword whenever a member-access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`).| **C#:** <br>`var local = int.MaxValue;` <br><br> **Visual Basic:** <br> `Dim local = Integer.MaxValue`
| False | Prefer the type name whenever a member access expression is used on a type with a keyword representation (`int`, `double`, `float`, `short`, `long`, `decimal`, `string`). | **C#:** <br>`var local = Int32.MaxValue;` <br><br> **Visual Basic:** <br> `Dim local = Int32.MaxValue`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_predefined_type_for_member_access = true:suggestion
``` 

## <a name="expression_level">Expression-level Preferences</a>
### <a name="expression_level_object_initializers">Object initializers (IDE0017)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_object_initializer`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer objects to be initialized using object initializers when possible.| **C#:** <br>`var c = new Customer(){ Age = 21 };` <br><br> **Visual Basic:** <br> `Dim c = New Customer() With { .Age = 21 }`
| False | Prefer objects to *not* be initialized using object initializers. | **C#:** <br>`var c = new Customer();`<br>`c.Age = 21;` <br><br> **Visual Basic:** <br>`Dim c = new Customer() `<br>`c.Age = 21`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_object_initializer = true:suggestion
``` 

### <a name="expression_level_collection_initializers">Collection initializers (IDE0028)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_collection_initializer`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer collections to be initialized using collection initializers when possible.| **C#:** <br>`var list = new List<int>{ 1, 2, 3 };` <br><br> **Visual Basic:** <br> `Dim list = new List(Of Integer) From { 1, 2, 3}`
| False | Prefer objects to *not* be initialized using collection initializers. | **C#:** <br>`var list = new List<int>();`<br>`list.Add(1);`<br>`list.Add(2);`<br>`list.Add(3);` <br><br> **Visual Basic:** <br>`Dim list = new List(Of Integer)`<br>`list.Add(1)`<br>`list.Add(2)`<br>`list.Add(3)`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_collection_initializer = true:suggestion
```

### <a name="expression_level_tuple_names">Explicit tuple names (IDE0033)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_explicit_tuple_names`| C# 7.0+ and Visual Basic 15+ | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer tuple names to ItemX properties.| **C#:** <br>`(string name, int age) customer = GetCustomer();`<br>`var name = customer.name;` <br><br> **Visual Basic:** <br> `Dim customer As (name As String, age As Integer) = GetCustomer()`<br>`Dim name = customer.name`
| False | Prefer ItemX properties to tuple names. | **C#:** <br>`(string name, int age) customer = GetCustomer();`<br>`var name = customer.Item1;` <br><br> **Visual Basic:** <br>`Dim customer As (name As String, age As Integer) = GetCustomer()`<br> `Dim name = customer.Item1`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_explicit_tuple_names = true:suggestion
``` 

### <a name="expression_level_null_checking">Coalescing expressions in "null" checking (IDE0029)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_coalesce_expression`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer null coalescing expression to ternary operator checking.| **C#:** <br>`var v = x ?? y;` <br><br> **Visual Basic:** <br> `Dim v = If(x, y)`
| False | Prefer ternary operator checking to null coalescing expression. | **C#:** <br>`var v = x != null ? x : y; // or`<br>`var v = x == null ? y : x;` <br><br> **Visual Basic:** <br>`Dim v = If(x Is Nothing, y, x) ' or`<br> `Dim v = If(x IsNot Nothing, x, y)`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_coalesce_expression = true:suggestion
``` 

### <a name="expression_level_null_propogation">Null propagation in "null" checking (IDE0031)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_null_propagation`| C# 6.0+ and Visual Basic 14+ | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use null-conditional operator where possible.| **C#:** <br>`var v = o?.ToString();` <br><br> **Visual Basic:** <br> `Dim v = o?.ToString()`
| False | Prefer to use ternary null checking where possible. | **C#:** <br>`var v = o == null ? null : o.ToString(); // or`<br>`var v = o != null ? o.String() : null;` <br><br> **Visual Basic:** <br>`Dim v = If(o Is Nothing, Nothing, o.ToString()) ' or`<br> `Dim v = If(o IsNot Nothing, o.ToString(), Nothing)`

#### Example editorconfig file:
```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_null_propagation = true:suggestion
``` 

# <a name="csharp_codestyle">CSharp Code Style Settings</a>
## <a name="var">"var" and Explicit Types</a>
### <a name="var_built_in">"var" for built-in types (IDE0007, IDE0008)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_var_for_built_in_types`| C# | true:none | Visual Studio 2017 RTW |


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

### <a name="var_apparent">"var" when type is apparent (IDE0007, IDE0008)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_var_when_type_is_apparent`| C# | true:none | Visual Studio 2017 RTW |


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

### <a name="var_elsewhere">"var" elsewhere (IDE0007, IDE0008) </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_var_elsewhere`| C# | true:none | Visual Studio 2017 RTW |


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

##<a name="expression_bodied_members">Expression-bodied Members</a>
### <a name="expression_bodied_members_methods">Methods (IDE0022)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_methods`| C# 6.0+ | false:none | Visual Studio 2017 RTW |


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

### <a name="expression_bodied_members_constructors">Constructors (IDE0021)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_constructors`| C# 7.0+ | false:none | Visual Studio 2017 RTW |


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

### <a name="expression_bodied_members_operators">Operators (IDE0023, IDE0024)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_operators` | C# 7.0+ | false:none | Visual Studio 2017 RTW |


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

### <a name="expression_bodied_members_properties">Properties (IDE0025)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_properties` | C# 7.0+ | true:none | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer expression-bodied members for properties.| **C#:** <br>`public int Age => _age;`
| False | Do not prefer expression-bodied members for properties.| **C#:** <br>`public int Age { get { return _age; }}`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_properties = true:none
``` 

### <a name="expression_bodied_members_indexers">Indexers (IDE0026)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_indexers` | C# 7.0+ | true:none | Visual Studio 2017 RTW |


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

### <a name="expression_bodied_members_accessors">Accessors (IDE0027)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_accessors` | C# 7.0+ | true:none | Visual Studio 2017 RTW |


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
### <a name="pattern_matching_is_cast">"is" with "cast" checking (IDE0020)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_pattern_matching_over_is_with_cast_check` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |


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

### <a name="pattern_matching_as_null">"as" with "null" checking (IDE0019)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_pattern_matching_over_as_with_null_check` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |


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

### <a name="inlined_variable_declarations">Inlined variable declarations (IDE0018)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_inlined_variable_declaration` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `out` variables to be declared inline when possible. | **C#:** <br>`if (int.TryParse(value, out int i) {...}`
| False | Prefer `out` variables to be declared explicitly.| **C#:** <br>`int i; if (int.TryParse(value, out i) {...}`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_inlined_variable_declaration = true:suggestion
```
## <a name="expression_level_csharp">Expression-level Preferences</a>
### <a name="expression_level_default">Simplify `default` expressions (IDE0034) </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_prefer_simple_default_expression` | C# 7.1+ | true:suggestion | Visual Studio 2017 v. 15.3 |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `default` over `default(T)` | **C#:** <br>`void DoWork(CancellationToken cancellationToken = default){ ... }`
| False | Prefer. | **C#:** <br>`void DoWork(CancellationToken cancellationToken = default(CancellationToken)){ ... }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_prefer_simple_default_expression = true:suggestion
``` 

## <a name="null_checking">"Null" Checking Preferences</a>
### <a name="null_checking_throw_expressions">Throw-expressions (IDE0016)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_throw_expression`  | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use `throw` expressions instead of `throw` statements. | **C#:** <br>`this.s = ss ?? throw new ArgumentNullException(nameof(s));`
| False | Prefer to use `throw` statements instead of `throw` expressions.| **C#:** <br>`if (s==null) {throw new ArgumentNullException(nameof(s));} this.s = s;`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_throw_expression = true:suggestion
```

### <a name="null_checking_conditional_delegate_calls">Prefer conditional delegate calls (IDE0041)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_conditional_delegate_call`  | C# 6.0+ | true:suggestion | Visual Studio 2017 RTW |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use conditional coalescing operation (`?.`) when invoking a lambda instead of performing a null check. | **C#:** <br>`func?.Invoke(args);`
| False | Prefer to perform a null check before invoking a lambda instead of using the conditional coalescing operator (`?.`).| **C#:** <br>`if (func!=null) { func(args); }`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_conditional_delegate_call = false:suggestion
```

## <a name="code_block">"Code Block Preferences</a>
### <a name="prefer_braces">Prefer braces (IDE0011)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_prefer_braces`  | C#  | true:none | Visual Studio 2017 v. 15.3 |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer braces | **C#:** <br>`if (test) { this.Display(); }`
| False | Prefer no braces when possible | **C#:** <br>`if (test) this.Display();`

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_prefer_braces = true:none
```

# <a name="formatting"> Formatting Rules </a>
## Overview
**Rule Format:**
`options_name = false|true`

For formatting options, you must specify **true** (prefer this option) or **false** (do not prefer this option) except in a couple cases where you must instead specify what conditions you want the rule applied to.

## .NET Formatting Options

- **[.NET Formatting Settings](#usings)**
    - [Organize Usings](#usings)
        - [Sort System Directives First](#usings_sort_system_first)
- **[C# Formatting Settings](#newline)**
    - [Newline Options](#newline)
        - [Newline Before Open Brace (`{`)](#newline_before_brace)
        - [Newline Before `else`](#newline_before_else)
        - [Newline Before `catch`](#newline_before_catch)
        - [Newline Before `finally`](#newline_before_finally)
        - [Newline Before Members in Object Initializers](#newline_before_object)
        - [Newline Before Members in Anonymous Types](#newline_before_anonymous)
        - [Newline Before Members in Query Expression Clauses](#newline_before_query)
    - [Indentation Options](#indent)
        - [Indent `switch` Case Contents](#indent_switch)
        - [Indent `switch` Labels](#indent_switch_labels)
        - [Label Positioning](#label)
    - [Spacing Options](#spacing)
        - [Space After Cast](#space_after_cast)
        - [Space After Keywords in Control Flow Statements](#space_control_flow)
        - [Space Between Method Declaration Parameter-List Parentheses](#space_parameter_list)
        - [Space Within Parentheses for Method Call Argument List](#space_method_call)
        - [Space Within Parentheses for Other Options](#space_other)
    - [Wrapping Options](#wrapping)
        - [Leave Statements and Member Declarations on the Same Line](#wrapping_statement)
        - [Leave Block on Single Line](#wrapping_block)

## <a name="usings">Organize Usings</a>
### <a name="usings_sort_system_first">Sort System Directives First</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_sort_system_directives_first`  |  C# and Visual Basic | true | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Sort System.* usings alphabetically and place them before other usings.| **C#:** <br>`using System.Collections.Generic;`<br> `using System.Threading.Tasks;`<br> `using Octokit;`
| False | Have no requirements on the ordering of usings | **C#:** <br>`using System.Collections.Generic;`<br> `using Octokit;` <br> `using System.Threading.Tasks;`

#### Example editorconfig file:
```
# .NET formatting settings:
[*.{cs,vb}]
dotnet_sort_system_directives_first = true
``` 

# <a name="csharp_formatting">C# Formatting Settings</a>
## <a name="newline">Newline Options</a>
### <a name="newline_before_brace"> Newline Before Open Brace (`{`)</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_new_line_before_open_brace`  |  C#  | all | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| accessors, anonymous_methods, anonymous_types, control_blocks, events, indexers, lambdas, local_functions, methods, object_collection, properties, types. (For multiple, separate with ','). | Require braces to be on a new line for the given expressions (Allman style) |
| all | Require braces to be on a new line for all expressions (Allman) |
| none | Require braces to be on the same line for all expressions (K&R) |

#### Applied:
```csharp
// csharp_new_line_before_open_brace = all
void MyMethod() 
{
    if (...) 
    {
        ...
    }
}
```

```csharp
// csharp_new_line_before_open_brace = none
void MyMethod() {
    if (...) {
        ...
    }
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_open_brace = methods, properties, control_blocks, types
``` 

### <a name="newline_before_else"> Newline Before `else`</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_new_line_before_else` |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Place `else` statements on a new line.  |
| False | Place `else` statements on the same line.  |

#### Applied:
```csharp
// csharp_new_line_before_else = true
if (...) {
    ...
}
else {
    ...
}
```

```csharp
// csharp_new_line_before_else = false
if (...) {
    ...
} else {
    ...
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_else = true
``` 

### <a name="newline_before_catch"> Newline Before `catch`</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_new_line_before_catch`|  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Place `catch` statements on a new line.  |
| False | Place `catch` statements on the same line. |

#### Applied:
```csharp
// csharp_new_line_before_catch = true
try {
    ...
}
catch (Exception e) {
    ...
}
```

```csharp
// csharp_new_line_before_catch = false
try {
    ...
} catch (Exception e) {
    ...
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_catch = true
``` 

### <a name="newline_before_finally"> Newline Before `finally`</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_new_line_before_finally`|  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Require `finally` statements to be on a new line after the closing brace.  |
| False | Require `finally` statements to be on the same line as the closing brace.  |

#### Applied:
```csharp
// csharp_new_line_before_finally = true
try {
    ...
}
catch (Exception e) {
    ...
}
finally {
    ...
}
```

```csharp
// csharp_new_line_before_finally = false
try {
    ...
} catch (Exception e) {
    ...
} finally {
    ...
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_finally = true
``` 

### <a name="newline_before_object"> Newline Before Members in Object Initializers</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_new_line_before_members_in_object_initializers`|  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Require members of object intializers to be on separate lines.  |
| False | Require members of object initializers to be on the same line.  |

#### Applied:
```csharp
// csharp_new_line_before_members_in_object_initializers = true
var z = new B()
{
    A = 3,
    B = 4
}
```

```csharp
// csharp_new_line_before_members_in_object_initializers = false
var z = new B()
{
    A = 3, B = 4
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_members_in_object_initializers = true
``` 

### <a name="newline_before_anonymous"> Newline Before Members in Anonymous Types</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_new_line_before_members_in_anonymous_types` |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Require members of anonymous types to be on separate lines.  |
| False | Require members of anonymous types to be on the same line.  |

#### Applied:
```csharp
// csharp_new_line_before_members_in_anonymous_types = true
var z = new
{
    A = 3,
    B = 4
}
```

```csharp
// csharp_new_line_before_members_in_anonymous_types = false
var z = new
{
    A = 3, B = 4
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_members_in_anonymous_types = true
``` 

### <a name="newline_before_query"> Newline Before Members in Query Expression Clauses</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_new_line_between_query_expression_clauses`  |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| True | Require elements of query expression clauses to be on separate lines.  |
| False | Require elements of query expression clauses to be on the same line.  |

#### Applied:
```csharp
// csharp_new_line_between_query_expression_clauses = true
var q = from a in e
        from b in e
        select a * b;
```

```csharp
// csharp_new_line_between_query_expression_clauses = false
var q = from a in e from b in e
        select a * b;
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_new_line_between_query_expression_clauses = true
``` 

## <a name="indent">Indentation Options</a>
### <a name="indent_switch"> Indent `switch` Case Contents </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_indent_case_contents`  |  C#  | true | Visual Studio 2017 v. 15.3  |

| Value | Description 
| ------------- |:-------------|
| True | Indent `switch` case contents  |
| False | Do not indent `switch` case contents |

#### Applied:
```csharp
// csharp_indent_case_contents = true
switch(c) {
    case Color.Red:
        Console.WriteLine("The color is red");
        break;
    case Color.Blue:
        Console.WriteLine("The color is blue");
        break;
    default:
        Console.WriteLine("The color is unknown.");
        break;
}
```

```csharp
// csharp_indent_case_contents = false
switch(c) {
    case Color.Red:
    Console.WriteLine("The color is red");
    break;
    case Color.Blue:
    Console.WriteLine("The color is blue");
    break;
    default:
    Console.WriteLine("The color is unknown.");
    break;
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_indent_case_contents = true
``` 

### <a name="indent_switch_labels"> Indent `switch` Labels </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_indent_switch_labels`  |  C#  | true | Visual Studio 2017 v. 15.3  |

| Value | Description 
| ------------- |:-------------|
| True | Indent `switch` labels  |
| False | Do not indent `switch` labels |

#### Applied:
```csharp
// csharp_indent_switch_labels = true
switch(c) {
    case Color.Red:
        Console.WriteLine("The color is red");
        break;
    case Color.Blue:
        Console.WriteLine("The color is blue");
        break;
    default:
        Console.WriteLine("The color is unknown.");
        break;
}
```

```csharp
// csharp_indent_switch_labels = false
switch(c) {
case Color.Red:
    Console.WriteLine("The color is red");
    break;
case Color.Blue:
    Console.WriteLine("The color is blue");
    break;
default:
    Console.WriteLine("The color is unknown.");
    break;
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_indent_switch_labels = true
``` 

### <a name="label">Label Positioning</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_indent_labels`  |  C#  | no_change | Visual Studio 2017 v. 15.3  |


| Value | Description 
| ------------- |:-------------|
| flush_left | Labels are placed at the leftmost column |
| one_less_than_current | Labels are placed at one less indent to the current context |
| no_change | Labels are placed at the same indent as the current context |

#### Applied:

```csharp
// csharp_indent_labels= flush_left
class C
{
    private string MyMethod(...) 
    {
        if (...) {
            goto error;
        }
error:
        throw new Exception(...);
    }
}
```

```csharp
// csharp_indent_labels = one_less_than_current
class C
{
    private string MyMethod(...) 
    {
        if (...) {
            goto error;
        }
    error:
        throw new Exception(...);
    }
}

```

```csharp
// csharp_indent_labels= no_change
class C
{
    private string MyMethod(...) 
    {
        if (...) {
            goto error;
        }
        error:
        throw new Exception(...);
    }
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_indent_labels = flush_left
``` 

## <a name="spacing">Spacing Options</a>
### <a name="space_after_cast"> Space After Cast </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_space_after_cast` |  C#  | false | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied |
| ------------- |:-------------|:-------------|
| True | Require a space between a cast and the value  | **C#:** <br>`int y = (int) x;`
| False | Require no space between the cast and the value | **C#:** <br>`int y = (int)x;`

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_space_after_cast = true
``` 

### <a name="space_control_flow"> Space After Keywords in Control Flow Statements </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_space_after_keywords_in_control_flow_statements` |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied |
| ------------- |:-------------|:-------------|
| True | Require a space after a keyword | **C#:** <br>`for (int i;i<x;i++) { ... }`
| False | Require no space after a keyword | **C#:** <br>`for(int i;i<x;i++) { ... }`

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_space_after_keywords_in_control_flow_statements = true
``` 

### <a name="space_parameter_list"> Space Between Method Declaration Argument-List Parentheses </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
| `csharp_space_between_method_declaration_parameter_list_parentheses` |  C#  | false | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied |
| ------------- |:-------------|:-------------|
| True | Require a space after a keyword | **C#:** <br>`void Bark( int x ) { ... }`
| False | Require no space after a keyword | **C#:** <br>`void Bark(int x) { ... }`

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_space_between_method_declaration_parameter_list_parentheses = true
```

### <a name="space_method_call"> Space Within Parentheses for Method Call Argument List</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|  `csharp_space_between_method_call_parameter_list_parentheses` |  C#  | false | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied |
| ------------- |:-------------|:-------------|
| true | Place space between parentheses of control flow statements | **C#:** <br>`MyMethod( argument );`
| false | Place space between parentheses of expressions | **C#:** <br>`MyMethod(argument);`

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_space_between_method_call_parameter_list_parentheses = control_flow_statements, type_casts
```  

### <a name="space_other"> Space Within Parentheses for Other Options </a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|  `csharp_space_between_parentheses`  |  C#  | false | Visual Studio 2017 v. 15.3  |


| Value | Description | Applied |
| ------------- |:-------------|:-------------|
| control_flow_statements | Place space between parentheses of control flow statements | **C#:** <br>`for( int i;i<x;i++ ) { ... }`
| expressions | Place space between parentheses of expressions | **C#:** <br>`var z = ( x * y ) - ( ( y - x ) * 3);`
| type_casts | Place space between parentheses in type casts | **C#:**<br>`int y = ( int )x;`

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_space_between_parentheses = control_flow_statements, type_casts
``` 

## <a name="wrapping">Wrapping Options</a>
### <a name="wrapping_statement">Leave Statements and Member Declarations on the Same Line</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|  `csharp_preserve_single_line_statements`   |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description |
| ------------- |:-------------|
| True | Leave statements and member declarations on the same line  | 
| False | Leave statements and member declarations on different lines | 

#### Applied
```csharp
//csharp_preserve_single_line_statements = true
int i = 0; string name = "John";
```

```csharp
//csharp_preserve_single_line_statements = false
int i = 0; 
string name = "John";
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_preserve_single_line_statements = true
``` 

### <a name="wrapping_block">Leave Block on Single Line</a>
| **Option Name** | **Applicable Languages** | **Visual Studio Default** | **Supported Version** |
| ----------- | -------------------- | ----------------------| ----------------  |
|   `csharp_preserve_single_line_blocks`    |  C#  | true | Visual Studio 2017 v. 15.3  |


| Value | Description |
| ------------- |:-------------|
| True | Leave block on single line | 
| False | Leave block on separate lines | 

#### Applied
```csharp
//csharp_preserve_single_line_blocks = true
public int Foo { get; set; }
```

```csharp
//csharp_preserve_single_line_blocks = false
public int MyProperty
{ 
    get; set;
}
```

#### Example editorconfig file:
```
# CSharp formatting settings:
[*.cs]
csharp_preserve_single_line_blocks = true
``` 

# <a name="naming"> Naming Conventions </a>
## Overview
**Rule Format:**<br>
namingRuleTitle:<br>
`dotnet_naming_rule.<namingRuleTitle>.symbols = <symbolTitle>`<br>
`dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>`<br>
`dotnet_naming_rule.<namingRuleTitle>.severity = none|suggestion|warning|error`<br>
<br>
symbolTitle:<br>
`dotnet_naming_symbols.<symbolTitle>.applicable_kinds = class, struct, interface, enum, property, method, field, event, namespace, delegate, type_parameter`<br>
`dotnet_naming_symbols.<symbolTitle>.applicable_accessibilities = public, internal, private, protected, protected_internal`<br>
`dotnet_naming_symbols.<symbolTitle>.required_modifiers = abstract, async, const, readonly, static`<br>
<br>
styleTitle:<br>
`dotnet_naming_style.<styleTitle>.capitalization = pascal_case|camel_case|first_word_upper|all_upper|all_lower`<br>
`dotnet_naming_style.<styleTitle>.required_prefix = string`<br>
`dotnet_naming_style.<styleTitle>.required_suffix = string`<br>
`dotnet_naming_style.<styleTitle>.word_separator = string`<br>

## Writing a Naming Convention
For naming conventions, you must specify **symbols**, **style**, and a **severity**. Naming conventions should be ordered from most-specific to least-specific. The first rule encountered that can be applied, is the only rule applied. 

### Severity
The following are valid options for the severity of a naming style rule
 `none`, `silent`, `suggestion`, `warning`, `error`.

 `none` and `silent` are synonymous and mean that no indication of any kind should be shown to the user. This has the effect of disabling this rule.

 `suggestion` means that the user is shown the following in the Error List: and the following in the IDE. The `suggestion` severity allows the naming rule to run, but it doesn't cause the build to break.

Severity | effect
------------ | -------------
none/silent | Do not show anything to the user when this style is not being followed, however code generation features generate in this style. 
suggestion | When this style is not being followed, show it to the user as a suggestion (underlying dots on the first two characters).
warning | When this style is not being followed, show a compiler warning.
error | When this style is not being followed, show a compiler error.

### Symbol Specification
Identify _what_ symbols _with which_ modifiers and _at what_ accessibility level the naming rule should apply to.

|  Option Name | `dotnet_naming_rule.<namingRuleTitle>.symbols` |
| ------------- |:-------------:|
|  | `dotnet_naming_symbols.<symbolTitle>.applicable_kinds`
|  | `dotnet_naming_symbols.<symbolTitle>.applicable_accessibilities`
|  | `dotnet_naming_symbols.<symbolTitle>.required_modifiers`

| Symbol | Accessibility | Modifiers
| ------------- |------------- |------------- |
| `*` | `*` |  `abstract` | 
| `class` | `public` |  `must_inherit` | `async` | 
| `struct` | `internal` (C#) /  | `const` | 
| `interface` | `friend` (Visual Basic) | `readonly` | 
| `enum` | `private`  | `static` | 
| `property` | `protected` | `shared` |
| `method` |`protected_internal` (C#) | |
| `field` | `protected_friend` (Visual Basic) | |
| `event` | | |
| `delegate` | | |


### Style Specification
Identify the naming style to apply to the symbols.

|  Option Name | `dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>` |
| ------------- |:-------------:|
|  | `dotnet_naming_style.<styleTitle>.capitalization`|
|  | `dotnet_naming_style.<styleTitle>.required_prefix`|
|  | `dotnet_naming_style.<styleTitle>.required_suffix`|
|  | `dotnet_naming_style.<styleTitle>.word_separator`|


| Style | Description |
| ------------- |:-------------:|
| Prefix | Required characters that must appear before the identifier. |
| Suffix | Required characters that must appear after the identifier. |
| Word Separator | Required separator between words in the identifier. |
| Capitalization |`pascal_case`, `camel_case`, `first_word_upper`, `all_upper`, `all_lower` | 


### Example Naming Convention
```
# Dotnet Naming Conventions
[*.{cs,vb}] 
dotnet_naming_rule.async_methods_end_in_async.symbols  = any_async_methods
dotnet_naming_rule.async_methods_end_in_async.style    = end_in_async
dotnet_naming_rule.async_methods_end_in_async.severity = suggestion

dotnet_naming_symbols.any_async_methods.applicable_kinds           = method
dotnet_naming_symbols.any_async_methods.applicable_accessibilities = *
dotnet_naming_symbols.any_async_methods.required_modifiers         = async

dotnet_naming_style.end_in_async.required_suffix = Async
dotnet_naming_style.end_in_async.capitalization  = pascal_case
``` 
