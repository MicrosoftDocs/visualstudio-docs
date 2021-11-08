---
title: Source Control Integration Essentials | Microsoft Docs
description: "Learn about the two types of source control integration that Visual Studio supports: a source control plug-in and a VSPackage-based source control solution."
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Source Control Integration, essentials
- Source Control Integration,overview
- essentials, Source Control Integration
ms.assetid: 442057cb-fd54-4283-96f8-2f6dc8bf2de7
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Source Control Integration Essentials
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] supports two types of source control integration: a source control plug-in that provides basic functionality and is built using the Source Control Plug-in API (formerly known as the MSSCCI API), and a VSPackage-based source control integration solution that provides more robust functionality.

## Source Control Plug-in
 A Source Control Plug-in is written as a DLL that implements the Source Control Plug-in API. Registration and source control integration functionality is provided through the API. This approach is easier to implement than a source control VSPackage, and it uses the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] user interface (UI) for most source control operations.

 To implement a source control plug-in using the Source Control Plug-in API, follow these steps:

1. Create a DLL that implements the functions specified in [Source Control Plug-ins](../../extensibility/source-control-plug-ins.md).

2. Register the DLL by making the appropriate registry entries, as described in [How to: Install a Source Control Plug-in](../../extensibility/internals/how-to-install-a-source-control-plug-in.md).

3. Create a helper UI and display it when prompted by the Source Control Adapter Package (the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] component that handles source control functionality through source control plug-ins).

   For more information, see [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md).

## Source Control VSPackage
 A source control VSPackage implementation allows you to develop a customized replacement for the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] source control UI. This approach provides complete control over source control integration, but it requires you to provide the UI elements and implement the source control interfaces that otherwise would be provided under the plug-in approach.

 To implement a source control VSPackage, you must:

1. Create and register your own source control VSPackage, as described in [Registration and Selection](../../extensibility/internals/registration-and-selection-source-control-vspackage.md).

2. Replace the default source control UI with your custom UI. See [Custom User Interface](../../extensibility/internals/custom-user-interface-source-control-vspackage.md).

3. Specify glyphs to be used, and handle **Solution Explorer** glyph events. See [Glyph Control](../../extensibility/internals/glyph-control-source-control-vspackage.md).

4. Handle Query Edit and Query Save events, as shown in [Query Edit Query Save](../../extensibility/internals/query-edit-query-save-source-control-vspackage.md).

   For more information, see [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md).

## See also
- [Overview](../../extensibility/internals/source-control-integration-overview.md)
- [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)
- [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md)
