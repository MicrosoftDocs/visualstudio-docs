---
title: "Csc Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Csc"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Csc task [MSBuild]"
  - "MSBuild, Csc task"
ms.assetid: d8c19b36-f5ca-484b-afa6-8ff3b90e103a
caps.latest.revision: 30
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Csc Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps CSC.exe, and produces executables (.exe files), dynamic-link libraries (.dll files), or code modules (.netmodule files). For more information about CSC.exe, see [C# Compiler Options](https://msdn.microsoft.com/library/d3403556-1816-4546-a782-e8223a772e44).  
  
## Parameters  
 The following table describes the parameters of the `Csc` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalLibPaths`|Optional `String[]` parameter.<br /><br /> Specifies additional directories to search for references. For more information, see [/lib (C# Compiler Options)](https://msdn.microsoft.com/library/b0efcc88-e8aa-4df4-a00b-8bdef70b7673).|  
|`AddModules`|Optional `String` parameter.<br /><br /> Specifies one or more modules to be part of the assembly. For more information, see [/addmodule (C# Compiler Options)](https://msdn.microsoft.com/library/ed604546-0dc2-4bd4-9a3e-610a8d973e58).|  
|`AllowUnsafeBlocks`|Optional `Boolean` parameter.<br /><br /> If `true`, compiles code that uses the [unsafe](https://msdn.microsoft.com/library/7e818009-1c6e-4b9e-b769-3728a01586a0) keyword. For more information, see [/unsafe (C# Compiler Options)](https://msdn.microsoft.com/library/fdb77ed9-da03-45bd-bb7f-250704da1bcc).|  
|`ApplicationConfiguration`|Optional `String` parameter.<br /><br /> Specifies the application configuration file containing the assembly binding settings.|  
|`BaseAddress`|Optional `String` parameter.<br /><br /> Specifies the preferred base address at which to load a DLL. The default base address for a DLL is set by the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] common language runtime. For more information, see [/baseaddress (C# Compiler Options)](https://msdn.microsoft.com/library/ce13c965-dfe4-4433-94f5-63b476e3a608).|  
|`CheckForOverflowUnderflow`|Optional `Boolean` parameter.<br /><br /> Specifies whether integer arithmetic that overflows the bounds of the data type causes an exception at run time. For more information, see [/checked (C# Compiler Options)](https://msdn.microsoft.com/library/fb7475d3-e6a6-4e6d-b86c-69e7a74c854b).|  
|`CodePage`|Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. For more information, see [/codepage (C# Compiler Options)](https://msdn.microsoft.com/library/75942989-b69a-4308-90a0-840c73d2c478).|  
|`DebugType`|Optional `String` parameter.<br /><br /> Specifies the debug type. `DebugType` can be `full` or `pdbonly`. The default is `full`, which enables a debugger to be attached to a running program. Specifying `pdbonly` enables source code debugging when the program is started in the debugger, but only displays assembler when the running program is attached to the debugger.<br /><br /> This parameter overrides the `EmitDebugInformation` parameter.<br /><br /> For more information, see [/debug (C# Compiler Options)](https://msdn.microsoft.com/library/e2b48c07-01bc-45cc-a52c-92e9085eb969).|  
|`DefineConstants`|Optional `String` parameter.<br /><br /> Defines preprocessor symbols. For more information, see [/define (C# Compiler Options)](https://msdn.microsoft.com/library/f17d7b4d-82d0-4133-8563-68cced1cac6e).|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you want a fully signed assembly. If `false`, specifies that you only want to place the public key in the assembly.<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter.<br /><br /> For more information, see [/delaysign (C# Compiler Options)](https://msdn.microsoft.com/library/bcb058eb-2933-4e7f-b356-5c941db4de75).|  
|`DisabledWarnings`|Optional `String` parameter.<br /><br /> Specifies the list of warnings to be disabled. For more information, see [/nowarn (C# Compiler Options)](https://msdn.microsoft.com/library/6dcbc5e8-ae67-4566-9df3-f63cfdd9c4e4).|  
|`DocumentationFile`|Optional `String` parameter.<br /><br /> Processes documentation comments to an XML file. For more information, see [/doc (C# Compiler Options)](https://msdn.microsoft.com/library/849eea59-c936-4311-bad8-d07404480f2a).|  
|`EmitDebugInformation`|Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a program database (.pdb) file. If `false`, the task emits no debug information. Default is `false`. For more information, see [/debug (C# Compiler Options)](https://msdn.microsoft.com/library/e2b48c07-01bc-45cc-a52c-92e9085eb969).|  
|`ErrorReport`|Optional `String` parameter.<br /><br /> Provides a convenient way to report a C# internal error to Microsoft. This parameter can have a value of `prompt`, `send`, or `none`. If the parameter is set to `prompt`, you will receive a prompt when an internal compiler error occurs. The prompt lets you send a bug report electronically to Microsoft. If the parameter is set to `send`, a bug report is sent automatically. If the parameter is set to `none`, the error is reported only in the text output of the compiler. Default is `none`. For more information, see [/errorreport (C# Compiler Options)](https://msdn.microsoft.com/library/bd0e7493-b79d-4369-9c3f-ba26ebdfbedf).|  
|`FileAlignment`|Optional `Int32` parameter.<br /><br /> Specifies the size of sections in the output file. For more information, see [/filealign (C# Compiler Options)](https://msdn.microsoft.com/library/15cf1c98-3798-4ced-9f08-60619308a073).|  
|`GenerateFullPaths`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies the absolute path to the file in the compiler output. If `false`, specifies the name of the file. Default is `false`. For more information, see [/fullpaths (C# Compiler Options)](https://msdn.microsoft.com/library/d2a5f857-cbb2-430b-879c-d648aaf0b8c4).|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. For more information, see [/keycontainer (C# Compiler Options)](https://msdn.microsoft.com/library/b3982b6d-2382-4f7e-bebd-ce98eaa30763).|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [/keyfile (C# Compiler Options)](https://msdn.microsoft.com/library/0815f9de-ace4-4e98-b4c6-13c55dea40c2).|  
|`LangVersion`|Optional `String` parameter.<br /><br /> Specifies the version of the language to use. For more information, see [/langversion (C# Compiler Options)](https://msdn.microsoft.com/library/3fb00b05-a0ff-4782-b313-13a4c0f62d94).|  
|`LinkResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Creates a link to a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] resource in the output file; the resource file is not placed in the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/linkresource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/linkresource (C# Compiler Options)](https://msdn.microsoft.com/library/440c26c2-77c1-4811-a0a3-57cce3f5fc96).|  
|`MainEntryPoint`|Optional `String` parameter.<br /><br /> Specifies the location of the `Main` method. For more information, see [/main (C# Compiler Options)](https://msdn.microsoft.com/library/975cf4d5-36ac-4530-826c-4aad0c7f2049).|  
|`ModuleAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the name of the assembly that this module will be a part of.|  
|`NoConfig`|Optional `Boolean` parameter.<br /><br /> If `true`, tells the compiler not to compile with the csc.rsp file. For more information, see [/noconfig (C# Compiler Options)](https://msdn.microsoft.com/library/cd26967e-e494-4c8c-b5c9-af13b2f78b2e).|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. For more information, see [/nologo (C# Compiler Options)](https://msdn.microsoft.com/library/426afb36-a8fb-469d-9c45-a35d9512557c).|  
|`NoStandardLib`|Optional `Boolean` parameter.<br /><br /> If `true`, prevents the import of mscorlib.dll, which defines the entire System namespace. Use this parameter if you want to define or create your own System namespace and objects. For more information, see [/nostdlib (C# Compiler Options)](https://msdn.microsoft.com/library/ec197989-fa49-4725-a455-e06b551eb65f).|  
|`NoWin32Manifest`|Optional `Boolean` parameter.<br /><br /> If `true`, do not include the default Win32 manifest.|  
|`Optimize`|Optional `Boolean` parameter.<br /><br /> If `true`, enables optimizations. If `false`, disables optimizations. For more information, see [/optimize (C# Compiler Options)](https://msdn.microsoft.com/library/6dd5b6f2-cd1d-4593-a9f4-1c2ed9404ca0).|  
|`OutputAssembly`|Optional `String` output parameter.<br /><br /> Specifies the name of the output file. For more information, see [/out (C# Compiler Options)](https://msdn.microsoft.com/library/70d91d01-7bd2-4aea-ba8b-4e9807e9caa5).|  
|`PdbFile`|Optional `String` parameter.<br /><br /> Specifies the debug information file name. The default name is the output file name with a .pdb extension.|  
|`Platform`|Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`. For more information, see [/platform (C# Compiler Options)](https://msdn.microsoft.com/library/c290ff5e-47f4-4a85-9bb3-9c2525b0be04).|  
|`References`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. For more information, see [/reference (C# Compiler Options)](https://msdn.microsoft.com/library/8d13e5b0-abf6-4c46-bf71-2daf2cd0a6c4).<br /><br /> You can specify a [!INCLUDE[csprcs](../includes/csprcs-md.md)] reference alias in an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] file by adding the metadata `Aliases` to the original "Reference" item. For example, to set the alias "LS1" in the following CSC command line:<br /><br /> `csc /r:LS1=MyCodeLibrary.dll /r:LS2=MyCodeLibrary2.dll *.cs`<br /><br /> you would use:<br /><br /> `<Reference Include="MyCodeLibrary"> <Aliases>LS1</Aliases> </Reference>`|  
|`Resources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Embeds a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] resource into the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/resource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/resource (C# Compiler Options)](https://msdn.microsoft.com/library/5212666e-98ab-47e4-a497-b5545ab15c7f).|  
|`ResponseFiles`|Optional `String` parameter.<br /><br /> Specifies the response file that contains commands for this task. For more information, see [@ (Specify Response File)](https://msdn.microsoft.com/library/dda4fa9f-a02c-400f-8b6a-d58834e13d7f).|  
|`Sources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more [!INCLUDE[csprcs](../includes/csprcs-md.md)] source files.|  
|`TargetType`|Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. The default value is `library`. For more information, see [/target (C# Compiler Options)](https://msdn.microsoft.com/library/a18bbd8e-bbf7-49e7-992c-717d0eb1f76f).|  
|`TreatWarningsAsErrors`|Optional `Boolean` parameter.<br /><br /> If `true`, treats all warnings as errors. For more information, see [/warnaserror (C# Compiler Options)](https://msdn.microsoft.com/library/04680ec3-08d6-4e2e-a274-38310e10e33c).|  
|`UseHostCompilerIfAvailable`|Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|  
|`Utf8Output`|Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. For more information, see [/utf8output (C# Compiler Options)](https://msdn.microsoft.com/library/27ff7381-c281-45d7-b2eb-1ad644b1354e).|  
|`WarningLevel`|Optional `Int32` parameter.<br /><br /> Specifies the warning level for the compiler to display. For more information, see [/warn (C# Compiler Options)](https://msdn.microsoft.com/library/5f80ff59-4991-4382-9f9a-77da18446e71).|  
|`WarningsAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [/warnaserror (C# Compiler Options)](https://msdn.microsoft.com/library/04680ec3-08d6-4e2e-a274-38310e10e33c).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter.|  
|`WarningsNotAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [/warnaserror (C# Compiler Options)](https://msdn.microsoft.com/library/04680ec3-08d6-4e2e-a274-38310e10e33c).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`.|  
|`Win32Icon`|Optional `String` parameter.<br /><br /> Inserts an .ico file in the assembly, which gives the output file the desired appearance in File Explorer. For more information, see [/win32icon (C# Compiler Options)](https://msdn.microsoft.com/library/756d9b6d-ab07-41b7-ba58-5bd88f711138).|  
|`Win32Manifest`|Optional `String` parameter.<br /><br /> Specifies the Win32 manifest to be included.|  
|`Win32Resource`|Optional `String` parameter.<br /><br /> Inserts a Win32 resource (.res) file in the output file. For more information, see [/win32res (C# Compiler Options)](https://msdn.microsoft.com/library/3c33f750-6948-4c7e-a27e-bef98f77255b).|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the `Microsoft.Build.Tasks.ManagedCompiler` class, which inherits from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../msbuild/tooltaskextension-base-class.md).  
  
## Example  
 The following example uses the `Csc` task to compile an executable from the source files in the `Compile` item collection.  
  
```  
<CSC  
    Sources="@(Compile)"  
    OutputAssembly="$(AppName).exe"  
    EmitDebugInformation="true" />  
```  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Tasks](../msbuild/msbuild-tasks.md)
