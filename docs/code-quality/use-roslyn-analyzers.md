---
title: "Use and configure Roslyn analyzers in Visual Studio | Microsoft Docs"
ms.date: 03/26/2018
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload:
  - "dotnet"
---
# Configure and use Roslyn analyzer rules

## Analyzers in Solution Explorer

You can configure the severity of analyzer rules, or *diagnostics*, if you install the analyzers as a NuGet package. After you install the analyzer package, a new **Analyzers** node appears under the **References** node in **Solution Explorer**. If you expand **Analyzers**, and then expand one of the analyzer assemblies, you see all the diagnostics in the assembly.

![Analyzers node in Solution Explorer](media/analyzers-expanded-in-solution-explorer.png)

You can view the properties of a diagnostic, including its description and default severity, in the **Properties** window. To view the properties, right-click on the rule and select **Properties**, or select the rule and then press **Alt**+**Enter**.

![Diagnostic properties in Properties window](media/analyzer-diagnostic-properties.png)

### Set rule severity

You can set the severity of a rule to one of the following options:

|Severity|Description|
|-|-|
|Default||
|Error||
|Warning||
|Info||
|Hidden||
|None||

You can change the severity of a rule from **Solution Explorer**, or within the *\<projectname>.ruleset* file that is added to the solution after you change the severity of a rule in **Solution Explorer**.

![Ruleset file in Solution Explorer](media/ruleset-in-solution-explorer.png)

![Ruleset file open in editor](media/ruleset-file-in-editor.png)

## See also

- [Overview of Roslyn analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)