---
title: Managing VSPackages
description: Learn about managing VSPackages, so that you know when you can simply use the default VSPackage management provided by Visual Studio, and how and when to customize it.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- VSPackages, autoloading
- VSPackages, delayed loading
- delay loading
- VSPackages, loading
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manage VSPackages

In most cases you don't need to worry about managing VSPackages, since the project and item templates register and load the package automatically. However, in some circumstances you may need to learn a bit more in order to manage your package.

## Use the experimental instance
 To find out more about the experimental instance, see [The experimental instance](../extensibility/the-experimental-instance.md).

## Register and unregister VSPackages
 To find out how to register and unregister VSPackages and other types of extension, see [Register and unregister VSPackages](../extensibility/registering-and-unregistering-vspackages.md).

## Load a VSPackage
 VSPackages can be set to autoload when a particular CMDUICONTEXT GUID is turned on. For more information, see [Load VSPackages](../extensibility/loading-vspackages.md).

## Use AsyncPackage to load VSPackages in the background
 The `AsyncPackage` class enables package loading on a background thread for better UI responsiveness in Visual Studio. For more information, see [How to: Use AsyncPackage to load VSPackages in the background](../extensibility/how-to-use-asyncpackage-to-load-vspackages-in-the-background.md).

## Rule-based UI Context for extensions
 Rules-based UI Contexts allows extension authors to define the precise conditions under which a UI Context is activated and associated VSPackages loaded. For more information, see [How to: Use rule-based UI Context for Visual Studio extensions](../extensibility/how-to-use-rule-based-ui-context-for-visual-studio-extensions.md).

## Diagnose extension performance
Extensions can impact startup and solution load performance. Learn how Visual Studio extension impact is calculated and how it can be analyzed locally to test if an extension may be shown as a performance impacting extension. For more information, see [How to: Diagnose extension performance](how-to-diagnose-extension-performance.md).

## Troubleshoot VSPackages
 Find out the techniques for troubleshooting VSPackages that don't load or are experiencing errors: [Troubleshoot VSPackages](/troubleshoot/developer/visualstudio/extensibility/troubleshooting-vspackages)

## Related content
- [VSPackages](../extensibility/internals/vspackages.md)
