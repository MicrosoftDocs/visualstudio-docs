---
title: Generate code metrics from the IDE or command line
ms.date: 04/14/2025
description: Learn how to generate code metrics data in Visual Studio. See how to use Solution Explorer, a rule set file, the command line, or a menu command.
ms.topic: how-to
helpviewer_keywords:
  - code metrics data
  - code metrics results
  - code metrics [Visual Studio]
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: code-analysis
---

# Generate code metrics data

You can generate code metrics data in three ways:

- By enabling [.NET code-quality analyzers](#net-code-quality-analyzers-code-metrics-rules) and enabling the four code metrics (maintainability) rules it contains.

- By choosing the [**Analyze** > **Calculate Code Metrics**](#calculate-code-metrics-menu-command) menu command within Visual Studio.

- From the [command line](#command-line-code-metrics) for C# and Visual Basic projects.

## .NET code-quality analyzers code metrics rules

The .NET code-quality analyzers include several code metrics [analyzer](roslyn-analyzers-overview.md) rules:

- [CA1501](/dotnet/fundamentals/code-analysis/quality-rules/ca1501)
- [CA1502](/dotnet/fundamentals/code-analysis/quality-rules/ca1502)
- [CA1505](/dotnet/fundamentals/code-analysis/quality-rules/ca1505)
- [CA1506](/dotnet/fundamentals/code-analysis/quality-rules/ca1506)

These rules are disabled by default but you can enable them from [**Solution Explorer**](use-roslyn-analyzers.md#set-rule-severity-from-solution-explorer) or in an [EditorConfig](use-roslyn-analyzers.md#set-rule-severity-in-an-editorconfig-file) file. For example, to enable rule CA1502 as a warning, your EditorConfig file would contain the following entry:

```cs
dotnet_diagnostic.CA1502.severity = warning
```

### Configuration

You can configure the thresholds at which the code metrics rules fire.

1. Create a text file. As an example, you can name it *CodeMetricsConfig.txt*.

2. Add the desired thresholds to the text file in the following format:

   ```txt
   CA1502: 10
   ```

   In this example, rule [CA1502](/dotnet/fundamentals/code-analysis/quality-rules/ca1502) is configured to fire when a method's cyclomatic complexity is greater than 10.

3. In the **Properties** window of Visual Studio, or in the project file, mark the build action of the configuration file as [**AdditionalFiles**](../ide/build-actions.md#build-action-values). For example:

   ```xml
   <ItemGroup>
     <AdditionalFiles Include="CodeMetricsConfig.txt" />
   </ItemGroup>
   ```

## Calculate Code Metrics menu command

Generate code metrics for one or all of your open projects in the IDE by using the **Analyze** > **Calculate Code Metrics** menu.

### Generate code metrics results for an entire solution

You can generate code metrics results for an entire solution in any of the following ways:

- From the menu bar, select **Analyze** > **Calculate Code Metrics** > **For Solution**.

- In **Solution Explorer**, right-click the solution and then select **Calculate Code Metrics**.

- In the **Code Metrics Results** window, select the **Calculate Code Metrics for Solution** button.

The results are generated and the **Code Metrics Results** window is displayed. To view the results details, expand the tree in the **Hierarchy** column.

### Generate code metrics results for one or more projects

1. In **Solution Explorer**, select one or more projects.

1. From the menu bar, select **Analyze** > **Calculate Code Metrics** > **For Selected Project(s)**.

The results are generated and the **Code Metrics Results** window is displayed. To view the results details, expand the tree in the **Hierarchy**.

## Command-line code metrics

You can generate code metrics data from the command line for C# and Visual Basic projects for .NET Framework, .NET Core, and .NET Standard apps. To run code metrics from the command line, install the [Microsoft.CodeAnalysis.Metrics NuGet package](#microsoftcodeanalysismetrics-nuget-package) or build the [Metrics.exe](#metricsexe) executable yourself.

### Microsoft.CodeAnalysis.Metrics NuGet package

The easiest way to generate code metrics data from the command line is by installing the [Microsoft.CodeAnalysis.Metrics](https://www.nuget.org/packages/Microsoft.CodeAnalysis.Metrics/) NuGet package. After you've installed the package, run `msbuild /t:Metrics` from the directory that contains your project file. For example:

```shell
C:\source\repos\ClassLibrary3\ClassLibrary3>msbuild /t:Metrics
Microsoft (R) Build Engine version 16.0.360-preview+g9781d96883 for .NET Framework
Copyright (C) Microsoft Corporation. All rights reserved.

Build started 1/22/2019 4:29:57 PM.
Project "C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj" on node 1 (Metrics target(s))
.
Metrics:
  C:\source\repos\ClassLibrary3\packages\Microsoft.CodeMetrics.2.6.4-ci\build\\..\Metrics\Metrics.exe /project:C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj /out:ClassLibrary3.Metrics.xml
  Loading ClassLibrary3.csproj...
  Computing code metrics for ClassLibrary3.csproj...
  Writing output to 'ClassLibrary3.Metrics.xml'...
  Completed Successfully.
Done Building Project "C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj" (Metrics target(s)).

Build succeeded.
    0 Warning(s)
    0 Error(s)
```

You can override the output file name by specifying `/p:MetricsOutputFile=<filename>`. You can also get [legacy-style](#previous-versions) code metrics data by specifying `/p:LEGACY_CODE_METRICS_MODE=true`. For example:

```shell
C:\source\repos\ClassLibrary3\ClassLibrary3>msbuild /t:Metrics /p:LEGACY_CODE_METRICS_MODE=true /p:MetricsOutputFile="Legacy.xml"
Microsoft (R) Build Engine version 16.0.360-preview+g9781d96883 for .NET Framework
Copyright (C) Microsoft Corporation. All rights reserved.

Build started 1/22/2019 4:31:00 PM.
The "MetricsOutputFile" property is a global property, and cannot be modified.
Project "C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj" on node 1 (Metrics target(s))
.
Metrics:
  C:\source\repos\ClassLibrary3\packages\Microsoft.CodeMetrics.2.6.4-ci\build\\..\Metrics.Legacy\Metrics.Legacy.exe /project:C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj /out:Legacy.xml
  Loading ClassLibrary3.csproj...
  Computing code metrics for ClassLibrary3.csproj...
  Writing output to 'Legacy.xml'...
  Completed Successfully.
Done Building Project "C:\source\repos\ClassLibrary3\ClassLibrary3\ClassLibrary3.csproj" (Metrics target(s)).

Build succeeded.
    0 Warning(s)
    0 Error(s)
```

### Code metrics output

The generated XML output takes the following format:

```xml
<?xml version="1.0" encoding="utf-8"?>
<CodeMetricsReport Version="1.0">
  <Targets>
    <Target Name="ConsoleApp20.csproj">
      <Assembly Name="ConsoleApp20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null">
        <Metrics>
          <Metric Name="MaintainabilityIndex" Value="100" />
          <Metric Name="CyclomaticComplexity" Value="1" />
          <Metric Name="ClassCoupling" Value="1" />
          <Metric Name="DepthOfInheritance" Value="1" />
          <Metric Name="SourceLines" Value="11" />
          <Metric Name="ExecutableLines" Value="1" />
        </Metrics>
        <Namespaces>
          <Namespace Name="ConsoleApp20">
            <Metrics>
              <Metric Name="MaintainabilityIndex" Value="100" />
              <Metric Name="CyclomaticComplexity" Value="1" />
              <Metric Name="ClassCoupling" Value="1" />
              <Metric Name="DepthOfInheritance" Value="1" />
              <Metric Name="SourceLines" Value="11" />
              <Metric Name="ExecutableLines" Value="1" />
            </Metrics>
            <Types>
              <NamedType Name="Program">
                <Metrics>
                  <Metric Name="MaintainabilityIndex" Value="100" />
                  <Metric Name="CyclomaticComplexity" Value="1" />
                  <Metric Name="ClassCoupling" Value="1" />
                  <Metric Name="DepthOfInheritance" Value="1" />
                  <Metric Name="SourceLines" Value="7" />
                  <Metric Name="ExecutableLines" Value="1" />
                </Metrics>
                <Members>
                  <Method Name="void Program.Main(string[] args)" File="C:\source\repos\ConsoleApp20\ConsoleApp20\Program.cs" Line="7">
                    <Metrics>
                      <Metric Name="MaintainabilityIndex" Value="100" />
                      <Metric Name="CyclomaticComplexity" Value="1" />
                      <Metric Name="ClassCoupling" Value="1" />
                      <Metric Name="SourceLines" Value="4" />
                      <Metric Name="ExecutableLines" Value="1" />
                    </Metrics>
                  </Method>
                </Members>
              </NamedType>
            </Types>
          </Namespace>
        </Namespaces>
      </Assembly>
    </Target>
  </Targets>
</CodeMetricsReport>
```

### Metrics.exe

If you don't want to install the NuGet package, you can generate and use the *Metrics.exe* executable directly. To generate the *Metrics.exe* executable:

1. Clone the [dotnet/roslyn-analyzers](https://github.com/dotnet/roslyn-analyzers) repo.
2. Open Developer Command Prompt for Visual Studio as an administrator.
3. From the root of the **roslyn-analyzers** repo, execute the following command: `Restore.cmd`
4. Change the directory to *src\Tools\Metrics*.
5. Execute the following command to build the **Metrics.csproj** project:

   ```shell
   msbuild /m /v:m /p:Configuration=Release Metrics.csproj
   ```

   An executable named *Metrics.exe* is generated in the *artifacts\bin* directory under the repo root.

#### Metrics.exe usage

To run *Metrics.exe*, supply a project or solution and an output XML file as arguments. For example:

```shell
C:\>Metrics.exe /project:ConsoleApp20.csproj /out:report.xml
Loading ConsoleApp20.csproj...
Computing code metrics for ConsoleApp20.csproj...
Writing output to 'report.xml'...
Completed Successfully.
```

#### Legacy mode

You can choose to build *Metrics.exe* in *legacy mode*. The legacy mode version of the tool generates metric values that are closer to what [older versions of the tool generated](#previous-versions). Additionally, in legacy mode, *Metrics.exe* generates code metrics for the same set of method types that previous versions of the tool generated code metrics for. For example, it doesn't generate code metrics data for field and property initializers. Legacy mode is useful for backward compatibility or if you have code check-in gates based on code metrics numbers. The command to build *Metrics.exe* in legacy mode is:

```shell
msbuild /m /v:m /t:rebuild /p:LEGACY_CODE_METRICS_MODE=true Metrics.csproj
```

For more information, see [Enable generating code metrics in legacy mode](https://github.com/dotnet/roslyn-analyzers/pull/1841).

### Previous versions

Visual Studio 2015 included a command-line code metrics tool that was also called *Metrics.exe*. This previous version of the tool did a binary analysis, that is, an assembly-based analysis. The newer version of the *Metrics.exe* tool analyzes source code instead. Because the newer *Metrics.exe* tool is source code-based, command-line code metrics results might be different to those generated by the Visual Studio IDE and by previous versions of *Metrics.exe*. Starting in Visual Studio 2019, the Visual Studio IDE analyzes source code like the command-line tool and the results should be the same.

The new command-line code metrics tool computes metrics even in the presence of source code errors, as long as the solution and project can be loaded.

#### Metric value differences

Starting in Visual Studio 2019 version 16.4 and Microsoft.CodeAnalysis.Metics (2.9.5), `SourceLines` and `ExecutableLines` replace the previous `LinesOfCode` metric. For descriptions of the new metrics, see [Code metrics values](../code-quality/code-metrics-values.md). The `LinesOfCode` metric is available in legacy mode.

Other metrics such as `CyclomaticComplexity` and `MaintainabilityIndex` use the same formulas as previous versions of *Metrics.exe*, but the new tool counts the number of `IOperations` (logical source instructions) instead of intermediate language (IL) instructions. The numbers will be slightly different to those generated by the Visual Studio IDE and by previous versions of *Metrics.exe*.

## Related content

- [Use the Code Metrics Results window](../code-quality/working-with-code-metrics-data.md)
- [Code metrics values](../code-quality/code-metrics-values.md)
