---
title: Configure FxCop analyzers using editorconfig or rulesets
ms.date: 03/06/2019
ms.topic: conceptual
helpviewer_keywords:
  - "FxCop analyzers, configuring"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Configure FxCop analyzers

When you configure code analyzers, you define which rules to enable, the severity of rule violations, and to which parts of your code they should apply (for example, only the public interface).

The [FxCop analyzers](install-fxcop-analyzers.md) consist of the most important "FxCop" rules from static code analysis, converted to Roslyn analyzers. You can configure FxCop analyzers using either an [.editorconfig file](https://editorconfig.org/), which is the newer, preferred way, or through a [rule set](analyzer-rule-sets.md).

> [!TIP]
> For information about the differences between FxCop static code analysis and FxCop analyzers, see [FxCop analyzers FAQ](fxcop-analyzers-faq.md).

## Configure analyzers using .editorconfig

Starting in version 2.6.3 of the [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers) NuGet package, you can refine how the analyzers analyze your code by configuring certain [options](#options). Each option can be configured for all rules, for a category of rules (for example, `Naming` or `Design`), or for a specific rule.

The configuration syntax is as follows:

||||
|-|-|-|
| Scope | All rules |
| Syntax | dotnet_code_quality.OptionName = OptionValue |
| Example | `dotnet_code_quality.api_surface = public` |

||||
|-|-|-|
| Scope | A category of rules, such as `Naming`, `Design`, `Performance`, `Security` |
| Syntax | dotnet_code_quality.RuleCategory.OptionName = OptionValue |
| Example | `dotnet_code_quality.Naming.api_surface = public` |

||||
|-|-|-|
| Scope | A specific rule |
| Syntax | dotnet_code_quality.RuleId.OptionName = OptionValue |
| Example | `dotnet_code_quality.CA1040.api_surface = public` |

### Per-project configuration

To enable .editorconfig-based analyzer configuration for a specific project, add an *.editorconfig* file to the project's root directory.

> [!TIP]
> You can add an .editorconfig file to your project by right-clicking on the project in **Solution Explorer** and selecting **Add** > **New Item**. In the **Add New Item** window, enter **editorconfig** in the search box. Select the **editorconfig File (default)** template and choose **Add**.
>
> ![Add editorconfig item to project in Visual Studio](media/add-editorconfig-file.png)

Currently there is no hierarchical support for "combining" .editorconfig files that exist at different directory levels, for example, the solution and project level.

### Shared configuration

You can share an .editorconfig file for analyzer configuration between two or more projects, but it requires some additional steps.

1. Save the *.editorconfig* file to a common location.

2. Create a *.props* file with the following content:

   ```xml
   <Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
     <PropertyGroup>
       <SkipDefaultEditorConfigAsAdditionalFile>true</SkipDefaultEditorConfigAsAdditionalFile>
     </PropertyGroup>
     <ItemGroup Condition="Exists('<your path>\.editorconfig')" >
       <AdditionalFiles Include="<your path>\.editorconfig" />
     </ItemGroup>
   </Project>
   ```

3. Add a line to your *.csproj* or *.vbproj* file to import the *.props* file you created in the previous step. This line must be placed before any lines that import the FxCop analyzer *.props* files. For example, if your .props file is named *editorconfig.props*:

   ```xml
   ...
   <Import Project="..\..\editorconfig.props" Condition="Exists('..\..\editorconfig.props')" />
   <Import Project="..\packages\Microsoft.CodeAnalysis.FxCopAnalyzers.2.6.3\build\Microsoft.CodeAnalysis.FxCopAnalyzers.props" Condition="Exists('..\packages\Microsoft.CodeAnalysis.FxCopAnalyzers.2.6.3\build\Microsoft.CodeAnalysis.FxCopAnalyzers.props')" />
   ...
   ```

4. Reload the project.

> [!NOTE]
> You cannot configure legacy FxCop rules (static code analysis FxCop) by using an .editorconfig file.

### Options

| Option name | Description | Allowable values | Default value | Configurable rules |
| - | - | - | - | - |
| `output_kind` | Which kinds of output assembly to analyze for the configured rules | One or more fields of the <xref:Microsoft.CodeAnalysis.OutputKind> enumeration<br/><br/>Separate multiple values with a comma (,) | All output kinds | [CA2007](https://github.com/dotnet/roslyn-analyzers/blob/master/src/Microsoft.CodeQuality.Analyzers/Microsoft.CodeQuality.Analyzers.md#ca2007-do-not-directly-await-a-task) |
| `skip_async_void_methods` | Whether to skip analysis of asynchronous methods that don't return a value | `true`, `false` | `false` | [CA2007](https://github.com/dotnet/roslyn-analyzers/blob/master/src/Microsoft.CodeQuality.Analyzers/Microsoft.CodeQuality.Analyzers.md#ca2007-do-not-directly-await-a-task) |
| `allow_single_letter_type_parameters` | Whether to exclude single-character [type parameters](/dotnet/csharp/programming-guide/generics/generic-type-parameters) from the rule, for example, `S` | `true`, `false` | `false` | [CA1715](ca1715-identifiers-should-have-correct-prefix.md) |
| `api_surface` | Which part of the API surface to analyze for the configured rules | `public`, `internal` or `friend`, `private`, `all`<br/><br/>Separate multiple values with a comma (,) | `public` | [CA1000](ca1000-do-not-declare-static-members-on-generic-types.md)<br/>[CA1003](ca1003-use-generic-event-handler-instances.md)<br/>[CA1008](ca1008-enums-should-have-zero-value.md)<br/>[CA1010](ca1010-collections-should-implement-generic-interface.md)<br/>[CA1012](ca1012-abstract-types-should-not-have-constructors.md)<br/>[CA1024](ca1024-use-properties-where-appropriate.md)<br/>[CA1027](ca1027-mark-enums-with-flagsattribute.md)<br/>[CA1028](ca1028-enum-storage-should-be-int32.md)<br/>[CA1030](ca1030-use-events-where-appropriate.md)<br/>[CA1036](ca1036-override-methods-on-comparable-types.md)<br/>[CA1040](ca1040-avoid-empty-interfaces.md)<br/>[CA1041](ca1041-provide-obsoleteattribute-message.md)<br/>[CA1043](ca1043-use-integral-or-string-argument-for-indexers.md)<br/>[CA1044](ca1044-properties-should-not-be-write-only.md)<br/>[CA1051](ca1051-do-not-declare-visible-instance-fields.md)<br/>[CA1052](ca1052-static-holder-types-should-be-sealed.md)<br/>[CA1054](ca1054-uri-parameters-should-not-be-strings.md)<br/>[CA1055](ca1055-uri-return-values-should-not-be-strings.md)<br/>[CA1056](ca1056-uri-properties-should-not-be-strings.md)<br/>[CA1058](ca1058-types-should-not-extend-certain-base-types.md)<br/>[CA1063](ca1063-implement-idisposable-correctly.md)<br/>[CA1708](ca1708-identifiers-should-differ-by-more-than-case.md)<br/>[CA1710](ca1710-identifiers-should-have-correct-suffix.md)<br/>[CA1711](ca1711-identifiers-should-not-have-incorrect-suffix.md)<br/>[CA1714](ca1714-flags-enums-should-have-plural-names.md)<br/>[CA1715](ca1715-identifiers-should-have-correct-prefix.md)<br/>[CA1716](ca1716-identifiers-should-not-match-keywords.md)<br/>[CA1717](ca1717-only-flagsattribute-enums-should-have-plural-names.md)<br/>[CA1720](ca1720-identifiers-should-not-contain-type-names.md)<br/>[CA1721](ca1721-property-names-should-not-match-get-methods.md)<br/>[CA1725](ca1725-parameter-names-should-match-base-declaration.md)<br/>[CA1802](ca1802-use-literals-where-appropriate.md)<br/>[CA1815](ca1815-override-equals-and-operator-equals-on-value-types.md)<br/>[CA1819](ca1819-properties-should-not-return-arrays.md)<br/>[CA2217](ca2217-do-not-mark-enums-with-flagsattribute.md)<br/>[CA2225](ca2225-operator-overloads-have-named-alternates.md)<br/>[CA2226](ca2226-operators-should-have-symmetrical-overloads.md)<br/>[CA2231](ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)<br/>[CA2234](ca2234-pass-system-uri-objects-instead-of-strings.md) |

## Configure analyzers using rule sets

You can also configure FxCop analyzers using an XML *rule set*. A rule set is a grouping of code analysis rules that identify targeted issues and specific conditions. The FxCop analyzer NuGet package includes predefined rule sets for the following rule categories:

- design
- documentation
- maintainability
- naming
- performance
- reliability
- security
- usage

For more information, see [Rule sets for Roslyn analyzers](analyzer-rule-sets.md).

## See also

- [Analyzer configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md)
- [FxCop analyzers](install-fxcop-analyzers.md)
