---
title: "Command-line parameter examples for Visual Studio installation"
description: "Customize these examples to create your own command-line installation of Visual Studio."
ms.date: 05/07/2018
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Command-line parameter examples for Visual Studio 2017 installation

To illustrate how to [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md), here are several examples that you can customize to match your needs.

In each example, `vs_enterprise.exe`, `vs_professional.exe` and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper, which is the small (approximately 1MB) file that initiates the download process. If you are using a different edition, substitute the appropriate bootstrapper name.

> [!NOTE]
> All commands require administrative elevation, and a User Account Control prompt will be displayed if the process is not started from an elevated prompt.
>
> [!NOTE]
>  You can use the `^` character at the end of a command line to concatenate multiple lines into a single command. Alternatively, you can simply place these lines together onto a single row. In PowerShell, the equivalent is the backtick (`` ` ``) character.

## Using --installPath

* Install a minimal instance of Visual Studio, with no interactive prompts but progress displayed:

  ```cmd
  vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
  ```

* Update a Visual Studio instance by using the command line, with no interactive prompts but progress displayed:

  ```cmd
  vs_enterprise.exe update --passive --installpath "C:\installPathVS"
  ```

  > [!NOTE]
  > Both commands are required. The first command updates the Visual Studio Installer. The second command updates the Visual Studio instance. To avoid a User Account Control dialog, run the command prompt as an Administrator.

* Install a desktop instance of Visual Studio silently, with the French language pack, returning only when the product is installed.

  ```cmd
  vs_enterprise.exe --installPath C:\desktopVS ^
   --addProductLang fr-FR ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --includeRecommended --quiet --wait
  ```

  > [!NOTE]
  > The `--wait` parameter is designed for use in a batch file. In a batch file, execution of the next command will not continue until the installation has completed. The `%ERRORLEVEL%` environment variable will contain the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

## Using --layout

* Download the Visual Studio core editor (the most minimal Visual Studio configuration). Only include the English language pack:

  ```cmd
  vs_community.exe --layout C:\VS2017
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor
  ```

* Download the .NET desktop and .NET web workloads along with all recommended components and the GitHub extension. Only include the English language pack:

  ```cmd
  vs_community.exe --layout C:\VS2017 ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.NetWeb ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --add Component.GitHub.VisualStudio ^
   --includeRecommended
  ```

## Using --includeRecommended

* Start an interactive installation of all workloads and components that are available in the Visual Studio 2017 Enterprise edition:

  ```cmd
  vs_enterprise.exe --all --includeRecommended --includeOptional
  ```

* Install a second, named instance of Visual Studio 2017 Professional on a machine with Visual Studio 2017 Community edition already installed, with support for Node.js development:

  ```cmd
  vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --includeRecommended --nickname VSforNode
  ```

## Using --remove

* Remove the Profiling Tools component from the default installed Visual Studio instance:

  ```cmd
  vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```

## Using --path

These command-line parameters are **new in 15.7**. For more information about them, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

* Using the install, cache, and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache" --path shared="C:\VS\shared"`

* Using only the install and cache paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache"`

* Using only the install and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path shared="C:\VS\shared"`

* Using only the install path:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS"`

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
