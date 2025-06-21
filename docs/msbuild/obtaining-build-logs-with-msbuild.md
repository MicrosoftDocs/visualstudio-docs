---
title: Obtaining Build Logs with MSBuild
description: Use switches with MSBuild and specify how much build data to review and whether to save build data to one or more files.
ms.date: 6/5/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, logging
- logging [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Obtain build logs with MSBuild

By using command-line options with MSBuild, you can specify how much build data you want to review and whether you want to save build data to one or more files. You can also specify a custom logger to collect build data. For information about MSBuild command-line options that this topic doesn't cover, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

> [!NOTE]
> If you build projects by using the Visual Studio IDE, you can troubleshoot those builds by reviewing build logs. For more information, see [How to: View, save, and configure build log files](../ide/how-to-view-save-and-configure-build-log-files.md).

## Set the level of detail

 When you build a project by using MSBuild without specifying a level of detail, the following information appears in the output log:

- Errors, warnings, and messages that are categorized as highly important.

- Some status events.

- A summary of the build.

By using the `-verbosity` (`-v`) switch, you can control how much data appears in the output log. For troubleshooting, use a verbosity level of either `detailed` (`d`) or `diagnostic` (`diag`), which provides the most information.

The build process may be slower when you set the `-verbosity` to `detailed` and even slower when you set the `-verbosity` to `diagnostic`.

```cmd
msbuild MyProject.proj -t:go -v:diag
```

### Verbosity settings

The following table shows how the log verbosity (column values) affects which types of message (row values) are logged.

| Message type / Verbosity              | Quiet | Minimal | Normal | Detailed | Diagnostic |
|---------------------------------------|:-----:|:-------:|:------:|:--------:|:----------:|
| Errors                                |   ✅   |    ✅    |    ✅   |     ✅    |      ✅     |
| Warnings                              |   ✅   |    ✅    |    ✅   |     ✅    |      ✅     |
| High-importance Messages              |       |    ✅    |    ✅   |     ✅    |      ✅     |
| Normal-importance  Messages           |       |         |    ✅   |     ✅    |      ✅     |
| Low-importance  Messages              |       |         |        |     ✅    |      ✅     |
| Additional MSBuild-engine information |       |         |        |          |      ✅     |

## Save the build log to a file

You can use the `-fileLogger` (`-fl`) switch to save build data to a file. The following example saves build data to a file that's named *msbuild.log*.

```cmd
msbuild MyProject.proj -t:go -fileLogger
```

 In the following example, the log file is named *MyProjectOutput.log*, and the verbosity of the log output is set to `diagnostic`. You specify those two settings by using the `-fileLoggerParameters` (`-flp`) switch.

```cmd
msbuild MyProject.proj -t:go -fl -flp:logfile=MyProjectOutput.log;verbosity=diagnostic
```

 For more information, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## Save the log output to multiple files

 The following example saves the entire log to *msbuild1.log*, just the errors to *JustErrors.log*, and just the warnings to *JustWarnings.log*. The example uses file numbers for each of the three files. The file numbers are specified just after the `-fl` and `-flp` switches (for example, `-fl1` and `-flp1`).

 The `-fileLoggerParameters` (`-flp`) switches for files 2 and 3 specify what to name each file and what to include in each file. No name is specified for file 1, so the default name of *msbuild1.log* is used.

```cmd
msbuild MyProject.proj -t:go -fl1 -fl2 -fl3 -flp2:logfile=JustErrors.log;errorsonly -flp3:logfile=JustWarnings.log;warningsonly
```

If you're using a shell that interprets semicolons (for example, bash), put single or double quotes around any option that has semicolons to prevent it from being interpreted as a command separator. For more information, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## Save a binary log

You can save the log in compressed, binary format using the `-binaryLogger` (`-bl`) switch. This log includes a detailed description of the build process and can be read by certain log analysis tools.

In the following example, a binary log file is created with the name *binarylogfilename*.

```cmd
-bl:binarylogfilename.binlog
```

You can use the [Structured log viewer](https://msbuildlog.com/) to view binary logs in a way that makes it much easier to see what is going on.

For more information, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## Use a custom logger

 You can write your own logger by authoring a managed type that implements the <xref:Microsoft.Build.Framework.ILogger> interface. You might use a custom logger, for instance, to send build errors in email, log them to a database, or log them to an XML file. For more information, see [Build loggers](../msbuild/build-loggers.md).

 In the MSBuild command line, you specify the custom logger by using the `-logger` switch. You can also use the `-noconsolelogger` switch to disable the default console logger.

## Related content

- <xref:Microsoft.Build.Framework.LoggerVerbosity>
- [Build loggers](../msbuild/build-loggers.md)
- [Logging in a multi-processor environment](writing-multi-processor-aware-loggers.md)
- [Creating forwarding loggers](../msbuild/creating-forwarding-loggers.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
