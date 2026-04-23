---
title: Troubleshoot proxy and firewall issues in Visual Studio
description: Diagnose and resolve proxy server, firewall, and SSL certificate issues that affect network connectivity in Visual Studio.
ms.date: 02/03/2026
ms.topic: troubleshooting
monikerRange: '>=vs-2022'
author: ghogen
ms.author: ghogen
ms.subservice: general-ide
ai-usage: ai-assisted
---

# Troubleshoot proxy and firewall issues in Visual Studio

When you use Visual Studio behind a corporate proxy or firewall, you might encounter connectivity issues that affect features requiring network access, such as NuGet package restore, extension installation, and AI-powered features. Proxy issues generally fall into two categories:

- **Configuration issues**: Problems with your proxy server setup, certificates, or network configuration. These issues are resolved by your IT administrator.

::: moniker range="visualstudio"

- **Settings required**: Visual Studio requires additional information about your network configuration. You can configure proxy settings directly in the IDE. See [Configure proxy settings in Visual Studio](proxy-settings.md) for setup instructions.

  > [!NOTE]
  > The proxy configuration experience is not yet available in all Visual Studio 2026 installations. If you don't see this in your installation, you can install [Visual Studio Insiders](https://visualstudio.microsoft.com/insiders/) to try it. Or, view the [Visual Studio 2022 version of this page](/visualstudio/ide/reference/proxy-firewall-troubleshoot?view=vs-2022&preserve-view=true) for guidance.

::: moniker-end

::: moniker range="vs-2022"

- **Settings required**: Visual Studio requires additional information about your network configuration. You can find more information about how to supply required settings to Visual Studio in this article.

::: moniker-end

- **Product issues**: If you have determined that your issue is not a configuration issue or supplied settings do not address the issue you're seeing, then this could be a product issue. Follow the steps at [Collect diagnostic information](#product-issues-collect-diagnostic-information-for-support) before submitting a ticket.

This article helps you identify which category your issue falls into and provides solutions for common problems.

## Prerequisites

Before troubleshooting proxy issues, ensure you have:

- Visual Studio installed and updated to the latest version.
- The required URLs allowed through your firewall. See [Install and use Visual Studio behind a firewall or proxy server](../../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md).

## Known issues and solutions

The following sections describe common proxy-related issues and their solutions.

### SSL connection errors (certificate authority not trusted)

**Symptom**: You see an error like `System.Net.Http.HttpRequestException: The SSL connection could not be established` with an inner exception `IOException: Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host`.

**Category**: Configuration issue

**Solution**: Your proxy server uses a certificate authority (CA) that must be installed and trusted. Complete both of the following steps:

1. Install all proxy-issues certificates (root and intermediate) in the Windows **Trusted Root Certification Authorities** store. For more information, see [Trusted Root Certification Authorities Certificate Store](/windows-hardware/drivers/install/trusted-root-certification-authorities-certificate-store).
1. Set the `NODE_EXTRA_CA_CERTS` environment variable to the path of the CA certificate file. This step is required for features that use Node.js processes.

> [!NOTE]
> This error can also occur if a firewall is blocking the connection rather than a proxy issue.

### Transparent proxy failures

**Symptom**: Network calls fail when using a transparent proxy, with various error messages.

**Category**: Configuration issue

**Solution**: Transparent proxies can cause a broad range of issues because they intercept traffic without explicit configuration. The proxy server might be using allow or block lists for specific processes and applications. Work with your network administrator to:

- Verify that Visual Studio processes are allowed through the proxy
- Check if specific endpoints are blocked
- Review SSL inspection settings

### Copilot Authentication works while Copilot Chat does not

**Symptom**: You are able to sign into GitHub and Copilot indicates you are authenticated, however using Copilot chat results in an error.

**Category**: Configuration issue

**Solution**: These symptoms mean that Visual Studio's own .NET requests fail but .NET Framework requests are working. There are many possible causes, including proxies that block specific endpoints, or that general IPv6 traffic is blocked. Check that IPv6 traffic is not blocked by your proxy or firewall. Try one of the following solutions:

