---
title: Configure Visual Studio policies
description: Configure Visual Studio policies with Intune, Group Policy, ADMX templates, or registry settings.
ms.date: 10/29/2026
ms.topic: how-to
f1_keywords:
- gpo
- policy
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: madskristensen
ms.author: madsk


ms.subservice: installation
---
# Configure Visual Studio policies

You can configure certain aspects of Visual Studio's behavior through policies. Some policies apply to an installed instance, while machine-wide policies can apply to all Visual Studio instances on a client. This article brings together Visual Studio deployment, update, feedback, and survey policies and explains how to manage them.

You can configure policies to control:

- Should users without administrator permissions be allowed to update or modify Visual Studio
- Should unsupported components be removed from the machine
- Where some packages shared with other versions or instances are installed
- Where and whether packages are cached
- Should administrator updates be enabled and how they should be applied
- Which update channels are available and how they're presented to the client
- How notifications appear or don't appear

For machine-wide policies, use the [Microsoft Intune settings catalog ↗](/mem/intune/configuration/settings-catalog), deploy the Visual Studio ADMX policies through Group Policy, or configure the documented registry values directly. Use [command-line options](use-command-line-parameters-to-install-visual-studio.md) on the client to control per-instance behavior.

## Choose a policy management method

The Visual Studio ADMX template describes policy settings for management tools. Download the current [Visual Studio Administrative Template (ADMX) ↗](https://aka.ms/vs/admx/details) and check its included categories and policy descriptions before deployment. Microsoft updates the templates periodically.

The Visual Studio policy settings in the ADMX template are machine-wide for all users. They apply to all applicable installed instances, versions, and SKUs of Visual Studio. When a policy applies only to a specific version of Visual Studio, the template calls this out.

<a name="deploying-the-policies"></a>

### Deploy the policies

For cloud-connected environments managed by Microsoft Intune, you have two choices for configuring and deploying Visual Studio policies:

1. Access Visual Studio policies through the [settings catalog ↗](/mem/intune/configuration/settings-catalog). This is the recommended approach.
1. [Import the Visual Studio Administrative Templates (ADMX) ↗](/mem/intune/configuration/administrative-templates-import-custom#add-the-admx-and-adml-files) into your **Devices > Configuration profiles**, and then [create a customized **Configuration profile** ↗](/mem/intune/configuration/administrative-templates-import-custom#create-a-profile-using-your-imported-files) based on the imported ADMX files. Use this option if you need a template setting that isn't available in the settings catalog. The Visual Studio Administrative Templates (ADMX) depend on the [Windows administrative template (Windows.admx) ↗](/mem/intune/configuration/administrative-templates-windows), so ensure you manually import that one too.

For machines within a corporate network, you can use the [Group Policy editor ↗](/previous-versions/windows/it-pro/windows-server-2012-r2-and-2012/dn265982(v=ws.11)) or [Microsoft Endpoint Manager (SCCM) ↗](/mem/configmgr/core/understand/introduction) to deploy Visual Studio policies. To use Group Policy, copy the downloaded `.admx` template to the local `C:\Windows\PolicyDefinitions` folder or your organization's Group Policy Central Store. Copy its matching language `.adml` file into the corresponding language subfolder, such as `en-US`. Then use the Group Policy Management Editor or Local Group Policy Editor to configure the Visual Studio settings and apply the policy to the intended machines. Follow your Windows domain's Central Store procedures when managing domain policies.

You can also set a documented registry value directly when that deployment method is appropriate for your organization. Follow the registry path, data type, precedence, and scope documented for each setting.

Distributing Visual Studio through an endpoint-management tool doesn't automatically configure its policies or administrator-update enrollment.

The Visual Studio ADMX template includes policy categories for Copilot, Dev Tunnels, feedback, installation and updates, Live Share, and privacy. The following inventory covers all 34 policy definitions in the [template and matching English descriptions at revision `0a45fdd` ↗](https://github.com/microsoft/Visual-Studio-Administrative-Templates/tree/0a45fddff18f11cf9570493d6533d1b4e4ec8faf/settingFiles/admx). This article documents installation, update, feedback, and survey settings in detail. For other categories, use the feature-specific guidance rather than applying the Setup registry path to them.

| Category | ADMX policy names | Guidance |
|---|---|---|
| Copilot | `DisableCopilot`, `DisableCopilotForIndividuals`, `DisableAgentMode`, `DisableMCP`, `DisableBringYourOwnKeyNoAuth` | [Admin controls for GitHub Copilot ↗](../ide/visual-studio-github-copilot-admin.md) |
| Dev Tunnels | `DisableVisualStudioDevTunnels` | [Dev Tunnels policy reference ↗](https://aka.ms/devtunnels/vs/admx) |
| Feedback | `DisableFeedbackDialog`, `DisableScreenshotCapture`, `ProductFeedbackDisabled`, `SurveysDisabled` | [Configure feedback and survey policies](#configure-feedback-and-survey-policies) |
| Install and update | `RemoveOutOfSupport`, `CachePath`, `BackgroundDownloadDisabled`, `SharedInstallationPath`, `KeepDownloadedPayloads`, `AdministratorUpdatesEnabled`, `AdministratorUpdatesOptOut`, `AdministratorUpdatesNotifications`, `UpdateConfigurationFile`, `DisableRollback`, `HideAvailableTab`, `AllowStandardUserControl`, `UpdateNotificationsOptOut`, `AvailableTabProducts`, `DisableMigrationDialog` | Registry settings in this article. The `RemoveOutOfSupport` ADMX policy writes the `RemoveOos` registry value. |
| Live Share | `LiveShareDomainName`, `DirectConnectionMode`, `DisableAnonymousGuests`, `GuestApprovalRequired`, `DisableSharedServer`, `DisableReadWriteTerminal`, `DisableChat` | [Live Share policy reference ↗](https://aka.ms/vsls-policies) |
| Privacy | `TelemetryOptIn`, `IntelliCodeRemoteAnalysisDisabled` | [Visual Studio privacy and telemetry policies ↗](https://aka.ms/vs/admx/telemetry) and [IntelliCode privacy ↗](/visualstudio/intellicode/intellicode-privacy) |

## Registry keys

For installation and update policies, Visual Studio checks the following registry locations in order. As soon as Visual Studio finds a policy value, it stops checking the remaining keys. Feedback and survey policies use a separate [Feedback registry path](#configure-feedback-and-survey-policies).

1. `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\Setup`
2. `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`
3. `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\Setup` (on 64-bit operating systems)

Some registry values are set automatically the first time they are used if not set already. This practice ensures that subsequent installs use the same values. These values are stored in the second registry key, `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`.

You can set the following registry values:

## Controlling installation, download, and update behavior
The registry settings in this section control how and where the Visual Studio product is downloaded and installed onto the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**       |
|----------------------------------|-----------------------------|-----------------------------------------------------|----------------------------|
| `AllowStandardUserControl`       | `REG_DWORD`                 | 0  | **Allows users without administrator permissions to manually manage their Visual Studio installations using the Installer UI**: if set to 1, users without administrator permissions can manually update or roll back an update without needing to supply an administrator password. If set to 2, users without administrator permissions can use all functionality in the Visual Studio Installer manually, including **Modify** and **Install** from the **Available** tab. Standard Users cannot run any Visual Studio Installer commands programmatically with the `--passive` or `--quiet` parameters, regardless of what this policy is set to. This policy requires the latest version of the Visual Studio Installer to be installed on the client machine. |
| `CachePath`                      | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\Packages  | **Package manifest and payload cache path**: the Visual Studio Installer enforces a 50 character limit for the path of this storage cache directory. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page   |
| `KeepDownloadedPayloads`         | `REG_DWORD`                 | 1                                                   | **Keep package payloads after installation**:  disabling the policy removes any cached package payloads for the instance you repair or modify. You can change the value anytime. For more information, see [Disable or move the package cache](disable-or-move-the-package-cache.md) page.   |
| `SharedInstallationPath`         | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramFiles(x86)%<br>\Microsoft Visual Studio<br>\Shared  | **Shared installation path**: the directory where some packages shared across versions of instances of Visual Studio are installed. You can change the value anytime, but it will only affect future installs. Any products already installed to the old location must not be moved or they might not function correctly. The Visual Studio Installer enforces a 150 character limit for the path.     |
| `BackgroundDownloadDisabled`     | `REG_DWORD`                 | 0                                                   | **Disable downloading updates automatically**: if set to 1, then setup will be prevented from downloading updates automatically for all installed Visual Studio products. You can change the value anytime.  |
| `RemoveOos` | `REG_DWORD` | 0 | **Remove out-of-support components during updates**: the ADMX policy is named `RemoveOutOfSupport`. Set to `1` to remove out-of-support components from all Visual Studio installations during subsequent updates. Set to `0`, or leave unset, to respect other configuration locations such as command-line options and **Update Settings**. Requires the Visual Studio 2022 version 17.4 Installer or later. |
| `DisableRollback` | `REG_DWORD` | 0 | **Disable rollback**: set to `1` to prevent users from undoing the most recent update, which might contain a security fix. Set to `0`, or leave unset, to allow rollback to the previously installed version. Applies to release instances of Visual Studio 2022 and later. |
| `HideAvailableTab` | `REG_DWORD` | 0 | **Hide the Installer's Available tab**: set to `1` to hide the tab and prevent product installation through that tab. Set to `0`, or leave unset, to show it. This setting doesn't block installation through the command line or bootstrapper. Requires the Visual Studio 2022 version 17.6 Installer or later. |
| `AvailableTabProducts` | `REG_SZ` or `REG_EXPAND_SZ` | Not configured | **Restrict products shown on the Available tab**: specify the product IDs to display, such as `Microsoft.VisualStudio.Product.Professional`. This policy applies only to machines that have the Visual Studio Installer installed but no Visual Studio product installed. It isn't an installation allow list for other routes. |
| `UpdateNotificationsOptOut` | `REG_DWORD` | 0 | **Suppress eligible IDE update notifications**: set to `1` to suppress update notifications for Enterprise and Professional editions on Release or LTSC channels, only when they receive updates from a layout or are enrolled for administrator updates. Set to `0`, or leave unset, to show notifications when an update is detected. This setting doesn't disable updates or administrator-update toast notifications. |
| `DisableMigrationDialog` | `REG_DWORD` | 0 | **Disable the stale-build migration dialog**: set to `1` to hide the dialog prompting Enterprise and Professional users on Stable or LTSC channels to move to the latest version. This policy applies to Visual Studio 2026 and later; it doesn't apply to Insiders or Community. |

> [!IMPORTANT]
> If you change the `CachePath` registry policy after any installations, you must move the existing package cache to the new location and make sure it's secured so that `SYSTEM` and `Administrators` have **Full Control** and that `Everyone` has **Read** access.
> Failure to move the existing cache or securing it might cause problems with future installs.

### Registry-only Installer setting

`DisableSound` is documented separately from the ADMX inventory because it isn't defined in the template revision listed above. Its absence from ADMX doesn't establish that the registry setting is unsupported.

| Name | Type | Default | Description |
|---|---|---|---|
| `DisableSound` | `REG_DWORD` | 0 | Set to `1` to disable Installer audio cues for operation completion and errors. Set to `0`, or leave unset, to allow sounds. See the [Installer sound-setting announcement ↗](https://aka.ms/vs/disablesound). |

## Controlling Administrator Updates

The registry settings in this section control if and how administrator updates are applied to the client machine.

| **Name**                         | **Type**                    | **Default**                                         | **Description**           |
|----------------------------------|-----------------------------|-----------------------------------------------------|---------------------------|
| `AdministratorUpdatesEnabled` | `REG_DWORD` | 0 | **Enable administrator updates**: set to `1` to receive updates through WSUS/Configuration Manager on Active Directory-joined clients. Set to `2` to allow WSUS/Configuration Manager or Microsoft Update/Intune delivery. The Microsoft Update route requires Active Directory- or Microsoft Entra-joined clients enrolled in Windows Update for Business with updates for other Microsoft products enabled. Set to `0`, or leave unset, to block administrator updates. This is a machine-wide policy configured by an administrator. See [Deploy and verify administrator updates](applying-administrator-updates.md). |
| `AdministratorUpdatesNotifications` | `REG_DWORD` | 0 | **Show administrator-update prompts and status**: set to `1` to show Windows toast notifications for update success or failure, diagnostic information, and prompts to close Visual Studio when it blocks an update. These notifications respect the client's Windows toast-notification settings. |
| `AdministratorUpdatesOptOut` | `REG_DWORD`                 | 0                                                   | **Opt out of administrator updates**: indicates that the user does not want to receive administrator updates to Visual Studio. The absence of the registry value, or a set value of 0, means that the Visual Studio user wants to receive administrator updates to Visual Studio. This policy is for the developer user to configure if they have admin permissions on the client machine. <br> <br> The AdministratorUpdatesOptOut key for encoding user preference is prioritized over the AdministratorUpdatesEnabled key, which encodes the IT admin intent. If AdministratorUpdatesOptOut is set to 1, the update is blocked on the client, even if the AdministratorUpdatesEnabled key is also set to 1. This action assumes that IT admins can access and monitor which developers chose to opt out. The two parties can then discuss whose needs are more important. IT admins can always change either key whenever they want.|
| `UpdateConfigurationFile`    | `REG_SZ` or `REG_EXPAND_SZ`  | %ProgramData%<br>\Microsoft<br>\VisualStudio<br>\updates.config | **Custom path to the update configuration file**: the path to the file on the client that can be used to configure Administrative Updates. By default, this file doesn't exist and the policy isn't set. If you choose to add the policy to the client machine and define a custom configuration file location, the Administrator update looks for this file. If the file doesn't exist, the update fails and throws an exception. For more information, see [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update).   |

> [!IMPORTANT]
> Cloud connected client machines that Intune manages must be configured for [Windows Update for Business ↗](/windows/deployment/update/waas-manage-updates-wufb) and opted into the ["Enable Updates for other Microsoft Products" ↗](/windows/client-management/mdm/policy-csp-update#allowmuupdateservice) in order to receive Visual Studio administrator updates through the Windows Update for Business Microsoft Update channel.

## Configuring source location for updates 

<!-- tbs Section needs dev review. Much of info in this section is specific to reg key, not currently monikered. Does it apply at all in Dev18? -->
::: moniker range="=visualstudio"
The settings in this section allow an administrator to customize and control what update channels are available and how they appear to clients in an enterprise organization. For information about what the update settings even are and how they work, refer to the [configure source location of updates](update-visual-studio.md#configure-source-location-of-updates-1) documentation. 
This functionality requires the client to be using the Visual Studio 2022 Installer and the layout to be using a version of the 2019 bootstrapper that shipped on or after November 10, 2021. For guidance, see [how to get the Visual Studio 2022 installer on your client machines via a Visual Studio 2019 layout](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer) documentation.

The keys in this section only apply to the Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup registry path

| **Name**                         | **Type**                    | **Description**                                                |
|----------------------------------|-----------------------------|-----------------------------------------------------|
| `Channels` | `Key` |  Subkey path for storing custom layout channel information. The name of this key is considered the Channel name, and is what shows up in the [Update channel dropdown](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1). The `ChannelURI` value is required to be present under the `Channels` subkey. |
| `DisabledChannels` | `Key` | Subkey path for suppressing channels and preventing them from showing up in the Update Channel dialog. If the channel is defined here (along with the `ChannelURI` value), it is filtered out of the dialog. |
| `ChannelURI` | `REG_SZ` |  The channelURI to either add to list of update channel values by adding to the `Channels` hive, or suppress from the list of update channels by adding to the `DisabledChannels` registry hive. For Microsoft hosted channels, the channelURI is `https://aka.ms/vs/stable/channel` or `https://aka.ms/vs/insiders/channel`.  For layouts, this value needs to point to the layout's ChannelManifest.json. Refer to examples. |
| `Description` | `REG_SZ` |  A two-line custom description of the channel. If you already installed from a layout, then the Update Settings UI defaults to "Private Channel" and you can change it using the Description. |

Some registry file examples that illustrate how an IT Admin may want to customize the [Update Settings UI](/visualstudio/install/update-visual-studio?#configure-source-location-of-updates-1): 

The first registry example can be used in a situation where the client previously installed from a network layout located at `\\vslayoutserver3\vs\18_Enterprise`. As mentioned previously, Visual Studio defaults the channel name for this layout to "Private Channel". Here's how you would customize the channel name and description for this layout.

```example registry file
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels]

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\More meaningful name of my existing layout]
"channelUri"="\\\\vslayoutserver3\\vs\\18_Enterprise\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2026 18.x.Spring.2026 servicing baseline"
```

Here's how to add a few more layout entries for other custom update channels that are available as a source for updates, and also how to suppress the Preview channel from showing up.

```example registry file
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels]

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels] [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Spring 2026 dev toolset] "channelUri"="\\\\newVS18layoutserver\\share\\newVS18layout\\ChannelManifest.json"
"Description"="Dev Tools based on VS 2026 18.x.Spring.2026 servicing baseline" 

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\Channels\Next gen dev tools using VS 2026 toolset]
"channelUri"="\\\\vs18Layoutserver\\share\\2026Enterprise\\ChannelManifest.json"
"Description"="Developer Tools based on the VS 2026 18.0.Winter.2026 LSTC servicing baseline"

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup\DisabledChannels\Preview]
"channelUri"="[https://aka.ms/vs/insiders/channel" ↗](https://aka.ms/vs/insiders/channel%22)
```
::: moniker-end

::: moniker range="<=vs-2022"
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
::: moniker-end

## Controlling notifications in the Visual Studio IDE

As described earlier, Visual Studio checks the location it is installed from, such as a network share or the internet, to see whether any updates are available. When an update is available, Visual Studio notifies the user with a notification icon in the lower right-hand corner of the window.

   ![The notification icon in the Visual Studio IDE](media/vs-2019/notification-bar.png "The notification icon in the Visual Studio IDE")

You can disable the notifications if you don't want end users to be notified of updates. (For example, you might want to disable notifications if you deliver updates through a central software distribution mechanism.)


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

Because Visual Studio [stores registry entries in a private registry](tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance), you can't directly edit the registry in the typical way. However, Visual Studio includes a `vsregedit.exe` utility that you can use to change Visual Studio settings. You can turn off notifications with the following command:

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

## Configure feedback and survey policies

The Visual Studio ADMX template includes four feedback policies. `SurveysDisabled` and `ProductFeedbackDisabled` are machine-wide policies for Visual Studio 2022 version 17.13 or later. `DisableFeedbackDialog` and `DisableScreenshotCapture` are legacy send-a-smile policies that remain in the current template.

Configure these policies through one of the management methods in [Choose a policy management method](#choose-a-policy-management-method). All use `SOFTWARE\Policies\Microsoft\VisualStudio\Feedback`, not the Setup path. The two machine-wide policies use `HKEY_LOCAL_MACHINE`. The two legacy policies have ADMX class `Both`, so the template also supports user configuration under `HKEY_CURRENT_USER`.

| Name | Type | Default | Description |
|---|---|---:|---|
| `SurveysDisabled` | `REG_DWORD` | `0` | Set to `1` to hide product survey requests and links in Visual Studio and the Visual Studio Installer. |
| `ProductFeedbackDisabled` | `REG_DWORD` | `0` | Set to `1` to disable feedback mechanisms in Visual Studio and the Installer, including thumbs up or down, feedback pop-ups, send-a-smile, and information bars without survey links. |
| `DisableFeedbackDialog` | `REG_DWORD` | Not configured | Set to `1` to disable the legacy send-a-smile feature. The template's disabled value is `0`. Supports computer and user configuration. |
| `DisableScreenshotCapture` | `REG_DWORD` | Not configured | Set to `1` to disable screenshot capture in the legacy send-a-smile feature. The template's disabled value is `0`. Supports computer and user configuration. |

Prefer `SurveysDisabled` and `ProductFeedbackDisabled` for the current feedback experience. Don't apply their Visual Studio 2022 version 17.13 requirement to the legacy policies.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

- [Install Visual Studio](install-visual-studio.md)
- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Download the Visual Studio ADMX template ↗](https://aka.ms/vs/admx/details)
- [Applying administrator updates](applying-administrator-updates.md)
- [Disable or move the package cache](disable-or-move-the-package-cache.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
