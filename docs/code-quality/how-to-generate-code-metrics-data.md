---
title: Generate code metrics from the IDE or command line
ms.date: 11/02/2018
ms.prod: visual-studio-dev15
ms.topic: "conceptual"
helpviewer_keywords:
  - "code metrics data"
  - "code metrics results"
  - "code metrics [Visual Studio]"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Generate code metrics data

You can generate code metrics results for one or more projects or an entire solution. Code metrics is available within the Visual Studio interactive development environment (IDE) and, for C# and Visual Basic projects, at the command line.

In addition, you can install a [NuGet package](https://dotnet.myget.org/feed/roslyn-analyzers/package/nuget/Microsoft.CodeAnalysis.FxCopAnalyzers/2.6.2-beta2-63202-01) that includes four code metrics [analyzer](roslyn-analyzers-overview.md) rules: CA1501, CA1502, CA1505, and CA1506. These rules are disabled by default, but you can enable them from **Solution Explorer** or in a [rule set](using-rule-sets-to-group-code-analysis-rules.md) file.

## Visual Studio IDE code metrics

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

## Command-line code metrics

You can generate code metrics data from the command line for C# and Visual Basic projects for .NET Framework, .NET Core, and .NET Standard apps. The command line code metrics tools is called *Metrics.exe*.

To obtain the *Metrics.exe* executable, you must [generate it yourself](#generate-the-executable). In the near future, a [published version of *Metrics.exe* will be available](https://github.com/dotnet/roslyn-analyzers/issues/1756) so you don't have to build it yourself.

### Generate the executable

To generate the executable *Metrics.exe*, follow these steps:

1. Clone the [dotnet/roslyn-analyzers](https://github.com/dotnet/roslyn-analyzers) repo.
2. Open Developer Command Prompt for Visual Studio as an administrator.
3. From the root of the **roslyn-analyzers** repo, execute the following command: `Restore.cmd`
4. Change directory to *src\Tools*.
5. Execute the following command to build the **Metrics.csproj** project:

   ```shell
   msbuild /m /v:m /p:Configuration=Release Metrics.csproj
   ```

   An executable named *Metrics.exe* is generated in the *artifacts\bin* directory under the repo root.

   > [!TIP]
   > To build *Metrics.exe* in [legacy mode](#legacy-mode), execute the following command:
   >
   > ```shell
   > msbuild /m /v:m /t:rebuild /p:LEGACY_CODE_METRICS_MODE=true Metrics.csproj
   > ```

### Usage

To run *Metrics.exe*, supply a project or solution and an output XML file as arguments. For example:

```shell
C:\>Metrics.exe /project:ConsoleApp20.csproj /out:report.xml
Loading ConsoleApp20.csproj...
Computing code metrics for ConsoleApp20.csproj...
Writing output to 'report.xml'...
Completed Successfully.
```

### Output

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

Previous versions of Visual Studio, including Visual Studio 2015, included a command-line code metrics tool called *Metrics.exe*. This previous version of the tool did a binary analysis, that is, an assembly-based analysis. The new tool analyzes source code instead. Because the new *Metrics.exe* is source code-based, the results are different to what's generated by previous versions of *Metrics.exe* and within the Visual Studio 2017 IDE.

The new *Metrics.exe* tool can compute metrics even in the presence of source code errors, as long as the solution and project can be loaded.

#### Metric value differences

The `LinesOfCode` metric is more accurate and reliable in the new *Metrics.exe*. It is independent of any codegen differences and doesn’t change when the toolset or runtime changes. The new *Metrics.exe* counts actual lines of code, including blank lines and comments.

Other metrics such as `CyclomaticComplexity` and `MaintainabilityIndex` use the same formulas as previous versions of *Metrics.exe*, but the new *Metrics.exe* counts the number of `IOperations` (logical source instructions) instead of intermediate language (IL) instructions. The numbers will be slightly different from previous versions of *Metrics.exe* and from the Visual Studio 2017 IDE code metrics results.

### Legacy mode

You can also choose to build *Metrics.exe* in *legacy mode*. The legacy mode version of the tool generates metric values that are closer to what older versions of the tool generated. Additionally, in legacy mode, *Metrics.exe* generates code metrics for the same set of method types that previous versions of the tool generated code metrics for. For example, it doesn't generate code metrics data for field and property initializers. Legacy mode is useful for backwards compatibility or if you have code check-in gates based on code metrics numbers. The command to build *Metrics.exe* in legacy mode is:

```shell
msbuild /m /v:m /t:rebuild /p:LEGACY_CODE_METRICS_MODE=true Metrics.csproj
```

For more information, see [Enable generating code metrics in legacy mode](https://github.com/dotnet/roslyn-analyzers/pull/1841).

## See also

- [Use the Code Metrics Results window](../code-quality/working-with-code-metrics-data.md)
- [Code metrics values](../code-quality/code-metrics-values.md)
