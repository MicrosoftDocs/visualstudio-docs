---
title: "How to: Whitelist URLs for Secure Networks | Microsoft Docs"
ms.custom: ""
ms.date: "09/19/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "network resources"
  - "connection was closed"
  - "security appliance"
ms.assetid: 
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# How to: Whitelist URLs for secure networks
If you are using Visual Studio in a corporate network that uses security appliances, Visual Studio might not be able to connect to Visual Studio Team Services (VSTS) and other network resources such as NuGet. In this case, Visual Studio would show the following error message:  

**The underlying connection was closed: An unexpected error occurred on send**  

In this how-to topic, I'll show you how to whitelist the URLs that Visual Studio needs to access on your security appliances.  

## Whitelist URLs  
Visual Studio uses Transport Layer Security (TLS) 1.2 protocol to connect to network resources such as VSTS, NuGet, and for sign-in and licensing. Security appliances on some corporate networks block certain server connections when Visual Studio uses TLS 1.2.  

#### To whitelist URLs on your security appliance  
Follow these steps to update your security appliances to allow server connections through TLS 1.2 for the URLs that Visual Studio needs to access.

1.  

2.  

3.  Enable connections for the following URLs:

     1. https://management.core.windows.net
     2. https://app.vssps.visualstudio.com
     3. https://login.microsoftonline.com
     4. https://login.live.com
     5. https://go.microsoft.com
     6. https://graph.windows.net
     7. https://app.vsspsext.visualstudio.com
     8. *.azurewebsites.net (Azure connections)
     9. *.nuget.org (NuGet connections)
     10. *.visualstudio.com
     11. cdn.vsassets.io (hosts CDN content)
     12. *.gallerycdn.vsassets.io (hosts VSTS extensions)
     13. static2.sharepointonline.com (hosts some resources that Visual Studio uses in the ‘office fabric’ UI kit such as fonts)

> [!NOTE]
>  Privately owned NuGet server URLs may not be included in the list above. You can check the NuGet servers you are using by opening up %APPData%\Nuget\NuGet.Config.  