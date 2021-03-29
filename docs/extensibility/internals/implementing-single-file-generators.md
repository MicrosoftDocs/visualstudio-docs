---
title: Implementing Single-File Generators | Microsoft Docs
description: Learn how to use a custom tool that implements the IVsSingleFileGenerator interface to extend Visual Basic and Visual C# project systems in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- custom tools, implementing
- projects [Visual Studio SDK], extensibility
- projects [Visual Studio SDK], managed custom tools
ms.assetid: fe9ef6b6-4690-4c2c-872c-301c980d17fe
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Implementing Single-File Generators
A custom tool — sometimes referred to as a single file generator — can be used to extend the [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] and [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] project systems in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. A custom tool is a COM component that implements the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interface. Using this interface, a custom tool transforms a single input file into a single output file. The result of the transformation may be source code, or any other output that is useful. Two examples of custom tool-generated code files are code generated in response to changes in a visual designer and files generated using Web Services Description Language (WSDL).

 When a custom tool is loaded, or the input file is saved, the project system calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.Generate%2A> method, and passes a reference to a <xref:Microsoft.VisualStudio.Shell.Interop.IVsGeneratorProgress> callback interface, whereby the tool can report its progress to the user.

 The output file that the custom tool generates is added to the project with a dependency on the input file. The project system automatically determines the name of the output file, based on the string returned by the custom tool's implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.DefaultExtension%2A>.

 A custom tool must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator> interface. Optionally, custom tools support the <xref:Microsoft.VisualStudio.OLE.Interop.IObjectWithSite> interface to retrieve information from sources other than the input file. In any case, before you can use a custom tool, you must register it with the system or in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] local registry. For more information on registering custom tools, see [Registering Single File Generators](../../extensibility/internals/registering-single-file-generators.md).

## See also
- [Exposing Types to Visual Designers](../../extensibility/internals/exposing-types-to-visual-designers.md)
