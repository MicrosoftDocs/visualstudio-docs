---
title: "Proxy Authorization Required | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: troubleshooting
ms.assetid: c2d24ae1-9902-460e-b72a-0299eed9ee82
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# Proxy Authorization Required
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **Proxy authorization required** error generally occurs when users are connected to Visual Studio online resources through a proxy server, and the proxy server blocks the calls.

To correct this error, try one or more of the following steps:

- Restart Visual Studio. A proxy authentication dialog box should appear. Enter your credentials in the dialog.

- If the above step does not solve the problem, this may be because your proxy server does not prompt for credentials for https://go.microsoft.com addresses but does so for *.visualStudio.com addresses. For these servers, you need to add the following URLs to the allow list to unblock all sign-in scenarios in Visual Studio:

  - *.windows.net

  - *.microsoftonline.com

  - *.visualstudio.com

  - *.microsoft.com

  - *.live.com

- You can remove the https://go.microsoft.com address from the allow list so that the proxy authentication dialog shows up for both the https://go.microsoft.com address and the server endpoints when Visual Studio is restarted.

- If you want to use your default credentials with your proxy, do the following:

   1. Find devenv.exe.config (the devenv.exe configuration file) in: **%ProgramFiles%\Microsoft Visual Studio 14.0\Common7\IDE** (or **%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE**).

   2. In the configuration file, find the `<system.net>` block, and add this code:

      ```xml
      <defaultProxy enabled="true" useDefaultCredentials="true">
          <proxy bypassonlocal="True" proxyaddress=" HYPERLINK "http://<yourproxy:port#" http://<yourproxy:port#>"/>
      </defaultProxy>
      ```

      Insert the correct proxy address for your network in `proxyaddress="<http://<yourproxy:port#>`.

- Follow the instructions in [this blog post](https://blogs.msdn.microsoft.com/rido/2010/05/06/how-to-connect-to-tfs-through-authenticated-web-proxy/) to add code that allows you to use the proxy.
