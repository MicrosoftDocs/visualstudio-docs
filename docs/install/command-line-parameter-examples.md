---
title: Command-line parameter examples for installation
description: Customize command-line parameter examples to create your own installation of Visual Studio by setting parameters, such as installPath, wait, all, remove, and more.
ms.date: 11/3/2025
ms.topic: article
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation
---
# Command-line parameter examples for Visual Studio installation

To illustrate how to [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md), here are several examples that you can customize to match your needs.

In each example, `vs_enterprise.exe`, `vs_professional.exe`, and `vs_community.exe` represent the respective edition of the Visual Studio bootstrapper, which is the small (~ 1MB) file that initiates the download process. If you're using a different edition, substitute the appropriate bootstrapper name.

All commands require administrative elevation, and a User Account Control prompt will be displayed if the process isn't started from an elevated prompt.

You can use the `^` character at the end of a command line to concatenate multiple lines into a single command. Alternatively, you can place these lines together onto a single row. In PowerShell, the equivalent is the backtick (`` ` ``) character.

To execute commands in a non-interactive manner, you can use`--passive` or `--quiet`. For more information on these parameters, see the [commands and command-line parameters](use-command-line-parameters-to-install-visual-studio.md#install-update-modify-repair-uninstall-and-export-commands-and-command-line-parameters) page.

For lists of the workloads and components that you can install by using the command line, see the [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

## Install using --installPath and --add alongside the bootstrapper

* Install a minimal instance of Visual Studio, with no interactive prompts, but progress displayed:

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

## Update 

* Update a Visual Studio instance via the command line with progress displayed and no interactive prompts. You can run these series of commands in two steps by using a bootstrapper found on either the client or in a layout. The first command updates the installer on the client, and the second command updates the Visual Studio product. You need to run these commands in an elevated command prompt, because updating the installer requires administrator permissions. The following example simulates updating a client using an evergreen bootstrapper in the layout. 

   ```shell
   \\layoutserver\share\path\vs_enterprise.exe --update --quiet --wait
   \\layoutserver\share\path\vs_enterprise.exe update --wait --passive --norestart --installPath "C:\installPathVS"
   ```
 
  Alternatively, you can also update your Visual Studio instance in one step by using the installer on the client. Note that you can't initiate the installer programmatically from the same directory that the installer resides in.
 
   ```shell
   "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" update --passive --norestart --installPath "C:\installPathVS"
   ```

  [Standard users, if they've been granted appropriate permissions](https://aka.ms/vs/setup/policies), can programmatically execute the update command using the installer, but they aren't allowed to use the `--passive` or `--quiet` switch. 

## Using --wait

* Use `--wait` in batch files or scripts to wait for the initial command to complete before the next command is executed. For batch files, an `%ERRORLEVEL%` environment variable contains the return value of the command, as documented in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page. Some command utilities require other parameters to wait for completion and to get the installer's return value. 
 
  The `--wait` parameter is only supported by the bootstrapper. 

   ```shell
   start /wait vs_professional.exe --installPath "C:\VS" --passive --wait > nul
   echo %errorlevel%
   ```

  The following command is an example of using `--wait` with the PowerShell script command `Start-Process`:

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

* The first `--wait` is used by the Visual Studio bootstrapper, and the second `-Wait` is used by 'Start-Process' to wait for completion. The `-PassThru` parameter is used by `Start-Process` to use the installer's exit code for its return value.

## Using --layout to create a network layout or a local cache

* Create a layout that includes only the Visual Studio core editor (the most minimal Visual Studio configuration) and the English language pack. More layout creation examples can be found on the [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md#configure-the-contents-of-a-layout) page.

  ```shell
   vs_professional.exe --layout "C:\VS" ^
   --lang en-US ^
   --add Microsoft.VisualStudio.Workload.CoreEditor ^
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
Using the [latest installer](update-visual-studio.md#use-the-latest-and-greatest-installer), it's possible to [configure where Visual Studio looks for updates](update-visual-studio.md#configure-source-location-of-updates-1). The `--channelUri` is otherwise known as the update channel or the source location of updates. The following table gives example values for channelId and channelUri and what they mean.

| **Channel Name** | **--channelUri** | [**--channelId**](create-a-network-installation-of-visual-studio.md#ensure-your-layout-is-based-off-of-the-correct-channel) |
|------------------|------------------|-----------------|
| Visual Studio 2026 Stable channel | `https://aka.ms/vs/18/stable/channel` | `VisualStudio.18.Stable` |
| Visual Studio 2026 Insiders channel | `https://aka.ms/vs/18/insiders/channel` | `VisualStudio.18.Insiders` |
| Visual Studio 2022 Current channel | `https://aka.ms/vs/17/release/channel` | `VisualStudio.17.Release` |
| Visual Studio 2022 17.0 LTSC channel | `https://aka.ms/vs/17/release.LTSC.17.0/channel` | `VisualStudio.17.Release.LTSC.17.0` |
| Visual Studio 2022 Preview channel | `https://aka.ms/vs/17/pre/channel` | `VisualStudio.17.Preview` |
| Visual Studio 2019 Release channel | `https://aka.ms/vs/16/release/channel` | `VisualStudio.16.Release` |
| Visual Studio 2017 Release channel | `https://aka.ms/vs/15/release/channel` | `VisualStudio.15.Release` |
| Custom layout - Private Channel | `\\layoutserver\share\path\channelmanifest.json` | `VisualStudio.17.Release` (or whatever the layout was based on) |

If you choose to use a custom layout as the update channel, then be aware of the following guidelines:
  * the `--channelUri` must point to the 'channelmanifest.json' file in the custom layout. 
  * Administrators can configure [how the custom layout "Private Channel" is displayed in the Update Settings UI by configuring the client's registry settings](/visualstudio/install/set-defaults-for-enterprise-deployments#configuring-source-location-for-updates). 

## Using --remove

* Remove the Profiling Tools component from the default installed Visual Studio instance. This example uses the installer already installed on the client machine. [Standard users with appropriate permissions](https://aka.ms/vs/setup/policies) can programmatically execute the modify command using the installer, but they aren't allowed to use the `--passive` or `--quiet` switch. Note that you can't initiate the installer programmatically from the same directory that the installer resides in.

::: moniker range="=visualstudio"
  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\18\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```
::: moniker-end

::: moniker range="<=vs-2022"
  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" ^
   --remove Microsoft.VisualStudio.Component.DiagnosticTools ^
   --passive
  ```
::: moniker-end
  
You can't use `--remove` in the same command as `--layout`. In other words, it's not possible to remove components from a layout.

## Using --removeOos

Using the [latest installer](update-visual-studio.md#use-the-latest-and-greatest-installer), you can modify an installation and remove all [components that have transitioned to an out-of-support state](out-of-support-components.md) from the default installed Visual Studio instance. This example uses the installer already installed on the client machine to configure the removeOos setting. [Standard users, if they've been granted appropriate permissions](https://aka.ms/vs/setup/policies), can programmatically execute the modify command using the installer, but they aren't allowed to use the `--passive` or `--quiet` switch. You can't initiate the installer programmatically from the same directory that the installer resides in.

::: moniker range=">=visualstudio"
  ```shell
   "C:\Program Files (x86)\Microsoft Visual studio\Installer\setup.exe" modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\18\Enterprise" ^
   --removeOos true ^
   --passive
  ```

* Adjust the update settings to persistently remove all components transitioned to an out-of-support state every time the product updates:

  ```shell
  "C:\Program Files (x86)\Microsoft Visual studio\Installer\setup.exe" modify ^
  --channelURI https://aka.ms/vs/18/stable.18.0/channel ^
  --productID Microsoft.VisualStudio.Product.Enterprise ^
  --newChannelURI \\layoutserver\share\path\channelmanifest.json ^
  --removeOos true ^
  --quiet  
  ```
::: moniker-end

::: moniker range="=vs-2022"
  ```shell
   "C:\Program Files (x86)\Microsoft Visual studio\Installer\setup.exe" modify ^
   --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" ^
   --removeOos true ^
   --passive
  ```

* Adjust the update settings to persistently remove all components transitioned to an out-of-support state every time the product updates:

  ```shell
  "C:\Program Files (x86)\Microsoft Visual studio\Installer\setup.exe" modify ^
  --channelURI https://aka.ms/vs/17/release.LTSC.17.0/channel ^
  --productID Microsoft.VisualStudio.Product.Enterprise ^
  --newChannelURI \\layoutserver\share\path\channelmanifest.json ^
  --removeOos true ^
  --quiet  
  ```
::: moniker-end

## Using --path

All of these examples assume you're installing a new product using a bootstrapper. 

* Use the install, cache, and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache" --path shared="C:\VS\shared"`

* Use only the install and cache paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path cache="C:\VS\cache"`

* Use only the install and shared paths:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS" --path shared="C:\VS\shared"`

* Use only the install path:

  `vs_enterprise.exe --add Microsoft.VisualStudio.Workload.CoreEditor --path install="C:\VS"`

## Using export

* Use export to save the selection from an installation. This example uses the installer already installed on the client machine. 

  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" export --installPath "C:\VS" --config "C:\my.vsconfig"
  ```

* Use export to save custom selection from scratch. This example uses the installer already installed on the client machine.

::: moniker range="=visualstudio"
  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" export --channelId VisualStudio.18.Stable --productId Microsoft.VisualStudio.Product.Enterprise --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --config "C:\my.vsconfig"
  ```
::: moniker-end

::: moniker range="=vs-2022"
  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" export --channelId VisualStudio.17.Release --productId Microsoft.VisualStudio.Product.Enterprise --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --config "C:\my.vsconfig"
  ```
::: moniker-end

## Using --config

* Use --config to install the workloads and components from a previously saved installation configuration file:

  ```shell
  vs_enterprise.exe --config "C:\my.vsconfig" --installPath "C:\VS"
  ```

* Use --config to add workloads and components to an existing installation. This example uses the installer already installed on the client machine. [Standard users with appropriate permissions](https://aka.ms/vs/setup/policies) can programmatically execute the modify command using the installer, but they aren't allowed to use the `--passive` or `--quiet` switch. You can't initiate the installer programmatically from the same directory that the installer resides in.

  ```shell
   "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" modify --installPath "C:\VS" --config "C:\my.vsconfig"
  ```
  
* Use --config to configure the contents of a layout:
 
   ```shell
  vs_enterprise.exe --layout C:\layout --config "C:\my.vsconfig" 
  ```

## Using winget

Use the [Windows Package Manager](/windows/package-manager/winget/) "winget" tool to programmatically install or update Visual Studio on your machines along with other packages managed by winget. To customize the installation and specify other workloads and components, you can use winget's `--override` switch alongside winget's `install` command, and pass in an [exported vsconfig file](import-export-installation-configurations.md) like this:

::: moniker range=">=visualstudio"
  ```shell
  winget install --id Microsoft.VisualStudio.Community --override "--passive --config C:\my.vsconfig"
  ```
::: moniker-end
::: moniker range="=vs-2022"
  ```shell
  winget install --id Microsoft.VisualStudio.2022.Community --override "--passive --config C:\my.vsconfig"
  ```
::: moniker-end

You can also use [`winget configure`](/windows/package-manager/configuration/) and pass in a `.yaml` file to modify an existing Visual Studio installation. This approach uses the [Visual Studio PowerShell DSC provider](https://www.powershellgallery.com/packages/Microsoft.VisualStudio.DSC) that is [documented here](https://github.com/microsoft/VisualStudioDSC). 
  
[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
