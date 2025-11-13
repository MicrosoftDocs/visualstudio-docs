---
title: 'Provide Automation for Windows'
description: Learn how to provide automation for document and tool windows in Visual Studio by using Microsoft.VisualStudio.Shell.Interop methods.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- automation [Visual Studio SDK], tool windows
- tool windows, automation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Provide automation for windows

You can provide automation for document and tool windows. Providing automation is advisable whenever you want to make automation objects available on a window, and the environment does not already provide a ready-made automation object, as it does with a task list.

## Automation for tool windows

The environment provides automation on a tool window by returning a standard <xref:EnvDTE.Window> object as explained in the following procedure:

1. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method via the environment with [__VSFPROPID.VSFPROPID_ExtWindowObject](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_ExtWindowObject>) as `VSFPROPID` parameter to get the `Window` object.

2. When a caller requests a VSPackage-specific automation object for your tool window through <xref:EnvDTE.Window.Object%2A>, the environment calls `QueryInterface` for `IExtensibleObject`, <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject>, or the `IDispatch` interfaces. Both `IExtensibleObject` and `IVsExtensibleObject` provide a <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject.GetAutomationObject%2A> method.

3. When the environment then calls the `GetAutomationObject` method passing `NULL`, respond by passing back your VSPackage-specific object.

4. If calling `QueryInterface` for `IExtensibleObject` and `IVsExtensibleObject` fails, then the environment calls `QueryInterface` for `IDispatch`.

## Automation for document windows

A standard <xref:EnvDTE.Document> object is also available from the environment, although an editor can have its own implementation of the <xref:EnvDTE.Document> object by implementing `IExtensibleObject` interface and responding to `GetAutomationObject`.

In addition, an editor can provide a VSPackage-specific automation object, retrieved through the <xref:EnvDTE.Document.Object%2A> method, by implementing the `IVsExtensibleObject` or `IExtensibleObject` interfaces. The [VSSDK samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples) contributes an RTF document-specific automation object.

## Related content

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject>
