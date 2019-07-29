---
title: "Command-line parameter examples for installation"
description: "Customize these examples to create your own command-line installation of Visual Studio."
ms.date: 03/30/2019
ms.custom: "seodec18"
ms.topic: conceptual
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Command-line parameter examples for Visual Studio installation

To illustrate how to [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md), here are several examples that you can customize to match your needs.

In each example, `vs_enterprise.exe`, `vs_professional.exe` and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper, which is the small (approximately 1MB) file that initiates the download process. If you are using a different edition, substitute the appropriate bootstrapper name.

> [!NOTE]
> All commands require administrative elevation, and a User Account Control prompt will be displayed if the process is not started from an elevated prompt.
>
> [!NOTE]
> You can use the `^` character at the end of a command line to concatenate multiple lines into a single command. Alternatively, you can simply place these lines together onto a single row. In PowerShell, the equivalent is the backtick (`` ` ``) character.

For lists of the workloads and components that you can install by using the command line, see the [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

## Using --installPath

* Install a minimal instance of Visual Studio, with no interactive prompts but progress displayed:

  ```cmd
   vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
  ```

* Update a Visual Studio instance by using the command line, with no interactive prompts but progress displayed:

   ```cmd
   vs_enterprise.exe --update --quiet --wait
   vs_enterprise.exe update --wait --passive --norestart --installPath "C:\installPathVS"
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

## Using --wait

* Use in batch files or scripts to wait for the Visual Studio installer to complete before the next command is executed. For batch files, an `%ERRORLEVEL%` environment variable will contain the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page. Some command utilities require additional parameters to wait for completion and to get the installer's return value. The following is an example of the additional parameters used with the PowerShell script command 'Start-Process':

   ```cmd
   start /wait vs_professional.exe --installPath "C:\VS" --passive --wait > nul
   echo %errorlevel%
   ```

   ```powershell
   $exitCode = Start-Process -FilePath vs_enterprise.exe -ArgumentList "--installPath", "C:\VS", "--passive", "--wait" -Wait -PassThru
   ```

   or

   ```powershell
    $startInfo = New-Object System.Diagnostics.ProcessStartInfo
    $startInfo.FileName = "vs_enterprise.exe"
    $startInfo.Arguments = "--all --quiet --wait"
    $process = New-Object System.Diagnostics.Process
    $process.StartInfo = $startInfo
    $process.Start()
    $process.WaitForExit()
   ```

* The first '--wait' is used by the Visual Studio Installer, and the second '-Wait' is used by 'Start-Process' to wait for completion. The '-PassThru' parameter is used by 'Start-Process' to use the installer's exit code for its return value.

## Using --layout

* Download the Visual Studio core editor (the most minimal Visual Studio configuration). Only include the English language pack:

  ```cmd
   vs_community.exe --layout C:\VS
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor
  ```

* Download the .NET desktop and .NET web workloads along with all recommended components and the GitHub extension. Only include the English language pack:

  ```cmd
   vs_community.exe --layout C:\VS ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.NetWeb ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --add Component.GitHub.VisualStudio ^
   --includeRecommended
  ```

## Using --all

* Start an interactive installation of all workloads and components that are available in the Visual Studio Enterprise edition:

   ```cmd
   vs_enterprise.exe --all
   ```

## Using --includeRecommended

* Install a second, named instance of Visual Studio Professional on a machine with Visual Studio Community edition already installed, with support for Node.js development:

   ```cmd
   vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --includeRecommended --nickname VSforNode
  ```

## Using --remove

::: moniker range="vs-2017"

* Remove the Profiling Tools component from the default installed Visual Studio instance:

  ```cmd
   vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```

::: moniker-end

::: moniker range="vs-2019"

* Remove the Profiling Tools component from the default installed Visual Studio instance:

  ```cmd
   vs_enterprise.exe modify ^
   --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```

::: moniker-end

## Using --path

::: moniker range="vs-2017"

These command-line parameters are **new in 15.7**. For more information about them, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

::: moniker-end

* Using the install, cache, and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache" --path shared="C:\VS\shared"`

* Using only the install and cache paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache"`

* Using only the install and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path shared="C:\VS\shared"`

* Using only the install path:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS"`

## Using export

::: moniker range="vs-2017"

This command-line command is **new in 15.9**. For more information about it, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

::: moniker-end

* Using export to save the selection from an installation:

  ```cmd
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe" export --installPath "C:\VS" --config "C:\.vsconfig"
  ```

* Using export to save custom selection from scratch:

  ```cmd
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe" export --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --config "C:\.vsconfig"
  ```

## Using --config

::: moniker range="vs-2017"

This command-line parameter is **new in 15.9**. For more information about it, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page.

::: moniker-end

* Using --config to install the workloads and components from a previously saved installation configuration file:

  ```cmd
  vs_enterprise.exe --config "C:\.vsconfig" --installPath "C:\VS"
  ```

* Using --config to add workloads and components to an existing installation:

  ```cmd
  vs_enterprise.exe modify --installPath "C:\VS" --config "C:\.vsconfig"
  ```

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
