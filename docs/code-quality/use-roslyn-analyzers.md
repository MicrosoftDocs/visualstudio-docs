---
title: Analyzer rule severity and suppression
ms.date: 03/26/2019
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# Use Roslyn analyzers

.NET Compiler Platform ("Roslyn") analyzer rules, or *diagnostics*, analyze your C# or Visual Basic code as you type. Each diagnostic has a default severity and suppression state that can be overwritten for your project. This article covers setting rule severity, using rule sets, and suppressing violations.

## Analyzers in Solution Explorer

You can do much of the customization of analyzer diagnostics from **Solution Explorer**. If you [install analyzers](../code-quality/install-roslyn-analyzers.md) as a NuGet package, an **Analyzers** node appears under the **References** or **Dependencies** node in **Solution Explorer**. If you expand **Analyzers**, and then expand one of the analyzer assemblies, you see all the diagnostics in the assembly.

![Analyzers node in Solution Explorer](media/analyzers-expanded-in-solution-explorer.png)

You can view the properties of a diagnostic, including its description and default severity, in the **Properties** window. To view the properties, right-click on the rule and select **Properties**, or select the rule and then press **Alt**+**Enter**.

![Diagnostic properties in Properties window](media/analyzer-diagnostic-properties.png)

To see online documentation for a diagnostic, right-click on the diagnostic and select **View Help**.

The icons next to each diagnostic in **Solution Explorer** correspond to the icons you see in the rule set when you open it in the editor:

