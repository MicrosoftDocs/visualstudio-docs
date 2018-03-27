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

If you [install analyzers](../code-quality/install-roslyn-analyzers.md) as a NuGet package, an **Analyzers** node appears under the **References** node in **Solution Explorer**. If you expand **Analyzers**, and then expand one of the analyzer assemblies, you see all the diagnostics in the assembly.

![Analyzers node in Solution Explorer](media/analyzers-expanded-in-solution-explorer.png)

You can view the properties of a diagnostic, including its description and default severity, in the **Properties** window. To view the properties, right-click on the rule and select **Properties**, or select the rule and then press **Alt**+**Enter**.

![Diagnostic properties in Properties window](media/analyzer-diagnostic-properties.png)

## Rule sets

## Rule severity

You can configure the severity of analyzer rules, or *diagnostics*, if you [install the analyzers](../code-quality/install-roslyn-analyzers.md) as a NuGet package. The following table shows the severity options for diagnostics:

|Severity|Build-time behavior|Editor behavior|
|-|-|-|
|Error|Violations appear as *Errors* in the **Error List** and in command-line build output, and cause builds to fail.|Offending code is underlined with a red squiggly, and marked by a small red box in the scroll bar.|
|Warning|Violations appear as *Warnings* in the **Error List** and in command-line build output, but do not cause builds to fail.|Offending code is underlined with a green squiggly, and marked by a small green box in the scroll bar.|
|Info|Violations appear as *Messages* in the **Error List**, and not at all in command-line builds.|Offending code is underlined with a gray squiggly, and marked by a small gray box in the scroll bar.|
|Hidden|Non-visible.|Non-visible.|
|None|Suppressed completely.|Suppressed completely.|

In addition, you can "re-set" a rule's severity by setting it to **Default**.

The following screenshot shows three different diagnostic violations in the code editor, with three different severities. Notice the color of the squiggly, as well as the small box in the scroll bar on the right.

![Error, warning, and info violation in the code editor](media/diagnostics-severity-colors.png)

The following screenshot shows the same three violations as they appear in the **Error List**:

![Error, warning, and info violation in Error List](media/diagnostics-severities-in-error-list.png)

You can change the severity of a rule from **Solution Explorer**, or within the *\<projectname>.ruleset* file that is added to the solution after you change the severity of a rule in **Solution Explorer**.

![Ruleset file in Solution Explorer](media/ruleset-in-solution-explorer.png)

### To set rule severity from Solution Explorer

### To set rule severity in the rule set file

![Ruleset file open in editor](media/ruleset-file-in-editor.png)

## Supress violations

## See also

- [Overview of Roslyn analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)