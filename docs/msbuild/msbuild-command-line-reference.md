---
title: MSBuild Command-Line Reference | Microsoft Docs
description: Learn how to use MSBuild.exe command line to build a project or solution file, and several switches you can include.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, msbuild.exe
- MSBuild, command line reference
- msbuild.exe
ms.assetid: edaa65ec-ab8a-42a1-84cb-d76d5b2f4584
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild command-line reference

When you use *MSBuild.exe* to build a project or solution file, you can include several switches to specify various aspects of the process.

Every switch is available in two forms: -switch and /switch. The documentation only shows the -switch form. Switches are not case-sensitive. If you run MSBuild from a shell other than the Windows command prompt, lists of arguments to a switch (separated by semicolons or commas) might need single or double quotes to ensure that lists are passed to MSBuild instead of interpreted by the shell.

## Syntax

```cmd
MSBuild.exe [Switches] [ProjectFile]
```

## Arguments

|Argument|Description|
|--------------|-----------------|
|`ProjectFile`|Builds the targets in the project file that you specify. If you don't specify a project file, MSBuild searches the current working directory for a file name extension that ends in *proj* and uses that file. You can also specify a Visual Studio solution file for this argument.|

## Switches

|Switch|Short form|Description|
|------------|----------------|-----------------|
|-detailedSummary|-ds|Show detailed information at the end of the build log about the configurations that were built and how they were scheduled to nodes.|
|-graphBuild[:`True` or `False`]|-graph[:`True` or `False`]|Causes MSBuild to construct and build a project graph. Constructing a graph involves identifying project references to form dependencies. Building that graph involves attempting to build project references prior to the projects that reference them, differing from traditional MSBuild scheduling. Requires MSBuild 16 or later.|
|-help|/? or -h|Display usage information. The following command is an example:<br /><br /> `msbuild.exe -?`|
|-ignoreProjectExtensions: `extensions`|-ignore: `extensions`|Ignore the specified extensions when determining which project file to build. Use a semicolon or a comma to separate multiple extensions, as the following example shows:<br /><br /> `-ignoreprojectextensions:.vcproj,.sln`|
|-interactive[:`True` or `False`]|-|Indicates that actions in the build are allowed to interact with the user.  Do not use this argument in an automated scenario where interactivity is not expected. Specifying -interactive is the same as specifying -interactive:true.  Use the parameter to override a value that comes from a response file.
|-isolateProjects[:`True` or `False`]|-isolate[:`True` or `False`]|Causes MSBuild to build each project in isolation. This is a more restrictive mode of MSBuild as it requires that the project graph be statically discoverable at evaluation time, but can improve scheduling and reduce memory overhead when building a large set of projects.|
|-maxCpuCount[:`number`]|-m[:`number`]|Specifies the maximum number of concurrent processes to use when building. If you don't include this switch, the default value is 1. If you include this switch without specifying a value, MSBuild will use up to the number of processors in the computer. For more information, see [Building multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md).<br /><br /> The following example instructs MSBuild to build using three MSBuild processes, which allows three projects to build at the same time:<br /><br /> `msbuild myproject.proj -maxcpucount:3`|
|-noAutoResponse|-noautorsp|Don't include any *MSBuild.rsp* files automatically.|
|-nodeReuse:`value`|-nr:`value`|Enable or disable the re-use of MSBuild nodes. You can specify the following values:<br /><br /> -   **True**. Nodes remain after the build finishes so that subsequent builds can use them (default).<br />-   **False**. Nodes don't remain after the build completes.<br /><br /> A node corresponds to a project that's executing. If you include the **-maxcpucount** switch, multiple nodes can execute concurrently.|
|-nologo||Don't display the startup banner or the copyright message.|
|<a name="preprocess"></a> -preprocess[:`filepath`]|-pp[:`filepath`]|Create a single, aggregated project file by inlining all the files that would be imported during a build, with their boundaries marked. You can use this switch to more easily determine which files are being imported, from where the files are being imported, and which files contribute to the build. When you use this switch, the project isn't built.<br /><br /> If you specify a `filepath`, the aggregated project file is output to the file. Otherwise, the output appears in the console window.<br /><br /> For information about how to use the `Import` element to insert a project file into another project file, see [Import element (MSBuild)](../msbuild/import-element-msbuild.md) and [How to: Use the same target in multiple project files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md).|
|-outputResultsCache[:cacheFile]|-orc[:cacheFile]|Output cache file where MSBuild will write the contents of its build result caches at the end of the build. Setting this also turns on isolated builds (-isolate).|
|-profileEvaluation:`<file>`|-|Profiles MSBuild evaluation and writes the result to the specified file. If the extension of the specified file is '.md', the result is generated in Markdown format. Otherwise, a tab-separated file is produced.|
|-property:`name`=`value`|-p:`name`=`value`|Set or override the specified project-level properties, where `name` is the property name and `value` is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:<br /><br /> `-property:WarningLevel=2;OutDir=bin\Debug`|
|-restore|-r|Runs the `Restore` target prior to building the actual targets.|
|-restoreProperty:`name=value`|-rp:`name=value`|Set or override these project-level properties only during restore and do not use properties specified with the -property argument. `name` is the property name, and `value` is the property value. Use a semicolon or a comma to separate multiple properties, or specify each property separately.|
|-target:`targets`|-t:`targets`|Build the specified targets in the project. Specify each target separately, or use a semicolon or comma to separate multiple targets, as the following example shows:<br /><br /> `-target:PrepareResources;Compile`<br /><br /> If you specify any targets by using this switch, they are run instead of any targets in the `DefaultTargets` attribute in the project file. For more information, see [Target build order](../msbuild/target-build-order.md) and [How to: Specify which target to build first](../msbuild/how-to-specify-which-target-to-build-first.md).<br /><br /> A target is a group of tasks. For more information, see [Targets](../msbuild/msbuild-targets.md).|
|-targets[:`file`]|-ts[:`file`]|Write the list of available targets to the specified file (or the output device, if no file is specified), without actually executing the build process.|
|-toolsVersion:`version`|-tv:`version`|Specifies the version of the Toolset to use to build the project, as the following example shows: `-toolsversion:3.5`<br /><br /> By using this switch, you can build a project and specify a version that differs from the version that's specified in the [Project element (MSBuild)](../msbuild/project-element-msbuild.md). For more information, see [Overriding ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).<br /><br /> For MSBuild 4.5, you can specify the following values for `version`: 2.0, 3.5, and 4.0. If you specify 4.0, the `VisualStudioVersion` build property specifies which sub-toolset to use. For more information, see the Sub-toolsets section of [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md).<br /><br /> A Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as *csc.exe* and *vbc.exe*. For more information about Toolsets, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md), [Standard and custom toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md), and [Multitargeting](../msbuild/msbuild-multitargeting-overview.md). **Note:**  The toolset version isn't the same as the target framework, which is the version of the .NET Framework on which a project is built to run. For more information, see [Target framework and target platform](../msbuild/msbuild-target-framework-and-target-platform.md).|
|-validate:[`schema`]|-val[`schema`]|Validate the project file and, if validation succeeds, build the project.<br /><br /> If you don't specify `schema`, the project is validated against the default schema.<br /><br /> If you specify `schema`, the project is validated against the schema that you specify.<br /><br /> The following setting is an example: `-validate:MyExtendedBuildSchema.xsd`|
|-verbosity:`level`|-v:`level`|Specifies the amount of information to display in the build log. Each logger displays events based on the verbosity level that you set for that logger.<br /><br /> You can specify the following verbosity levels: `q[uiet]`, `m[inimal]`, `n[ormal]` (default), `d[etailed]`, and `diag[nostic]`.<br /><br /> The following setting is an example: `-verbosity:quiet`
|-version|-ver|Display version information only. The project isn't built.|
|@`file`||Insert command-line switches from a text file. If you have multiple files, you specify them separately. For more information, see [Response files](../msbuild/msbuild-response-files.md).|
|-warnAsError[:`code`[`;code2`]|-err[`:code`[`;code2`]|List of warning codes to treats as errors.  Use a semicolon or a comma to separate multiple warning codes. To treat all warnings as errors, use the switch with no values. When a warning is treated as an error the target continues to execute as if it was a warning but the overall build fails.<br/><br/>Example: `-err:MSB4130`|
|-warnAsMessage[:`code`[`;code2`]|-noWarn[:`code`[`;code2`]|List of warning codes to treats as low importance messages.  Use a semicolon or a comma to separate multiple warning codes.<br/><br/>Example: `-noWarn:MSB3026`|

### Switches for loggers

|Switch|Short form|Description|
|------------|----------------|-----------------|
|-binaryLogger[:[LogFile=]`output.binlog`<br/>[;ProjectImports=[None,Embed,ZipFile]]]|-bl|Serializes all build events to a compressed binary file. By default the file is in the current directory and named *msbuild.binlog*. The binary log is a detailed description of the build process that can later be used to reconstruct text logs and used by other analysis tools. A binary log is usually 10-20x smaller than the most detailed text diagnostic-level log, but it contains more information.<br /><br />The binary logger by default collects the source text of project files, including all imported projects and target files encountered during the build. The optional `ProjectImports` switch controls this behavior:<br /><br /> -   **ProjectImports=None**. Don't collect the project imports.<br /> -   **ProjectImports=Embed**. Embed project imports in the log file (default).<br /> -   **ProjectImports=ZipFile**. Save project files to *\<output>.projectimports.zip* where \<output> is the same name as the binary log file name.<br /><br />The default setting for ProjectImports is Embed.<br />**Note**: the logger does not collect non-MSBuild source files such as *.cs*, *.cpp* etc.<br />A *.binlog* file can be "played back" by passing it to *msbuild.exe* as an argument instead of a project/solution. Other loggers will receive the information contained in the log file as if the original build was happening. You can read more about the binary log and its usages at: https://github.com/dotnet/msbuild/blob/main/documentation/wiki/Binary-Log.md <br /><br />**Examples**:<br /> -   `-bl`<br /> -    `-bl:output.binlog`<br /> -   `-bl:output.binlog;ProjectImports=None`<br /> -   `-bl:output.binlog;ProjectImports=ZipFile`<br /> -   `-bl:..\..\custom.binlog`<br /> -   `-binaryLogger`|
|-consoleLoggerParameters:<br /><br /> `parameters`|-clp:`parameters`|Pass the parameters that you specify to the console logger, which displays build information in the console window. You can specify the following parameters:<br /><br /> -   **PerformanceSummary**. Show the time that's spent in tasks, targets, and projects.<br />-   **Summary**. Show the error and warning summary at the end.<br />-   **NoSummary**. Don't show the error and warning summary at the end.<br />-   **ErrorsOnly**. Show only errors.<br />-   **WarningsOnly**. Show only warnings.<br />-   **NoItemAndPropertyList**. Don't show the list of items and properties that would appear at the start of each project build if the verbosity level is set to `diagnostic`.<br />-   **ShowCommandLine**. Show `TaskCommandLineEvent` messages.<br />-   **ShowTimestamp**. Show the timestamp as a prefix to any message.<br />-   **ShowEventId**. Show the event ID for each started event, finished event, and message.<br />-   **ForceNoAlign**. Don't align the text to the size of the console buffer.<br />-   **DisableConsoleColor**. Use the default console colors for all logging messages.<br />-   **DisableMPLogging**. Disable the multiprocessor logging style of output when running in non-multiprocessor mode.<br />-   **EnableMPLogging**. Enable the multiprocessor logging style even when running in non-multiprocessor mode. This logging style is on by default.<br />-   **Verbosity**. Override the **-verbosity** setting for this logger.<br /><br /> Use a semicolon to separate multiple parameters, as the following example shows:<br /><br /> `-consoleloggerparameters:PerformanceSummary;NoSummary -verbosity:minimal`<br/><br/> The default console logger is at normal verbosity and includes a `Summary`.|
|-distributedFileLogger|-dfl|Log the build output of each MSBuild node to its own file. The initial location for these files is the current directory. By default, the files are named *MSBuild\<NodeId>.log*. You can use the **-fileLoggerParameters** switch to specify the location of the files and other parameters for the fileLogger.<br /><br /> If you name a log file by using the **-fileLoggerParameters** switch, the distributed logger will use that name as a template and append the node ID to that name when creating a log file for each node.|
|-distributedLogger:<br /><br /> `central logger`*<br /><br /> `forwarding logger`|-dl:`central logger`*`forwarding logger`|Log events from MSBuild, attaching a different logger instance to each node. To specify multiple loggers, specify each logger separately.<br /><br /> You use the logger syntax to specify a logger. For the logger syntax, see the **-logger** switch below.<br /><br /> The following examples show how to use this switch:<br /><br /> `-dl:XMLLogger,MyLogger,Version=1.0.2,Culture=neutral`<br /><br /> `-dl:MyLogger,C:\My.dll*ForwardingLogger,C:\Logger.dll`|
|-fileLogger<br /><br /> *[number]*|-fl[`number`]|Log the build output to a single file in the current directory. If you don't specify `number`, the output file is named *msbuild.log*. If you specify `number`, the output file is named *msbuild\<n>.log*, where \<n> is `number`. `Number` can be a digit from 1 to 9.<br /><br /> You can use the **-fileLoggerParameters** switch to specify the location of the file and other parameters for the fileLogger.|
|-fileLoggerParameters[number]:<br /><br /> `parameters`|-flp[ `number`]: `parameters`|Specifies any extra parameters for the file logger and the distributed file logger. The presence of this switch implies that the corresponding -**filelogger[**`number`**]** switch is present. `Number` can be a digit from 1 to 9.<br /><br /> You can use all parameters that are listed for **-consoleloggerparameters**. You can also use one or more of the following parameters:<br /><br /> -   **LogFile**. The path to the log file into which the build log is written. The distributed file logger prefixes this path to the names of its log files.<br />-   **Append**. Determines whether the build log is appended to the log file or overwrites it. When you set the switch, the build log is appended to the log file. When the switch is not present, the contents of an existing log file are overwritten.<br />     Example: `msbuild myfile.proj -flp:FileLogger,Microsoft.Build;logfile=MyLog.log;append`<br />     If you include an explicit `true` or `false` setting, the log is appended regardless of the setting. If you do not include the append switch, the log is overwritten.<br />     In this case the file is overwritten: `msbuild myfile.proj -flp:FileLogger,Microsoft.Build;logfile=MyLog.log`<br />     In this case the file is appended: `msbuild myfile.proj -flp:FileLogger,Microsoft.Build;logfile=MyLog.log;append=true`<br />     In this case the file is appended: `msbuild myfile.proj -flp:FileLogger,Microsoft.Build;logfile=MyLog.log;append=false`<br />-   **Encoding**. Specifies the encoding for the file (for example, UTF-8, Unicode, or ASCII).<br /><br /> The following example generates separate log files for warnings and errors:<br /><br /> `-flp1:logfile=errors.txt;errorsonly -flp2:logfile=warnings.txt;warningsonly`<br /><br /> The following examples show other possibilities:<br /><br /> `-fileLoggerParameters:LogFile=MyLog.log;Append; Verbosity=diagnostic;Encoding=UTF-8`<br /><br /> `-flp:Summary;Verbosity=minimal;LogFile=msbuild.sum`<br /><br /> `-flp1:warningsonly;logfile=msbuild.wrn`<br /><br /> `-flp2:errorsonly;logfile=msbuild.err`|
|-logger:<br /><br /> `logger`|-l:`logger`|Specifies the logger to use to log events from MSBuild. To specify multiple loggers, specify each logger separately.<br /><br /> Use the following syntax for `logger`: `[``LoggerClass``,]``LoggerAssembly``[;``LoggerParameters``]`<br /><br /> Use the following syntax for `LoggerClass`: `[``PartialOrFullNamespace``.]``LoggerClassName`<br /><br /> You don't have to specify the logger class if the assembly contains exactly one logger.<br /><br /> Use the following syntax for `LoggerAssembly`: `{``AssemblyName``[,``StrongName``] &#124;` `AssemblyFile``}`<br /><br /> Logger parameters are optional and are passed to the logger exactly as you enter them.<br /><br /> The following examples use the **-logger** switch.<br /><br /> `-logger:XMLLogger,MyLogger,Version=1.0.2,Culture=neutral`<br /><br /> `-logger:XMLLogger,C:\Loggers\MyLogger.dll;OutputAsHTML`|
|-noConsoleLogger|-noconlog|Disable the default console logger, and don't log events to the console.|

## Example 1

 The following example builds the `rebuild` target of the *MyProject.proj* project.

```cmd
MSBuild.exe MyProject.proj -t:rebuild
```

## Example 2

 You can use *MSBuild.exe* to perform more complex builds. For example, you can use it to build specific targets of specific projects in a solution. The following example rebuilds the project `NotInSolutionFolder` and cleans the project `InSolutionFolder`, which is in the *NewFolder* solution folder.

```cmd
msbuild SlnFolders.sln -t:NotInSolutionfolder:Rebuild;NewFolder\InSolutionFolder:Clean
```

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Common MSBuild project properties](../msbuild/common-msbuild-project-properties.md)
