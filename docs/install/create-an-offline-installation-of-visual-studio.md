---
title: "Create an Offline Installation of Visual Studio | Microsoft Docs"
description: "Find out how to install Visual Studio offline."
ms.custom: ""
ms.date: "08/30/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "offline installation [Visual Studio]"
  - "offline install [Visual Studio]"
  - "layout [Visual Studio]"
ms.assetid: f8625d5e-f6ea-4db0-83c0-619b77fab3cf
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
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
> If you are an enterprise administrator who wants to perform a deployment of Visual Studio 2017 to a network of client workstations that are firewalled from the internet, see our [Create a network installation of Visual Studio 2017](../install/create-a-network-installation-of-visual-studio.md) and [Special considerations for installing Visual Studio in an offline environment](../install/install-visual-studio-in-offline-environment.md) pages.
