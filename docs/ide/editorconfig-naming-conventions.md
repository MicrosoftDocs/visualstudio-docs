---
title: ".NET Naming Conventions For EditorConfig | Microsoft Docs"
ms.custom: ""
ms.date: "11/20/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
 - "naming conventions [EditorConfig]"
 - "EditorConfig naming conventions"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology:
  - "vs-ide-general"
---
# Naming Conventions for EditorConfig

Naming conventions concern the naming of code elements such as classes, properties, and methods. For example, you can specify that public members must be capitalized, or that asynchronous methods must end in "Async". You can enforce these rules by specifying them in an [.editorconfig file](../ide/create-portable-custom-editor-options.md).

Naming conventions should be ordered from most-specific to least-specific in the .editorconfig file. The first rule encountered that can be applied is the only rule that is applied.

For each naming convention rule, identified by **<namingRuleTitle\>**, you must specify the symbols it applies to, a naming style, and a severity for enforcing the convention:

`dotnet_naming_rule.<namingRuleTitle>.symbols = <symbolTitle>`
`dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>`
`dotnet_naming_rule.<namingRuleTitle>.severity = none|suggestion|warning|error`

## Symbols

First, we must identify a group of symbols to apply the naming rule to. Describe the group of symbols by replacing the **<symbolTitle\>** value in the following property:

`dotnet_naming_rule.<namingRuleTitle>.symbols = <symbolTitle>`

Replace **<namingRuleTitle\>** in the property name with the title you chose previously.

You'll use the **<symbolTitle\>** value you choose in the three property names that describe which symbols the rule is applied to (kinds of symbol, accessibility levels, and modifiers).

### Kinds of symbols

Specify a property name in the format `dotnet_naming_symbols.<symbolTitle>.applicable_kinds` to describe the kind of symbols to apply the naming rule to. You can specify multiple values by separating them with a comma (`,`). The allowable values are listed below:

- \* (use this value to specify all symbols)
- class
- struct
- interface
- enum
- property
- method
- field
- event
- delegate
- parameter

### Accessibility levels of symbols

Specify a property name in the format `dotnet_naming_symbols.<symbolTitle>.applicable_accessibilities` to describe the accessibility levels of the symbols you want to apply the naming rule to. You can specify multiple values by separating them with a comma (`,`). The allowable values are listed below:

- \* (use this value to specify all accessibility levels)
- public
- internal or friend
- private
- protected
- protected\_internal or protected_friend

### Symbol modifiers

Specify a property name in the format `dotnet_naming_symbols.<symbolTitle>.required_modifiers` to describe the modifiers of the symbols you want to apply the naming rule to. You can specify multiple values by separating them with a comma (`,`). The allowable values are listed below:

- \* (use this value to specify all modifiers)
- abstract or must_inherit
- async
- const
- readonly
- static or shared

## Style

Now that we've identified the group of symbols to apply the naming rule to, we must describe the naming style. You can specify that the name has a certain prefix or a certain suffix, or that individual words in the name are separated with a certain character. You can also specify a capitalization style.

Give the style a name of your choosing by replacing the <styleTitle\> value in the following property:

`dotnet_naming_rule.<namingRuleTitle>.style = <styleTitle>`

Replace **<namingRuleTitle\>** in the property name with the title you chose previously.

You'll use the **<styleTitle\>** value you choose in the property names that describe the naming style.

### Require a prefix

To specify that symbol names must begin with a certain prefix, use this property:

`dotnet_naming_style.<styleTitle>.required_prefix = <characters that must appear at the beginning of the identifier\>`

### Require a suffix

To specify that symbol names must end with a certain suffix, use this property:

`dotnet_naming_style.<styleTitle>.required_suffix = <characters that must appear at the end of the identifier\>`

### Require a certain word separator

To specify that individual words in symbol names must be separated with a certain character, use this property:

`dotnet_naming_style.<styleTitle>.word_separator = <Required character between words in the identifier\>`

### Require a capitalization style

To specify a particular capitalization style for symbol names, use this property:

`dotnet_naming_style.\<styleTitle\>.capitalization`

The allowable values for this property are:

- pascal_case
- camel_case
- first\_word_upper
- all\_upper
- all_lower

> [!NOTE]
> You must specify a capitalization style as part of your naming style, otherwise your naming style might be ignored.

## Severity

We've identified a naming style and the group of symbols we want it applied to. Now we'll specify the degree to which we want the naming style enforced by using the following property:

`dotnet_naming_rule.<namingRuleTitle>.severity`

The following table shows the allowable severity values, and what they mean:

Severity | Effect
------------ | -------------
none or silent | When this style is not being followed, do not show anything to the user; however, code generation features generate new code in this style.
suggestion | When this style is not being followed, show it to the user as a suggestion, as underlying dots on the first two characters. It has no effect at compile time.
warning | When this style is not being followed, show a compiler warning.
error | When this style is not being followed, show a compiler error.

## Example .editorconfig file with naming conventions

Finally, let's look at an example .editorconfig file that contains two naming conventions. Notice that the "public_symbols" naming convention specifies multiple kinds of symbol to apply the rule to.

```
# Public members must be capitalized
[*.{cs,vb}]
dotnet_naming_rule.public_members_must_be_capitalized.severity = warning
dotnet_naming_rule.public_members_must_be_capitalized.symbols  = public_symbols
dotnet_naming_rule.public_members_must_be_capitalized.style    = first_word_upper_case_style

dotnet_naming_symbols.public_symbols.applicable_kinds   = property,method,field,event,delegate
dotnet_naming_symbols.public_symbols.required_modifiers = public

dotnet_naming_style.first_word_upper_case_style.capitalization = first_word_upper

# Asynchronous methods must end in "Async"
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

[.NET language and formatting conventions](../ide/editorconfig-code-style-settings-reference.md)  
[Create portable custom editor options](../ide/create-portable-custom-editor-options.md)