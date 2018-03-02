---
title: "Tools for detecting and managing Visual Studio instances | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "08/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 85686707-14C0-4860-9B7A-66485D43D241
author: "timsneath"
ms.author: "tglee"
manager: ghogen
ms.workload: 
  - "multiple"
---

# Tools for detecting and managing Visual Studio instances

## Detecting existing Visual Studio instances
We have made several tools available that will help you detect and manage installed Visual Studio instances on client machines:

* [VSWhere](https://github.com/microsoft/vswhere): an executable built into Visual Studio or available for separate distribution that helps you find the location of all Visual Studio instances on a particular machine.
* [VSSetup.PowerShell](https://github.com/microsoft/vssetup.powershell): PowerShell scripts that use the Setup Configuration API to identify installed instances of Visual Studio.
* [VS-Setup-Samples](https://github.com/microsoft/vs-setup-samples): C# and C++ samples that demonstrate how to use the Setup Configuration API to query an existing installation.

In addition, the [Setup Configuration API](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.setup.configuration.aspx) provides interfaces for developers who want to build their own utilities for interrogating Visual Studio instances.

## Using vswhere.exe
`vswhere.exe` is automatically included in Visual Studio 2017 version 15.2 or above, or you may download it from [the releases page](https://github.com/Microsoft/vswhere/releases). Use `vswhere -?` to get help information about the tool. As an example, this command shows all releases of Visual Studio, including old versions of the product and prereleases, and outputs the results in JSON format:

```cmd
C:\Program Files (x86)\Microsoft Visual Studio\Installer> vswhere.exe -legacy -prerelease -format json
```

>[!TIP]
>For more information about Visual Studio 2017 installation, see [Heath Stewart's blog articles](https://blogs.msdn.microsoft.com/heaths/tag/vs2017/).


## Editing the registry for a Visual Studio instance
In Visual Studio 2017, registry settings are stored in a private location, which enables multiple side-by-side instances of the same version of Visual Studio on the same machine.

As these entries are not stored in the global registry, there are special instructions for using the Registry Editor to make changes to registry settings:

1. If you have an open instance of Visual Studio 2017, close it.
2. Start `regedit.exe`.
3. Select the `HKEY_LOCAL_MACHINE` node.
4. From the Regedit main menu, select **File -> Load Hive...** and then select the private registry file, which is stored in the **AppData\Local** folder. For example:
   ```
   %localappdata%\Microsoft\VisualStudio\<config>\privateregistry.bin
   ```

> [!NOTE]
> `<config>` corresponds to the instance of Visual Studio that you would like to browse.

You will be prompted to provide a hive name, which becomes the name of your isolated hive. After you do so, you should be able to browse the registry under the isolated hive that you created.

> [!IMPORTANT]
> Before you start Visual Studio again, you must unload the isolated hive that you created. To do this, select File -> Unload Hive from the Regedit main menu. (If you do not do this, then the file remains locked and Visual Studio will not be able to start.)

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Visual Studio Administrators Guide](visual-studio-administrator-guide.md)
