---
title: "CL Task"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 18
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
# CL Task
Wraps the Visual C++ compiler tool, cl.exe. The compiler produces executable (.exe) files, dynamic-link library (.dll) files, or code module (.netmodule) files. For more information, see [Compiler Options](../Topic/Compiler%20Options.md).  
  
## Parameters  
 The following table describes the parameters of the **CL** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.  
  
-   **AdditionalIncludeDirectories**  
  
     Optional String[] parameter.  
  
     Adds a directory to the list of directories that are searched for include files.  
  
     For more information, see [/I (Additional Include Directories)](../Topic/-I%20\(Additional%20Include%20Directories\).md).  
  
-   **AdditionalOptions**  
  
     Optional String parameter.  
  
     A list of command-line options. For example, "/*option1* /*option2* /*option#*". Use this parameter to specify command-line options that are not represented by any other task parameter.  
  
     For more information, see [Compiler Options](../Topic/Compiler%20Options.md).  
  
-   **AdditionalUsingDirectories**Optional String[] parameter.  
  
     Specifies a directory that the compiler will search to resolve file references passed to the **#using** directive.  
  
     For more information, see [/AI (Specify Metadata Directories)](../Topic/-AI%20\(Specify%20Metadata%20Directories\).md).  
  
-   **AlwaysAppend**  
  
     Optional String parameter.  
  
     A string that always gets emitted on the command line. Its default value is "**/c**".  
  
-   **AssemblerListingLocation**  
  
     Creates a listing file that contains assembly code.  
  
     For more information, see the **/Fa** option in [/FA, /Fa (Listing File)](../Topic/-FA,%20-Fa%20\(Listing%20File\).md).  
  
-   **AssemblerOutput**  
  
     Optional String parameter.  
  
     Creates a listing file that contains assembly code.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NoListing** - *\<none>*  
  
    -   **AssemblyCode** - **/FA**  
  
    -   **AssemblyAndMachineCode** - **/FAc**  
  
    -   **AssemblyAndSourceCode** - **/FAs**  
  
    -   **All** - **/FAcs**  
  
     For more information, see the **/FA**, **/FAc**, **/FAs**, and **/FAcs** options in [/FA, /Fa (Listing File)](../Topic/-FA,%20-Fa%20(Listing%20File).md).  
  
-   **BasicRuntimeChecks**  
  
     Optional String parameter.  
  
     Enables and disables the run-time error checks feature, in conjunction with the [runtime_checks](../Topic/runtime_checks.md) pragma.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** -                          *\<none>*  
  
    -   **StackFrameRuntimeCheck** - **/RTCs**  
  
    -   **UninitializedLocalUsageCheck** - **/RTCu**  
  
    -   **EnableFastChecks** -                          **/RTC1**  
  
     For more information, see [/RTC (Run-Time Error Checks)](../Topic/-RTC%20\(Run-Time%20Error%20Checks\).md).  
  
-   **BrowseInformation**  
  
     Optional Boolean parameter.  
  
     If `true`, creates a browse information file.  
  
     For more information, see the **/FR** option in [/FR, /Fr (Create .Sbr File)](../Topic/-FR,%20-Fr%20\(Create%20.Sbr%20File\).md).  
  
-   **BrowseInformationFile**  
  
     Optional String parameter.  
  
     Specifies a file name for the browse information file.  
  
     For more information, see the **BrowseInformation** parameter in this table, and also see [/FR, /Fr (Create .Sbr File)](../Topic/-FR,%20-Fr%20\(Create%20.Sbr%20File\).md).  
  
-   **BufferSecurityCheck**  
  
     Optional Boolean parameter.  
  
     If `true`, detects some buffer overruns that overwrite the return address, a common technique for exploiting code that does not enforce buffer size restrictions.  
  
     For more information, see [/GS (Buffer Security Check)](../Topic/-GS%20\(Buffer%20Security%20Check\).md).  
  
-   **BuildingInIDE**  
  
     Optional Boolean parameter.  
  
     If `true`, indicates that **MSBuild** is invoked by the IDE. Otherwise, **MSBuild** is invoked on the command line.  
  
