---
title: When to implement a source control VSPackage
description: Learn about the choices of source control plug-ins and source control VSPackages that are available for extending Visual Studio source control solutions.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control packages, about source control packages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Determine whether to implement a source control VSPackage

This section elaborates the choices of source control plug-ins and source control VSPackages for extending source control solutions and gives broad guidelines about choosing a suitable integration path.

## Small source control solution with limited resources

 If you have limited resources and cannot be burdened with the overhead of writing a source control package, you can create Source Control Plug-in API-based plug-ins. Doing so allows you to work side by side with source control packages, and you can switch between source control plug-ins and packages on demand. For more information, see [Registration and selection](../../extensibility/internals/registration-and-selection-source-control-vspackage.md).

## Large source control solution with a rich feature set

 If you want to implement a source control solution that provides a rich source control model that is not adequately captured by using the Source Control Plug-in API, you may consider a source control package as the integration path. This applies especially if you would rather replace the Source Control Adapter Package (which communicates with source control plug-ins and provides a basic source control UI) with your own so that you can handle the source control events in a custom manner. If you already have a satisfactory source control UI and want to preserve that experience in Visual Studio, the source control package option lets you do just that. The source control package is not generic and is designed solely for use with Visual Studio IDE.

 If you want to implement a source control solution that provides flexibility and richer control over the source control logic and UI, you may prefer the source control package integration route. You can:

1. Register your own source control VSPackage (see [Registration and selection](../../extensibility/internals/registration-and-selection-source-control-vspackage.md)).

2. Replace the default source control UI with your custom UI (see [Custom user interface](../../extensibility/internals/custom-user-interface-source-control-vspackage.md)).

3. Specify glyphs to be used and handle Solution Explorer glyph events (see [Glyph control](../../extensibility/internals/glyph-control-source-control-vspackage.md)).

4. Handle Query Edit and Query Save events (see [Query Edit Query Save](../../extensibility/internals/query-edit-query-save-source-control-vspackage.md)).

## Related content

- [Create a source control plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)
