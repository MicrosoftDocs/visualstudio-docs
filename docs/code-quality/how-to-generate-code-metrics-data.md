---
title: Generate code metrics from the IDE or command line
ms.date: 11/02/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: "conceptual"
helpviewer_keywords:
  - "code metrics data"
  - "code metrics results"
  - "code metrics [Visual Studio]"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Generate code metrics data

You can generate code metrics results for one or more projects or an entire solution. Code metrics is available within the Visual Studio interactive development environment (IDE) and, for C# and Visual Basic projects, at the command line.

In addition, you can install a [NuGet package](https://dotnet.myget.org/feed/roslyn-analyzers/package/nuget/Microsoft.CodeAnalysis.FxCopAnalyzers/2.6.2-beta2-63202-01) that includes four code metrics [analyzer](roslyn-analyzers-overview.md) rules: CA1501, CA1502, CA1505, and CA1506. These rules are disabled by default, but you can enable them from **Solution Explorer** or in a [rule set](using-rule-sets-to-group-code-analysis-rules.md) file.

## Generate code metrics in the Visual Studio IDE

### Generate code metrics results for an entire solution

You can generate code metrics results for an entire solution in any of the following ways:

- From the menu bar, choose **Analyze** > **Calculate Code Metrics** > **For Solution**.

- In **Solution Explorer**, right-click the solution and then choose **Calculate Code Metrics**.

- In the **Code Metrics Results** window, choose the **Calculate Code Metrics for Solution** button.

   The results are generated and the **Code Metrics Results** window is displayed. To view the results details, expand the tree in the **Hierarchy** column.

### Generate code metrics results for one or more projects

1. In **Solution Explorer**, select one or more projects.

1. From the menu bar, choose **Analyze** > **Calculate Code Metrics** > **For Selected Project(s)**.

   The results are generated and the **Code Metrics Results** window is displayed. To view the results details, expand the tree in the **Hierarchy**.

## Generate code metrics from the command line

You can generate code metrics data from the command line for C# and Visual Basic projects, including .NET Core and .NET Standard projects. The command line code metrics tools is called *Metrics.exe*.

To obtain the *Metrics.exe* executable, you must generate it yourself by cloning the [dotnet/roslyn-analyzers](https://github.com/dotnet/roslyn-analyzers) repo and then building the project at https://github.com/dotnet/roslyn-analyzers/blob/master/src/Tools/Metrics.csproj. In the near future, a [published version of *Metrics.exe* will be available](https://github.com/dotnet/roslyn-analyzers/issues/1756) so you don't have to clone the repo and build it yourself.

## Usage

To run *Metrics.exe*, either supply a project or solution and an output XML file as arguments. For example:

```shell
C:\>Metrics.exe /project:ConsoleApp20.csproj /out:report.xml
Loading ConsoleApp20.csproj...
Computing code metrics for ConsoleApp20.csproj...
Writing output to 'report.xml'...
Completed Successfully.
```

## Output

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
          <Metric Name="LinesOfCode" Value="11" />
        </Metrics>
        <Namespaces>
          <Namespace Name="ConsoleApp20">
            <Metrics>
              <Metric Name="MaintainabilityIndex" Value="100" />
              <Metric Name="CyclomaticComplexity" Value="1" />
              <Metric Name="ClassCoupling" Value="1" />
              <Metric Name="DepthOfInheritance" Value="1" />
              <Metric Name="LinesOfCode" Value="11" />
            </Metrics>
            <Types>
              <NamedType Name="Program">
                <Metrics>
                  <Metric Name="MaintainabilityIndex" Value="100" />
                  <Metric Name="CyclomaticComplexity" Value="1" />
                  <Metric Name="ClassCoupling" Value="1" />
                  <Metric Name="DepthOfInheritance" Value="1" />
                  <Metric Name="LinesOfCode" Value="7" />
                </Metrics>
                <Members>
                  <Method Name="void Program.Main(string[] args)" File="C:\Users\mavasani\source\repos\ConsoleApp20\ConsoleApp20\Program.cs" Line="7">
                    <Metrics>
                      <Metric Name="MaintainabilityIndex" Value="100" />
                      <Metric Name="CyclomaticComplexity" Value="1" />
                      <Metric Name="ClassCoupling" Value="1" />
                      <Metric Name="LinesOfCode" Value="4" />
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

### Tool differences

Previous versions of Visual Studio, including Visual Studio 2015, included a command-line code metrics tool called *Metrics.exe*. This previous version of the tool did a binary analysis, that is, an assembly-based analysis. The new tool analyzes source code instead. Because the new *Metrics.exe* is source code-based, the results are different to what's generated within the Visual Studio 2017 IDE and from previous versions of *Metrics.exe*.

#### Metric Values

- The `LinesOfCode` metric is more accurate and reliable in the new *Metrics.exe*. It is independent of any codegen differences and doesn’t change when the toolset or runtime changes. The new *Metrics.exe* counts actual lines of code, including blank lines and comments.

- Other metrics such as `CyclomaticComplexity` and `MaintainabilityIndex` use identical formulas to previous versions of *Metrics.exe*, but the new *Metrics.exe* counts the number of `IOperations` (logical source instructions) instead of intermediate language (IL) instructions. The numbers will be slightly different from previous versions of *Metrics.exe* and from the Visual Studio 2017 IDE code metrics results.

#### Presence of errors

The new *Metrics.exe* tool can compute metrics even in the presence of source code errors, as long as the solution and project can be loaded.

## See also

- [Use the Code Metrics Results window](../code-quality/working-with-code-metrics-data.md)
- [Code metrics values](../code-quality/code-metrics-values.md)