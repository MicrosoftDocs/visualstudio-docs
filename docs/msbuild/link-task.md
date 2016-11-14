---
title: "Link Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VC.Project.VCLinkerTool.ForceFileOutput"
  - "VC.Project.VCLinkerTool.LinkStatus"
  - "VC.Project.VCLinkerTool.CLRUnmanagedCodeCheck"
  - "VC.Project.VCLinkerTool.SpecifySectionAttributes"
  - "VC.Project.VCLinkerTool.SupportNobindOfDelayLoadedDLL"
  - "VC.Project.VCLinkerTool.MinimumRequiredVersion"
  - "VC.Project.VCLinkerTool.PerUserRedirection"
  - "VC.Project.VCLinkerTool.CreateHotPatchableImage"
  - "VC.Project.VCLinkerTool.DataExecutionPrevention"
  - "VC.Project.VCLinkerTool.TreatLinkerWarningsAsErrors"
  - "vc.task.link"
  - "VC.Project.VCLinkerTool.ImageHasSafeExceptionHandlers"
  - "VC.Project.VCLinkerTool.CLRSupportLastError"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild (Visual C++), Link task"
  - "Link task (MSBuild (Visual C++))"
ms.assetid: 0a61f168-3113-4fa7-83a3-d9142e2a33f8
caps.latest.revision: 12
author: "kempb"
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
# Link Task
Wraps the Visual C++ linker tool, link.exe. The linker tool links Common Object File Format (COFF) object files and libraries to create an executable (.exe) file or a dynamic-link library (DLL). For more information, see [Linker Options](/visual-cpp/build/reference/linker-options).  
  
## Parameters  
 The following table describes the parameters of the **Link** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.  
  
-   **AdditionalDependencies**  
  
     Optional **String[]** parameter.  
  
     Specifies a list of input files to add to the command.  
  
     For more information, see [LINK Input Files](/visual-cpp/build/reference/link-input-files).  
  
-   **AdditionalLibraryDirectories**  
  
     Optional **String[]** parameter.  
  
     Overrides the environment library path. Specify a directory name.  
  
     For more information, see [/LIBPATH (Additional Libpath)](/visual-cpp/build/reference/libpath-additional-libpath).  
  
