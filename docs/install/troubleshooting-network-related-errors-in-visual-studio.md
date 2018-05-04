---
title: "Troubleshooting network-related errors when you install or use Visual Studio"
description: "Find solutions for network- or proxy-related errors that you might encounter when you install or use Visual Studio behind a firewall or a proxy server."
ms.custom: ""
ms.date: 02/12/2018
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: troubleshooting
helpviewer_keywords:
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
  - "list of domains, locations, URLs, Visual Studio"
  - "proxy errors, Visual Studio"
ms.assetid:
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Troubleshooting network-related errors when you install or use Visual Studio

We've got solutions for the most typical network- or proxy-related errors that you might encounter when you install or use Visual Studio behind a firewall or a proxy server.

## Error: “Proxy authorization required”

This error generally occurs when users are connected to the internet through a proxy server, and the proxy server blocks the calls that Visual Studio makes to some network resources.

### To fix this proxy error

- Restart Visual Studio. A proxy authentication dialog box should appear. Enter your credentials when prompted in the dialog.

- If restarting Visual Studio does not solve the problem, it might be that your proxy server does not prompt for credentials for http:&#47;&#47;go.microsoft.com addresses but does so for &#42;.visualStudio.com addresses. For these servers, consider whitelisting the following URLs to unblock all sign-in scenarios in Visual Studio:

    - &#42;.windows.net

    - &#42;.microsoftonline.com

    - &#42;.visualstudio.com

    - &#42;.microsoft.com

    - &#42;.live.com

- You can otherwise remove the http:&#47;&#47;go.microsoft.com address from the whitelist so that the proxy authentication dialog shows up for both the http:&#47;&#47;go.microsoft.com address and the server endpoints when Visual Studio is restarted.

    OR

- If you want to use your default credentials with your proxy, you can perform the following actions:

    1. Find **devenv.exe.config** (the devenv.exe configuration file) in: **%ProgramFiles%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE** or **%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE**.

    1. In the configuration file, find the `<system.net>` block, and then add this code:

        ```xml
        <defaultProxy enabled="true" useDefaultCredentials="true">
            <proxy bypassonlocal="True" proxyaddress=" HYPERLINK "http://<yourproxy:port#" http://<yourproxy:port#>"/>
        </defaultProxy>
        ```

        You must insert the correct proxy address for your network in `proxyaddress="<http://<yourproxy:port#>`.

    OR

- You can also follow the instructions in the [How to connect through an authenticated Web Proxy](http://blogs.msdn.com/b/rido/archive/2010/05/06/how-to-connect-to-tfs-through-authenticated-web-proxy.aspx) blog post, which shows you how to add code that will allow you to use the proxy.

## Error: “The underlying connection was closed”

If you are using Visual Studio in a private network that has a firewall, Visual Studio might not be able to connect to some network resources. These resources can include Visual Studio Team Services (VSTS) for sign-in and licensing, NuGet, and Azure services. If Visual Studio fails to connect to one of these resources, you might see the following error message:

  **The underlying connection was closed: An unexpected error occurred on send**

Visual Studio uses Transport Layer Security (TLS) 1.2 protocol to connect to network resources. Security appliances on some private networks block certain server connections when Visual Studio uses TLS 1.2.

### To fix this connection error

Enable connections for the following URLs:

- https:&#47;&#47;management.core.windows.net

- https:&#47;&#47;app.vssps.visualstudio.com

- https:&#47;&#47;login.microsoftonline.com

- https:&#47;&#47;login.live.com

- https:&#47;&#47;go.microsoft.com

- https:&#47;&#47;graph.windows.net

- https:&#47;&#47;app.vsspsext.visualstudio.com

- &#42;.azurewebsites.net (for Azure connections)

- &#42;.visualstudio.com

- cdn.vsassets.io (hosts content delivery network, or CDN, content)

- &#42;.gallerycdn.vsassets.io (hosts VSTS extensions)

- static2.sharepointonline.com (hosts resources that Visual Studio uses in the Office UI Fabric kit, such as fonts)

- &#42;.nuget.org (for NuGet connections)

 > [!NOTE]
 > Privately owned NuGet server URLs may not be included in this list. You can check for the NuGet servers that you are using in %APPData%\Nuget\NuGet.Config.

## Get support

If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the installation troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:

* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/).
* You can also engage with us and other Visual Studio developers through the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio). (This option requires a [GitHub](https://github.com/) account.)

## See also

* [Install and use Visual Studio behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Install Visual Studio 2017](install-visual-studio.md)
