---
title: "How to use managed identity"
ms.technology: vs-azure
ms.date: 04/28/2021
ms.topic: "conceptual"
description: "Learn how to use managed identity in a Kubernetes cluster with Bridge to Kubernetes"
monikerRange: ">=vs-2019"
manager: jmartens
author: ghogen
ms.author: ghogen
---
# How to: Configure and use managed identity with Bridge to Kubernetes

If your AKS cluster uses [managed identity](/azure/active-directory/managed-identities-azure-resources/overview) security features to secure access to secrets and resources, Bridge to Kubernetes need some special configuration to ensure it can work with these features. An Azure Active Directory token needs to be downloaded to the local machine to ensure that local execution and debugging is properly secured, and this requires some special configuration in Bridge to Kubernetes. This article shows how to configure Bridge to Kubernetes to work with services that use managed identity.

## How to configure your service to use managed identity

To enable a local machine with support for managed identity, in the *KubernetesLocalConfig.yaml* file, in the `enableFeatures` section, add `ManagedIdentity`. Add the `enableFeatures` section if it's not already there.

```yaml
enableFeatures:
    ManagedIdentity
```

## How to fetch the Azure Active Directory tokens

You must ensure that you are relying on either <xref:Azure.Identity.DefaultAzureCredential> or <xref:Azure.Identity.ManagedIdentityCredential> in code when fetching the token.

The following C# code shows how to fetch storage account credentials when you use `ManagedIdentityCredential`:

```csharp
var credential = new ManagedIdentityCredential(miClientId);
Console.WriteLine("Created credential");
var containerClient = new BlobContainerClient(new Uri($"https://{accountName}.blob.windows.net/{containerName}"), credential);
Console.WriteLine("Created blob client");
```

The following code shows how to fetch storage account credentials when you use DefaultAzureCredential:

```csharp
var credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions() { ManagedIdentityClientId = miClientId });
Console.WriteLine("Created credential");
var containerClient = new BlobContainerClient(new Uri($"https://{accountName}.blob.windows.net/{containerName}"), credential);
Console.WriteLine("Created blob client");
```

## Receive Azure alerts when tokens are downloaded

Whenever you use Bridge to Kubernetes on a service, the managed identity token is downloaded to the local machine. You can enable Azure alerts to be notified when this occurs. For information, see [Enable Azure Defender](/azure/security-center/enable-azure-defender). Please be aware that there is a charge (after a 30-day trial period).

## Next steps

Learn more about managed identity at [About managed identities for Azure resources](/azure/active-directory/managed-identities-azure-resources/overview).

## See also

[Azure Active Directory](/azure/active-directory/managed-identities-azure-resources/)

