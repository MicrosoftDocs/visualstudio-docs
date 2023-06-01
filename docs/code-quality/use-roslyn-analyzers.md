---
title: Analyzer configuration
ms.date: 07/27/2022
description: Learn how to customize Roslyn analyzer rules. See how to adjust analyzer severities, suppress violations, and designate files as generated code.
ms.custom: devdivchpfy22
ms.topic: conceptual
helpviewer_keywords:
- code analysis, managed code
- analyzers
- Roslyn analyzers
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---
# Overview

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Each Roslyn analyzer *diagnostic* or rule has a default severity and suppression state that can be overwritten and customized for your project. This article covers setting analyzer severities and suppressing analyzer violations.

## Configure severity levels

Starting in Visual Studio 2019 version 16.3, you can configure the severity of analyzer rules, or *diagnostics*, in an [EditorConfig file](#set-rule-severity-in-an-editorconfig-file), from the [light bulb menu](#set-rule-severity-from-the-light-bulb-menu), and the error list.

The following table shows the different severity options:

| Severity (Solution Explorer) | Severity (EditorConfig file) | Build-time behavior | Editor behavior |
|-|-|-|
| Error | `error` | Violations appear as *Errors* in the Error List and in command-line build output, and cause builds to fail.| Offending code is underlined with a red squiggle and marked by a small red box in the scroll bar. |
| Warning | `warning` | Violations appear as *Warnings* in the Error List and in command-line build output, but don't cause builds to fail. | Offending code is underlined with a green squiggle and marked by a small green box in the scroll bar. |
| Info | `suggestion` | Violations appear as *Messages* in the Error List, and not at all in command-line build output. | Offending code is underlined with a gray squiggle and marked by a small gray box in the scroll bar. |
| Hidden | `silent` | Non-visible to user. | Non-visible to user. The diagnostic is reported to the IDE diagnostic engine, however. |
| None | `none` | Suppressed completely. | Suppressed completely. |
| Default | `default` | Corresponds to the default severity of the rule. To determine what the default value for a rule is, look in the Properties window. | Corresponds to the default severity of the rule. |

Rule violations found by the analyzer appear in the code editor (as a *squiggle* under the offending code) and in the Error List window by analyzer.

The analyzer violations reported in the error list match the [severity level setting](../code-quality/use-roslyn-analyzers.md#configure-severity-levels) of the rule. Analyzer violations also show up in the code editor as squiggles under the offending code. The following image shows three violations&mdash;one error (red squiggle), one warning (green squiggle), and one suggestion (three grey dots):

![Squiggles in the code editor in Visual Studio](media/diagnostics-severity-colors.png)

The following screenshot shows the same three violations as they appear in the Error List:

![Error, warning, and info violation in Error List](media/diagnostics-severities-in-error-list.png)

Many analyzer rules, or *diagnostics*, have one or more associated *code fixes* that you can apply to correct the rule violation. Code fixes are shown in the light bulb icon menu along with other types of [Quick Actions](../ide/quick-actions.md). For information about these code fixes, see [Common Quick Actions](../ide/quick-actions.md).

![Analyzer violation and Quick Action code fix](../code-quality/media/built-in-analyzer-code-fix.png)

### 'Hidden' severity versus 'None' severity

`Hidden` severity rules that are enabled by default differ from disabled or `None` severity rules in certain aspects.

- If any code fix is registered for a `Hidden` severity rule, Visual Studio offers the fix as a light bulb code-refactoring action even if the hidden diagnostic isn't visible to the user. The fix isn't offered if the severity rule is disabled as `None`.
- `Hidden` severity rules can be bulk configured by entries that [set rule severity of multiple analyzer rules at once in an EditorConfig file](#set-rule-severity-of-multiple-analyzer-rules-at-once-in-an-editorconfig-file). `None` severity rules can’t be configured this way. Instead, they must be configured through entries that [set rule severity in an EditorConfig file for each rule ID](#set-rule-severity-in-an-editorconfig-file).

### Set rule severity in an EditorConfig file

(Visual Studio 2019 version 16.3 and later)

You can set the severity for compiler warnings or analyzer rules in an EditorConfig file with the following syntax:

`dotnet_diagnostic.<rule ID>.severity = <severity>`

Setting a rule's severity in an EditorConfig file takes precedence over any severity that's set in a rule set or in Solution Explorer. You can [manually](#manually-configure-rule-severity-in-an-editorconfig-file) configure severity in an EditorConfig file or [automatically](#set-rule-severity-from-the-light-bulb-menu) through the light bulb that appears next to a violation.

### Set rule severity of multiple analyzer rules at once in an EditorConfig file

(Visual Studio 2019 version 16.5 and later)

You can set the severity for a specific category of analyzer rules or for all analyzer rules with a single entry in an EditorConfig file.

- Set rule severity for a category of analyzer rules:

`dotnet_analyzer_diagnostic.category-<rule category>.severity = <severity>`

- Set rule severity for all analyzer rules:

`dotnet_analyzer_diagnostic.severity = <severity>`

> [!NOTE]
> Entries to configure multiple analyzer rules at once only apply to rules that are *enabled by default*. Analyzer rules that are marked as disabled by default in the analyzer package must be enabled through explicit `dotnet_diagnostic.<rule ID>.severity = <severity>` entries.

If you have multiple entries that are applicable to a specific rule ID, the order of precedence for the applicable entry follows:

- Severity entry for an individual rule by ID takes precedence over severity entry for a category.
- Severity entry for a category takes precedence over severity entry for all analyzer rules.

Consider the following EditorConfig example, where [CA1822](/dotnet/fundamentals/code-analysis/quality-rules/ca1822) has the category "Performance":

   ```ini
   [*.cs]
   dotnet_diagnostic.CA1822.severity = error
   dotnet_analyzer_diagnostic.category-performance.severity = warning
   dotnet_analyzer_diagnostic.severity = suggestion
   ```

In the preceding example, all three entries apply to CA1822. However, using the specified precedence rules, the first rule ID-based severity entry wins over the next entries. In this example, CA1822 has an effective severity of "error". The remaining rules with the "Performance" category have severity "warning", and the analyzer rules that don't have the "Performance" category have severity of "suggestion".

#### Manually configure rule severity in an EditorConfig file

1. If you don't already have an EditorConfig file for your project, [add one](../ide/create-portable-custom-editor-options.md#add-an-editorconfig-file-to-a-project).

2. Add an entry for each rule you want to configure under the corresponding file extension. For example, to set the severity for [CA1822](/dotnet/fundamentals/code-analysis/quality-rules/ca1822) to `error` for C# files, the entry looks as follows:

   ```ini
   [*.cs]
   dotnet_diagnostic.CA1822.severity = error
   ```

> [!NOTE]
> For IDE code-style analyzers, you can also configure them in an EditorConfig file using a different syntax, for example, `dotnet_style_qualification_for_field = false:suggestion`. However, if you set a severity using the `dotnet_diagnostic` syntax, it takes precedence. For more information, see [Language conventions for EditorConfig](/dotnet/fundamentals/code-analysis/style-rules/language-rules).

### Set rule severity from the light bulb menu

Visual Studio provides a convenient way to configure a rule's severity from the [Quick Actions](../ide/quick-actions.md) light bulb menu.

1. After a violation occurs, hover over the violation squiggle in the editor and choose **Show potential fixes** to open the light bulb menu. Or, put your cursor on the line and press **Ctrl**+**.** (period).

2. From the light bulb menu, hover over a severity level to get a preview of the change, and then select an option to configure severity:

   - **Configure \<rule ID> severity** - Set the [severity](#configure-severity-levels) for the specific rule.
   - **Configure severity for all \<style> analyzers** - Set the severity for all rules in the specific [rule category](/dotnet/fundamentals/code-analysis/categories).
   - **Configure severity for all analyzers** - Set the severity for all categories of analyzer rules.

   In the following example, choose **Configure or Suppress issues** > **Configure \<rule ID> severity**.

   ::: moniker range=">=vs-2022"
   ![Configure rule severity from light bulb menu in Visual Studio](media/vs-2022/configure-rule-severity.png)
   ::: moniker-end
   ::: moniker range="vs-2019"
   ![Configure rule severity from light bulb menu in Visual Studio](media/configure-rule-severity.png)
   ::: moniker-end

3. From there, choose one of the severity options.

   ::: moniker range=">=vs-2022"
   ![Configure rule severity as Suggestion](media/vs-2022/configure-rule-severity-suggestion.png)
   ::: moniker-end
   ::: moniker range="vs-2019"
   ![Configure rule severity as Suggestion](media/configure-rule-severity-suggestion.png)
   ::: moniker-end

   Visual Studio adds an entry to the EditorConfig file to configure the rule to the requested level, as shown in the preview box.

   > [!TIP]
   > If you don't already have an EditorConfig file in the project, Visual Studio creates one for you.

### Set rule severity from the Error List window

Visual Studio also provides a convenient way to configure a rule's severity from the error list context menu.

1. After a violation occurs, right-click the diagnostic entry in the error list.

2. From the context menu, select **Set severity**.

   ![Configure rule severity from error list in Visual Studio](media/configure-rule-severity-error-list.png)

3. From there, choose one of the severity options.

   Visual Studio adds an entry to the EditorConfig file to configure the rule to the requested level.

   > [!TIP]
   > If you don't already have an EditorConfig file in the project, Visual Studio creates one for you.

### Set rule severity from Solution Explorer

You can do much of the customization of analyzer diagnostics from **Solution Explorer**. If you [install analyzers](../code-quality/install-roslyn-analyzers.md) as a NuGet package, an **Analyzers** node appears under the **References** or **Dependencies** node in **Solution Explorer**. If you expand **Analyzers**, and then expand one of the analyzer assemblies, you see all the diagnostics in the assembly.

![Analyzers node in Solution Explorer](media/analyzers-expanded-in-solution-explorer.png)

You can view the properties of a diagnostic, including its description and default severity, in the **Properties** window. To view properties, right-click the rule and select **Properties**, or select the rule and then press **Alt**+**Enter**.

![Diagnostic properties in Properties window](media/analyzer-diagnostic-properties.png)

To see online documentation for a diagnostic, right-click the diagnostic and select **View Help**.

The icons next to each diagnostic in **Solution Explorer** correspond to the icons you see in the rule set when you open it in the editor:

- "x" in a circle indicates a [severity](#configure-severity-levels) of **Error**
- "!" in a triangle indicates a [severity](#configure-severity-levels) of **Warning**
- "i" in a circle indicates a [severity](#configure-severity-levels) of **Info**
- "i" in a circle on a light-colored background indicates a [severity](#configure-severity-levels) of **Hidden**
- Downward-pointing arrow in a circle indicates that the diagnostic is suppressed

![Diagnostics icons in Solution Explorer](media/diagnostics-icons-solution-explorer.png)

#### Convert an existing Ruleset file to EditorConfig file

Starting in Visual Studio 2019 version 16.5, ruleset files are deprecated in favor of the EditorConfig file for analyzer configuration for managed code. Most of the Visual Studio tools for analyzer rules severity configuration are updated to work on EditorConfig files instead of ruleset files. EditorConfig files let you configure both analyzer rule severities and analyzer options, including Visual Studio IDE code style options. We recommended converting your existing ruleset file to an EditorConfig file. Also, save the EditorConfig file at the root of your repo or in the solution folder. By using the root of your repo or solution folder, you make sure that the severity settings from this file automatically apply to the entire repo or solution, respectively.

There are a couple ways to convert an existing ruleset file to an EditorConfig file:

- From the Ruleset Editor in Visual Studio (requires Visual Studio 2019 16.5 or later). If your project already uses a specific ruleset file as its `CodeAnalysisRuleSet`, you can convert it to an equivalent EditorConfig file from Ruleset Editor within Visual Studio.

    1. Double-click the ruleset file in Solution Explorer.

       The Ruleset file should open in the Ruleset Editor. You should see a clickable **infobar** at top of the ruleset editor.

       ![Convert Ruleset to EditorConfig file in Ruleset Editor](media/convert-ruleset-to-editorconfig-file-ruleset-editor.png)

    2. Select the **infobar** link.

       The action should open a **Save As** dialog that lets you select the directory where you want to generate the EditorConfig file.

    3. Select the **Save** button to generate the EditorConfig file.

       The generated EditorConfig should open in the editor. Additionally, the MSBuild property `CodeAnalysisRuleSet` gets updated in the project file so that it no longer references the original ruleset file.

- From the command line:

    1. Install the NuGet package [Microsoft.CodeAnalysis.RulesetToEditorconfigConverter](https://www.nuget.org/packages/Microsoft.CodeAnalysis.RulesetToEditorconfigConverter).

    2. Execute `RulesetToEditorconfigConverter.exe` from the installed package, with paths to ruleset file and EditorConfig file as command-line arguments.

   ```
   Usage: RulesetToEditorconfigConverter.exe <%ruleset_file%> [<%path_to_editorconfig%>]
   ```

Following is an example ruleset file to convert:

```xml
<?xml version="1.0" encoding="utf-8"?>
<RuleSet Name="Rules for ConsoleApp" Description="Code analysis rules for ConsoleApp.csproj." ToolsVersion="16.0">
  <Rules AnalyzerId="Microsoft.Analyzers.ManagedCodeAnalysis" RuleNamespace="Microsoft.Rules.Managed">
    <Rule Id="CA1001" Action="Warning" />
    <Rule Id="CA1821" Action="Warning" />
    <Rule Id="CA2213" Action="Warning" />
    <Rule Id="CA2231" Action="Warning" />
  </Rules>
</RuleSet>
```

Following is the converted EditorConfig file:

```ini
# NOTE: Requires **VS2019 16.3** or later

# Rules for ConsoleApp
# Description: Code analysis rules for ConsoleApp.csproj.

# Code files
[*.{cs,vb}]

dotnet_diagnostic.CA1001.severity = warning

dotnet_diagnostic.CA1821.severity = warning

dotnet_diagnostic.CA2213.severity = warning

dotnet_diagnostic.CA2231.severity = warning
```

### Set rule severity from Solution Explorer

1. In Solution Explorer, expand **References** > **Analyzers** (or **Dependencies** > **Analyzers** for .NET Core projects).

2. Expand the assembly that contains the rule you want to set severity for.

3. Right-click the rule and select **Set severity**. In the context menu, choose one of the severity options.

   Visual Studio adds an entry to the EditorConfig file to configure the rule to the requested level. If your project uses a ruleset file instead of an EditorConfig file, the severity entry is added to the ruleset file.

   > [!TIP]
   > If you don't already have an EditorConfig file or ruleset file in the project, Visual Studio creates a new EditorConfig file for you.

### Set rule severity in the rule set file

1. Open the active rule set file in one of the following ways:

    - In **Solution Explorer**, double-click the file, right-click **References** > **Analyzers** node, and select **Open Active Rule Set**.
  
        ![Rule set file in Solution Explorer](media/ruleset-in-solution-explorer.png)

    - On the **Code Analysis** property page for the project, select **Open** .

    If you're editing the rule set for the first time, Visual Studio makes a copy of the default rule set file, names it *\<projectname>.ruleset*, and adds it to your project. This custom rule set also becomes the active rule set for your project.

    > [!NOTE]
    > .NET Core and .NET Standard projects don't support the menu commands for rule sets in **Solution Explorer**, for example, **Open Active Rule Set**. To specify a non-default rule set for a .NET Core or .NET Standard project, manually [add the **CodeAnalysisRuleSet** property](using-rule-sets-to-group-code-analysis-rules.md#specify-a-rule-set-for-a-project) to the project file. You can still configure the rules within the rule set in the Visual Studio rule set editor UI.

1. Browse to the rule by expanding its containing assembly.

1. In the **Action** column, select the value to open a drop-down list, and choose the desired severity from the list.

   ![Rule set file open in editor](media/ruleset-file-in-editor.png)

## Configure Generated code

Analyzers run on all source files in a project and report violations on them. However, the violations aren't useful on generated code files, such as designer generated code files, temporary source files generated by the build system, and so on. Users can't manually edit the files and aren't concerned about fixing violations in tooling-generated files.

By default, the analyzer driver running analyzers treats the files with certain names, file extensions, or autogenerated file headers as generated code files. For example, a file name ending with .designer.cs or .generated.cs is considered generated code. However, these heuristics might not be able to identify all the custom generated code files in the user's source code.

Starting with Visual Studio 2019 16.5, end users can configure specific files and/or folders to be treated as generated code in an [EditorConfig file](https://editorconfig.org/). Follow the steps below to add such a configuration:

1. If you don't already have an EditorConfig file for your project, [add one](../ide/create-portable-custom-editor-options.md#add-an-editorconfig-file-to-a-project).

2. Add the `generated_code = true | false` entry for specific files and/or folders. For example, to treat all files whose name ends with `.MyGenerated.cs` as generated code, the entry would be as follows:

   ```ini
   [*.MyGenerated.cs]
   generated_code = true
   ```

## Suppress violations

You can suppress rule violations using various methods. For more information, see [Suppress code analysis violations](../code-quality/in-source-suppression-overview.md).

## Command-line usage

When you build your project at the command line, rule violations appear in the build output if the following conditions are met:

- The analyzers are installed with the .NET SDK or as a NuGet package, and not as a VSIX extension.

  For analyzers installed using the .NET SDK, you may need to [Enable the analyzers](../code-quality/install-net-analyzers.md). For code styles, you can also [enforce code styles on build](/dotnet/fundamentals/code-analysis/overview#code-style-analysis) by setting an MSBuild property.

- One or more rules are violated in the project's code.

- The [severity](#configure-severity-levels) of a violated rule is set to either **warning**, in which case violations don't cause build to fail, or **error**, in which case violations cause build to fail.

The verbosity of the build output doesn't affect whether rule violations are shown. Even with **quiet** verbosity, rule violations appear in the build output.

> [!TIP]
> If you're accustomed to running legacy analysis from the command line, either with *FxCopCmd.exe* or through msbuild with the **RunCodeAnalysis** flag, here's how to do that with code analyzers.

To see analyzer violations at the command line when you build your project using msbuild, run a command like this:

```cmd
msbuild myproject.csproj /target:rebuild /verbosity:minimal
```

The following image shows the command-line build output from building a project that contains an analyzer rule violation:

![MSBuild output with rule violation](media/command-line-build-analyzers.png)

## Dependent projects

In a .NET Core project, if you add a reference to a project that has NuGet analyzers, those analyzers are also automatically added to the dependent project. To disable this behavior, for example, if the dependent project is a unit test project, mark the NuGet package as private in the *.csproj* or *.vbproj* file of the referenced project by setting the **PrivateAssets** attribute:

```xml
<PackageReference Include="Microsoft.CodeAnalysis.NetAnalyzers" Version="5.0.0" PrivateAssets="all" />
```

## See also

- [Overview of code analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Submit a code analyzer bug](https://github.com/dotnet/roslyn-analyzers/issues)
- [Use rule sets](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
- [Suppress code analysis warnings](../code-quality/in-source-suppression-overview.md)
- [Configuration options for code analysis (.NET)](/dotnet/fundamentals/code-analysis/configuration-options)