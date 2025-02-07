---
title: Explore experimental space in Visual Studio SDK
description: Explore how the Visual Studio SDK provides an experimental space to run untested applications in debug mode and safeguard your development environment.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- experimental builds
- VSPackages, experimental builds
- VSIP, experimental builds
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# The Experimental Instance

To safeguard your Visual Studio development environment from untested applications that might change it, the VSSDK provides an experimental space that you can use to experiment. You develop new applications by using Visual Studio as usual, but you run them by using this experimental instance.

 Every application that has a VSIX package launches the Visual Studio experimental instance in debug mode.

 If you want to start the experimental instance of Visual Studio outside a specific solution, run the following command at the command window:

 "*\<Visual Studio installation path>*\Common7\IDE\devenv.exe" /RootSuffix Exp

> [!NOTE]
> The experimental instance is written to the registry under the `<version number>Exp` and `<version number>Exp_Config` nodes. For example the Visual Studio 2015 experimental registry area is
>
> `HKCU\Software\Microsoft\VisualStudio\14.0Exp` and `HKCU\Software\Microsoft\VisualStudio\14.0Exp_Config`

 We recommend that you run your extension in the experimental instance while you are developing it. When you deploy the extension, it runs in the development instance. For more information about registering applications, see [Registering VSPackages](../extensibility/internals/registering-vspackages.md).
