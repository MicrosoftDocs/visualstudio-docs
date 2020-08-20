---
title: Configure .NET code-quality analyzers using editorconfig
ms.date: 09/23/2019
ms.topic: conceptual
helpviewer_keywords:
- .NET analyzers, FxCop analyzers, configuring, code quality
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
- dotnet
---
# Configure .NET code-quality analyzers

For certain .NET code-quality analyzers (CAxxxx rule IDs), you can refine which parts of your codebase they should be applied to through [configurable options](fxcop-analyzer-options.md). Each option is specified by adding a key-value pair to an [EditorConfig](https://editorconfig.org) file. A configuration file can be [specific to a project](#per-project-configuration) or it can be [shared](#shared-configuration) between two or more projects.

> [!TIP]
> Add an .editorconfig file to your project by right-clicking on the project in **Solution Explorer** and selecting **Add** > **New Item**. In the **Add New Item** window, enter **editorconfig** in the search box. Select the **editorconfig File (default)** template and choose **Add**.
>
> ![Add editorconfig file to project in Visual Studio](media/add-editorconfig-file.png)

::: moniker range=">=vs-2019"

For information about configuring a rule's severity (for example, whether it's an error or a warning), see [Set rule severity in an EditorConfig file](use-roslyn-analyzers.md#set-rule-severity-in-an-editorconfig-file). Or, you can choose one of the built-in [EditorConfig files or rule sets](analyzer-rule-sets.md) to quickly enable or disable a category of rules.

::: moniker-end

The remainder of this article discusses general syntax for the [options that refine](fxcop-analyzer-options.md) where .NET code-quality analyzers are applied.

## Option scopes

Each refining option can be configured for all rules, for a category of rules (for example, Naming or Design), or for a specific rule.

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

## Enabling .editorconfig based configuration

End users can enable .editorconfig based configuration for individual documents, folders, projects, solution or entire repo. You can do so by creating an .editorconfig file with the options in the corresponding directory. This file can also contain .editorconfig based diagnostic severity configuration entries. See [set rule severity in an EditorConfig file](use-roslyn-analyzers.md#set-rule-severity-in-an-editorconfig-file) for further details.

## See also

- [Rule scope options for .NET code-quality analyzers](fxcop-analyzer-options.md)
- [Analyzer configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md)
- [.NET coding conventions for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
