---
title: "Obtaining Build Logs with MSBuild | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, logging"
  - "logging [MSBuild]"
ms.assetid: 6ba9a754-9cc0-4fed-9fc8-4dcd3926a031
caps.latest.revision: 30
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Obtaining Build Logs with MSBuild
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using switches with MSBuild, you can specify how much build data you want to review and whether you want to save build data to one or more files. You can also specify a custom logger to collect build data. For information about MSBuild command-line switches that this topic doesn't cover, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
> [!NOTE]
> If you build projects by using the Visual Studio IDE, you can troubleshoot those builds by reviewing build logs. For more information, see [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md).  
  
## Setting the level of detail  
 When you build a project by using MSBuild without specifying a level of detail, the following information appears in the output log:  
  
- Errors, warnings, and messages that are categorized as highly important.  
  
- Some status events.  
  
- A summary of the build.  
  
  By using the **/verbosity** (**/v**) switch, you can control how much data appears in the output log. For troubleshooting, use a verbosity level of either `detailed` (`d`) or `diagnostic` (`diag`), which provides the most information.  
  
  The build process may be slower when you set the **/verbosity** to `detailed` and even slower when you set the **/verbosity** to `diagnostic`.  
  
```  
msbuild MyProject.proj /t:go /v:diag  
```  
  
## Saving the build log to a file  
 You can use the **/fileLogger** (**fl**) switch to save build data to a file. The following example saves build data to a file that's named `msbuild.log`.  
  
```  
msbuild MyProject.proj /t:go /fileLogger  
```  
  
 In the following example, the log file is named `MyProjectOutput.log`, and the verbosity of the log output is set to `diagnostic`. You specify those two settings by using the **/filelogparameters** (`flp`) switch.  
  
```  
msbuild MyProject.proj /t:go /fl /flp:logfile=MyProjectOutput.log;verbosity=diagnostic  
```  
  
 For more information, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
## Saving the log output to multiple files  
 The following example saves the entire log to `msbuild1.log`, just the errors to `JustErrors.log`, and just the warnings to `JustWarnings.log`. The example uses file numbers for each of the three files. The file numbers are specified just after the **/fl** and **/flp** switches (for example, `/fl1` and `/flp1`).  
  
 The **/filelogparameters** (`flp`) switches for files 2 and 3 specify what to name each file and what to include in each file. No name is specified for file 1, so the default name of `msbuild1.log` is used.  
  
```  
msbuild MyProject.proj /t:go /fl1 /fl2 /fl3 /flp2:logfile=JustErrors.log;errorsonly /flp3:logfile=JustWarnings.log;warningsonly  
  
```  
  
 For more information, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
## Using a custom logger  
 You can write your own logger by authoring a managed type that implements the <xref:Microsoft.Build.Framework.ILogger> interface. You might use a custom logger, for instance, to send build errors in email, log them to a database, or log them to an XML file. For more information, see [Build Loggers](../msbuild/build-loggers.md).  
  
 In the MSBuild command line, you specify the custom logger by using the **/logger** switch. You can also use the **/noconsolelogger** switch to disable the default console logger.  
  
## See Also  
 <xref:Microsoft.Build.Framework.LoggerVerbosity>   
 [Build Loggers](../msbuild/build-loggers.md)   
 [Logging in a Multi-Processor Environment](../msbuild/logging-in-a-multi-processor-environment.md)   
 [Creating Forwarding Loggers](../msbuild/creating-forwarding-loggers.md)   
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)
