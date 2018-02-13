---
title: "Install on low bandwidth or unreliable network environments | Microsoft Docs"
description: "Describes how the Visual Studio installer works in unreliable network conditions, and explains how to download install files before beginning the installation."
ms.date: "01/17/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "installing Visual Studio"
  - "no internet connection"
author: "tglee"
ms.author: "tglee"
manager: ghogen
ms.workload:
  - "multiple"
---

# Install Visual Studio 2017 on low bandwidth or unreliable network environments

We recommend that you try the Visual Studio web installer&mdash;we think you'll find it a good experience for most situations.

 > [!div class="button"]
 > [Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocsOL)
<br/>

However, if your internet connection is unavailable or unreliable, you can use the command line to create a local cache of the files you need to complete an offline install. Here's how.

> [!NOTE]
> If you are an enterprise administrator who wants to perform a deployment of Visual Studio 2017 to a network of client workstations that are firewalled from the internet, see our [Create a network installation of Visual Studio 2017](../install/create-a-network-installation-of-visual-studio.md) and [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md) pages.

## Step 1 - Download the Visual Studio bootstrapper

Start by downloading the Visual Studio bootstrapper for your chosen edition of Visual Studio.

Your setup file&mdash;or to be more specific, a bootstrapper file&mdash;will match or be similar to one of the following.

| Edition                    | File                                                                    |
|----------------------------|-------------------------------------------------------------------------|
| Visual Studio Community    | [vs_community.exe](https://aka.ms/vs/15/release/vs_community.exe)       |
| Visual Studio Professional | [vs_professional.exe](https://aka.ms/vs/15/release/vs_professional.exe) |
| Visual Studio Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/15/release/vs_enterprise.exe)     |

## Step 2 - Create a local install cache

You must have an internet connection to complete this step. To create a local layout, open a command prompt and use one of the commands from the following examples: The examples here assume that you're using the Community edition of Visual Studio; adjust the command as appropriate for your edition.

- For .NET web and .NET desktop development, run:

   ```vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US```

- For .NET desktop and Office development, run:

   ```vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.Office --includeOptional --lang en-US```

- For C++ desktop development, run:

   ```vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --lang en-US```

- To create a complete local layout with all features (this will take a long time&mdash;we have _lots_ of features!), run:

   ```vs_community.exe --layout c:\vs2017layout --lang en-US```

If you want to install a language other than English, change `en-US` to a locale from the list at the bottom of this page. Use this [list of the components and workloads available](workload-and-component-ids.md) to further customize your installation cache as necessary.

> [!IMPORTANT]
> A complete Visual Studio 2017 layout requires at least 35 GB of disk space and can take some time to download. See [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) for information on how to create a layout with only the components you want to install.

## Step 3 - Install Visual Studio from the local cache

> [!TIP]
> When you run from a local install cache, setup uses the local versions of each of these files. But if you select components during installation that aren't in the cache, we attempt to download them from the internet.

To ensure that you only install the files you've downloaded, use the same command-line options that you used to create the layout cache. For example, if you created a layout cache with the following command:

```vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US```

Use this command to run the installation:

```c:\vs2017layout\vs_community.exe --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional```

> [!NOTE]
> If you get an error that a signature is invalid, you must install updated certificates. Open the Certificates folder in your offline cache. Double-click each of the certificate files, and then click through the Certificate Manager wizard. If asked for a password, leave it blank.

## List of language locales

| **Language-locale** | **Language** |
| ----------------------- | --------------- |
| cs-CZ | Czech |
| de-DE | German |
| en-US | English |
| es-ES | Spanish |
| fr-FR | French |
| it-IT | Italian |
| ja-JP | Japanese |
| ko-KR | Korean |
| pl-PL | Polish |
| pt-BR | Portuguese - Brazil |
| ru-RU | Russian |
| tr-TR | Turkish |
| zh-CN | Chinese - Simplified |
| zh-TW | Chinese - Traditional |

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
