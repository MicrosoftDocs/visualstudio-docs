---
title: "Vbc Task"
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
ms.assetid: 595278b1-2782-4577-b1ba-b4b5ab5625a3
caps.latest.revision: 19
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
# Vbc Task
Wraps vbc.exe, which produces executables (.exe), dynamic-link libraries (.dll), or code modules (.netmodule). For more information on vbc.exe, see [Visual Basic Command-Line Compiler](../Topic/Visual%20Basic%20Command-Line%20Compiler.md).  
  
## Parameters  
 The following table describes the parameters of the `Vbc` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalLibPaths`|Optional `String[]` parameter.<br /><br /> Specifies additional folders in which to look for assemblies specified in the References attribute.|  
|`AddModules`|Optional `String[]` parameter.<br /><br /> Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling. This parameter corresponds to the [/addmodule](../Topic/-addmodule.md) switch of the vbc.exe compiler.|  
|`BaseAddress`|Optional `String` parameter.<br /><br /> Specifies the base address of the DLL. This parameter corresponds to the [/baseaddress](../Topic/-baseaddress.md) switch of the vbc.exe compiler.|  
|`CodePage`|Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. This parameter corresponds to the [/codepage](../Topic/-codepage%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`DebugType`|Optional `String[]` parameter.<br /><br /> Causes the compiler to generate debugging information. This parameter can have the following values:<br /><br /> -   `full`<br />-   `pdbonly`<br /><br /> The default value is `full`, which enables attaching a debugger to the running program. A value of `pdbonly` allows source code debugging when the program is started in the debugger, but displays assembly language code only when the running program is attached to the debugger. For more information, see [/debug (Visual Basic)](../Topic/-debug%20\(Visual%20Basic\).md).|  
|`DefineConstants`|Optional `String[]` parameter.<br /><br /> Defines conditional compiler constants. Symbol/value pairs are separated by semicolons and are specified with the following syntax:<br /><br /> *symbol1* `=` *value1* `;` *symbol2* `=` *value2*<br /><br /> This parameter corresponds to the [/define](../Topic/-define%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, the task places the public key in the assembly. If `false`, the task fully signs the assembly. The default value is `false`.This parameter has no effect unless used with the `KeyFile` parameter or the `KeyContainer` parameter. This parameter corresponds to the [/delaysign](../Topic/-delaysign.md) switch of the vbc.exe compiler.|  
|`DisabledWarnings`|Optional `String` parameter.<br /><br /> Suppresses the specified warnings. You only need to specify the numeric part of the warning identifier. Multiple warnings are separated by semicolons. This parameter corresponds to the [/nowarn](../Topic/-nowarn.md) switch of the vbc.exe compiler.|  
|`DocumentationFile`|Optional `String` parameter.<br /><br /> Processes documentation comments to the specified XML file. This parameter overrides the `GenerateDocumentation` attribute. For more information, see [/doc](../Topic/-doc.md).|  
|`EmitDebugInformation`|Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a .pdb file. For more information, see [/debug (Visual Basic)](../Topic/-debug%20\(Visual%20Basic\).md).|  
|`ErrorReport`|Optional `String` parameter.<br /><br /> Specifies how the task should report internal compiler errors. This parameter can have the following values:<br /><br /> -   `prompt`<br />-   `send`<br />-   `none`<br /><br /> If `prompt` is specified and an internal compiler error occurs, the user is prompted with an option of wheter to send the error data to Microsoft.<br /><br /> If `send` is specified and an internal compiler error occurs, the task sends the error data to Microsoft.<br /><br /> The default value is `none`, which reports errors in text output only.<br /><br /> This parameter corresponds to the [/errorreport](../Topic/-errorreport.md) switch of the vbc.exe compiler.|  
|`FileAlignment`|Optional `Int32` parameter.<br /><br /> Specifies, in bytes, where to align the sections of the output file. This parameter can have the following values:<br /><br /> -   `512`<br />-   `1024`<br />-   `2048`<br />-   `4096`<br />-   `8192`<br /><br /> This parameter corresponds to the [/filealign](../Topic/-filealign.md) switch of the vbc.exe compiler.|  
|`GenerateDocumentation`|Optional `Boolean` parameter.<br /><br /> If `true`, generates documentation information and places it in an XML file with the name of the executable file or library that the task is creating. For more information, see [/doc](../Topic/-doc.md).|  
|`Imports`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Imports namespaces from the specified item collections. This parameter corresponds to the [/imports](../Topic/-imports%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. This parameter corresonds to the [/keycontainer](../Topic/-keycontainer.md) switch of the vbc.exe compiler.|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [/keyfile](../Topic/-keyfile.md).|  
|`LangVersion`|Optional [String](assetId:///String?qualifyHint=False&autoUpgrade=True) parameter.<br /><br /> Specifies the language version, either "9" or "10".|  
|`LinkResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. This parameter corresponds to the [/linkresource](../Topic/-linkresource%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`MainEntryPoint`|Optional `String` parameter.<br /><br /> Specifies the class or module that contains the `Sub Main` procedure. This parameter corresonds to the [/main](../Topic/-main.md) switch of the vbc.exe compiler.|  
|`ModuleAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the assembly that this module is a part of.|  
|`NoConfig`|Optional `Boolean` parameter.<br /><br /> Specifies that the compiler should not use the vbc.rsp file. This parameter corresponds to the [/noconfig](../Topic/-noconfig.md) parameter of the vbc.exe compiler.|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. This parameter corresponds to the [/nologo](../Topic/-nologo%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`NoStandardLib`|Optional `Boolean` parameter.<br /><br /> Causes the compiler not to reference the standard libraries. This parameter corresponds to the [/nostdlib](../Topic/-nostdlib%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`NoVBRuntimeReference`|Optional `Boolean` parameter.<br /><br /> Internal use only. If true, prevents the automatic reference to Microsoft.VisualBasic.dll..|  
|`NoWarnings`|Optional `Boolean` parameter.<br /><br /> If `true`, the task supresses all warnings. For more information, see [/nowarn](../Topic/-nowarn.md).|  
|`Optimize`|Optional `Boolean` parameter.<br /><br /> If `true`, enables compiler optimizations. This parameter corresponds to the [/optimize](../Topic/-optimize.md) switch of the vbc.exe compiler.|  
|`OptionCompare`|Optional `String` parameter.<br /><br /> Specifies how string comparisons are made. This parameter can have the following values:<br /><br /> -   `binary`<br />-   `text`<br /><br /> The value `binary` specifies that the task uses binary string comparisons. The value `text` specifies that the task uses text string comparisons. The default value of this parameter is `binary`. This parameter corresponds to the [/optioncompare](../Topic/-optioncompare.md) switch of the vbc.exe compiler.|  
|`OptionExplicit`|Optional `Boolean` parameter.<br /><br /> If `true`, explicit declaration of variables is required. This parameter corresponds to the [/optionexplicit](../Topic/-optionexplicit.md) switch of the vbc.exe compiler.|  
|`OptionInfer`|Optional `Boolean` parameter.<br /><br /> If `true`, allows type inference of variables.|  
|`OptionStrict`|Optional `Boolean` parameter.<br /><br /> If `true`, the task enforces strict type semantics to restrict implicit type conversions. This parameter corresponds to the [/optionstrict](../Topic/-optionstrict.md) switch of the vbc.exe compiler.|  
|`OptionStrictType`|Optional `String` parameter.<br /><br /> Specifies which strict type semantics generate a warning. Currently, only "custom" is supported. This parameter corresponds to the [/optionstrict](../Topic/-optionstrict.md) switch of the vbc.exe compiler.|  
|`OutputAssembly`|Optional `String` output parameter.<br /><br /> Specifies the name of the ouput file. This parameter corresponds to the [/out](../Topic/-out%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`Platform`|Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, `Itanium`, or `anycpu`. Default is `anycpu`. This parameter corresponds to the [/platform](../Topic/-platform%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`References`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. This parameter corresponds to the [/reference](../Topic/-reference%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`RemoveIntegerChecks`|Optional `Boolean` parameter.<br /><br /> If `true`, disables integer overflow error checks. The default value is `false`. This parameter corresponds to the [/removeintchecks](../Topic/-removeintchecks.md) switch of the vbc.exe compiler.|  
|`Resources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Embeds a .NET Framework resource into the output file. This parameter corresponds to the [/resource](../Topic/-resource%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`ResponseFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the response file that contains commands for this task. This parameter corresponds to the [@ (Specify Response File)](../Topic/@%20\(Specify%20Response%20File\)%20\(Visual%20Basic\).md) option of the vbc.exe compiler.|  
|`RootNamespace`|Optional `String` parameter.<br /><br /> Specifies the root namespace for all type declarations. This parameter corresponds to the [/rootnamespace](../Topic/-rootnamespace.md) switch of the vbc.exe compiler.|  
|`SdkPath`|Optional `String` parameter.<br /><br /> Specifies the location of mscorlib.dll and microsoft.visualbasic.dll. This parameter corresponds to the [/sdkpath](../Topic/-sdkpath.md) switch of the vbc.exe compiler.|  
|`Sources`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies one or more Visual Basic source files.|  
|`TargetCompactFramework`|Optional `Boolean` parameter.<br /><br /> If `true`, the task targets the .NET Compact Framework. This switch corresponds to the [/netcf](../Topic/-netcf.md) switch of the vbc.exe compiler.|  
|`TargetType`|Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. Default is `library`. This parameter corresponds to the [/target](../Topic/-target%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`Timeout`|Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period.|  
|`ToolPath`|Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (vbc.exe). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running MSBuild.|  
|`TreatWarningsAsErrors`|Optional `Boolean` parameter.<br /><br /> If `true`, all warnings are treated as errors. For more information, see [/warnaserror (Visual Basic)](../Topic/-warnaserror%20\(Visual%20Basic\).md).|  
|`UseHostCompilerIfAvailable`|Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by Visual Studio.|  
|`Utf8Output`|Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. This parameter corresponds to the [/utf8output](../Topic/-utf8output%20\(Visual%20Basic\).md) switch of the vbc.exe compiler.|  
|`Verbosity`|Optional `String` parameter.<br /><br /> Specifies the verbosity of the compiler’s output. Verbosity can be `Quiet`, `Normal` (the default), or `Verbose`.|  
|`WarningsAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [/warnaserror (Visual Basic)](../Topic/-warnaserror%20\(Visual%20Basic\).md).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter.|  
|`WarningsNotAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [/warnaserror (Visual Basic)](../Topic/-warnaserror%20\(Visual%20Basic\).md).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`.|  
|`Win32Icon`|Optional `String` parameter.<br /><br /> Inserts an .ico file in the assembly, which gives the output file the desired appearance in File Explorer. This parameter corresponds to the [/win32icon](../Topic/-win32icon.md) switch of the vbc.exe compiler.|  
|`Win32Resources`|Optional `String` parameter.<br /><br /> Inserts a Win32 resource (.res) file in the output file. This parameter corresponds to the [/win32resource](../Topic/-win32resource.md) switch of the vbc.exe compiler.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../VS_IDE/ToolTaskExtension-Base-Class.md).  
  
## Example  
 The following example compiles a Visual Basic project.  
  
```  
<VBC  
   Sources="@(sources)"  
   Resources="strings.resources"  
   Optimize="true"  
   OutputAssembly="out.exe"/>  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../Topic/Visual%20Basic%20Command-Line%20Compiler.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)