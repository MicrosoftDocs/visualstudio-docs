---
title: ".NET Coding Convention Settings For EditorConfig | Microsoft Docs"
ms.custom: ""
ms.date: "10/13/2017"
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
ms.technology: 
  - "vs-ide-general"
---
# .NET coding convention settings for EditorConfig
You can define and maintain consistent code style in your codebase with the use of an [EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options) file. EditorConfig includes several core formatting properties, such as `indent_style` and `indent_size`. In Visual Studio, .NET coding conventions settings can also be configured using an EditorConfig file. EditorConfig files allow you to enable or disable individual .NET coding conventions, and to configure the degree to which you want the convention enforced via a severity level. To learn more about how to use EditorConfig to enforce consistency in your codebase, read [Create portable custom editor options](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options). You can also look at the [.NET Compiler Platform's .editorconfig file](https://github.com/dotnet/roslyn/blob/master/.editorconfig) as an example.  

There are three supported .NET coding convention categories:  
- [Language Conventions](#language-conventions)  
   Rules pertaining to the C# or Visual Basic language. For example, you can specify rules around using `var` or explicit types when defining variables, or preferring expression-bodied members.  
- [Formatting Conventions](#formatting-conventions)  
   Rules regarding the layout and structure of your code in order to make it easier to read. For example, you can specify rules around Allman braces, or preferring spaces in control blocks.  
- [Naming Conventions](#naming-conventions)  
   Rules regarding the naming of code elements. For example, you can specify that `async` methods must end in "Async".  

## Language conventions  
The rules for language conventions have the following format:  

`options_name = false|true : none|suggestion|warning|error`  

For each language convention rule, you must specify either **true** (prefer this style) or **false** (do not prefer this style), and a **severity**. The severity specifies the level of enforcement for that style.  

The following table lists the possible severity values and their effects:  

Severity | Effect
:------- | ------
none or silent | Do not show anything to the user when this rule is violated. Code generation features will generate code in this style, however.  
suggestion | When this style rule is violated, show it to the user as a suggestion. Suggestions appear as three grey dots under the first two characters.  
warning | When this style rule is violated, show a compiler warning.  
error | When this style rule is violated, show a compiler error.  

The following list shows the allowable language convention rules:  

- .NET Code Style Settings
    - ["This." and "Me." qualifiers](#this_and_me)
        - dotnet\_style\_qualification\_for_field
        - dotnet\_style\_qualification\_for_property
        - dotnet\_style\_qualification\_for_method
        - dotnet\_style\_qualification\_for_event
    - [Language keywords instead of framework type names for type references](#language_keywords)
        - dotnet\_style\_predefined\_type\_for\_locals\_parameters_members
        - dotnet\_style\_predefined\_type\_for\_member_access
    - [Expression-level preferences](#expression_level)
        - dotnet\_style\_object_initializer
        - dotnet\_style\_collection_initializer
        - dotnet\_style\_explicit\_tuple_names
        - dotnet\_style\_coalesce_expression
        - dotnet\_style\_null_propagation
- C# Code Style Settings
    - [Implicit and explicit types](#var)
        - csharp\_style\_var\_for\_built\_in_types
        - csharp\_style\_var\_when\_type\_is_apparent
        - csharp\_style\_var_elsewhere
    - [Expression-bodied members](#expression_body)
        - csharp\_style\_expression\_bodied_methods
        - csharp\_style\_expression\_bodied_constructors
        - csharp\_style\_expression\_bodied_operators
        - csharp\_style\_expression\_bodied_properties
        - csharp\_style\_expression\_bodied_indexers
        - csharp\_style\_expression\_bodied_accessors
    - [Pattern matching](#pattern_matching)
        - csharp\_style\_pattern\_matching\_over\_is\_with\_cast_check
        - csharp\_style\_pattern\_matching\_over\_as\_with\_null_check
    - [Inlined variable declarations](#inlined_variable_declarations)
        - csharp\_style\_inlined\_variable_declaration
    - [Expression-level preferences](#expression_level_csharp)
        - csharp\_prefer\_simple\_default_expression
    - ["Null" checking preferences](#null_checking)
        - csharp\_style\_throw_expression
        - csharp\_style\_conditional\_delegate_call
    - [Code block preferences](#code_block)
        - csharp\_prefer_braces

### .NET code style settings  
The style rules in this section are applicable to both C# and Visual Basic. To see code examples in your preferred programming language, choose it in the drop-down **Language** menu at the top-right corner of your browser window.  

#### <a name="this_and_me">"This." and "Me." qualifiers (rule IDs IDE0003 and IDE0009)</a>
This style rule can be applied to fields, properties, methods or events. A value of **true** means prefer the code symbol to be prefaced with `this.` in C# or `Me.` in Visual Basic. A value of **false** means prefer the code element _not_ to be prefaced with `this.` or `Me.`.  

The following table shows the rule names, applicable programming languages, default values, and first supported version of Visual Studio:  

| Rule Name | Applicable languages | Visual Studio default value | Supported version |
| ----------- | -------------------- | ----------------------| ----------------  |
| `dotnet_style_qualification_for_field` | C# and Visual Basic | false:none | Visual Studio 2017 RTW |
| `dotnet_style_qualification_for_property` | C# and Visual Basic | false:none | Visual Studio 2017 RTW |
| `dotnet_style_qualification_for_method` | C# and Visual Basic | false:none | Visual Studio 2017 RTW |
| `dotnet_style_qualification_for_event` | C# and Visual Basic | false:none | Visual Studio 2017 RTW |   

**dotnet\_style\_qualification\_for_field**  
When this rule is set to **true**, prefer fields to be prefaced with `this.` in C# or `Me.` in Visual Basic.  
When this rule is set to **false**, prefer fields _not_ to be prefaced with `this.` or `Me.`.  

Code examples:  

```csharp
// dotnet_style_qualification_for_field = true
this.capacity = 0;

// dotnet_style_qualification_for_field = false
capacity = 0;
```
```vb
' dotnet_style_qualification_for_field = true
Me.capacity = 0

' dotnet_style_qualification_for_field = false
capacity = 0
```  

**dotnet\_style\_qualification\_for_property**  
When this rule is set to **true**, prefer properties to be prefaced with `this.` in C# or `Me.` in Visual Basic.  
When this rule is set to **false**, prefer properties _not_ to be prefaced with `this.` or `Me.`.  

Code examples:  

```csharp
// dotnet_style_qualification_for_property = true
this.ID = 0;

// dotnet_style_qualification_for_property = false
ID = 0;
```
```vb
' dotnet_style_qualification_for_property = true
Me.ID = 0

' dotnet_style_qualification_for_property = false
ID = 0
```  

**dotnet\_style\_qualification\_for_method**  
When this rule is set to **true**, prefer methods to be prefaced with `this.` in C# or `Me.` in Visual Basic.  
When this rule is set to **false**, prefer methods _not_ to be prefaced with `this.` or `Me.`.  

Code examples:  

```csharp
// dotnet_style_qualification_for_method = true
this.Display();

// dotnet_style_qualification_for_method = false
Display();
```
```vb
' dotnet_style_qualification_for_method = true
Me.Display()

' dotnet_style_qualification_for_method = false
Display()
```  

**dotnet\_style\_qualification\_for_event**  
When this rule is set to **true**, prefer events to be prefaced with `this.` in C# or `Me.` in Visual Basic.  
When this rule is set to **false**, prefer events _not_ to be prefaced with `this.` or `Me.`.  

Code examples:  

```csharp
// dotnet_style_qualification_for_event = true
this.Elapsed += Handler;

// dotnet_style_qualification_for_event = false
Elapsed += Handler;
```
```vb
' dotnet_style_qualification_for_event = true
AddHandler Me.Elapsed, AddressOf Handler

' dotnet_style_qualification_for_event = false
AddHandler Elapsed, AddressOf Handler
```  

This rule could appear in an .editorconfig file as follows:  

```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_qualification_for_field = false:suggestion
dotnet_style_qualification_for_property = false:suggestion
dotnet_style_qualification_for_method = false:suggestion
dotnet_style_qualification_for_event = false:suggestion
```

#### <a name="language_keywords">Language keywords instead of framework type names for type references</a>
This style rule can be applied to local variables, method parameters, and class members (rule IDs IDE0012 and IDE0014), or as a separate rule to type member access expressions (rule IDs IDE0013 and IDE0015). A value of **true** means prefer the language keyword (e.g. `int` or `Integer`) instead of the type name (e.g. `Int32`) for types that have a keyword to represent them. A value of **false** means prefer the type name instead of the language keyword.  

The following table shows the rule names, applicable programming languages, default values, and first supported version of Visual Studio:  

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_predefined_type_for_locals_parameters_members`| C# and Visual Basic | true:none | Visual Studio 2017 RTW |
|`dotnet_style_predefined_type_for_member_access`| C# and Visual Basic | true:none | Visual Studio 2017 RTW |  

**dotnet\_style\_predefined\_type\_for\_locals\_parameters_members**  
When this rule is set to **true**, prefer the language keyword for local variables, method parameters, and class members, instead of the type name, for types that have a keyword to represent them.  
When this rule is set to **false**, prefer the type name for local variables, method parameters, and class members, instead of the language keyword.  

Code examples:  

```csharp
// dotnet_style_predefined_type_for_locals_parameters_members = true
private int _member;

// dotnet_style_predefined_type_for_locals_parameters_members = false
private Int32 _member;
```
```vb
' dotnet_style_predefined_type_for_locals_parameters_members = true
Private _member As Integer

' dotnet_style_predefined_type_for_locals_parameters_members = false
Private _member As Int32
``` 

**dotnet\_style\_predefined\_type\_for\_member_access**   
When this rule is set to **true**, prefer the language keyword for member access expressions, instead of the type name, for types that have a keyword to represent them.  
When this rule is set to **false**, prefer the type name for member access expressions, instead of the language keyword.  

Code examples:  

```csharp
// dotnet_style_predefined_type_for_member_access = true
var local = int.MaxValue;

// dotnet_style_predefined_type_for_member_access = false
var local = Int32.MaxValue;
```
```vb
' dotnet_style_predefined_type_for_member_access = true
Dim local = Integer.MaxValue

' dotnet_style_predefined_type_for_member_access = false
Dim local = Int32.MaxValue
```  

This rule could appear in an .editorconfig file as follows:  

```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_predefined_type_for_locals_parameters_members = true:suggestion
dotnet_style_predefined_type_for_member_access = true:suggestion
``` 

#### <a name="expression_level">Expression-level preferences</a>  
The style rules in this section concern expression-level preferences, including the use of object initializers (rule ID IDE0017), collection initializers (rule ID IDE0028), explicit tuple names (rule ID IDE0033), null coalescing expressions versus ternary operators (rule ID IDE0029), and the null-conditional operator (rule ID IDE0031).  

The following table shows the rule names, applicable programming languages, default values, and first supported version of Visual Studio:  

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`dotnet_style_object_initializer`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |
|`dotnet_style_collection_initializer`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |
|`dotnet_style_explicit_tuple_names`| C# 7.0+ and Visual Basic 15+ | true:suggestion | Visual Studio 2017 RTW |
|`dotnet_style_coalesce_expression`| C# and Visual Basic | true:suggestion | Visual Studio 2017 RTW |
|`dotnet_style_null_propagation`| C# 6.0+ and Visual Basic 14+ | true:suggestion | Visual Studio 2017 RTW | 

**dotnet\_style\_object_initializer**  
When this rule is set to **true**, prefer objects to be initialized using object initializers when possible.  
When this rule is set to **false**, prefer objects to *not* be initialized using object initializers.  

Code examples:  

```csharp
// dotnet_style_object_initializer = true
var c = new Customer() { Age = 21 };

// dotnet_style_object_initializer = false
var c = new Customer();
c.Age = 21;
```
```vb
' dotnet_style_object_initializer = true
Dim c = New Customer() With {.Age = 21}

' dotnet_style_object_initializer = false
Dim c = New Customer()
c.Age = 21
```

**dotnet\_style\_collection_initializer**  
When this rule is set to **true**, prefer collections to be initialized using collection initializers when possible.  
When this rule is set to **false**, prefer collections to *not* be initialized using collection initializers.

Code examples:

```csharp
// dotnet_style_collection_initializer = true
var list = new List<int> { 1, 2, 3 };

// dotnet_style_collection_initializer = false
var list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
```
```vb
' dotnet_style_collection_initializer = true
Dim list = New List(Of Integer) From {1, 2, 3}

' dotnet_style_collection_initializer = false
Dim list = New List(Of Integer)
list.Add(1)
list.Add(2)
list.Add(3)
```  

**dotnet\_style\_explicit\_tuple_names**  
When this rule is set to **true**, prefer tuple names to ItemX properties.  
When this rule is set to **false**, prefer ItemX properties to tuple names.  

Code examples:  

```csharp
// dotnet_style_explicit_tuple_names = true
(string name, int age) customer = GetCustomer();
var name = customer.name;

// dotnet_style_explicit_tuple_names = false
(string name, int age) customer = GetCustomer();
var name = customer.Item1;
```
```vb
 ' dotnet_style_explicit_tuple_names = true
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.name

' dotnet_style_explicit_tuple_names = false
Dim customer As (name As String, age As Integer) = GetCustomer()
Dim name = customer.Item1
```

**dotnet\_style\_coalesce_expression**  
When this rule is set to **true**, prefer null coalescing expressions to ternary operator checking.  
When this rule is set to **false**, prefer ternary operator checking to null coalescing expressions.

Code examples:  

```csharp
// dotnet_style_coalesce_expression = true
var v = x ?? y;

// dotnet_style_coalesce_expression = false
var v = x != null ? x : y; // or
var v = x == null ? y : x;
```
```vb
' dotnet_style_coalesce_expression = true
Dim v = If(x, y)

' dotnet_style_coalesce_expression = false
Dim v = If(x Is Nothing, y, x) ' or
Dim v = If(x IsNot Nothing, x, y)
```

**dotnet\_style\_null_propagation**  
When this rule is set to **true**, prefer to use null-conditional operator when possible.  
When this rule is set to **false**, prefer to use ternary null checking where possible.  

Code examples:  

```csharp
// dotnet_style_null_propagation = true
var v = o?.ToString();

// dotnet_style_null_propagation = false
var v = o == null ? null : o.ToString(); // or
var v = o != null ? o.String() : null;
```
```vb
' dotnet_style_null_propagation = true
Dim v = o?.ToString()

' dotnet_style_null_propagation = false
Dim v = If(o Is Nothing, Nothing, o.ToString()) ' or
Dim v = If(o IsNot Nothing, o.ToString(), Nothing)
```  

This rule could appear in an .editorconfig file as follows:  

```
# CSharp and Visual Basic code style settings:
[*.{cs,vb}]
dotnet_style_object_initializer = true:suggestion
dotnet_style_collection_initializer = true:suggestion
dotnet_style_explicit_tuple_names = true:suggestion
dotnet_style_coalesce_expression = true:suggestion
dotnet_style_null_propagation = true:suggestion
``` 

### C# code style settings  
The style rules in this section are applicable to C# only.  

#### <a name="var">Implicit and explicit types</a>
The style rules in this section (rule IDs IDE0007 and IDE0008) concern the use of the [var](/dotnet/csharp/language-reference/keywords/var) keyword versus an explicit type in a variable declaration. This rule can be applied separately to built-in types, when the type is apparent, and elsewhere.  

The following table shows the rule names, applicable programming languages, default values, and first supported version of Visual Studio:  

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_var_for_built_in_types`| C# | true:none | Visual Studio 2017 RTW |
|`csharp_style_var_when_type_is_apparent`| C# | true:none | Visual Studio 2017 RTW |
|`csharp_style_var_elsewhere`| C# | true:none | Visual Studio 2017 RTW |

**csharp\_style\_var\_for\_built\_in_types**  
When this rule is set to **true**, prefer `var` is used to declare variables with built-in system types such as `int`.  
When this rule is set to **false**, prefer explicit type over `var` to declare variables with built-in system types such as `int`.

Code examples:  

```csharp
// csharp_style_var_for_built_in_types = true
var x = 5;

// csharp_style_var_for_built_in_types = false
int x = 5;
```

**csharp\_style\_var\_when\_type\_is_apparent**  
When this rule is set to **true**, prefer `var` when the type is already mentioned on the right-hand side of a declaration expression.  
When this rule is set to **false**, prefer explicit type over `var` when the type is already mentioned on the right-hand side of a declaration expression.  

Code examples:  

```csharp
// csharp_style_var_when_type_is_apparent = true
var obj = new Customer();

// csharp_style_var_when_type_is_apparent = false
Customer obj = new Customer();
```

**csharp\_style\_var_elsewhere**  
When this rule is set to **true**, prefer `var` over explicit type in all cases, unless overridden by another code style rule.  
When this rule is set to **false**, prefer explicit type over `var` in all cases, unless overridden by another code style rule.  

Code examples:  

```csharp
// csharp_style_var_elsewhere = true
var f = this.Init();

// csharp_style_var_elsewhere = false
bool f = this.Init();
```

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_var_for_built_in_types = true:suggestion
csharp_style_var_when_type_is_apparent = true:suggestion
csharp_style_var_elsewhere = true:suggestion
``` 

#### <a name="expression_bodied_members">Expression-bodied members</a>
The style rules in this section concern the use of [expression-bodied members](/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members) when the logic consists of a single expression. This rule can be applied to methods (rule ID IDE0022), constructors (rule ID IDE0021), operators (rule IDs IDE0023 and IDE0024), properties (rule ID IDE0025), indexers (rule ID IDE0026), and accessors (rule ID IDE0027).  

The following table shows the rule names, applicable language versions, default values, and first supported version of Visual Studio:  

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_expression_bodied_methods`| C# 6.0+ | false:none | Visual Studio 2017 RTW |
|`csharp_style_expression_bodied_constructors`| C# 7.0+ | false:none | Visual Studio 2017 RTW |
|`csharp_style_expression_bodied_operators` | C# 7.0+ | false:none | Visual Studio 2017 RTW |
|`csharp_style_expression_bodied_properties` | C# 7.0+ | true:none | Visual Studio 2017 RTW |
|`csharp_style_expression_bodied_indexers` | C# 7.0+ | true:none | Visual Studio 2017 RTW |
|`csharp_style_expression_bodied_accessors` | C# 7.0+ | true:none | Visual Studio 2017 RTW |  

**csharp\_style\_expression\_bodied_methods**  
When this rule is set to **true**, prefer expression-bodied members for methods.  
When this rule is set to **false**, do not prefer expression-bodied members for methods.  

Code examples:  

```csharp
// csharp_style_expression_bodied_methods = true
public int GetAge() => this.Age;

// csharp_style_expression_bodied_methods = false
public int GetAge() { return this.Age; }
```  

**csharp\_style\_expression\_bodied_constructors**  
When this rule is set to **true**, prefer expression-bodied members for constructors.  
When this rule is set to **false**, do not prefer expression-bodied members for constructors.  

Code examples:  

```csharp
// csharp_style_expression_bodied_constructors = true
public Customer(int age) => Age = age;

// csharp_style_expression_bodied_constructors = false
public Customer(int age) { Age = age; }
```  

**csharp\_style\_expression\_bodied_operators**  
When this rule is set to **true**, prefer expression-bodied members for operators.  
When this rule is set to **false**, do not prefer expression-bodied members for operators.  

Code examples:  

```csharp
// csharp_style_expression_bodied_operators = true
public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    => new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);

// csharp_style_expression_bodied_operators = false
public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
{ return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary); }
```  

**csharp\_style\_expression\_bodied_properties**  
When this rule is set to **true**, prefer expression-bodied members for properties.  
When this rule is set to **false**, do not prefer expression-bodied members for properties.  

Code examples:  

```csharp
// csharp_style_expression_bodied_properties = true
public int Age => _age;

// csharp_style_expression_bodied_properties = false
public int Age { get { return _age; }}
```  

**csharp\_style\_expression\_bodied_indexers**  
When this rule is set to **true**, prefer expression-bodied members for indexers.  
When this rule is set to **false**, do not prefer expression-bodied members for indexers.  

Code examples:  

```csharp
// csharp_style_expression_bodied_indexers = true
public T this[int i] => _value[i];

// csharp_style_expression_bodied_indexers = false
public T this[int i] { get { return _values[i]; } }
```  

**csharp\_style\_expression\_bodied_accessors**  
When this rule is set to **true**, prefer expression-bodied members for accessors.  
When this rule is set to **false**, do not prefer expression-bodied members for accessors.  

Code examples:  

```csharp
// csharp_style_expression_bodied_accessors = true
public int Age { get => _age; set => _age = value; }

// csharp_style_expression_bodied_accessors = false
public int Age { get { return _age; } set { _age = value; } }
```  

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_expression_bodied_methods = false:none
csharp_style_expression_bodied_constructors = false:none
csharp_style_expression_bodied_operators = false:none
csharp_style_expression_bodied_properties = true:none
csharp_style_expression_bodied_indexers = false:none
csharp_style_expression_bodied_accessors = false:none
```  

#### <a name="pattern_matching">Pattern matching</a>

"is" with "cast" checking (IDE0020)
"as" with "null" checking (IDE0019)
Inlined variable declarations (IDE0018)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_pattern_matching_over_is_with_cast_check` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |
|`csharp_style_pattern_matching_over_as_with_null_check` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |
|`csharp_style_inlined_variable_declaration` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_pattern_matching_over_is_with_cast_check = true:suggestion
csharp_style_pattern_matching_over_as_with_null_check = true:suggestion
csharp_style_inlined_variable_declaration = true:suggestion
```

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer pattern matching instead of `is` expressions with type casts.| **C#:** <br>`if (o is int i) {...}`
| False | Prefer `is` expressions with type casts instead of pattern matching.| **C#:** <br>`if (o is int) {var i = (int)o; ... }`

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer pattern matching instead of `as` expressions with null checks to determine if something is of a particular type.| **C#:** <br>`if (o is string s) {...}`
| False | Prefer `as` expressions with null checks instead of pattern matching to determine if something is of a particular type.| **C#:** <br>`var s = o as string; if (s != null) {...}`

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `out` variables to be declared inline when possible. | **C#:** <br>`if (int.TryParse(value, out int i) {...}`
| False | Prefer `out` variables to be declared explicitly.| **C#:** <br>`int i; if (int.TryParse(value, out i) {...}`

#### <a name="inlined_variable_declarations">Inlined variable declarations</a>

Inlined variable declarations (IDE0018)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_inlined_variable_declaration` | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_inlined_variable_declaration = true:suggestion
```

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer `out` variables to be declared inline when possible. | **C#:** <br>`if (int.TryParse(value, out int i) {...}`
| False | Prefer `out` variables to be declared explicitly.| **C#:** <br>`int i; if (int.TryParse(value, out i) {...}`

#### <a name="expression_level_csharp">Expression-level preferences</a>

Simplify `default` expressions (IDE0034)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

#### <a name="null_checking">"Null" checking preferences</a>

Throw-expressions (IDE0016)
Prefer conditional delegate calls (IDE0041)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
| ----------- | -------------------- | ----------------------| ----------------  |
|`csharp_style_throw_expression`  | C# 7.0+ | true:suggestion | Visual Studio 2017 RTW |
|`csharp_style_conditional_delegate_call`  | C# 6.0+ | true:suggestion | Visual Studio 2017 RTW |

#### Example editorconfig file:
```
# CSharp code style settings:
[*.cs]
csharp_style_throw_expression = true:suggestions:
csharp_style_conditional_delegate_call = false:suggestion
```

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use `throw` expressions instead of `throw` statements. | **C#:** <br>`this.s = ss ?? throw new ArgumentNullException(nameof(s));`
| False | Prefer to use `throw` statements instead of `throw` expressions.| **C#:** <br>`if (s==null) {throw new ArgumentNullException(nameof(s));} this.s = s;`

| Value | Description | Applied 
| ------------- |:-------------|:-------------|
| True | Prefer to use conditional coalescing operation (`?.`) when invoking a lambda instead of performing a null check. | **C#:** <br>`func?.Invoke(args);`
| False | Prefer to perform a null check before invoking a lambda instead of using the conditional coalescing operator (`?.`).| **C#:** <br>`if (func!=null) { func(args); }`

#### <a name="code_block">"Code block preferences</a>

Prefer braces (IDE0011)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

## Formatting conventions

Overview
**Rule Format:**
`options_name = false|true`

For formatting rules, you must specify **true** (prefer this style) or **false** (do not prefer this style) except in a couple cases where you must instead specify what conditions you want the rule applied to.

### .NET formatting settings

- .NET Formatting Settings
    - [Organize Usings](#usings)
- C# Formatting Settings
    - [Newline Options](#newline)
    - [Indentation Options](#indent)
    - [Spacing Options](#spacing)
    - [Wrapping Options](#wrapping)

#### <a name="usings">Organize usings</a>

Sort System Directives First

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

### <a name="csharp_formatting">C# formatting settings</a>  

#### <a name="newline">Newline Options</a>  

 Newline Before Open Brace (`{`)

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before `else`

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before `catch`

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before `finally`

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before Members in Object Initializers

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before Members in Anonymous Types

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Newline Before Members in Query Expression Clauses

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

#### <a name="indent">Indentation options</a>  

Indent `switch` Case Contents

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Indent `switch` Labels

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Label positioning

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

#### <a name="spacing">Spacing Options</a>  

Space After Cast

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Space After Keywords in Control Flow Statements

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Space Between Method Declaration Argument-List Parentheses

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Space Within Parentheses for Method Call Argument List

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Space Within Parentheses for Other Options

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

#### <a name="wrapping">Wrapping options</a>

Leave Statements and Member Declarations on the Same Line

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

Leave Block on Single Line

| Rule Name | Applicable Languages | Visual Studio Default | Supported Version |
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

## Naming conventions  
Naming conventions concern the naming of code elements such as classes, properties, and methods. For example, you can specify that asynchronous methods must end in "Async". Naming conventions should be ordered from most-specific to least-specific. The first rule encountered that can be applied is the only rule that is applied.  

For each naming convention rule, identified by `namingRuleTitle`, you must specify the **symbols** it applies to, a naming **style**, and a **severity**:  
  
`dotnet_naming_rule.<namingRuleTitle>.symbols = <symbolTitle>`  
`dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>`  
`dotnet_naming_rule.<namingRuleTitle>.severity = none|suggestion|warning|error`  

### Symbols
Identify a group of symbols to apply a naming rule to with this property: `dotnet_naming_rule.<namingRuleTitle>.symbols = <symbolTitle>`. Specify which kind of symbols, which modifiers, and which accessibility levels are included in the group using the following properties:  

| Property | Possible Values |
| ------------- |:-------------:|
| `dotnet_naming_symbols.<symbolTitle>.applicable_kinds` | *, class, struct, interface, enum, property, method, field, event, namespace, delegate, type_parameter |
| `dotnet_naming_symbols.<symbolTitle>.applicable_accessibilities` | *, public, internal (C#), friend (Visual Basic), private, protected, protected\_internal (C#), protected\_friend (Visual Basic) |
| `dotnet_naming_symbols.<symbolTitle>.required_modifiers` | abstract (C#), must_inherit (Visual Basic), async, const, readonly, static (C#), shared (Visual Basic) |  

### Style
Identify the naming style to apply to a group of symbols with this property: `dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>`. Specify the naming style using one or more of the following properties:  

|  Property | Possible Values |
| ------------- |:-------------:|
| `dotnet_naming_style.<styleTitle>.required_prefix`| Required characters that must appear at the beginning of the identifier. |  
| `dotnet_naming_style.<styleTitle>.required_suffix`| Required characters that must appear at the end of the identifier. |  
| `dotnet_naming_style.<styleTitle>.word_separator`| Required character between words in the identifier. | 
| `dotnet_naming_style.<styleTitle>.capitalization`| `pascal_case`, `camel_case`, `first_word_upper`, `all_upper`, `all_lower` |  

#### Severity
Identify the severity level for a naming rule with this property: `dotnet_naming_rule.<namingRuleTitle>.severity`. The following table shows the severity value options:  

Severity | Effect
------------ | -------------
none or silent | When this style is not being followed, do not show anything to the user; however, code generation features generate new code in this style.  
suggestion | When this style is not being followed, show it to the user as a suggestion (underlying dots on the first two characters). It has no effect at compile time.  
warning | When this style is not being followed, show a compiler warning.  
error | When this style is not being followed, show a compiler error.   

### Example naming convention
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

## See also
[Quick Actions](../ide/quick-actions.md)  
[Create portable custom editor options](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options)  
[.NET Compiler Platform's .editorconfig file](https://github.com/dotnet/roslyn/blob/master/.editorconfig)  