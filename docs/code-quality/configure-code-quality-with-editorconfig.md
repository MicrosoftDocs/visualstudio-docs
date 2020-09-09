---
title: Configure .NET code quality analyzers using editorconfig
ms.date: 09/01/2020
ms.topic: conceptual
helpviewer_keywords:
- .NET analyzers
- FxCop analyzers, configuring
- code quality
author: mikadumont
ms.author: midumont
manager: jillfra
ms.workload:
- dotnet
---
# Configure .NET code quality analysis with EditorConfig

Each code quality analyzer (those whose rule IDs start with `CA`), can be refined to apply to the parts of your codebase through configurable options. Each option is specified by adding a key-value pair to an [EditorConfig](https://editorconfig.org) file. A configuration file can be specific to a file, project, solution, or the entire repo.

> [!TIP]
> Add an .editorconfig file to your project by right-clicking the project in **Solution Explorer** and selecting **Add** > **New Item**. In the **Add New Item** window, enter **editorconfig** in the search box. Select the **editorconfig File (default)** template and choose **Add**.
>
> ![Add editorconfig file to project in Visual Studio](media/add-editorconfig-file.png)

::: moniker range=">=vs-2019"

For information about configuring a rule's severity (for example, whether it's an error or a warning), see [Set rule severity in an EditorConfig file](use-roslyn-analyzers.md#set-rule-severity-in-an-editorconfig-file). Or, you can choose one of the built-in [EditorConfig files or rule sets](analyzer-rule-sets.md) to quickly enable or disable a category of rules.

::: moniker-end

The remainder of this article discusses general syntax for the options that refine where .NET code-quality analyzers are applied.

## Option scopes

Each refining option can be configured for all rules, for a category of rules (for example, Security or Design), or for a specific rule.

### All rules

The syntax for configuring an option for *all* rules is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.OptionName = OptionValue | `dotnet_code_quality.api_surface = public` |

### Category of rules

The syntax for configuring an option for a *category* of rules (such as Naming, Design, or Performance) is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.RuleCategory.OptionName = OptionValue | `dotnet_code_quality.Naming.api_surface = public` |

### Specific rule

The syntax for configuring an option for a *specific* rule is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.RuleId.OptionName = OptionValue | `dotnet_code_quality.CA1040.api_surface = public` |

## Enabling Editorconfig based configuration

EditorConfig-based analyzer configuration can be enabled for the following scopes:

- Specific document(s)
- Specific folder(s)
- Specific project(s)
- Specific solution(s)
- Entire repo

To enable configuration, add an *.editorconfig* file with the options in the corresponding directory. This file can also contain EditorConfig-based diagnostic severity configuration entries. See [here](use-roslyn-analyzers.md#rule-severity) for more details.

## Enable a category of rules

Analyzer packages may include predefined [EditorConfig](use-roslyn-analyzers.md#rule-severity) and/or [rule set](using-rule-sets-to-group-code-analysis-rules.md) files that make it quick and easy to enable a category of rules, such as security or design rules. The [Microsoft.CodeAnalysis.NetAnalyzers](https://github.com/dotnet/roslyn-analyzers#microsoftcodeanalysisnetanalyzers) NuGet analyzer package includes both EditorConfig files and rule sets. By enabling a specific category of rules, you can identify targeted issues and specific conditions.

> [!NOTE]
> Enabling analyzer rules and setting their severity by using an EditorConfig file is supported starting in Visual Studio 2019 version 16.3.

The NetAnalyzers NuGet package includes predefined EditorConfig files and rule sets for the following rule categories:

- All rules
- Dataflow
- Design
- Documentation
- Globalization
- Interoperability
- Maintainability
- Naming
- Performance
- Ported from FxCop
- Reliability
- Security
- Usage

Each of those categories of rules has an EditorConfig or rule set file to:

- Enable all the rules in the category (and disable all other rules)
- Use each rule's default severity and enabled by default setting (and disable all other rules)

> [!TIP]
> The "all rules" category has an additional EditorConfig or rule set file to disable all rules. Use this file to quickly get rid of any analyzer warnings or errors in a project.

> [!TIP]
> If you're migrating from legacy "FxCop" analysis to .NET Compiler Platform-based code analysis, the EditorConfig and rule set files enable you to continue using similar rule configurations to [those you used previously](rule-set-reference.md).

## Predefined EditorConfig files

The predefined EditorConfig files for the Microsoft.CodeAnalysis.NetAnalyzers analyzer package are located in the *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.netanalyzers\\\<version\>\editorconfig* directory. For example, the EditorConfig file to enable all security rules is located at *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.netanalyzers\\\<version\>\editorconfig\SecurityRulesEnabled\\.editorconfig*.

Copy the chosen .editorconfig file to your project's root directory.

## Predefined rule sets

The predefined rule set files for the Microsoft.CodeAnalysis.NetAnalyzers analyzer package are located in the *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.netanalyzers\\\<version\>\rulesets* directory. For example, the rule set file to enable all security rules is located at *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.netanalyzers\\\<version\>\rulesets\SecurityRulesEnabled.ruleset*.

Copy one or more of the rule sets and paste them in the directory that contains your Visual Studio project or directly into **Solution Explorer**.

You can also [customize a predefined rule set](how-to-create-a-custom-rule-set.md) to your preference. For example, you can change the severity of one or more rules so that violations appear as errors or warnings in the **Error List**.


# Rule scope options for .NET code-quality analyzers

You can specify options in an [EditorConfig file](../ide/create-portable-custom-editor-options.md#add-an-editorconfig-file-to-a-project). For example, you can specify the following options.

> [!TIP]
> To see the full list of options that are available, see this [Analyzer Configuration.md file](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md). Here's an example of how an option is documented in the *Analyzer Configuration.md* file:
>
> Option Name: `sufficient_IterationCount_for_weak_KDF_algorithm`\
> Option Values: integral values\
> Default Value: Specific to each configurable rule ('100000' by default for most rules)\
> Example: `dotnet_code_quality.CA5387.sufficient_IterationCount_for_weak_KDF_algorithm = 100000`

## api_surface

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Which part of the API surface to analyze | `public`<br/>`internal` or `friend`<br/>`private`<br/>`all`<br/><br/>Separate multiple values with a comma (,) | `public` | [CA1000](ca1000.md) [CA1003](ca1003.md) [CA1008](ca1008.md) [CA1010](ca1010.md)<br/>[CA1012](ca1012.md) [CA1024](ca1024.md) [CA1027](ca1027.md) [CA1028](ca1028.md)<br/>[CA1030](ca1030.md) [CA1036](ca1036.md) [CA1040](ca1040.md) [CA1041](ca1041.md)<br/>[CA1043](ca1043.md) [CA1044](ca1044.md) [CA1051](ca1051.md) [CA1052](ca1052.md)<br/>[CA1054](ca1054.md) [CA1055](ca1055.md) [CA1056](ca1056.md) [CA1058](ca1058.md)<br/>[CA1063](ca1063.md) [CA1708](ca1708.md) [CA1710](ca1710.md) [CA1711](ca1711.md)<br/>[CA1714](ca1714.md) [CA1715](ca1715.md) [CA1716](ca1716.md) [CA1717](ca1717.md)<br/>[CA1720](ca1720.md) [CA1721](ca1721.md) [CA1725](ca1725.md) [CA1801](ca1801.md)<br/>[CA1802](ca1802.md) [CA1815](ca1815.md) [CA1819](ca1819.md) [CA2217](ca2217.md)<br/>[CA2225](ca2225.md) [CA2226](ca2226.md) [CA2231](ca2231.md) [CA2234](ca2234.md)<br/>|

## exclude_async_void_methods

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Whether to ignore asynchronous methods that don't return a value | `true`<br/>`false` | `false` | [CA2007](ca2007.md) |

> [!NOTE]
> In version 2.6.3 and earlier of the analyzer package, this option was named `skip_async_void_methods`.

## exclude_single_letter_type_parameters

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Whether to exclude single-character [type parameters](/dotnet/csharp/programming-guide/generics/generic-type-parameters) from the rule, for example, `S` in `Collection<S>` | `true`<br/>`false` | `false` | [CA1715](ca1715.md) |

> [!NOTE]
> In version 2.6.3 and earlier of the analyzer package, this option was named `allow_single_letter_type_parameters`.

## output_kind

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Specifies that code in a project that generates this type of assembly should be analyzed | One or more fields of the <xref:Microsoft.CodeAnalysis.OutputKind> enumeration<br/><br/>Separate multiple values with a comma (,) | All output kinds | [CA2007](ca2007.md) |

## required_modifiers

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Specifies the required modifiers for APIs that should be analyzed | One or more values from the below allowed modifiers table<br/><br/>Separate multiple values with a comma (,) | Depends on each rule | [CA1802](ca1802.md) |

| Allowed Modifier | Summary |
| --- | --- |
| `none` | No modifier requirement |
| `static` or `Shared` | Must be declared as 'static' ('Shared' in Visual Basic) |
| `const` | Must be declared as 'const' |
| `readonly` | Must be declared as 'readonly' |
| `abstract` | Must be declared as 'abstract' |
| `virtual` | Must be declared as 'virtual' |
| `override` | Must be declared as 'override' |
| `sealed` | Must be declared as 'sealed' |
| `extern` | Must be declared as 'extern' |
| `async` | Must be declared as 'async' |

## exclude_extension_method_this_parameter

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Whether to skip analysis for the `this` parameter of extension methods | `true`<br/>`false` | `false` | [CA1062](ca1062.md) |

## null_check_validation_methods

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Names of null check validation methods that validate arguments passed to the method are non-null | Allowed method name formats (separated by `|`):<br/> - Method name only (includes all methods with the name, regardless of the containing type or namespace)<br/> - Fully qualified names in the symbol's [documentation ID format](https://github.com/dotnet/csharplang/blob/master/spec/documentation-comments.md#id-string-format), with an optional `M:` prefix | None | [CA1062](ca1062.md) |

## additional_string_formatting_methods

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Names of additional string formatting methods | Allowed method name formats (separated by `|`):<br/> - Method name only (includes all methods with the name, regardless of the containing type or namespace)<br/> - Fully qualified names in the symbol's [documentation ID format](https://github.com/dotnet/csharplang/blob/master/spec/documentation-comments.md#id-string-format), with an optional `M:` prefix | None | [CA2241](ca2241.md) |

## excluded_type_names_with_derived_types

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Names of types, such that the type and all its derived types are excluded for analysis | Allowed symbol name formats (separated by `|`):<br/> - Type name only (includes all types with the name, regardless of the containing type or namespace)<br/> - Fully qualified names in the symbol's [documentation ID format](https://github.com/dotnet/csharplang/blob/master/spec/documentation-comments.md#id-string-format), with an optional `T:` prefix | None | [CA1303](ca1303.md) |

## excluded_symbol_names

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Names of symbols that are excluded for analysis | Allowed symbol name formats (separated by `|`):<br/> - Symbol name only (includes all symbols with the name, regardless of the containing type or namespace)<br/> - Fully qualified names in the symbol's [documentation ID format](https://github.com/dotnet/csharplang/blob/master/spec/documentation-comments.md#id-string-format). Each symbol name requires a symbol kind prefix, such as "M:" prefix for methods, "T:" prefix for types, "N:" prefix for namespaces, etc.<br/> - `.ctor` for constructors and `.cctor` for static constructors | None | [CA1062](ca1062.md) [CA1303](ca1303.md) [CA2000](ca2000.md) [CA2100](ca2100.md) [CA2301](ca2301.md) [CA2302](ca2302.md)<br/>[CA2311](ca2311.md) [CA2312](ca2312.md) [CA2321](ca2321.md) [CA2322](ca2322.md) [CA2327](ca2327.md) [CA2328](ca2328.md)<br/>[CA2329](ca2329.md) [CA2330](ca2330.md) [CA3001](ca3001.md) [CA3002](ca3002.md) [CA3003](ca3003.md) [CA3004](ca3004.md)<br/>[CA3005](ca3005.md) [CA3006](ca3006.md) [CA3007](ca3007.md) [CA3008](ca3008.md) [CA3009](ca3009.md) [CA3010](ca3010.md)<br/>[CA3011](ca3011.md) [CA3012](ca3012.md) [CA5361](ca5361.md) CA5376 CA5377 [CA5378](ca5378.md)<br/>[CA5380](ca5380.md) [CA5381](ca5381.md) CA5382 CA5383 CA5384 CA5387<br/>CA5388 [CA5389](ca5389.md) CA5390 |

## disallowed_symbol_names

| Description | Allowable values | Default value | Configurable rules |
| - | - | - | - |
| Names of symbols that are disallowed in the context of the analysis | Allowed symbol name formats (separated by `|`):<br/> - Symbol name only (includes all symbols with the name, regardless of the containing type or namespace)<br/> - Fully qualified names in the symbol's [documentation ID format](https://github.com/dotnet/csharplang/blob/master/spec/documentation-comments.md#id-string-format). Each symbol name requires a symbol kind prefix, such as "M:" prefix for methods, "T:" prefix for types, "N:" prefix for namespaces, etc.<br/> - `.ctor` for constructors and `.cctor` for static constructors | None | [CA1031](ca1031.md) |

## See also

- [Analyzer configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md)
- [.NET coding conventions for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
