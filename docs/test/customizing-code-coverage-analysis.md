---
title: "Customizing Code Coverage Analysis in Visual Studio"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
ms.topic: conceptual
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
author: gewarren
---
# Customize code coverage analysis

By default, the Visual Studio Code Coverage tool analyzes all solution assemblies that are loaded during unit tests. We recommend that you retain this default, because it works well most of the time. For more information, see [Using Code Coverage to Determine How Much Code is being Tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md).

Before customizing the code coverage behavior, consider some alternatives:

- *I want to exclude the test code from the code coverage results and include only the application code.*

     Add the `ExcludeFromCodeCoverage Attribute` to your test class.

- *I want to include assemblies that are not part of my solution.*

     Obtain the .pdb files for these assemblies and copy them into the same folder as the assembly .dll files.

To customize the code coverage behavior, copy the [sample at the end of this topic](#sample) and add it to your solution, using the file extension *.runsettings*. Edit it to your own needs, and then on the **Test** menu, choose **Test Settings**, **Select Test Settings** file. The remainder of this article describes this procedure in more detail.

## The run settings file

Advanced code coverage settings are specified in a *.runsettings* file. The run settings file is the configuration file used by unit testing tools. We recommend you copy the [sample at the end of this topic](#sample) and edit it to suit your own needs.

To customize code coverage, add a run settings file to your solution:

1. Add an .xml file as a solution item with the extension *.runsettings*:

     In Solution Explorer, on the shortcut menu of your solution, choose **Add** > **New Item**, and select **XML File**. Save the file with a name ending such as *CodeCoverage.runsettings*.

2. Add the content from the example at the end of this article, and then customize it to your needs as described in the sections that follow.

3. On the **Test** menu, choose **Test Settings** > **Select Test Settings File** and select the file.

4. Now when you run **Analyze Code Coverage**, the run settings file will control its behavior. Don't forget that you must run code coverage again. The previous coverage results and code coloring aren't automatically hidden when you run tests or update your code.

5. To turn the custom settings off and on, deselect or select the file in the **Test** > **Test Settings** menu.

 ![Test settings menu with custom settings file](../test/media/codecoverage-settingsfile.png)

Other aspects of unit tests can be configured in the same run settings file. For more information, see [Unit Test Your Code](../test/unit-test-your-code.md).

### Specifying symbol search paths

Code coverage requires symbols (.pdb files) for assemblies to be present. For assemblies built by your solution, symbol files are usually present alongside the binary files, and code coverage works automatically. But in some cases, you might want to include referenced assemblies in your code coverage analysis. In such cases, the .pdb files might not be adjacent to the binaries, but you can specify the symbol search path in the .runsettings file.

```xml
<SymbolSearchPaths>
      <Path>\\mybuildshare\builds\ProjectX</Path>
      <!--More paths if required-->
</SymbolSearchPaths>
```

> [!WARNING]
> Symbol resolution can take time, especially when using a remote file location with many assemblies. Therefore, consider copying remote .pdb files to the same local location as the binary (.dll and .exe) files.

### Excluding and including

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

If `<Include>` is empty, then code coverage processing includes all assemblies that are loaded, and for which .pdb files can be found. Code coverage does not include items that match a clause in an `<Exclude>` list.

`Include` is processed before `Exclude`.

### Regular expressions

Include and exclude nodes use regular expressions. For more information, see [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md). Regular expressions are not the same as wildcards. In particular:

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
> If there is an error in a regular expression, such as an unescaped and unmatched parenthesis, then code coverage analysis will not run.

### Other ways to include or exclude elements

See the [sample at the end of this topic](#sample) for examples.

- `ModulePath` - Assemblies specified by assembly file path.

- `CompanyName` - matches assemblies by the Company attribute.

- `PublicKeyToken` - matches signed assemblies by the public key token. For example to match all Visual Studio components and extensions, use `<PublicKeyToken>^B03F5F7F11D50A3A$</PublicKeyToken>`.

- `Source` - matches elements by the path name of the source file in which they are defined.

- `Attribute` - matches elements to which a particular attribute is attached. Specify the full name of the attribute, including "Attribute" at the end of the name.

- `Function` - matches procedures, functions, or methods by fully qualified name.

**Matching a function name**

Your regular expression must match the fully qualified name of the function, including namespace, class name, method name, and parameter list. For example,

- C# or Visual Basic: `Fabrikam.Math.LocalMath.SquareRoot(double)`

- C++:  `Fabrikam::Math::LocalMath::SquareRoot(double)`

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

## How to specify run settings files while running tests

### To customize run settings in Visual Studio tests

Choose **Test** > **Test Settings** > **Select Test Settings File** and select the *.runsettings* file. The file appears on the Test Settings menu, and you can select or cancel it. While selected, your run settings file applies whenever you use **Analyze Code Coverage**.

### To customize run settings in a command-line test

To run tests from the command line, use *vstest.console.exe*. The settings file is a parameter of this utility.

1. Launch the Visual Studio Developer Command Prompt:

    On the Windows **Start** menu, choose **Visual Studio 2017** > **Developer Command Prompt for VS 2017**.

2. Run the following command:

    `vstest.console.exe MyTestAssembly.dll /EnableCodeCoverage /Settings:CodeCoverage.runsettings`

### To customize run settings in a build definition

You can get code coverage data from a team build.

![Specifying runsettings in a build definition](../test/media/codecoverage-buildrunsettings.png)

1. Make sure your run settings file is checked in.

2. In Team Explorer, open **Builds**, and then add or edit a build definition.

3. On the **Process** page, expand **Automated Tests** > **Test Source** > **Run Settings**. Select the *.runsettings* file.

   > [!TIP]
   > If **Test Assembly** appears instead of **Test Source**, and you can only select *.testsettings* files, set the **Test Runner** property as follows. Under **Automated Tests**, select **Test Assembly**, and then choose **[...]** at the end of the line. In the **Add/Edit Test Run** dialog box, set **Test Runner** to **Visual Studio Test Runner**.

The results are visible in the summary section of the build report.

##  <a name="sample"></a> Sample .runsettings file

Copy this code and edit it to suit your own needs.

(For other uses of the run settings file, see [Configure unit tests by using a run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md).)

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
Each element in the list is a regular expression (ECMAScript syntax). See http://msdn.microsoft.com/library/2k3te2cs.aspx.
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

- [Using Code Coverage to Determine How Much Code is being Tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)
- [Unit Test Your Code](../test/unit-test-your-code.md)