-   **AdditionalManifestDependencies**  
  
     Optional **String[]** parameter.  
  
     Specifies attributes that will be placed in the `dependency` section of the manifest file.  
  
     For more information, see [/MANIFESTDEPENDENCY (Specify Manifest Dependencies)](/visual-cpp/build/reference/manifestdependency-specify-manifest-dependencies). Also, see "Publisher Configuration Files" on the [MSDN](http://go.microsoft.com/fwlink/?LinkId=737) Web site.  
  
-   **AdditionalOptions**  
  
     Optional **String** parameter.  
  
     A list of linker options as specified on the command line. For example, **"***/option1 /option2 /option#*". Use this parameter to specify linker options that are not represented by any other **Link** task parameter.  
  
     For more information, see [Linker Options](/visual-cpp/build/reference/linker-options).  
  
-   **AddModuleNamesToAssembly**  
  
     Optional **String[]** parameter.  
  
     Adds a module reference to an assembly.  
  
     For more information, see [/ASSEMBLYMODULE (Add a MSIL Module to the Assembly)](/visual-cpp/build/reference/assemblymodule-add-a-msil-module-to-the-assembly).  
  
-   **AllowIsolation**  
  
     Optional **Boolean** parameter.  
  
     If `true`, causes the operating system to do manifest lookups and loads. If `false`, indicates that DLLs are loaded as if there was no manifest.  
  
     For more information, see [/ALLOWISOLATION (Manifest Lookup)](/visual-cpp/build/reference/allowisolation-manifest-lookup).  
  
-   **AssemblyDebug**  
  
     Optional **Boolean** parameter.  
  
     If `true`, emits the **DebuggableAttribute** attribute together with debug information tracking and disables JIT optimizations. If `false`, emits the **DebuggableAttribute** attribute but disables debug information tracking and enables JIT optimizations.  
  
     For more information, see [/ASSEMBLYDEBUG (Add DebuggableAttribute)](/visual-cpp/build/reference/assemblydebug-add-debuggableattribute).  
  
-   **AssemblyLinkResource**  
  
     Optional **String[]** parameter.  
  
     Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. Specify the name of the resource.  
  
     For more information, see [/ASSEMBLYLINKRESOURCE (Link to .NET Framework Resource)](/visual-cpp/build/reference/assemblylinkresource-link-to-dotnet-framework-resource).  
  
-   **AttributeFileTracking**  
  
     Implicit **Boolean** parameter.  
  
     Enables deeper file tracking to capture link incremental's behavior. Always returns `true`.  
  
-   **BaseAddress**  
  
     Optional **String** parameter.  
  
     Sets a base address for the program or DLL being built. Specify `{address[,size] | @filename,key}`.  
  
     For more information, see [/BASE (Base Address)](/visual-cpp/build/reference/base-base-address).  
  
-   **BuildingInIDE**  
  
     Optional **Boolean** parameter.  
  
     If true, indicates that MSBuild is invoked from the IDE. Otherwise, indicates that MSBuild is invoked from the command line.  
  
     This parameter has no equivalent linker option.  
  
-   **CLRImageType**  
  
     Optional **String** parameter.  
  
     Sets the type of a common language runtime (CLR) image.  
  
     Specify one of the following values, each of which corresponds to a linker option.  
  
    -   **Default** - *\<none>*  
  
    -   **ForceIJWImage** - **/CLRIMAGETYPE:IJW**  
  
    -   **ForcePureILImage** - **/CLRIMAGETYPE:PURE**  
  
    -   **ForceSafeILImage** - **/CLRIMAGETYPE:SAFE**  
  
     For more information, see [/CLRIMAGETYPE (Specify Type of CLR Image)](/visual-cpp/build/reference/clrimagetype-specify-type-of-clr-image).  
  
-   **CLRSupportLastError**  
  
     Optional **String** parameter.  
  
     Preserves the last error code of functions called through the P/Invoke mechanism.  
  
     Specify one of the following values, each of which corresponds to a linker option.  
  
    -   **Enabled** - **/CLRSupportLastError**  
  
    -   **Disabled** - **/CLRSupportLastError:NO**  
  
    -   **SystemDlls** - **/CLRSupportLastError:SYSTEMDLL**  
  
     For more information, see [/CLRSUPPORTLASTERROR (Preserve Last Error Code for PInvoke Calls)](/visual-cpp/build/reference/clrsupportlasterror-preserve-last-error-code-for-pinvoke-calls).  
  
-   **CLRThreadAttribute**  
  
     Optional **String** parameter.  
  
     Explicitly specifies the threading attribute for the entry point of your CLR program.  
  
     Specify one of the following values, each of which corresponds to a linker option.  
  
    -   **DefaultThreadingAttribute** - **/CLRTHREADATTRIBUTE:NONE**  
  
    -   **MTAThreadingAttribute** - **/CLRTHREADATTRIBUTE:MTA**  
  
    -   **STAThreadingAttribute** - **/CLRTHREADATTRIBUTE:STA**  
  
     For more information, see [/CLRTHREADATTRIBUTE (Set CLR Thread Attribute)](/visual-cpp/build/reference/clrthreadattribute-set-clr-thread-attribute).  
  
-   **CLRUnmanagedCodeCheck**  
  
     Optional **Boolean** parameter.  
  
     Specifies whether the linker will apply **SuppressUnmanagedCodeSecurityAttribute** to linker-generated P/Invoke calls from managed code into native DLLs.  
  
     For more information, see [/CLRUNMANAGEDCODECHECK (Add SupressUnmanagedCodeSecurityAttribute)](/visual-cpp/build/reference/clrunmanagedcodecheck-add-supressunmanagedcodesecurityattribute).  
  
-   **CreateHotPatchableImage**  
  
     Optional **String** parameter.  
  
     Prepares an image for hot patching.  
  
     Specify one of the following values, which corresponds to a linker option.  
  
    -   **Enabled** - **/FUNCTIONPADMIN**  
  
    -   **X86Image** - **/FUNCTIONPADMIN:5**  
  
    -   **X64Image** - **/FUNCTIONPADMIN:6**  
  
    -   **ItaniumImage** - **/FUNCTIONPADMIN:16**  
  
     For more information, see [/FUNCTIONPADMIN (Create Hotpatchable Image)](/visual-cpp/build/reference/functionpadmin-create-hotpatchable-image).  
  
-   **DataExecutionPrevention**  
  
     Optional **Boolean** parameter.  
  
     If `true`, indicates that an executable was tested to be compatible with the Windows Data Execution Prevention feature.  
  
     For more information, see [/NXCOMPAT (Compatible with Data Execution Prevention)](/visual-cpp/build/reference/nxcompat-compatible-with-data-execution-prevention).  
  
-   **DelayLoadDLLs**  
  
     Optional **String[]** parameter.  
  
     This parameter causes *delayed loading* of DLLs. Specify the name of a DLL to delay load.  
  
     For more information, see [/DELAYLOAD (Delay Load Import)](/visual-cpp/build/reference/delayload-delay-load-import).  
  
-   **DelaySign**  
  
     Optional **Boolean** parameter.  
  
     If `true`, partially signs an assembly. By default, the value is `false`.  
  
     For more information, see [/DELAYSIGN (Partially Sign an Assembly)](/visual-cpp/build/reference/delaysign-partially-sign-an-assembly).  
  
-   **Driver**  
  
     Optional **String** parameter.  
  
     Specify this parameter to build a Windows NT kernel mode driver.  
  
     Specify one of the following values, each of which corresponds to a linker option.  
  
    -   **NotSet** - *\<none>*  
  
    -   **Driver** - **/Driver**  
  
    -   **UpOnly** - **/DRIVER:UPONLY**  
  
    -   **WDM** - **/DRIVER:WDM**  
  
     For more information, see [/DRIVER (Windows NT Kernel Mode Driver)](/visual-cpp/build/reference/driver-windows-nt-kernel-mode-driver).  
  
-   **EmbedManagedResourceFile**  
  
     Optional **String[]** parameter.  
  
     Embeds a resource file in an assembly. Specify the required resource file name. Optionally specify the logical name, which is used to load the resource, and the **PRIVATE** option, which indicates in the assembly manifest that the resource file is private.  
  
     For more information, see [/ASSEMBLYRESOURCE (Embed a Managed Resource)](/visual-cpp/build/reference/assemblyresource-embed-a-managed-resource).  
  
-   **EnableCOMDATFolding**  
  
     Optional **Boolean** parameter.  
  
     If `true`, enables identical COMDAT folding.  
  
     For more information, see the `ICF[= iterations]` argument of [/OPT (Optimizations)](/visual-cpp/build/reference/opt-optimizations).  
  
-   **EnableUAC**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies that User Account Control (UAC) information is embedded in the program manifest.  
  
     For more information, see [/MANIFESTUAC (Embeds UAC information in manifest)](/visual-cpp/build/reference/manifestuac-embeds-uac-information-in-manifest).  
  
-   **EntryPointSymbol**  
  
     Optional **String** parameter.  
  
     Specifies an entry point function as the starting address for an .exe file or DLL. Specify a function name as the parameter value.  
  
     For more information, see [/ENTRY (Entry-Point Symbol)](/visual-cpp/build/reference/entry-entry-point-symbol).  
  
-   **FixedBaseAddress**  
  
     Optional **Boolean** parameter.  
  
     If `true`, creates a program or DLL that can be loaded only at its preferred base address.  
  
     For more information, see [/FIXED (Fixed Base Address)](/visual-cpp/build/reference/fixed-fixed-base-address).  
  
-   **ForceFileOutput**  
  
     Optional **String** parameter.  
  
     Tells the linker to create a valid .exe file or DLL even if a symbol is referenced but not defined, or is multiply defined.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Enabled** - **/FORCE**  
  
    -   **MultiplyDefinedSymbolOnly** - **/FORCE:MULTIPLE**  
  
    -   **UndefinedSymbolOnly** - **/FORCE:UNRESOLVED**  
  
     For more information, see [/FORCE (Force File Output)](/visual-cpp/build/reference/force-force-file-output).  
  
-   **ForceSymbolReferences**  
  
     Optional **String[]** parameter.  
  
     This parameter tells the linker to add a specified symbol to the symbol table.  
  
     For more information, see [/INCLUDE (Force Symbol References)](/visual-cpp/build/reference/include-force-symbol-references).  
  
-   **FunctionOrder**  
  
     Optional **String** parameter.  
  
     This parameter optimizes your program by placing the specified packaged functions (COMDATs) into the image in a predetermined order.  
  
     For more information, see [/ORDER (Put Functions in Order)](/visual-cpp/build/reference/order-put-functions-in-order).  
  
-   **GenerateDebugInformation**  
  
     Optional **Boolean** parameter.  
  
     If `true`, creates debugging information for the .exe file or DLL.  
  
     For more information, see [/DEBUG (Generate Debug Info)](/visual-cpp/build/reference/debug-generate-debug-info).  
  
-   **GenerateManifest**  
  
     Optional **Boolean** parameter.  
  
     If `true`, creates a side-by-side manifest file.  
  
     For more information, see [/MANIFEST (Create Side-by-Side Assembly Manifest)](/visual-cpp/build/reference/manifest-create-side-by-side-assembly-manifest).  
  
-   **GenerateMapFile**  
  
     Optional **Boolean** parameter.  
  
     If `true`, creates a *map file*. The file name extension of the map file is .map.  
  
     For more information, see [/MAP (Generate Mapfile)](/visual-cpp/build/reference/map-generate-mapfile).  
  
-   **HeapCommitSize**  
  
     Optional **String** parameter.  
  
     Specifies the amount of physical memory on the heap to allocate at a time.  
  
     For more information, see the `commit` argument in [/HEAP (Set Heap Size)](/visual-cpp/build/reference/heap-set-heap-size). Also, see the **HeapReserveSize** parameter.  
  
-   **HeapReserveSize**  
  
     Optional **String** parameter.  
  
     Specifies the total heap allocation in virtual memory.  
  
     For more information, see the `reserve` argument in [/HEAP (Set Heap Size)](/visual-cpp/build/reference/heap-set-heap-size). Also, see the **HeapCommitSize** parameter in this table.  
  
-   **IgnoreAllDefaultLibraries**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the linker to remove one or more default libraries from the list of libraries it searches when it resolves external references.  
  
     For more information, see [/NODEFAULTLIB (Ignore Libraries)](/visual-cpp/build/reference/nodefaultlib-ignore-libraries).  
  
-   **IgnoreEmbeddedIDL**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies that any IDL attributes in source code should not be processed into an .idl file.  
  
     For more information, see [/IGNOREIDL (Don't Process Attributes into MIDL)](/visual-cpp/build/reference/ignoreidl-don-t-process-attributes-into-midl).  
  
-   **IgnoreImportLibrary**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies that the import library generated by this configuration should not be imported into dependent projects.  
  
     This parameter does not correspond to a linker option.  
  
-   **IgnoreSpecificDefaultLibraries**  
  
     Optional **String[]** parameter.  
  
     Specifies one or more names of default libraries to ignore. Separate multiple libraries by using semi-colons.  
  
     For more information, see [/NODEFAULTLIB (Ignore Libraries)](/visual-cpp/build/reference/nodefaultlib-ignore-libraries).  
  
-   **ImageHasSafeExceptionHandlers**  
  
     Optional **Boolean** parameter.  
  
     If `true`, the linker produces an image only if it can also produce a table of the image's safe exception handlers.  
  
     For more information, see [/SAFESEH (Image has Safe Exception Handlers)](/visual-cpp/build/reference/safeseh-image-has-safe-exception-handlers).  
  
-   **ImportLibrary**  
  
     A user-specified import library name that replaces the default library name.  
  
     For more information, see [/IMPLIB (Name Import Library)](/visual-cpp/build/reference/implib-name-import-library).  
  
-   **KeyContainer**  
  
     Optional **String** parameter.  
  
     Container that contains the key for a signed assembly.  
  
     For more information, see [/KEYCONTAINER (Specify a Key Container to Sign an Assembly)](/visual-cpp/build/reference/keycontainer-specify-a-key-container-to-sign-an-assembly). Also, see the **KeyFile** parameter in this table.  
  
-   **KeyFile**  
  
     Optional **String** parameter.  
  
     Specifies a file that contains the key for a signed assembly.  
  
     For more information, see [/KEYFILE (Specify Key or Key Pair to Sign an Assembly)](/visual-cpp/build/reference/keyfile-specify-key-or-key-pair-to-sign-an-assembly). Also, see the **KeyContainer** parameter.  
  
-   **LargeAddressAware**  
  
     Optional **Boolean** parameter.  
  
     If `true`, the application can handle addresses larger than 2 gigabytes.  
  
     For more information, see [/LARGEADDRESSAWARE (Handle Large Addresses)](/visual-cpp/build/reference/largeaddressaware-handle-large-addresses).  
  
-   **LinkDLL**  
  
     Optional **Boolean** parameter.  
  
     If `true`, builds a DLL as the main output file.  
  
     For more information, see [/DLL (Build a DLL)](/visual-cpp/build/reference/dll-build-a-dll).  
  
-   **LinkErrorReporting**  
  
     Optional **String** parameter.  
  
     Lets you provide internal compiler error (ICE) information directly to Microsoft.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NoErrorReport** - **/ERRORREPORT:NONE**  
  
    -   **PromptImmediately** - **/ERRORREPORT:PROMPT**  
  
    -   **QueueForNextLogin** - **/ERRORREPORT:QUEUE**  
  
    -   **SendErrorReport** - **/ERRORREPORT:SEND**  
  
     For more information, see [/ERRORREPORT (Report Internal Linker Errors)](/visual-cpp/build/reference/errorreport-report-internal-linker-errors).  
  
-   **LinkIncremental**  
  
     Optional **Boolean** parameter.  
  
     If `true`, enables incremental linking.  
  
     For more information, see [/INCREMENTAL (Link Incrementally)](/visual-cpp/build/reference/incremental-link-incrementally).  
  
-   **LinkLibraryDependencies**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies that library outputs from project dependencies are automatically linked in.  
  
     This parameter does not correspond to a linker option.  
  
-   **LinkStatus**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies that the linker is to display a progress indicator that shows what percentage of the link is complete.  
  
     For more information, see the `STATUS` argument of [/LTCG (Link-time Code Generation)](/visual-cpp/build/reference/ltcg-link-time-code-generation).  
  
-   **LinkTimeCodeGeneration**  
  
     Optional **String** parameter.  
  
     Specifies options for profile-guided optimization.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - *\<none>*  
  
    -   **UseLinkTimeCodeGeneration** - **/LTCG**  
  
    -   **PGInstrument** - **/LTCG:PGInstrument**  
  
    -   **PGOptimization** - **/LTCG:PGOptimize**  
  
    -   **PGUpdate**  
  
         \- **/LTCG:PGUpdate**  
  
     For more information, see [/LTCG (Link-time Code Generation)](/visual-cpp/build/reference/ltcg-link-time-code-generation).  
  
-   **ManifestFile**  
  
     Optional **String** parameter.  
  
     Changes the default manifest file name to the specified file name.  
  
     For more information, see [/MANIFESTFILE (Name Manifest File)](/visual-cpp/build/reference/manifestfile-name-manifest-file).  
  
-   **MapExports**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the linker to include exported functions in a map file.  
  
     For more information, see the `EXPORTS` argument of [/MAPINFO (Include Information in Mapfile)](/visual-cpp/build/reference/mapinfo-include-information-in-mapfile).  
  
-   **MapFileName**  
  
     Optional **String** parameter.  
  
     Changes the default map file name to the specified file name.  
  
-   **MergedIDLBaseFileName**  
  
     Optional **String** parameter.  
  
     Specifies the file name and file name extension of the .idl file.  
  
     For more information, see [/IDLOUT (Name MIDL Output Files)](/visual-cpp/build/reference/idlout-name-midl-output-files).  
  
-   **MergeSections**  
  
     Optional **String** parameter.  
  
     Combines sections in an image. Specify `from-section=to-section`.  
  
     For more information, see [/MERGE (Combine Sections)](/visual-cpp/build/reference/merge-combine-sections).  
  
-   **MidlCommandFile**  
  
     Optional **String** parameter.  
  
     Specify the name of a file that contains MIDL command-line options.  
  
     For more information, see [/MIDL (Specify MIDL Command Line Options)](/visual-cpp/build/reference/midl-specify-midl-command-line-options).  
  
-   **MinimumRequiredVersion**  
  
     Optional **String** parameter.  
  
     Specifies the minimum required version of the subsystem. The arguments are decimal numbers in the range 0 through 65535.  
  
-   **ModuleDefinitionFile**  
  
     Optional **String** parameter.  
  
     Specifies the name of a [module definition file](/visual-cpp/build/reference/module-definition-dot-def-files).  
  
     For more information, see [/DEF (Specify Module-Definition File)](/visual-cpp/build/reference/def-specify-module-definition-file).  
  
-   **MSDOSStubFileName**  
  
     Optional **String** parameter.  
  
     Attaches the specified MS-DOS stub program to a Win32 program.  
  
     For more information, see [/STUB (MS-DOS Stub File Name)](/visual-cpp/build/reference/stub-ms-dos-stub-file-name).  
  
-   **NoEntryPoint**  
  
     Optional **Boolean** parameter.  
  
     If `true`, specifies a resource-only DLL.  
  
     For more information, see [/NOENTRY (No Entry Point)](/visual-cpp/build/reference/noentry-no-entry-point).  
  
-   **ObjectFiles**  
  
     Implicit **String[]** parameter.  
  
     Specifies the object files that are linked.  
  
-   **OptimizeReferences**  
  
     Optional **Boolean** parameter.  
  
     If `true`, eliminates functions and/or data that are never referenced.  
  
     For more information, see the `REF` argument in [/OPT (Optimizations)](/visual-cpp/build/reference/opt-optimizations).  
  
-   **OutputFile**  
  
     Optional **String** parameter.  
  
     Overrides the default name and location of the program that the linker creates.  
  
     For more information, see [/OUT (Output File Name)](/visual-cpp/build/reference/out-output-file-name).  
  
-   **PerUserRedirection**  
  
     Optional **Boolean** parameter.  
  
     If `true` and Register Output is enabled, forces registry writes to **HKEY_CLASSES_ROOT** to be redirected to **HKEY_CURRENT_USER**.  
  
-   **PreprocessOutput**  
  
     Optional `ITaskItem[]` parameter.  
  
     Defines an array of preprocessor output items that can be consumed and emitted by tasks.  
  
-   **PreventDllBinding**  
  
     Optional **Boolean** parameter.  
  
     If `true`, indicates to Bind.exe that the linked image should not be bound.  
  
     For more information, see [/ALLOWBIND (Prevent DLL Binding)](/visual-cpp/build/reference/allowbind-prevent-dll-binding).  
  
-   **Profile**  
  
     Optional **Boolean** parameter.  
  
     If `true`, produces an output file that can be used with the **Performance Tools** profiler.  
  
     For more information, see [/PROFILE (Performance Tools Profiler)](/visual-cpp/build/reference/profile-performance-tools-profiler).  
  
-   **ProfileGuidedDatabase**  
  
     Optional **String** parameter.  
  
     Specifies the name of the .pgd file that will be used to hold information about the running program  
  
     For more information, see [/PGD (Specify Database for Profile-Guided Optimizations)](/visual-cpp/build/reference/pgd-specify-database-for-profile-guided-optimizations).  
  
-   **ProgramDatabaseFile**  
  
     Optional **String** parameter.  
  
     Specifies a name for the program database (PDB) that the linker creates.  
  
     For more information, see [/PDB (Use Program Database)](/visual-cpp/build/reference/pdb-use-program-database).  
  
-   **RandomizedBaseAddress**  
  
     Optional **Boolean** parameter.  
  
     If `true`, generates an executable image that can be randomly rebased at load time by using the *address space layout randomization* (ASLR) feature of Windows.  
  
     For more information, see [/DYNAMICBASE (Use address space layout randomization)](/visual-cpp/build/reference/dynamicbase-use-address-space-layout-randomization).  
  
-   **RegisterOutput**  
  
     Optional **Boolean** parameter.  
  
     If `true`, registers the primary output of this build.  
  
-   **SectionAlignment**  
  
     Optional **Integer** parameter.  
  
     Specifies the alignment of each section within the linear address space of the program. The parameter value is a unit number of bytes and is a power of two.  
  
     For more information, see [/ALIGN (Section Alignment)](/visual-cpp/build/reference/align-section-alignment).  
  
-   **SetChecksum**  
  
     Optional **Boolean** parameter.  
  
     If `true`, sets the checksum in the header of an .exe file.  
  
     For more information, see [/RELEASE (Set the Checksum)](/visual-cpp/build/reference/release-set-the-checksum).  
  
-   **ShowProgress**  
  
     Optional **String** parameter.  
  
     Specifies the verbosity of progress reports for the linking operation.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NotSet** - *\<none>*  
  
    -   **LinkVerbose** - **/VERBOSE**  
  
    -   **LinkVerboseLib** - **/VERBOSE:Lib**  
  
    -   **LinkVerboseICF** - **/VERBOSE:ICF**  
  
    -   **LinkVerboseREF** - **/VERBOSE:REF**  
  
    -   **LinkVerboseSAFESEH** - **/VERBOSE:SAFESEH**  
  
    -   **LinkVerboseCLR** - **/VERBOSE:CLR**  
  
     For more information, see [/VERBOSE (Print Progress Messages)](/visual-cpp/build/reference/verbose-print-progress-messages).  
  
-   **Sources**  
  
     Required `ITaskItem[]` parameter.  
  
     Defines an array of MSBuild source file items that can be consumed and emitted by tasks.  
  
-   **SpecifySectionAttributes**  
  
     Optional **String** parameter.  
  
     Specifies the attributes of a section. This overrides the attributes that were set when the .obj file for the section was compiled.  
  
     For more information, see [/SECTION (Specify Section Attributes)](/visual-cpp/build/reference/section-specify-section-attributes).  
  
-   **StackCommitSize**  
  
     Optional **String** parameter.  
  
     Specifies the amount of physical memory in each allocation when additional memory is allocated.  
  
     For more information, see the `commit` argument of [/STACK (Stack Allocations)](/visual-cpp/build/reference/stack-stack-allocations).  
  
-   **StackReserveSize**  
  
     Optional **String** parameter.  
  
     Specifies the total stack allocation size in virtual memory.  
  
     For more information, see the `reserve` argument of [/STACK (Stack Allocations)](/visual-cpp/build/reference/stack-stack-allocations).  
  
-   **StripPrivateSymbols**  
  
     Optional **String** parameter.  
  
     Creates a second program database (PDB) file that omits symbols that you do not want to distribute to your customers. Specify the name of the second PDB file.  
  
     For more information, see [/PDBSTRIPPED (Strip Private Symbols)](/visual-cpp/build/reference/pdbstripped-strip-private-symbols).  
  
-   **SubSystem**  
  
     Optional **String** parameter.  
  
     Specifies the environment for the executable.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NotSet** - *\<none>*  
  
    -   **Console** - **/SUBSYSTEM:CONSOLE**  
  
    -   **Windows** - **/SUBSYSTEM:WINDOWS**  
  
    -   **Native** - **/SUBSYSTEM:NATIVE**  
  
    -   **EFI Application** - **/SUBSYSTEM:EFI_APPLICATION**  
  
    -   **EFI Boot Service Driver** - **/SUBSYSTEM:EFI_BOOT_SERVICE_DRIVER**  
  
    -   **EFI ROM** - **/SUBSYSTEM:EFI_ROM**  
  
    -   **EFI Runtime** - **/SUBSYSTEM:EFI_RUNTIME_DRIVER**  
  
    -   **WindowsCE** - **/SUBSYSTEM:WINDOWSCE**  
  
    -   **POSIX** - **/SUBSYSTEM:POSIX**  
  
     For more information, see [/SUBSYSTEM (Specify Subsystem)](/visual-cpp/build/reference/subsystem-specify-subsystem).  
  
-   **SupportNobindOfDelayLoadedDLL**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the linker not to include a bindable Import Address Table (IAT) in the final image.  
  
     For more information, see the `NOBIND` argument of [/DELAY (Delay Load Import Settings)](/visual-cpp/build/reference/delay-delay-load-import-settings).  
  
-   **SupportUnloadOfDelayLoadedDLL**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the delay-load helper function to support explicit unloading of the DLL.  
  
     For more information, see the `UNLOAD` argument of [/DELAY (Delay Load Import Settings)](/visual-cpp/build/reference/delay-delay-load-import-settings).  
  
-   **SuppressStartupBanner**  
  
     Optional **Boolean** parameter.  
  
     If `true`, prevents the display of the copyright and version number message when the task starts.  
  
     For more information, see [/NOLOGO (Suppress Startup Banner) (Linker)](/visual-cpp/build/reference/nologo-suppress-startup-banner-linker).  
  
-   **SwapRunFromCD**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the operating system to first copy the linker output to a swap file, and then run the image from there.  
  
     For more information, see the `CD` argument of [/SWAPRUN (Load Linker Output to Swap File)](/visual-cpp/build/reference/swaprun-load-linker-output-to-swap-file). Also, see the **SwapRunFromNET** parameter.  
  
-   **SwapRunFromNET**  
  
     Optional **Boolean** parameter.  
  
     If `true`, tells the operating system to first copy the linker output to a swap file, and then run the image from there.  
  
     For more information, see the `NET` argument of [/SWAPRUN (Load Linker Output to Swap File)](/visual-cpp/build/reference/swaprun-load-linker-output-to-swap-file). Also, see the **SwapRunFromCD** parameter in this table.  
  
-   **TargetMachine**  
  
     Optional **String** parameter.  
  
     Specifies the target platform for the program or DLL.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NotSet** - *\<none>*  
  
    -   **MachineARM** - **/MACHINE:ARM**  
  
    -   **MachineEBC** - **/MACHINE:EBC**  
  
    -   **MachineIA64** - **/MACHINE:IA64**  
  
    -   **MachineMIPS** - **/MACHINE:MIPS**  
  
    -   **MachineMIPS16** - **/MACHINE:MIPS16**  
  
    -   **MachineMIPSFPU** - **/MACHINE:MIPSFPU**  
  
    -   **MachineMIPSFPU16** - **/MACHINE:MIPSFPU16**  
  
    -   **MachineSH4** - **/MACHINE:SH4**  
  
    -   **MachineTHUMB** - **/MACHINE:THUMB**  
  
    -   **MachineX64** - **/MACHINE:X64**  
  
    -   **MachineX86** - **/MACHINE:X86**  
  
     For more information, see [/MACHINE (Specify Target Platform)](/visual-cpp/build/reference/machine-specify-target-platform).  
  
-   **TerminalServerAware**  
  
     Optional **Boolean** parameter.  
  
     If `true`, sets a flag in the IMAGE_OPTIONAL_HEADER DllCharacteristics field in the program image's optional header. When this flag is set, Terminal Server will not make certain changes to the application.  
  
     For more information, see [/TSAWARE (Create Terminal Server Aware Application)](/visual-cpp/build/reference/tsaware-create-terminal-server-aware-application).  
  
-   **TrackerLogDirectory**  
  
     Optional **String** parameter.  
  
     Specifies the directory of the tracker log.  
  
-   **TreatLinkerWarningAsErrors**  
  
     Optional **Boolean** parameter.  
  
     If `true`, causes no output file to be generated if the linker generates a warning.  
  
     For more information, see [/WX (Treat Linker Warnings as Errors)](/visual-cpp/build/reference/wx-treat-linker-warnings-as-errors).  
  
-   **TurnOffAssemblyGeneration**  
  
     Optional **Boolean** parameter.  
  
     If `true`, creates an image for the current output file without a .NET Framework assembly.  
  
     For more information, see [/NOASSEMBLY (Create a MSIL Module)](/visual-cpp/build/reference/noassembly-create-a-msil-module).  
  
-   **TypeLibraryFile**  
  
     Optional **String** parameter.  
  
     Specifies the file name and file name extension of the .tlb file. Specify a file name, or a path and file name.  
  
     For more information, see [/TLBOUT (Name .TLB File)](/visual-cpp/build/reference/tlbout-name-dot-tlb-file).  
  
-   **TypeLibraryResourceID**  
  
     Optional **Integer** parameter.  
  
     Designates a user-specified value for a linker-created type library. Specify a value from 1 through 65535.  
  
     For more information, see [/TLBID (Specify Resource ID for TypeLib)](/visual-cpp/build/reference/tlbid-specify-resource-id-for-typelib).  
  
-   **UACExecutionLevel**  
  
     Optional **String** parameter.  
  
     Specifies the requested execution level for the application when it is run under with User Account Control.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **AsInvoker** - `level='asInvoker'`  
  
    -   **HighestAvailable** - `level='highestAvailable'`  
  
    -   **RequireAdministrator** - `level='requireAdministrator'`  
  
     For more information, see the `level` argument of [/MANIFESTUAC (Embeds UAC information in manifest)](/visual-cpp/build/reference/manifestuac-embeds-uac-information-in-manifest).  
  
-   **UACUIAccess**  
  
     Optional **Boolean** parameter.  
  
     If `true`, the application bypasses user interface protection levels and drives input to higher-permission windows on the desktop; otherwise, `false`.  
  
     For more information, see the `uiAccess` argument of [/MANIFESTUAC (Embeds UAC information in manifest)](/visual-cpp/build/reference/manifestuac-embeds-uac-information-in-manifest).  
  
-   **UseLibraryDependencyInputs**  
  
     Optional **Boolean** parameter.  
  
     If `true`, the inputs to the librarian tool are used rather than the library file itself when library outputs of project dependencies are linked in.  
  
-   **Version**  
  
     Optional **String** parameter.  
  
     Put a version number in the header of the .exe or .dll file. Specify "`major[.minor]`". The `major` and `minor` arguments are decimal numbers from 0 through 65535.  
  
     For more information, see [/VERSION (Version Information)](/visual-cpp/build/reference/version-version-information).  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)