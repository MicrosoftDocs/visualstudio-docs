---
title: "Options Page, Debugging Node Properties"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 564cc8b2-0084-420e-b560-200cc5621a7e
caps.latest.revision: 9
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Options Page, Debugging Node Properties
The following tables describe the pages (or properties collections) that are associated with the **Debugging** category, `DTE.Properties("Debugging", <Property Page>)` of the **Options** dialog box.  
  
## General  
 `DTE.Properties("Debugging", "General")`  
  
|Property Item Name|Value|Description|  
|------------------------|-----------|-----------------|  
|PromptOnBreakpointDelete|Get/Set (Boolean)|Determines whether the debugger prompts for permission before deleting all breakpoints in a project.|  
|BreakAllProcesses|Get/Set (Boolean)|Determines whether the debugger breaks all processes whenever a single process breaks.|  
|BreakAtBoundaries|Get/Set (Boolean)|Determines whether the debugger breaks execution when an exception crosses a border between AppDomains or between managed and native code.|  
|EnableAddressLevelDebugging|Get/Set (Boolean)|Determines whether address-level debugging features are enabled.|  
|ShowDisassemblyIfNoSource|Get/Set (Boolean)|Determines whether the debugger displays disassembly code when source code is not available.|  
|EnableBreakpointFilters|Get/Set (Boolean)|Determines whether breakpoint filtering is enabled.|  
|EnableExceptionAssistant|Get/Set (Boolean)|Determines whether the Exception Assistant is used for managed exceptions.|  
|UnwindCallstack|Get/Set (Boolean)|Determines whether the debugger unwinds the call stack for an unhandled exception.|  
|EnableJustMyCode|Get/Set (Boolean)|Determines whether Just My Code is enabled for C# and for Visual Basic code.|  
|ShowAllMembers|Get/Set (Boolean)|For non-user objects, determines whether the debugger displays all object members in the variables windows. This option has no effect unless Just My Code is enabled.|  
|WarnIfNoUserCode|Get/Set (Boolean)|Determines whether the debugger emits a warning when the user tries to attach to a process that has no user code. This option has no effect unless Just My Code is enabled.|  
|EnablePropertyEvaluation|Get/Set (Boolean)|Determines whether the debugger automatically evaluates properties and implicit function calls in managed code.|  
|CallStringConversion|Get/Set (Boolean)|Determines whether the debugger implicitly calls a string conversion function on objects in the variables windows. This option applies to C# and JScript code only.|  
|EnableSourceServer|Get/Set (Boolean)|Determines whether the debugger can access code from a source server.|  
|PrintSourceServerDiagnostics|Get/Set (Boolean)|Determines whether the Output window shows diagnostic messages related to the source server. This option has no effect unless source server access is enabled.|  
|HighlightEntireLine|Get/Set (Boolean)|Determines whether the debugger highlights an entire line for breakpoints and the current statement.|  
|RequireSourceToMatch|Get/Set (Boolean)|Determines whether the debugger requires source files to exactly match the original version when you open files for debugging.|  
|RedirectOutputToImmediate|Get/Set (Boolean)|Determines whether Output window output is redirected to the Immediate Window.|  
|ShowRawVariableStructure|Get/Set (Boolean)|Determines whether objects in the variables windows are shown in raw form.|  
|SuppressJitOptimization|Get/Set (Boolean)|For managed code, determines whether just-in-time optimization is suppressed by the debugger.|  
|WarnIfNoSymbols|Get/Set (Boolean)|Determines whether the debugger displays a warning if no debugging symbols are available when a process is launched.|  
|WarnIfScriptDisabled|Get/Set (Boolean)|Determines whether the debugger displays a warning if script debugging is not enabled when a process is launched.|  
|ShowMarkersForAllThreads|Get/Set (Boolean)|Determines whether the debugger displays thread markers.|  
|StepOverPropertiesAndOperators|Get/Set (Boolean)|Specifies whether to step over properties and operators in managed code only.|  
  
## Edit and Continue  
 `DTE.Properties("Debugging", "EditAndContinue")`  
  
|Property Item Name|Value|Description|  
|------------------------|-----------|-----------------|  
|EnableEditAndContinue|Get/Set (Boolean)|Determines whether Edit and Continue is enabled. This option applies to all languages that support Edit and Continue.|  
|InvokedByCommands|Get/Set (Boolean)|Determines whether Edit and Continue automatically applies code changes when the user selects a debugging command such as **Step** or **Continue**. This option applies to native code only.|  
|InvokedByCommandsAskFirst|Get/Set (Boolean)|Determines whether Edit and Continue prompts the user for permission to apply code changes when the user selects a debugging command such as **Step** or **Continue**. This option applies to native code only.|  
|WarnAboutStaleCode|Get/Set (Boolean)|Determines whether the debugger issues a warning message when Edit and Continue would result in the execution of out-of-date, or stale, code. This option applies to native code only.|  
|RelinkChangesOnStop|Get/Set (Short)|Determines whether Visual Studio relinks code changes applied by Edit and Continue when execution of the application stops. This option applies to native code only.|  
|AllowPrecompiling|Get/Set (Short)|Determines whether Edit and Continue is allowed to load precompiled headers in the background. This option applies to native code only.|  
  
## Just-In-Time  
 `DTE.Properties("Debugging", "JustInTime")`  
  
|Property Item Name|Value|Description|  
|------------------------|-----------|-----------------|  
|JitManaged|Get/Set (Boolean)|Determines whether Just-In-Time Debugging is enabled for managed code.|  
|JitNative|Get/Set (Boolean)|Determines whether Just-In-Time Debugging is enabled for native code.|  
|JitScript|Get/Set (Boolean)|Determines whether Just-In-Time Debugging is enabled for script code.|  
  
## Native  
 `DTE.Properties("Debugging", "Native")`  
  
|Property Item Name|Value|Description|  
|------------------------|-----------|-----------------|  
|LoadDllExports|Get/Set (Boolean)|Determines whether the debugger loads DLL export tables.|  
|EnableRPC|Get/Set (Boolean)|Determines whether the debugger can step into COM remote procedure calls.|  
  
## See Also  
 [Controlling Options Settings](../Topic/Controlling%20Options%20Settings.md)   
 [Determining the Names of Property Items on Options Pages](../Topic/Determining%20the%20Names%20of%20Property%20Items%20on%20Options%20Pages.md)   
 [Options Page, Fonts and Colors Node Properties](../reference/options-page--fonts-and-colors-node-properties.md)   
 [Options Page, Text Editor Node Properties](../reference/options-page--text-editor-node-properties.md)   
 [General, Debugging, Options Dialog Box](../debugger/general--debugging--options-dialog-box.md)   
 [Edit and Continue, Debugging, Options Dialog Box](../Topic/Edit%20and%20Continue,%20Debugging,%20Options%20Dialog%20Box.md)   
 [Just-In-Time, Debugging, Options Dialog Box](../debugger/just-in-time--debugging--options-dialog-box.md)