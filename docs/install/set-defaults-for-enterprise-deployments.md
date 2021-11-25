---
title: Set defaults for enterprise deployments
description: Learn about domain policies and other configuration operations for enterprise deployments of Visual Studio.
ms.date: 11/23/2021
ms.topic: conceptual
f1_keywords:
- gpo
- policy
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 9B7B4608-7A3F-4FF4-BDCE-42D9F7CE6DBA
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Set defaults for enterprise deployments of Visual Studio

You can set registry policies that affect the deployment and update behavior of Visual Studio. These policies are global on the client machine and affect the following:

- Where some packages shared with other versions or instances are installed.
- Where and whether packages are cached.
- If administrator updates should be enabled and how they should be applied.
- Which update channels are available and how they're presented to the client.
- How notifications appear or don't appear.

You can set these policies by using [command-line options](use-command-line-parameters-to-install-visual-studio.md) on the client machine, by setting registry values directly on the client machine, or by distributing them using Group Policy across an organization.

## Registry keys

There are several locations where you can set enterprise defaults to enable their control either through Group Policy or directly in the registry. Visual Studio looks sequentially to see if any enterprise policies have been set; as soon as a policy value is discovered in the order below, the remaining keys are ignored.

1. `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\Setup`
2. `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`
3. `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\Setup` (on 64-bit operating systems)

Some registry values are set automatically the first time they are used if not set already. This practice ensures that subsequent installs use the same values. These values are stored in the second registry key, `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`.

You can set the following registry values:

## Controlling installation and download behavior
The registry settings in this section control how and where the Visual Studio product is downloaded onto the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**       |
|----------------------------------|-----------------------------|-----------------------------------------------------|----------------------------|
| `CachePath`                      | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\Packages       | The directory where package manifests and, optionally, payloads are stored. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page.   |
| `KeepDownloadedPayloads`         | `REG_DWORD`                 | 1                                                   | Keep package payloads even after they are installed. You can change the value anytime. Disabling the policy removes any cached package payloads for the instance you repair or modify. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page.   |
| `SharedInstallationPath`         | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramFiles(x86)%<br>\Microsoft Visual Studio<br>\Shared  | The directory where some packages shared across versions of instances of Visual Studio are installed. You can change the value anytime, but it will only affect future installs. Any products already installed to the old location must not be moved or they might not function correctly.      |
| `BackgroundDownloadDisabled`     | `REG_DWORD`                 | 0                                                   | Prevent setup from downloading updates automatically for all installed Visual Studio products. You can change the value anytime.    |

> [!IMPORTANT]
> If you change the `CachePath` registry policy after any installations, you must move the existing package cache to the new location and make sure it's secured so that `SYSTEM` and `Administrators` have **Full Control** and that `Everyone` has **Read** access.
> Failure to move the existing cache or securing it might cause problems with future installs.


## Controlling Administrator Updates
::: moniker range="vs-2017"

