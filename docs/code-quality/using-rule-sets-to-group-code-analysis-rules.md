---
title: Code analysis rule sets in Visual Studio
ms.date: 04/02/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.rulesets.learnmore"
helpviewer_keywords:
  - "code analysis, rule sets"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Use rule sets to group code analysis rules

When you configure code analysis in Visual Studio, you can choose from a list of built-in *rule sets*. A rule set applies to a project, and is a grouping of code analysis rules that identify targeted issues and specific conditions for that project. For example, you can apply a rule set that is designed to scan code for publicly available APIs, or just the minimum recommended rules. You can also apply a rule set that includes all the rules.

You can customize a rule set by adding or deleting rules, or by changing rule severities to appear as either warnings or errors in the **Error List**. Customized rule sets can fulfill a need for your particular development environment. When you customize a rule set, the rule set editor provides search and filtering tools to help you in the process.

## Rule set format

A rule set is specified in XML format in a *.ruleset* file. Rules, which consist of an ID and an *action*, are grouped by analyzer ID and namespace in the file.

The XML contents of a *.ruleset* file looks similar to this:

```xml
<RuleSet Name="Rules for Hello World project" Description="These rules focus on critical issues for the Hello World app." ToolsVersion="10.0">
  <Localization ResourceAssembly="Microsoft.VisualStudio.CodeAnalysis.RuleSets.Strings.dll" ResourceBaseName="Microsoft.VisualStudio.CodeAnalysis.RuleSets.Strings.Localized">
    <Name Resource="HelloWorldRules_Name" />
    <Description Resource="HelloWorldRules_Description" />
  </Localization>
  <Rules AnalyzerId="Microsoft.Analyzers.ManagedCodeAnalysis" RuleNamespace="Microsoft.Rules.Managed">
    <Rule Id="CA1001" Action="Warning" />
    <Rule Id="CA1009" Action="Warning" />
    <Rule Id="CA1016" Action="Warning" />
    <Rule Id="CA1033" Action="Warning" />
  </Rules>
  <Rules AnalyzerId="Microsoft.CodeQuality.Analyzers" RuleNamespace="Microsoft.CodeQuality.Analyzers">
    <Rule Id="CA1802" Action="Error" />
    <Rule Id="CA1814" Action="Info" />
    <Rule Id="CA1823" Action="None" />
    <Rule Id="CA2217" Action="Warning" />
  </Rules>
</RuleSet>
```

> [!TIP]
> It is easier to [edit a rule set](../code-quality/working-in-the-code-analysis-rule-set-editor.md) in the graphical **Rule Set Editor** than by hand.

The rule set for a project is specified by the `CodeAnalysisRuleSet` property in the Visual Studio project file. For example:

```xml
<CodeAnalysisRuleSet>HelloWorld.ruleset</CodeAnalysisRuleSet>
```

## See also

- [Code analysis rule set reference](../code-quality/rule-set-reference.md)
