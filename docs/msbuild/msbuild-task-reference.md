---
title: "MSBuild Task Reference | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, tasks"
ms.assetid: b3144b27-a426-4259-b8ae-5f7991b202b6
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# MSBuild task reference

Tasks provide the code that runs during the build process. The tasks in the following list are included with [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. When [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] is installed, additional tasks are available that are used to build [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] projects. For more information, see [C++ tasks](../msbuild/msbuild-tasks-specific-to-visual-cpp.md).

In addition to the parameters listed in the topics in this section, each task also has the following parameters:

| Parameter | Description |
|-------------------| - |
| `Condition` | Optional `String` parameter.<br /><br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)], see [Conditions](../msbuild/msbuild-conditions.md). |
| `ContinueOnError` | Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../msbuild/target-element-msbuild.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore errors in tasks](../msbuild/how-to-ignore-errors-in-tasks.md). |

## In this section

- [Task base class](../msbuild/task-base-class.md)

 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Utilities.Task> class.

- [TaskExtension base class](../msbuild/taskextension-base-class.md)

 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.TaskExtension> class.

- [ToolTaskExtension base class](../msbuild/tooltaskextension-base-class.md)

 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class.

- [AL (Assembly Linker) task](../msbuild/al-assembly-linker-task.md)

 Creates an assembly with a manifest from one or more files that are either modules or resource files.

- [AspNetCompiler task](../msbuild/aspnetcompiler-task.md)

 Wraps *aspnet_compiler.exe*, a utility to precompile ASP.NET applications.

- [AssignCulture task](../msbuild/assignculture-task.md)

 Assigns culture identifiers to items.

- [AssignProjectConfiguration task](../msbuild/assignprojectconfiguration-task.md)

 Accepts a list of configuration strings and assigns them to specified projects.

- [AssignTargetPath task](../msbuild/assigntargetpath-task.md)

 Accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.

- [CallTarget task](../msbuild/calltarget-task.md)

 Invokes a target in the project file.

- [CombinePath task](../msbuild/combinepath-task.md)

 Combines the specified paths into a single path.

- [ConvertToAbsolutePath task](../msbuild/converttoabsolutepath-task.md)

 Converts a relative path or reference into an absolute path.

- [Copy task](../msbuild/copy-task.md)

 Copies files to a new location.

- [CreateCSharpManifestResourceName task](../msbuild/createcsharpmanifestresourcename-task.md)

 Creates a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)]-style manifest name from a given *.resx* file name or other resource.

- [CreateItem task](../msbuild/createitem-task.md)

 Populates item collections from the input items, allowing items to be copied from one list to another.

- [CreateProperty task](../msbuild/createproperty-task.md)

 Populates properties from the input values, allowing values to be copied from one property or string to another.

- [CreateVisualBasicManifestResourceName task](../msbuild/createvisualbasicmanifestresourcename-task.md)

 Creates a [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]-style manifest name from a given *.resx* file name or other resource.

- [Csc task](../msbuild/csc-task.md)

 Invokes the Visual C# compiler to produce executables, dynamic-link libraries, or code modules.

- [Delete task](../msbuild/delete-task.md)

 Deletes the specified files.

- [DownloadFile task](../msbuild/downloadfile-task.md)

 Downloads a file to the specified location.

- [Error task](../msbuild/error-task.md)

 Stops a build and logs an error based on an evaluated conditional statement.

- [Exec task](../msbuild/exec-task.md)

 Runs the specified program or command with the specified arguments.

- [FindAppConfigFile task](../msbuild/findappconfigfile-task.md)

 Finds the *app.config* file, if any, in the provided lists.

- [FindInList task](../msbuild/findinlist-task.md)

 Finds an item in a specified list that has the matching itemspec.

- [FindUnderPath task](../msbuild/findunderpath-task.md)

 Determines which items in the specified item collection exist in the specified folder and all of its subfolders.

- [FormatUrl task](../msbuild/formaturl-task.md)

 Converts a URL to a correct URL format.

- [FormatVersion task](../msbuild/formatversion-task.md)

 Appends the revision number to the version number.

- [GenerateApplicationManifest task](../msbuild/generateapplicationmanifest-task.md)

 Generates a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest or a native manifest.

- [GenerateBootstrapper task](../msbuild/generatebootstrapper-task.md)

 Provides an automated way to detect, download, and install an application and its prerequisites.

- [GenerateDeploymentManifest task](../msbuild/generatedeploymentmanifest-task.md)

 Generates a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest.

- [GenerateResource task](../msbuild/generateresource-task.md)

 Converts *.txt* and *.resx* files to common language runtime binary *.resources* files.

- [GenerateTrustInfo task](../msbuild/generatetrustinfo-task.md)

 Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.

