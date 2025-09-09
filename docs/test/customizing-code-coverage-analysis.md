---
title: Customizing Code Coverage Analysis
description: Learn how to use the ExcludeFromCodeCoverageAttribute attribute to exclude test code from coverage results. You can include assemblies outside your solution.
ms.date: 09/09/2025
ms.topic: conceptual
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Customize code coverage analysis

By default, code coverage analyzes all solution assemblies that are loaded during unit tests. We recommend that you use this default behavior, because it works well most of the time. For more information, see [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

To exclude test code from the code coverage results and only include application code, add the <xref:System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute> attribute to your test class.

To include assemblies that aren't part of your solution, obtain the *.pdb* files for these assemblies and copy them into the same folder as the assembly *.dll* files.

::: moniker range=">=visualstudio"
>[!NOTE]
> Code coverage is available in all versions of Visual Studio. In Visual Studio 2022 and previous versions, the code coverage feature was limited to Visual Studio Enterprise edition.
::: moniker-end
::: moniker range="<=vs-2022"
>[!NOTE]
> Code coverage is available only with Visual Studio Enterprise. For .NET code coverage, you can alternatively use the command-line tool, [dotnet-coverage](/dotnet/core/additional-tools/dotnet-coverage).
::: moniker-end

## Run settings file

The [run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md) is the configuration file used by unit testing tools. Advanced code coverage settings are specified in a *.runsettings* file.

To customize code coverage, follow these steps:

1. Add a run settings file to your solution. In **Solution Explorer**, on the shortcut menu of your solution, choose **Add** > **New Item**, and select **XML File**. Save the file with a name such as *CodeCoverage.runsettings*.

   If you don't see all the item templates, choose **Show All Templates**, and then choose the item template.

2. Add the content from the example file at the end of this article, and then customize it to your needs as described in the sections that follow.

3. Select a run settings file.

   ::: moniker range=">=vs-2022"
   Starting in Visual Studio 2019 version 16.4, you can autodetect a run settings file in the project root. Otherwise, on the **Test** menu, choose **Configure Run Settings**, and then choose **Select Solution Wide runsettings File**. To specify a run settings file for running tests from the command line, see [Configure unit tests](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#specify-a-run-settings-file-from-the-command-line).

   When you select **Analyze Code Coverage**, the configuration information is read from the run settings file.

   > [!TIP]
   > Any previous code coverage results and code coloring aren't automatically hidden when you run tests or update your code.

   To turn the custom settings off and on, deselect or select the file on the **Test** menu.
   :::moniker-end
   ::: moniker range="vs-2019"
   To select the run settings file, on the **Test** menu, choose **Select Settings File**. To specify a run settings file for running tests from the command line, see [Configure unit tests](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#specify-a-run-settings-file-from-the-command-line).

   When you select **Analyze Code Coverage**, the configuration information is read from the run settings file.

   > [!TIP]
   > Any previous code coverage results and code coloring aren't automatically hidden when you run tests or update your code.

   To turn the custom settings off and on, choose **Test**, **Configure Run Settings**, and deselect or select the file name.
   :::moniker-end

## Symbol search paths

Code coverage requires symbol files (*.pdb* files) for assemblies. For assemblies built by your solution, symbol files are usually present alongside the binary files, and code coverage works automatically. In some cases, you might want to include referenced assemblies in your code coverage analysis. In such cases, the *.pdb* files might not be adjacent to the binaries, but you can specify the symbol search path in the *.runsettings* file.

```xml
<SymbolSearchPaths>
      <Path>\\mybuildshare\builds\ProjectX</Path>
      <!--More paths if required-->
</SymbolSearchPaths>
```

> [!NOTE]
> Symbol resolution can take time, especially when using a remote file location with many assemblies. Therefore, consider copying *.pdb* files to the same local location as the binary (*.dll* and *.exe*) files.

## Include or exclude assemblies and members

You can include or exclude assemblies or specific types and members from code coverage analysis. If the **Include** section is empty or omitted, then all assemblies that are loaded and have associated PDB files are included. If an assembly or member matches a clause in the **Exclude** section, then it is excluded from code coverage. The **Exclude** section takes precedence over the **Include** section: if an assembly is listed in both **Include** and **Exclude**, it will not be included in code coverage.

For example, the following XML excludes a single assembly by specifying its name:

```xml
<ModulePaths>
  <Exclude>
   <ModulePath>.*Fabrikam.Math.UnitTest.dll</ModulePath>
   <!-- Add more ModulePath nodes here. -->
  </Exclude>
</ModulePaths>
```

The following example specifies that only a single assembly should be included in code coverage:

```xml
<ModulePaths>
  <Include>
   <ModulePath>.*Fabrikam.Math.dll</ModulePath>
   <!-- Add more ModulePath nodes here. -->
  </Include>
</ModulePaths>
```

The following table shows the various ways that assemblies and members can be matched for inclusion in or exclusion from code coverage.

| XML element | What it matches |
| - | - |
| ModulePath | Matches assemblies specified by assembly name or file path. |
| CompanyName | Matches assemblies by the **Company** attribute. |
| PublicKeyToken | Matches signed assemblies by the public key token. |
| Source | Matches elements by the path name of the source file in which they're defined. |
| Attribute | Matches elements that have the specified attribute. Specify the full name of the attribute, for example `<Attribute>^System\.Diagnostics\.DebuggerHiddenAttribute$</Attribute>`.<br/><br/>If you exclude the <xref:System.Runtime.CompilerServices.CompilerGeneratedAttribute> attribute, code that uses language features such as `async`, `await`, `yield return`, and auto-implemented properties is excluded from code coverage analysis. To exclude truly generated code, only exclude the <xref:System.CodeDom.Compiler.GeneratedCodeAttribute> attribute. |
| Function | Matches procedures, functions, or methods by fully qualified name, including the parameter list. You can also match part of the name by using a [regular expression](#regular-expressions).<br/><br/>Examples:<br/><br/>`Fabrikam.Math.LocalMath.SquareRoot(double);` (C#)<br/><br/>`Fabrikam::Math::LocalMath::SquareRoot(double)` (C++) |

::: moniker range=">=vs-2022"
### Code coverage formats

By default code coverage is collected and saved in a `.coverage` file. You can also collect coverage using other formats including XML and Cobertura. Different formats may be useful across different editors and pipelines. You can enable this in runsettings by adding `<Format>Cobertura</Format>` or `<Format>Xml</Format>` in the [DataCollector configuration section in your runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#codecoverage-data-collector). This format can be viewed in the code coverage results window in Visual Studio Enterprise.

You can also specify different formats from the command-line by either specifying it in the runsettings file or specifying it in a parameter. For example, the dotnet command-line use `dotnet test --collect:"Code Coverage;Format=Cobertura"`. For vstest use `vstest.console.exe /collect:"Code Coverage;Format=Cobertura"`. The collect parameter will override the format specified in runsettings.
::: moniker-end

::: moniker range=">=vs-2022"
### Static and dynamic native instrumentation

In Visual Studio 2022 version 17.2, we added the option to instrument native binary statically (on disk). In previous versions, we supported only dynamic instrumentation, which was often not able to instrument methods. Static native instrumentation is more stable and it is recommended. Static native instrumentation requires enabling the [/PROFILE](/cpp/build/reference/profile-performance-tools-profiler) link option for all native projects for which you need code coverage collection. 

You can also enable native static instrumentation in runsettings by adding `<EnableStaticNativeInstrumentation>True</EnableStaticNativeInstrumentation>` under `<CodeCoverage>` tag. Use this method for command line scenarios.

By default, dynamic native instrumentation is always enabled. If both static and dynamic instrumentation is enabled, Visual Studio tries to instrument your C++ code statically, but if this is not possible (for example, when the `/PROFILE` link option is not enabled), dynamic instrumentation will be used. You can fully disable dynamic native instrumentation in runsettings by adding `<EnableDynamicNativeInstrumentation>False</EnableDynamicNativeInstrumentation>` under `<CodeCoverage>`.

When static native instrumentation is enabled, native binaries will be instrumented and replaced on disk before test execution. Original binaries will be restored after test execution. You can disable restoring original files in runsettings by adding `<EnableStaticNativeInstrumentationRestore>False</EnableStaticNativeInstrumentationRestore>` under the `<CodeCoverage>` tag. This can be especially useful in CI scenarios.

When static native instrumentation is enabled, Visual Studio will search and instrument all native binaries in directory where test binary is located. You can specify additional directories where binaries should be searched. The following example specifies that all native binaries from `C:\temp` and its subdirectories should be instrumented except files ending with `Fabrikam.Math.dll`.

```xml
<ModulePaths>
  <IncludeDirectories>
    <Directory Recursive="true">C:\temp</Directory>
  </IncludeDirectories>
  <Exclude>
    <ModulePath>.*Fabrikam.Math.dll</ModulePath>
  </Exclude>
</ModulePaths>
```

::: moniker-end

### Include or exclude test assemblies

To include or exclude test assemblies from the coverage report, you can use the `<IncludeTestAssembly>` element in the `<Configuration>` section of your .runsettings file.

In this example, setting `<IncludeTestAssembly>` to `False` will exclude test assemblies from the code coverage report. If you want to include test assemblies, set it to `True`.

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- File name extension must be .runsettings -->
<RunSettings>
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="Code Coverage" uri="datacollector://Microsoft/CodeCoverage/2.0" assemblyQualifiedName="Microsoft.VisualStudio.Coverage.DynamicCoverageDataCollector, Microsoft.VisualStudio.TraceCollector, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
        <Configuration>
          <IncludeTestAssembly>False</IncludeTestAssembly>
          ...
        </Configuration>
      </DataCollector>
    </DataCollectors>
  </DataCollectionRunSettings>
</RunSettings>
```

> [!NOTE]
> The default value of `IncludeTestAssembly` in [VSTest](/visualstudio/test/vstest-console-options) is `true`, while it is `false` in [Microsoft.Testing.Platform](/dotnet/core/testing/microsoft-testing-platform-extensions-code-coverage). This means that test projects are included by default. For more information, see [Code Coverage configuration](https://github.com/microsoft/codecoverage/blob/main/docs/configuration.md).

### Regular expressions

Include and exclude nodes use regular expressions, which aren't the same as wildcards. All matches are case-insensitive. Some examples are:

- **.\*** matches a string of any characters

- **\\.** matches a dot "."

- **\\(   \\)** matches parentheses "(  )"

- **\\\\** matches a file path delimiter "\\"

- **^** matches the start of the string

- **$** matches the end of the string

The following XML shows how to include and exclude specific assemblies by using regular expressions:

```xml
<ModulePaths>
  <Include>
    <!-- Include all loaded .dll assemblies (but not .exe assemblies): -->
    <ModulePath>.*\.dll$</ModulePath>
  </Include>
  <Exclude>
    <!-- But exclude some assemblies: -->
    <ModulePath>.*\\Fabrikam\.MyTests1\.dll$</ModulePath>
    <!-- Exclude all file paths that contain "Temp": -->
    <ModulePath>.*Temp.*</ModulePath>
  </Exclude>
</ModulePaths>
```

The following XML shows how to include and exclude specific functions by using regular expressions:

```xml
<Functions>
  <Include>
    <!-- Include methods in the Fabrikam namespace: -->
    <Function>^Fabrikam\..*</Function>
    <!-- Include all methods named EqualTo: -->
    <Function>.*\.EqualTo\(.*</Function>
  </Include>
  <Exclude>
    <!-- Exclude methods in a class or namespace named UnitTest: -->
    <Function>.*\.UnitTest\..*</Function>
  </Exclude>
</Functions>
```

> [!WARNING]
> If there is an error in a regular expression, such as an unescaped or unmatched parenthesis, code coverage analysis won't run.

For more information about regular expressions, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

## Sample .runsettings file

Copy this code and edit it to suit your needs.

::: moniker range=">=vs-2022"

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- File name extension must be .runsettings -->
<RunSettings>
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="Code Coverage" uri="datacollector://Microsoft/CodeCoverage/2.0" assemblyQualifiedName="Microsoft.VisualStudio.Coverage.DynamicCoverageDataCollector, Microsoft.VisualStudio.TraceCollector, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
        <Configuration>
          <Format>coverage</Format>
          <CodeCoverage>
<!--
Additional paths to search for .pdb (symbol) files. Symbols must be found for modules to be instrumented.
If .pdb files are in the same folder as the .dll or .exe files, they are automatically found. Otherwise, specify them here.
Note that searching for symbols increases code coverage runtime. So keep this small and local.
-->
<!--
            <SymbolSearchPaths>
                   <Path>C:\Users\username\source\repos\ProjectX</Path>
                   <Path>\\mybuildshare\builds\ProjectX</Path>
            </SymbolSearchPaths>
-->

<!--
About include/exclude lists:
Empty "Include" clauses imply all; empty "Exclude" clauses imply none.
Each element in the list is a regular expression (ECMAScript syntax). See /visualstudio/ide/using-regular-expressions-in-visual-studio.
An item must first match at least one entry in the include list to be included.
Included items must then not match any entries in the exclude list to remain included.
-->

            <!-- Match assembly file paths: -->
            <ModulePaths>
              <Include>
                <ModulePath>.*\.dll$</ModulePath>
                <ModulePath>.*\.exe$</ModulePath>
              </Include>
              <Exclude>
                <ModulePath>.*CPPUnitTestFramework.*</ModulePath>
              </Exclude>
              <!-- Specifies additional list of directories where binaries static native instrumentation should be searched. -->
              <IncludeDirectories>
                <Directory Recursive="true">C:\b59fb11c-1611-4562-9a2b-c35719da65d3</Directory>
              </IncludeDirectories>
            </ModulePaths>

            <!-- Match fully qualified names of functions: -->
            <!-- (Use "\." to delimit namespaces in C# or Visual Basic, "::" in C++.)  -->
            <Functions>
              <Exclude>
                <Function>^Fabrikam\.UnitTest\..*</Function>
                <Function>^std::.*</Function>
                <Function>^ATL::.*</Function>
                <Function>.*::__GetTestMethodInfo.*</Function>
                <Function>^Microsoft::VisualStudio::CppCodeCoverageFramework::.*</Function>
                <Function>^Microsoft::VisualStudio::CppUnitTestFramework::.*</Function>
              </Exclude>
            </Functions>

            <!-- Match attributes on any code element: -->
            <Attributes>
              <Exclude>
                <!-- Don't forget "Attribute" at the end of the name -->
                <Attribute>^System\.Diagnostics\.DebuggerHiddenAttribute$</Attribute>
                <Attribute>^System\.Diagnostics\.DebuggerNonUserCodeAttribute$</Attribute>
                <Attribute>^System\.CodeDom\.Compiler\.GeneratedCodeAttribute$</Attribute>
                <Attribute>^System\.Diagnostics\.CodeAnalysis\.ExcludeFromCodeCoverageAttribute$</Attribute>
              </Exclude>
            </Attributes>

            <!-- Match the path of the source files in which each method is defined: -->
            <Sources>
              <Exclude>
                <Source>.*\\atlmfc\\.*</Source>
                <Source>.*\\vctools\\.*</Source>
                <Source>.*\\public\\sdk\\.*</Source>
                <Source>.*\\microsoft sdks\\.*</Source>
                <Source>.*\\vc\\include\\.*</Source>
              </Exclude>
            </Sources>

            <!-- Match the company name property in the assembly: -->
            <CompanyNames>
              <Exclude>
                <CompanyName>.*microsoft.*</CompanyName>
              </Exclude>
            </CompanyNames>

            <!-- Match the public key token of a signed assembly: -->
            <PublicKeyTokens>
              <!-- Exclude Visual Studio extensions: -->
              <Exclude>
                <PublicKeyToken>^B77A5C561934E089$</PublicKeyToken>
                <PublicKeyToken>^B03F5F7F11D50A3A$</PublicKeyToken>
                <PublicKeyToken>^31BF3856AD364E35$</PublicKeyToken>
                <PublicKeyToken>^89845DCD8080CC91$</PublicKeyToken>
                <PublicKeyToken>^71E9BCE111E9429C$</PublicKeyToken>
                <PublicKeyToken>^8F50407C4E9E73B6$</PublicKeyToken>
                <PublicKeyToken>^E361AF139669C375$</PublicKeyToken>
              </Exclude>
            </PublicKeyTokens>

            <!-- We recommend you do not change the following values: -->

            <!-- Set this to True to collect coverage information for functions marked with the "SecuritySafeCritical" attribute. Instead of writing directly into a memory location from such functions, code coverage inserts a probe that redirects to another function, which in turns writes into memory. -->
            <UseVerifiableInstrumentation>True</UseVerifiableInstrumentation>
            <!-- When set to True, collects coverage information from child processes that are launched with low-level ACLs, for example, UWP apps. -->
            <AllowLowIntegrityProcesses>True</AllowLowIntegrityProcesses>
            <!-- When set to True, collects coverage information from child processes that are launched by test or production code. -->
            <CollectFromChildProcesses>True</CollectFromChildProcesses>
            <!-- When set to True, restarts the IIS process and collects coverage information from it. -->
            <CollectAspDotNet>False</CollectAspDotNet>
            <!-- When set to True, static native instrumentation will be enabled. -->
            <EnableStaticNativeInstrumentation>True</EnableStaticNativeInstrumentation>
            <!-- When set to True, dynamic native instrumentation will be enabled. -->
            <EnableDynamicNativeInstrumentation>True</EnableDynamicNativeInstrumentation>
            <!-- When set to True, instrumented binaries on disk are removed and original files are restored. -->
            <EnableStaticNativeInstrumentationRestore>True</EnableStaticNativeInstrumentationRestore>
            <!-- When set to False, test assemblies will not be added to the coverage report. -->
            <IncludeTestAssembly>True</IncludeTestAssembly>
          </CodeCoverage>
        </Configuration>
      </DataCollector>
    </DataCollectors>
  </DataCollectionRunSettings>
</RunSettings>
```

::: moniker-end

::: moniker range="vs-2019"

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- File name extension must be .runsettings -->
<RunSettings>
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="Code Coverage" uri="datacollector://Microsoft/CodeCoverage/2.0" assemblyQualifiedName="Microsoft.VisualStudio.Coverage.DynamicCoverageDataCollector, Microsoft.VisualStudio.TraceCollector, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
        <Configuration>
          <CodeCoverage>
<!--
Additional paths to search for .pdb (symbol) files. Symbols must be found for modules to be instrumented.
If .pdb files are in the same folder as the .dll or .exe files, they are automatically found. Otherwise, specify them here.
Note that searching for symbols increases code coverage runtime. So keep this small and local.
-->
<!--
            <SymbolSearchPaths>
                   <Path>C:\Users\username\source\repos\ProjectX</Path>
                   <Path>\\mybuildshare\builds\ProjectX</Path>
            </SymbolSearchPaths>
-->

<!--
About include/exclude lists:
Empty "Include" clauses imply all; empty "Exclude" clauses imply none.
Each element in the list is a regular expression (ECMAScript syntax). See /visualstudio/ide/using-regular-expressions-in-visual-studio.
An item must first match at least one entry in the include list to be included.
Included items must then not match any entries in the exclude list to remain included.
-->

            <!-- Match assembly file paths: -->
            <ModulePaths>
              <Include>
                <ModulePath>.*\.dll$</ModulePath>
                <ModulePath>.*\.exe$</ModulePath>
              </Include>
              <Exclude>
                <ModulePath>.*CPPUnitTestFramework.*</ModulePath>
              </Exclude>
              <!-- Specifies additional list of directories where binaries static native instrumentation should be searched. -->
              <IncludeDirectories>
                <Directory Recursive="true">C:\b59fb11c-1611-4562-9a2b-c35719da65d3</Directory>
              </IncludeDirectories>
            </ModulePaths>

            <!-- Match fully qualified names of functions: -->
            <!-- (Use "\." to delimit namespaces in C# or Visual Basic, "::" in C++.)  -->
            <Functions>
              <Exclude>
                <Function>^Fabrikam\.UnitTest\..*</Function>
                <Function>^std::.*</Function>
                <Function>^ATL::.*</Function>
                <Function>.*::__GetTestMethodInfo.*</Function>
                <Function>^Microsoft::VisualStudio::CppCodeCoverageFramework::.*</Function>
                <Function>^Microsoft::VisualStudio::CppUnitTestFramework::.*</Function>
              </Exclude>
            </Functions>

            <!-- Match attributes on any code element: -->
            <Attributes>
              <Exclude>
                <!-- Don't forget "Attribute" at the end of the name -->
                <Attribute>^System\.Diagnostics\.DebuggerHiddenAttribute$</Attribute>
                <Attribute>^System\.Diagnostics\.DebuggerNonUserCodeAttribute$</Attribute>
                <Attribute>^System\.CodeDom\.Compiler\.GeneratedCodeAttribute$</Attribute>
                <Attribute>^System\.Diagnostics\.CodeAnalysis\.ExcludeFromCodeCoverageAttribute$</Attribute>
              </Exclude>
            </Attributes>

            <!-- Match the path of the source files in which each method is defined: -->
            <Sources>
              <Exclude>
                <Source>.*\\atlmfc\\.*</Source>
                <Source>.*\\vctools\\.*</Source>
                <Source>.*\\public\\sdk\\.*</Source>
                <Source>.*\\microsoft sdks\\.*</Source>
                <Source>.*\\vc\\include\\.*</Source>
              </Exclude>
            </Sources>

            <!-- Match the company name property in the assembly: -->
            <CompanyNames>
              <Exclude>
                <CompanyName>.*microsoft.*</CompanyName>
              </Exclude>
            </CompanyNames>

            <!-- Match the public key token of a signed assembly: -->
            <PublicKeyTokens>
              <!-- Exclude Visual Studio extensions: -->
              <Exclude>
                <PublicKeyToken>^B77A5C561934E089$</PublicKeyToken>
                <PublicKeyToken>^B03F5F7F11D50A3A$</PublicKeyToken>
                <PublicKeyToken>^31BF3856AD364E35$</PublicKeyToken>
                <PublicKeyToken>^89845DCD8080CC91$</PublicKeyToken>
                <PublicKeyToken>^71E9BCE111E9429C$</PublicKeyToken>
                <PublicKeyToken>^8F50407C4E9E73B6$</PublicKeyToken>
                <PublicKeyToken>^E361AF139669C375$</PublicKeyToken>
              </Exclude>
            </PublicKeyTokens>

            <!-- We recommend you do not change the following values: -->

            <!-- Set this to True to collect coverage information for functions marked with the "SecuritySafeCritical" attribute. Instead of writing directly into a memory location from such functions, code coverage inserts a probe that redirects to another function, which in turns writes into memory. -->
            <UseVerifiableInstrumentation>True</UseVerifiableInstrumentation>
            <!-- When set to True, collects coverage information from child processes that are launched with low-level ACLs, for example, UWP apps. -->
            <AllowLowIntegrityProcesses>True</AllowLowIntegrityProcesses>
            <!-- When set to True, collects coverage information from child processes that are launched by test or production code. -->
            <CollectFromChildProcesses>True</CollectFromChildProcesses>
            <!-- When set to True, restarts the IIS process and collects coverage information from it. -->
            <CollectAspDotNet>False</CollectAspDotNet>

          </CodeCoverage>
        </Configuration>
      </DataCollector>
    </DataCollectors>
  </DataCollectionRunSettings>
</RunSettings>
```

::: moniker-end

## Related content

- [Configure unit tests by using a run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)
- [Unit test your code](../test/unit-test-your-code.md)
