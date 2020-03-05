---
title: "Automation for Configuration and SelectedItem Objects | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "automation [Visual Studio SDK], SelectedItem object"
  - "automation [Visual Studio SDK], builds"
ms.assetid: 120377f1-51aa-4445-b2f7-06ab7fc2b47f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Automation for Configuration and SelectedItem objects

You can automate the build and selected item processes in Visual Studio.

## Automation for builds

Build or configuration has an automation model that is provided when you implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider>. For more information, see [Understand build configurations](../../ide/understanding-build-configurations.md).

If you create a VSPackage and want to control configuration options, you must use the automation model.

## Automation for SelectedItem

You do not have to provide an implementation for the `SelectedItem` object because Visual Studio contains a standard implementation. However, you can implement the `SelectedItem` object if you prefer. You must implement an object that contains the `SelectedItem` interface and return a response to a call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage%2A> method with `VSITEMID` set to [__VSHPROPID.VSHPROPID_ExtSelectedItem](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_ExtSelectedItem>).

## See also

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage%2A>
- [Contribute to the automation model](../../extensibility/internals/contributing-to-the-automation-model.md)
- [Understand build configurations](../../ide/understanding-build-configurations.md)