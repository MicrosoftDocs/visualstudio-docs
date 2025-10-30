---
title: Tools for detecting and managing Visual Studio instances
titleSuffix: ''
description: Explore tools to detect and manage Visual Studio installations on client machines, including vswhere, PowerShell scripts, C# and C++ samples, and more.
ms.date: 10/13/2023
ms.topic: article
helpviewer_keywords:
- vswhere
- vswhere.exe
- visual studio instance
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Tools for detecting and managing Visual Studio instances

There are several tools that you can use to detect and manage Visual Studio installations on client machines.

## Detecting existing Visual Studio instances

The following tools and utilities will help you detect and manage installed Visual Studio instances on client machines:

* [**vswhere**](https://github.com/microsoft/vswhere): an executable built into Visual Studio or available for separate distribution that helps you find the location of all Visual Studio instances on a particular machine.
* [**VSSetup.PowerShell**](https://github.com/microsoft/vssetup.powershell): PowerShell scripts that use the Setup Configuration API to identify installed instances of Visual Studio.
* [**VS-Setup-Samples**](https://github.com/microsoft/vs-setup-samples): C# and C++ samples that demonstrate how to use the Setup Configuration API to query an existing installation.
* [**Windows Management Instrumentation (WMI)**](/windows/win32/wmisdk/wmi-start-page): Visual Studio instance information can be queried through the Visual Studio class MSFT_VSInstance.
* The [**Setup Configuration API**](<xref:Microsoft.VisualStudio.Setup.Configuration>) provides interfaces for developers who want to build their own utilities for interrogating Visual Studio instances.
* [**Microsoft Endpoint Configuration Manager software inventory**](/mem/configmgr/core/clients/manage/inventory/introduction-to-software-inventory): can be used to collect information about Visual Studio instances on client devices.

## Using vswhere.exe

`vswhere.exe` is automatically included in Visual Studio 2017 and later, or you can download it from [the vswhere releases page](https://github.com/Microsoft/vswhere/releases). Use `vswhere -?` to get help information about the tool. For example, this command shows all releases of Visual Studio, including earlier versions of the product and prereleases, and outputs the results in JSON format:

```shell
C:\Program Files (x86)\Microsoft Visual Studio\Installer>vswhere.exe -legacy -prerelease -format json
```

## Using Windows Management Instrumentation (WMI)

If the Visual Studio Client Detector Utility is installed on the machine, then you can query for Visual Studio instance information using WMI. The Visual Studio Client Detector Utility is installed by default with every Visual Studio 2017, Visual Studio 2019, and Visual Studio 2022 update that was released on or after May 12, 2020. It is also available on the [Microsoft Update Catalog](https://catalog.update.microsoft.com/) if you want to install it independently.  For an example of how to use the utility to return Visual Studio instance information, open up PowerShell as an administrator on the client machine, and type in the following command:

```shell
Get-CimInstance MSFT_VSInstance -Namespace root/cimv2/vs
```

## Using Microsoft Endpoint Configuration Manager

[Microsoft Endpoint Configuration Manager software inventory](/mem/configmgr/core/clients/manage/inventory/introduction-to-software-inventory) capabilities can be used to query and collect information about Visual Studio instances on client devices. For example, the following query will return the display name, version, and the device name Visual Studio is installed on for all installed Visual Studio 2017, 2019, and 2022 instances:

```WQL
select distinct SMS_G_System_COMPUTER_SYSTEM.Name, SMS_G_System_ADD_REMOVE_PROGRAMS.DisplayName, SMS_G_System_ADD_REMOVE_PROGRAMS.Version from SMS_R_System inner join SMS_G_System_COMPUTER_SYSTEM on SMS_G_System_COMPUTER_SYSTEM.ResourceID = SMS_R_System.ResourceId inner join SMS_G_System_ADD_REMOVE_PROGRAMS on SMS_G_System_ADD_REMOVE_PROGRAMS.ResourceID = SMS_R_System.ResourceId where SMS_G_System_ADD_REMOVE_PROGRAMS.DisplayName like "Visual Studio %[a-z]% 201[7,9]" or SMS_G_System_ADD_REMOVE_PROGRAMS.DisplayName like "Visual Studio %[a-z]% 2022"
```

## Editing the registry for a Visual Studio instance

In Visual Studio, registry settings are stored in a private location, which enables multiple side-by-side instances of the same version of Visual Studio on the same machine.

As these entries are not stored in the global registry, there are special instructions for using the Registry Editor to make changes to registry settings:

1. If you have an open instance of Visual Studio, close it.

1. Start `regedit.exe`.

1. Select the `HKEY_LOCAL_MACHINE` node.

1. From the Regedit main menu, select **File** > **Load Hive...** and then select the private registry file, which is stored in the **AppData\Local** folder. For example:

   ```shell
   %localappdata%\Microsoft\VisualStudio\<config>\privateregistry.bin
   ```

   > [!NOTE]
   > `<config>` corresponds to the instance of Visual Studio that you would like to browse.

You will be prompted to provide a hive name, which becomes the name of your isolated hive. After you do so, you should be able to browse the registry under the isolated hive that you created.

> [!IMPORTANT]
> Before you start Visual Studio again, you must unload the isolated hive that you created. To do this, select **File** > **Unload Hive** from the Regedit main menu. (If you don't do this, then the file remains locked and Visual Studio will not be able to start.)

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
