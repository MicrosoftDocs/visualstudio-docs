---
title: Disable or move the package cache
description: Disable, enable, or move the package cache of installed packages for Visual Studio deployments to save or recover disk space.
ms.date: 11/04/2025
ms.topic: how-to
f1_keywords:
- cache
- nocache
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Disable or move the package cache

The package cache provides a source of installed packages. You need these packages to repair Visual Studio or other related products when there's no internet connection. With some drives or system set ups, however, you might not want to keep all those packages around.
The installer will download them when needed. If you want to save or recover disk space, you can disable or move the package cache.

## Disable the package cache

Before you install, modify, or repair Visual Studio or other products with the new installer, you can start the installer with the
`--nocache` switch to the installer.

```shell
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" --nocache
```

Any operation you do on a product will remove any existing packages for that product and will avoid saving any packages after they're installed. If packages are required to modify or repair Visual Studio, they'll be downloaded automatically and removed after their installation.

If you want to re-enable the cache, pass `--cache` instead. Only packages that are required will be cached. If you need to restore all packages, we recommend you repair Visual Studio before you disconnect from your network.

```shell
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" repair --passive --norestart --cache
```

You can also set the `KeepDownloadedPayloads` [registry policy](configure-policies-for-enterprise-deployments.md) to disable the cache before you install, modify, or repair Visual Studio.

## Move the package cache

A common system configuration is to have Windows installed on an SSD that has a larger hard disk (or more) for development needs, such as source code, program binaries, and more. If you want to work offline, you can move the package cache instead.

Currently, you can do this operation only if you set the `CachePath` [registry policy](configure-policies-for-enterprise-deployments.md) before you install, modify, or repair Visual Studio.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Install Visual Studio](install-visual-studio.md)
* [Configure policies for enterprise deployments](configure-policies-for-enterprise-deployments.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
