---
title: "Csc Task"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d8c19b36-f5ca-484b-afa6-8ff3b90e103a
caps.latest.revision: 26
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Csc Task
Wraps CSC.exe, and produces executables (.exe files), dynamic-link libraries (.dll files), or code modules (.netmodule files). For more information about CSC.exe, see [C# Compiler Options](../Topic/C%23%20Compiler%20Options.md).  
  
## Parameters  
 The following table describes the parameters of the `Csc` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalLibPaths`|Optional `String[]` parameter.<br /><br /> Specifies additional directories to search for references. For more information, see [/lib (C# Compiler Options)](../Topic/-lib%20\(C%23%20Compiler%20Options\).md).|  
|`AddModules`|Optional `String` parameter.<br /><br /> Specifies one or more modules to be part of the assembly. For more information, see [/addmodule (C# Compiler Options)](../Topic/-addmodule%20\(C%23%20Compiler%20Options\).md).|  
|`AllowUnsafeBlocks`|Optional `Boolean` parameter.<br /><br /> If `true`, compiles code that uses the [unsafe](../Topic/unsafe%20\(C%23%20Reference\).md) keyword. For more information, see [/unsafe (C# Compiler Options)](../Topic/-unsafe%20\(C%23%20Compiler%20Options\).md).|  
|`ApplicationConfiguration`|Optional `String` parameter.<br /><br /> Specifies the application configuration file containing the assembly binding settings.|  
|`BaseAddress`|Optional `String` parameter.<br /><br /> Specifies the preferred base address at which to load a DLL. The default base address for a DLL is set by the .NET Framework common language runtime. For more information, see [/baseaddress (C# Compiler Options)](../Topic/-baseaddress%20\(C%23%20Compiler%20Options\).md).|  
|`CheckForOverflowUnderflow`|Optional `Boolean` parameter.<br /><br /> Specifies whether integer arithmetic that overflows the bounds of the data type causes an exception at run time. For more information, see [/checked (C# Compiler Options)](../Topic/-checked%20\(C%23%20Compiler%20Options\).md).|  
|`CodePage`|Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. For more information, see [/codepage (C# Compiler Options)](../Topic/-codepage%20\(C%23%20Compiler%20Options\).md).|  
|`DebugType`|Optional `String` parameter.<br /><br /> Specifies the debug type. `DebugType` can be `full` or `pdbonly`. The default is `full`, which enables a debugger to be attached to a running program. Specifying `pdbonly` enables source code debugging when the program is started in the debugger, but only displays assembler when the running program is attached to the debugger.<br /><br /> This parameter overrides the `EmitDebugInformation` parameter.<br /><br /> For more information, see [/debug (C# Compiler Options)](../Topic/-debug%20\(C%23%20Compiler%20Options\).md).|  
|`DefineConstants`|Optional `String` parameter.<br /><br /> Defines preprocessor symbols. For more information, see [/define (C# Compiler Options)](../Topic/-define%20\(C%23%20Compiler%20Options\).md).|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you want a fully signed assembly. If `false`, specifies that you only want to place the public key in the assembly.<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter.<br /><br /> For more information, see [/delaysign (C# Compiler Options)](../Topic/-delaysign%20\(C%23%20Compiler%20Options\).md).|  
|`DisabledWarnings`|Optional `String` parameter.<br /><br /> Specifies the list of warnings to be disabled. For more information, see [/nowarn (C# Compiler Options)](../Topic/-nowarn%20\(C%23%20Compiler%20Options\).md).|  
|`DocumentationFile`|Optional `String` parameter.<br /><br /> Processes documentation comments to an XML file. For more information, see [/doc (C# Compiler Options)](../Topic/-doc%20\(C%23%20Compiler%20Options\).md).|  
|`EmitDebugInformation`|Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a program database (.pdb) file. If `false`, the task emits no debug information. Default is `false`. For more information, see [/debug (C# Compiler Options)](../Topic/-debug%20\(C%23%20Compiler%20Options\).md).|  
|`ErrorReport`|Optional `String` parameter.<br /><br /> Provides a convenient way to report a C# internal error to Microsoft. This parameter can have a value of `prompt`, `send`, or `none`. If the parameter is set to `prompt`, you will receive a prompt when an internal compiler error occurs. The prompt lets you send a bug report electronically to Microsoft. If the parameter is set to `send`, a bug report is sent automatically. If the parameter is set to `none`, the error is reported only in the text output of the compiler. Default is `none`. For more information, see [/errorreport (C# Compiler Options)](../Topic/-errorreport%20\(C%23%20Compiler%20Options\).md).|  
|`FileAlignment`|Optional `Int32` parameter.<br /><br /> Specifies the size of sections in the output file. For more information, see [/filealign (C# Compiler Options)](../Topic/-filealign%20\(C%23%20Compiler%20Options\).md).|  
|`GenerateFullPaths`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies the absolute path to the file in the compiler output. If `false`, specifies the name of the file. Default is `false`. For more information, see [/fullpaths (C# Compiler Options)](../Topic/-fullpaths%20\(C%23%20Compiler%20Options\).md).|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. For more information, see [/keycontainer (C# Compiler Options)](../Topic/-keycontainer%20\(C%23%20Compiler%20Options\).md).|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [/keyfile (C# Compiler Options)](../Topic/-keyfile%20\(C%23%20Compiler%20Options\).md).|  
|`LangVersion`|Optional `String` parameter.<br /><br /> Specifies the version of the language to use. For more information, see [/langversion (C# Compiler Options)](../Topic/-langversion%20\(C%23%20Compiler%20Options\).md).|  
|`LinkResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/linkresource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/linkresource (C# Compiler Options)](../Topic/-linkresource%20\(C%23%20Compiler%20Options\).md).|  
|`MainEntryPoint`|Optional `String` parameter.<br /><br /> Specifies the location of the `Main` method. For more information, see [/main (C# Compiler Options)](../Topic/-main%20\(C%23%20Compiler%20Options\).md).|  
|`ModuleAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the name of the assembly that this module will be a part of.|  
|`NoConfig`|Optional `Boolean` parameter.<br /><br /> If `true`, tells the compiler not to compile with the csc.rsp file. For more information, see [/noconfig (C# Compiler Options)](../Topic/-noconfig%20\(C%23%20Compiler%20Options\).md).|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. For more information, see [/nologo (C# Compiler Options)](../Topic/-nologo%20\(C%23%20Compiler%20Options\).md).|  
|`NoStandardLib`|Optional `Boolean` parameter.<br /><br /> If `true`, prevents the import of mscorlib.dll, which defines the entire System namespace. Use this parameter if you want to define or create your own System namespace and objects. For more information, see [/nostdlib (C# Compiler Options)](../Topic/-nostdlib%20\(C%23%20Compiler%20Options\).md).|  
|`NoWin32Manifest`|Optional `Boolean` parameter.<br /><br /> If `true`, do not include the default Win32 manifest.|  
|`Optimize`|Optional `Boolean` parameter.<br /><br /> If `true`, enables optimizations. If `false`, disables optimizations. For more information, see [/optimize (C# Compiler Options)](../Topic/-optimize%20\(C%23%20Compiler%20Options\).md).|  
|`OutputAssembly`|Optional `String` output parameter.<br /><br /> Specifies the name of the output file. For more information, see [/out (C# Compiler Options)](../Topic/-out%20\(C%23%20Compiler%20Options\).md).|  
|`PdbFile`|Optional `String` parameter.<br /><br /> Specifies the debug information file name. The default name is the output file name with a .pdb extension.|  
|`Platform`|Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`. For more information, see [/platform (C# Compiler Options)](../Topic/-platform%20\(C%23%20Compiler%20Options\).md).|  
|`References`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. For more information, see [/reference (C# Compiler Options)](../Topic/-reference%20\(C%23%20Compiler%20Options\).md).<br /><br /> You can specify a Visual C# reference alias in an MSBuild file by adding the metadata `Aliases` to the original "Reference" item. For example, to set the alias "LS1" in the following CSC command line:<br /><br /> `csc /r:LS1=MyCodeLibrary.dll /r:LS2=MyCodeLibrary2.dll *.cs`<br /><br /> you would use:<br /><br /> `<Reference Include="MyCodeLibrary"> <Aliases>LS1</Aliases> </Reference>`|  
|`Resources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Embeds a .NET Framework resource into the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/resource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/resource (C# Compiler Options)](../Topic/-resource%20\(C%23%20Compiler%20Options\).md).|  
|`ResponseFiles`|Optional `String` parameter.<br /><br /> Specifies the response file that contains commands for this task. For more information, see [@ (Specify Response File)](../Topic/@%20\(C%23%20Compiler%20Options\).md).|  
|`Sources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies one or more Visual C# source files.|  
|`TargetType`|Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. The default value is `library`. For more information, see [/target (C# Compiler Options)](../Topic/-target%20\(C%23%20Compiler%20Options\).md).|  
|`TreatWarningsAsErrors`|Optional `Boolean` parameter.<br /><br /> If `true`, treats all warnings as errors. For more information, see [/warnaserror (C# Compiler Options)](../Topic/-warnaserror%20\(C%23%20Compiler%20Options\).md).|  
|`UseHostCompilerIfAvailable`|Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by Visual Studio.|  
|`Utf8Output`|Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. For more information, see [/utf8output (C# Compiler Options)](../Topic/-utf8output%20\(C%23%20Compiler%20Options\).md).|  
|`WarningLevel`|Optional `Int32` parameter.<br /><br /> Specifies the warning level for the compiler to display. For more information, see [/warn (C# Compiler Options)](../Topic/-warn%20\(C%23%20Compiler%20Options\).md).|  
|`WarningsAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [/warnaserror (C# Compiler Options)](../Topic/-warnaserror%20\(C%23%20Compiler%20Options\).md).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter.|  
|`WarningsNotAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [/warnaserror (C# Compiler Options)](../Topic/-warnaserror%20\(C%23%20Compiler%20Options\).md).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`.|  
|`Win32Icon`|Optional `String` parameter.<br /><br /> Inserts an .ico file in the assembly, which gives the output file the desired appearance in File Explorer. For more information, see [/win32icon (C# Compiler Options)](../Topic/-win32icon%20\(C%23%20Compiler%20Options\).md).|  
|`Win32Manifest`|Optional `String` parameter.<br /><br /> Specifies the Win32 manifest to be included.|  
|`Win32Resource`|Optional `String` parameter.<br /><br /> Inserts a Win32 resource (.res) file in the output file. For more information, see [/win32res (C# Compiler Options)](../Topic/-win32res%20\(C%23%20Compiler%20Options\).md).|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the `Microsoft.Build.Tasks.ManagedCompiler` class, which inherits from the <xref:Microsoft.Build.Tasks.ToolTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../VS_IDE/ToolTaskExtension-Base-Class.md).  
  
## Example  
 The following example uses the `Csc` task to compile an executable from the source files in the `Compile` item collection.  
  
```  
<CSC  
    Sources="@(Compile)"  
    OutputAssembly="$(AppName).exe"  
    EmitDebugInformation="true" />  
```  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)