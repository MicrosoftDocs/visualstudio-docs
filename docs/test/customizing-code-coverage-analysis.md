---
title: "Customizing Code Coverage Analysis"
ms.date: 11/04/2016
ms.topic: conceptual
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
author: gewarren
---
# Customize code coverage analysis

By default, code coverage analyzes all solution assemblies that are loaded during unit tests. We recommend that you use this default behavior, because it works well most of the time. For more information, see [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

To exclude test code from the code coverage results and only include application code, add the <xref:System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute> attribute to your test class.

To include assemblies that aren't part of your solution, obtain the *.pdb* files for these assemblies and copy them into the same folder as the assembly *.dll* files.

## Run settings file

The [run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md) is the configuration file used by unit testing tools. Advanced code coverage settings are specified in a *.runsettings* file.

To customize code coverage, follow these steps:

1. Add a run settings file to your solution. In **Solution Explorer**, on the shortcut menu of your solution, choose **Add** > **New Item**, and select **XML File**. Save the file with a name such as *CodeCoverage.runsettings*.

1. Add the content from the example file at the end of this article, and then customize it to your needs as described in the sections that follow.

1. To select the run settings file, on the **Test** menu, choose **Test Settings** > **Select Test Settings File**. To specify a run settings file for running tests from the command line or in a build workflow, see [Configure unit tests by using a *.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md#specify-a-run-settings-file).

   When you select **Analyze Code Coverage**, the configuration information is read from the run settings file.

   > [!TIP]
   > The previous code coverage results and code coloring aren't automatically hidden when you run tests or update your code.

To turn the custom settings off and on, deselect or select the file in the **Test** > **Test Settings** menu.

![Test settings menu with custom settings file](../test/media/codecoverage-settingsfile.png)

### Specify symbol search paths

Code coverage requires symbol files (*.pdb* files) for assemblies. For assemblies built by your solution, symbol files are usually present alongside the binary files and code coverage works automatically. But in some cases, you might want to include referenced assemblies in your code coverage analysis. In such cases, the *.pdb* files might not be adjacent to the binaries, but you can specify the symbol search path in the *.runsettings* file.

```xml
<SymbolSearchPaths>
      <Path>\\mybuildshare\builds\ProjectX</Path>
      <!--More paths if required-->
</SymbolSearchPaths>
```

> [!NOTE]
> Symbol resolution can take time, especially when using a remote file location with many assemblies. Therefore, consider copying *.pdb* files to the same local location as the binary (*.dll* and *.exe*) files.

### Exclude and include

You can exclude specified assemblies from code coverage analysis. For example:

```xml
<ModulePaths>
  <Exclude>
   <ModulePath>Fabrikam.Math.UnitTest.dll</ModulePath>
   <!-- Add more ModulePath nodes here. -->
  </Exclude>
</ModulePaths>
```

As an alternative, you can specify which assemblies should be included. This approach has the drawback that when you add more assemblies to the solution, you have to remember to add them to the list:

```xml
<ModulePaths>
  <Include>
   <ModulePath>Fabrikam.Math.dll</ModulePath>
   <!-- Add more ModulePath nodes here. -->
  </Include>
</ModulePaths>
```

If **Include** is empty, then code coverage processing includes all assemblies that are loaded, and for which *.pdb* files can be found. Code coverage does not include items that match a clause in an **Exclude** list.

**Include** is processed before **Exclude**.

### Regular expressions

Include and exclude nodes use regular expressions. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md). Regular expressions aren't the same as wildcards. In particular:

- **.\*** matches a string of any characters

- **\\.** matches a dot ".")

- **\\(   \\)** matches parentheses "(  )"

- **\\\\** matches a file path delimiter "\\"

- **^** matches the start of the string

- **$** matches the end of the string

All matches are case-insensitive.

For example:

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

> [!WARNING]
> If there is an error in a regular expression, such as an unescaped or unmatched parenthesis, code coverage analysis won't run.

### Other ways to include or exclude elements

- **ModulePath** - matches assemblies specified by assembly file path.

- **CompanyName** - matches assemblies by the **Company** attribute.

- **PublicKeyToken** - matches signed assemblies by the public key token.

- **Source** - matches elements by the path name of the source file in which they are defined.

- **Attribute** - matches elements to which a particular attribute is attached. Specify the full name of the attribute, and include "Attribute" at the end of the name.

- **Function** - matches procedures, functions, or methods by fully qualified name. To match a function name, the regular expression must match the fully qualified name of the function, including namespace, class name, method name, and parameter list. For example:

   ```csharp
   Fabrikam.Math.LocalMath.SquareRoot(double);
   ```

   ```cpp
   Fabrikam::Math::LocalMath::SquareRoot(double)
   ```

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
                <Attribute>^System\.Runtime\.CompilerServices.CompilerGeneratedAttribute$</Attribute>
                <Attribute>^System\.CodeDom\.Compiler.GeneratedCodeAttribute$</Attribute>
                <Attribute>^System\.Diagnostics\.CodeAnalysis.ExcludeFromCodeCoverageAttribute$</Attribute>
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
            <UseVerifiableInstrumentation>True</UseVerifiableInstrumentation>
            <AllowLowIntegrityProcesses>True</AllowLowIntegrityProcesses>
            <CollectFromChildProcesses>True</CollectFromChildProcesses>
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
