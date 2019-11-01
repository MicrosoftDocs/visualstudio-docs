---
title: "CL Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.UseUnicodeForAssemblerListing"
  - "vc.task.cl"
  - "VC.Project.VCCLCompilerTool.TreatSpecificWarningsAsErrors"
  - "VC.Project.VCCLCompilerTool.CreateHotpatchableImage"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild (Visual C++), CL task"
  - "CL task (MSBuild (Visual C++))"
ms.assetid: 651ba971-b755-4f03-a549-4816beb3cc0d
caps.latest.revision: 21
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# CL Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps the Visual C++ compiler tool, cl.exe. The compiler produces executable (.exe) files, dynamic-link library (.dll) files, or code module (.netmodule) files. For more information, see [Compiler Options](https://msdn.microsoft.com/library/ed3376c8-bef4-4c9a-80e9-3b5da232644c).  
  
## Parameters  
 The following table describes the parameters of the **CL** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.  
  
- **AdditionalIncludeDirectories**  
  
   Optional String[] parameter.  
  
   Adds a directory to the list of directories that are searched for include files.  
  
   For more information, see [/I (Additional Include Directories)](https://msdn.microsoft.com/library/3e9add2a-5ed8-4d15-ad79-5b411e313a49).  
  
- **AdditionalOptions**  
  
   Optional String parameter.  
  
   A list of command-line options. For example, "/*option1* /*option2* /*option#*". Use this parameter to specify command-line options that are not represented by any other task parameter.  
  
   For more information, see [Compiler Options](https://msdn.microsoft.com/library/ed3376c8-bef4-4c9a-80e9-3b5da232644c).  
  
- **AdditionalUsingDirectories** Optional String[] parameter.  
  
   Specifies a directory that the compiler will search to resolve file references passed to the **#using** directive.  
  
   For more information, see [/AI (Specify Metadata Directories)](https://msdn.microsoft.com/library/fb9c1846-504c-4a3b-bb39-c8696de32f6f).  
  
- **AlwaysAppend**  
  
   Optional String parameter.  
  
   A string that always gets emitted on the command line. Its default value is "**/c**".  
  
- **AssemblerListingLocation**  
  
   Creates a listing file that contains assembly code.  
  
   For more information, see the **/Fa** option in [/FA, /Fa (Listing File)](https://msdn.microsoft.com/library/c7507d0e-c69d-44f9-b8e2-d2c398697402).  
  
- **AssemblerOutput**  
  
   Optional String parameter.  
  
   Creates a listing file that contains assembly code.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NoListing** - *\<none>*  
  
  - **AssemblyCode** - **/FA**  
  
  - **AssemblyAndMachineCode** - **/FAc**  
  
  - **AssemblyAndSourceCode** - **/FAs**  
  
  - **All** - **/FAcs**  
  
    For more information, see the **/FA**, **/FAc**, **/FAs**, and **/FAcs** options in [/FA, /Fa (Listing File)](https://msdn.microsoft.com/library/c7507d0e-c69d-44f9-b8e2-d2c398697402).  
  
- **BasicRuntimeChecks**  
  
   Optional String parameter.  
  
   Enables and disables the run-time error checks feature, in conjunction with the [runtime_checks](https://msdn.microsoft.com/library/ae50b43f-f88d-47ad-a2db-3389e9e7df5b) pragma.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Default** -                          *\<none>*  
  
  - **StackFrameRuntimeCheck** - **/RTCs**  
  
  - **UninitializedLocalUsageCheck** - **/RTCu**  
  
  - **EnableFastChecks** -                          **/RTC1**  
  
    For more information, see [/RTC (Run-Time Error Checks)](https://msdn.microsoft.com/library/9702c558-412c-4004-acd5-80761f589368).  
  
- **BrowseInformation**  
  
   Optional Boolean parameter.  
  
   If `true`, creates a browse information file.  
  
   For more information, see the **/FR** option in [/FR, /Fr (Create .Sbr File)](https://msdn.microsoft.com/library/3fd8f88b-3924-4feb-9393-287036a28896).  
  
- **BrowseInformationFile**  
  
   Optional String parameter.  
  
   Specifies a file name for the browse information file.  
  
   For more information, see the **BrowseInformation** parameter in this table, and also see [/FR, /Fr (Create .Sbr File)](https://msdn.microsoft.com/library/3fd8f88b-3924-4feb-9393-287036a28896).  
  
- **BufferSecurityCheck**  
  
   Optional Boolean parameter.  
  
   If `true`, detects some buffer overruns that overwrite the return address, a common technique for exploiting code that does not enforce buffer size restrictions.  
  
   For more information, see [/GS (Buffer Security Check)](https://msdn.microsoft.com/library/8d8a5ea1-cd5e-42e1-bc36-66e1cd7e731e).  
  
- **BuildingInIDE**  
  
   Optional Boolean parameter.  
  
   If `true`, indicates that **MSBuild** is invoked by the IDE. Otherwise, **MSBuild** is invoked on the command line.  
  
- **CallingConvention**  
  
   Optional String parameter.  
  
   Specifies the calling convention, which determines the order in which function arguments are pushed onto the stack, whether the caller function or called function removes the arguments from the stack at the end of the call, and the name-decorating convention that the compiler uses to identify individual functions.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Cdecl** - **/Gd**  
  
  - **FastCall** -                          **/Gr**  
  
  - **StdCall** -                          **/Gz**  
  
    For more information, see [/Gd, /Gr, /Gv, /Gz (Calling Convention)](https://msdn.microsoft.com/library/fd3110cb-2d77-49f2-99cf-a03f9ead00a3).  
  
- **CompileAs**  
  
   Optional String parameter.  
  
   Specifies whether to compile the input file as a C or C++ source file.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Default** - *\<none>*  
  
  - **CompileAsC** - **/TC**  
  
  - **CompileAsCpp** - **/TP**  
  
    For more information, see [/Tc, /Tp, /TC, /TP (Specify Source File Type)](https://msdn.microsoft.com/library/7d9d0a65-338b-427c-8b48-fff30e2f9d2b).  
  
- **CompileAsManaged**  
  
   Optional String parameter.  
  
   Enables applications and components to use features from the common language runtime (CLR).  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **false** - *\<none>*  
  
  - **true** - **/clr**  
  
  - **Pure** - **/clr:pure**  
  
  - **Safe** - **/clr:safe**  
  
  - **OldSyntax** - **/clr:oldSyntax**  
  
    For more information, see [/clr (Common Language Runtime Compilation)](https://msdn.microsoft.com/library/fec5a8c0-40ec-484c-a213-8dec918c1d6c).  
  
- **CreateHotpatchableImage**  
  
   Optional Boolean parameter.  
  
   If `true`, tells the compiler to prepare an image for *hot patching*. This parameter ensures that the first instruction of each function is two bytes, which is required for hot patching.  
  
   For more information, see [/hotpatch (Create Hotpatchable Image)](https://msdn.microsoft.com/library/aad539b6-c053-4c78-8682-853d98327798).  
  
- **DebugInformationFormat**  
  
   Optional String parameter.  
  
   Selects the type of debugging information created for your program and whether this information is kept in object (.obj) files or in a program database (PDB).  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **OldStyle** - **/Z7**  
  
  - **ProgramDatabase** - **/Zi**  
  
  - **EditAndContinue** - **/ZI**  
  
    For more information, see [/Z7, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8).  
  
- **DisableLanguageExtensions**  
  
   Optional Boolean parameter.  
  
   If **true**, tells the compiler to emit an error for language constructs that are not compatible with either ANSI C or ANSI C++.  
  
   For more information, see the **/Za** option in [/Za, /Ze (Disable Language Extensions)](https://msdn.microsoft.com/library/65e49258-7161-4289-a176-7c5c0656b1a2).  
  
- **DisableSpecificWarnings**  
  
   Optional String[] parameter.  
  
   Disables the warning numbers that are specified in a semicolon-delimited list.  
  
   For more information, see the `/wd` option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](https://msdn.microsoft.com/library/d6bc7bf5-c754-4879-909c-8e3a67e2629f).  
  
- **EnableEnhancedInstructionSet**  
  
   Optional String parameter.  
  
   Specifies the architecture for code generation that uses the Streaming SIMD Extensions (SSE) and Streaming SIMD Extensions 2 (SSE2) instructions.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **StreamingSIMDExtensions** - **/arch:SSE**  
  
  - **StreamingSIMDExtensions2** - **/arch:SSE2**  
  
    For more information, see [/arch (x86)](https://msdn.microsoft.com/library/9dd5a75d-06e4-4674-aade-33228486078d).  
  
- **EnableFiberSafeOptimizations**  
  
   Optional Boolean parameter.  
  
   If `true`, support fiber safety for data allocated by using static thread-local storage, that is, data allocated by using `__declspec(thread)`.  
  
   For more information, see [/GT (Support Fiber-Safe Thread-Local Storage)](https://msdn.microsoft.com/library/071fec79-c701-432b-9970-457344133159).  
  
- **EnablePREfast**  
  
   Optional Boolean parameter.  
  
   If `true`, enable code analysis.  
  
   For more information, see [/analyze (Code Analysis)](https://msdn.microsoft.com/library/81da536a-e030-4bd4-be18-383927597d08).  
  
- **ErrorReporting**  
  
   Optional String parameter.  
  
   Lets you provide internal compiler error (ICE) information directly to Microsoft. By default, the setting in IDE builds is **Prompt** and the setting in command-line builds is **Queue**.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **None** - **/errorReport:none**  
  
  - **Prompt** - **/errorReport:prompt**  
  
  - **Queue** - **/errorReport:queue**  
  
  - **Send** - **/errorReport:send**  
  
    For more information, see [/errorReport (Report Internal Compiler Errors)](https://msdn.microsoft.com/library/819828f8-b0a5-412c-9c57-bf822f17e667).  
  
- **ExceptionHandling**  
  
   Optional String parameter.  
  
   Specifies the model of exception handling to be used by the compiler.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **false** - *\<none>*  
  
  - **Async** - **/EHa**  
  
  - **Sync** - **/EHsc**  
  
  - **SyncCThrow** - **/EHs**  
  
    For more information, see [/EH (Exception Handling Model)](https://msdn.microsoft.com/library/754b916f-d206-4472-b55a-b6f1b0f2cb4d).  
  
- **ExpandAttributedSource**  
  
   Optional Boolean parameter.  
  
   If `true`, creates a listing file that has expanded attributes injected into the source file.  
  
   For more information, see [/Fx (Merge Injected Code)](https://msdn.microsoft.com/library/14f0e301-3bab-45a3-bbdf-e7ce66f20560).  
  
- **FavorSizeOrSpeed**  
  
   Optional String parameter.  
  
   Specifies whether to favor code size or code speed.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Neither** - *\<none>*  
  
  - **Size** - **/Os**  
  
  - **Speed** - **/Ot**  
  
    For more information, see [/Os, /Ot (Favor Small Code, Favor Fast Code)](https://msdn.microsoft.com/library/9a340806-fa15-4308-892c-355d83cac0f2).  
  
- **FloatingPointExceptions**  
  
   Optional Boolean parameter.  
  
   If `true`, enables the reliable floating-point exception model. Exceptions will be raised immediately after they are triggered.  
  
   For more information, see the /**fp:except** option in [/fp (Specify Floating-Point Behavior)](https://msdn.microsoft.com/library/10469d6b-e68b-4268-8075-d073f4f5d57e).  
  
- **FloatingPointModel**  
  
   Optional String parameter.  
  
   Sets the floating point model.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Precise** - **/fp:precise**  
  
  - **Strict** - **/fp:strict**  
  
  - **Fast** - **/fp:fast**  
  
    For more information, see [/fp (Specify Floating-Point Behavior)](https://msdn.microsoft.com/library/10469d6b-e68b-4268-8075-d073f4f5d57e).  
  
- **ForceConformanceInForLoopScope**  
  
   Optional Boolean parameter.  
  
   If `true`, implements standard C++ behavior in [for](https://msdn.microsoft.com/library/6c7d01b3-c4c1-4c6a-aa58-e2d198f33d4a) loops that use Microsoft extensions ([/Ze](https://msdn.microsoft.com/library/65e49258-7161-4289-a176-7c5c0656b1a2)).  
  
   For more information, see [/Zc:forScope (Force Conformance in for Loop Scope)](https://msdn.microsoft.com/library/3031f02d-3b14-4ad0-869e-22b0110c3aed).  
  
- **ForcedIncludeFiles**  
  
   Optional `String[]` parameter.  
  
   Causes the preprocessor to process one or more specified header files.  
  
   For more information, see [/FI (Name Forced Include File)](https://msdn.microsoft.com/library/07e79577-8152-4df9-a64c-aae08c603397).  
  
- **ForcedUsingFiles**  
  
   Optional **String[]** parameter.  
  
   Causes the preprocessor to process one or more specified **#using** files.  
  
   For more information, see [/FU (Name Forced #using File)](https://msdn.microsoft.com/library/698f8603-457f-435a-baff-5ac9243d6ca1).  
  
- **FunctionLevelLinking**  
  
   Optional `Boolean` parameter.  
  
   If `true`, enables the compiler to package individual functions in the form of packaged functions (COMDATs).  
  
   For more information, see [/Gy (Enable Function-Level Linking)](https://msdn.microsoft.com/library/0d3cf14c-ed7d-4ad3-b4b6-104e56f61046).  
  
- **GenerateXMLDocumentationFiles**  
  
   Optional `Boolean` parameter.  
  
   If `true`, causes the compiler to process documentation comments in source code files and to create an .xdc file for each source code file that has documentation comments.  
  
   For more information, see [/doc (Process Documentation Comments) (C/C++)](https://msdn.microsoft.com/library/b54f7e2c-f28f-4f46-9ed6-0db09be2cc63). Also see the **XMLDocumentationFileName** parameter in this table.  
  
- **IgnoreStandardIncludePath**  
  
   Optional `Boolean` parameter.  
  
   If `true`, prevents the compiler from searching for include files in directories specified in the PATH and INCLUDE environment variables.  
  
   For more information, see [/X (Ignore Standard Include Paths)](https://msdn.microsoft.com/library/16bdf2cc-c8dc-46e4-bdcc-f3caeba5e1ef).  
  
- **InlineFunctionExpansion**  
  
   Optional **String** parameter.  
  
   Specifies the level of inline function expansion for the build.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Default** - *\<none>*  
  
  - **Disabled** - **/Ob0**  
  
  - **OnlyExplicitInline** - **/Ob1**  
  
  - **AnySuitable** - **/Ob2**  
  
    For more information, see [/Ob (Inline Function Expansion)](https://msdn.microsoft.com/library/f134e6df-e939-4980-a01d-47425dbc562a).  
  
- **IntrinsicFunctions**  
  
   Optional `Boolean` parameter.  
  
   If `true`, replaces some function calls with intrinsic or otherwise special forms of the function that help your application run faster.  
  
   For more information, see [/Oi (Generate Intrinsic Functions)](https://msdn.microsoft.com/library/fa4a3bf6-0ed8-481b-91c0-add7636132b4).  
  
- **MinimalRebuild**  
  
   Optional `Boolean` parameter.  
  
   If `true`, enables minimal rebuild, which determines whether C++ source files that include changed C++ class definitions (stored in header (.h) files) must be recompiled.  
  
   For more information, see [/Gm (Enable Minimal Rebuild)](https://msdn.microsoft.com/library/d8869ce0-d2ea-40eb-8dae-6d2cdb61dd59).  
  
- **MultiProcessorCompilation**  
  
   Optional `Boolean` parameter.  
  
   If `true`, use multiple processors to compile. This parameter creates a process for each effective processor on your computer.  
  
   For more information, see [/MP (Build with Multiple Processes)](https://msdn.microsoft.com/library/a932b14a-74fe-4b45-84e4-6bf53f0f5e07). Also, see the **ProcessorNumber** parameter in this table.  
  
- **ObjectFileName**  
  
   Optional **String** parameter.  
  
   Specifies an object (.obj) file name or directory to be used instead of the default.  
  
   For more information, see [/Fo (Object File Name)](https://msdn.microsoft.com/library/0e6d593e-4e7f-4990-9e6e-92e1dcbcf6e6).  
  
- **ObjectFiles**  
  
   Optional **String[]** parameter.  
  
   A list of object files.  
  
- **OmitDefaultLibName**  
  
   Optional `Boolean` parameter.  
  
   If `true`, omits the default C run-time library name from the object (.obj) file. By default, the compiler puts the name of the library into the .obj file to direct the linker to the correct library.  
  
   For more information, see [/Zl (Omit Default Library Name)](https://msdn.microsoft.com/library/b27d39d0-44d6-498c-84ae-27c1326fee59).  
  
- **OmitFramePointers**  
  
   Optional `Boolean` parameter.  
  
   If `true`, suppresses creation of frame pointers on the call stack.  
  
   For more information, see [/Oy (Frame-Pointer Omission)](https://msdn.microsoft.com/library/c451da86-5297-4c5a-92bc-561d41379853).  
  
- **OpenMPSupport**  
  
   Optional `Boolean` parameter.  
  
   If `true`, causes the compiler to process OpenMP clauses and directives.  
  
   For more information, see [/openmp (Enable OpenMP 2.0 Support)](https://msdn.microsoft.com/library/9082b175-18d3-4378-86a7-c0eb95664e13).  
  
- **Optimization**  
  
   Optional **String** parameter.  
  
   Specifies various code optimizations for speed and size.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Disabled** - **/Od**  
  
  - **MinSpace** - **/O1**  
  
  - **MaxSpeed** - **/O2**  
  
  - **Full** - **/Ox**  
  
    For more information, see [/O Options (Optimize Code)](https://msdn.microsoft.com/library/77997af9-5555-4b3d-aa57-6615b27d4d5d).  
  
- **PrecompiledHeader**  
  
   Optional **String** parameter.  
  
   Create or use a precompiled header (.pch) file during the build.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NotUsing** - *\<none>*  
  
  - **Create** - **/Yc**  
  
  - **Use** - **/Yu**  
  
    For more information, see [/Yc (Create Precompiled Header File)](https://msdn.microsoft.com/library/47c2e555-b4f5-46e6-906e-ab5cf21f0678) and [/Yu (Use Precompiled Header File)](https://msdn.microsoft.com/library/24f1bd0e-b624-4296-a17e-d4b53e374e1f). Also, see the **PrecompiledHeaderFile** and **PrecompiledHeaderOutputFile** parameters in this table.  
  
- **PrecompiledHeaderFile**  
  
   Optional **String** parameter.  
  
   Specifies a precompiled header file name to create or use.  
  
   For more information, see [/Yc (Create Precompiled Header File)](https://msdn.microsoft.com/library/47c2e555-b4f5-46e6-906e-ab5cf21f0678) and [/Yu (Use Precompiled Header File)](https://msdn.microsoft.com/library/24f1bd0e-b624-4296-a17e-d4b53e374e1f).  
  
- **PrecompiledHeaderOutputFile**  
  
   Optional **String** parameter.  
  
   Specifies a path name for a precompiled header instead of using the default path name.  
  
   For more information, see [/Fp (Name .Pch File)](https://msdn.microsoft.com/library/0fcd9cbd-e09f-44d3-9715-b41efb5d0be2).  
  
- **PreprocessKeepComments**  
  
   Optional `Boolean` parameter.  
  
   If `true`, preserves comments during preprocessing.  
  
   For more information, see [/C (Preserve Comments During Preprocessing)](https://msdn.microsoft.com/library/944567ca-16bc-4728-befe-d414a7787f26).  
  
- **PreprocessorDefinitions**  
  
   Optional `String[]` parameter.  
  
   Defines a preprocessing symbol for your source file.  
  
   For more information, see [/D (Preprocessor Definitions)](https://msdn.microsoft.com/library/b53fdda7-8da1-474f-8811-ba7cdcc66dba).  
  
- **PreprocessOutput**  
  
   Optional `ITaskItem[]` parameter.  
  
   Defines an array of preprocessor output items that can be consumed and emitted by tasks.  
  
- **PreprocessOutputPath**  
  
   Optional `String` parameter.  
  
   Specifies the name of the output file to which the **PreprocessToFile** parameter writes preprocessed output.  
  
   For more information, see [/Fi (Preprocess Output File Name)](https://msdn.microsoft.com/library/6d0ba983-a8b7-41ec-84f5-b4688ef8efee).  
  
- **PreprocessSuppressLineNumbers**  
  
   Optional `Boolean` parameter.  
  
   If `true`, preprocesses C and C++ source files and copies the preprocessed files to the standard output device.  
  
   For more information, see [/EP (Preprocess to stdout Without #line Directives)](https://msdn.microsoft.com/library/6ec411ae-e33d-4ef5-956e-0054635eabea).  
  
- **PreprocessToFile**  
  
   Optional `Boolean` parameter.  
  
   If `true`, preprocesses C and C++ source files and writes the preprocessed output to a file.  
  
   For more information, see [/P (Preprocess to a File)](https://msdn.microsoft.com/library/123ee54f-8219-4a6f-9876-4227023d83fc).  
  
- **ProcessorNumber**  
  
   Optional `Integer` parameter.  
  
   Specifies the maximum number of processors to use in a multiprocessor compilation. Use this parameter in combination with the **MultiProcessorCompilation** parameter.  
  
- **ProgramDataBaseFileName**  
  
   Optional `String` parameter.  
  
   Specifies a file name for the program database (PDB) file.  
  
   For more information, see [/Fd (Program Database File Name)](https://msdn.microsoft.com/library/3977a9ed-f0ac-45df-bf06-01cedd2ba85a).  
  
- **RuntimeLibrary**  
  
   Optional `String` parameter.  
  
   Indicates whether a multithreaded module is a DLL, and selects retail or debug versions of the run-time library.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **MultiThreaded** - **/MT**  
  
  - **MultiThreadedDebug** - **/MTd**  
  
  - **MultiThreadedDLL** - **/MD**  
  
  - **MultiThreadedDebugDLL** - **/MDd**  
  
    For more information, see [/MD, /MT, /LD (Use Run-Time Library)](https://msdn.microsoft.com/library/cf7ed652-dc3a-49b3-aab9-ad60e5395579).  
  
- **RuntimeTypeInfo**  
  
   Optional `Boolean` parameter.  
  
   If `true`, adds code to check C++ object types at run time (run-time type information).  
  
   For more information, see [/GR (Enable Run-Time Type Information)](https://msdn.microsoft.com/library/d1f9f850-dcec-49fd-96ef-e72d01148906).  
  
- **ShowIncludes**  
  
   Optional `Boolean` parameter.  
  
   If `true`, causes the compiler to output a list of the include files.  
  
   For more information, see [/showIncludes (List Include Files)](https://msdn.microsoft.com/library/0b74b052-f594-45a6-a7c7-09e1a319547d).  
  
- **SmallerTypeCheck**  
  
   Optional `Boolean` parameter.  
  
   If `true`, reports a run-time error if a value is assigned to a smaller data type and causes a data loss.  
  
   For more information, see the **/RTCc** option in [/RTC (Run-Time Error Checks)](https://msdn.microsoft.com/library/9702c558-412c-4004-acd5-80761f589368).  
  
- **Sources**  
  
   Required `ITaskItem[]` parameter.  
  
   Specifies a list of source files separated by spaces.  
  
- **StringPooling**  
  
   Optional `Boolean` parameter.  
  
   If `true`, enables the compiler to create one copy of identical strings in the program image.  
  
   For more information, see [/GF (Eliminate Duplicate Strings)](https://msdn.microsoft.com/library/bb7b5d1c-8e1f-453b-9298-8fcebf37d16c).  
  
- **StructMemberAlignment**  
  
   Optional `String` parameter.  
  
   Specifies the byte alignment for all members in a structure.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Default** - **/Zp1**  
  
  - **1Byte** - **/Zp1**  
  
  - **2Bytes** - **/Zp2**  
  
  - **4Bytes** - **/Zp4**  
  
  - **8Bytes** - **/Zp8**  
  
  - **16Bytes** - **/Zp16**  
  
    For more information, see [/Zp (Struct Member Alignment)](https://msdn.microsoft.com/library/5242f656-ed9b-48a3-bc73-cfcf3ed2520f).  
  
- **SuppressStartupBanner**  
  
   Optional `Boolean` parameter.  
  
   If `true`, prevents the display of the copyright and version number message when the task starts.  
  
   For more information, see [/nologo (Suppress Startup Banner) (C/C++)](https://msdn.microsoft.com/library/75930d8b-b11c-4db8-99e5-b52f97da0693).  
  
- **TrackerLogDirectory**  
  
   Optional `String` parameter.  
  
   Specifies the intermediate directory where tracking logs for this task are stored.  
  
   For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
- **TreatSpecificWarningsAsErrors**  
  
   Optional **String[]** parameter.  
  
   Treats the specified list of compiler warnings as errors.  
  
   For more information, see the **/we**`n` option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](https://msdn.microsoft.com/library/d6bc7bf5-c754-4879-909c-8e3a67e2629f).  
  
- **TreatWarningAsError**  
  
   Optional `Boolean` parameter.  
  
   If `true`, treat all compiler warnings as errors.  
  
   For more information, see **/WX** option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](https://msdn.microsoft.com/library/d6bc7bf5-c754-4879-909c-8e3a67e2629f).  
  
- **TreatWChar_tAsBuiltInType**  
  
   Optional `Boolean` parameter.  
  
   If `true`, treat the `wchar_t` type as a native type.  
  
   For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](https://msdn.microsoft.com/library/b0de5a84-da72-4e5a-9a4e-541099f939e0).  
  
- **UndefineAllPreprocessorDefinitions**  
  
   Optional `Boolean` parameter.  
  
   If `true`, undefines the Microsoft-specific symbols that the compiler defines.  
  
   For more information, see the **/u** option in [/U, /u (Undefine Symbols)](https://msdn.microsoft.com/library/7bc0474f-6d1f-419b-807d-0d8816763b2a).  
  
- **UndefinePreprocessorDefinitions**  
  
   Optional `String[]` parameter.  
  
   Specifies a list of one or more preprocessor symbols to undefine.  
  
   For more information, see **/U** option in [/U, /u (Undefine Symbols)](https://msdn.microsoft.com/library/7bc0474f-6d1f-419b-807d-0d8816763b2a).  
  
- **UseFullPaths**  
  
   Optional `Boolean` parameter.  
  
   If `true`, displays the full path of source code files passed to the compiler in diagnostics.  
  
   For more information, see [/FC (Full Path of Source Code File in Diagnostics)](https://msdn.microsoft.com/library/1f11414e-cb42-421b-be68-9d369aab036b).  
  
- **UseUnicodeForAssemblerListing**  
  
   Optional `Boolean` parameter.  
  
   If `true`, causes the output file to be created in UTF-8 format.  
  
   For more information, see the **/FAu** option in [/FA, /Fa (Listing File)](https://msdn.microsoft.com/library/c7507d0e-c69d-44f9-b8e2-d2c398697402).  
  
- **WarningLevel**  
  
   Optional `String` parameter.  
  
   Specifies the highest level of warning that is to be generated by the compiler.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **TurnOffAllWarnings** - **/W0**  
  
  - **Level1** - **/W1**  
  
  - **Level2** - **/W2**  
  
  - **Level3** - **/W3**  
  
  - **Level4** - **/W4**  
  
  - **EnableAllWarnings** - **/Wall**  
  
    For more information, see the **/W**_n_ option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](https://msdn.microsoft.com/library/d6bc7bf5-c754-4879-909c-8e3a67e2629f).  
  
- **WholeProgramOptimization**  
  
   Optional `Boolean` parameter.  
  
   If `true`, enables whole program optimization.  
  
   For more information, see [/GL (Whole Program Optimization)](https://msdn.microsoft.com/library/09d51e2d-9728-4bd0-b5dc-3b8284aca1d1).  
  
- **XMLDocumentationFileName**  
  
   Optional `String` parameter.  
  
   Specifies the name of the generated XML documentation files. This parameter can be a file or directory name.  
  
   For more information, see the `name` argument in [/doc (Process Documentation Comments) (C/C++)](https://msdn.microsoft.com/library/b54f7e2c-f28f-4f46-9ed6-0db09be2cc63). Also see the **GenerateXMLDocumentationFiles** parameter in this table.  
  
- **MinimalRebuildFromTracking**  
  
   Optional `Boolean` parameter.  
  
   If `true`, a tracked incremental build is performed; if `false`, a rebuild is performed.  
  
- **TLogReadFiles**  
  
   Optional `ITaskItem[]` parameter.  
  
   Specifies an array of items that represent the *read file tracking logs*.  
  
   A read-file tracking log (.tlog) contains the names of the input files that are read by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
- **TLogWriteFiles**  
  
   Optional `ITaskItem[]` parameter.  
  
   Specifies an array of items that represent the *write file tracking logs*.  
  
   A write-file tracking log (.tlog) contains the names of the output files that are written by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
- **TrackFileAccess**  
  
   Optional `Boolean` parameter.  
  
   If `true`, tracks file access patterns.  
  
   For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
## Remarks  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)
