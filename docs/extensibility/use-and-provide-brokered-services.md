---
title: Using and providing brokered services
description: Learn about the brokered services that the Visual Studio IDE and extensions provide and use. These articles describe how to get and provide brokered services.
monikerRange: '>= vs-2019'
ms.date: 01/06/2022
ms.topic: conceptual
helpviewer_keywords:
- examples [Visual Studio SDK], brokered services
- Visual Studio, brokered services
- brokered services
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Using and providing brokered services

A brokered service is a service acquired via an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>, and is exposed as an RPC-compatible interface to enable the service and its client to exist in distinct AppDomains, processes or even across machines (in the case of Live Share).

VS Packages can offer services of their own by using the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer> interface.

Visual Studio offers important brokered services, such as the following:

|Brokered service|Description|
|-----------------|-----------------|
|<xref:Microsoft.VisualStudio.RpcContracts.OutputChannel.IOutputChannelStore>|Allows streaming text to the output window.|
|<xref:Microsoft.VisualStudio.RpcContracts.OpenDocument.IOpenDocumentService>|Allows opening documents.|
|<xref:Microsoft.VisualStudio.RpcContracts.FileSystem.IFileSystem>|Allows access to local or remote file systems.|

## In this section

- [Brokered Service Essentials](internals/brokered-service-essentials.md) presents the important elements of a Visual Studio brokered service and how they differ from other Visual Studio services.

- [Discovering Available Brokered Services](internals/discover-available-brokered-services.md) describes how to discover the available set of brokered services.

- [How to: Get a Brokered Service](how-to-consume-brokered-service.md) discusses how to request (consume) a brokered service.

- [How to: Provide a Brokered Service](how-to-provide-brokered-service.md) discusses how to provide a brokered service.

- [How to: Troubleshoot Brokered Services](/troubleshoot/developer/visualstudio/extensibility/how-to-troubleshoot-brokered-services) discusses common problems and presents solutions to them.

## Related sections

- [Visual Studio SDK](visual-studio-sdk.md)
