---
title: Configure policies for enterprise deployments
description: Configure domain policies, related registry keys, and other configuration operations for enterprise deployments of Visual Studio.
ms.date: 11/04/2025
ms.topic: how-to
f1_keywords:
- gpo
- policy
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Configure policies for enterprise deployments of Visual Studio

You can configure certain aspects of Visual Studio's deployment and update behavior via policies. Some of these configurations are particular to an installed instance of Visual Studio, and some of the configurations can be global and apply to all Visual Studio instances on the client machine. You can configure the following:

- Should users without administrator permissions be allowed to update or modify Visual Studio
- Should unsupported components be removed from the machine
- Where some packages shared with other versions or instances are installed
- Where and whether packages are cached
- Should administrator updates be enabled and how they should be applied
- Which update channels are available and how they're presented to the client
- How notifications appear or don't appear

Configure and deploy global machine wide policies across your organization by using the [Microsoft Intune settings catalog](/mem/intune/configuration/settings-catalog) or by importing [Visual Studio Administrative Templates (ADMX)](administrative-templates.md) into legacy tools like Group Policy editor. You can also set registry values directly on the client machine. Per instance behaviors, are typically controlled by using [command-line options](use-command-line-parameters-to-install-visual-studio.md) on the client machine.

## Registry keys

There are several locations in the registry where you can set these policies. Visual Studio looks sequentially, in the following order, to see if any enterprise policies are set. As soon as a policy value is discovered, the remaining keys are ignored.  

1. `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\Setup`
2. `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`
3. `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\Setup` (on 64-bit operating systems)

Some registry values are set automatically the first time they are used if not set already. This practice ensures that subsequent installs use the same values. These values are stored in the second registry key, `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`.

You can set the following registry values:

