---
title: Build custom tools & join them with project items
description: Create custom tools in Visual Studio that associate a tool with an item in a project and run that tool whenever the file is saved.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- VSPackages, custom tools
- tools [Visual Studio], custom
- custom tools
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Custom tools

*Custom tools* let you associate a tool with an item in a project and run that tool whenever the file is saved. Certain custom tools, sometimes referred to as *single-file generators*, are frequently used to implement translators that generate code from data and vice versa. For example, single-file generators create Visual C# and Visual Basic source code out of the *.settings* and *.resx* files. The generated source code provides strongly-typed access to the data in the *.settings* and *.resx* files. The Visual C# and Visual Basic project types support custom tools; Visual C++ project types do not. Your own project types can also support custom tools.

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

 Describes how to use Visual Studio projects and solutions to organize code files and resource files, and how to implement source control.
