---
title: "Link Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
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
caps.latest.revision: 16
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Link Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps the Visual C++ linker tool, link.exe. The linker tool links Common Object File Format (COFF) object files and libraries to create an executable (.exe) file or a dynamic-link library (DLL). For more information, see [Linker Options](https://msdn.microsoft.com/library/c1d51b8a-bd23-416d-81e4-900e02b2c129).  
  
## Parameters  
 The following table describes the parameters of the **Link** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.  
  
- **AdditionalDependencies**  
  
   Optional **String[]** parameter.  
  
   Specifies a list of input files to add to the command.  
  
   For more information, see [LINK Input Files](https://msdn.microsoft.com/library/bb26fcc5-509a-4620-bc3e-b6c6e603a412).  
  
- **AdditionalLibraryDirectories**  
  
   Optional **String[]** parameter.  
  
   Overrides the environment library path. Specify a directory name.  
  
   For more information, see [/LIBPATH (Additional Libpath)](https://msdn.microsoft.com/library/7240af0b-9a3d-4d53-8169-2a92cd6958ba).  
  
- **AdditionalManifestDependencies**  
  
   Optional **String[]** parameter.  
  
   Specifies attributes that will be placed in the `dependency` section of the manifest file.  
  
   For more information, see [/MANIFESTDEPENDENCY (Specify Manifest Dependencies)](https://msdn.microsoft.com/library/e4b68313-33a2-4c3e-908e-ac2b9f7d6a73). Also, see "Publisher Configuration Files" on the [MSDN](https://go.microsoft.com/fwlink/?LinkId=737) Web site.  
  
- **AdditionalOptions**  
  
   Optional **String** parameter.  
  
   A list of linker options as specified on the command line. For example, **"**_/option1 /option2 /option#_". Use this parameter to specify linker options that are not represented by any other **Link** task parameter.  
  
   For more information, see [Linker Options](https://msdn.microsoft.com/library/c1d51b8a-bd23-416d-81e4-900e02b2c129).  
  
- **AddModuleNamesToAssembly**  
  
   Optional **String[]** parameter.  
  
   Adds a module reference to an assembly.  
  
   For more information, see [/ASSEMBLYMODULE (Add a MSIL Module to the Assembly)](https://msdn.microsoft.com/library/67357da8-e4b6-49fd-932c-329a5777f143).  
  
- **AllowIsolation**  
  
   Optional **Boolean** parameter.  
  
   If `true`, causes the operating system to do manifest lookups and loads. If `false`, indicates that DLLs are loaded as if there was no manifest.  
  
   For more information, see [/ALLOWISOLATION (Manifest Lookup)](https://msdn.microsoft.com/library/6d41851e-b3c1-4bdf-beaa-031773089d6f).  
  
- **AssemblyDebug**  
  
   Optional **Boolean** parameter.  
  
   If `true`, emits the **DebuggableAttribute** attribute together with debug information tracking and disables JIT optimizations. If `false`, emits the **DebuggableAttribute** attribute but disables debug information tracking and enables JIT optimizations.  
  
   For more information, see [/ASSEMBLYDEBUG (Add DebuggableAttribute)](https://msdn.microsoft.com/library/94443af3-470c-41d7-83a0-7434563d7982).  
  
- **AssemblyLinkResource**  
  
   Optional **String[]** parameter.  
  
   Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. Specify the name of the resource.  
  
   For more information, see [/ASSEMBLYLINKRESOURCE (Link to .NET Framework Resource)](https://msdn.microsoft.com/library/8b6ad184-1b33-47a4-8513-4803cf915b64).  
  
- **AttributeFileTracking**  
  
   Implicit **Boolean** parameter.  
  
   Enables deeper file tracking to capture link incremental's behavior. Always returns `true`.  
  
- **BaseAddress**  
  
   Optional **String** parameter.  
  
   Sets a base address for the program or DLL being built. Specify `{address[,size] | @filename,key}`.  
  
   For more information, see [/BASE (Base Address)](https://msdn.microsoft.com/library/00b9f6fe-0bd2-4772-a69c-7365eb199069).  
  
- **BuildingInIDE**  
  
   Optional **Boolean** parameter.  
  
   If true, indicates that MSBuild is invoked from the IDE. Otherwise, indicates that MSBuild is invoked from the command line.  
  
   This parameter has no equivalent linker option.  
  
- **CLRImageType**  
  
   Optional **String** parameter.  
  
   Sets the type of a common language runtime (CLR) image.  
  
   Specify one of the following values, each of which corresponds to a linker option.  
  
  - **Default** - *\<none>*  
  
  - **ForceIJWImage** - **/CLRIMAGETYPE:IJW**  
  
  - **ForcePureILImage** - **/CLRIMAGETYPE:PURE**  
  
  - **ForceSafeILImage** - **/CLRIMAGETYPE:SAFE**  
  
    For more information, see [/CLRIMAGETYPE (Specify Type of CLR Image)](https://msdn.microsoft.com/library/04c60ee6-9dd7-4391-bc03-6926ad0fa116).  
  
- **CLRSupportLastError**  
  
   Optional **String** parameter.  
  
   Preserves the last error code of functions called through the P/Invoke mechanism.  
  
   Specify one of the following values, each of which corresponds to a linker option.  
  
  - **Enabled** - **/CLRSupportLastError**  
  
  - **Disabled** - **/CLRSupportLastError:NO**  
  
  - **SystemDlls** - **/CLRSupportLastError:SYSTEMDLL**  
  
    For more information, see [/CLRSUPPORTLASTERROR (Preserve Last Error Code for PInvoke Calls)](https://msdn.microsoft.com/library/b7057990-4154-4b1d-9fc9-6236f7be7575).  
  
- **CLRThreadAttribute**  
  
   Optional **String** parameter.  
  
   Explicitly specifies the threading attribute for the entry point of your CLR program.  
  
   Specify one of the following values, each of which corresponds to a linker option.  
  
  - **DefaultThreadingAttribute** - **/CLRTHREADATTRIBUTE:NONE**  
  
  - **MTAThreadingAttribute** - **/CLRTHREADATTRIBUTE:MTA**  
  
  - **STAThreadingAttribute** - **/CLRTHREADATTRIBUTE:STA**  
  
    For more information, see [/CLRTHREADATTRIBUTE (Set CLR Thread Attribute)](https://msdn.microsoft.com/library/4907e9ef-5031-446c-aecf-0a0b32fae1e8).  
  
- **CLRUnmanagedCodeCheck**  
  
   Optional **Boolean** parameter.  
  
   Specifies whether the linker will apply **SuppressUnmanagedCodeSecurityAttribute** to linker-generated P/Invoke calls from managed code into native DLLs.  
  
   For more information, see [/CLRUNMANAGEDCODECHECK (Add SuppressUnmanagedCodeSecurityAttribute)](https://msdn.microsoft.com/library/73abc426-dab0-45e2-be85-0f9a14206cc2).  
  
- **CreateHotPatchableImage**  
  
   Optional **String** parameter.  
  
   Prepares an image for hot patching.  
  
   Specify one of the following values, which corresponds to a linker option.  
  
  - **Enabled** - **/FUNCTIONPADMIN**  
  
  - **X86Image** - **/FUNCTIONPADMIN:5**  
  
  - **X64Image** - **/FUNCTIONPADMIN:6**  
  
  - **ItaniumImage** - **/FUNCTIONPADMIN:16**  
  
    For more information, see [/FUNCTIONPADMIN (Create Hotpatchable Image)](https://msdn.microsoft.com/library/25b02c13-1add-4fbd-add9-fcb30eb2cae7).  
  
- **DataExecutionPrevention**  
  
   Optional **Boolean** parameter.  
  
   If `true`, indicates that an executable was tested to be compatible with the Windows Data Execution Prevention feature.  
  
   For more information, see [/NXCOMPAT (Compatible with Data Execution Prevention)](https://msdn.microsoft.com/library/5858e7ff-24d3-4ac3-9046-af2c9e220d9b).  
  
- **DelayLoadDLLs**  
  
   Optional **String[]** parameter.  
  
   This parameter causes *delayed loading* of DLLs. Specify the name of a DLL to delay load.  
  
   For more information, see [/DELAYLOAD (Delay Load Import)](https://msdn.microsoft.com/library/39ea0f1e-5c01-450f-9c75-2d9761ff9b28).  
  
- **DelaySign**  
  
   Optional **Boolean** parameter.  
  
   If `true`, partially signs an assembly. By default, the value is `false`.  
  
   For more information, see [/DELAYSIGN (Partially Sign an Assembly)](https://msdn.microsoft.com/library/15244d30-3ecb-492f-a408-ffe81f38de20).  
  
- **Driver**  
  
   Optional **String** parameter.  
  
   Specify this parameter to build a Windows NT kernel mode driver.  
  
   Specify one of the following values, each of which corresponds to a linker option.  
  
  - **NotSet** - *\<none>*  
  
  - **Driver** - **/Driver**  
  
  - **UpOnly** - **/DRIVER:UPONLY**  
  
  - **WDM** - **/DRIVER:WDM**  
  
    For more information, see [/DRIVER (Windows NT Kernel Mode Driver)](https://msdn.microsoft.com/library/aeee8e28-5d97-40f5-ba16-9f370fe8a1b8).  
  
- **EmbedManagedResourceFile**  
  
   Optional **String[]** parameter.  
  
   Embeds a resource file in an assembly. Specify the required resource file name. Optionally specify the logical name, which is used to load the resource, and the **PRIVATE** option, which indicates in the assembly manifest that the resource file is private.  
  
   For more information, see [/ASSEMBLYRESOURCE (Embed a Managed Resource)](https://msdn.microsoft.com/library/0ce6e1fb-921b-4b1b-a59c-d35388d789f2).  
  
- **EnableCOMDATFolding**  
  
   Optional **Boolean** parameter.  
  
   If `true`, enables identical COMDAT folding.  
  
   For more information, see the `ICF[= iterations]` argument of [/OPT (Optimizations)](https://msdn.microsoft.com/library/8f229863-5f53-48a8-9478-243a647093ac).  
  
- **EnableUAC**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies that User Account Control (UAC) information is embedded in the program manifest.  
  
   For more information, see [/MANIFESTUAC (Embeds UAC information in manifest)](https://msdn.microsoft.com/library/2d243c39-fa13-493c-b56f-d0d972a1603a).  
  
- **EntryPointSymbol**  
  
   Optional **String** parameter.  
  
   Specifies an entry point function as the starting address for an .exe file or DLL. Specify a function name as the parameter value.  
  
   For more information, see [/ENTRY (Entry-Point Symbol)](https://msdn.microsoft.com/library/26c62ba2-4f52-4882-a7bd-7046a0abf445).  
  
- **FixedBaseAddress**  
  
   Optional **Boolean** parameter.  
  
   If `true`, creates a program or DLL that can be loaded only at its preferred base address.  
  
   For more information, see [/FIXED (Fixed Base Address)](https://msdn.microsoft.com/library/929bba5e-b7d8-40ed-943e-056aa3710fc5).  
  
- **ForceFileOutput**  
  
   Optional **String** parameter.  
  
   Tells the linker to create a valid .exe file or DLL even if a symbol is referenced but not defined, or is multiply defined.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Enabled** - **/FORCE**  
  
  - **MultiplyDefinedSymbolOnly** - **/FORCE:MULTIPLE**  
  
  - **UndefinedSymbolOnly** - **/FORCE:UNRESOLVED**  
  
    For more information, see [/FORCE (Force File Output)](https://msdn.microsoft.com/library/b1e9a218-a5eb-4e60-a4a4-65b4be15e5da).  
  
- **ForceSymbolReferences**  
  
   Optional **String[]** parameter.  
  
   This parameter tells the linker to add a specified symbol to the symbol table.  
  
   For more information, see [/INCLUDE (Force Symbol References)](https://msdn.microsoft.com/library/4a039677-360a-480f-bd0b-448e239b449c).  
  
- **FunctionOrder**  
  
   Optional **String** parameter.  
  
   This parameter optimizes your program by placing the specified packaged functions (COMDATs) into the image in a predetermined order.  
  
   For more information, see [/ORDER (Put Functions in Order)](https://msdn.microsoft.com/library/ecf5eb3e-e404-4e86-9a91-4e5ec157261a).  
  
- **GenerateDebugInformation**  
  
   Optional **Boolean** parameter.  
  
   If `true`, creates debugging information for the .exe file or DLL.  
  
   For more information, see [/DEBUG (Generate Debug Info)](https://msdn.microsoft.com/library/1af389ae-3f8b-4d76-a087-1cdf861e9103).  
  
- **GenerateManifest**  
  
   Optional **Boolean** parameter.  
  
   If `true`, creates a side-by-side manifest file.  
  
   For more information, see [/MANIFEST (Create Side-by-Side Assembly Manifest)](https://msdn.microsoft.com/library/98c52e1e-712c-4f49-b149-4d0a3501b600).  
  
- **GenerateMapFile**  
  
   Optional **Boolean** parameter.  
  
   If `true`, creates a *map file*. The file name extension of the map file is .map.  
  
   For more information, see [/MAP (Generate Mapfile)](https://msdn.microsoft.com/library/9ccce53d-4e36-43da-87b0-7603ddfdea63).  
  
- **HeapCommitSize**  
  
   Optional **String** parameter.  
  
   Specifies the amount of physical memory on the heap to allocate at a time.  
  
   For more information, see the `commit` argument in [/HEAP (Set Heap Size)](https://msdn.microsoft.com/library/a3f71927-7f1d-492c-9fdb-dfccb1a043da). Also, see the **HeapReserveSize** parameter.  
  
- **HeapReserveSize**  
  
   Optional **String** parameter.  
  
   Specifies the total heap allocation in virtual memory.  
  
   For more information, see the `reserve` argument in [/HEAP (Set Heap Size)](https://msdn.microsoft.com/library/a3f71927-7f1d-492c-9fdb-dfccb1a043da). Also, see the **HeapCommitSize** parameter in this table.  
  
- **IgnoreAllDefaultLibraries**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the linker to remove one or more default libraries from the list of libraries it searches when it resolves external references.  
  
   For more information, see [/NODEFAULTLIB (Ignore Libraries)](https://msdn.microsoft.com/library/7270b673-6711-468e-97a7-c2925ac2be6e).  
  
- **IgnoreEmbeddedIDL**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies that any IDL attributes in source code should not be processed into an .idl file.  
  
   For more information, see [/IGNOREIDL (Don't Process Attributes into MIDL)](https://msdn.microsoft.com/library/29514098-6a1c-4317-af2f-1dc268972780).  
  
- **IgnoreImportLibrary**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies that the import library generated by this configuration should not be imported into dependent projects.  
  
   This parameter does not correspond to a linker option.  
  
- **IgnoreSpecificDefaultLibraries**  
  
   Optional **String[]** parameter.  
  
   Specifies one or more names of default libraries to ignore. Separate multiple libraries by using semi-colons.  
  
   For more information, see [/NODEFAULTLIB (Ignore Libraries)](https://msdn.microsoft.com/library/7270b673-6711-468e-97a7-c2925ac2be6e).  
  
- **ImageHasSafeExceptionHandlers**  
  
   Optional **Boolean** parameter.  
  
   If `true`, the linker produces an image only if it can also produce a table of the image's safe exception handlers.  
  
   For more information, see [/SAFESEH (Image has Safe Exception Handlers)](https://msdn.microsoft.com/library/7722ff99-b833-4c65-a855-aaca902ffcb7).  
  
- **ImportLibrary**  
  
   A user-specified import library name that replaces the default library name.  
  
   For more information, see [/IMPLIB (Name Import Library)](https://msdn.microsoft.com/library/fe8f71ab-7055-41b5-8ef8-2b97cfa4a432).  
  
- **KeyContainer**  
  
   Optional **String** parameter.  
  
   Container that contains the key for a signed assembly.  
  
   For more information, see [/KEYCONTAINER (Specify a Key Container to Sign an Assembly)](https://msdn.microsoft.com/library/94882d12-b77a-49c7-96d0-18a31aee001e). Also, see the **KeyFile** parameter in this table.  
  
- **KeyFile**  
  
   Optional **String** parameter.  
  
   Specifies a file that contains the key for a signed assembly.  
  
   For more information, see [/KEYFILE (Specify Key or Key Pair to Sign an Assembly)](https://msdn.microsoft.com/library/9b71f8c0-541c-4fe5-a0c7-9364f42ecb06). Also, see the **KeyContainer** parameter.  
  
- **LargeAddressAware**  
  
   Optional **Boolean** parameter.  
  
   If `true`, the application can handle addresses larger than 2 gigabytes.  
  
   For more information, see [/LARGEADDRESSAWARE (Handle Large Addresses)](https://msdn.microsoft.com/library/a29756c8-e893-47a9-9750-1f0d25359385).  
  
- **LinkDLL**  
  
   Optional **Boolean** parameter.  
  
   If `true`, builds a DLL as the main output file.  
  
   For more information, see [/DLL (Build a DLL)](https://msdn.microsoft.com/library/c7685aec-31d0-490f-9503-fb5171a23609).  
  
- **LinkErrorReporting**  
  
   Optional **String** parameter.  
  
   Lets you provide internal compiler error (ICE) information directly to Microsoft.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NoErrorReport** - **/ERRORREPORT:NONE**  
  
  - **PromptImmediately** - **/ERRORREPORT:PROMPT**  
  
  - **QueueForNextLogin** - **/ERRORREPORT:QUEUE**  
  
  - **SendErrorReport** - **/ERRORREPORT:SEND**  
  
    For more information, see [/ERRORREPORT (Report Internal Linker Errors)](https://msdn.microsoft.com/library/f5fab595-a2f1-4eb0-ab5c-1c0fbd3d8c28).  
  
- **LinkIncremental**  
  
   Optional **Boolean** parameter.  
  
   If `true`, enables incremental linking.  
  
   For more information, see [/INCREMENTAL (Link Incrementally)](https://msdn.microsoft.com/library/135656ff-94fa-4ad4-a613-22e1a2a5d16b).  
  
- **LinkLibraryDependencies**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies that library outputs from project dependencies are automatically linked in.  
  
   This parameter does not correspond to a linker option.  
  
- **LinkStatus**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies that the linker is to display a progress indicator that shows what percentage of the link is complete.  
  
   For more information, see the `STATUS` argument of [/LTCG (Link-time Code Generation)](https://msdn.microsoft.com/library/788c6f52-fdb8-40c2-90af-4026ea2cf2e2).  
  
- **LinkTimeCodeGeneration**  
  
   Optional **String** parameter.  
  
   Specifies options for profile-guided optimization.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **Default** - *\<none>*  
  
  - **UseLinkTimeCodeGeneration** - **/LTCG**  
  
  - **PGInstrument** - **/LTCG:PGInstrument**  
  
  - **PGOptimization** - **/LTCG:PGOptimize**  
  
  - **PGUpdate**  
  
     \- **/LTCG:PGUpdate**  
  
    For more information, see [/LTCG (Link-time Code Generation)](https://msdn.microsoft.com/library/788c6f52-fdb8-40c2-90af-4026ea2cf2e2).  
  
- **ManifestFile**  
  
   Optional **String** parameter.  
  
   Changes the default manifest file name to the specified file name.  
  
   For more information, see [/MANIFESTFILE (Name Manifest File)](https://msdn.microsoft.com/library/befa5ab2-a9cf-4c9b-969a-e7b4a930f08d).  
  
- **MapExports**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the linker to include exported functions in a map file.  
  
   For more information, see the `EXPORTS` argument of [/MAPINFO (Include Information in Mapfile)](https://msdn.microsoft.com/library/533d2bce-f9b7-4fea-ae1c-0b4864c9d10b).  
  
- **MapFileName**  
  
   Optional **String** parameter.  
  
   Changes the default map file name to the specified file name.  
  
- **MergedIDLBaseFileName**  
  
   Optional **String** parameter.  
  
   Specifies the file name and file name extension of the .idl file.  
  
   For more information, see [/IDLOUT (Name MIDL Output Files)](https://msdn.microsoft.com/library/10d00a6a-85b4-4de1-8732-e422c6931509).  
  
- **MergeSections**  
  
   Optional **String** parameter.  
  
   Combines sections in an image. Specify `from-section=to-section`.  
  
   For more information, see [/MERGE (Combine Sections)](https://msdn.microsoft.com/library/10fb20c2-0b3f-4c8d-98a8-f69aedf03d52).  
  
- **MidlCommandFile**  
  
   Optional **String** parameter.  
  
   Specify the name of a file that contains MIDL command-line options.  
  
   For more information, see [/MIDL (Specify MIDL Command Line Options)](https://msdn.microsoft.com/library/22dc259e-b34c-4ed3-a380-4beb734482c1).  
  
- **MinimumRequiredVersion**  
  
   Optional **String** parameter.  
  
   Specifies the minimum required version of the subsystem. The arguments are decimal numbers in the range 0 through 65535.  
  
- **ModuleDefinitionFile**  
  
   Optional **String** parameter.  
  
   Specifies the name of a [module definition file](https://msdn.microsoft.com/library/08c0bc28-c5d2-47aa-9624-7fc68bcaa4d8).  
  
   For more information, see [/DEF (Specify Module-Definition File)](https://msdn.microsoft.com/library/6497fa68-65f0-48ca-8f66-b87166fc631a).  
  
- **MSDOSStubFileName**  
  
   Optional **String** parameter.  
  
   Attaches the specified MS-DOS stub program to a Win32 program.  
  
   For more information, see [/STUB (MS-DOS Stub File Name)](https://msdn.microsoft.com/library/65221ffe-4f9a-4a14-ac69-3cfb79b40b5f).  
  
- **NoEntryPoint**  
  
   Optional **Boolean** parameter.  
  
   If `true`, specifies a resource-only DLL.  
  
   For more information, see [/NOENTRY (No Entry Point)](https://msdn.microsoft.com/library/0214dd41-35ad-43ab-b892-e636e038621a).  
  
- **ObjectFiles**  
  
   Implicit **String[]** parameter.  
  
   Specifies the object files that are linked.  
  
- **OptimizeReferences**  
  
   Optional **Boolean** parameter.  
  
   If `true`, eliminates functions and/or data that are never referenced.  
  
   For more information, see the `REF` argument in [/OPT (Optimizations)](https://msdn.microsoft.com/library/8f229863-5f53-48a8-9478-243a647093ac).  
  
- **OutputFile**  
  
   Optional **String** parameter.  
  
   Overrides the default name and location of the program that the linker creates.  
  
   For more information, see [/OUT (Output File Name)](https://msdn.microsoft.com/library/976210a4-e51f-4cfb-af5e-c16344455834).  
  
- **PerUserRedirection**  
  
   Optional **Boolean** parameter.  
  
   If `true` and Register Output is enabled, forces registry writes to **HKEY_CLASSES_ROOT** to be redirected to **HKEY_CURRENT_USER**.  
  
- **PreprocessOutput**  
  
   Optional `ITaskItem[]` parameter.  
  
   Defines an array of preprocessor output items that can be consumed and emitted by tasks.  
  
- **PreventDllBinding**  
  
   Optional **Boolean** parameter.  
  
   If `true`, indicates to Bind.exe that the linked image should not be bound.  
  
   For more information, see [/ALLOWBIND (Prevent DLL Binding)](https://msdn.microsoft.com/library/30e37e24-12e4-407e-988a-39d357403598).  
  
- **Profile**  
  
   Optional **Boolean** parameter.  
  
   If `true`, produces an output file that can be used with the **Performance Tools** profiler.  
  
   For more information, see [/PROFILE (Performance Tools Profiler)](https://msdn.microsoft.com/library/e676baa1-5063-47a3-a357-ba0d1f0d1699).  
  
- **ProfileGuidedDatabase**  
  
   Optional **String** parameter.  
  
   Specifies the name of the .pgd file that will be used to hold information about the running program  
  
   For more information, see [/PGD (Specify Database for Profile-Guided Optimizations)](https://msdn.microsoft.com/library/9f312498-493b-461f-886f-92652257e443).  
  
- **ProgramDatabaseFile**  
  
   Optional **String** parameter.  
  
   Specifies a name for the program database (PDB) that the linker creates.  
  
   For more information, see [/PDB (Use Program Database)](https://msdn.microsoft.com/library/d23db0ce-10cb-427a-bc60-d6b2a852723d).  
  
- **RandomizedBaseAddress**  
  
   Optional **Boolean** parameter.  
  
   If `true`, generates an executable image that can be randomly rebased at load time by using the *address space layout randomization* (ASLR) feature of Windows.  
  
   For more information, see [/DYNAMICBASE (Use address space layout randomization)](https://msdn.microsoft.com/library/6c0ced8e-fe9c-4b63-b956-eb8a55fbceb2).  
  
- **RegisterOutput**  
  
   Optional **Boolean** parameter.  
  
   If `true`, registers the primary output of this build.  
  
- **SectionAlignment**  
  
   Optional **Integer** parameter.  
  
   Specifies the alignment of each section within the linear address space of the program. The parameter value is a unit number of bytes and is a power of two.  
  
   For more information, see [/ALIGN (Section Alignment)](https://msdn.microsoft.com/library/f2f8ac24-e90e-4bea-8205-f2960a3b1740).  
  
- **SetChecksum**  
  
   Optional **Boolean** parameter.  
  
   If `true`, sets the checksum in the header of an .exe file.  
  
   For more information, see [/RELEASE (Set the Checksum)](https://msdn.microsoft.com/library/93bcadf4-29ac-4824-914b-6997e3751d22).  
  
- **ShowProgress**  
  
   Optional **String** parameter.  
  
   Specifies the verbosity of progress reports for the linking operation.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NotSet** - *\<none>*  
  
  - **LinkVerbose** - **/VERBOSE**  
  
  - **LinkVerboseLib** - **/VERBOSE:Lib**  
  
  - **LinkVerboseICF** - **/VERBOSE:ICF**  
  
  - **LinkVerboseREF** - **/VERBOSE:REF**  
  
  - **LinkVerboseSAFESEH** - **/VERBOSE:SAFESEH**  
  
  - **LinkVerboseCLR** - **/VERBOSE:CLR**  
  
    For more information, see [/VERBOSE (Print Progress Messages)](https://msdn.microsoft.com/library/9c347d98-4c37-4724-a39e-0983934693ab).  
  
- **Sources**  
  
   Required `ITaskItem[]` parameter.  
  
   Defines an array of MSBuild source file items that can be consumed and emitted by tasks.  
  
- **SpecifySectionAttributes**  
  
   Optional **String** parameter.  
  
   Specifies the attributes of a section. This overrides the attributes that were set when the .obj file for the section was compiled.  
  
   For more information, see [/SECTION (Specify Section Attributes)](https://msdn.microsoft.com/library/92b69d81-e421-462e-b46f-7d0dff9b9d16).  
  
- **StackCommitSize**  
  
   Optional **String** parameter.  
  
   Specifies the amount of physical memory in each allocation when additional memory is allocated.  
  
   For more information, see the `commit` argument of [/STACK (Stack Allocations)](https://msdn.microsoft.com/library/73283660-e4bd-47cc-b5ca-04c5d739034c).  
  
- **StackReserveSize**  
  
   Optional **String** parameter.  
  
   Specifies the total stack allocation size in virtual memory.  
  
   For more information, see the `reserve` argument of [/STACK (Stack Allocations)](https://msdn.microsoft.com/library/73283660-e4bd-47cc-b5ca-04c5d739034c).  
  
- **StripPrivateSymbols**  
  
   Optional **String** parameter.  
  
   Creates a second program database (PDB) file that omits symbols that you do not want to distribute to your customers. Specify the name of the second PDB file.  
  
   For more information, see [/PDBSTRIPPED (Strip Private Symbols)](https://msdn.microsoft.com/library/9b9e0070-6a13-4142-8180-19c003fbbd55).  
  
- **SubSystem**  
  
   Optional **String** parameter.  
  
   Specifies the environment for the executable.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NotSet** - *\<none>*  
  
  - **Console** - **/SUBSYSTEM:CONSOLE**  
  
  - **Windows** - **/SUBSYSTEM:WINDOWS**  
  
  - **Native** - **/SUBSYSTEM:NATIVE**  
  
  - **EFI Application** - **/SUBSYSTEM:EFI_APPLICATION**  
  
  - **EFI Boot Service Driver** - **/SUBSYSTEM:EFI_BOOT_SERVICE_DRIVER**  
  
  - **EFI ROM** - **/SUBSYSTEM:EFI_ROM**  
  
  - **EFI Runtime** - **/SUBSYSTEM:EFI_RUNTIME_DRIVER**  
  
  - **WindowsCE** - **/SUBSYSTEM:WINDOWSCE**  
  
  - **POSIX** - **/SUBSYSTEM:POSIX**  
  
    For more information, see [/SUBSYSTEM (Specify Subsystem)](https://msdn.microsoft.com/library/d7b133cf-cf22-4da8-ab46-6552702c0b9b).  
  
- **SupportNobindOfDelayLoadedDLL**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the linker not to include a bindable Import Address Table (IAT) in the final image.  
  
   For more information, see the `NOBIND` argument of [/DELAY (Delay Load Import Settings)](https://msdn.microsoft.com/library/9334b332-cc58-4dae-b10f-a4c75972d50c).  
  
- **SupportUnloadOfDelayLoadedDLL**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the delay-load helper function to support explicit unloading of the DLL.  
  
   For more information, see the `UNLOAD` argument of [/DELAY (Delay Load Import Settings)](https://msdn.microsoft.com/library/9334b332-cc58-4dae-b10f-a4c75972d50c).  
  
- **SuppressStartupBanner**  
  
   Optional **Boolean** parameter.  
  
   If `true`, prevents the display of the copyright and version number message when the task starts.  
  
   For more information, see [/NOLOGO (Suppress Startup Banner) (Linker)](https://msdn.microsoft.com/library/3b20dddd-eca6-4545-a331-9f70bf720197).  
  
- **SwapRunFromCD**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the operating system to first copy the linker output to a swap file, and then run the image from there.  
  
   For more information, see the `CD` argument of [/SWAPRUN (Load Linker Output to Swap File)](https://msdn.microsoft.com/library/4a1e7f46-4399-4161-8dfc-d6a71beaf683). Also, see the **SwapRunFromNET** parameter.  
  
- **SwapRunFromNET**  
  
   Optional **Boolean** parameter.  
  
   If `true`, tells the operating system to first copy the linker output to a swap file, and then run the image from there.  
  
   For more information, see the `NET` argument of [/SWAPRUN (Load Linker Output to Swap File)](https://msdn.microsoft.com/library/4a1e7f46-4399-4161-8dfc-d6a71beaf683). Also, see the **SwapRunFromCD** parameter in this table.  
  
- **TargetMachine**  
  
   Optional **String** parameter.  
  
   Specifies the target platform for the program or DLL.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **NotSet** - *\<none>*  
  
  - **MachineARM** - **/MACHINE:ARM**  
  
  - **MachineEBC** - **/MACHINE:EBC**  
  
  - **MachineIA64** - **/MACHINE:IA64**  
  
  - **MachineMIPS** - **/MACHINE:MIPS**  
  
  - **MachineMIPS16** - **/MACHINE:MIPS16**  
  
  - **MachineMIPSFPU** - **/MACHINE:MIPSFPU**  
  
  - **MachineMIPSFPU16** - **/MACHINE:MIPSFPU16**  
  
  - **MachineSH4** - **/MACHINE:SH4**  
  
  - **MachineTHUMB** - **/MACHINE:THUMB**  
  
  - **MachineX64** - **/MACHINE:X64**  
  
  - **MachineX86** - **/MACHINE:X86**  
  
    For more information, see [/MACHINE (Specify Target Platform)](https://msdn.microsoft.com/library/8d41bf4b-7e53-4ab9-9085-d852b08d31c2).  
  
- **TerminalServerAware**  
  
   Optional **Boolean** parameter.  
  
   If `true`, sets a flag in the IMAGE_OPTIONAL_HEADER DllCharacteristics field in the program image's optional header. When this flag is set, Terminal Server will not make certain changes to the application.  
  
   For more information, see [/TSAWARE (Create Terminal Server Aware Application)](https://msdn.microsoft.com/library/fe1c1846-de5b-4839-b562-93fbfe36cd29).  
  
- **TrackerLogDirectory**  
  
   Optional **String** parameter.  
  
   Specifies the directory of the tracker log.  
  
- **TreatLinkerWarningAsErrors**  
  
   Optional **Boolean** parameter.  
  
   If `true`, causes no output file to be generated if the linker generates a warning.  
  
   For more information, see [/WX (Treat Linker Warnings as Errors)](https://msdn.microsoft.com/library/e4ba97c7-93f7-43ae-a4bb-d866790926c9).  
  
- **TurnOffAssemblyGeneration**  
  
   Optional **Boolean** parameter.  
  
   If `true`, creates an image for the current output file without a .NET Framework assembly.  
  
   For more information, see [/NOASSEMBLY (Create a MSIL Module)](https://msdn.microsoft.com/library/3cea4e70-f451-4395-a626-1930b1b127fe).  
  
- **TypeLibraryFile**  
  
   Optional **String** parameter.  
  
   Specifies the file name and file name extension of the .tlb file. Specify a file name, or a path and file name.  
  
   For more information, see [/TLBOUT (Name .TLB File)](https://msdn.microsoft.com/library/0df6d078-2e48-46c9-a1a5-02674d85dce8).  
  
- **TypeLibraryResourceID**  
  
   Optional **Integer** parameter.  
  
   Designates a user-specified value for a linker-created type library. Specify a value from 1 through 65535.  
  
   For more information, see [/TLBID (Specify Resource ID for TypeLib)](https://msdn.microsoft.com/library/434b28a2-4656-4d52-ac82-8b18bf486fb2).  
  
- **UACExecutionLevel**  
  
   Optional **String** parameter.  
  
   Specifies the requested execution level for the application when it is run under with User Account Control.  
  
   Specify one of the following values, each of which corresponds to a command-line option.  
  
  - **AsInvoker** - `level='asInvoker'`  
  
  - **HighestAvailable** - `level='highestAvailable'`  
  
  - **RequireAdministrator** - `level='requireAdministrator'`  
  
    For more information, see the `level` argument of [/MANIFESTUAC (Embeds UAC information in manifest)](https://msdn.microsoft.com/library/2d243c39-fa13-493c-b56f-d0d972a1603a).  
  
- **UACUIAccess**  
  
   Optional **Boolean** parameter.  
  
   If `true`, the application bypasses user interface protection levels and drives input to higher-permission windows on the desktop; otherwise, `false`.  
  
   For more information, see the `uiAccess` argument of [/MANIFESTUAC (Embeds UAC information in manifest)](https://msdn.microsoft.com/library/2d243c39-fa13-493c-b56f-d0d972a1603a).  
  
- **UseLibraryDependencyInputs**  
  
   Optional **Boolean** parameter.  
  
   If `true`, the inputs to the librarian tool are used rather than the library file itself when library outputs of project dependencies are linked in.  
  
- **Version**  
  
   Optional **String** parameter.  
  
   Put a version number in the header of the .exe or .dll file. Specify "`major[.minor]`". The `major` and `minor` arguments are decimal numbers from 0 through 65535.  
  
   For more information, see [/VERSION (Version Information)](https://msdn.microsoft.com/library/b86d0e86-dca6-4316-aee2-d863ccb9f223).  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)
