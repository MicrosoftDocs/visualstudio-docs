---
title: Manage certificates when deploying containerized apps
author: ghogen
description: Learn how to set up TLS (SSL) certificates for secure traffic over HTTPS in containerized applications when you deploy to Azure from Visual Studio.
ms.author: ghogen
ms.date: 9/10/2025
ms.subservice: container-tools
ms.topic: how-to
---
# Configure HTTPS when deploying containerized applications to Azure

When you deploy a containerized application, you typically use the HTTPS protocol for encrypted, secure communication. The secure communication is implemented by Transport Layer Security (TLS), which replaces the earlier method using Secure Sockets Layer (SSL).

:::moniker range="visualstudio"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows) or [Podman Desktop](https://podman-desktop.io/downloads).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta), or for Podman support, [Visual Studio (Insiders)](https://visualstudio.microsoft.com/insiders/?cid=learn-onpage-download-cta), with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed

:::moniker-end
::: moniker range="vs-2022"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed

:::moniker-end

::: moniker range="vs-2019"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, **.NET desktop development**, and/or **.NET Core cross-platform development** workload installed

:::moniker-end

## Devtest certificates

During development, Visual Studio uses a self-signed certificate, sometimes called a *devtest* certificate. You get a prompt asking you to trust the certificate when you launch the application on your local machine for the first time. This is acceptable for development and testing, but when you deploy to Azure and expose your application on a custom domain, you need to switch to a certificate issued by a Certificate Authority (CA), either Azure or a third-party CA.

## Security for deployment options in Azure

Many Azure services simplify the configuration and management burden by handling certificate management automatically. The configuration and procedure for setting up TLS for containers in Azure depends on the service you deploy to. 

In general, Azure services can support multiple ways of obtaining and storing certificates. You may obtain trusted certificates from Azure's own certificate authority (CA), or you may upload private trusted certificates issued by a third-party CA. You may make use of the service's own certificate store, or you may use Azure Key Vault to store the certificate, along with other secrets.

The following table shows the services and includes links that explain how HTTPS security works when you deploy to these services and how-to guides for managing the certificates.

| Azure Service | Notes |
| - | - |
| [Azure App Service](/azure/app-service/overview) | Azure App Service is a suitable deployment service for a single container that provides a default experience that means you get a secure endpoint with a trusted certificate provided by Azure without any additional overhead. For greater control, you can choose from multiple options for obtaining and storing the certificate. You may use your own trusted certificate obtained from a third-party CA instead of the default trusted certificate provided by Azure. Optionally, you can store certificates in Azure Key Vault. See [App Service TLS overview](/azure/app-service/overview-tls). |
| [Azure Container Apps](/azure/container-apps/overview) | Azure Container Apps is a suitable hosting service for containerized apps using one or more containers. Like Azure App Service, it provides a default experience that uses trusted Azure-provided certificates automatically, but also provides a range of networking architecture options to support different scenarios. See [Networking in Azure Container Apps](/azure/container-apps/networking?tabs=workload-profiles-env%2Cazure-cli).  |
| [Azure Container Instances](/azure/container-instances/container-instances-overview) | To configure HTTPS public endpoint for a container hosted in Azure Container Instances, see [Enable a TLS endpoint in a sidecar container](/azure/container-instances/container-instances-container-group-ssl). This option minimizes the impact to the container itself. |
| [Service Fabric](/azure/service-fabric/overview-managed-cluster) | See [Service Fabric application and service security](/azure/service-fabric/service-fabric-application-and-service-security). You typically set up a reverse proxy to handle security for incoming requests. See [Reverse proxy in Azure Service Fabric](/azure/service-fabric/service-fabric-reverseproxy). |
| [Azure Kubernetes Service (AKS)](/azure/aks/what-is-aks) | See the [guidance](/azure/aks/app-routing-dns-ssl) in the AKS documentation for setting up TLS for an ingress to your cluster. AKS provides the most advanced management capabilities, handling rotation and renewal of certificates with maximum flexibility. |

### Network security options for multiple containers

If your scenario involves multiple containers, you have the option of securing the ingress traffic only (that is, at the externally facing load balancer or reverse proxy), or you can apply secure communications between every container in the application. The latter option provides security for deeper layers of the system, even if there's a breach in the outer layer. Using HTTPS for all container-to-container communication is outside the scope of this article.

For Azure Container Apps, you can configure ingress which uses HTTPS for external callers, and within the network of multiple containers, use HTTP or TCP. For secure communication between containers, you can use mTLS (mutual TLS), which requires certificates on both sides of a request, client and server, or between microservices. See [Ingress in Azure Container Apps](/azure/container-apps/ingress-overview) and [Configure client certificate authentication in Azure Container Apps](/azure/container-apps/client-certificate-authorization).

## Related content

- [Deploy an ASP.NET Core container to Azure App Service using Visual Studio](deploy-app-service.md)
- [Use SSL for containerized ASP.NET Core apps](container-certificate-management.md)
