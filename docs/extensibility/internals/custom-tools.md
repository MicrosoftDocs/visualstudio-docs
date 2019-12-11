---
title: "Custom Tools | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "VSPackages, custom tools"
  - "tools [Visual Studio], custom"
  - "custom tools"
ms.assetid: d669f154-9b23-48b6-b9f6-7419c8dd61a6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Custom tools
*Custom tools* let you associate a tool with an item in a project and run that tool whenever the file is saved. Certain custom tools, sometimes referred to as *single-file generators*, are frequently used to implement translators that generate code from data and vice versa. For example, single-file generators create [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] source code out of the *.settings* and *.resx* files. The generated source code provides strongly-typed access to the data in the *.settings* and *.resx* files. The [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project types support custom tools; [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] project types do not. Your own project types can also support custom tools.

 Custom tools are registered components that implement the `IVsSingleFileGenerator` interface.

 Custom tools are associated with a `ProjectItem` interface object, and are like designers and editors. A custom tool takes the file represented by a `ProjectItem` as input and writes a new file whose file name is provided by the `DefaultExtension` method.

## In this section
- [Implement single-file generators](../../extensibility/internals/implementing-single-file-generators.md)

 Describes how to use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interface to implement a custom tool.

- [Register single file generators](../../extensibility/internals/registering-single-file-generators.md)

 Provides descriptions for all the registry entries for a custom tool.

- [Expose types to visual designers](../../extensibility/internals/exposing-types-to-visual-designers.md)

 Explains how project systems provide support for visual designers to access generated classes and types through temporary portable executable (PE) files.

- [Persist the property of a project item](../../extensibility/persisting-the-property-of-a-project-item.md)

 Shows how to persist a project item property, such as the author of a source file, in the project file.

## Reference
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>
 Provides details about the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator>, which transforms a single input file into a single output file that can be compiled or added to a project.

 <xref:EnvDTE.ProjectItem>
 Explains the `ProjectItem` interface, which represents an item in a project.

 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.DefaultExtension%2A>
 Provides details about the `DefaultExtension` method, which retrieves the file name extension that is given to the output file name.

## Related sections
- [Extend projects](../../extensibility/extending-projects.md)

 Describes how to use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] projects and solutions to organize code files and resource files, and how to implement source control.