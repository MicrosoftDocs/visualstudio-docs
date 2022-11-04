---
title: Command-line parameter examples for installation
description: Customize these examples to create your own command-line installation of Visual Studio.
ms.date: 11/3/2022
ms.topic: conceptual
ms.assetid: 837F31AA-F121-46e9-9996-F8BCE768E579
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Command-line parameter examples for Visual Studio installation

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

To illustrate how to [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md), here are several examples that you can customize to match your needs.

In each example, `vs_enterprise.exe`, `vs_professional.exe` and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper, which is the small (~1MB) file that initiates the download process. If you're using a different edition, substitute the appropriate bootstrapper name.

All commands require administrative elevation, and a User Account Control prompt will be displayed if the process isn't started from an elevated prompt.

You can use the `^` character at the end of a command line to concatenate multiple lines into a single command. Alternatively, you can place these lines together onto a single row. In PowerShell, the equivalent is the backtick (`` ` ``) character.

For lists of the workloads and components that you can install by using the command line, see the [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

## Install using --installPath

* Install a minimal instance of Visual Studio, with no interactive prompts but progress displayed:

  ```shell
   vs_enterprise.exe --installPath C:\minVS ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
   --passive --norestart
  ```
  
* Install a desktop instance of Visual Studio silently, with the French language pack, returning only when the product is installed.

  ```shell
   vs_enterprise.exe --installPath C:\desktopVS ^
   --addProductLang fr-FR ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --includeRecommended --quiet --wait
  ```

## Update in two steps

* Update a Visual Studio instance via the command line, with no interactive prompts but progress displayed. If the bootstrapper is on the client machine, then you can run this command from the client. Otherwise, you'll need to run this command from the layout. The first command updates the installer, and the second command updates the Visual Studio product.

   ```shell
   vs_enterprise.exe --update --quiet --wait
   vs_enterprise.exe update --wait --passive --norestart --installPath "C:\installPathVS"
   ```

  > [!NOTE]
  > Both commands are advised. The first command updates the Visual Studio Installer. The second command updates the Visual Studio instance. To avoid a User Account Control dialog, run the command prompt as an Administrator.

## Using --wait

* Use `--wait` in batch files or scripts to wait for the Visual Studio installer to complete before the next command is executed. For batch files, an `%ERRORLEVEL%` environment variable will contain the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page. Some command utilities require additional parameters to wait for completion and to get the installer's return value. The following command is an example of the additional parameters used with the PowerShell script command 'Start-Process':

   ```shell
   start /wait vs_professional.exe --installPath "C:\VS" --passive --wait > nul
   echo %errorlevel%
   ```

   ```powershell
   $process = Start-Process -FilePath vs_enterprise.exe -ArgumentList "--installPath", "C:\VS", "--passive", "--wait" -Wait -PassThru
   Write-Output $process.ExitCode 
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

## Using --layout to create a network layout or a local cache

* Create a layout that includes only the Visual Studio core editor (the most minimal Visual Studio configuration) and the English language pack:

  ```shell
   vs_professional.exe --layout C:\VS ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor
  ```

* Create a layout that includes the .NET desktop and .NET web workloads, along with all recommended components, English only.

  ```shell
   vs_professional.exe --layout C:\VS ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.NetWeb ^
   --add Microsoft.VisualStudio.Workload.ManagedDesktop ^
   --includeRecommended
  ```

## Using --all to acquire the entire product

* Start an interactive installation of all workloads and components that are available in the Visual Studio Enterprise edition:

   ```shell
   vs_enterprise.exe --all
   ```

## Using --includeRecommended

* Install a second instance of Visual Studio Professional using a nickname on a machine with Visual Studio Community edition already installed, with support for Node.js development:

   ```shell
   vs_professional.exe --installPath C:\VSforNode ^
   --add Microsoft.VisualStudio.Workload.Node --includeRecommended --nickname VSforNode
  ```

## Using --channelURI
Using the Visual Studio 2022 or later installer, it's possible to [configure where Visual Studio looks for updates](/visualstudio/install/update-visual-studio?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1). The `--channelURI` is otherwise known as the update channel or the source location of updates. The following table gives example values for channelURI and what they mean.

| **Channel Name** | **--channelURI** |
|------------------|------------------|
| Visual Studio 2022 Current channel | `https://aka.ms/vs/17/release/channel` |
| Visual Studio 2022 17.0 LTSC channel | `https://aka.ms/vs/17/release.LTSC.17.0/channel` |
| Visual Studio 2022 Preview channel | `https://aka.ms/vs/17/pre/channel` |
| Visual Studio 2019 Release channel | `https://aka.ms/vs/16/release/channel` |
| Visual Studio 2017 Release channel | `https://aka.ms/vs/15/release/channel` |
| Custom layout - Private Channel | `\\layoutserver\share\path\channelmanifest.json` |

If you choose to use a custom layout as the update channel, then be aware of the following guidelines:
  * the --channelURI must point to the 'channelmanifest.json' file in the custom layout. 
  * Administrators can configure [how the custom layout "Private Channel" is displayed in the Update Settings UI by configuring the client's registry settings](/visualstudio/install/set-defaults-for-enterprise-deployments#configuring-source-location-for-updates). 

## Using --remove

* Remove the Profiling Tools component from the default installed Visual Studio instance:

  ```shell
   vs_enterprise.exe modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```

## Using --removeOos
>[!NOTE]
>This command requires using the VS 2022 version 17.4 or later installer. Follow the guidance here for [how to acquire the latest installer on your client machine](/install/update-visual-studio.md#install-the-latest-and-greatest-installer).

* Modify an installation and remove all components that have transitioned to an out-of-support state from the default installed Visual Studio instance:

  ```shell
   vs_enterprise.exe modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" ^
   --removeOos true ^
   --passive
  ```

* Adjust the update settings to persistently remove all components that have transitioned to an out-of-support state every time the product updates:

  ```shell
  vs_enterprise.exe modifySettings ^
  --channelURI https://aka.ms/vs/17/release.LTSC.17.0/channel ^
  --productID Microsoft.VisualStudio.Product.Enterprise ^
  --newChannelURI \\layoutserver\share\path\channelmanifest.json ^
  --removeOos true ^
  --quiet  
  ```

## Using --path

* Using the install, cache, and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache" --path shared="C:\VS\shared"`

* Using only the install and cache paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache"`

* Using only the install and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path shared="C:\VS\shared"`

* Using only the install path:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS"`

## Using export

* Using export to save the selection from an installation:

  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe" export --installPath "C:\VS" --config "C:\.vsconfig"
  ```

* Using export to save custom selection from scratch:

  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe" export --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --config "C:\.vsconfig"
  ```

## Using --config

* Using --config to install the workloads and components from a previously saved installation configuration file:

  ```shell
  vs_enterprise.exe --config "C:\.vsconfig" --installPath "C:\VS"
  ```

* Using --config to add workloads and components to an existing installation:

  ```shell
  vs_enterprise.exe modify --installPath "C:\VS" --config "C:\.vsconfig"
  ```

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
