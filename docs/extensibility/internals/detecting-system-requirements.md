---
title: Detecting System Requirements
description: Learn how to configure the Microsoft Windows Installer to detect system requirements such as the edition of Visual Studio that is installed.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- setup, VSPackages
- launch conditions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Detect system requirements

A VSPackage cannot function unless Visual Studio is installed. When you use Microsoft Windows Installer to manage the installation of your VSPackage, you can configure the installer to detect whether Visual Studio is installed. You can also configure it to check the system for other requirements, for example, a particular version of Windows or a particular amount of RAM.

## Detect Visual Studio editions
 To determine whether an edition of Visual Studio is installed, verify that the value of the **Install** registry key is *(REG_DWORD) 1* in the appropriate folder, as listed in the following table. Note that there is a hierarchy of Visual Studio editions:

1. Enterprise

2. Professional

3. Community

When a newer edition is installed, the registry keys for that edition are added as well as for earlier editions. That is, if the Enterprise edition is installed, the **Install** key is set to *1* for Enterprise, as well as for the Professional and Community editions. Therefore, you need to check only for the most recent edition you need.

> [!NOTE]
> In the 64-bit version of the registry editor, 32-bit keys are displayed under **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\\**. The Visual Studio keys are under **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\DevDiv\vs\Servicing\\**.

|Product|Key|
|-------------|---------|
|Visual Studio Enterprise 2015|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\DevDiv\vs\Servicing\14.0\enterprise|
|Visual Studio Professional 2015|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\DevDiv\vs\Servicing\14.0\professional|
|Visual Studio Community 2015|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\DevDiv\vs\Servicing\14.0\community|
|Visual Studio 2015 Shell (integrated and isolated)|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\DevDiv\vs\Servicing\14.0\isoshell|

## Detect when Visual Studio is running
 Your VSPackage can't be registered correctly if Visual Studio is running when the VSPackage is installed. The installer must detect when Visual Studio is running and then refuse to install the program. Windows Installer doesn't let you use table entries to enable such detection. Instead, you must create a custom action, as follows: Use the `EnumProcesses` function to detect the *devenv.exe* process, and then either set an installer property that's used in a launch condition or conditionally display a dialog box that prompts the user to close Visual Studio.

## Related content
- [Install VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)
