---
title: "Uninstall Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
f1_keywords:
  - "uninstalling"
  - "uninstalling visual studio"
  - "uninstall"
  - "uninstall Visual Studio"
ms.assetid: 0e445255-b796-426d-ad93-a4d8e36da2c5
caps.latest.revision: 9
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Uninstall Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [Uninstall Visual Studio](/visualstudio/install/uninstall-visual-studio).

This page walks you through uninstalling Visual Studio 2015, an earlier version of our integrated suite of productivity tools for developers.

## Uninstall Visual Studio by using the "standard" uninstallation method

1. In **Control Panel**, on the **Programs and Features** page, choose the product edition that you want to uninstall, and then choose **Change**.

2. In the Setup wizard, choose **Uninstall**, choose **Yes**, and then follow the remaining instructions in the wizard.

   This standard, or default method will leave some items behind that your first installation of Visual Studio originally installed (for example, the Microsoft .NET Framework, Microsoft Visual C++ Redistributables, Microsoft SQL Server, etc.).   We leave these installed because many other applications depend on them. However, if you want to remove them too, select their entry  in **Programs and Features**, and then remove each individually.

## Uninstall Visual Studio and all other related files (that is, to uninstall almost everything)

1. Locate the Visual Studio .exe file (for example, locate "vs_enterprise.exe").

    > [!NOTE]
    > The file should be in a subfolder of "%ProgramData%\Package Cache", for example: C:\ProgramData\Package Cache\\{37e19555-e88d-4aed-9d42-82d0784d2b79}\vs_enterprise.exe

2. Run the .exe file by using the /uninstall /force command-line parameters.

     For example, run ```vs_enterprise.exe /uninstall /force```, which will remove Visual Studio and most of the core components that are left behind in a default uninstallation. However, it will not remove all of the additional content that Visual Studio add-ons and extensions can install (for example, Visual Studio updates, and other optional components).

    > [!TIP]
    > Alternatively, you can use the "**Total Uninstaller**" tool to remove everything that Visual Studio or updates to Visual Studio might have installed. That is, any version of Visual Studio 2013 or later. To find out more, see the [Visual Studio Uninstaller tool](https://github.com/Microsoft/VisualStudioUninstaller/releases) on GitHub.

## Uninstall Visual Studio in silent or passive modes (that is, to uninstall from source)

1. On the computer where Visual Studio is installed, open the Windows command prompt.

2. Enter the following parameters:

     *DVDRoot* \\<Installation File\> \</quiet&#124;/passive> [/norestart]/uninstall

## Roll back to a previous version or release of  Visual Studio

1. Uninstall Visual Studio by using any of the methods listed in this topic.

   > [!WARNING]
   > Uninstalling  a current release of Visual Studio (or a Visual Studio Update) and then installing a previous release might not work as expected.
   >
   > The outcome depends on the which version  or release of Visual Studio you have  installed, which versions of its components are installed, which products are installed that might have dependencies either the Visual Studio release or its components, and finally, on which earlier Visual Studio version you plan to install or reinstall.  Because of all these variables, a standard uninstall will often leave components behind that might not work with previous Visual Studio versions or releases.
   >
   > Therefore, for best results, we recommend using the [Visual Studio Uninstaller tool](https://github.com/Microsoft/VisualStudioUninstaller/releases).

2. Install or reinstall the earlier version of Visual Studio that you want to use.

   Even if you install a previous version of Visual Studio, the Setup program might still try to use a newer version or release if one is available. For more detailed information, see the [How to: Install a Specific Release of Visual Studio](../install/how-to-install-a-specific-release-of-visual-studio.md) topic.

## See also

- [Install Visual Studio](https://msdn.microsoft.com/library/e2h7fzkw.aspx)