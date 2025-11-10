---
title: Manage SSL certificates for containerized apps
author: ghogen
description: Lear how to use secure communications over HTTPS for a containerized app using SSL, and manage certificates and ports.
ms.author: ghogen
ms.date: 09/10/2025
ms.subservice: container-tools
ms.topic: how-to
---

# Use SSL for containerized ASP.NET Core apps

SSL (Secure Sockets Layer) provides secure connections over HTTP (HTTPS). This method of securing connections uses a certificate, and in a containerized app, the port mappings are different for secured and unsecured entry points.

:::moniker range="visualstudio"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows) or [Podman Desktop](https://podman-desktop.io/downloads).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta), or for Podman support, [Visual Studio 2026](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta), with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed.

:::moniker-end
::: moniker range="vs-2022"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed.

:::moniker-end

::: moniker range="vs-2019"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, **.NET desktop development**, and/or **.NET Core cross-platform development** workload installed.

:::moniker-end

## Security for multicontainer apps

Multicontainer app architectures vary depending on security requirements. Some app designs use HTTPS for external endpoints, but HTTP for internal communication from one container to another. High-security environments might use HTTPS for all communications, even between containers that are only accessible within a secure outer perimeter.

## Ports and port mappings

The Dockerfile contains directives for exposing ports to external traffic over unsecured HTTP or secure HTTPS. Also, .NET 8 and later run the containerized app as a typical user, but in earlier .NET versions, containerized apps run as administrator. When running as administrator, apps have access to the privileged ports 80 for HTTP traffic and 443 HTTPS traffic. When apps run as users without elevated privileges, they use ports 8080 for HTTP and 8081 for HTTPS. The ports appear in the EXPOSE commands in the Dockerfile that Visual Studio generates. The ports in the container specified in the Dockerfile are mapped to host ports using the mappings specified in the launch settings file. See [Container tools launch settings](container-launch-settings.md). When the container is running, you can view the port mappings in the **Containers** window. See [View and diagnose containers](view-and-diagnose-containers.md#view-port-mappings).

## Certificates

Container tools in Visual Studio support debugging an SSL-enabled ASP.NET core app with a dev certificate, the same way you'd expect it to work without containers. To make that happen, Visual Studio adds a couple of more steps to export the certificate and make it available to the container. Here is the flow that Visual Studio handles for you when debugging in the container:

1. Ensures the local development certificate is present and trusted on the host machine through the `dev-certs` tool.
2. Exports the certificate to `%APPDATA%\ASP.NET\Https` with a secure password that is stored in the user secrets store for this particular app.
3. Volume-mounts the following directories:

   - `*%APPDATA%\Microsoft\UserSecrets`
   - `*%APPDATA%\ASP.NET\Https`

ASP.NET Core looks for a certificate that matches the assembly name under the *Https* folder, which is why it's mapped to the container in that path. The certificate path and password can alternatively be defined using environment variables (that is, `ASPNETCORE_Kestrel__Certificates__Default__Path` and `ASPNETCORE_Kestrel__Certificates__Default__Password`) or in the user secrets json file, for example:

```json
{
  "Kestrel": {
    "Certificates": {
      "Default": {
        "Path": "c:\\app\\mycert.pfx",
        "Password": "strongpassword"
      }
    }
  }
}
```

If your configuration supports both containerized and non-containerized builds, you should use the environment variables, because the paths are specific to the container environment.

For more information about using SSL with ASP.NET Core apps in containers, see [Hosting ASP.NET Core images with Docker over HTTPS](/aspnet/core/security/docker-https).

For a code sample that demonstrates creating custom certificates for a multi-service app that are trusted on the host and in the containers for HTTPS service-to-service communication, see [CertExample](https://github.com/NCarlsonMSFT/CertExample).

If you plan to deploy your containerized app to Azure, see [Configure HTTPS when deploying containerized applications to Azure](manage-certificates.md).
