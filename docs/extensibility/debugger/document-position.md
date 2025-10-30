---
title: Document Position
description: Learn how a document position in Visual Studio debugging provides an abstraction of a position in a source file as known to the IDE.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], contexts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Document position

In Visual Studio debugging, a *document position*:

- Provides an abstraction of a position in a source file as known to the IDE. For most languages today, a document position can be thought of as a position in a source file.

- Describes a position in a source document to a debug engine.

- Is implemented by an [IDebugDocumentPosition2](../../extensibility/debugger/reference/idebugdocumentposition2.md) interface.

## See also
- [Code context](../../extensibility/debugger/code-context.md)
- [Document context](../../extensibility/debugger/document-context.md)
- [Symbol provider](../../extensibility/debugger/symbol-provider.md)
- [Symbol provider Interfaces](../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