## Controlling installation, download, and update behavior
The registry settings in this section control how and where the Visual Studio product is downloaded and installed onto the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**       |
|----------------------------------|-----------------------------|-----------------------------------------------------|----------------------------|
| `AllowStandardUserControl`       | `REG_DWORD`                 | 0  | **Allows users without administrator permissions to manually manage their Visual Studio installations using the Installer UI**: if set to 1, users without administrator permissions can manually update or rollback an update without needing to supply an administrator password. If set to 2, users without administrator permissions can use all functionality in the Visual Studio Installer manually, including **Modify** and **Install** from the **Available** tab. Standard Users cannot run any Visual Studio Installer commands programmatically with the `--passive` or `--quiet` parameters, regardless of what this policy is set to. This policy requires the latest version of the Visual Studio Installer to be installed on the client machine. |
| `CachePath`                      | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\Packages  | **Package manifest and payload cache path**: the Visual Studio Installer enforces a 50 character limit for the path of this storage cache directory. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page   |
| `KeepDownloadedPayloads`         | `REG_DWORD`                 | 1                                                   | **Keep package payloads after installation**:  disabling the policy removes any cached package payloads for the instance you repair or modify. You can change the value anytime. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page.   |
| `SharedInstallationPath`         | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramFiles(x86)%<br>\Microsoft Visual Studio<br>\Shared  | **Shared installation path**: the directory where some packages shared across versions of instances of Visual Studio are installed. You can change the value anytime, but it will only affect future installs. Any products already installed to the old location must not be moved or they might not function correctly. The Visual Studio Installer enforces a 150 character limit for the path.     |
| `BackgroundDownloadDisabled`     | `REG_DWORD`                 | 0                                                   | **Disable downloading updates automatically**: if set to 1, then setup will be prevented from downloading updates automatically for all installed Visual Studio products. You can change the value anytime.  |
| `RemoveOos`                      | `REG_DWORD`                 | 0                                                   | **Remove out-of-support components during updates**: if set to 1, then the Visual Studio Installer will remove all installed components transitioned to an out-of-support state during all subsequent updates. If set to 0 or missing entirely, then the `removeOos` behavior respects other locations where this setting can be configured, such as commandline parameter or the **Update Settings** dialog. For more information, see [Remove out-of-support components blog post](https://aka.ms/vs/removeoos/blog). This functionality requires the latest version of Visual Studio to be installed on the client machine. |
| `DisableRollback`                | `REG_DWORD`                 | 0                                                   | **Disable the ability to rollback or undo a Visual Studio update**: if set to 1, then users will be prevented from accessing the rollback capability, which prevents Visual Studio from reverting the most recent update, which may contain a security fix. If set to 0 or missing entirely, then users are able to access the rollback feature in Visual Studio, and undo an update and rollback their Visual Studio instances to the previously installed version. For more information, see the [Rollback blog post](https://aka.ms/vs/rollback).|
| `HideAvailableTab`               | `REG_DWORD`                 | 0                                                   | **Hide the installer's Available tab**:  if set to 1, then administrators are able to hide the installer's **Available** tab, which can prevent users within the organization from accidentally installing the wrong product. |
| `DisableSound`                   | `REG_DWORD`                 | 0                                                   | **Disable sounds in the installer**: if set to 1, then users are able to disable sounds in the Visual Studio Installer, which will prevent any audio cue when an installer operation is done or when there is an error. Installer operations include install, update, modify, and many other operations done by the installer or any error dialogs while trying the requested operation. If set to 0 or missing entirely, then users are able to re-enable sounds in the installer. For more information, see the [DisableSound blog post](https://aka.ms/vs/disablesound). |

> [!IMPORTANT]
> If you change the `CachePath` registry policy after any installations, you must move the existing package cache to the new location and make sure it's secured so that `SYSTEM` and `Administrators` have **Full Control** and that `Everyone` has **Read** access.
> Failure to move the existing cache or securing it might cause problems with future installs.

## Controlling Administrator Updates

The registry settings in this section control if and how administrator updates are applied to the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**           |
|----------------------------------|-----------------------------|-----------------------------------------------------|---------------------------|
| `AdministratorUpdatesEnabled`| `REG_DWORD`                 | 0                                                   | **Enable administrator updates**: allows administrator updates to be applied to the client computer. If this value is missing or is set to 0, administrator updates are blocked. A value of 1 makes the client machine available for updates deployed through the WSUS/SCCM channel. The recommended value of **2** makes the client machine available to receive updates deployed through either the WSUS/SCCM channel or the Windows Update for Business/Intune/Microsoft Endpoint manager channel. This registry key is for the administrator user. For more information, see [Enabling Administrator Updates](enabling-administrator-updates.md). |
| `AdministratorUpdatesNotifications`| `REG_DWORD`           | 0                                                   | **Enables admins to notify users to close Visual Studio to unblock the administrator update**: If Visual Studio is open or in use, then the administrator update fails to apply. By setting this registry key, the administrator can cause a Windows toast notification prompt that prompts the user to close Visual Studio and save their work so that the pending update can apply. This registry key is for the administrator user. For more information, refer to the [blog post announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-17-8-now-available/#administrators-can-prompt-users-to-close-to-unblock-updates). |
| `AdministratorUpdatesOptOut` | `REG_DWORD`                 | 0                                                   | **Opt out of administrator updates**: indicates that the user does not want to receive administrator updates to Visual Studio. The absence of the registry value, or a set value of 0, means that the Visual Studio user wants to receive administrator updates to Visual Studio. This policy is for the developer user to configure if they have admin permissions on the client machine. <br> <br> The AdministratorUpdatesOptOut key for encoding user preference is prioritized over the AdministratorUpdatesEnabled key, which encodes the IT admin intent. If AdministratorUpdatesOptOut is set to 1, the update is blocked on the client, even if the AdministratorUpdatesEnabled key is also set to 1. This action assumes that IT admins can access and monitor which developers chose to opt out. The two parties can then discuss whose needs are more important. IT admins can always change either key whenever they want.|
| `UpdateConfigurationFile`    | `REG_SZ` or `REG_EXPAND_SZ`  | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\updates.config | **Custom path to the update configuration file**: the path to the file on the client that can be used to configure Administrative Updates. By default, this file doesn't exist and the policy isn't set. If you choose to add the policy to the client machine and define a custom configuration file location, then the Administrator update will look for this file. If the file doesn’t exist, then an exception is thrown and the update fails. For more information, see [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update).   |    

> [!IMPORTANT]
> Cloud connected client machines that are managed by Intune must be configured for [Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb) and opted into the ["Enable Updates for other Microsoft Products"](/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice) in order to receive Visual Studio administrator updates through the Windows Update for Business Microsoft Update channel.

## Configuring source location for updates 

<!-- tbs Section needs dev review. Much of info in this section is specific to reg key, not currently monikered. Does it apply at all in Dev18? -->
The settings in this section allow an administrator to customize and control what update channels are available and how they appear to clients in an enterprise organization. For information about what the update settings even are and how they work, refer to the [configure source location of updates](update-visual-studio.md#configure-source-location-of-updates-1) documentation. 
This functionality requires the client to be using the Visual Studio 2022 Installer and the layout to be using a version of the 2019 bootstrapper that shipped on or after November 10, 2021. For guidance, see [how to get the Visual Studio 2022 installer on your client machines via a Visual Studio 2019 layout](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer) documentation.

The keys in this section only apply to the Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup registry path

| **Name**                         | **Type**                    | **Description**                                                |
|----------------------------------|-----------------------------|-----------------------------------------------------|
| `Channels` | `Key` |  Subkey path for storing custom layout channel information. The name of this key is considered the Channel name, and is what shows up in the [Update channel dropdown](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1). The `ChannelURI` value is required to be present under the `Channels` subkey. |
| `DisabledChannels` | `Key` | Subkey path for suppressing channels and preventing them from showing up in the Update Channel dialog. If the channel is defined here (along with the `ChannelURI` value), it is filtered out of the dialog. |
| `ChannelURI` | `REG_SZ` |  The channelURI to either add to list of update channel values by adding to the `Channels` hive, or suppress from the list of update channels by adding to the `DisabledChannels` registry hive. For Microsoft hosted channels, the channelURI is `https://aka.ms/vs/16/release/channel` or `https://aka.ms/vs/16/pre/channel`.  For layouts, this value needs to point to the layout's ChannelManifest.json. Refer to examples. |
| `Description` | `REG_SZ` |  A two-line custom description of the channel. If you already installed from a layout, then the Update Settings UI defaults to "Private Channel" and you can change it using the Description. |

Some registry file examples that illustrate how an IT Admin may want to customize the [Update Settings UI](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1): 

The first registry example can be used in a situation where the client previously installed from a network layout located at `\\vslayoutserver3\vs\2019_Enterprise`. As mentioned previously, Visual Studio defaults the channel name for this layout to "Private Channel". Here's how you would customize the channel name and description for this layout.

```example registry file
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels]

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\More meaningful name of my existing layout]
"channelUri"="\\\\vslayoutserver3\\vs\\2019_Enterprise\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2019 16.9.Spring.2020 servicing baseline"
```

Here's how to add a few more layout entries for other custom update channels that are available as a source for updates, and also how to suppress the Preview channel from showing up.

```example registry file
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels]

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Spring 2021 dev toolset]
"channelUri"="\\\\new2019layoutserver\\share\\new2019layout\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2019 16.11.Spring.2021 servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Next gen dev tools using VS 2022 toolset]
"channelUri"="\\\\vs2022Layoutserver\\share\\2022Enterprise\\ChannelManifest.json"
"Description"="Developer Tools based on the VS 2022 17.0.Winter.2021 LSTC servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\DisabledChannels\Preview]
"channelUri"="https://aka.ms/vs/16/pre/channel"
```

## Controlling notifications in the Visual Studio IDE

As described earlier, Visual Studio checks the location it is installed from, such as a network share or the internet, to see whether any updates are available. When an update is available, Visual Studio notifies the user with a notification icon in the lower right-hand corner of the window.

   ![The notification icon in the Visual Studio IDE](media/vs-2019/notification-bar.png "The notification icon in the Visual Studio IDE")

You can disable the notifications if you don't want end users to be notified of updates. (For example, you might want to disable notifications if you deliver updates through a central software distribution mechanism.)

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

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio don't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (default condition), the previous command indicates it failed to read the value. If you set the value, then the previous command reflects the value in the Visual Studio configuration (it indicates either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

::: moniker range="=vs-2022"

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

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio don't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "c:\Program Files\Microsoft Visual Studio\2022\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (default condition), the previous command indicates it failed to read the value. If you set the value, then the previous command reflects the value in the Visual Studio configuration (it indicates either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

::: moniker range="=visualstudio"

Because Visual Studio 2026 [stores registry entries in a private registry](tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance), you can't directly edit the registry in the typical way. However, Visual Studio includes a `vsregedit.exe` utility that you can use to change Visual Studio settings. You can turn off notifications with the following command:

```shell
vsregedit.exe set "C:\Program Files\Microsoft Visual Studio\18\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 0
```

You can turn notifications back on with the following command:

```shell
vsregedit.exe set "C:\Program Files\Microsoft Visual Studio\18\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword 1
```

To get back to default behavior, you can also delete the value with the following command:

```shell
vsregedit.exe remove "c:\Program Files\Microsoft Visual Studio\18\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override
```

After you run the command to change Visual Studio settings, start Visual Studio. Any already-running instances of Visual Studio don't change behavior until Visual Studio is shut down and restarted. As another option, you can restart the computer to make sure the setting takes effect.

You can confirm the setting with the following command:

```shell
vsregedit.exe read "c:\Program Files\Microsoft Visual Studio\18\Enterprise" HKCU ExtensionManager AutomaticallyCheckForUpdates2Override dword
```

If the value doesn’t exist (default condition), the previous command indicates it failed to read the value. If you set the value, then the previous command reflects the value in the Visual Studio configuration (it indicates either 0 or 1, or whatever value it is set to – only 0 or 1 are expected).

::: moniker-end

(Make sure to replace the directory to match the installed instance that you want to edit.)

> [!TIP]
> Use [vswhere.exe](tools-for-managing-visual-studio-instances.md#detecting-existing-visual-studio-instances) to find a specific instance of Visual Studio on a client workstation.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

- [Install Visual Studio](install-visual-studio.md)
- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Applying administrator updates](applying-administrator-updates.md)
- [Disable or move the package cache](disable-or-move-the-package-cache.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