-   **CallingConvention**  
  
     Optional String parameter.  
  
     Specifies the calling convention, which determines the order in which function arguments are pushed onto the stack, whether the caller function or called function removes the arguments from the stack at the end of the call, and the name-decorating convention that the compiler uses to identify individual functions.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Cdecl** - **/Gd**  
  
    -   **FastCall** -                          **/Gr**  
  
    -   **StdCall** -                          **/Gz**  
  
     For more information, see [/Gd, /Gr, /Gv, /Gz (Calling Convention)](../Topic/-Gd,%20-Gr,%20-Gv,%20-Gz%20\(Calling%20Convention\).md).  
  
-   **CompileAs**  
  
     Optional String parameter.  
  
     Specifies whether to compile the input file as a C or C++ source file.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - *\<none>*  
  
    -   **CompileAsC** - **/TC**  
  
    -   **CompileAsCpp** - **/TP**  
  
     For more information, see [/Tc, /Tp, /TC, /TP (Specify Source File Type)](../Topic/-Tc,%20-Tp,%20-TC,%20-TP%20\(Specify%20Source%20File%20Type\).md).  
  
-   **CompileAsManaged**  
  
     Optional String parameter.  
  
     Enables applications and components to use features from the common language runtime (CLR).  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **false** - *\<none>*  
  
    -   **true** - **/clr**  
  
    -   **Pure** - **/clr:pure**  
  
    -   **Safe** - **/clr:safe**  
  
    -   **OldSyntax** - **/clr:oldSyntax**  
  
     For more information, see [/clr (Common Language Runtime Compilation)](../Topic/-clr%20\(Common%20Language%20Runtime%20Compilation\).md).  
  
-   **CreateHotpatchableImage**  
  
     Optional Boolean parameter.  
  
     If `true`, tells the compiler to prepare an image for *hot patching*. This parameter ensures that the first instruction of each function is two bytes, which is required for hot patching.  
  
     For more information, see [/hotpatch (Create Hotpatchable Image)](../Topic/-hotpatch%20\(Create%20Hotpatchable%20Image\).md).  
  
-   **DebugInformationFormat**  
  
     Optional String parameter.  
  
     Selects the type of debugging information created for your program and whether this information is kept in object (.obj) files or in a program database (PDB).  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **OldStyle** - **/Z7**  
  
    -   **ProgramDatabase** - **/Zi**  
  
    -   **EditAndContinue** - **/ZI**  
  
     For more information, see [/Z7, /Zi, /ZI (Debug Information Format)](../Topic/-Z7,%20-Zi,%20-ZI%20\(Debug%20Information%20Format\).md).  
  
-   **DisableLanguageExtensions**  
  
     Optional Boolean parameter.  
  
     If **true**, tells the compiler to emit an error for language constructs that are not compatible with either ANSI C or ANSI C++.  
  
     For more information, see the **/Za** option in [/Za, /Ze (Disable Language Extensions)](../Topic/-Za,%20-Ze%20\(Disable%20Language%20Extensions\).md).  
  
-   **DisableSpecificWarnings**  
  
     Optional String[] parameter.  
  
     Disables the warning numbers that are specified in a semicolon-delimited list.  
  
     For more information, see the `/wd` option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](../Topic/-w,%20-W0,%20-W1,%20-W2,%20-W3,%20-W4,%20-w1,%20-w2,%20-w3,%20-w4,%20-Wall,%20-wd,%20-we,%20-wo,%20-Wv,%20-WX%20\(Warning%20Level\).md).  
  
-   **EnableEnhancedInstructionSet**  
  
     Optional String parameter.  
  
     Specifies the architecture for code generation that uses the Streaming SIMD Extensions (SSE) and Streaming SIMD Extensions 2 (SSE2) instructions.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **StreamingSIMDExtensions** - **/arch:SSE**  
  
    -   **StreamingSIMDExtensions2** - **/arch:SSE2**  
  
     For more information, see [/arch (x86)](../Topic/-arch%20\(x86\).md).  
  
