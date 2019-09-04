---
title: Configure FxCop analyzers using editorconfig
ms.date: 03/11/2019
ms.topic: conceptual
helpviewer_keywords:
  - "FxCop analyzers, configuring"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# Configure FxCop analyzers

The [FxCop analyzers](install-fxcop-analyzers.md) consist of the most important "FxCop" rules from legacy analysis, converted to .NET Compiler Platform-based code analyzers. You can configure FxCop code analyzers in two ways:

- With a [rule set](#fxcop-analyzer-rule-sets), which lets you enable or disable rule and set the severity for individual rule violations.

- Starting in version 2.6.3 of the [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers) NuGet package, through an [.editorconfig file](#editorconfig-file). The [configurable options](fxcop-analyzer-options.md) let you refine which parts of your codebase to analyze.

> [!TIP]
> For information about the differences between legacy analysis and FxCop analyzers, see [FxCop analyzers FAQ](fxcop-analyzers-faq.md).

## FxCop analyzer rule sets

One way to configure FxCop analyzers is by using an XML *rule set*. A rule set is a grouping of code analysis rules that identify targeted issues and specific conditions. Rule sets let you enable or disable rule and set the severity for individual rule violations.

The FxCop analyzer NuGet package includes predefined rule sets for the following rule categories:

- design
- documentation
- maintainability
- naming
- performance
- reliability
- security
- usage

For more information, see [Rule sets for code analyzers](analyzer-rule-sets.md).

## EditorConfig file

You can configure FxCop analyzer rules by adding key-value pairs to an [.editorconfig](https://editorconfig.org) file. A configuration file can be [specific to a project](#per-project-configuration) or it can be [shared](#shared-configuration) between two or more projects.

> [!NOTE]
> You cannot configure legacy FxCop rules by using an .editorconfig file.

### Per-project configuration

To enable .editorconfig-based analyzer configuration for a specific project, add an *.editorconfig* file to the project's root directory.

> [!TIP]
> You can add an .editorconfig file to your project by right-clicking on the project in **Solution Explorer** and selecting **Add** > **New Item**. In the **Add New Item** window, enter **editorconfig** in the search box. Select the **editorconfig File (default)** template and choose **Add**.
>
> ![Add editorconfig item to project in Visual Studio](media/add-editorconfig-file.png)

Currently there is no hierarchical support for "combining" .editorconfig files that exist at different directory levels, for example, the solution and project level.

### Shared configuration

You can share an .editorconfig file for FxCop analyzer configuration between two or more projects, but it requires some additional steps.

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
> The arbitrary shared location of the EditorConfig file described here applies only to configuring FxCop analyzers. For other settings, such as indentation and code style, the EditorConfig file must always be placed in the project folder or a parent folder.

## Option scopes

Each option can be configured for all rules, for a category of rules (for example, Naming or Design), or for a specific rule.

### All rules

The syntax for configuring an option for all rules is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.OptionName = OptionValue | `dotnet_code_quality.api_surface = public` |

### Category of rules

The syntax for configuring an option for a *category* of rules (such as Naming, Design, or Performance) is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.RuleCategory.OptionName = OptionValue | `dotnet_code_quality.Naming.api_surface = public` |

### Specific rule

The syntax for configuring an option for a specific rule is as follows:

|Syntax|Example|
|-|-|
| dotnet_code_quality.RuleId.OptionName = OptionValue | `dotnet_code_quality.CA1040.api_surface = public` |

## See also

- [Analyzer configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md)
- [FxCop analyzers](install-fxcop-analyzers.md)
- [.NET coding conventions for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