:::moniker range="visualstudio"
- **Preferred**: Configure your proxy to allow IPv6 traffic.
- **Alternative**: Set the environment variable `DOTNET_SYSTEM_NET_DISABLEIPV6` to `1` to force IPv4.
- **If using process allow lists**: Add `DevHub.exe` to your firewall or proxy allow list.
:::moniker-end

:::moniker range="vs-2022"
- **Preferred**: Configure your proxy to allow IPv6 traffic.
- **Alternative**: Set the environment variable `DOTNET_SYSTEM_NET_DISABLEIPV6` to `1` to force IPv4.
- **If using process allow lists**: Add `ServiceHub.Host.dotnet.x64.exe` to your firewall or proxy allow list.
:::moniker-end

### Partial certificate chain errors

**Symptom**: Stack traces show `The remote certificate is invalid because of errors in the certificate chain: PartialChain`.

**Category**: Configuration issue

**Solution**: One or more intermediate certificates are missing from the certificate chain. See [Diagnose partial certificate chain issues](#diagnose-partial-certificate-chain-issues) for steps to identify missing certificates, then work with your IT administrator to install them.

### Proxy authentication required (407 error with Basic auth)

**Symptom**: Stack traces show `(407) Proxy Authentication Required` when using a proxy with Basic authentication.

**Category**: Settings required

**Solution**: Visual Studio supports signing into GitHub and Microsoft Entra accounts behind an authenticating proxy with basic authentication, but most versions of Visual Studio don't have support for Copilot behind an authenticating proxy with basic authentication.

::: moniker range="vs-2022"

On startup, a prompt appears to capture credentials. The credentials persist in the Windows **Credential Manager** under **Windows Credentials** as `VSCredentials_<proxyAddress>` as the internet or network address, then the username and password that the proxy requires.

::: moniker-end

::: moniker range="visualstudio"

On startup, a prompt appears to capture credentials. The credentials persist in the Windows **Credential Manager** under **Windows Credentials** as `VSCredentials_<proxyAddress>` as the internet or network address, then the username and password that the proxy requires.

You can also configure proxy credentials directly in Visual Studio. See [Configure proxy settings in Visual Studio](proxy-settings.md).

::: moniker-end
### Proxy authentication required (NTLM or Kerberos)

**Symptom**: Network-dependent features don't work when using a proxy server with NTLM or Kerberos authentication.

**Category**: Settings required

**Solution**: Configure Visual Studio to use default proxy credentials:

::: moniker range="visualstudio"

1. Go to **Tools** > **Options** > **Proxy Settings**.
1. Select **Use the logged-in Windows account** to use your current Windows credentials.
1. Restart Visual Studio for the changes to take effect.

For more information, see [Configure proxy settings in Visual Studio](proxy-settings.md).

::: moniker-end

::: moniker range="vs-2022"

Set the environment variable `VS_USE_DEFAULTPROXY` to `true`. For Copilot, also set `COPILOT_USE_DEFAULTPROXY` to `true`.

::: moniker-end

> [!NOTE]
> To disable this workaround later, delete the environment variable entirely. Setting it to `false` doesn't disable the feature.

### Explicit proxy configuration required

**Symptom**: Network-dependent features don't work even though your proxy doesn't require authentication.

**Category**: Settings required

**Solution**: Configure the proxy server address explicitly:

::: moniker range="visualstudio"

1. Go to **Tools** > **Options** > **Proxy Settings**.
1. Select **Use custom proxy settings**.
1. Enter the proxy server URL and port.
1. Restart Visual Studio for the changes to take effect.

For more information, see [Configure proxy settings in Visual Studio](proxy-settings.md).

::: moniker-end

::: moniker range="vs-2022"

Set the `HTTPS_PROXY` and `HTTP_PROXY` environment variables to your proxy server address. Copilot needs these set up for Visual Studio.

::: moniker-end

::: moniker range="visualstudio"

For detailed proxy configuration steps, see [Configure proxy settings in Visual Studio](proxy-settings.md).

::: moniker-end

## Troubleshoot SSL certificate issues

SSL certificate errors typically occur when your proxy server performs SSL inspection and the required certificates aren't properly installed or trusted. Use the following steps to diagnose the root cause.

### Answer diagnostic questions

Work through these questions to narrow down the issue:

1. **Are the certificates trusted?** Check if the proxy's CA certificate is installed in the current user's certificate store or the local machine store.
1. **Is Visual Studio running as a different user?** If Visual Studio runs as a different user than the one logged into Windows, it might not have access to certificates in the current user's store.
1. **Are you authenticated to online services?** Check if you can sign in to your Microsoft or GitHub account in Visual Studio.
1. **Did the feature work previously?** If the feature worked before and stopped working, an upstream network configuration change likely occurred. This isn't a Visual Studio product issue.
1. **Can you access other network resources?** If you can browse the web but Visual Studio features fail, the issue is specifically with Visual Studio's network connections.

### Identify the issue based on symptoms

Use these patterns to identify your specific issue:

- **Certificates in user store, VS running as different user**: Visual Studio might not be able to access the certificates. Install certificates in the local machine store instead.
- **Some features work but others fail**: This usually indicates an IPv6 issue or a difference between .NET Framework and .NET Core networking. See [Copilot Authentication works while Copilot Chat does not](#copilot-authentication-works-while-copilot-chat-does-not).
- **Worked yesterday, broken today**: An upstream network configuration change occurred. Contact your IT administrator to identify what changed.

### Diagnose partial certificate chain issues

If you see `PartialChain` errors, use the following steps to identify missing certificates. These steps require the OpenSSL command-line tool.

1. Run the following command to view the certificate chain, replacing `PROXY_HOST:PORT` with your proxy address and `target.host.com` with the endpoint you're trying to reach:

   ```bash
   openssl s_client -proxy PROXY_HOST:PORT -connect target.host.com:443 -showcerts -verify 5 </dev/null
   ```

1. For each certificate in the output, run the following command to check the chain (after saving each certificate to a file like `cert1.pem`, `cert2.pem`, and so on):

   ```bash
   openssl x509 -in cert1.pem -noout -subject -issuer -ski -aki
   ```

1. Verify the certificate chain by checking:
   - The **Authority Key Identifier (AKI)** of certificate N should match the **Subject Key Identifier (SKI)** of certificate N+1.
   - The **Issuer DN** of certificate N should match the **Subject DN** of certificate N+1.

If you find a break in the chain, contact your IT administrator to obtain and install the missing intermediate certificates.

> [!NOTE]
> .NET rejects requests if the AKI of one certificate doesn't match the SKI of the next certificate in the chain, even when web browsers succeed. This is a stricter validation than most browsers perform.

## Product issues: Collect diagnostic information for support

If you've determined that your issue is not a configuration issue after having supplied the required settings in Visual Studio, please file a feedback ticket. See [How to report a problem with Visual Studio](../how-to-report-a-problem-with-visual-studio.md). When filing a feedback ticket for proxy issues, include the following information to help us investigate. The more details you provide, the faster we can identify whether the issue is a product bug or a configuration problem.

### Check authentication status

Verify the following authentication states:

1. **GitHub authentication**:
   - Open **Windows** > **Credential Manager** > **Windows Credentials**.
   - Look for credentials with the `git:` prefix.
   - Check `%LocalAppData%/.IdentityService/GitHubV3AccountStore.json` for GitHub account metadata.

1. **Feature status**: Note which features are working and which are failing (for example, NuGet restore, extension installation, AI features).

### Gather logs and configuration details

Collect the following information:

1. **Visual Studio logs**: Create a zip file of `%temp%/Vslogs`.

1. **Network trace**: If possible, collect a Fiddler trace showing the failed requests.

1. **Proxy configuration details**:
   - Is this an explicit or transparent proxy?
   - Does the proxy require authentication? If so, what kind (Basic, NTLM, Kerberos)?
   - Is the proxy blocking or allowing specific applications?
   - Are the required certificates installed and trusted? Are any certificates revoked or expired?
   - Is a firewall also configured?
   - Is SSL inspection enabled?
   - Is IPv6 traffic being routed through the proxy?

1. **Comparison with other tools**: Does Visual Studio Code or other applications work through this proxy?

## Related content

::: moniker range="visualstudio"

- [Configure proxy settings in Visual Studio](proxy-settings.md)

::: moniker-end

- [Install and use Visual Studio behind a firewall or proxy server](../../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)
- [Visual Studio connectivity troubleshooting](../../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md#troubleshoot-network-related-errors)
