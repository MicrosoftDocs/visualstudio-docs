---
title: Editor remote procedure calls (RPC)
description: Learn about the RPC protocol for editor-based extensions.
ms.date: 3/31/2023
ms.topic: conceptual
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Editor RPC support

Since the new Visual Studio extensibility model is entirely in a separate process, and communication between the extension process and the Visual Studio process occurs through a stream, all APIs have to at some level operate with serializable data types. Typically, extensions can ignore these implementation details. In some scenarios, an extension may need to interface directly with RPC services acquired from `this.Extensibility.ServiceBroker`.

## Serializable RPC types

To facilitate interactions with RPC services, the object model exposes [RpcContract](/dotnet/api/microsoft.visualstudio.extensibility.editor.selection.rpccontract) properties on most core types, and the following serializable RPC types:

- `VersionedTextDocumentRange` - 1:1 serializable version of `Span`, which you can access through the `RpcContract` property. This type should be used in most RPC contracts between processes.
- `VersionedTextDocumentPosition` - 1:1 serializable version of `Position`, which you can access through the `RpcContract` property. This type should be used in most RPC contracts between processes.
- `Range` - Serializable version of Span, omitting the Uri and version number.
- `Microsoft.VisualStudio.RpcContracts.Utilities.Position` - Serializable version of `Position`, omitting the Uri and version number.
- `TextView` - 1:1 serialized form of `ITextView`, which you can access through the `RpcContract` property.
- `TextDocument` - 1:1 serialized form of `ITextDocument` through the `RpcContract` property.

As opposed to `VersionedTextDocumentRange` and `VersionedTextDocumentPosition`, `Range` and `Microsoft.VisualStudio.RpcContracts.Utilities.Position` omit the Uri and document version, making for a smaller serializable representation. This type should be used in RPC contracts that contain lots of span/range equivalents that need to reduce their payload size for performance. These RPC contracts need to pass the document Uri and version for the spans or range to be instantiated into `Span` and `Position` objects by the [IEditorHostService](/dotnet/api/microsoft.visualstudio.extensibility.editor.ieditorhostservice). `IEditorHostService` interfaces with extension-local copies of the text buffer, and manages opening and closing of documents described by the RPC types.

## Related content

Learn more about Remote UI, the RPC model used in VS.Extensibilty at [Remote UI](../inside-the-sdk/remote-ui.md).