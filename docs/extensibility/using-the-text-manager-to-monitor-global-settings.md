---
title: "Using the Text Manager to Monitor Global Settings | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - monitor global settings"
  - "editors [Visual Studio SDK], legacy - text manager"
ms.assetid: 023e7671-cf65-419c-9bc1-3c4ee92aa436
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# Use the text manager to monitor global settings
If you implement a core editor, you must monitor the changes that are made to global settings, because these changes may affect your instance of the editor. You can track the changes by listening to events raised by the text manager. For example, when you specify a global preference for the appearance or behavior of a component in the core editor, such as its document data object, the text manager stores this information and communicates it to all affected clients.

## Text manager functions
 The text manager raises events for a number of settings, including the following:

- Whether a buffer is under source code control

- How to register for file-change notifications

- How to keep track of which views are associated with certain buffers

- Text colorization preferences

- Tab versus space preferences

  Preferences that are unique to a given language are not managed by the text manager. These settings must be managed by each language service.

  Event notification for the text manager is provided by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManagerEvents> interface. Implement this interface on your client object to handle events raised the text manager. You register for these events by using the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer> interface on the text manager.

## See also
- [Inside the core editor](../extensibility/inside-the-core-editor.md)
- [Editor features](https://msdn.microsoft.com/library/bdac940d-1f14-4019-a01f-fd0bb3dc7198)