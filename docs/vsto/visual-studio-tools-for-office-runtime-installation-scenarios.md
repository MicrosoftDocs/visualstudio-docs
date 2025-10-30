---
title: Visual Studio Tools for Office runtime installation scenarios
description: Install the Visual Studio 2010 Tools for Microsoft Office runtime during installation of Visual Studio, Microsoft Office, or the runtime redistributable.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visual Studio Tools for Office runtime, installation scenarios"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Visual Studio Tools for Office runtime installation scenarios

  You can install the Visual Studio 2010 Tools for Office runtime in three ways:

- When you install Visual Studio.

- When you install Microsoft Office.

- When you install the Visual Studio 2010 Tools for Office runtime redistributable.

  The runtime components that are installed depend on the configuration of the computer and the installation scenario.

## Runtime components that are installed in each installation scenario

 The Visual Studio 2010 Tools for Office runtime have three components: the Office solution loader, the Office extensions for the .NET Framework 3.5, and the Office extensions for the .NET Framework 4 or later. When you install the runtime, the Office solution loader is always installed. The installation of the Office extensions for the .NET Framework depends on the configuration of the computer and the installation scenario. If one of the Office extensions cannot be installed when the runtime is first installed, the runtime will automatically install the missing Office extensions later, when certain requirements are met. This feature of the runtime is called *install on demand*.

 The following table shows which runtime components are installed by default in each runtime installation scenario. More information about each scenario appears later.

|Runtime installation scenario|Office solution loader|Office extensions for the .NET Framework 3.5|Office extensions for the .NET Framework 4|Office extensions for the .NET Framework 4.5|
|-----------------------------------|----------------------------|--------------------------------------------------| - |---------------------------------------------------------------------------|
|With Visual Studio 2013 and later|Yes|Yes, if the .NET Framework 3.5 is already installed.|Yes|Yes|
|With Office 2010|Yes|Yes, if the .NET Framework 3.5 is already installed.|No|No|
|With Office 2010 Service Pack 1 (SP1) or later|Yes|Yes, if the .NET Framework 3.5 is already installed.|Yes, if the .NET Framework 4 is already installed.|No|
|With Office 2013 and newer|Yes|Yes, if the .NET Framework 3.5 is already installed|Yes, if the .NET Framework 4 is already installed.|Yes, if the .NET Framework 4.5 is already installed.|
|With the runtime redistributable|Yes|Yes, if the .NET Framework 3.5 is already installed|Yes, if the .NET Framework 4 is already installed.|Yes, if the .NET Framework 4.5 is already installed.|

### Install the runtime with Visual Studio or the Microsoft Office Developer Tools for Visual Studio

 When you install the Office developer tools in Visual Studio, the Office extensions for the .NET Framework 4.5 and the .NET Framework 4 are always installed on the development computer. The Office extensions for the .NET Framework 3.5 are installed only if the .NET Framework 3.5 is already present on the development computer. If you install the .NET Framework 3.5 after you install Visual Studio 2013, the runtime automatically installs the Office extensions for the .NET Framework 3.5 the first time you create an Office project that targets the .NET Framework 3.5.

> [!WARNING]
> You cannot create an Office project that targets the .NET Framework 3.5 by using Visual Studio 2013 or later.

 For more information about how to install the Office developer tools, see [How to: Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

### Install the runtime with Office

 When you install Office, the Office extensions for the .NET Framework 3.5 are installed if the .NET Framework 3.5 is already present on the computer. If you install the .NET Framework 3.5 after Office, the runtime automatically installs the Office extensions for the .NET Framework 3.5 the first time that an Office application tries to load a solution that targets the .NET Framework 3.5.

 The Office extensions for the .NET Framework 4 or later are also installed with Office if the corresponding versions of the .NET Framework are already present on the computer.

 To ensure that your users have the necessary extensions to use your application, include the latest version of the Visual Studio 2010 Tools for Office runtime redistributable as a prerequisite for your solution. For more information about prerequisites, see [Office solution prerequisites for deployment](/previous-versions/bb608617(v=vs.110)).

### Install the runtime by using the runtime redistributable

 You can install the runtime by running the Visual Studio 2010 Tools for Office runtime redistributable manually or by including the redistributable as a prerequisite when you deploy an Office solution.

 When you install the runtime by using the Visual Studio 2010 Tools for Office runtime redistributable, the Office extensions for the .NET Framework 3.5 and the Office extensions for the .NET Framework 4 or later are installed if the corresponding versions of the .NET Framework are already present on the computer. If the computer is missing one of these versions of the .NET Framework when the runtime is installed, the Office extensions for the missing version of the .NET Framework are not installed at that time. If you install the missing version of the .NET Framework later, the runtime automatically installs the corresponding Office extensions the next time a solution that requires the extensions is installed (if the runtime was installed with a solution that was deployed by using ClickOnce) or loaded (if the runtime was installed with a solution that was deployed by using Windows Installer).

 For more information about including prerequisites in a ClickOnce solution, see [How to: Install prerequisites on end user computers to run Office solutions](/previous-versions/bb608608(v=vs.110)). For more information about how to install the runtime from the redistributable package manually, see [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md).

## Related content

- [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)
- [Assemblies in the Visual Studio Tools for Office runtime](../vsto/assemblies-in-the-visual-studio-tools-for-office-runtime.md)
