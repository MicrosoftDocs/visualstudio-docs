---
title: "Install and use Visual Studio behind a firewall or proxy server | Microsoft Docs"
description: ""
ms.custom: ""
ms.date: "01/30/2018"
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
# Install and use Visual Studio behind a firewall or proxy server
When you install and use Visual Studio, there might be scenarios in which you'll want to "whitelist" some domain URLs.

## Installing Visual Studio by using deployment scripts
Because the Visual Studio Installer downloads files from various domains and their download servers, here are the domain URLs that you might want to whitelist as trusted in your deployment scripts.

If it's possible for your environment, consider adding the following domains with both HTTP and HTTPS protocols.

### Microsoft domains
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


### Non-Microsoft domains
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

## Using Visual Studio or Azure services in a private network
You might want to whitelist URLs when you use Visual Studio in a private network, or when you use or develop for Azure services.

### Whitelisting URLs in a private network
If you are using Visual Studio in a private network that has a firewall, Visual Studio might not be able to connect to some network resources. These resources can include Visual Studio Team Services (VSTS) for sign-in and licensing, NuGet, and Azure services. If Visual Studio fails to connect to one of these resources, you'll see the following error message:

  **The underlying connection was closed: An unexpected error occurred on send**

Visual Studio uses Transport Layer Security (TLS) 1.2 protocol to connect to network resources. Security appliances on some private networks block certain server connections when Visual Studio uses TLS 1.2. To fix the error, enable connections for the following URLs:

- https://management.core.windows.net

- https://app.vssps.visualstudio.com

- https://login.microsoftonline.com

- https://login.live.com

- https://go.microsoft.com

- https://graph.windows.net

- https://app.vsspsext.visualstudio.com

- &#42;.azurewebsites.net (for Azure connections)

- &#42;.visualstudio.com

- cdn.vsassets.io (hosts content delivery network, or CDN, content)

- &#42;.gallerycdn.vsassets.io (hosts VSTS extensions)

- static2.sharepointonline.com (hosts resources that Visual Studio uses in the Office UI Fabric kit, such as fonts)

- &#42;.nuget.org (for NuGet connections)

 > [!NOTE]
 > Privately owned NuGet server URLs may not be included in this list. You can check for the NuGet servers that you are using in %APPData%\Nuget\NuGet.Config.


### Whitelisting URLs for Azure services
Whether you are using Azure services or are an Azure developer, there are the DNS endpoints, protocols, and output ports you'll want to know about. For a full list, see the [Visual Studio and Azure Services ports & protocols](visual-studio-and-azure-services-ports-and-protocols.md) page.

## Get support
Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Visual Studio and Azure Services ports and protocols list](visual-studio-and-azure-services-ports-and-protocols.md)
* [Troubleshooting proxy errors in Visual Studio](troubleshooting-proxy-errors.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Install Visual Studio 2017](install-visual-studio.md)
