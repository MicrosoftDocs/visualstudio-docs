---
title: Configure proxy settings in Visual Studio
description: Set a custom proxy server, port, and authentication for Visual Studio to connect through enterprise networks.
ms.date: 03/12/2026
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Environment.ProxySettings
monikerRange: 'visualstudio'
author: ghogen
ms.author: ghogen
ms.subservice: general-ide
ms.custom: awp-ai
---

# Configure proxy settings in Visual Studio

By default, Visual Studio uses your Windows proxy configuration, but if your organization's network requires a different proxy configuration for Visual Studio, you can set one directly in the IDE through the **Proxy Settings** options page.

In this first release, the custom proxy settings apply to **GitHub Copilot experiences** and **sign-in flows for Entra ID and GitHub** within Visual Studio. A restart may be required for some features to pick up new proxy settings.

## Prerequisites

The proxy configuration experience is not yet available in all Visual Studio 2026 installations. If you don't see this in your installation, install [Visual Studio Insiders](https://visualstudio.microsoft.com/insiders/). Or, view the [Visual Studio 2022 proxy troubleshooting page](/visualstudio/ide/reference/proxy-firewall-troubleshoot?view=vs-2022&preserve-view=true) for guidance.

## Open the Proxy Configuration page

1. Select **Tools** > **Options** from the menu bar.
1. Select **Proxy Configuration** to open the proxy configuration page.

   ![Screenshot of the Proxy Settings page under Tools > Options.](./media/visualstudio/proxy-settings.png)


## Default behavior

By default, Visual Studio uses your Windows proxy configuration. You don't need to change any settings unless you require a proxy configuration that differs from the default for your user account. If the Windows settings are set to No Proxy, Visual Studio respects this and sets no proxy.

## Configure proxy settings

To supply Visual Studio with proxy settings:

1. Open the **Proxy Configuration** page (**Tools** > **Options** > **Proxy Configuration**).
1. Select **Use custom proxy settings**.
1. Enter the **proxy server URL** and **port**.
1. Choose an authentication method:
   - **Use the logged-in Windows account** — uses your current Windows credentials for integrated authentication (NTLM or Kerberos).
   - **Use alternate credentials** — provide a **username** and **password** for the proxy.
1. Select **OK**.
1. Restart Visual Studio.

> [!TIP]
> If your proxy requires Basic authentication, choose **Use alternate credentials** and enter the credentials your proxy expects.

## Related content

- [Troubleshoot proxy and firewall issues in Visual Studio](proxy-firewall-troubleshoot.md)
- [Install and use Visual Studio behind a firewall or proxy server](../../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
