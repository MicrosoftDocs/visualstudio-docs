---
title: "C++ EditorConfig formatting conventions"
titleSuffix: ""
description: "Learn about how to use EditorConfig to format C++ code in Visual Studio."
ms.date: 08/22/2024
author: jureid
ms.author: ghogen 
manager: mijacobs
ms.subservice: general-ide
dev_langs:
 - CPP

ms.topic: reference
---
# C++ EditorConfig formatting conventions

You can add EditorConfig files to your project to configure C++ formatting to enforce a consistent code style for everyone contributing to the project. Both Visual Studio and Visual Studio Code have built-in [EditorConfig](https://editorconfig.org/) support for each of the global Visual Studio C++ formatting settings. The EditorConfig settings are stored in an `.editorconfig` file. When that file is present in your project, it takes precedence over the Visual Studio formatting settings.

This document lists all the EditorConfig C++ formatting settings supported by Visual Studio and Visual Studio Code.

For more information about:

- Using an EditorConfig file in Visual Studio, see [Define consistent coding styles with EditorConfig](create-portable-custom-editor-options.md).
- Manually create an EditorConfig file based on clang formatting settings, see [clangformat](https://clang.llvm.org/docs/ClangFormat.html). Rename that file `.editorconfig` and save it in your project.

## C++ formatting conventions

C++ formatting EditorConfig settings are prefixed with `cpp_`. Here's an example of what an `.editorconfig` file might look like:

```
[*.{c++,cc,cpp,cxx,h,h++,hh,hpp,hxx,inl,ipp,tlh,tli}]

cpp_indent_case_contents_when_block = true
cpp_new_line_before_open_brace_namespace = same_line
```

The rest of this document lists all the EditorConfig C++ formatting settings supported by Visual Studio and VS Code.

### Indentation settings

**Indent braces**

- Name: `cpp_indent_braces`
- Values: `true`, `false`

**Indent each line relatively to**

- Name: `cpp_indent_multi_line_relative_to`
- Values:
  - `outermost_parenthesis` - When a new line is typed, it's indented relatively to the outermost open parenthesis.
  - `innermost_parenthesis` - When a new line is typed, it's indented relatively to the innermost open parenthesis.
  - `statement_begin` - When a new line is typed, it's indented relatively to the beginning of the current statement.

**Within parentheses, align new lines when I type them**

- Name: `cpp_indent_within_parentheses`
- Values:
  - `align_to_parenthesis` - Align contents to opening parenthesis.
  - `indent` - Indent new lines.

**In existing code, do not use the setting for alignment of new lines within parentheses**

- Name: `cpp_indent_preserve_within_parentheses`
- Values: `true`, `false`

**Indent case contents**

- Name: `cpp_indent_case_contents`
- Values: `true`, `false`

**Indent case labels**

- Name: `cpp_indent_case_labels`
- Values: `true`, `false`

**Indent braces following a case statement**

- Name: `cpp_indent_case_contents_when_block`
- Values: `true`, `false`

**Indent braces of lambdas used as parameters**

- Name: `cpp_indent_lambda_braces_when_parameter`
- Values: `true`, `false`

**Position of goto labels**

- Name: `cpp_indent_goto_labels`
- Values:
  - `one_left` - One indent to the left
  - `leftmost_column` - Move to the leftmost column
  - `none` - Leave indented

**Position of preprocessor directives**

- Name: `cpp_indent_preprocessor`
- Values:
  - `one_left` - One indent to the left
  - `leftmost_column` - Move to the leftmost column
  - `none` - Leave indented

**Indent access specifiers**

- Name: `cpp_indent_access_specifiers`
- Values: `true`, `false`

**Indent namespace contents**

- Name: `cpp_indent_namespace_contents`
- Values: `true`, `false`

**Preserve indentation of comments**

- Name: `cpp_indent_preserve_comments`
- Values: `true`, `false`

### Newline settings

**Position of open braces for namespaces**

- Name: `cpp_new_line_before_open_brace_namespace`
- Values:
  - `new_line` - Move to a new line
  - `same_line` - Keep on the same line, but add a space before
  - `ignore` - Don't automatically reposition

**Position of open braces for types**

- Name: `cpp_new_line_before_open_brace_type`
- Values:
  - `new_line` - Move to a new line
  - `same_line` - Keep on the same line, but add a space before
  - `ignore` - Don't automatically reposition

**Position of open braces for functions**

- Name: `cpp_new_line_before_open_brace_function`
- Values:
  - `new_line` - Move to a new line
  - `same_line` - Keep on the same line, but add a space before
  - `ignore` - Don't automatically reposition

**Position of open braces for control blocks**

- Name: `cpp_new_line_before_open_brace_block`
- Values:
  - `new_line` - Move to a new line
  - `same_line` - Keep on the same line, but add a space before
  - `ignore` - Don't automatically reposition

**Position of open braces for lambdas**

- Name: `cpp_new_line_before_open_brace_lambda`
- Values:
  - `new_line` - Move to a new line
  - `same_line` - Keep on the same line, but add a space before
  - `ignore` - Don't automatically reposition
 
**Place scope braces on separate lines**

- Name: `cpp_new_line_scope_braces_on_separate_lines`
- Values: `true`, `false`

**For empty types, move closing braces to the same line as opening braces**

- Name: `cpp_new_line_close_brace_same_line_empty_type`
- Values: `true`, `false`

**For empty function bodies, move closing braces to the same line as opening braces**

- Name: `cpp_new_line_close_brace_same_line_empty_function`
- Values: `true`, `false`

**Place 'catch' and similar keywords on a new line**

- Name: `cpp_new_line_before_catch`
- Values: `true`, `false`

**Place 'else' on a new line**

- Name: `cpp_new_line_before_else`
- Values: `true`, `false`

**Place 'while' in a do-while loop on a new line**

- Name: `cpp_new_line_before_while_in_do_while`
- Values: `true`, `false`

### Spacing settings

**Spacing between function names and opening parentheses of argument lists**

- Name: `cpp_space_before_function_open_parenthesis`
- Values:
  - `insert` - Insert a space
  - `remove` - Remove spaces
  - `ignore` - Don't change spaces

**Insert space within parentheses of an argument list**

- Name `cpp_space_within_parameter_list_parentheses`
Values: `true`, `false`

**Insert space between parentheses when argument list is empty**

- Name: `cpp_space_between_empty_parameter_list_parentheses`
- Values: `true`, `false`

**Insert space between keyword and opening parenthesis in control flow statements**

- Name: `cpp_space_after_keywords_in_control_flow_statements`
- Values: `true`, `false`

**Insert space within parentheses of a control statement**

- Name: `cpp_space_within_control_flow_statement_parentheses`
- Values: `true`, `false`

**Insert space before opening parenthesis of lambda argument lists**

- Name: `cpp_space_before_lambda_open_parenthesis`
- Values: `true`, `false`

**Insert space within parentheses of a C-style cast**

- Name: `cpp_space_within_cast_parentheses`
- Values: `true`, `false`

**Insert space after closing parenthesis of C-style cast**

- Name: `cpp_space_after_cast_close_parenthesis`
- Values: `true`, `false`

**Insert space within parentheses of a parenthesized expression**

- Name: `cpp_space_within_expression_parentheses`
- Values: `true`, `false`

**Insert space before opening brace of blocks**

- Name: `cpp_space_before_block_open_brace`
- Values: `true`, `false`

**Insert space between empty braces**

- Name: `cpp_space_between_empty_braces`
- Values: `true`, `false`

**Insert space before opening brace of uniform initialization and initializer lists**

- Name: `cpp_space_before_initializer_list_open_brace`
- Values: `true`, `false`

**Insert space within braces of uniform initialization and initializer lists**

- Name: `cpp_space_within_initializer_list_braces`
- Values: `true`, `false`

**Preserve spaces inside uniform initialization and initializer lists**

- Name: `cpp_space_preserve_in_initializer_list`
- Values: `true`, `false`

**Insert space before opening square brackets**

- Name: `cpp_space_before_open_square_bracket`
- Values: `true`, `false`

**Insert space within square bracket**

- Name: `cpp_space_within_square_brackets`
- Values: `true`, `false`

**Insert space before empty square brackets**

- Name: `cpp_space_before_empty_square_brackets`
- Values: `true`, `false`

**Insert space between empty square brackets**

- Name: `cpp_space_between_empty_square_brackets`
- Values: `true`, `false`

**Group square brackets for multi-dimensional arrays together**

- Name: `cpp_space_group_square_brackets`
- Values: `true`, `false`

**Insert space within square brackets for lambdas**

- Name: `cpp_space_within_lambda_brackets`
- Values: `true`, `false`

**SpaceBetweenEmptyLambdaBrackets**

- Name: `cpp_space_between_empty_lambda_brackets`
- Values: `true`, `false`

**Insert space before commas**

- Name: `cpp_space_before_comma`
- Values: `true`, `false`

**Insert space after commas**

- Name: `cpp_space_after_comma`
- Values: `true`, `false`

**Remove spaces before and after member operators**

- Name: `cpp_space_remove_around_member_operators`
- Values: `true`, `false`

**Insert space before colon for base in type declarations**

- Name: `cpp_space_before_inheritance_colon`
- Values: `true`, `false`

**Insert space before colon for constructors**

- Name: `cpp_space_before_constructor_colon`
- Values: `true`, `false`

**Remove space before semicolons**

- Name: `cpp_space_remove_before_semicolon`
- Values: `true`, `false`

**Insert space after semicolons**

- Name: `cpp_space_after_semicolon`
- Values: `true`, `false`

**Remove spaces between unary operators and their operands**

- Name: `cpp_space_remove_around_unary_operator`
- Values: `true`, `false`

**Spacing for binary operators**

- Name: `cpp_space_around_binary_operator`
- Values:
  - `insert` - Insert spaces before and after binary operators.
  - `remove` - Remove spaces around binary operators.
  - `ignore` - Don't change spaces around binary operators.

**Spacing for assignment operators**

- Name: `cpp_space_around_assignment_operator`
- Values:
  - `insert` - Insert spaces around assignment operators.
  - `remove` - Remove spaces around assignment operators.
  - `ignore` - Don't change spaces around assignment operators.

**Pointer/reference alignment**

- Name: `cpp_space_pointer_reference_alignment`
- Values:
  - `left` - Align left.
  - `center` - Align center.
  - `right` - Align right.
  - `ignore` - Leave unchanged.

**Spacing for conditional operators**

- Name: `cpp_space_around_ternary_operator`
- Values:
  - `insert` - Insert spaces around conditional operators.
  - `remove` - Remove spaces around conditional operators.
  - `ignore` - Don't change spaces around conditional operators.

### Wrapping options

**Wrapping options for blocks**

- Name: `cpp_wrap_preserve_blocks`
- Values:
  - `one_liners` - Don't wrap one-line code blocks.
  - `all_one_line_scopes` - Don't wrap code blocks where opening and closing braces are on the next line.
  - `never` - Always apply New Lines settings for blocks.

## See also

- [EditorConfig.org](https://editorconfig.org/)
- [Supporting EditorConfig for a language service](../extensibility/supporting-editorconfig.md)
- [Features of the code editor](writing-code-in-the-code-and-text-editor.md)
