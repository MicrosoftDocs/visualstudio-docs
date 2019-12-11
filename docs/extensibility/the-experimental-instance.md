---
title: "The Experimental Instance | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "experimental builds"
  - "VSPackages, experimental builds"
  - "VSIP, experimental builds"
ms.assetid: ead0df4e-6f88-4b42-9297-581b7902f050
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# The Experimental Instance
To safeguard your Visual Studio development environment from untested applications that might change it, the VSSDK provides an experimental space that you can use to experiment. You develop new applications by using Visual Studio as usual, but you run them by using this experimental instance.

 Every application that has a VSIX package launches the Visual Studio experimental instance in debug mode.

 If you want to start the experimental instance of Visual Studio outside a specific solution, run the following command at the command window:

 "*\<Visual studio installation path>*\Common7\IDE\devenv.exe" /RootSuffix Exp

> [!NOTE]
> The experimental instance is written to the registry under the `<version number>Exp` and `<version number>Exp_Config` nodes. For example the Visual Studio 2015 experimental registry area is
>
> `HKCU\Software\Microsoft\VisualStudio\14.0Exp` and `HKCU\Software\Microsoft\VisualStudio\14.0Exp_Config`

 We recommend that you run your extension in the experimental instance while you are developing it. When you deploy the extension, it runs in the development instance. For more information about registering applications, see [Registering VSPackages](../extensibility/internals/registering-vspackages.md).