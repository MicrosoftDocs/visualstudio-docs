---
title: "MSBuild Task Reference"
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
ms.assetid: b3144b27-a426-4259-b8ae-5f7991b202b6
caps.latest.revision: 32
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
# MSBuild Task Reference
Tasks provide the code that runs during the build process. The tasks in the following list are included with MSBuild. When Visual C++ is installed, additional tasks are available that are used to build Visual C++ projects. For more information, see [Visual C++ Tasks](../VS_IDE/MSBuild-Tasks-Specific-to-Visual-C--.md).  
  
 In addition to the parameters listed in the topics in this section, each task also has the following parameters:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the MSBuild engine uses to determine whether this task will be executed. For information about the conditions that are supported by MSBuild, see [Conditions](../VS_IDE/MSBuild-Conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../VS_IDE/Target-Element--MSBuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../VS_IDE/How-to--Ignore-Errors-in-Tasks.md).|  
  
## In This Section  
 [Task Base Class](../VS_IDE/Task-Base-Class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class.  
  
 [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class.  
  
 [ToolTaskExtension Base Class](../VS_IDE/ToolTaskExtension-Base-Class.md)  
 Adds several parameters to the tasks that derive from the <xref:Microsoft.Build.Tasks.ToolTaskExtension?qualifyHint=False> class.  
  
 [AL (Assembly Linker) Task](../VS_IDE/AL--Assembly-Linker--Task.md)  
 Creates an assembly with a manifest from one or more files that are either modules or resource files.  
  
 [AspNetCompiler Task](../VS_IDE/AspNetCompiler-Task.md)  
 Wraps aspnet_compiler.exe, a utility to precompile ASP.NET applications.  
  
 [AssignCulture Task](../VS_IDE/AssignCulture-Task.md)  
 Assigns culture identifiers to items.  
  
 [AssignProjectConfiguration Task](../VS_IDE/AssignProjectConfiguration-Task.md)  
 Accepts a list of configuration strings and assigns them to specified projects.  
  
 [AssignTargetPath Task](../VS_IDE/AssignTargetPath-Task.md)  
 Accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.  
  
 [CallTarget Task](../VS_IDE/CallTarget-Task.md)  
 Invokes a target in the project file.  
  
 [CombinePath Task](../VS_IDE/CombinePath-Task.md)  
 Combines the specified paths into a single path.  
  
 [ConvertToAbsolutePath Task](../VS_IDE/ConvertToAbsolutePath-Task.md)  
 Converts a relative path or reference into an absolute path.  
  
 [Copy Task](../VS_IDE/Copy-Task.md)  
 Copies files to a new location.  
  
 [CreateCSharpManifestResourceName Task](../VS_IDE/CreateCSharpManifestResourceName-Task.md)  
 Creates a Visual C#-style manifest name from a given .resx file name or other resource.  
  
 [CreateItem Task](../VS_IDE/CreateItem-Task.md)  
 Populates item collections from the input items, allowing items to be copied from one list to another.  
  
 [CreateProperty Task](../VS_IDE/CreateProperty-Task.md)  
 Populates properties from the input values, allowing values to be copied from one property or string to another.  
  
 [CreateVisualBasicManifestResourceName Task](../VS_IDE/CreateVisualBasicManifestResourceName-Task.md)  
 Creates a Visual Basic-style manifest name from a given .resx file name or other resource.  
  
 [Csc Task](../VS_IDE/Csc-Task.md)  
 Invokes the Visual C# compiler to produce executables, dynamic-link libraries, or code modules.  
  
 [Delete Task](../VS_IDE/Delete-Task.md)  
 Deletes the specified files.  
  
 [Error Task](../VS_IDE/Error-Task.md)  
 Stops a build and logs an error based on an evaluated conditional statement.  
  
 [Exec Task](../VS_IDE/Exec-Task.md)  
 Runs the specified program or command with the specified arguments.  
  
 [FindAppConfigFile Task](../VS_IDE/FindAppConfigFile-Task.md)  
 Finds the app.config file, if any, in the provided lists.  
  
 [FindInList Task](../VS_IDE/FindInList-Task.md)  
 Finds an item in a specified list that has the matching itemspec.  
  
 [FindUnderPath Task](../VS_IDE/FindUnderPath-Task.md)  
 Determines which items in the specified item collection exist in the specified folder and all of its subfolders.  
  
 [FormatUrl Task](../VS_IDE/FormatUrl-Task.md)  
 Converts a URL to a correct URL format.  
  
 [FormatVersion Task](../VS_IDE/FormatVersion-Task.md)  
 Appends the revision number to the version number.  
  
 [GenerateApplicationManifest Task](../VS_IDE/GenerateApplicationManifest-Task.md)  
 Generates a ClickOnce application manifest or a native manifest.  
  
 [GenerateBootstrapper Task](../VS_IDE/GenerateBootstrapper-Task.md)  
 Provides an automated way to detect, download, and install an application and its prerequisites.  
  
 [GenerateDeploymentManifest Task](../VS_IDE/GenerateDeploymentManifest-Task.md)  
 Generates a ClickOnce deployment manifest.  
  
 [GenerateResource Task](../VS_IDE/GenerateResource-Task.md)  
 Converts .txt and .resx files to common language runtime binary .resources files.  
  
 [GenerateTrustInfo Task](../VS_IDE/GenerateTrustInfo-Task.md)  
 Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.  
  
 [GetAssemblyIdentity Task](../VS_IDE/GetAssemblyIdentity-Task.md)  
 Retrieves the assembly identities from the specified files and outputs the identity information.  
  
 [GetFrameworkPath Task](../VS_IDE/GetFrameworkPath-Task.md)  
 Retrieves the path to the .NET Framework assemblies.  
  
 [GetFrameworkSdkPath Task](../VS_IDE/GetFrameworkSdkPath-Task.md)  
 Retrieves the path to the Windows Software Development Kit (SDK).  
  
 [GetReferenceAssemblyPaths Task](../VS_IDE/GetReferenceAssemblyPaths-Task.md)  
 Returns the reference assembly paths of the various frameworks.  
  
 [LC Task](../VS_IDE/LC-Task.md)  
 Generates a .license file from a .licx file.  
  
 [MakeDir Task](../VS_IDE/MakeDir-Task.md)  
 Creates directories and, if necessary, any parent directories.  
  
 [Message Task](../VS_IDE/Message-Task.md)  
 Logs a message during a build.  
  
 [Move Task](../VS_IDE/Move-Task.md)  
 Moves files to a new location.  
  
 [MSBuild Task](../VS_IDE/MSBuild-Task.md)  
 Builds MSBuild projects from another MSBuild project.  
  
 [ReadLinesFromFile Task](../VS_IDE/ReadLinesFromFile-Task.md)  
 Reads a list of items from a text file.  
  
 [RegisterAssembly Task](../VS_IDE/RegisterAssembly-Task.md)  
 Reads the metadata within the specified assembly and adds the necessary entries to the registry.  
  
 [RemoveDir Task](../VS_IDE/RemoveDir-Task.md)  
 Removes the specified directories and all of its files and subdirectories.  
  
 [RemoveDuplicates Task](../VS_IDE/RemoveDuplicates-Task.md)  
 Removes duplicate items from the specified item collection.  
  
 [RequiresFramework35SP1Assembly Task](../VS_IDE/RequiresFramework35SP1Assembly-Task.md)  
 Determines whether the application requires the .NET Framework 3.5 SP1.  
  
 ResGen Task  
 Obsolete. Use the [GenerateResource Task](../VS_IDE/GenerateResource-Task.md) task to convert .txt and .resx files to and from common language runtime binary .resources files.  
  
 [ResolveAssemblyReference Task](../VS_IDE/ResolveAssemblyReference-Task.md)  
 Determines all assemblies that depend on the specified assemblies.  
  
 [ResolveComReference Task](../VS_IDE/ResolveComReference-Task.md)  
 Takes a list of one or more type library names or .tlb files and resolves those type libraries to locations on disk.  
  
 [ResolveKeySource Task](../VS_IDE/ResolveKeySource-Task.md)  
 Determines the strong name key source  
  
 [ResolveManifestFiles Task](../VS_IDE/ResolveManifestFiles-Task.md)  
 Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
 [ResolveNativeReference Task](../VS_IDE/ResolveNativeReference-Task.md)  
 Resolves native references.  
  
 [ResolveNonMSBuildProjectOutput Task](../VS_IDE/ResolveNonMSBuildProjectOutput-Task.md)  
 Determines the output files for non-MSBuild project references.  
  
 [SGen Task](../VS_IDE/SGen-Task.md)  
 Creates an XML serialization assembly for types in the specified assembly.  
  
 [SignFile Task](../VS_IDE/SignFile-Task.md)  
 Signs the specified file using the specified certificate.  
  
 [Touch Task](../VS_IDE/Touch-Task.md)  
 Sets the access and modification times of files.  
  
 [UnregisterAssembly Task](../VS_IDE/UnregisterAssembly-Task.md)  
 Unregisters the specified assemblies for COM interop purposes.  
  
 [UpdateManifest Task](../VS_IDE/UpdateManifest-Task.md)  
 Updates selected properties in a manifest and resigns.  
  
 [Vbc Task](../VS_IDE/Vbc-Task.md)  
 Invokes the Visual Basic compiler to produce executables, dynamic-link libraries, or code modules..  
  
 [Warning Task](../VS_IDE/Warning-Task.md)  
 Logs a warning during a build based on an evaluated conditional statement.  
  
 [WriteCodeFragment Task](../VS_IDE/WriteCodeFragment-Task.md)  
 Generates a temporary code file by using the specified generated code fragment. Does not delete the file.  
  
 [WriteLinesToFile Task](../VS_IDE/WriteLinesToFile-Task.md)  
 Writes the specified items to the specified text file.  
  
 [XmlPeek Task](../VS_IDE/XmlPeek-Task.md)  
 Returns values as specified by XPath query from an XML file.  
  
 [XmlPoke Task](../VS_IDE/XmlPoke-Task.md)  
 Sets values as specified by an XPath query into an XML file.  
  
 [XslTransformation Task](../VS_IDE/XslTransformation-Task.md)  
 Transforms an XML input by using an *Extensible Stylesheet Language Transformation* (XSLT) or compiled XSLT and outputs to an output device or a file.  
  
## See Also  
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)   
 [Task Writing](../VS_IDE/Task-Writing.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)