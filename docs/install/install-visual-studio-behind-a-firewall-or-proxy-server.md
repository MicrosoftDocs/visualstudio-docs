---
title: "Install Visual Studio behind a firewall or proxy server | Microsoft Docs"
description: ""
ms.custom: ""
ms.date: "07/18/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
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
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
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
| visualstudio.com | Documentation location |
| msdn.microsoft.com | Documentation location |
| microsoft.com | Documentation location |

## Third-party domains
| Domain | Used to install these workloads |
| ------ | ------- |
| archive.apache.org |  Mobile development with JavaScript (Cordova) |
| cocos2d-x.org | Game development with C++ (Cocos) |
| download.epicgames.com | Game development with C++ (Unreal Engine) |
| download.oracle.com | Mobile development with JavaScript (Java SDK) <br />Mobile Development with .NET (Java SDK) |
| download.unity3d.com | Game Development with Unity workload (Unity) |
| netstorage.unity3d.com | Game Development with Unity workload (Unity) |
| dl.google.com | Mobile development with JavaScript (Android SDK and NDK, Emulator) <br />Mobile Development with .NET (Android SDK and NDK, Emulator) |
| incredibuild.com | Game development with C++ (Incredibuild) |
| incredibuildvs2017i.azureedge.net | Game development with C++ (Incredibuild) |
| python.org | Python development (Python) <br /> Data science and and analytical applications (Python) |

## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
  * [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
    * [Command-line parameter examples](command-line-parameter-examples.md)
    * [Workload and Component ID reference](workload-and-component-ids.md)
  * [Create a networked-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
    * [Special considerations for installing Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md)
  * [Automate Visual Studio with a response file](automated-installation-with-response-file.md)
  * [Automatically apply product keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)
  * [Set defaults for enterprise deployments of Visual Studio](set-defaults-for-enterprise-deployments.md)
  * [Disable or move the package cache](disable-or-move-the-package-cache.md)
  * [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
  * [Control updates to Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
  * [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
  * [Report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
