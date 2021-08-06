---
title: Configure Code Analysis
ms.date: 04/04/2018
description: Learn how to configure the rule set that Visual Studio legacy code analysis uses. See how to apply a rule set to one or multiple projects in a solution.
ms.custom: SEO-VS-2020
ms.topic: how-to
f1_keywords:
  - vs.codeanalysis.propertypages.csvb
  - vs.codeanalysis.propertypages.solution
  - vs.codeanalysis.propertypages.asp
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - code analysis, selecting rule sets
  - code analysis, rule sets
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
  - dotnet
---
# How to: Configure legacy analysis for managed code

In Visual Studio, you can choose from a list of code analysis [rule sets](../code-quality/rule-set-reference.md) to apply to a managed code project. By default, the **Microsoft Minimum Recommended Rules** rule set is selected, but you can apply a different rule set if desired. Rule sets can be applied to one or multiple projects in a solution.

> [!NOTE]
> This article applies to legacy analysis and not to [.NET Compiler Platform-based code analyzers](use-roslyn-analyzers.md).

## Configure a rule set for a .NET Framework project

1. Open the **Code Analysis** tab on the project's property pages. You can do this in either of the following ways:

   - In **Solution Explorer**, choose the project. On the menu bar, select **Analyze** > **Configure Code Analysis** > **For \<projectname>**.

   - Right-click the project in **Solution Explorer** and select **Properties**, and then select the **Code Analysis** tab.

2. In the **Configuration** and **Platform** lists, choose the build configuration and target platform.

::: moniker range="vs-2017"

3. To run code analysis every time the project is built using the selected configuration, select **Enable Code Analysis on Build**. You can also run code analysis manually by selecting **Analyze** > **Run Code Analysis** > **Run Code Analysis on \<projectname>**.

::: moniker-end

::: moniker range=">=vs-2019"

3. To run code analysis every time the project is built using the selected configuration, select **Run on build** in the **Binary analyzers** section. You can also run legacy code analysis manually, see [How to: Run Legacy Code Analysis Manually for Managed Code](how-to-run-legacy-code-analysis-manually-for-managed-code.md) for more details.

::: moniker-end

4. To view warnings from generated code, clear the **Suppress results from generated code** check box.

    > [!NOTE]
    > This option does not suppress code analysis errors and warnings from generated code when the errors and warnings appear in forms and templates. You can both view and maintain the source code for a form or a template, and it won't be overwritten.

::: moniker range="vs-2017"

5. In the **Run this rule set** list, do one of the following:

::: moniker-end

::: moniker range=">=vs-2019"

5. In the **Active rules** list, do one of the following:

::: moniker-end

   - Select the rule set that you want to use.

   - Select **\<Browse>** to find an existing custom rule set that is not in the list.

   - Define a [custom rule set](../code-quality/how-to-create-a-custom-rule-set.md).

## Specify rule sets for multiple projects in a solution

By default, all the managed projects of a solution are assigned the *Microsoft Minimum Recommended Rules* code analysis rule set. You can change the rule sets that are assigned to the projects of a solution in the **Properties** dialog box for the solution.

1. Open the solution in Visual Studio.

2. On the **Analyze** menu, select **Configure Code Analysis for Solution**.

3. If necessary, expand **Common Properties**, and then select **Code Analysis Settings**.

4. You can specify a rule set for one or more projects:

    - To specify a rule set for an individual project, choose the project name.

    - To specify a rule set for multiple projects, select **Ctrl** and the project names.

    - To specify all the projects in the solution, select **Shift** and the project list.

5. Select the **Rule Set** field of a project, and then select the name of the rule set that you want to apply.

## See also

- [Code analysis rule set reference](../code-quality/rule-set-reference.md)
