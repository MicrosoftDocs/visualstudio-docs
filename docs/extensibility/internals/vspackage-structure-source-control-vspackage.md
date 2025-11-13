---
title: VSPackage Structure (Source Control VSPackage)
description: Learn about the Source Control Package SDK, which provides guidelines for a VSPackage with a source control implementer to integrate with Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSPackages, structure
- source control packages, VSPackage overview
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSPackage Structure (Source Control VSPackage)

The Source Control Package SDK provides guidelines for creating a VSPackage that allow a source control implementer to integrate his or her source control functionality with the Visual Studio environment. A VSPackage is a COM component that is typically loaded on demand by the Visual Studio integrated development environment (IDE) based on the services that are advertised by the package in its registry entries. Every VSPackage must implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage>. A VSPackage typically consumes services offered by the Visual Studio IDE and proffers some services of its own.

A VSPackage declares its menu items and establishes a default item state via the .vsct file. The Visual Studio IDE displays the menu items in this state until the VSPackage is loaded. Subsequently, the VSPackage's implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method is called to enable or disable menu items.

## Source Control Package Characteristics

A source control VSPackage is deeply integrated into Visual Studio. The VSPackage semantics include:

- Interface to be implemented by virtue of being a VSPackage (the `IVsPackage` interface)

- UI Command implementation (.vsct file and implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface)

- Registration of the VSPackage with Visual Studio.

The source control VSPackage must communicate with these other Visual Studio entities:

- Projects

- Editors

- Solutions

- Windows

- The running document table

### Visual Studio Environment Services That May Be Consumed

<xref:Microsoft.VisualStudio.Shell.Interop.SVsShell>

<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>

<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution>

SVsRegisterScciProvider Service

<xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave>

<xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackProjectDocuments>

<xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager>

### VSIP Interfaces Implemented and Called

A source control package is a VSPackage, and therefore it can interact directly with other VSPackages that are registered with Visual Studio. In order to provide the full breadth of source control functionality, a source control VSPackage can deal with interfaces provided by projects or the shell.

Every project in Visual Studio must implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3> to be recognized as a project within the Visual Studio IDE. However, this interface is not specialized enough for source control. Projects that are expected to be under source control implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2>. This interface is used by the source control VSPackage to query a project for its contents and to provide it glyphs and binding information (the information needed to establish a connection between the server location and the disk location of a project that is under source control).

The source control VSPackage implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2>, which in turn allows projects to register themselves for source control and retrieve their status glyphs.

For a complete list of interfaces that a source control VSPackage must consider, see [Related Services and Interfaces](../../extensibility/internals/related-services-and-interfaces-source-control-vspackage.md).

## See also

- [Design Elements](../../extensibility/internals/source-control-vspackage-design-elements.md)
- [Related Services and Interfaces](../../extensibility/internals/related-services-and-interfaces-source-control-vspackage.md)
