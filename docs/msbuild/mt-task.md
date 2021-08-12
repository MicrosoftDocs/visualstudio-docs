---
title: MT Task | Microsoft Docs
description: Learn about the parameters and command-line options of the MSBuild MT task, which wraps the Microsoft Manifest Tool, mt.exe.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VC.Project.VCManifestTool.ResourceOutputFileName
- VC.Project.VCManifestTool.SuppressDependencyElement
- VC.Project.VCManifestTool.ManifestFromManagedAssembly
- VC.Project.VCManifestTool.GenerateCategoryTags
- VC.Project.VCManifestTool.EnableDPIAwareness
- vc.task.mt
dev_langs:
- VB
- CSharp
- C++
- jsharp
- C++
helpviewer_keywords:
- MSBUILD (C++), MT task
- MT task (MSBuild (C++))
ms.assetid: bb94913c-1042-4968-9f08-b394518e899f
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MT task

Wraps the Microsoft Manifest Tool, *mt.exe*. For more information, see [Mt.exe](/windows/desktop/SbsCs/mt-exe).

## Parameters

 The following table describes the parameters of the **MT** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.

> [!NOTE]
> The *mt.exe* documentation uses a hyphen (**-**) as the prefix for command-line options, but this topic uses a slash (**/**). Either prefix is acceptable.

|Parameter|Description|
|---------------|-----------------|
|**AdditionalManifestFiles**|Optional **String[]** parameter.<br /><br /> Specifies the name of one or more manifest files.<br /><br /> For more information, see the **/manifest** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of command-line options. For example, /\<option1> /\<option2> /\<option#>. Use this parameter to specify command-line options that are not represented by any other **MT** task parameter.<br /><br /> For more information, see [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**AssemblyIdentity**|Optional **String** parameter.<br /><br /> Specifies the attribute values of the **assemblyIdentity** element of the manifest. Specify a comma-delimited list, where the first component is the value of the `name` attribute, followed by one or more name/value pairs that have the form, *\<attribute name>=<attribute_value>*.<br /><br /> For more information, see the **/identity** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**ComponentFileName**|Optional **String** parameter.<br /><br /> Specifies the name of the dynamic-link library you intend to build from the *.rgs* or *.tlb* files. This parameter is required if you specify the **RegistrarScriptFile** or **TypeLibraryFile** MT task parameters.<br /><br /> For more information, see the **/dll** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**DependencyInformationFile**|Optional **String** parameter.<br /><br /> Specifies the dependency information file used by Visual Studio to track build dependency information for the manifest tool.|
|**EmbedManifest**|Optional `Boolean` parameter.<br /><br /> If `true`, embeds the manifest file in the assembly. If `false`, creates as a stand-alone manifest file.|
|**EnableDPIAwareness**|Optional `Boolean` parameter.<br /><br /> If `true`, adds to the manifest information that marks the application as DPI-aware. Writing a DPI-aware application makes a user interface look consistently good across a wide variety of high-DPI display settings.<br /><br /> For more information, see [High DPI](/windows/desktop/win7devguide/high-dpi).|
|**GenerateCatalogFiles**|Optional `Boolean` parameter.<br /><br /> If `true`, generates catalog definition (*.cdf*) files.<br /><br /> For more information, see the **/makecdfs** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**GenerateCategoryTags**|Optional `Boolean` parameter.<br /><br /> If `true`, causes category tags to be generated. If this parameter is `true`, the **ManifestFromManagedAssemblyMT** task parameter must also be specified.<br /><br /> For more information, see the **/category** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**InputResourceManifests**|Optional **String** parameter.<br /><br /> Input the manifest from a resource of type RT_MANIFEST that has the specified identifier. Specify a resource of the form, \<file>[;[#]\<resource_id>], where the optional \<resource_id> parameter is a non-negative, 16-bit number.<br /><br /> If no `resource_id` is specified, the CREATEPROCESS_MANIFEST_RESOURCE default value (1) is used.<br /><br /> For more information, see the **/inputresource** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**ManifestFromManagedAssembly**|Optional **String** parameter.<br /><br /> Generates a manifest from the specified managed assembly.<br /><br /> For more information, see the **/managedassemblyname** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**ManifestToIgnore**|Optional **String** parameter.<br /><br /> (Not used.)|
|**OutputManifestFile**|Optional **String** parameter.<br /><br /> Specifies the name of the output manifest. If this parameter is omitted and only one manifest is being operated on, that manifest is modified in place.<br /><br /> For more information, see the **/out** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**OutputResourceManifests**|Optional **String** parameter.<br /><br /> Output the manifest to a resource of type RT_MANIFEST that has the specified identifier. The resource is of the form, \<file>[;[#]\<resource_id>], where the optional \<resource_id> parameter is a non-negative, 16-bit number.<br /><br /> If no `resource_id` is specified, the CREATEPROCESS_MANIFEST_RESOURCE default value (1) is used.<br /><br /> For more information, see the **/outputresource** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**RegistrarScriptFile**|Optional **String** parameter.<br /><br /> Specifies the name of the registrar script (*.rgs*) file to use for registration-free COM manifest support.<br /><br /> For more information, see the **/rgs** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**ReplacementsFile**|Optional **String** parameter.<br /><br /> Specifies the file that contains values for the replaceable strings in the registrar script (*.rgs*) file.<br /><br /> For more information, see the **/replacements** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**ResourceOutputFileName**|Optional **String** parameter.<br /><br /> Specifies the output resources file used to embed the manifest into the project output.|
|**Sources**|Optional `ITaskItem[]` parameter.<br /><br /> Specifies a list of manifest source files separated by spaces.<br /><br /> For more information, see the **/manifest** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**SuppressDependencyElement**|Optional `Boolean` parameter.<br /><br /> If `true`, generates a manifest without dependency elements. If this parameter is `true`, also specify the **ManifestFromManagedAssemblyMT** task parameter.<br /><br /> For more information, see the **/nodependency** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**SuppressStartupBanner**|Optional `Boolean` parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, see the **/nologo** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**TrackerLogDirectory**|Optional `String` parameter.<br /><br /> Specifies the intermediate directory where tracking logs for this task are stored.|
|**TypeLibraryFile**|Optional **String** parameter.<br /><br /> Specifies the name of the type library (*.tlb*) file. If you specify this parameter, also specify the **ComponentFileNameMT** task parameter.<br /><br /> For more information, see the **/tlb** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|
|**UpdateFileHashes**|Optional `Boolean` parameter.<br /><br /> If `true`, computes the hash value of the files at the path specified by the **UpdateFileHashesSearchPathMT** task parameter, and then updates the value of the **hash** attribute of the **file** element of the manifest by using the computed value.<br /><br /> For more information, see the **/hashupdate** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe). Also see the **UpdateFileHashesSearchPath** parameter in this table.|
|**UpdateFileHashesSearchPath**|Optional `String` parameter.<br /><br /> Specifies the search path to use when the file hashes are updated. Use this parameter with the **UpdateFileHashesMT** task parameter.<br /><br /> For more information, see the **UpdateFileHashes** parameter in this table.|
|**VerboseOutput**|Optional `Boolean` parameter.<br /><br /> If `true`, displays verbose debugging information.<br /><br /> For more information, see the **/verbose** option in [Mt.exe](/windows/desktop/SbsCs/mt-exe).|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
