---
title: "Proxy Authorization Required"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c2d24ae1-9902-460e-b72a-0299eed9ee82
caps.latest.revision: 4
ms.author: "kempb"
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
# Proxy Authorization Required
This error generally occurs when users are connected to Visual Studio Online through a proxy server, and the proxy server blocks the calls. Visual Studio Online is used to keep the user signed in to the IDE.  
  
## To correct this error  
  
-   Restart Visual Studio. A proxy authentication dialog box should appear. Enter your credentials in the dialog.  
  
-   If the above step does not solve the problem, this may be because your proxy server does not prompt for credentials for http://go.microsoft.com addresses but does so for *.visualStudio.com addresses. For these servers, you need to whitelist the following list to unblock all sign-in scenarios in Visual Studio:  
  
    -   *.windows.net  
  
    -   *.microsoftonline.com  
  
    -   *.visualstudio.com  
  
    -   *.microsoft.com  
  
    -   *.live.com  
  
-   You can otherwise remove the http://go.microsoft.com address from the whitelist so that the proxy authentication dialog shows up for both the http://go.microsoft.com address and the server endpoints when Visual Studio is restarted.  
  
-   OR  
  
-   If you want to use your default credentials with your proxy, you can do the following:  
  
    1.  Find devenv.exe.config (the devenv.exe configuration file) in: **%ProgramFiles%\Microsoft Visual Studio 14.0\Common7\IDE** (or **%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE**).  
  
    2.  In the configuration file, find the `<system.net>` block, and add this code:  
  
        ```xml  
        <defaultProxy enabled="true" useDefaultCredentials="true">  
            <proxy bypassonlocal="True" proxyaddress=" HYPERLINK "http://<yourproxy:port#" http://<yourproxy:port#>"/>  
        </defaultProxy>  
  
        ```  
  
         You must insert the correct proxy address for your network in `proxyaddress="<http://<yourproxy:port#>`.  
  
-   OR  
  
-   You can also follow the instructions in [this post](http://blogs.msdn.com/b/rido/archive/2010/05/06/how-to-connect-to-tfs-through-authenticated-web-proxy.aspx) to add code that will allow you to use the proxy.