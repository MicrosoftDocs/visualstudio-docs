---
title: .NET formatting conventions for EditorConfig
ms.date: 06/17/2019
ms.topic: reference
dev_langs:
  - "CSharp"
  - "VB"
helpviewer_keywords:
  - "formatting conventions [EditorConfig]"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
  - "dotnetcore"
---
# Formatting conventions

Most of the rules for formatting conventions have the following format:

`rule_name = false|true`

You specify either **true** (prefer this style) or **false** (do not prefer this style). For a few rules, instead of true or false, you specify other values to describe when and where to apply the rule. You don't specify a severity.

The following list shows the formatting convention rules available in Visual Studio:

- [.NET formatting settings](#net-formatting-settings)
    - [Organize usings](#organize-using-directives)
        - dotnet_sort_system_directives_first
        - dotnet_separate_import_directive_groups
- [C# formatting settings](#c-formatting-settings)
    - [Newline options](#new-line-options)
        - csharp_new_line_before_open_brace
        - csharp_new_line_before_else
        - csharp_new_line_before_catch
        - csharp_new_line_before_finally
        - csharp_new_line_before_members_in_object_initializers
        - csharp_new_line_before_members_in_anonymous_types
        - csharp_new_line_between_query_expression_clauses
    - [Indentation options](#indentation-options)
        - csharp_indent_case_contents
        - csharp_indent_switch_labels
        - csharp_indent_labels
    - [Spacing options](#spacing-options)
        - csharp_space_after_cast
        - csharp_space_after_keywords_in_control_flow_statements
        - csharp_space_between_method_declaration_parameter_list_parentheses
        - csharp_space_between_method_call_parameter_list_parentheses
        - csharp_space_between_parentheses
        - csharp_space_before_colon_in_inheritance_clause
        - csharp_space_after_colon_in_inheritance_clause
        - csharp_space_around_binary_operators
        - csharp_space_between_method_declaration_empty_parameter_list_parentheses
        - csharp_space_between_method_call_name_and_opening_parenthesis
        - csharp_space_between_method_call_empty_parameter_list_parentheses
        - csharp_space_after_comma
        - csharp_space_after_dot
    - [Wrap options](#wrap-options)
        - csharp_preserve_single_line_statements
        - csharp_preserve_single_line_blocks

## .NET formatting settings

The formatting rules in this section apply to C# and Visual Basic code.

### Organize using directives

These formatting rules concern the sorting and display of `using` directives and `Imports` statements.

Example *.editorconfig* file:

```ini
# .NET formatting settings
[*.{cs,vb}]
dotnet_sort_system_directives_first = true
dotnet_separate_import_directive_groups = true
```

#### dotnet\_sort\_system\_directives_first

|||
|-|-|
| **Rule name** | dotnet_sort_system_directives_first |
| **Applicable languages** | C# and Visual Basic |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, sort System.* `using` directives alphabetically, and place them before other using directives.
- When this rule is set to **false**, do not place System.* `using` directives before other `using` directives.

Code examples:

```csharp
// dotnet_sort_system_directives_first = true
using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

// dotnet_sort_system_directives_first = false
using System.Collections.Generic;
using Octokit;
using System.Threading.Tasks;
```

#### dotnet\_separate\_import\_directive\_groups

|||
|-|-|
| **Rule name** | dotnet_separate_import_directive_groups |
| **Applicable languages** | C# and Visual Basic |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.5 |

- When this rule is set to **true**, place a blank line between `using` directive groups.
- When this rule is set to **false**, do not place a blank line between `using` directive groups.

Code examples:

```csharp
// dotnet_separate_import_directive_groups = true
using System.Collections.Generic;
using System.Threading.Tasks;

using Octokit;

// dotnet_separate_import_directive_groups = false
using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;
```

## C# formatting settings

The formatting rules in this section apply only to C# code.

### New-line options

These formatting rules concern the use of new lines to format code.

Example *.editorconfig* file:

```ini
# CSharp formatting settings:
[*.cs]
csharp_new_line_before_open_brace = methods, properties, control_blocks, types
csharp_new_line_before_else = true
csharp_new_line_before_catch = true
csharp_new_line_before_finally = true
csharp_new_line_before_members_in_object_initializers = true
csharp_new_line_before_members_in_anonymous_types = true
csharp_new_line_between_query_expression_clauses = true
```

#### csharp\_new\_line\_before\_open_brace

|||
|-|-|
| **Rule name** | csharp_new_line_before_open_brace |
| **Applicable languages** | C# |
| **Visual Studio default** | all |
| **Introduced version** | Visual Studio 2017 version 15.3 |

This rule concerns whether an open brace `{` should be placed on the same line as the preceding code, or on a new line. For this rule, you do not specify **true** or **false**. Instead you specify **all**, **none**, or one or more code elements such as **methods** or **properties**, to define when this rule should be applied. The complete list of allowable values is shown in the following table:

| Value | Description
| ------------- |:-------------|
| accessors, anonymous_methods, anonymous_types, control_blocks, events, indexers, lambdas, local_functions, methods, object_collection_array_initializers, properties, types.<br>(For multiple kinds, separate with ','). | Require braces to be on a new line for the specified code elements (also known as "Allman" style) |
| all | Require braces to be on a new line for all expressions ("Allman" style) |
| none | Require braces to be on the same line for all expressions ("K&R") |

Code examples:

```csharp
// csharp_new_line_before_open_brace = all
void MyMethod()
{
    if (...)
    {
        ...
    }
}

// csharp_new_line_before_open_brace = none
void MyMethod() {
    if (...) {
        ...
    }
}
```

#### csharp\_new\_line\_before_else

|||
|-|-|
| **Rule name** | csharp_new_line_before_else |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, place `else` statements on a new line.
- When this rule is set to **false**, place `else` statements on the same line.

Code examples:

```csharp
// csharp_new_line_before_else = true
if (...) {
    ...
}
else {
    ...
}

// csharp_new_line_before_else = false
if (...) {
    ...
} else {
    ...
}
```

#### csharp\_new\_line\_before_catch

|||
|-|-|
| **Rule name** | csharp_new_line_before_catch |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, place `catch` statements on a new line.
- When this rule is set to **false**, place `catch` statements on the same line.

Code examples:

```csharp
// csharp_new_line_before_catch = true
try {
    ...
}
catch (Exception e) {
    ...
}

// csharp_new_line_before_catch = false
try {
    ...
} catch (Exception e) {
    ...
}
```

#### csharp\_new\_line\_before_finally

|||
|-|-|
| **Rule name** | csharp_new_line_before_finally |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require `finally` statements to be on a new line after the closing brace.
- When this rule is set to **false**, require `finally` statements to be on the same line as the closing brace.

Code examples:

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

// csharp_new_line_before_finally = false
try {
    ...
} catch (Exception e) {
    ...
} finally {
    ...
}
```

#### csharp\_new\_line\_before\_members\_in\_object_initializers

|||
|-|-|
| **Rule name** | csharp_new_line_before_members_in_object_initializers |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require members of object initializers to be on separate lines.
- When this rule is set to **false**, require members of object initializers to be on the same line.

Code examples:

```csharp
// csharp_new_line_before_members_in_object_initializers = true
var z = new B()
{
    A = 3,
    B = 4
}

// csharp_new_line_before_members_in_object_initializers = false
var z = new B()
{
    A = 3, B = 4
}
```

#### csharp\_new\_line\_before\_members\_in\_anonymous_types

|||
|-|-|
| **Rule name** | csharp_new_line_before_members_in_anonymous_types |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require members of anonymous types to be on separate lines.
- When this rule is set to **false**, require members of anonymous types to be on the same line.

Code examples:

```csharp
// csharp_new_line_before_members_in_anonymous_types = true
var z = new
{
    A = 3,
    B = 4
}

// csharp_new_line_before_members_in_anonymous_types = false
var z = new
{
    A = 3, B = 4
}
```

#### csharp_new_line_between_query_expression_clauses

|||
|-|-|
| **Rule name** | csharp_new_line_between_query_expression_clauses |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require elements of query expression clauses to be on separate lines.
- When this rule is set to **false**, require elements of query expression clauses to be on the same line.

Code examples:

```csharp
// csharp_new_line_between_query_expression_clauses = true
var q = from a in e
        from b in e
        select a * b;

// csharp_new_line_between_query_expression_clauses = false
var q = from a in e from b in e
        select a * b;
```

### Indentation options

These formatting rules concern the use of indentation to format code.

Example *.editorconfig* file:

```ini
# CSharp formatting settings:
[*.cs]
csharp_indent_case_contents = true
csharp_indent_switch_labels = true
csharp_indent_labels = flush_left
```

#### csharp\_indent\_case_contents

|||
|-|-|
| **Rule name** | csharp_indent_case_contents |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, indent `switch` case contents.
- When this rule is set to **false**, do not indent `switch` case contents.

Code examples:

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

#### csharp\_indent\_switch_labels

|||
|-|-|
| **Rule name** | csharp_indent_switch_labels |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, indent `switch` labels.
- When this rule is set to **false**, do not indent `switch` labels.

Code examples:

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

#### csharp\_indent_labels

|||
|-|-|
| **Rule name** | csharp_indent_labels |
| **Applicable languages** | C# |
| **Visual Studio default** | no_change |
| **Introduced version** | Visual Studio 2017 version 15.3 |

This rule does not accept a **true** or **false** value; instead it accepts a value from the following table:

| Value | Description |
| ----- |:----------- |
| flush_left | Labels are placed at the leftmost column |
| one_less_than_current | Labels are placed at one less indent to the current context |
| no_change | Labels are placed at the same indent as the current context |

Code examples:

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

### Spacing options

These formatting rules concern the use of space characters to format code.

Example *.editorconfig* file:

```ini
# CSharp formatting settings:
[*.cs]
csharp_space_after_cast = true
csharp_space_after_keywords_in_control_flow_statements = true
csharp_space_between_method_declaration_parameter_list_parentheses = true
csharp_space_between_method_call_parameter_list_parentheses = true
csharp_space_between_parentheses = control_flow_statements, type_casts
csharp_space_before_colon_in_inheritance_clause = true
csharp_space_after_colon_in_inheritance_clause = true
csharp_space_around_binary_operators = before_and_after
csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
csharp_space_between_method_call_name_and_opening_parenthesis = false
csharp_space_between_method_call_empty_parameter_list_parentheses = false
csharp_space_after_comma = true
csharp_space_after_dot = false
```

#### csharp\_space\_after_cast

|||
|-|-|
| **Rule name** | csharp_space_after_cast |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require a space between a cast and the value.
- When this rule is set to **false**, require _no_ space between the cast and the value.

Code examples:

```csharp
// csharp_space_after_cast = true
int y = (int) x;

// csharp_space_after_cast = false
int y = (int)x;
```

#### csharp_space_after_keywords_in_control_flow_statements

|||
|-|-|
| **Rule name** | csharp_space_after_keywords_in_control_flow_statements |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, require a space after a keyword in a control flow statement such as a `for` loop.
- When this rule is set to **false**, require _no_ space after a keyword in a control flow statement such as a `for` loop.

Code examples:

```csharp
// csharp_space_after_keywords_in_control_flow_statements = true
for (int i;i<x;i++) { ... }

// csharp_space_after_keywords_in_control_flow_statements = false
for(int i;i<x;i++) { ... }
```

#### csharp_space_between_method_declaration_parameter_list_parentheses

|||
|-|-|
| **Rule name** | csharp_space_between_method_declaration_parameter_list_parentheses |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, place a space character after the opening parenthesis and before the closing parenthesis of a method declaration parameter list.
- When this rule is set to **false**, do not place space characters after the opening parenthesis and before the closing parenthesis of a  method declaration parameter list.

Code examples:

```csharp
// csharp_space_between_method_declaration_parameter_list_parentheses = true
void Bark( int x ) { ... }

// csharp_space_between_method_declaration_parameter_list_parentheses = false
void Bark(int x) { ... }
```

#### csharp_space_between_method_call_parameter_list_parentheses

|||
|-|-|
| **Rule name** | csharp_space_between_method_call_parameter_list_parentheses |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, place a space character after the opening parenthesis and before the closing parenthesis of a method call.
- When this rule is set to **false**, do not place space characters after the opening parenthesis and before the closing parenthesis of a method call.

Code examples:

```csharp
// csharp_space_between_method_call_parameter_list_parentheses = true
MyMethod( argument );

// csharp_space_between_method_call_parameter_list_parentheses = false
MyMethod(argument);
```

#### csharp_space_between_parentheses

|||
|-|-|
| **Rule name** | csharp_space_between_parentheses |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.3 |

This rule accepts one or more values from the following table:

| Value | Description |
| ----- |:------------|
| control_flow_statements | Place space between parentheses of control flow statements |
| expressions | Place space between parentheses of expressions |
| type_casts | Place space between parentheses in type casts |

If you omit this rule, or use a value other than `control_flow_statements`, `expressions`, or `type_casts`, the setting is not applied.

Code examples:

```csharp
// csharp_space_between_parentheses = control_flow_statements
for ( int i = 0; i < 10; i++ ) { }

// csharp_space_between_parentheses = expressions
var z = ( x * y ) - ( ( y - x ) * 3 );

// csharp_space_between_parentheses = type_casts
int y = ( int )x;
```

#### csharp\_space\_before\_colon\_in\_inheritance_clause

|||
|-|-|
| **Rule name** | csharp_space_before_colon_in_inheritance_clause |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.7 |

- When this rule is set to **true**, require a space before the colon for bases or interfaces in a type declaration.
- When this rule is set to **false**, require _no_ space before the colon for bases or interfaces in a type declaration.

Code examples:

```csharp
// csharp_space_before_colon_in_inheritance_clause = true
interface I
{

}

class C : I
{

}

// csharp_space_before_colon_in_inheritance_clause = false
interface I
{

}

class C: I
{

}
```

#### csharp\_space\_after\_colon\_in\_inheritance_clause

|||
|-|-|
| **Rule name** | csharp_space_after_colon_in_inheritance_clause |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.7 |

- When this rule is set to **true**, require a space after the colon for bases or interfaces in a type declaration.
- When this rule is set to **false**, require _no_ space after the colon for bases or interfaces in a type declaration.

Code examples:

```csharp
// csharp_space_after_colon_in_inheritance_clause = true
interface I
{

}

class C : I
{

}

// csharp_space_after_colon_in_inheritance_clause = false
interface I
{

}

class C :I
{

}
```

#### csharp\_space\_around\_binary_operators

|||
|-|-|
| **Rule name** | csharp_space_around_binary_operators |
| **Applicable languages** | C# |
| **Visual Studio default** | before_and_after |
| **Introduced version** | Visual Studio 2017 version 15.7 |

This rule accepts one value from the following table:

| Value | Description |
| ----- |:------------|
| before_and_after | Insert space before and after the binary operator |
| none | Remove spaces before and after the binary operator |
| ignore | Ignore spaces around binary operators |

If you omit this rule, or use a value other than `before_and_after`, `none`, or `ignore`, the setting is not applied.

Code examples:

```csharp
// csharp_space_around_binary_operators = before_and_after
return x * (x - y);

// csharp_space_around_binary_operators = none
return x*(x-y);

// csharp_space_around_binary_operators = ignore
return x  *  (x-y);
```

#### csharp_space_between_method_declaration_empty_parameter_list_parentheses

|||
|-|-|
| **Rule name** | csharp_space_between_method_declaration_empty_parameter_list_parentheses |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.7 |

- When this rule is set to **true**, insert space within empty parameter list parentheses for a method declaration.
- When this rule is set to **false**, remove space within empty parameter list parentheses for a method declaration.

Code examples:

```csharp
// csharp_space_between_method_declaration_empty_parameter_list_parentheses = true
void Goo( )
{
    Goo(1);
}

void Goo(int x)
{
    Goo();
}

// csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
void Goo()
{
    Goo(1);
}

void Goo(int x)
{
    Goo();
}
```

#### csharp_space_between_method_call_name_and_opening_parenthesis

|||
|-|-|
| **Rule name** | csharp_space_between_method_call_name_and_opening_parenthesis |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.7 |

- When this rule is set to **true**, insert space between method call name and opening parenthesis.
- When this rule is set to **false**, remove space between method call name and opening parenthesis.

Code examples:

```csharp
// csharp_space_between_method_call_name_and_opening_parenthesis = true
void Goo()
{
    Goo (1);
}

void Goo(int x)
{
    Goo ();
}

// csharp_space_between_method_call_name_and_opening_parenthesis = false
void Goo()
{
    Goo(1);
}

void Goo(int x)
{
    Goo();
}
```

#### csharp_space_between_method_call_empty_parameter_list_parentheses

|||
|-|-|
| **Rule name** | csharp_space_between_method_call_empty_parameter_list_parentheses |
| **Applicable languages** | C# |
| **Visual Studio default** | false |
| **Introduced version** | Visual Studio 2017 version 15.7 |

- When this rule is set to **true**, insert space within empty argument list parentheses.
- When this rule is set to **false**, remove space within empty argument list parentheses.

Code examples:

```csharp
// csharp_space_between_method_call_empty_parameter_list_parentheses = true
void Goo()
{
    Goo(1);
}

void Goo(int x)
{
    Goo( );
}

// csharp_space_between_method_call_empty_parameter_list_parentheses = false
void Goo()
{
    Goo(1);
}

void Goo(int x)
{
    Goo();
}
```

#### csharp_space_after_comma

|||
|-|-|
| **Rule name** | csharp_space_after_comma |
| **Applicable languages** | C# |
| **Visual Studio default** | true |

- When this rule is set to **true**, insert space after a comma.
- When this rule is set to **false**, remove space after a comma.

Code examples:

```csharp
// csharp_space_after_comma = true
int[] x = new int[] { 1, 2, 3, 4, 5 };

// csharp_space_after_comma = false
int[] x = new int[] { 1,2,3,4,5 }
```

#### csharp_space_after_dot

|||
|-|-|
| **Rule name** | csharp_space_after_dot |
| **Applicable languages** | C# |
| **Visual Studio default** | false |

- When this rule is set to **true**, insert space after a dot.
- When this rule is set to **false**, remove space after a dot.

Code examples:

```csharp
// csharp_space_after_dot = true
this. Goo();

// csharp_space_after_dot = false
this.Goo();
```

### Wrap options

These formatting rules concern the use of single lines versus separate lines for statements and code blocks.

Example *.editorconfig* file:

```ini
# CSharp formatting settings:
[*.cs]
csharp_preserve_single_line_statements = true
csharp_preserve_single_line_blocks = true
```

#### csharp_preserve_single_line_statements

|||
|-|-|
| **Rule name** | csharp_preserve_single_line_statements |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, leave statements and member declarations on the same line.
- When this rule is set to **false**, leave statements and member declarations on different lines.

Code examples:

```csharp
//csharp_preserve_single_line_statements = true
int i = 0; string name = "John";

//csharp_preserve_single_line_statements = false
int i = 0;
string name = "John";
```

#### csharp_preserve_single_line_blocks

|||
|-|-|
| **Rule name** | csharp_preserve_single_line_blocks |
| **Applicable languages** | C# |
| **Visual Studio default** | true |
| **Introduced version** | Visual Studio 2017 version 15.3 |

- When this rule is set to **true**, leave code block on single line.
- When this rule is set to **false**, leave code block on separate lines.

Code examples:

```csharp
//csharp_preserve_single_line_blocks = true
public int Foo { get; set; }

//csharp_preserve_single_line_blocks = false
public int MyProperty
{
    get; set;
}
```

## See also

- [Language conventions](editorconfig-language-conventions.md)
- [Naming conventions](editorconfig-naming-conventions.md)
- [.NET coding convention settings for EditorConfig](editorconfig-code-style-settings-reference.md)