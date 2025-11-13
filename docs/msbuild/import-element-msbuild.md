---
title: Import Element (MSBuild)
description: Learn how MSBuild uses the Import element to import the contents of one project file into another project file.
ms.date: 03/13/2017
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Import
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- Import element [MSBuild]
- <Import> element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Import element (MSBuild)

Imports the contents of one project file into another project file.

\<Project>
\<Import>

## Syntax

```xml
<Import Project="ProjectPath"
    Condition="'String A'=='String B'" />
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Project`|Required attribute.<br /><br /> The path of the project file to import. The path can include wildcards. The matching files are imported in sorted order. By using this feature, you can add code to a project just by adding the code file to a directory.|
|`Condition`|Optional attribute.<br /><br /> A condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|
|`Label`|Optional attribute.<br /><br /> Applies an identifier to this import element.|
|`Sdk`| Optional attribute.<br /><br /> References a project SDK.|

### Child elements

 None

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an MSBuild project file. |
| [ImportGroup](../msbuild/importgroup-element.md) | Contains a collection of `Import` elements grouped under an optional condition. |

## Remarks

 By using the `Import` element, you can reuse code that is common to many project files. Using imports makes it easier to maintain the code, because any updates you make to the shared code get propagated to all the projects that import it.

 By convention, shared imported project files are saved as `.targets` files, but they are standard MSBuild project files. MSBuild does not prevent you from importing a project that has a different file name extension, but we recommend that you use the `.targets` extension for consistency.

 Relative paths in imported projects are interpreted relative to the directory of the importing project (with a few exceptions described later in this paragraph). Therefore, if a project file is imported into several project files in different locations, the relative paths in the imported project file will be interpreted differently for each imported project. There are two exceptions. One exception is that in `Import` elements, the path is always interpreted relative to the project that contains the `Import` element. Another exception is that the `UsingTask` always interprets the relative path for the `AssemblyFile` attribute relative to the file that contains the `UsingTask` element.

 All MSBuild reserved properties that relate to the project file that are referenced in an imported project (for example, `MSBuildProjectDirectory` and `MSBuildProjectFile`) are assigned values based on the importing project file.

 If the imported project doesn't have a `DefaultTargets` attribute, imported projects are inspected in the order that they are imported, and the value of the first discovered `DefaultTargets` attribute is used. For example, if ProjectA imports ProjectB and ProjectC (in that order), and ProjectB imports ProjectD, MSBuild first looks for `DefaultTargets` specified on ProjectA, then ProjectB, then ProjectD, and finally ProjectC.

 The schema of an imported project is identical to that of a standard project. Although MSBuild may be able to build an imported project, it is unlikely because an imported project typically does not contain information about which properties to set or the order in which to run targets. The imported project depends on the project into which it is imported to provide that information.

## Wildcards

 MSBuild allows wildcards in the Project attribute. When there are wildcards, all matches found are sorted (for reproducibility), and then they are imported in that order as if the order had been explicitly set.

 This is useful if you want to offer an extensibility point so that someone else can import a file without requiring you to explicitly add the file name to the importing file. For this purpose, *Microsoft.Common.Targets* contains the following line at the top of the file.

```xml
<Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\$(MSBuildThisFile)\ImportBefore\*" Condition="'$(ImportByWildcardBeforeMicrosoftCommonTargets)' == 'true' and exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\$(MSBuildThisFile)\ImportBefore')"/>
```

## Example

 The following example shows a project that has several items and properties and imports a general project file.

```xml
<Project DefaultTargets="Compile">

    <PropertyGroup>
        <resourcefile>Strings.resx</resourcefile>

        <compiledresources>
            $(O)\$(MSBuildProjectName).Strings.resources
        </compiledresources>
    </PropertyGroup>

    <ItemGroup>
        <CSFile Include="*.cs" />

        <Reference Include="System" />
        <Reference Include="System.Data" />
    </ItemGroup>

    <Import Project="$(CommonLocation)\General.targets" />
</Project>
```

## See also

- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [How to: Use the same target in multiple project files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md)
