---
title: FxCop analyzer configuration options
ms.date: 09/23/2019
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Rule scope options for FxCop analyzers

Some FxCop analyzer rules let you refine which parts of your codebase they should be applied to. This page lists the available scope configuration options, their allowable values, and the rules to which they can be applied. To use these options, specify them in an [EditorConfig file](../ide/create-portable-custom-editor-options.md#add-an-editorconfig-file-to-a-project).

These configuration options are available starting in version 2.6.3 of the [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers) NuGet package.

> [!TIP]
> To see the full list of options that are available for a given version of the FxCopAnalyzers package, look at the *Analyzer Configuration.md* file in the *documentation* folder for the package. The file is located at *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.fxcopanalyzers\\\<version\>\documentation\Analyzer Configuration.md*. This configuration documentation file is included with each version of the package, starting in version 2.6.5. Here's an example of how an option is documented in the *Analyzer Configuration.md* file:
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

