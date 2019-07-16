---
title: "Import Element (MSBuild) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Import"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Import element [MSBuild]"
  - "<Import> element [MSBuild]"
ms.assetid: 3bfecaf1-69fd-4008-b651-c9dafd4389d9
caps.latest.revision: 32
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Import Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Imports the contents of one project file into another project file.  
  
 \<Project>  
 \<Import>  
  
## Syntax  
  
```  
<Import Project="ProjectPath"  
    Condition="'String A'=='String B'" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Project`|Required attribute.<br /><br /> The path of the project file to import. The path can include wildcards. The matching files are imported in sorted order. By using this feature, you can add code to a project just by adding the code file to a directory.|  
|`Condition`|Optional attribute.<br /><br /> A condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../msbuild/project-element-msbuild.md)|Required root element of an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file.|  
|[ImportGroup](../msbuild/importgroup-element.md)|Contains a collection of `Import` elements grouped under an optional condition.|  
  
## Remarks  
 By using the `Import` element, you can reuse code that is common to many project files. This makes it easier to maintain the code because any updates you make to the shared code get propagated to all the projects that import it.  
  
 By convention, shared imported project files are saved as .targets files, but they are standard [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project files. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] does not prevent you from importing a project that has a different file name extension, but we recommend that you use the .targets extension for consistency.  
  
 Relative paths in imported projects are interpreted relative to the directory of the importing project. Therefore, if a project file is imported into several project files in different locations, the relative paths in the imported project file will be interpreted differently for each imported project.  
  
 All [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] reserved properties that relate to the project file, for example, `MSBuildProjectDirectory` and `MSBuildProjectFile`, that are referenced in an imported project are assigned values based on the importing project file.  
  
 If the imported project does not have a `DefaultTargets` attribute, imported projects are inspected in the order that they are imported, and the value of the first discovered `DefaultTargets` attribute is used. For example, if ProjectA imports ProjectB and ProjectC (in that order), and ProjectB imports ProjectD, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] first looks for `DefaultTargets` specified on ProjectA, then ProjectB, then ProjectD, and finally ProjectC.  
  
 The schema of an imported project is identical to that of a standard project. Although [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] may be able to build an imported project, it is unlikely because an imported project typically does not contain information about which properties to set or the order in which to run targets. The imported project depends on the project into which it is imported to provide that information.  
  
> [!NOTE]
> While conditional import statements work in command-line MSBuilds, they do not work with MSBuild in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE). Conditional imports are evaluated by using the configuration and platform values that are set when the project is loaded. If changes are subsequently made that require a reevaluation of the conditionals in the project file, for example, changing the platform, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] reevaluates the conditions on properties and items, but not on imports. Because the import conditional is not reevaluated, the import is skipped.  
>   
> To work around this, put conditional imports in the .targets files or put code in a conditional block such as a [Choose Element (MSBuild)](../msbuild/choose-element-msbuild.md) block.  
  
## Wildcards  
 In the .NET Framework 4, MSBuild allows wildcards in the Project attribute. When there are wildcards, all matches found are sorted (for reproducibility), and then they are imported in that order as if the order had been explicitly set.  
  
 This is useful if you want to offer an extensibility point so that someone else can import a file without requiring you to explicitly add the file name to the importing file. For this purpose, Microsoft.Common.Targets contains the following line at the top of the file.  
  
```  
<Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\$(MSBuildThisFile)\ImportBefore\*" Condition="'$(ImportByWildcardBeforeMicrosoftCommonTargets)' == 'true' and exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\$(MSBuildThisFile)\ImportBefore')"/>  
```  
  
## Example  
 The following example shows a project that has several items and properties and imports a general project file.  
  
```  
<Project DefaultTargets="Compile"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
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
  
## See Also  
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)   
 [How to: Use the Same Target in Multiple Project Files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md)
