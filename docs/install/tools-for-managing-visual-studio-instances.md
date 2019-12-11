---
title: "Tools for detecting and managing Visual Studio instances"
titleSuffix: ""
description: "Learn about the tools that you can use to detect and manage Visual Studio installations on client machines."
ms.date: 08/14/2017
ms.custom: "seodec18"
ms.topic: conceptual
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 85686707-14C0-4860-9B7A-66485D43D241
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Tools for detecting and managing Visual Studio instances

There are several tools that you can use to detect Visual Studio installations on client machines, and to manage the installations, too.

## Detecting existing Visual Studio instances

We have made several tools available that will help you detect and manage installed Visual Studio instances on client machines:

* [vswhere](https://github.com/microsoft/vswhere): an executable built into Visual Studio or available for separate distribution that helps you find the location of all Visual Studio instances on a particular machine.
* [VSSetup.PowerShell](https://github.com/microsoft/vssetup.powershell): PowerShell scripts that use the Setup Configuration API to identify installed instances of Visual Studio.
* [VS-Setup-Samples](https://github.com/microsoft/vs-setup-samples): C# and C++ samples that demonstrate how to use the Setup Configuration API to query an existing installation.

In addition, the [Setup Configuration API](<xref:Microsoft.VisualStudio.Setup.Configuration>) provides interfaces for developers who want to build their own utilities for interrogating Visual Studio instances.

## Using vswhere.exe

`vswhere.exe` is automatically included in Visual Studio (starting with Visual Studio 2017 version 15.2 and later versions), or you can download it from [the vswhere releases page](https://github.com/Microsoft/vswhere/releases). Use `vswhere -?` to get help information about the tool. As an example, this command shows all releases of Visual Studio, including earlier versions of the product and prereleases, and outputs the results in JSON format:

```cmd
C:\Program Files (x86)\Microsoft Visual Studio\Installer> vswhere.exe -legacy -prerelease -format json
```

::: moniker range="vs-2017"

> [!TIP]
> For more information about Visual Studio 2017 installation, see [Visual Studio Setup Archives](https://devblogs.microsoft.com/setup/tag/vs2017/).

::: moniker-end

## Editing the registry for a Visual Studio instance

In Visual Studio, registry settings are stored in a private location, which enables multiple side-by-side instances of the same version of Visual Studio on the same machine.

As these entries are not stored in the global registry, there are special instructions for using the Registry Editor to make changes to registry settings:

1. If you have an open instance of Visual Studio, close it.

1. Start `regedit.exe`.

1. Select the `HKEY_LOCAL_MACHINE` node.

1. From the Regedit main menu, select **File** > **Load Hive...** and then select the private registry file, which is stored in the **AppData\Local** folder. For example:

   ```
   %localappdata%\Microsoft\VisualStudio\<config>\privateregistry.bin
   ```

   > [!NOTE]
   > `<config>` corresponds to the instance of Visual Studio that you would like to browse.

You will be prompted to provide a hive name, which becomes the name of your isolated hive. After you do so, you should be able to browse the registry under the isolated hive that you created.

> [!IMPORTANT]
> Before you start Visual Studio again, you must unload the isolated hive that you created. To do this, select **File** > **Unload Hive** from the Regedit main menu. (If you do not do this, then the file remains locked and Visual Studio will not be able to start.)

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio Administrators Guide](visual-studio-administrator-guide.md)
