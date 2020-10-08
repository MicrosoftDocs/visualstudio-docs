---
title: "MSBuild Task Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, tasks"
ms.assetid: b3144b27-a426-4259-b8ae-5f7991b202b6
caps.latest.revision: 35
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Task Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Tasks provide the code that runs during the build process. The tasks in the following list are included with [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)]. When [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] is installed, additional tasks are available that are used to build [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] projects. For more information, see [Visual C++ Tasks](../msbuild/msbuild-tasks-specific-to-visual-cpp.md).  
  
 In addition to the parameters listed in the topics in this section, each task also has the following parameters:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)], see [Conditions](../msbuild/msbuild-conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../msbuild/target-element-msbuild.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../msbuild/how-to-ignore-errors-in-tasks.md).|  
  
## In This Section  
 [Task Base Class](../msbuild/task-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Utilities.Task> class.  
  
 [TaskExtension Base Class](../msbuild/taskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.TaskExtension> class.  
  
 [ToolTaskExtension Base Class](../msbuild/tooltaskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class.  
  
 [AL (Assembly Linker) Task](../msbuild/al-assembly-linker-task.md)  
 Creates an assembly with a manifest from one or more files that are either modules or resource files.  
  
 [AspNetCompiler Task](../msbuild/aspnetcompiler-task.md)  
 Wraps aspnet_compiler.exe, a utility to precompile ASP.NET applications.  
  
 [AssignCulture Task](../msbuild/assignculture-task.md)  
 Assigns culture identifiers to items.  
  
 [AssignProjectConfiguration Task](../msbuild/assignprojectconfiguration-task.md)  
 Accepts a list of configuration strings and assigns them to specified projects.  
  
 [AssignTargetPath Task](../msbuild/assigntargetpath-task.md)  
 Accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.  
  
 [CallTarget Task](../msbuild/calltarget-task.md)  
 Invokes a target in the project file.  
  
 [CombinePath Task](../msbuild/combinepath-task.md)  
 Combines the specified paths into a single path.  
  
 [ConvertToAbsolutePath Task](../msbuild/converttoabsolutepath-task.md)  
 Converts a relative path or reference into an absolute path.  
  
 [Copy Task](../msbuild/copy-task.md)  
 Copies files to a new location.  
  
 [CreateCSharpManifestResourceName Task](../msbuild/createcsharpmanifestresourcename-task.md)  
 Creates a [!INCLUDE[csprcs](../includes/csprcs-md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [CreateItem Task](../msbuild/createitem-task.md)  
 Populates item collections from the input items, allowing items to be copied from one list to another.  
  
 [CreateProperty Task](../msbuild/createproperty-task.md)  
 Populates properties from the input values, allowing values to be copied from one property or string to another.  
  
 [CreateVisualBasicManifestResourceName Task](../msbuild/createvisualbasicmanifestresourcename-task.md)  
 Creates a [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [Csc Task](../msbuild/csc-task.md)  
 Invokes the Visual C# compiler to produce executables, dynamic-link libraries, or code modules.  
  
 [Delete Task](../msbuild/delete-task.md)  
 Deletes the specified files.  
  
 [Error Task](../msbuild/error-task.md)  
 Stops a build and logs an error based on an evaluated conditional statement.  
  
 [Exec Task](../msbuild/exec-task.md)  
 Runs the specified program or command with the specified arguments.  
  
 [FindAppConfigFile Task](../msbuild/findappconfigfile-task.md)  
 Finds the app.config file, if any, in the provided lists.  
  
 [FindInList Task](../msbuild/findinlist-task.md)  
 Finds an item in a specified list that has the matching itemspec.  
  
 [FindUnderPath Task](../msbuild/findunderpath-task.md)  
 Determines which items in the specified item collection exist in the specified folder and all of its subfolders.  
  
 [FormatUrl Task](../msbuild/formaturl-task.md)  
 Converts a URL to a correct URL format.  
  
 [FormatVersion Task](../msbuild/formatversion-task.md)  
 Appends the revision number to the version number.  
  
 [GenerateApplicationManifest Task](../msbuild/generateapplicationmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application manifest or a native manifest.  
  
 [GenerateBootstrapper Task](../msbuild/generatebootstrapper-task.md)  
 Provides an automated way to detect, download, and install an application and its prerequisites.  
  
 [GenerateDeploymentManifest Task](../msbuild/generatedeploymentmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment manifest.  
  
 [GenerateResource Task](../msbuild/generateresource-task.md)  
 Converts .txt and .resx files to common language runtime binary .resources files.  
  
 [GenerateTrustInfo Task](../msbuild/generatetrustinfo-task.md)  
 Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.  
  
 [GetAssemblyIdentity Task](../msbuild/getassemblyidentity-task.md)  
 Retrieves the assembly identities from the specified files and outputs the identity information.  
  
 [GetFrameworkPath Task](../msbuild/getframeworkpath-task.md)  
 Retrieves the path to the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] assemblies.  
  
 [GetFrameworkSdkPath Task](../msbuild/getframeworksdkpath-task.md)  
 Retrieves the path to the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)].  
  
 [GetReferenceAssemblyPaths Task](../msbuild/getreferenceassemblypaths-task.md)  
 Returns the reference assembly paths of the various frameworks.  
  
 [LC Task](../msbuild/lc-task.md)  
 Generates a .license file from a .licx file.  
  
 [MakeDir Task](../msbuild/makedir-task.md)  
 Creates directories and, if necessary, any parent directories.  
  
 [Message Task](../msbuild/message-task.md)  
 Logs a message during a build.  
  
 [Move Task](../msbuild/move-task.md)  
 Moves files to a new location.  
  
 [MSBuild Task](../msbuild/msbuild-task.md)  
 Builds [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] projects from another [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project.  
  
 [ReadLinesFromFile Task](../msbuild/readlinesfromfile-task.md)  
 Reads a list of items from a text file.  
  
 [RegisterAssembly Task](../msbuild/registerassembly-task.md)  
 Reads the metadata within the specified assembly and adds the necessary entries to the registry.  
  
 [RemoveDir Task](../msbuild/removedir-task.md)  
 Removes the specified directories and all of its files and subdirectories.  
  
 [RemoveDuplicates Task](../msbuild/removeduplicates-task.md)  
 Removes duplicate items from the specified item collection.  
  
 [RequiresFramework35SP1Assembly Task](../msbuild/requiresframework35sp1assembly-task.md)  
 Determines whether the application requires the .NET Framework 3.5 SP1.  
  
 ResGen Task  
 Obsolete. Use the [GenerateResource Task](../msbuild/generateresource-task.md) task to convert .txt and .resx files to and from common language runtime binary .resources files.  
  
 [ResolveAssemblyReference Task](../msbuild/resolveassemblyreference-task.md)  
 Determines all assemblies that depend on the specified assemblies.  
  
 [ResolveComReference Task](../msbuild/resolvecomreference-task.md)  
 Takes a list of one or more type library names or .tlb files and resolves those type libraries to locations on disk.  
  
 [ResolveKeySource Task](../msbuild/resolvekeysource-task.md)  
 Determines the strong name key source  
  
 [ResolveManifestFiles Task](../msbuild/resolvemanifestfiles-task.md)  
 Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
 [ResolveNativeReference Task](../msbuild/resolvenativereference-task.md)  
 Resolves native references.  
  
 [ResolveNonMSBuildProjectOutput Task](../msbuild/resolvenonmsbuildprojectoutput-task.md)  
 Determines the output files for non-MSBuild project references.  
  
 [SGen Task](../msbuild/sgen-task.md)  
 Creates an XML serialization assembly for types in the specified assembly.  
  
 [SignFile Task](../msbuild/signfile-task.md)  
 Signs the specified file using the specified certificate.  
  
 [Touch Task](../msbuild/touch-task.md)  
 Sets the access and modification times of files.  
  
 [UnregisterAssembly Task](../msbuild/unregisterassembly-task.md)  
 Unregisters the specified assemblies for COM interop purposes.  
  
 [UpdateManifest Task](../msbuild/updatemanifest-task.md)  
 Updates selected properties in a manifest and resigns.  
  
 [Vbc Task](../msbuild/vbc-task.md)  
 Invokes the Visual Basic compiler to produce executables, dynamic-link libraries, or code modules..  
  
 [Warning Task](../msbuild/warning-task.md)  
 Logs a warning during a build based on an evaluated conditional statement.  
  
 [WriteCodeFragment Task](../msbuild/writecodefragment-task.md)  
 Generates a temporary code file by using the specified generated code fragment. Does not delete the file.  
  
 [WriteLinesToFile Task](../msbuild/writelinestofile-task.md)  
 Writes the specified items to the specified text file.  
  
 [XmlPeek Task](../msbuild/xmlpeek-task.md)  
 Returns values as specified by XPath query from an XML file.  
  
 [XmlPoke Task](../msbuild/xmlpoke-task.md)  
 Sets values as specified by an XPath query into an XML file.  
  
 [XslTransformation Task](../msbuild/xsltransformation-task.md)  
 Transforms an XML input by using an *Extensible Stylesheet Language Transformation* (XSLT) or compiled XSLT and outputs to an output device or a file.  
  
## See Also  
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Task Writing](../msbuild/task-writing.md)   
 [Tasks](../msbuild/msbuild-tasks.md)