-   **EnableFiberSafeOptimizations**  
  
     Optional Boolean parameter.  
  
     If `true`, support fiber safety for data allocated by using static thread-local storage, that is, data allocated by using `__declspec(thread)`.  
  
     For more information, see [/GT (Support Fiber-Safe Thread-Local Storage)](../Topic/-GT%20\(Support%20Fiber-Safe%20Thread-Local%20Storage\).md).  
  
-   **EnablePREfast**  
  
     Optional Boolean parameter.  
  
     If `true`, enable code analysis.  
  
     For more information, see [/analyze (Code Analysis)](../Topic/-analyze%20\(Code%20Analysis\).md).  
  
-   **ErrorReporting**  
  
     Optional String parameter.  
  
     Lets you provide internal compiler error (ICE) information directly to Microsoft. By default, the setting in IDE builds is **Prompt** and the setting in command-line builds is **Queue**.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **None** - **/errorReport:none**  
  
    -   **Prompt** - **/errorReport:prompt**  
  
    -   **Queue** - **/errorReport:queue**  
  
    -   **Send** - **/errorReport:send**  
  
     For more information, see [/errorReport (Report Internal Compiler Errors)](../Topic/-errorReport%20\(Report%20Internal%20Compiler%20Errors\).md).  
  
-   **ExceptionHandling**  
  
     Optional String parameter.  
  
     Specifies the model of exception handling to be used by the compiler.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **false** - *\<none>*  
  
    -   **Async** - **/EHa**  
  
    -   **Sync** - **/EHsc**  
  
    -   **SyncCThrow** - **/EHs**  
  
     For more information, see [/EH (Exception Handling Model)](../Topic/-EH%20\(Exception%20Handling%20Model\).md).  
  
-   **ExpandAttributedSource**  
  
     Optional Boolean parameter.  
  
     If `true`, creates a listing file that has expanded attributes injected into the source file.  
  
     For more information, see [/Fx (Merge Injected Code)](../Topic/-Fx%20\(Merge%20Injected%20Code\).md).  
  
-   **FavorSizeOrSpeed**  
  
     Optional String parameter.  
  
     Specifies whether to favor code size or code speed.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Neither** - *\<none>*  
  
    -   **Size** - **/Os**  
  
    -   **Speed** - **/Ot**  
  
     For more information, see [/Os, /Ot (Favor Small Code, Favor Fast Code)](../Topic/-Os,%20-Ot%20\(Favor%20Small%20Code,%20Favor%20Fast%20Code\).md).  
  
-   **FloatingPointExceptions**  
  
     Optional Boolean parameter.  
  
     If `true`, enables the reliable floating-point exception model. Exceptions will be raised immediately after they are triggered.  
  
     For more information, see the /**fp:except** option in [/fp (Specify Floating-Point Behavior)](../Topic/-fp%20\(Specify%20Floating-Point%20Behavior\).md).  
  
-   **FloatingPointModel**  
  
     Optional String parameter.  
  
     Sets the floating point model.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Precise** - **/fp:precise**  
  
    -   **Strict** - **/fp:strict**  
  
    -   **Fast** - **/fp:fast**  
  
     For more information, see [/fp (Specify Floating-Point Behavior)](../Topic/-fp%20\(Specify%20Floating-Point%20Behavior\).md).  
  
-   **ForceConformanceInForLoopScope**  
  
     Optional Boolean parameter.  
  
     If `true`, implements standard C++ behavior in [for](../Topic/for%20Statement%20\(C++\).md) loops that use Microsoft extensions ([/Ze](../Topic/-Za,%20-Ze%20\(Disable%20Language%20Extensions\).md)).  
  
     For more information, see [/Zc:forScope (Force Conformance in for Loop Scope)](../Topic/-Zc:forScope%20\(Force%20Conformance%20in%20for%20Loop%20Scope\).md).  
  
-   **ForcedIncludeFiles**  
  
     Optional `String[]` parameter.  
  
     Causes the preprocessor to process one or more specified header files.  
  
     For more information, see [/FI (Name Forced Include File)](../Topic/-FI%20\(Name%20Forced%20Include%20File\).md).  
  
