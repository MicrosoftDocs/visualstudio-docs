---
title: "Disable or move the package cache | Microsoft Docs"
description: "Disable, enable, or move the package cache for Visual Studio deployments."
ms.date: "04/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "cache"
  - "nocache"
helpviewer_keywords: 
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 2429993A-3F0E-41C5-9562-FEA6AE994440
author: "heaths"
ms.author: "heaths"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Disable or move the package cache

The package cache provides a source of installed packages in case you need to repair Visual Studio or other related products in cases
where you have no Internet connection. With some drives or system set ups, however, you may not want to keep all those packages around.
The installer will download them when needed, so if you want to save or recover disk space you can disable or move the package cache.

## Disable the package cache

Before you install, modify, or repair Visual Studio or other products with the new installer, you can start the installer with the
`--nocache` switch to the installer.

```
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" --nocache
```

Any operation you do on any product will remove any existing packages for that product and will avoid saving any packages after they
are installed. If you modify or repair Visual Studio and packages are required, they will be downloaded automatically and removed after
they are installed.

If you want to re-enable the cache, pass `--cache` instead. Only packages that are required will be cached, so if you need to restore
all packages you should repair Visual Studio before you disconnect from your network.

```
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" repair --passive --norestart --cache
```

You can also set the `KeepDownloadedPayloads` [registry policy](set-defaults-for-enterprise-deployments.md) to disable the cache
before you install, modify, or repair Visual Studio.

## Move the package cache

A common system configuration is to have Windows installed on an SSD with a larger hard disk (or more) for development needs, such as source
code, program binaries, and more. If you want to work offline you can instead move the package cache.

Currently, you can only do this if you set the `CachePath` [registry policy](set-defaults-for-enterprise-deployments.md) before you
install, modify, or repair Visual Studio.

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also

 * [Install Visual Studio](install-visual-studio.md)
 * [Set defaults for enterprise deployments](set-defaults-for-enterprise-deployments.md)
 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
