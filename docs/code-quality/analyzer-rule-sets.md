---
title: FxCop analyzer rule sets and editorconfig files
ms.date: 10/08/2019
ms.topic: conceptual
helpviewer_keywords:
  - "analyzer packages, rule sets"
  - "rule sets for analyzers"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Enable a category of rules

Analyzer packages may include predefined [EditorConfig](use-roslyn-analyzers.md#rule-severity) and [rule set](using-rule-sets-to-group-code-analysis-rules.md) files that make it quick and easy to enable a category of rules, such as security or design rules. The [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/) NuGet analyzer package includes both rule sets (starting in version 2.6.2) and EditorConfig files (starting in version 2.9.5). By enabling a specific category of rules, you can identify targeted issues and specific conditions.

> [!NOTE]
> Enabling analyzer rules and setting their severity by using an EditorConfig file is supported starting in Visual Studio 2019 version 16.3.

The FxCop analyzer NuGet package includes predefined rule sets and EditorConfig files for the following rule categories:

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

- enable all the rules in the category (and disable all other rules)
- use each rule's default severity and enablement setting (and disable all other rules)

> [!TIP]
> The "all rules" category has an additional EditorConfig or rule set file to disable all rules. Use this file to quickly get rid of any analyzer warnings or errors in a project.

> [!TIP]
> If you're migrating from legacy "FxCop" analysis to .NET Compiler Platform-based code analysis, the EditorConfig and rule set files enable you to continue using similar rule configurations to [those you used previously](rule-set-reference.md).

## Predefined EditorConfig files

The predefined EditorConfig files for the Microsoft.CodeAnalysis.FxCopAnalyzers analyzer package are located in the *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.fxcopanalyzers\\\<version\>\editorconfig* directory. For example, the EditorConfig file to enable all security rules is located at *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.fxcopanalyzers\\\<version\>\editorconfig\SecurityRulesEnabled\\.editorconfig*.

Copy the chosen .editorconfig file to your project's root directory.

## Predefined rule sets

The predefined rule set files for the Microsoft.CodeAnalysis.FxCopAnalyzers analyzer package are located in the *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.fxcopanalyzers\\\<version\>\rulesets* directory. For example, the rule set file to enable all security rules is located at *%USERPROFILE%\\.nuget\packages\microsoft.codeanalysis.fxcopanalyzers\\\<version\>\rulesets\SecurityRulesEnabled.ruleset*.

Copy one or more of the rule sets and paste them in the directory that contains your Visual Studio project or directly into **Solution Explorer**.

You can also [customize a predefined rule set](how-to-create-a-custom-rule-set.md) to your preference. For example, you can change the severity of one or more rules so that violations appear as errors or warnings in the **Error List**.

### Set the active rule set

The process for setting the active rule set is a little different depending on whether you have a .NET Core/.NET Standard project or a .NET Framework project.

#### .NET Core

To make a rule set the active rule set for analysis in .NET Core or .NET Standard projects, manually add the **CodeAnalysisRuleSet** property to your project file. For example, the following code snippet sets `HelloWorld.ruleset` as the active rule set.

```xml
<PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
  ...
  <CodeAnalysisRuleSet>HelloWorld.ruleset</CodeAnalysisRuleSet>
</PropertyGroup>
```

#### .NET Framework

To make a rule set the active rule set for analysis in .NET Framework projects:

- Right-click on the project in **Solution Explorer** and choose **Properties**.

- In the project property pages, select the **Code Analysis** tab.

::: moniker range="vs-2017"

- Under **Run this rule set**, select **Browse**, and then select the desired rule set that you copied to the project directory.

::: moniker-end

::: moniker range=">=vs-2019"

- Under **Active rules**, select **Browse**, and then select the desired rule set that you copied to the project directory.

::: moniker-end

   Now you only see rule violations for those rules that are enabled in the selected rule set.

## See also

- [Analyzers FAQ](analyzers-faq.md)
- [Overview of .NET Compiler Platform analyzers](roslyn-analyzers-overview.md)
- [Install analyzers](install-roslyn-analyzers.md)
- [Configure analyzers](use-roslyn-analyzers.md)
- [Use rule sets to group code analysis rules](using-rule-sets-to-group-code-analysis-rules.md)