-   **ForcedUsingFiles**  
  
     Optional **String[]** parameter.  
  
     Causes the preprocessor to process one or more specified **#using** files.  
  
     For more information, see [/FU (Name Forced #using File)](../Topic/-FU%20\(Name%20Forced%20%23using%20File\).md).  
  
-   **FunctionLevelLinking**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables the compiler to package individual functions in the form of packaged functions (COMDATs).  
  
     For more information, see [/Gy (Enable Function-Level Linking)](../Topic/-Gy%20\(Enable%20Function-Level%20Linking\).md).  
  
-   **GenerateXMLDocumentationFiles**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to process documentation comments in source code files and to create an .xdc file for each source code file that has documentation comments.  
  
     For more information, see [/doc (Process Documentation Comments) (C/C++)](../Topic/-doc%20\(Process%20Documentation%20Comments\)%20\(C-C++\).md). Also see the **XMLDocumentationFileName** parameter in this table.  
  
-   **IgnoreStandardIncludePath**  
  
     Optional `Boolean` parameter.  
  
     If `true`, prevents the compiler from searching for include files in directories specified in the PATH and INCLUDE environment variables.  
  
     For more information, see [/X (Ignore Standard Include Paths)](../Topic/-X%20\(Ignore%20Standard%20Include%20Paths\).md).  
  
-   **InlineFunctionExpansion**  
  
     Optional **String** parameter.  
  
     Specifies the level of inline function expansion for the build.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - *\<none>*  
  
    -   **Disabled** - **/Ob0**  
  
    -   **OnlyExplicitInline** - **/Ob1**  
  
    -   **AnySuitable** - **/Ob2**  
  
     For more information, see [/Ob (Inline Function Expansion)](../Topic/-Ob%20\(Inline%20Function%20Expansion\).md).  
  
-   **IntrinsicFunctions**  
  
     Optional `Boolean` parameter.  
  
     If `true`, replaces some function calls with intrinsic or otherwise special forms of the function that help your application run faster.  
  
     For more information, see [/Oi (Generate Intrinsic Functions)](../Topic/-Oi%20\(Generate%20Intrinsic%20Functions\).md).  
  
-   **MinimalRebuild**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables minimal rebuild, which determines whether C++ source files that include changed C++ class definitions (stored in header (.h) files) must be recompiled.  
  
     For more information, see [/Gm (Enable Minimal Rebuild)](../Topic/-Gm%20\(Enable%20Minimal%20Rebuild\).md).  
  
-   **MultiProcessorCompilation**  
  
     Optional `Boolean` parameter.  
  
     If `true`, use multiple processors to compile. This parameter creates a process for each effective processor on your computer.  
  
     For more information, see [/MP (Build with Multiple Processes)](../Topic/-MP%20\(Build%20with%20Multiple%20Processes\).md). Also, see the **ProcessorNumber** parameter in this table.  
  
-   **ObjectFileName**  
  
     Optional **String** parameter.  
  
     Specifies an object (.obj) file name or directory to be used instead of the default.  
  
     For more information, see [/Fo (Object File Name)](../Topic/-Fo%20\(Object%20File%20Name\).md).  
  
-   **ObjectFiles**  
  
     Optional **String[]** parameter.  
  
     A list of object files.  
  
-   **OmitDefaultLibName**  
  
     Optional `Boolean` parameter.  
  
     If `true`, omits the default C run-time library name from the object (.obj) file. By default, the compiler puts the name of the library into the .obj file to direct the linker to the correct library.  
  
     For more information, see [/Zl (Omit Default Library Name)](../Topic/-Zl%20\(Omit%20Default%20Library%20Name\).md).  
  
-   **OmitFramePointers**  
  
     Optional `Boolean` parameter.  
  
     If `true`, suppresses creation of frame pointers on the call stack.  
  
     For more information, see [/Oy (Frame-Pointer Omission)](../Topic/-Oy%20\(Frame-Pointer%20Omission\).md).  
  
-   **OpenMPSupport**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to process OpenMP clauses and directives.  
  
     For more information, see [/openmp (Enable OpenMP 2.0 Support)](../Topic/-openmp%20\(Enable%20OpenMP%202.0%20Support\).md).  
  
-   **Optimization**  
  
     Optional **String** parameter.  
  
     Specifies various code optimizations for speed and size.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Disabled** - **/Od**  
  
    -   **MinSpace** - **/O1**  
  
    -   **MaxSpeed** - **/O2**  
  
    -   **Full** - **/Ox**  
  
     For more information, see [/O Options (Optimize Code)](../Topic/-O%20Options%20\(Optimize%20Code\).md).  
  
-   **PrecompiledHeader**  
  
     Optional **String** parameter.  
  
     Create or use a precompiled header (.pch) file during the build.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NotUsing** - *\<none>*  
  
    -   **Create** - **/Yc**  
  
    -   **Use** - **/Yu**  
  
     For more information, see [/Yc (Create Precompiled Header File)](../Topic/-Yc%20\(Create%20Precompiled%20Header%20File\).md) and [/Yu (Use Precompiled Header File)](../Topic/-Yu%20\(Use%20Precompiled%20Header%20File\).md). Also, see the **PrecompiledHeaderFile** and **PrecompiledHeaderOutputFile** parameters in this table.  
  
-   **PrecompiledHeaderFile**  
  
     Optional **String** parameter.  
  
     Specifies a precompiled header file name to create or use.  
  
     For more information, see [/Yc (Create Precompiled Header File)](../Topic/-Yc%20\(Create%20Precompiled%20Header%20File\).md) and [/Yu (Use Precompiled Header File)](../Topic/-Yu%20\(Use%20Precompiled%20Header%20File\).md).  
  
-   **PrecompiledHeaderOutputFile**  
  
     Optional **String** parameter.  
  
     Specifies a path name for a precompiled header instead of using the default path name.  
  
     For more information, see [/Fp (Name .Pch File)](../Topic/-Fp%20\(Name%20.Pch%20File\).md).  
  
-   **PreprocessKeepComments**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preserves comments during preprocessing.  
  
     For more information, see [/C (Preserve Comments During Preprocessing)](../Topic/-C%20\(Preserve%20Comments%20During%20Preprocessing\).md).  
  
-   **PreprocessorDefinitions**  
  
     Optional `String[]` parameter.  
  
     Defines a preprocessing symbol for your source file.  
  
     For more information, see [/D (Preprocessor Definitions)](../Topic/-D%20\(Preprocessor%20Definitions\).md).  
  
-   **PreprocessOutput**  
  
     Optional `ITaskItem[]` parameter.  
  
     Defines an array of preprocessor output items that can be consumed and emitted by tasks.  
  
-   **PreprocessOutputPath**  
  
     Optional `String` parameter.  
  
     Specifies the name of the output file to which the **PreprocessToFile** parameter writes preprocessed output.  
  
     For more information, see [/Fi (Preprocess Output File Name)](../Topic/-Fi%20\(Preprocess%20Output%20File%20Name\).md).  
  
-   **PreprocessSuppressLineNumbers**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preprocesses C and C++ source files and copies the preprocessed files to the standard output device.  
  
     For more information, see [/EP (Preprocess to stdout Without #line Directives)](../Topic/-EP%20\(Preprocess%20to%20stdout%20Without%20%23line%20Directives\).md).  
  
-   **PreprocessToFile**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preprocesses C and C++ source files and writes the preprocessed output to a file.  
  
     For more information, see [/P (Preprocess to a File)](../Topic/-P%20\(Preprocess%20to%20a%20File\).md).  
  
-   **ProcessorNumber**  
  
     Optional `Integer` parameter.  
  
     Specifies the maximum number of processors to use in a multiprocessor compilation. Use this parameter in combination with the **MultiProcessorCompilation** parameter.  
  
-   **ProgramDataBaseFileName**  
  
     Optional `String` parameter.  
  
     Specifies a file name for the program database (PDB) file.  
  
     For more information, see [/Fd (Program Database File Name)](../Topic/-Fd%20\(Program%20Database%20File%20Name\).md).  
  
-   **RuntimeLibrary**  
  
     Optional `String` parameter.  
  
     Indicates whether a multithreaded module is a DLL, and selects retail or debug versions of the run-time library.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **MultiThreaded** - **/MT**  
  
    -   **MultiThreadedDebug** - **/MTd**  
  
    -   **MultiThreadedDLL** - **/MD**  
  
    -   **MultiThreadedDebugDLL** - **/MDd**  
  
     For more information, see [/MD, /MT, /LD (Use Run-Time Library)](../Topic/-MD,%20-MT,%20-LD%20\(Use%20Run-Time%20Library\).md).  
  
-   **RuntimeTypeInfo**  
  
     Optional `Boolean` parameter.  
  
     If `true`, adds code to check C++ object types at run time (run-time type information).  
  
     For more information, see [/GR (Enable Run-Time Type Information)](../Topic/-GR%20(Enable%20Run-Time%20Type%20Information).md).  
  
-   **ShowIncludes**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to output a list of the include files.  
  
     For more information, see [/showIncludes (List Include Files)](../Topic/-showIncludes%20\(List%20Include%20Files\).md).  
  
-   **SmallerTypeCheck**  
  
     Optional `Boolean` parameter.  
  
     If `true`, reports a run-time error if a value is assigned to a smaller data type and causes a data loss.  
  
     For more information, see the **/RTCc** option in [/RTC (Run-Time Error Checks)](../Topic/-RTC%20\(Run-Time%20Error%20Checks\).md).  
  
-   **Sources**  
  
     Required `ITaskItem[]` parameter.  
  
     Specifies a list of source files separated by spaces.  
  
-   **StringPooling**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables the compiler to create one copy of identical strings in the program image.  
  
     For more information, see [/GF (Eliminate Duplicate Strings)](../Topic/-GF%20\(Eliminate%20Duplicate%20Strings\).md).  
  
-   **StructMemberAlignment**  
  
     Optional `String` parameter.  
  
     Specifies the byte alignment for all members in a structure.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - **/Zp1**  
  
    -   **1Byte** - **/Zp1**  
  
    -   **2Bytes** - **/Zp2**  
  
    -   **4Bytes** - **/Zp4**  
  
    -   **8Bytes** - **/Zp8**  
  
    -   **16Bytes** - **/Zp16**  
  
     For more information, see [/Zp (Struct Member Alignment)](../Topic/-Zp%20\(Struct%20Member%20Alignment\).md).  
  
-   **SuppressStartupBanner**  
  
     Optional `Boolean` parameter.  
  
     If `true`, prevents the display of the copyright and version number message when the task starts.  
  
     For more information, see [/nologo (Suppress Startup Banner) (C/C++)](../Topic/-nologo%20\(Suppress%20Startup%20Banner\)%20\(C-C++\).md).  
  
-   **TrackerLogDirectory**  
  
     Optional `String` parameter.  
  
     Specifies the intermediate directory where tracking logs for this task are stored.  
  
     For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
-   **TreatSpecificWarningsAsErrors**  
  
     Optional **String[]** parameter.  
  
     Treats the specified list of compiler warnings as errors.  
  
     For more information, see the **/we**`n` option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](../Topic/-w,%20-W0,%20-W1,%20-W2,%20-W3,%20-W4,%20-w1,%20-w2,%20-w3,%20-w4,%20-Wall,%20-wd,%20-we,%20-wo,%20-Wv,%20-WX%20\(Warning%20Level\).md).  
  
-   **TreatWarningAsError**  
  
     Optional `Boolean` parameter.  
  
     If `true`, treat all compiler warnings as errors.  
  
     For more information, see **/WX** option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](../Topic/-w,%20-W0,%20-W1,%20-W2,%20-W3,%20-W4,%20-w1,%20-w2,%20-w3,%20-w4,%20-Wall,%20-wd,%20-we,%20-wo,%20-Wv,%20-WX%20\(Warning%20Level\).md).  
  
-   **TreatWChar_tAsBuiltInType**  
  
     Optional `Boolean` parameter.  
  
     If `true`, treat the `wchar_t` type as a native type.  
  
     For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](../Topic/-Zc:wchar_t%20\(wchar_t%20Is%20Native%20Type\).md).  
  
-   **UndefineAllPreprocessorDefinitions**  
  
     Optional `Boolean` parameter.  
  
     If `true`, undefines the Microsoft-specific symbols that the compiler defines.  
  
     For more information, see the **/u** option in [/U, /u (Undefine Symbols)](../Topic/-U,%20-u%20\(Undefine%20Symbols\).md).  
  
-   **UndefinePreprocessorDefinitions**  
  
     Optional `String[]` parameter.  
  
     Specifies a list of one or more preprocessor symbols to undefine.  
  
     For more information, see **/U** option in [/U, /u (Undefine Symbols)](../Topic/-U,%20-u%20\(Undefine%20Symbols\).md).  
  
-   **UseFullPaths**  
  
     Optional `Boolean` parameter.  
  
     If `true`, displays the full path of source code files passed to the compiler in diagnostics.  
  
     For more information, see [/FC (Full Path of Source Code File in Diagnostics)](../Topic/-FC%20\(Full%20Path%20of%20Source%20Code%20File%20in%20Diagnostics\).md).  
  
-   **UseUnicodeForAssemblerListing**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the output file to be created in UTF-8 format.  
  
     For more information, see the **/FAu** option in [/FA, /Fa (Listing File)](../Topic/-FA,%20-Fa%20\(Listing%20File\).md).  
  
-   **WarningLevel**  
  
     Optional `String` parameter.  
  
     Specifies the highest level of warning that is to be generated by the compiler.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **TurnOffAllWarnings** - **/W0**  
  
    -   **Level1** - **/W1**  
  
    -   **Level2** - **/W2**  
  
    -   **Level3** - **/W3**  
  
    -   **Level4** - **/W4**  
  
    -   **EnableAllWarnings** - **/Wall**  
  
     For more information, see the **/W***n* option in [/w, /W0, /W1, /W2, /W3, /W4, /w1, /w2, /w3, /w4, /Wall, /wd, /we, /wo, /Wv, /WX (Warning Level)](../Topic/-w,%20-W0,%20-W1,%20-W2,%20-W3,%20-W4,%20-w1,%20-w2,%20-w3,%20-w4,%20-Wall,%20-wd,%20-we,%20-wo,%20-Wv,%20-WX%20\(Warning%20Level\).md).  
  
-   **WholeProgramOptimization**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables whole program optimization.  
  
     For more information, see [/GL (Whole Program Optimization)](../Topic/-GL%20\(Whole%20Program%20Optimization\).md).  
  
-   **XMLDocumentationFileName**  
  
     Optional `String` parameter.  
  
     Specifies the name of the generated XML documentation files. This parameter can be a file or directory name.  
  
     For more information, see the `name` argument in [/doc (Process Documentation Comments) (C/C++)](../Topic/-doc%20\(Process%20Documentation%20Comments\)%20\(C-C++\).md). Also see the **GenerateXMLDocumentationFiles** parameter in this table.  
  
-   **MinimalRebuildFromTracking**  
  
     Optional `Boolean` parameter.  
  
     If `true`, a tracked incremental build is performed; if `false`, a rebuild is performed.  
  
-   **TLogReadFiles**  
  
     Optional `ITaskItem[]` parameter.  
  
     Specifies an array of items that represent the *read file tracking logs*.  
  
     A read-file tracking log (.tlog) contains the names of the input files that are read by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
-   **TLogWriteFiles**  
  
     Optional `ITaskItem[]` parameter.  
  
     Specifies an array of items that represent the *write file tracking logs*.  
  
     A write-file tracking log (.tlog) contains the names of the output files that are written by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
-   **TrackFileAccess**  
  
     Optional `Boolean` parameter.  
  
     If `true`, tracks file access patterns.  
  
     For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
## Remarks  
  
## See Also  
 [Task Reference](../reference/msbuild-task-reference.md)