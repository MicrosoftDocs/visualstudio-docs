---
title: Evaluate MSBuild items and properties
description: Execute MSBuild to evaluate items and properties, without necessarily running a full build, or get the results of running a specific target or targets.
ms.date: 11/30/2023
ms.topic: how-to
helpviewer_keywords:
- MSBuild, getProperty
- MSBuild, getItem
- MSBuild, getTargetResult
- getProperty [MSBuild]
- getItem [MSBuild]
- getTargetResult [MSBuild]
- evaluation [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Evaluate items and properties and display results of targets

You can get the values that MSBuild items and properties would have without executing a build. This option is helpful when you need these values as inputs for the desired build process, but you need to evaluate a project to get the value.

You can also generate formatted output for the results returned from built MSBuild targets. This could be helpful in scenarios where you're authoring a build tool and need to do something with the outputs of a particular target.

## Use command-line options to output values

The following command-line options are available in MSBuild 17.8 and later.

| Command-line option | Description |
| - | - |
|`-getProperty:{propertyName,...}` | Get the value of the specified property or properties. |
|`-getItem:{itemName,...}` | Get the value(s) and associated metadata of the specified item or items. |
|`-getTargetResult:{targetName,...}` | Get the output values of the target or targets. |

If you don't specify a target on the command line by using the `-target` option, then the `-getProperty` and `-getItem` options return the values from MSBuild evaluation, and no targets are built. If the `-target` option is specified, then the property or item values returned are the values after the build is finished, that is, after all requested targets have run to completion.

If you specify `-getTargetResult`, any targets requested are automatically built, as if you specified them with `-target`, along with any other targets you requested.

Be aware that properties are evaluated before items, so if you're using `-getProperty` for a property that references an item, you get a different result depending on whether or not you request the value before or after item evaluation occurs.  For example, if you use `-getProperty` without using the `-target` option (or `-getTargetResult`), then you get the property's value before item evaluation, but if you do specify `-targets` (or `-getTargetResult`), then you get the value after item evaluation. See [How MSBuild builds projects](build-process-overview.md).

You can use these commands with `MSBuild.exe` or with `dotnet build`, or other `dotnet` commands such as `dotnet publish`. See [MSBuild command-line reference](msbuild-command-line-reference.md) and [dotnet command](/dotnet/core/tools/dotnet).

If you use `-getProperty` to request a single property, the output is emitted as a string of text. That means you can easily consume the value in scripting scenarios, or within a more complex command line.

If you use `-getProperty` to request multiple properties, or use `-getItem` or `-getTargetResult`, the output is in a JSON format. Items are emitted with their associated metadata.

For example, the following command requests two properties, the `Compile` item, and the results from the `Build` target:

```dotnetcli
msbuild ConsoleApp1.csproj -getProperty:TargetFramework,OutDir -getItem:Compile -getTargetResult:Build
```

The command produces the following JSON output, with properties, items, and target results grouped together in that order:

```json
{
  "Properties": {
    "TargetFramework": "net6.0",
    "OutDir": "bin\\Debug\\net6.0\\"
  },
  "Items": {
    "Compile": [
      {
        "Identity": "Program.cs",
        "FullPath": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Program.cs",
        "RootDir": "c:\\",
        "Filename": "Program",
        "Extension": ".cs",
        "RelativeDir": "",
        "Directory": "source\\repos\\ConsoleApp1\\ConsoleApp1\\",
        "RecursiveDir": "",
        "ModifiedTime": "2022-07-26 14:40:20.2657461",
        "CreatedTime": "2022-07-26 14:40:13.0808797",
        "AccessedTime": "2023-11-30 13:38:05.4556046",
        "DefiningProjectFullPath": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\Microsoft.NET.Sdk.DefaultItems.props",
        "DefiningProjectDirectory": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\",
        "DefiningProjectName": "Microsoft.NET.Sdk.DefaultItems",
        "DefiningProjectExtension": ".props"
      },
      {
        "Identity": "obj\\Debug\\net6.0\\ConsoleApp1.GlobalUsings.g.cs",
        "FullPath": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\ConsoleApp1.GlobalUsings.g.cs",
        "RootDir": "c:\\",
        "Filename": "ConsoleApp1.GlobalUsings.g",
        "Extension": ".cs",
        "RelativeDir": "obj\\Debug\\net6.0\\",
        "Directory": "source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\",
        "RecursiveDir": "",
        "ModifiedTime": "2022-07-26 14:40:30.6973207",
        "CreatedTime": "2022-07-26 14:40:30.6968276",
        "AccessedTime": "2023-11-30 13:38:05.4556046",
        "DefiningProjectFullPath": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\Microsoft.NET.GenerateGlobalUsings.targets",
        "DefiningProjectDirectory": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\",
        "DefiningProjectName": "Microsoft.NET.GenerateGlobalUsings",
        "DefiningProjectExtension": ".targets"
      },
      {
        "Identity": "obj\\Debug\\net6.0\\.NETCoreApp,Version=v6.0.AssemblyAttributes.cs",
        "FullPath": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\.NETCoreApp,Version=v6.0.AssemblyAttributes.cs",
        "RootDir": "c:\\",
        "Filename": ".NETCoreApp,Version=v6.0.AssemblyAttributes",
        "Extension": ".cs",
        "RelativeDir": "obj\\Debug\\net6.0\\",
        "Directory": "source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\",
        "RecursiveDir": "",
        "ModifiedTime": "2023-11-30 13:38:04.4893499",
        "CreatedTime": "2022-07-26 14:40:31.9799773",
        "AccessedTime": "2023-11-30 13:38:05.4556046",
        "DefiningProjectFullPath": "C:\\Program Files\\Microsoft Visual Studio\\2022\\Preview\\MSBuild\\Current\\Bin\\amd64\\Microsoft.Common.CurrentVersion.targets",
        "DefiningProjectDirectory": "C:\\Program Files\\Microsoft Visual Studio\\2022\\Preview\\MSBuild\\Current\\Bin\\amd64\\",
        "DefiningProjectName": "Microsoft.Common.CurrentVersion",
        "DefiningProjectExtension": ".targets"
      },
      {
        "Identity": "obj\\Debug\\net6.0\\ConsoleApp1.AssemblyInfo.cs",
        "FullPath": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\ConsoleApp1.AssemblyInfo.cs",
        "RootDir": "c:\\",
        "Filename": "ConsoleApp1.AssemblyInfo",
        "Extension": ".cs",
        "RelativeDir": "obj\\Debug\\net6.0\\",
        "Directory": "source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\",
        "RecursiveDir": "",
        "ModifiedTime": "2023-11-30 13:38:04.5569391",
        "CreatedTime": "2022-07-26 14:40:32.0372385",
        "AccessedTime": "2023-11-30 13:38:05.4556046",
        "DefiningProjectFullPath": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\Microsoft.NET.GenerateAssemblyInfo.targets",
        "DefiningProjectDirectory": "C:\\Program Files\\dotnet\\sdk\\8.0.100\\Sdks\\Microsoft.NET.Sdk\\targets\\",
        "DefiningProjectName": "Microsoft.NET.GenerateAssemblyInfo",
        "DefiningProjectExtension": ".targets"
      }
    ]
  },
  "TargetResults": {
    "Build": {
      "Result": "Success",
      "Items": [
        {
          "Identity": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\ConsoleApp1.dll",
          "TargetFrameworkIdentifier": ".NETCoreApp",
          "TargetPlatformMoniker": "",
          "CopyUpToDateMarker": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\ConsoleApp1.csproj.CopyComplete",
          "TargetPlatformIdentifier": "",
          "TargetFrameworkVersion": "6.0",
          "ReferenceAssembly": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\obj\\Debug\\net6.0\\ref\\ConsoleApp1.dll",
          "FullPath": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\ConsoleApp1.dll",
          "RootDir": "c:\\",
          "Filename": "ConsoleApp1",
          "Extension": ".dll",
          "RelativeDir": "c:\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\",
          "Directory": "source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\",
          "RecursiveDir": "",
          "ModifiedTime": "2023-11-30 13:38:06.5084339",
          "CreatedTime": "2023-11-30 13:38:06.9308716",
          "AccessedTime": "2023-11-30 13:38:06.9318732",
          "DefiningProjectFullPath": "C:\\Program Files\\Microsoft Visual Studio\\2022\\Preview\\MSBuild\\Current\\Bin\\amd64\\Microsoft.Common.CurrentVersion.targets",
          "DefiningProjectDirectory": "C:\\Program Files\\Microsoft Visual Studio\\2022\\Preview\\MSBuild\\Current\\Bin\\amd64\\",
          "DefiningProjectName": "Microsoft.Common.CurrentVersion",
          "DefiningProjectExtension": ".targets"
        }
      ]
    }
  }
}
```

Of course, you can save the output to a file instead of writing to the console by redirecting the standard output using the `>` symbol, as provided by the shell.

## Next steps

The command-line options described here work based on how MSBuild separates the evaluation phase, in which properties and items are assigned their values, and the execution phase, in which targets run and produce outputs. Learn more about MSBuild build evaluation and execution phases at [How MSBuild builds projects](build-process-overview.md).
