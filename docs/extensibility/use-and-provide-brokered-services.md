---
title: Using and providing brokered services
description: Learn about the brokered services that the Visual Studio IDE and extensions provide and use. These articles describe how to get and provide brokered services.
monikerRange: '>= vs-2019'
ms.custom: SEO-VS-2020
ms.date: 01/06/2022
ms.topic: conceptual
helpviewer_keywords:
- examples [Visual Studio SDK], brokered services
- Visual Studio, brokered services
- brokered services
ms.assetid: d2b743f2-a06b-4f82-aaef-f207046a299e
author: aarnott
ms.author: andarno
manager: ansonh
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Using and providing brokered services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

A brokered service is a service acquired via an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>,
and is exposed as an RPC-compatible interface to enable the service and its client to exist in distinct AppDomains, processes or even across machines (in the case of Live Share).

VS Packages can offer services of their own by using the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer> interface.

[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] offers important brokered services, such as the following:

|Brokered service|Description|
|-----------------|-----------------|
|<xref:Microsoft.VisualStudio.RpcContracts.OutputChannel.IOutputChannelStore>|Allows streaming text to the output window.
|<xref:Microsoft.VisualStudio.RpcContracts.OpenDocument.IOpenDocumentService>|Allows opening documents.
|<xref:Microsoft.VisualStudio.RpcContracts.FileSystem.IFileSystem>|Allows access to local or remote file systems.

## In this section
- [Brokered Service Essentials](internals/brokered-service-essentials.md)
 Presents the important elements of a Visual Studio brokered service and how they differ from other [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] services.

- [Discovering Available Brokered Services](internals/discover-available-brokered-services.md)
 Describes how to discover the available set of brokered services.

- [How to: Get a Brokered Service](how-to-consume-brokered-service.md)
 Discusses how to request (consume) a brokered service.

- [How to: Provide a Brokered Service](how-to-provide-brokered-service.md)
 Discusses how to provide a brokered service.

- [How to: Troubleshoot Brokered Services](how-to-troubleshoot-brokered-services.md)
 Discusses common problems and presents solutions to them.

## Related sections
- [Visual Studio SDK](visual-studio-sdk.md)
