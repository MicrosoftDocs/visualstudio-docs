---
title: Source Control Runtime Details
description: Learn how a project is added to source control, either when a user adds a file to the project in source control or through an automation controller.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], runtime details
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Runtime Details

A project is added to source control when the user adds a file in the project to source control, or through an automation controller, such as a wizard. A project does not specify for itself that it is under source control; it supports source control, but must be added to it manually.

## Registering with a Source Control Package
 When a file in your project is added to source control, the environment calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2.SetSccLocation%2A> to provide you four opaque strings that are used as cookies by the source control system. Store these strings in your project file. These strings should be passed to the Source Control Stub (the Visual Studio component that manages source control packages) on startup of the project type by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2.RegisterSccProject%2A>. This in turn loads the appropriate source control package and forwards the call to its implementation of `IVsSccManager2::RegisterSccProject`.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2.RegisterSccProject%2A>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2.SetSccLocation%2A>
- [Supporting Source Control](../../extensibility/internals/supporting-source-control.md)