- [GetAssemblyIdentity task](../msbuild/getassemblyidentity-task.md)

 Retrieves the assembly identities from the specified files and outputs the identity information.

- [GetFileHash task](../msbuild/getfilehash-task.md)

 Computes checksums of the contents of a file or set of files.

- [GetFrameworkPath task](../msbuild/getframeworkpath-task.md)

 Retrieves the path to the .NET Framework assemblies.

- [GetFrameworkSdkPath task](../msbuild/getframeworksdkpath-task.md)

 Retrieves the path to the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)].

- [GetReferenceAssemblyPaths task](../msbuild/getreferenceassemblypaths-task.md)

 Returns the reference assembly paths of the various frameworks.

- [LC task](../msbuild/lc-task.md)

 Generates a *.license* file from a *.licx* file.

- [MakeDir task](../msbuild/makedir-task.md)

 Creates directories and, if necessary, any parent directories.

- [Message task](../msbuild/message-task.md)

 Logs a message during a build.

- [Move task](../msbuild/move-task.md)

 Moves files to a new location.

- [MSBuild task](../msbuild/msbuild-task.md)

 Builds [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] projects from another [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project.

- [ReadLinesFromFile task](../msbuild/readlinesfromfile-task.md)

 Reads a list of items from a text file.

- [RegisterAssembly task](../msbuild/registerassembly-task.md)

 Reads the metadata within the specified assembly and adds the necessary entries to the registry.

- [RemoveDir task](../msbuild/removedir-task.md)

 Removes the specified directories and all of its files and subdirectories.

- [RemoveDuplicates task](../msbuild/removeduplicates-task.md)

 Removes duplicate items from the specified item collection.

- [RequiresFramework35SP1Assembly task](../msbuild/requiresframework35sp1assembly-task.md)

 Determines whether the application requires the .NET Framework 3.5 SP1.

- ResGen Task

 Obsolete. Use the [GenerateResource task](../msbuild/generateresource-task.md) task to convert *.txt* and *.resx* files to and from common language runtime binary *.resources* files.

- [ResolveAssemblyReference task](../msbuild/resolveassemblyreference-task.md)

 Determines all assemblies that depend on the specified assemblies.

- [ResolveComReference task](../msbuild/resolvecomreference-task.md)

 Takes a list of one or more type library names or *.tlb* files and resolves those type libraries to locations on disk.

- [ResolveKeySource task](../msbuild/resolvekeysource-task.md)

 Determines the strong name key source

- [ResolveManifestFiles task](../msbuild/resolvemanifestfiles-task.md)

 Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.

- [ResolveNativeReference task](../msbuild/resolvenativereference-task.md)

 Resolves native references.

- [ResolveNonMSBuildProjectOutput task](../msbuild/resolvenonmsbuildprojectoutput-task.md)

 Determines the output files for non-MSBuild project references.

- [SGen task](../msbuild/sgen-task.md)

 Creates an XML serialization assembly for types in the specified assembly.

- [SignFile task](../msbuild/signfile-task.md)

 Signs the specified file using the specified certificate.

- [Touch task](../msbuild/touch-task.md)

 Sets the access and modification times of files.

- [UnregisterAssembly task](../msbuild/unregisterassembly-task.md)

 Unregisters the specified assemblies for COM interop purposes.

- [Unzip task](../msbuild/unzip-task.md)

 Unzips a *.zip* archive to the specified location.

- [UpdateManifest task](../msbuild/updatemanifest-task.md)

 Updates selected properties in a manifest and resigns.

- [Vbc task](../msbuild/vbc-task.md)

 Invokes the Visual Basic compiler to produce executables, dynamic-link libraries, or code modules..

- [VerifyFileHash task](../msbuild/verifyfilehash-task.md)

 Verifies that a file matches the expected file hash.

- [Warning task](../msbuild/warning-task.md)

 Logs a warning during a build based on an evaluated conditional statement.

- [WriteCodeFragment task](../msbuild/writecodefragment-task.md)

 Generates a temporary code file by using the specified generated code fragment. Does not delete the file.

- [WriteLinesToFile task](../msbuild/writelinestofile-task.md)

 Writes the specified items to the specified text file.

- [XmlPeek task](../msbuild/xmlpeek-task.md)

 Returns values as specified by XPath query from an XML file.

- [XmlPoke task](../msbuild/xmlpoke-task.md)

 Sets values as specified by an XPath query into an XML file.

- [XslTransformation task](../msbuild/xsltransformation-task.md)

 Transforms an XML input by using an *Extensible Stylesheet Language Transformation* (XSLT) or compiled XSLT and outputs to an output device or a file.

- [ZipDirectory task](../msbuild/zipdirectory-task.md)

 Creates a *.zip* archive from the contents of a directory.

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Task writing](../msbuild/task-writing.md)
- [Tasks](../msbuild/msbuild-tasks.md)