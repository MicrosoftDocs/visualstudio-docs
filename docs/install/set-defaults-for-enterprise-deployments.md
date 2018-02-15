---
title: "Set defaults for enterprise deployments of Visual Studio | Microsoft Docs"
description: "Domain policies and other configuration operations for enterprise deployment of Visual Studio."
ms.date: "05/05/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "gpo"
  - "policy"
helpviewer_keywords: 
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 9B7B4608-7A3F-4FF4-BDCE-42D9F7CE6DBA
author: "heaths"
ms.author: "heaths"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Set defaults for enterprise deployments of Visual Studio

You can set registry policies that affect the deployment of Visual Studio. These policies are global for the new installer and affect:

- Where some packages shared with other versions or instances are installed
- Where packages are cached
- Whether all packages are cached

You can set some of these policies using [command-line options](use-command-line-parameters-to-install-visual-studio.md), set registry values on your machine, or even distribute them using Group Policy across an organization.

## Registry keys

There are several locations where you can set enterprise defaults, to enable their control either through Group Policy or directly in the registry. Visual Studio looks sequentially to see if any enterprise policies have been set; as soon as a policy value is discovered in the order below, the remaining keys are ignored.

1. `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\Setup`
2. `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`
3. `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\Setup` (on 64-bit operating systems)

> [!IMPORTANT]
> If you do not set the `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\Setup` key and instead set one of the other keys, you should set both other keys on 64-bit operating systems. This issue is addressed in a future product update.

Some registry values are set automatically the first time they are used if not set already. This practice ensures that subsequent installs use the same values. These values are stored in the second registry key, `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup`.

You can set the following registry values:

| **Name** | **Type** | **Default** | **Description** |
| -------- | -------- | ----------- | --------------- |
| `CachePath` | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramData%\Microsoft\VisualStudio\Packages | The directory where package manifests and, optionally, payloads are stored. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `KeepDownloadedPayloads` | `REG_DWORD` | 1 | Keep package payloads even after they are installed. You can change the value anytime. Disabling the policy removes any cached package payloads for the instance you repair or modify. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `SharedInstallationPath` | `REG_SZ` or `REG_EXPAND_SZ` | %ProgramFiles(x86)%\Microsoft Visual Studio\Shared | The directory where some packages shared across versions of instances of Visual Studio are installed. You can change the value anytime, but that will only affect future installs. Any products already installed to the old location must not be moved or they may not function correctly. |

> [!IMPORTANT]
> If you change the `CachePath` registry policy after any installs you must move the existing package cache to the new location and make sure it's secured so that `SYSTEM` and `Administrators` have Full Control and `Everyone` has Read access.
> Failure to move the existing cache or securing it may cause problems with future installs.

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also

 * [Install Visual Studio](install-visual-studio.md)
 * [Disable or move the package cache](disable-or-move-the-package-cache.md)
 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
