---
title: "Customizing Code Coverage Analysis"
ms.date: 08/21/2019
ms.topic: conceptual
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Customize code coverage analysis

By default, code coverage analyzes all solution assemblies that are loaded during unit tests. We recommend that you use this default behavior, because it works well most of the time. For more information, see [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

To exclude test code from the code coverage results and only include application code, add the <xref:System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute> attribute to your test class.

To include assemblies that aren't part of your solution, obtain the *.pdb* files for these assemblies and copy them into the same folder as the assembly *.dll* files.

## Run settings file

The [run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md) is the configuration file used by unit testing tools. Advanced code coverage settings are specified in a *.runsettings* file.

To customize code coverage, follow these steps:

1. Add a run settings file to your solution. In **Solution Explorer**, on the shortcut menu of your solution, choose **Add** > **New Item**, and select **XML File**. Save the file with a name such as *CodeCoverage.runsettings*.

2. Add the content from the example file at the end of this article, and then customize it to your needs as described in the sections that follow.

::: moniker range="vs-2017"

3. To select the run settings file, on the **Test** menu, choose **Test Settings** > **Select Test Settings File**. To specify a run settings file for running tests from the command line, see [Configure unit tests](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#command-line).

::: moniker-end

::: moniker range=">=vs-2019"

3. To select the run settings file, on the **Test** menu, choose **Select Settings File**. To specify a run settings file for running tests from the command line, see [Configure unit tests](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#command-line).

::: moniker-end

   When you select **Analyze Code Coverage**, the configuration information is read from the run settings file.

   > [!TIP]
   > Any previous code coverage results and code coloring aren't automatically hidden when you run tests or update your code.

::: moniker range="vs-2017"

To turn the custom settings off and on, deselect or select the file in the **Test** > **Test Settings** menu.

![Test settings menu with custom settings file in Visual Studio 2017](../test/media/codecoverage-settingsfile.png)

::: moniker-end

::: moniker range=">=vs-2019"

To turn the custom settings off and on, deselect or select the file on the **Test** menu.

::: moniker-end

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
   <ModulePath>Fabrikam.Math.UnitTest.dll</ModulePath>
   <!-- Add more ModulePath nodes here. -->
  </Exclude>
</ModulePaths>
```

The following example specifies that only a single assembly should be included in code coverage:

```xml
<ModulePaths>
  <Include>
   <ModulePath>Fabrikam.Math.dll</ModulePath>
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
                   <Path>C:\Users\User\Documents\Visual Studio 2012\Projects\ProjectX\bin\Debug</Path>
                   <Path>\\mybuildshare\builds\ProjectX</Path>
            </SymbolSearchPaths>
-->

<!--
About include/exclude lists:
Empty "Include" clauses imply all; empty "Exclude" clauses imply none.
Each element in the list is a regular expression (ECMAScript syntax). See https://docs.microsoft.com/visualstudio/ide/using-regular-expressions-in-visual-studio.
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

## See also

- [Configure unit tests by using a run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)
- [Unit test your code](../test/unit-test-your-code.md)
