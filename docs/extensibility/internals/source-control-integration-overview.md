---
title: Source Control Integration Overview
description: "Learn about the differences between the two ways to integrate source control into Visual Studio: a source control plug-in and a VSPackage."
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], about source control
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Integration Overview

This section compares the two ways to integrate into Visual Studio source control; a source control Plug-in and a VSPackage that provides a source control solution and highlights the new source control features. Visual Studio allows for manual switching between source control VSPackages and source control plug-ins as well as automatic solution-based switching.

## Source Control Integration
 Visual Studio supports two types of source control integration options. In all versions of Visual Studio, you can still integrate a plug-in based on the Source Control Plug-in API (previously also referred to as the MSSCCI API), which provides basic source control functionality while using Visual Studio source control user interface (UI). A source control VSPackage, on the other hand, provides a new, deep-integration Visual Studio SDK path suitable for source control integration that demands a high level of sophistication and autonomy in its source control model.

 ![Source Control Overview](../../extensibility/internals/media/sourcectnrloverview.gif "SourceCtnrlOverview")

## Source Control Plug-in
 All versions of Visual Studio support the Source Control Plug-in API specification version 1.2 as an integration path. A source control plug-in implementer writes a DLL that implements the Source Control Plug-in API functions for source control integration and registration as described in [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md). In this approach, the Integrated Development Environment (IDE) uses the Visual Studio UI for dialog boxes, such as check in, checkout, tools/options property pages, toolbars, and source control glyphs. Strict adherence to the Source Control Plug-in API insures an easy integration into Visual Studio and a trouble-free experience for the user. This means the source control plug-in must implement most of the functions and callbacks detailed in the API.

 To implement a source control plug-in using the Source Control Plug-in API, follow these steps:

1. Create a DLL that implements the functions specified in [Source Control Plug-ins](../../extensibility/source-control-plug-ins.md).

2. Register the DLL by making the appropriate registry entries (described in [How to: Install a Source Control Plug-in](../../extensibility/internals/how-to-install-a-source-control-plug-in.md)).

3. Create a helper UI and display when prompted by the Source Control Adapter Package (the Visual Studio component that handles source control functionality via source control plug-ins)

   In response to a source control command, the Visual Studio IDE presents a standard UI for the basic operations and then passes the information to the source control plug-in via the functions defined in the Source Control Plug-in API. For advanced options, the source control plug-in may be called on to present its own UI, for example, browsing for a source-controlled project. This means that the user may be presented with two possibly different styles of UI when dealing with source control: the UI that Visual Studio presents and the UI that the source control plug-in presents. This is most noticeable with advanced source control operations.

### Drawbacks to Implementing a Source Control Plug-in

- For advanced features, the user may see two different styles of interfaces, leading to possible confusion.

- The source control plug-in is confined to the source control model implied by the Source Control Plug-in API.

- The Source Control Plug-in API may be too restrictive for some source control scenarios.

### Advantages to Implementing a Source Control Plug-in

- Visual Studio supplies all the UI for all the basic source control operations so that the source control plug-in does not have to implement potentially complex UI.

- Because of the strict API, the source control plug-in can readily interact with external source control programs to provide more extensive functionality; Visual Studio does not care too much how the source control functionality is accomplished, only that it is accomplished according to the Source Control Plug-in API.

- It is easier to implement a source control plug-in than a source control VSPackage.

## Source Control VSPackage
 Visual Studio SDK allows for deep integration into Visual Studio with full control of source control functionality and complete replacement of the Visual Studio-provided source control user interface. A source control VSPackage is registered with Visual Studio and provides source control functionality. Although several source control VSPackages can be registered with Visual Studio, only one of them can be active at any one time. A source control VSPackage has full control over the source control functionality and appearance in Visual Studio while it is active. All other source control VSPackages that may be registered in the system are inactive and will not display any UI at all.

 Implementing a source control VSPackage requires an "all or nothing" strategy. The creator of a source control VSPackage must invest a significant amount of effort in implementing a number of source control interfaces and new UI elements (dialog boxes, menus, and toolbars) to cover the entire source control functionality. See [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md) for more details.

### Drawbacks to Implementing a Source Control VSPackage

- The VSPackage must implement a number of complex interfaces to integrate successfully with Visual Studio.

- The VSPackage must supply all the UI required for source control; Visual Studio will provide no assistance in this area.

- A source control VSPackage is intimately tied to Visual Studio and cannot operate with stand-alone programs, so functionality cannot be as easily shared with an external version of the source control program.

### Advantages to Implementing a Source Control VSPackage

- Because the VSPackage has full control over the source control UI and functionality, the user is presented with a seamless interface for source control.

- The VSPackage is not confined to a particular source control model.

## Related content
- [Source Control](../../extensibility/internals/source-control.md)
- [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)
- [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md)
- [What's New in Source Control](../../extensibility/internals/what-s-new-in-source-control.md)
