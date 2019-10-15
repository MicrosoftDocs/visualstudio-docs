---
title: "Automation Support for Options Pages | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Tools Options pages [Visual Studio SDK], automation support"
  - "automation [Visual Studio SDK], creating Tools Options pages"
ms.assetid: 0b25b82c-7432-4e0a-9e84-350269ba8260
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Automation support for Options pages
VSPackages can provide custom **Options** dialog boxes to the **Tools** menu (**Tools Options** pages) in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] and can make them available to the automation model.

## Tools Options pages
 To create a **Tools Options** page, a VSPackage must provide a user control implementation returned to the environment through the VSPackage's implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage%2A> method. (Or, for managed-code, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage%2A> method.)

 It's optional, but strongly encouraged, to allow access to this new page through the automation model. You can do so with the following steps:

1. Extend the <xref:EnvDTE._DTE.Properties%2A> object through the implementation of an IDispatch-derived object.

2. Return an implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject%2A> method (or for managed code the <xref:Microsoft.VisualStudio.Shell.Package.GetAutomationObject%2A> method) to the IDispatch-derived object.

3. When an automation consumer calls the <xref:EnvDTE._DTE.Properties%2A> method on a custom **Option** property page, the environment uses the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject%2A> method to obtain a custom **Tools Options** page's automation implementation.

4. The automation object of the VSPackage is then used to provide each <xref:EnvDTE.Property> returned by <xref:EnvDTE._DTE.Properties%2A>.

   For a sample implementing a custom **Tools Options** page, see [VSSDK Samples](https://aka.ms/vs2015sdksamples).

## See also
- [Expose project objects](../../extensibility/internals/exposing-project-objects.md)