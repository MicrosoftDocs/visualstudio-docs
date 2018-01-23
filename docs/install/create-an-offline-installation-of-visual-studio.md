---
title: "Create an Offline Installation of Visual Studio | Microsoft Docs"
description: "Find out how to install Visual Studio offline."
ms.custom: ""
ms.date: "01/17/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "offline installation [Visual Studio]"
  - "offline install [Visual Studio]"
  - "layout [Visual Studio]"
ms.assetid: f8625d5e-f6ea-4db0-83c0-619b77fab3cf
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
ms.workload:
  - "multiple"
---
# Create an offline installation of Visual Studio 2017

We designed the Visual Studio 2017 installer to work well in a wide variety of network and machine conditions.

- The new workload-based model means you'll need to download far less than with previous versions of Visual Studio: as little as 300 MB for the smallest installation;
- Compared to a generic "ISO" or zip file, we download only the packages you need for your machine. For example, we don't download 64-bit files if you don't need them;
- During the installation process, we try three different download technologies (WebClient, BITS and WinInet) to minimize interference with anti-virus and proxy software;
- The files you'll need to install Visual Studio are distributed on a global delivery network, so we can get them to you from a local server.

We recommend that you try the [Visual Studio web installer](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocsOL)&mdash;we think you'll find it a good experience.

 > [!div class="button"]
 > [Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocsOL)
<br/>

If you want to install offline because your internet connection is unavailable or unreliable, see [Install Visual Studio 2017 on low bandwidth or unreliable network environments](../install/install-vs-inconsistent-quality-network.md). You can use the command line to create a local cache of the files you need to complete an offline install. This process replaces the ISO files available for previous versions.

> [!NOTE]
> If you are an enterprise administrator who wants to perform a deployment of Visual Studio 2017 to a network of client workstations that are firewalled from the internet, see our [Create a network installation of Visual Studio 2017](../install/create-a-network-installation-of-visual-studio.md) and [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md) pages.

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)
