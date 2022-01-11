---
title: Disable or move the package cache
description: Learn how to disable, enable, or move the package cache for Visual Studio deployments.
ms.date: 04/14/2017
ms.topic: conceptual
f1_keywords:
- cache
- nocache
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 2429993A-3F0E-41C5-9562-FEA6AE994440
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Disable or move the package cache

The package cache provides a source of installed packages in case you need to repair Visual Studio or other related products in cases
where you have no Internet connection. With some drives or system set ups, however, you might not want to keep all those packages around.
The installer will download them when needed, so if you want to save or recover disk space, you can disable or move the package cache.

## Disable the package cache

Before you install, modify, or repair Visual Studio or other products with the new installer, you can start the installer with the
`--nocache` switch to the installer.

```shell
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" --nocache
```

Any operation you do on any product will remove any existing packages for that product and will avoid saving any packages after they
are installed. If you modify or repair Visual Studio and packages are required, they will be downloaded automatically and removed after
they are installed.

If you want to re-enable the cache, pass `--cache` instead. Only packages that are required will be cached, so if you need to restore
all packages, you should repair Visual Studio before you disconnect from your network.

```shell
"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vs_installer.exe" repair --passive --norestart --cache
```

You can also set the `KeepDownloadedPayloads` [registry policy](set-defaults-for-enterprise-deployments.md) to disable the cache
before you install, modify, or repair Visual Studio.

## Move the package cache

A common system configuration is to have Windows installed on an SSD with a larger hard disk (or more) for development needs, such as source
code, program binaries, and more. If you want to work offline, you can move the package cache instead.

Currently, you can do this only if you set the `CachePath` [registry policy](set-defaults-for-enterprise-deployments.md) before you
install, modify, or repair Visual Studio.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Set defaults for enterprise deployments](set-defaults-for-enterprise-deployments.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