The registry settings in this section control if and how administrator updates are applied to the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**           |
|----------------------------------|-----------------------------|-----------------------------------------------------|---------------------------|
| `AdministratorUpdatesEnabled`    | `REG_DWORD`                 | 0                                                   | Allows administrator updates to be applied to the client computer. If this value is missing or is set to 0, administrator updates will be blocked. This value is for administrative use. For more information, see [Enabling Administrator Updates](enabling-administrator-updates.md). |
| `AdministratorUpdatesOptOut`     | `REG_DWORD`                 | 0                                                   | Indicates that the user does not want to receive administrator updates to Visual Studio. The absence of the registry value, or a set value of 0, means that the Visual Studio user wants to receive administrator updates to Visual Studio. This is for developer user (if they have admin permissions on the client machine). For more information, see [Applying administrator updates](../install/applying-administrator-updates.md#understanding-configuration-options). |
| `UpdateConfigurationFile`        | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\updates.config | The file path for configuring Administrative Updates. For more information, see [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update).   |    

::: moniker-end

::: moniker range="vs-2019"

The registry settings in this section control if and how administrator updates are applied to the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**           |
|----------------------------------|-----------------------------|-----------------------------------------------------|---------------------------|
| `AdministratorUpdatesEnabled`    | `REG_DWORD`                 | 0                                                   | Allows administrator updates to be applied to the client computer. If this value is missing or is set to 0, administrator updates will be blocked. This value is for administrative use. For more information, see [Enabling Administrator Updates](enabling-administrator-updates.md). |
| `AdministratorUpdatesOptOut`     | `REG_DWORD`                 | 0                                                   | Indicates that the user does not want to receive administrator updates to Visual Studio. The absence of the registry value, or a set value of 0, means that the Visual Studio user wants to receive administrator updates to Visual Studio. This is for developer user (if they have admin permissions on the client machine). For more information, see [Applying administrator updates](../install/applying-administrator-updates.md#understanding-configuration-options). |
| `UpdateConfigurationFile`        | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\updates.config | The file path for configuring Administrative Updates. For more information, see [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update).   |                        
| `BaselineStickinessVersions2019` | `REG_SZ` or `REG_EXPAND_SZ` | `16.7.0`                                            | The servicing baseline minor version that the client should remain on. For more information, see [Applying administrator updates](../install/applying-administrator-updates.md#understanding-configuration-options) page. |

::: moniker-end

::: moniker range=">=vs-2022"

The registry settings in this section control if and how administrator updates are applied to the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**           |
|----------------------------------|-----------------------------|-----------------------------------------------------|---------------------------|
| `AdministratorUpdatesEnabled`    | `REG_DWORD`                 | 0                                                   | Allows administrator updates to be applied to the client computer. If this value is missing or is set to 0, administrator updates will be blocked. This value is for administrative use. For more information, see [Enabling Administrator Updates](enabling-administrator-updates.md). |
| `AdministratorUpdatesOptOut`     | `REG_DWORD`                 | 0                                                   | Indicates that the user does not want to receive administrator updates to Visual Studio. The absence of the registry value, or a set value of 0, means that the Visual Studio user wants to receive administrator updates to Visual Studio. This is for developer user (if they have admin permissions on the client machine). For more information, see [Applying administrator updates](../install/applying-administrator-updates.md#understanding-configuration-options). |
| `UpdateConfigurationFile`        | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\updates.config | The file path for configuring Administrative Updates. For more information, see [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update).   |    

::: moniker-end

::: moniker range=">=vs-2019"

## Configuring source location for updates 

The settings in this section allow an administrator to customize and control what update channels are available and how they appear to clients in an enterprise organization. For information about what the update settings even are and how they work, refer to the [configure source location of updates](update-visual-studio.md#configure-source-location-of-updates-1) documentation. 
This functionality requires the client to be using the Visual Studio 2022 Installer and the layout to be using a version of the 2019 bootstrapper that shipped on or after November 10, 2021. Guidance for how to enable this is available at the [how to get the Visual Studio 2022 installer on your client machines via a Visual Studio 2019 layout](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-use-the-latest-installer) documentation.

The keys in this section only apply to the Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\ registry path

| **Name**                         | **Type**                    | **Description**                                                |
|----------------------------------|-----------------------------|-----------------------------------------------------|
| `Channels` | `Key` |  Key path for storing custom layout channel information. The value of this key is consider the Channel name, and is what shows up in the [Update channel dropdown](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1). |
| `DisabledChannels` | `Key` | Key path for suppressing channels and preventing them from showing up in the Update Channel dialog. If the channel is defined here, it will be filtered out of the dialog. |
| `ChannelURI` | `REG_SZ` |  The channelURI to either add to list of update channel values by adding to the `Channels` hive, or suppress from the list of update channels by adding to the `DisabledChannels` registry hive. For Microsoft hosted channels, the channelURI is "https://aka.ms/vs/16/release/channel" or "https://aka.ms/vs/16/pre/channel".  For layouts, this value needs to point to the layout's ChannelManifest.json. Refer to examples below. |
| `Description` | `REG_SZ` |  A two-line custom description of the channel. If you've already installed from a layout, then the Update Settings UI defaults to "Private Channel" and you can change it using this Description. |

The example registry file below illustrates how to add a few layout entries for custom update channels in the [Update Settings UI](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1), and also how to suppress the Preview channel from showing up.

```example registry file
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels]

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\More meaningful name of my existing layout]
"channelUri"="\\\\vslayoutserver3\\vs\\2019_Enterprise\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2019 16.9.Spring.2020 servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Spring 2021 dev toolset]
"channelUri"="\\\\new2019layoutserver\\share\\new2019layout\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2019 16.11.Spring.2021 servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Next gen dev tools using VS 2022 toolset]
"channelUri"="\\\\vs2022Layoutserver\\share\\2022Enterprise\\ChannelManifest.json"
"Description"="Developer Tools based on the VS 2022 17.0.Winter.2021 LSTC servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\DisabledChannels\Preview]
"channelUri"="https://aka.ms/vs/16/pre/channel"
```

::: moniker-end

## Controlling notifications in the Visual Studio IDE

::: moniker range="vs-2017"

As described earlier, Visual Studio checks the location from which it has been installed, such as a network share or the internet, to see whether any updates are available. When an update is available, Visual Studio notifies the user with a notification flag in the top right-hand corner of the window.

   ![Notification flag for updates](media/notification-flag.png)

::: moniker-end

::: moniker range=">=vs-2019"

As described earlier, Visual Studio checks the location from which it has been installed, such as a network share or the internet, to see whether any updates are available. When an update is available, Visual Studio notifies the user with a notification icon in the lower right-hand corner of the window.

   ![The notification icon in the Visual Studio IDE](media/vs-2019/notification-bar.png "The notification icon in the Visual Studio IDE")

::: moniker-end

You can disable the notifications if you don't want end users to be notified of updates. (For example, you might want to disable notifications if you deliver updates through a central software distribution mechanism.)

::: moniker range="vs-2017"

Because Visual Studio 2017 [stores registry entries in a private registry](tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance), you can't directly edit the registry in the typical way. However, Visual Studio includes a `vsregedit.exe` utility that you can use to change Visual Studio settings. You can turn off notifications with the following command:

```shell
vsregedit.exe set "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 0
```

You can turn notifications back on with the following command:

```shell
vsregedit.exe set "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 1
```

To get back to default behavior, you can also delete the value with the following command:

```shell
vsregedit.exe remove "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override
```

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio won't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (this is the condition by default), the previous command will indicate it failed to read the value. If you set the value, then the previous command will reflect the value in the Visual Studio configuration (it will indicate either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

::: moniker range="vs-2019"

Because Visual Studio 2019 [stores registry entries in a private registry](tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance), you can't directly edit the registry in the typical way. However, Visual Studio includes a `vsregedit.exe` utility that you can use to change Visual Studio settings. You can turn off notifications with the following command:

```shell
vsregedit.exe set "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 0
```

You can turn notifications back on with the following command:

```shell
vsregedit.exe set "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 1
```

To get back to default behavior, you can also delete the value with the following command:

```shell
vsregedit.exe remove "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override
```

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio won't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (this is the condition by default), the previous command will indicate it failed to read the value. If you set the value, then the previous command will reflect the value in the Visual Studio configuration (it will indicate either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

::: moniker range=">=vs-2022"

Because Visual Studio 2022 [stores registry entries in a private registry](tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance), you can't directly edit the registry in the typical way. However, Visual Studio includes a `vsregedit.exe` utility that you can use to change Visual Studio settings. You can turn off notifications with the following command:

```shell
vsregedit.exe set "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 0
```

You can turn notifications back on with the following command:

```shell
vsregedit.exe set "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 1
```

To get back to default behavior, you can also delete the value with the following command:

```shell
vsregedit.exe remove "c:\Program Files\Microsoft Visual Studio\2022\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override
```

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio won't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "c:\Program Files\Microsoft Visual Studio\2022\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (this is the condition by default), the previous command will indicate it failed to read the value. If you set the value, then the previous command will reflect the value in the Visual Studio configuration (it will indicate either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

(Make sure to replace the directory to match the installed instance that you want to edit.)

> [!TIP]
> Use [vswhere.exe](tools-for-managing-visual-studio-instances.md#detecting-existing-visual-studio-instances) to find a specific instance of Visual Studio on a client workstation.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Install Visual Studio](install-visual-studio.md)
- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Applying administrator updates](applying-administrator-updates.md)
- [Disable or move the package cache](disable-or-move-the-package-cache.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
