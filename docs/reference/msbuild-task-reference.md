---
title: "MSBuild Task Reference"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, tasks"
ms.assetid: b3144b27-a426-4259-b8ae-5f7991b202b6
caps.latest.revision: 32
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
# MSBuild Task Reference
Tasks provide the code that runs during the build process. The tasks in the following list are included with [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)]. When [!INCLUDE[vcprvc](../codequality/includes/vcprvc_md.md)] is installed, additional tasks are available that are used to build [!INCLUDE[vcprvc](../codequality/includes/vcprvc_md.md)] projects. For more information, see [Visual C++ Tasks](../reference/msbuild-tasks-specific-to-visual-c--.md).  
  
 In addition to the parameters listed in the topics in this section, each task also has the following parameters:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)], see [Conditions](../reference/msbuild-conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../reference/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../reference/how-to--ignore-errors-in-tasks.md).|  
  
## In This Section  
 [Task Base Class](../reference/task-base-class.md)  
 Adds several parameters to the tasks that derive from the \<xref:Microsoft.Build.Utilities.Task> class.  
  
 [TaskExtension Base Class](../reference/taskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the \<xref:Microsoft.Build.Tasks.TaskExtension> class.  
  
 [ToolTaskExtension Base Class](../reference/tooltaskextension-base-class.md)  
 Adds several parameters to the tasks that derive from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension> class.  
  
 [AL (Assembly Linker) Task](../reference/al--assembly-linker--task.md)  
 Creates an assembly with a manifest from one or more files that are either modules or resource files.  
  
 [AspNetCompiler Task](../reference/aspnetcompiler-task.md)  
 Wraps aspnet_compiler.exe, a utility to precompile ASP.NET applications.  
  
 [AssignCulture Task](../reference/assignculture-task.md)  
 Assigns culture identifiers to items.  
  
 [AssignProjectConfiguration Task](../reference/assignprojectconfiguration-task.md)  
 Accepts a list of configuration strings and assigns them to specified projects.  
  
 [AssignTargetPath Task](../reference/assigntargetpath-task.md)  
 Accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.  
  
 [CallTarget Task](../reference/calltarget-task.md)  
 Invokes a target in the project file.  
  
 [CombinePath Task](../reference/combinepath-task.md)  
 Combines the specified paths into a single path.  
  
 [ConvertToAbsolutePath Task](../reference/converttoabsolutepath-task.md)  
 Converts a relative path or reference into an absolute path.  
  
 [Copy Task](../reference/copy-task.md)  
 Copies files to a new location.  
  
 [CreateCSharpManifestResourceName Task](../reference/createcsharpmanifestresourcename-task.md)  
 Creates a [!INCLUDE[csprcs](../datatools/includes/csprcs_md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [CreateItem Task](../reference/createitem-task.md)  
 Populates item collections from the input items, allowing items to be copied from one list to another.  
  
 [CreateProperty Task](../reference/createproperty-task.md)  
 Populates properties from the input values, allowing values to be copied from one property or string to another.  
  
 [CreateVisualBasicManifestResourceName Task](../reference/createvisualbasicmanifestresourcename-task.md)  
 Creates a [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)]-style manifest name from a given .resx file name or other resource.  
  
 [Csc Task](../reference/csc-task.md)  
 Invokes the Visual C# compiler to produce executables, dynamic-link libraries, or code modules.  
  
 [Delete Task](../reference/delete-task.md)  
 Deletes the specified files.  
  
 [Error Task](../reference/error-task.md)  
 Stops a build and logs an error based on an evaluated conditional statement.  
  
 [Exec Task](../reference/exec-task.md)  
 Runs the specified program or command with the specified arguments.  
  
 [FindAppConfigFile Task](../reference/findappconfigfile-task.md)  
 Finds the app.config file, if any, in the provided lists.  
  
 [FindInList Task](../reference/findinlist-task.md)  
 Finds an item in a specified list that has the matching itemspec.  
  
 [FindUnderPath Task](../reference/findunderpath-task.md)  
 Determines which items in the specified item collection exist in the specified folder and all of its subfolders.  
  
 [FormatUrl Task](../reference/formaturl-task.md)  
 Converts a URL to a correct URL format.  
  
 [FormatVersion Task](../reference/formatversion-task.md)  
 Appends the revision number to the version number.  
  
 [GenerateApplicationManifest Task](../reference/generateapplicationmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest or a native manifest.  
  
 [GenerateBootstrapper Task](../reference/generatebootstrapper-task.md)  
 Provides an automated way to detect, download, and install an application and its prerequisites.  
  
 [GenerateDeploymentManifest Task](../reference/generatedeploymentmanifest-task.md)  
 Generates a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest.  
  
 [GenerateResource Task](../reference/generateresource-task.md)  
 Converts .txt and .resx files to common language runtime binary .resources files.  
  
 [GenerateTrustInfo Task](../reference/generatetrustinfo-task.md)  
 Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.  
  
 [GetAssemblyIdentity Task](../reference/getassemblyidentity-task.md)  
 Retrieves the assembly identities from the specified files and outputs the identity information.  
  
 [GetFrameworkPath Task](../reference/getframeworkpath-task.md)  
 Retrieves the path to the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] assemblies.  
  
 [GetFrameworkSdkPath Task](../reference/getframeworksdkpath-task.md)  
 Retrieves the path to the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)].  
  
 [GetReferenceAssemblyPaths Task](../reference/getreferenceassemblypaths-task.md)  
 Returns the reference assembly paths of the various frameworks.  
  
 [LC Task](../reference/lc-task.md)  
 Generates a .license file from a .licx file.  
  
 [MakeDir Task](../reference/makedir-task.md)  
 Creates directories and, if necessary, any parent directories.  
  
 [Message Task](../reference/message-task.md)  
 Logs a message during a build.  
  
 [Move Task](../reference/move-task.md)  
 Moves files to a new location.  
  
 [MSBuild Task](../reference/msbuild-task.md)  
 Builds [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] projects from another [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project.  
  
 [ReadLinesFromFile Task](../reference/readlinesfromfile-task.md)  
 Reads a list of items from a text file.  
  
 [RegisterAssembly Task](../reference/registerassembly-task.md)  
 Reads the metadata within the specified assembly and adds the necessary entries to the registry.  
  
 [RemoveDir Task](../reference/removedir-task.md)  
 Removes the specified directories and all of its files and subdirectories.  
  
 [RemoveDuplicates Task](../reference/removeduplicates-task.md)  
 Removes duplicate items from the specified item collection.  
  
 [RequiresFramework35SP1Assembly Task](../reference/requiresframework35sp1assembly-task.md)  
 Determines whether the application requires the .NET Framework 3.5 SP1.  
  
 ResGen Task  
 Obsolete. Use the [GenerateResource Task](../reference/generateresource-task.md) task to convert .txt and .resx files to and from common language runtime binary .resources files.  
  
 [ResolveAssemblyReference Task](../reference/resolveassemblyreference-task.md)  
 Determines all assemblies that depend on the specified assemblies.  
  
 [ResolveComReference Task](../reference/resolvecomreference-task.md)  
 Takes a list of one or more type library names or .tlb files and resolves those type libraries to locations on disk.  
  
 [ResolveKeySource Task](../reference/resolvekeysource-task.md)  
 Determines the strong name key source  
  
 [ResolveManifestFiles Task](../reference/resolvemanifestfiles-task.md)  
 Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
 [ResolveNativeReference Task](../reference/resolvenativereference-task.md)  
 Resolves native references.  
  
 [ResolveNonMSBuildProjectOutput Task](../reference/resolvenonmsbuildprojectoutput-task.md)  
 Determines the output files for non-MSBuild project references.  
  
 [SGen Task](../reference/sgen-task.md)  
 Creates an XML serialization assembly for types in the specified assembly.  
  
 [SignFile Task](../reference/signfile-task.md)  
 Signs the specified file using the specified certificate.  
  
 [Touch Task](../reference/touch-task.md)  
 Sets the access and modification times of files.  
  
 [UnregisterAssembly Task](../reference/unregisterassembly-task.md)  
 Unregisters the specified assemblies for COM interop purposes.  
  
 [UpdateManifest Task](../reference/updatemanifest-task.md)  
 Updates selected properties in a manifest and resigns.  
  
 [Vbc Task](../reference/vbc-task.md)  
 Invokes the Visual Basic compiler to produce executables, dynamic-link libraries, or code modules..  
  
 [Warning Task](../reference/warning-task.md)  
 Logs a warning during a build based on an evaluated conditional statement.  
  
 [WriteCodeFragment Task](../reference/writecodefragment-task.md)  
 Generates a temporary code file by using the specified generated code fragment. Does not delete the file.  
  
 [WriteLinesToFile Task](../reference/writelinestofile-task.md)  
 Writes the specified items to the specified text file.  
  
 [XmlPeek Task](../reference/xmlpeek-task.md)  
 Returns values as specified by XPath query from an XML file.  
  
 [XmlPoke Task](../reference/xmlpoke-task.md)  
 Sets values as specified by an XPath query into an XML file.  
  
 [XslTransformation Task](../reference/xsltransformation-task.md)  
 Transforms an XML input by using an *Extensible Stylesheet Language Transformation* (XSLT) or compiled XSLT and outputs to an output device or a file.  
  
## See Also  
 [MSBuild Reference](../reference/msbuild-reference.md)   
 [Task Writing](../reference/task-writing.md)   
 [Tasks](../reference/msbuild-tasks.md)