- the "i" in a circle indicates a [severity](#rule-severity) of **Info**
- the "!" in a triangle indicates a [severity](#rule-severity) of **Warning**
- the "x" in a circle indicates a [severity](#rule-severity) of **Error**
- the "i" in a circle on a light-colored background indicates a [severity](#rule-severity) of **Hidden**
- the downward-pointing arrow in a circle indicates that the diagnostic is suppressed

![Diagnostics icons in Solution Explorer](media/diagnostics-icons-solution-explorer.png)

## Rule sets

A [rule set](../code-quality/using-rule-sets-to-group-code-analysis-rules.md) is an XML file that stores the severity and suppression state for individual diagnostics.

> [!NOTE]
> Rule sets can include rules from both static (binary) code analysis and Roslyn analyzers.

To edit the active rule set in the rule set editor, right-click on the **References** > **Analyzers** node in **Solution Explorer** and select **Open Active Rule Set**. If this is the first time you're editing the rule set, Visual Studio makes a copy of the default rule set file, names it *\<projectname>.ruleset*, and adds it to your project. This custom rule set also becomes the active rule set for your project.

To change the active rule set for a project, navigate to the **Code Analysis** tab of a project's properties. Select the rule set from the list under **Run this rule set**. To open the rule set, select **Open**.

> [!NOTE]
> .NET Core and .NET Standard projects do not support the menu commands for rule sets in **Solution Explorer**, for example, **Open Active Rule Set**. To specify a non-default rule set for a .NET Core or .NET Standard project, manually [add the **CodeAnalysisRuleSet** property](using-rule-sets-to-group-code-analysis-rules.md#specify-a-rule-set-for-a-project) to the project file. You can still configure the rules within the rule set in the Visual Studio rule set editor UI.

## Rule severity

You can configure the severity of analyzer rules, or *diagnostics*, if you [install the analyzers](../code-quality/install-roslyn-analyzers.md) as a NuGet package. The following table shows the severity options for diagnostics:

|Severity|Build-time behavior|Editor behavior|
|-|-|-|
|Error|Violations appear as *Errors* in the **Error List** and in command-line build output, and cause builds to fail.|Offending code is underlined with a red squiggly, and marked by a small red box in the scroll bar.|
|Warning|Violations appear as *Warnings* in the **Error List** and in command-line build output, but do not cause builds to fail.|Offending code is underlined with a green squiggly, and marked by a small green box in the scroll bar.|
|Info|Violations appear as *Messages* in the **Error List**, and not at all in command-line build output.|Offending code is underlined with a gray squiggly, and marked by a small gray box in the scroll bar.|
|Hidden|Non-visible to user.|Non-visible to user. The diagnostic is reported to the IDE diagnostic engine, however.|
|None|Suppressed completely.|Suppressed completely.|

In addition, you can "reset" a rule's severity by setting it to **Default**. Each diagnostic has a default severity that can be seen in the **Properties** window.

The following screenshot shows three different diagnostic violations in the code editor, with three different severities. Notice the color of the squiggly, as well as the small box in the scroll bar on the right.

![Error, warning, and info violation in the code editor](media/diagnostics-severity-colors.png)

The following screenshot shows the same three violations as they appear in the **Error List**:

![Error, warning, and info violation in Error List](media/diagnostics-severities-in-error-list.png)

You can change the severity of a rule from **Solution Explorer**, or within the *\<projectname>.ruleset* file that is added to the solution after you change the severity of a rule in **Solution Explorer**.

![Rule set file in Solution Explorer](media/ruleset-in-solution-explorer.png)

### Set rule severity from Solution Explorer

1. In **Solution Explorer**, expand **References** > **Analyzers** (**Dependencies** > **Analyzers** for .NET Core projects).

1. Expand the assembly that contains the rule you want to set severity for.

1. Right-click on the rule and select **Set Rule Set Severity**. In the fly-out menu, select one of the severity options.

   The severity for the rule is saved in the active rule set file.

### Set rule severity in the rule set file

1. Open the [rule set](analyzer-rule-sets.md) file by double-clicking it in **Solution Explorer**, selecting **Open Active Rule Set** on the right-click menu of the **Analyzers** node, or by selecting **Open** on the **Code Analysis** property page for the project.

1. Browse to the rule by expanding its containing assembly.

1. In the **Action** column, select the value to open a drop-down list, and select the desired severity from the list.

   ![Rule set file open in editor](media/ruleset-file-in-editor.png)

## Suppress violations

There are multiple ways to suppress rule violations:

- From the **Analyze** menu

  Select **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar to suppress all current violations. This is sometimes referred to as "baselining".

- From **Solution Explorer**

  To suppress a violation in **Solution Explorer**, set the rule's severity to **None**.

- From the **rule set editor**

  To suppress a violation from the rule set editor, uncheck the box next to its name or set **Action** to **None**.

- From the **code editor**

  To suppress a violation from the code editor, place the cursor in the line of code with the violation and press **Ctrl**+**.** to open the **Quick Actions** menu. Select **Suppress CAXXXX** > **in Source/in Suppression File**.

  ![Suppress diagnostic from quick actions menu](media/suppress-diagnostic-from-editor.png)

- From the **Error List**

  You can suppress one or many diagnostics from the **Error List** by selecting the ones you want to suppress, and then right-clicking and selecting **Suppress** > **In Source/In Suppression File**.

  - If you suppress **In Source**, the **Preview Changes** dialog opens and shows a preview of the C# [#pragma warning](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-pragma-warning) or Visual Basic [#Disable warning](/dotnet/visual-basic/language-reference/directives/directives) directive that's added to the source code.

    ![Preview of adding #pragma warning in code file](media/pragma-warning-preview.png)

  - If you select **In Suppression File**, the **Preview Changes** dialog opens and shows a preview of the <xref:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> attribute that's added to the global suppressions file.

    ![Preview of adding SuppressMessage attribute to suppression file](media/preview-changes-in-suppression-file.png)

  In the **Preview Changes** dialog, select **Apply**.

  > [!NOTE]
  > If you don't see the **Suppress** menu option in **Solution Explorer**, the violation is likely coming from build and not live analysis. The **Error List** displays diagnostics, or rule violations, from both live code analysis and build. Since the build diagnostics can be stale, for example, if you've edited the code to fix the violation but haven't rebuilt, you cannot suppress these diagnostics from the **Error List**. Diagnostics from live analysis, or IntelliSense, are always up-to-date with current sources and can be suppressed from the **Error List**. To exclude *build* diagnostics from your selection, switch the **Error List** source filter from **Build + IntelliSense** to **Intellisense Only**. Then, select the diagnostics you want to suppress and proceed as described previously.
  >
  > ![Error List source filter in Visual Studio](media/error-list-filter.png)

## Command-line usage

When you build your project at the command line, rule violations appear in the build output if the following conditions are met:

- The analyzers are installed as a Nuget package and not as a VSIX extension.

- One or more rules are violated in the project's code.

- The [severity](#rule-severity) of a violated rule is set to either **warning**, in which case violations don't cause build to fail, or **error**, in which case violations cause build to fail.

The verbosity of the build output does not affect whether rule violations are shown. Even with **quiet** verbosity, rule violations appear in the build output.

> [!TIP]
> If you're accustomed to running static code analysis from the command line, either with *FxCopCmd.exe* or through msbuild with the **RunCodeAnalysis** flag, here's how to do that with Roslyn analyzers.

To see analyzer violations at the command line when you build your project using msbuild, run a command like this:

```cmd
msbuild myproject.csproj /target:rebuild /verbosity:minimal
```

The following image shows the command-line build output from building a project that contains an analyzer rule violation:

![MSBuild output with rule violation](media/command-line-build-analyzers.png)

## Dependent projects

In a .NET Core project, if you add a reference to a project that has NuGet analyzers, those analyzers are automatically added to the dependent project too. To disable this behavior, for example if the dependent project is a unit test project, mark the NuGet package as private in the *.csproj* or *.vbproj* file of the referenced project by setting the **PrivateAssets** attribute:

```xml
<PackageReference Include="Microsoft.CodeAnalysis.FxCopAnalyzers" Version="2.9.0" PrivateAssets="all" />
```

## See also

- [Overview of Roslyn analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Submit a Roslyn analyzer bug](https://github.com/dotnet/roslyn-analyzers/issues)
- [Use rule sets](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
- [Suppress code analysis warnings](../code-quality/in-source-suppression-overview.md)
