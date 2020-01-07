---
title: "Using the Managed Package Framework to Implement a Project Type (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "projects [Visual Studio SDK], creating with MPF"
  - "MPF projects"
  - "managed package framework, creating projects"
ms.assetid: 926de536-eead-415b-9451-f1ddc8c44630
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Using the Managed Package Framework to Implement a Project Type (C#)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The Managed Package Framework (MPF) provides C# classes you can use or inherit from to implement your own project types. The MPF implements many of the interfaces Visual Studio expects a project type to provide, leaving you free to concentrate on implementing the particulars of your project type.  
  
## Using the MPF Project Source Code  
 The Managed Package Framework for Projects (MPFProj) provides helper classes for creating and managing new project system. Unlike other classes in the MPF, the project classes are not included in the assemblies shipped with Visual Studio. Instead, the project classes are provided as source code at [MPF for Projects 2013](https://archive.codeplex.com/?p=mpfproj12).  
  
 To add this project to your VSPackage solution, do the following:  
  
1. Download the MPFProj files to *MPFProjectDir*.  
  
2. In the *MPFProjectDir*\Dev10\Src\CSharp\ProjectBase.file, change the following block:  
  
```  
<!-- Provide a default value for $(ProjectBasePath) -->  
  <PropertyGroup>  
    <ProjectBasePath >MPFProjDir\Dev10\Src\CSharp</ProjectBasePath>  
  </PropertyGroup>  
```  
  
1. Create a VSPackage project.  
  
2. Unload the VSPackage project.  
  
3. Edit the VSPackage .csproj file by adding the following block before the other `<Import>` blocks:  
  
```  
<Import Project="MPFProjectDir\Dev10\Src\CSharp\ProjectBase.files" />  
  <PropertyGroup>  
    <!--To specify a different registry root to register your package, uncomment the TargetRegistryRoot tag and specify a registry root in it.  
    <TargetRegistryRoot></TargetRegistryRoot>-->  
    <RegisterOutputPackage>true</RegisterOutputPackage>  
    <RegisterWithCodebase>true</RegisterWithCodebase>  
  </PropertyGroup>  
```  
  
1. Save the project.  
  
2. Close and reopen the VSPackage solution.  
  
3. Reopen the VSPackage project. You should see a new directory named ProjectBase.  
  
4. Add the following reference to the VSPackage project:  
  
     Microsoft.Build.Tasks.4.0  
  
5. Build the project.  
  
## Hierarchy Classes  
 The following table summarizes the classes in the MPFProj that support project hierarchies. For more information, see [Hierarchies and Selection](../../extensibility/internals/hierarchies-and-selection.md).  
  
|Class name|  
|----------------|  
|`Microsoft.VisualStudio.Package.HierarchyNode`|  
|`Microsoft.VisualStudio.Package.ProjectNode`|  
|`Microsoft.VisualStudio.Package.ProjectContainerNode`|  
|`Microsoft.VisualStudio.Package.FileNode`|  
|`Microsoft.VisualStudio.Package.FolderNode`|  
|`Microsoft.VisualStudio.Package.ReferenceContainerNode`|  
|`Microsoft.VisualStudio.Package.ReferenceNode`|  
|`Microsoft.VisualStudio.Package.ProjectReferenceNode`|  
|`Microsoft.VisualStudio.Package.ComReferenceNode`|  
|`Microsoft.VisualStudio.Package.AssemblyReferenceNode`|  
|`Microsoft.VisualStudio.Package.BuildDependency`|  
  
## Document-Handling Classes  
 The following table lists the classes in the MPF that support document handling. For more information, see [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md).  
  
|Class name|  
|----------------|  
|`Microsoft.VisualStudio.Package.DocumentManager`|  
|`Microsoft.VisualStudio.Package.FileDocumentManager`|  
  
## Configuration and Output Classes  
 The following table lists the classes in the MPF that let project types support multiple configurations, such as debug and release, and collections of project output. For more information, see [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md).  
  
|Class name|  
|----------------|  
|`Microsoft.VisualStudio.Package.ConfigProvider`|  
|`Microsoft.VisualStudio.Package.ProjectConfig`|  
|`Microsoft.VisualStudio.Package.BuildableProjectConfig`|  
|`Microsoft.VisualStudio.Package.OutputGroup`|  
|`Microsoft.VisualStudio.Package.ProjectElement`|  
  
## Automation-Support Classes  
 The following table lists the classes in the MPF that support automation so that users of your project type can write add-ins.  
  
|Class name|  
|----------------|  
|`Microsoft.VisualStudio.Package.Automation.OAProject`|  
|`Microsoft.VisualStudio.Package.Automation.OANavigableProjectItems`|  
|`Microsoft.VisualStudio.Package.Automation.OAProjectItems`|  
|`Microsoft.VisualStudio.Package.Automation.OAProjectItem`|  
|`Microsoft.VisualStudio.Package.Automation.OANestedProjectItem`|  
  
## Properties Classes  
 The following table lists the classes in the MPF that let project types add properties that users can browse and modify in a property browser.  
  
|Class name|  
|----------------|  
|`Microsoft.VisualStudio.Package.LocalizableProperties`|  
|`Microsoft.VisualStudio.Package.NodeProperties`|  
|`Microsoft.VisualStudio.Package.FileNodeProperties`|  
|`Microsoft.VisualStudio.Package.ProjectNodeProperties`|  
|`Microsoft.VisualStudio.Package.FolderNodeProperties`|  
|`Microsoft.VisualStudio.Package.ReferenceNodeProperties`|
