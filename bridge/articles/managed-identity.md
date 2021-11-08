---
title: "How to use managed identity with Bridge to Kubernetes"
ms.technology: bridge
ms.custom: "contperf-fy22q1"
ms.date: 04/28/2021
ms.topic: "conceptual"
description: "Learn how to use Azure Active Directory (Azure AD) managed identity in an AKS cluster with Bridge to Kubernetes"
manager: jmartens
author: ghogen
ms.author: ghogen
---
# Use managed identity with Bridge to Kubernetes

If your AKS cluster uses [managed identity](/azure/active-directory/managed-identities-azure-resources/overview) security features to secure access to secrets and resources, Bridge to Kubernetes needs some special configuration to ensure it can work with these features. An Azure Active Directory (AD) token needs to be downloaded to the local machine to ensure that local execution and debugging is properly secured, and this requires some special configuration in Bridge to Kubernetes. This article shows how to configure Bridge to Kubernetes to work with services that use managed identity.

## How to configure your service to use managed identity

To enable a local machine with support for managed identity, in the *KubernetesLocalConfig.yaml* file, in the `enableFeatures` section, add `ManagedIdentity`. Add the `enableFeatures` section if it's not already there.

```yaml
enableFeatures:
  - ManagedIdentity
```

> [!WARNING]
> Be sure to only use managed identity for Bridge to Kubernetes when working with dev clusters, not production clusters, because the Azure AD token is fetched to the local machine, which presents a potential security risk.

If you don't have a *KubernetesLocalConfig.yaml* file, you can create one; see [How to: Configure Bridge to Kubernetes](configure-bridge-to-kubernetes.md).

## How to fetch the Azure Active Directory tokens

You must ensure that you are relying on either `Azure.Identity.DefaultAzureCredential` or `Azure.Identity.ManagedIdentityCredential` in code when fetching the token.

The following C# code shows how to fetch storage account credentials when you use `ManagedIdentityCredential`:

```csharp
var credential = new ManagedIdentityCredential(miClientId);
Console.WriteLine("Created credential");
var containerClient = new BlobContainerClient(new Uri($"https://{accountName}.blob.windows.net/{containerName}"), credential);
Console.WriteLine("Created blob client");
```

The following code shows how to fetch storage account credentials when you use DefaultAzureCredential:

```csharp
var credential = new DefaultAzureCredential();
Console.WriteLine("Created credential");
var containerClient = new BlobContainerClient(new Uri($"https://{accountName}.blob.windows.net/{containerName}"), credential);
Console.WriteLine("Created blob client");
```

To learn how to access other Azure resources using managed identity, see the [Next steps](#next-steps) section.

## Receive Azure alerts when tokens are downloaded

Whenever you use Bridge to Kubernetes on a service, the Azure AD token is downloaded to the local machine. You can enable Azure alerts to be notified when this occurs. For information, see [Enable Azure Defender](/azure/security-center/enable-azure-defender). Please be aware that there is a charge (after a 30-day trial period).

## Next steps

Now that you've configured Bridge to Kubernetes to work with your AKS cluster that uses managed identity, you can debug as normal. See [bridge-to-kubernetes.md#connect-to-your-cluster-and-debug-a-service].

Learn more about using managed identify to access Azure resources by following these tutorials:

- [Tutorial: Use a Linux VM system-assigned managed identity to access Azure Storage](/azure/active-directory/managed-identities-azure-resources/tutorial-linux-vm-access-storage)
- [Tutorial: Use a Linux VM system-assigned managed identity to access Azure Data Lake Store](/azure/active-directory/managed-identities-azure-resources/tutorial-linux-vm-access-datalake)
- [Tutorial: Use a Linux VM system-assigned managed identity to access Azure Key Vault](/azure/active-directory/managed-identities-azure-resources/tutorial-linux-vm-access-nonaad)

There are other tutorials in that section as well for using managed identity to access other Azure resources.

## See also

[Azure Active Directory](/azure/active-directory/managed-identities-azure-resources/)
