---
title: "Vbc Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Vbc"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Vbc task [MSBuild]"
  - "MSBuild, Vbc task"
ms.assetid: 595278b1-2782-4577-b1ba-b4b5ab5625a3
caps.latest.revision: 22
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Vbc Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps vbc.exe, which produces executables (.exe), dynamic-link libraries (.dll), or code modules (.netmodule). For more information on vbc.exe, see [Visual Basic Command-Line Compiler](https://msdn.microsoft.com/library/6b57c444-50c7-4b88-8f59-ed65cff5e05c).  
  
## Parameters  
 The following table describes the parameters of the `Vbc` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalLibPaths`|Optional `String[]` parameter.<br /><br /> Specifies additional folders in which to look for assemblies specified in the References attribute.|  
|`AddModules`|Optional `String[]` parameter.<br /><br /> Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling. This parameter corresponds to the [/addmodule](https://msdn.microsoft.com/library/fb4b89d4-4926-4f20-868d-427fa28497b2) switch of the vbc.exe compiler.|  
|`BaseAddress`|Optional `String` parameter.<br /><br /> Specifies the base address of the DLL. This parameter corresponds to the [/baseaddress](https://msdn.microsoft.com/library/c982bcf2-46e5-47a2-bc8f-a5cc32b7dc47) switch of the vbc.exe compiler.|  
|`CodePage`|Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. This parameter corresponds to the [/codepage](https://msdn.microsoft.com/library/be36ec33-6800-4505-838c-4124564f5cc9) switch of the vbc.exe compiler.|  
|`DebugType`|Optional `String[]` parameter.<br /><br /> Causes the compiler to generate debugging information. This parameter can have the following values:<br /><br /> -   `full`<br />-   `pdbonly`<br /><br /> The default value is `full`, which enables attaching a debugger to the running program. A value of `pdbonly` allows source code debugging when the program is started in the debugger, but displays assembly language code only when the running program is attached to the debugger. For more information, see [/debug (Visual Basic)](https://msdn.microsoft.com/library/c2b0bea5-1d5e-499f-9bd5-4f6c6b715ea2).|  
|`DefineConstants`|Optional `String[]` parameter.<br /><br /> Defines conditional compiler constants. Symbol/value pairs are separated by semicolons and are specified with the following syntax:<br /><br /> *symbol1* `=` *value1* `;` *symbol2* `=` *value2*<br /><br /> This parameter corresponds to the [/define](https://msdn.microsoft.com/library/f735c57d-1cf9-4f2f-a26f-0de630fd4077) switch of the vbc.exe compiler.|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, the task places the public key in the assembly. If `false`, the task fully signs the assembly. The default value is `false`.This parameter has no effect unless used with the `KeyFile` parameter or the `KeyContainer` parameter. This parameter corresponds to the [/delaysign](https://msdn.microsoft.com/library/c76e61a4-1884-4252-9fb2-377f99caa690) switch of the vbc.exe compiler.|  
|`DisabledWarnings`|Optional `String` parameter.<br /><br /> Suppresses the specified warnings. You only need to specify the numeric part of the warning identifier. Multiple warnings are separated by semicolons. This parameter corresponds to the [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83) switch of the vbc.exe compiler.|  
|`DocumentationFile`|Optional `String` parameter.<br /><br /> Processes documentation comments to the specified XML file. This parameter overrides the `GenerateDocumentation` attribute. For more information, see [/doc](https://msdn.microsoft.com/library/5fc32ec9-a149-4648-994c-a8d0cccd0a65).|  
|`EmitDebugInformation`|Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a .pdb file. For more information, see [/debug (Visual Basic)](https://msdn.microsoft.com/library/c2b0bea5-1d5e-499f-9bd5-4f6c6b715ea2).|  
|`ErrorReport`|Optional `String` parameter.<br /><br /> Specifies how the task should report internal compiler errors. This parameter can have the following values:<br /><br /> -   `prompt`<br />-   `send`<br />-   `none`<br /><br /> If `prompt` is specified and an internal compiler error occurs, the user is prompted with an option of wheter to send the error data to Microsoft.<br /><br /> If `send` is specified and an internal compiler error occurs, the task sends the error data to Microsoft.<br /><br /> The default value is `none`, which reports errors in text output only.<br /><br /> This parameter corresponds to the [/errorreport](https://msdn.microsoft.com/library/a7fe83a2-a6d8-460c-8dad-79a8f433f501) switch of the vbc.exe compiler.|  
|`FileAlignment`|Optional `Int32` parameter.<br /><br /> Specifies, in bytes, where to align the sections of the output file. This parameter can have the following values:<br /><br /> -   `512`<br />-   `1024`<br />-   `2048`<br />-   `4096`<br />-   `8192`<br /><br /> This parameter corresponds to the [/filealign](https://msdn.microsoft.com/library/cc61ec3d-ad38-4b28-9659-099d73cad099) switch of the vbc.exe compiler.|  
|`GenerateDocumentation`|Optional `Boolean` parameter.<br /><br /> If `true`, generates documentation information and places it in an XML file with the name of the executable file or library that the task is creating. For more information, see [/doc](https://msdn.microsoft.com/library/5fc32ec9-a149-4648-994c-a8d0cccd0a65).|  
|`Imports`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Imports namespaces from the specified item collections. This parameter corresponds to the [/imports](https://msdn.microsoft.com/library/9a93fb53-c080-497b-bf9b-441022dbbc39) switch of the vbc.exe compiler.|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. This parameter corresonds to the [/keycontainer](https://msdn.microsoft.com/library/6a9bc861-1752-4db1-9f64-b5252f0482cc) switch of the vbc.exe compiler.|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [/keyfile](https://msdn.microsoft.com/library/ffa82a4b-517a-4c6c-9889-5bae7b534bb8).|  
|`LangVersion`|Optional [String](<!-- TODO: review code entity reference <xref:assetId:///String?qualifyHint=False&amp;autoUpgrade=True>  -->) parameter.<br /><br /> Specifies the language version, either "9" or "10".|  
|`LinkResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. This parameter corresponds to the [/linkresource](https://msdn.microsoft.com/library/cf4dcad8-17b7-404c-9184-29358aa05b15) switch of the vbc.exe compiler.|  
|`MainEntryPoint`|Optional `String` parameter.<br /><br /> Specifies the class or module that contains the `Sub Main` procedure. This parameter corresonds to the [/main](https://msdn.microsoft.com/library/83fc339d-6652-415d-b205-b5133319b5b0) switch of the vbc.exe compiler.|  
|`ModuleAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the assembly that this module is a part of.|  
|`NoConfig`|Optional `Boolean` parameter.<br /><br /> Specifies that the compiler should not use the vbc.rsp file. This parameter corresponds to the [/noconfig](https://msdn.microsoft.com/library/a7405067-bd21-4171-adf4-a126fa3ad6c3) parameter of the vbc.exe compiler.|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. This parameter corresponds to the [/nologo](https://msdn.microsoft.com/library/25ef54b6-d676-4639-a2d2-a747a158bc07) switch of the vbc.exe compiler.|  
|`NoStandardLib`|Optional `Boolean` parameter.<br /><br /> Causes the compiler not to reference the standard libraries. This parameter corresponds to the [/nostdlib](https://msdn.microsoft.com/library/140381b8-dc96-4ad5-ae11-792c9ed0be4d) switch of the vbc.exe compiler.|  
|`NoVBRuntimeReference`|Optional `Boolean` parameter.<br /><br /> Internal use only. If true, prevents the automatic reference to Microsoft.VisualBasic.dll..|  
|`NoWarnings`|Optional `Boolean` parameter.<br /><br /> If `true`, the task suppresses all warnings. For more information, see [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83).|  
|`Optimize`|Optional `Boolean` parameter.<br /><br /> If `true`, enables compiler optimizations. This parameter corresponds to the [/optimize](https://msdn.microsoft.com/library/fcba4a97-3622-4b87-a891-0f77deab4998) switch of the vbc.exe compiler.|  
|`OptionCompare`|Optional `String` parameter.<br /><br /> Specifies how string comparisons are made. This parameter can have the following values:<br /><br /> -   `binary`<br />-   `text`<br /><br /> The value `binary` specifies that the task uses binary string comparisons. The value `text` specifies that the task uses text string comparisons. The default value of this parameter is `binary`. This parameter corresponds to the [/optioncompare](https://msdn.microsoft.com/library/7237b766-b44d-4cc5-9a3c-885348a7d9e4) switch of the vbc.exe compiler.|  
|`OptionExplicit`|Optional `Boolean` parameter.<br /><br /> If `true`, explicit declaration of variables is required. This parameter corresponds to the [/optionexplicit](https://msdn.microsoft.com/library/5d296ab3-bafe-4c4d-9887-78f162ed86c7) switch of the vbc.exe compiler.|  
|`OptionInfer`|Optional `Boolean` parameter.<br /><br /> If `true`, allows type inference of variables.|  
|`OptionStrict`|Optional `Boolean` parameter.<br /><br /> If `true`, the task enforces strict type semantics to restrict implicit type conversions. This parameter corresponds to the [/optionstrict](https://msdn.microsoft.com/library/c7b10086-0fa4-49db-b3c8-4ae0db5957da) switch of the vbc.exe compiler.|  
|`OptionStrictType`|Optional `String` parameter.<br /><br /> Specifies which strict type semantics generate a warning. Currently, only "custom" is supported. This parameter corresponds to the [/optionstrict](https://msdn.microsoft.com/library/c7b10086-0fa4-49db-b3c8-4ae0db5957da) switch of the vbc.exe compiler.|  
|`OutputAssembly`|Optional `String` output parameter.<br /><br /> Specifies the name of the output file. This parameter corresponds to the [/out](https://msdn.microsoft.com/library/9f148c15-0909-4cb8-a2db-777f8a8b45ae) switch of the vbc.exe compiler.|  
|`Platform`|Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, `Itanium`, or `anycpu`. Default is `anycpu`. This parameter corresponds to the [/platform](https://msdn.microsoft.com/library/f9bc61e6-e854-4ae1-87b9-d6244de23fd1) switch of the vbc.exe compiler.|  
|`References`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. This parameter corresponds to the [/reference](https://msdn.microsoft.com/library/66bdfced-bbf6-43d1-a554-bc0990315737) switch of the vbc.exe compiler.|  
|`RemoveIntegerChecks`|Optional `Boolean` parameter.<br /><br /> If `true`, disables integer overflow error checks. The default value is `false`. This parameter corresponds to the [/removeintchecks](https://msdn.microsoft.com/library/c1835bd5-1e38-4fba-bd2f-6984774765d4) switch of the vbc.exe compiler.|  
|`Resources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Embeds a .NET Framework resource into the output file. This parameter corresponds to the [/resource](https://msdn.microsoft.com/library/eee2f227-91f2-4f2b-a9d6-1c51c5320858) switch of the vbc.exe compiler.|  
|`ResponseFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the response file that contains commands for this task. This parameter corresponds to the [@ (Specify Response File)](https://msdn.microsoft.com/library/a6847eaa-e5f9-4303-9421-45b55484b9ca) option of the vbc.exe compiler.|  
|`RootNamespace`|Optional `String` parameter.<br /><br /> Specifies the root namespace for all type declarations. This parameter corresponds to the [/rootnamespace](https://msdn.microsoft.com/library/e9245edf-6bef-420d-a7c7-324117752783) switch of the vbc.exe compiler.|  
|`SdkPath`|Optional `String` parameter.<br /><br /> Specifies the location of mscorlib.dll and microsoft.visualbasic.dll. This parameter corresponds to the [/sdkpath](https://msdn.microsoft.com/library/fec8a3f1-b791-4a37-8af7-344859f8212d) switch of the vbc.exe compiler.|  
|`Sources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] source files.|  
|`TargetCompactFramework`|Optional `Boolean` parameter.<br /><br /> If `true`, the task targets the [!INCLUDE[Compact](../includes/compact-md.md)]. This switch corresponds to the [/netcf](https://msdn.microsoft.com/library/db7cfa59-c315-401c-a59b-0daf355343d6) switch of the vbc.exe compiler.|  
|`TargetType`|Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. Default is `library`. This parameter corresponds to the [/target](https://msdn.microsoft.com/library/e0954147-548b-461f-9c4b-a8f88845616c) switch of the vbc.exe compiler.|  
|`Timeout`|Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period.|  
|`ToolPath`|Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (vbc.exe). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)].|  
|`TreatWarningsAsErrors`|Optional `Boolean` parameter.<br /><br /> If `true`, all warnings are treated as errors. For more information, see [/warnaserror (Visual Basic)](https://msdn.microsoft.com/library/49819f1d-a1bd-4201-affe-5afe6d9712e1).|  
|`UseHostCompilerIfAvailable`|Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|  
|`Utf8Output`|Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. This parameter corresponds to the [/utf8output](https://msdn.microsoft.com/library/8ab36b1e-027a-49ac-85b4-f48997d9e4d6) switch of the vbc.exe compiler.|  
|`Verbosity`|Optional `String` parameter.<br /><br /> Specifies the verbosity of the compiler’s output. Verbosity can be `Quiet`, `Normal` (the default), or `Verbose`.|  
|`WarningsAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [/warnaserror (Visual Basic)](https://msdn.microsoft.com/library/49819f1d-a1bd-4201-affe-5afe6d9712e1).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter.|  
|`WarningsNotAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [/warnaserror (Visual Basic)](https://msdn.microsoft.com/library/49819f1d-a1bd-4201-affe-5afe6d9712e1).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`.|  
|`Win32Icon`|Optional `String` parameter.<br /><br /> Inserts an .ico file in the assembly, which gives the output file the desired appearance in File Explorer. This parameter corresponds to the [/win32icon](https://msdn.microsoft.com/library/aecaab01-9353-46c5-941c-6edabd4eff92) switch of the vbc.exe compiler.|  
|`Win32Resources`|Optional `String` parameter.<br /><br /> Inserts a Win32 resource (.res) file in the output file. This parameter corresponds to the [/win32resource](https://msdn.microsoft.com/library/e226946d-19ce-4cc9-91f5-aed24f77aa2b) switch of the vbc.exe compiler.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../msbuild/tooltaskextension-base-class.md).  
  
## Example  
 The following example compiles a [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] project.  
  
```  
<VBC  
   Sources="@(sources)"  
   Resources="strings.resources"  
   Optimize="true"  
   OutputAssembly="out.exe"/>  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](https://msdn.microsoft.com/library/6b57c444-50c7-4b88-8f59-ed65cff5e05c)   
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
