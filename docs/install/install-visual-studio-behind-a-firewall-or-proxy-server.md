---
title: "Install Visual Studio behind a firewall or proxy server | Microsoft Docs"
description: ""
ms.custom: ""
ms.date: "08/01/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
  - "list of domains, locations, URLs"
ms.assetid: 
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Install Visual Studio behind a firewall or proxy server

The Visual Studio Installer downloads files from various domains and their download servers. This page lists the domain URLs that you might want to "whitelist" as trusted in your deployment scripts.

If it's possible for your environment, consider adding the following domains with both HTTP and HTTPS protocols.

## Microsoft domains
| Domain | Purpose |
| ------ | ------- |
| go.microsoft.com | Setup URL resolution |
| aka.ms | Setup URL resolution |
| download.visualstudio.microsoft.com | Setup packages download location |
| download.microsoft.com | Setup packages download location |
| download.visualstudio.com | Setup packages download location |
| dl.xamarin.com | Setup packages download location |
| visualstudiogallery.msdn.microsoft.com | Visual Studio Extensions download location |
| www.visualstudio.com | Documentation location |
| docs.microsoft.com | Documentation location |
| msdn.microsoft.com | Documentation location |
| www.microsoft.com | Documentation location |
| *.windows.net | Sign-in location |
| *.microsoftonline.com | Sign-in location |
| *.live.com | Sign-in location |


## Non-Microsoft domains
| Domain | Installs these workloads |
| ------ | ------- |
| archive.apache.org |  Mobile development with JavaScript <br />(Cordova) |
| cocos2d-x.org | Game development with C++ <br />(Cocos) |
| download.epicgames.com | Game development with C++ <br />(Unreal Engine) |
| download.oracle.com | Mobile development with JavaScript <br />(Java SDK) <br /><br />Mobile Development with .NET <br />(Java SDK) |
| download.unity3d.com | Game development with Unity <br />(Unity) |
| netstorage.unity3d.com | Game development with Unity <br /> (Unity) |
| dl.google.com | Mobile development with JavaScript <br />(Android SDK and NDK, Emulator) <br /><br />Mobile Development with .NET <br />(Android SDK and NDK, Emulator) |
| www.incredibuild.com | Game development with C++ <br />(IncrediBuild) |
| incredibuildvs2017i.azureedge.net | Game development with C++ <br />(IncrediBuild) |
| www.python.org | Python development <br />(Python) <br /><br />Data science and analytical applications <br />(Python) |

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
  * [Workload and Component ID reference](workload-and-component-ids.md)
* [Create a networked-based installation of Visual Studio 2017](create-a-network-installation-of-visual-studio.md)
  * [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md)
* [Automatically apply product keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)
* [Set defaults for enterprise deployments of Visual Studio 2017](set-defaults-for-enterprise-deployments.md)
* [Disable or move the package cache](disable-or-move-the-package-cache.md)
* [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
* [Control updates to Visual Studio 2017 deployments](controlling-updates-to-visual-studio-deployments.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
