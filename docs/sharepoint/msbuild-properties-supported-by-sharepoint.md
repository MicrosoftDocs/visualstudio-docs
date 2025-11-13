---
title: "MSBuild Properties Supported by SharePoint"
description: Read a list of MSBuild property names and descriptions that are supported by and are specific to SharePoint.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, MSBuild properties"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# MsBuild properties supported by SharePoint

  Any MSBuild property defined in the Microsoft.VisualStudio.SharePoint.targets file, project file, or project user file can be used in Visual Studio SharePoint projects. In addition to the common MSBuild properties supplied by the project, SharePoint defines additional properties that are specific to SharePoint projects.

 For a list of common MSBuild properties, see [Common MSBuild Project Properties](/previous-versions/dotnet/netframework-4.0/bb629394(v=vs.100)). For a full list of the properties supported by your programming language, look in the *.targets* file, the project file (*.csproj* or *.vbproj*), or the project user file (*csproj.user* or *.vbproj.user*).

## MsBuild properties specific to SharePoint
 The following table lists MSBuild properties that apply specifically to SharePoint projects in Visual Studio. Other properties exist, but they are for internal use.

|Property Name|Description|
|-------------------|-----------------|
|SharePointSiteUrl|A string that represents the URL to the SharePoint site.|
|SandboxedSolution|A Boolean value that indicates whether the solution is a sandboxed solution.|
|ActiveDeploymentConfiguration|The active deployment configuration.|
|IncludeAssemblyInPackage|A Boolean value that indicates whether the assembly is included in the package file.|
|PreDeploymentCommand|A string value that represents the command to execute in the pre-deployment command step.|
|PostDeploymentCommand|A string value that represents the command to execute in the post-deployment command step.|
|CustomBeforeSharePointTargets|A string that represents the path of a MSBuild targets file. If the targets file exists and is defined, it is imported before any SharePoint targets data. This property lets you customize the package process by predefining packaging-related properties without modifying the shipped SharePoint targets file, yet the targets file still applies to all SharePoint projects.|
|CustomAfterSharePointTargets|A string that represents the path of a MSBuild targets file. If the targets file exists and is defined, it is imported after all of the SharePoint targets data. This property lets you customize the package process by overriding packaging-related properties and targets without having to modify the shipped SharePoint targets file, yet the targets file still applies to all SharePoint projects.|
|LayoutPath|A string that represents the root directory where each of the files to be packaged are temporarily placed before they are added to the *.wsp* file. This path can be useful to know when you override the BeforeLayout and AfterLayout targets to add, remove, or modify files to be packaged, because you can use it to alter the contents of the *.wsp* file.|
|BasePackagePath|A string that represents the folder in which the package is placed. This value uses the output directory of the project, such as Bin\Debug.|
|PackageExtension|A string that represents the file name extension to append to the package. The default value is wsp.|
|AssemblyDeploymentTarget|A string that represents the location where the project assembly is deployed on the SharePoint server. Its value is either GlobalAssemblyCache (the default) or WebApplication. This property can also be set in the Properties window.|
|PackageWithValidation|A Boolean value that specifies whether validation is performed before packaging. This property lets you ignore validation errors while building Packages.|
|ValidatePackageDependsOn|A string that defines additional targets to execute before the ValidatePackage target.|
|TokenReplacementFileExensions|A string that defines the files that have their tokens replaced during packaging.|

## Use MsBuild properties in the properties page
 For flexibility, instead of using hard-coded strings in the **Pre-deployment Command Line** and **Post-deployment Command Line** boxes on the SharePoint Properties page, you can use the SharePoint properties as arguments. For example, instead of specifying a specific URL string for the SharePoint site, you can instead use `$(SharePointSiteUrl)`.

> [!NOTE]
> You can use either the MSBuild variable syntax `$(`*propertyName*`)` or the environment variable syntax `%`*propertyName*`%` to specify a property.

## Related content

- [MSBuild Reference](../msbuild/msbuild-reference.md)
