---
title: "Custom Tools | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSPackages, custom tools"
  - "tools [Visual Studio], custom"
  - "custom tools"
ms.assetid: d669f154-9b23-48b6-b9f6-7419c8dd61a6
caps.latest.revision: 22
ms.author: gregvanl
manager: jillfra
---
# Custom Tools
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

*Custom tools* let you associate a tool with an item in a project and run that tool whenever the file is saved. Certain custom tools, sometimes referred to as *single-file generators*, are frequently used to implement translators that generate code from data and vice versa. For example, single-file generators create [!INCLUDE[csprcs](../../includes/csprcs-md.md)] and [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] source code out of the .settings and .resx files. The generated source code provides strongly-typed access to the data in the .settings and .resx files. The [!INCLUDE[csprcs](../../includes/csprcs-md.md)] and [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] project types support custom tools; [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] project types do not. Your own project types can also support custom tools.  
  
 Custom tools are registered components that implement the `IVsSingleFileGenerator` interface.  
  
 Custom tools are associated with a `ProjectItem` interface object, and are like designers and editors. A custom tool takes the file represented by a `ProjectItem` as input and writes a new file whose file name is provided by the `DefaultExtension` method.  
  
## In This Section  
 [Implementing Single-File Generators](../../extensibility/internals/implementing-single-file-generators.md)  
 Describes how to use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interface to implement a custom tool.  
  
 [Determining the Default Namespace of a Project](../../misc/determining-the-default-namespace-of-a-project.md)  
 Describes how to determine the correct namespace based on the language being used.  
  
 [Registering Single File Generators](../../extensibility/internals/registering-single-file-generators.md)  
 Provides descriptions for all the registry entries for a custom tool.  
  
 [Exposing Types to Visual Designers](../../extensibility/internals/exposing-types-to-visual-designers.md)  
 Explains how project systems provide support for visual designers to access generated classes and types through temporary portable executable (PE) files.  
  
 [Persisting the Property of a Project Item](../../extensibility/persisting-the-property-of-a-project-item.md)  
 Shows how to persist a project item property, such as the author of a source file, in the project file.  
  
## Reference  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>  
 Provides details about the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>, which transforms a single input file into a single output file that can be compiled or added to a project.  
  
 <xref:EnvDTE.ProjectItem>  
 Explains the `ProjectItem` interface, which represents an item in a project.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.DefaultExtension%2A>  
 Provides details about the `DefaultExtension` method, which retrieves the file name extension that is given to the output file name.  
  
## Related Sections  
 [Extending Projects](../../extensibility/extending-projects.md)  
 Describes how to use [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] projects and solutions to organize code files and resource files, and how to implement source control.
