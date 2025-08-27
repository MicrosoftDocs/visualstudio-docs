---
title: Devenv Command-Line Switches for VSPackage Development
description: Learn how developers can automate tasks from the command line when executing devenv.exe, the file that starts the Visual Studio IDE.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- /Setup command line switch
- /ResetSkipPkgs command line switch
- /RootSuffix command line switch
- /SafeMode command line switch
- /Splash command line switch
- command-line switches
- registry, Visual Studio SDK
- command line, switches
- Visual Studio SDK, command-line switches
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Devenv command-line switches for VSPackage development

Visual Studio allows developers to automate tasks from the command line when executing `devenv.exe`, the file that starts the Visual Studio IDE.

 Tasks include:

- Deploying applications in predesigned configurations from outside the IDE.

- Automatically building projects using preset build settings or debug configurations.

- Loading the IDE in specific configurations, all from outside the IDE. You can also customize the IDE upon launch.

## Guidelines for switches

Visual Studio documentation describes the user-level `devenv` command-line switches. For more information, see [Devenv command-line switches](../ide/reference/devenv-command-line-switches.md). The `devenv` tool also supports additional command-line switches that are useful with VSPackage development, deployment, and debugging.

| Command-line switch | Description |
|---------------------| - |
| `/ResetSkipPkgs` | Clears all skip loading options that have been added by users who want to avoid loading problematic VSPackages, then starts Visual Studio. The presence of a SkipLoading tag disables the loading of a VSPackage. Clearing the tag re-enables the loading of the VSPackage.<br /><br /> This switch takes no arguments. |
| `/RootSuffix` | Starts Visual Studio by using an alternate location. The following command is run by the shortcut created by the Visual Studio SDK installer:<br /><br /> `devenv /RootSuffix exp`<br /><br /> In this case, `exp` identifies a location with a particular suffix (for example, `10.0Exp` instead of `10.0`). The experimental instance allows you to debug a VSPackage separately from the instance of Visual Studio that you're using to write code.<br /><br /> This switch can take any string that either identifies a location that you've created by using [CreateExpInstance.exe](../extensibility/internals/createexpinstance-utility.md) or the name of an instance to be created. The name of the instance must be a valid file name. For more information, see [The Experimental Instance](../extensibility/the-experimental-instance.md). |
| `/SafeMode` | Launches Visual Studio in safe mode, loading only the default IDE and services. The `/SafeMode` switch prevents all third-party VSPackages from loading when Visual Studio starts, ensuring stable execution.<br /><br /> This switch takes no arguments. |
| `/Setup` | Forces Visual Studio to merge resource metadata that describes menus, toolbars, and command groups from all available VSPackages. You can only run this command as an administrator. <br /><br /> This switch takes no arguments. The `devenv /Setup` command is typically given as the last step of the installation process. Use of the `/Setup` switch doesn't start the IDE.|
| `/Splash` | Shows the Visual Studio splash screen, as usual, and then shows a message box before showing the main IDE. The message box lets you study the splash screen (for example, to check for a VSPackage product icon).<br /><br /> This switch takes no arguments. |

## See also

- [Add command-line switches](../extensibility/adding-command-line-switches.md)
- [Devenv command-line switches](../ide/reference/devenv-command-line-switches.md)
