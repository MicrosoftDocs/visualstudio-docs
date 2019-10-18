---
title: "Finding and Using Extensions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.ExtensionManager"
helpviewer_keywords:
  - "install extensions"
  - "install packages"
  - "managing extensions visual studio"
ms.assetid: 4ca92d93-31b9-47ef-8109-4a429d9e2ca3
caps.latest.revision: 47
author: jillre
ms.author: jillfra
manager: jillfra
---
# Finding and Using Visual Studio Extensions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio extensions are code packages that run inside Visual Studio and provide new or improved Visual Studio features. You can find more information about Visual Studio extensions here: [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

 You can use the **Extensions and Updates** dialog box to install Visual Studio extensions and samples from websites and other locations, and then enable, disable, update, or uninstall them. (**Tools / Extensions and Updates**, or type **Extensions** in the **Quick Launch** window). The dialog box also shows updates for installed samples and extensions. You can also download extensions from websites, or get them from other developers.

> [!NOTE]
> Starting in Visual Studio 2015, extensions hosted on the Visual Studio Gallery will be automatically updated.  You can change this setting through the **Extensions and Updates** dialog.  See the section on **Automatic Extension Updates** below for details.

## Finding Visual Studio Extensions
 You can install extensions from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or the [Sample Gallery](https://code.msdn.microsoft.com/vstudio) on the Microsoft website. Extensions may be controls, samples, templates, tools, or other components that add functionality to Visual Studio. Visual Studio supports extensions in the VSIX package format—these include project templates, item templates, **Toolbox** items, Managed Extension Framework (MEF) components, and VSPackages. You can also download and install MSI-based extensions, but the **Extensions and Updates** dialog box can't enable or disable them. The Visual Studio Gallery contains both VSIX and MSI extensions.

## Installing or Uninstalling Visual Studio Extensions
 In the **Extensions and Updates**, find the extension you want to install. (If you know the name or part of the name of the extension, you can search in the **Search Visual Studio Gallery** window.) Click **Download**, then **Install**. You must restart Visual Studio in order to load the extension.

 If you try to install an extension that has dependencies, the installer verifies whether they're already installed. If they aren't installed, the **Extensions and Updates** dialog box lists the dependencies that must be installed before you can install the extension.

 If you want to stop using an extension, you can either disable it or uninstall it. Disabling an extension keeps it installed but unloaded. You can disable only VSIX extensions; extensions that were installed using an MSI can only be uninstalled. Find the extension and click **Uninstall** or **Disable**. You must restart Visual Studio in order to unload a disabled extension.

## Per-User and Administrative Extensions
 Most extensions are per-user extensions and are installed in the **%LocalAppData%\Microsoft\VisualStudio\\<Visual Studio version\>\Extensions\\** folder. A few extensions are administrative extensions, and are installed in the **\<Visual Studio installation folder>\Common7\IDE\Extensions\\** folder.

 To protect your system against extensions that may contain errors or malicious code, you can restrict per-user extensions to load only when Visual Studio is run with normal user permissions. This means that per-user extensions are disabled when Visual Studio is run with administrative user permissions. To do this, go to the **Extensions and Updates** options page (**Tools / Options**, **Environment**, **Extensions and Updates**, or just type **Extension** in the **Quick Launch** window). Clear the **Load per user extensions when running as administrator** check box, then restart Visual Studio.

## Automatic Extension Updates
 Per-user extensions are automatically updated when a new version is available on the Visual Studio Gallery.  The new version of the extension is detected and installed in the background and on the next restart of Visual Studio, the new version of the extension will be running.

 Only per-user extensions can be automatically updated.  Administrative extensions which are installed for all users will not be updated and you still manually install new versions through the **Extensions and Updates** dialog **Updates** node. You can see which extensions will be automatically updated in the extension’s details pane of **Extensions and Updates** dialog.

 If you wish to disable automatic updates, you can disable the feature for all extensions or only specific extensions.

- To disable automatic updates for all extensions, click the **Change your Extensions and Updates settings** link on the **Extensions and Updates** dialog and uncheck **Automatically update extensions**.

- To disable automatic updates for a specific extension, uncheck the **Automatically update this extension** option in the extension’s details pane on the right side of the **Extensions and Updates** dialog.

> [!NOTE]
> Starting in Visual Studio 2015 Update 2, you can specify (in **Tools / Options / Environment / Extensions and Updates**) whether you want automatic updates for per-user extensions,  all user extensions or both (the default setting).

## Sample Master Copies and Working Copies
 When you install an online sample, the solution is stored in two locations:

- A working copy is stored in the location that you specified in the **New Project** dialog box.

- A separate master copy is stored on your computer.

  You can use the **Extensions and Updates** dialog box to perform these samples-related tasks:

- List the master copies of samples that you have installed.

- Disable or uninstall the master copy of a sample.

- Install Sample Packs, which are collections of samples that relate to a technology or feature.

- Install individual online samples. (You can also do this in the **New Project** dialog box.)

- View update notifications when source code changes are published for installed samples.

- Update the master copy of an installed sample when there is an update notification.

## Installing Without Using the Extensions and Updates Dialog Box
 Extensions that have been packaged in .vsix files may be available in locations other than the Visual Studio Gallery. The **Extensions and Updates** dialog box can't detect these files, but you can install a .vsix file by double-clicking the file, or selecting the file and pressing the ENTER key. After that, just follow the instructions. When the extension is installed, you can use the **Extensions and Updates** dialog box to enable it, disable it, or uninstall it.

## Extension Types Not Supported by the Extensions and Updates Dialog Box
 Visual Studio continues to support extensions that are installed by the Microsoft Installer (MSI) but not through the **Extensions and Updates** dialog box without modification.

> [!TIP]
> If an MSI-based extension includes an extension.vsixmanifest file, the extension will appear in the **Extensions and Updates** dialog box.
