---
title: "Whitelisting URLs in a private network | Microsoft Docs"
ms.custom: ""
ms.date: "09/19/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Whitelisting URLs in a private network

If you are using Visual Studio in a private network that uses a security appliance such as a firewall, Visual Studio might not be able to connect to some network resources. These resources include Visual Studio Team Services (VSTS) for sign-in and licensing, NuGet, and Azure services. If Visual Studio fails to connect to one of these resources, you'll see the following error message:

  **The underlying connection was closed: An unexpected error occurred on send**

Visual Studio uses Transport Layer Security (TLS) 1.2 protocol to connect to network resources. Security appliances on some private networks block certain server connections when Visual Studio uses TLS 1.2. To fix the error, enable connections for the following URLs:

- https://management.core.windows.net

- https://app.vssps.visualstudio.com

- https://login.microsoftonline.com

- https://login.live.com

- https://go.microsoft.com

- https://graph.windows.net

- https://app.vsspsext.visualstudio.com

- *.azurewebsites.net (for Azure connections)

- *.nuget.org (for NuGet connections)

- *.visualstudio.com

- cdn.vsassets.io (hosts content delivery network, or CDN, content)

- *.gallerycdn.vsassets.io (hosts VSTS extensions)

- static2.sharepointonline.com (hosts resources that Visual Studio uses in the office fabric UI kit, such as fonts)

> [!NOTE]
> Privately owned NuGet server URLs may not be included in the list above. You can check the NuGet servers you are using by opening up %APPData%\Nuget\NuGet.Config.

## See also

[Proxy authorization required error](../ide/reference/proxy-authorization-required.md)  
[Install Visual Studio behind a firewall or proxy server](../install/install-visual-studio-behind-a-firewall-or-proxy-server.md)
