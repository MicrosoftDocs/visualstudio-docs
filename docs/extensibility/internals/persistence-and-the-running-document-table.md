---
title: Persistence and the Running Document Table | Microsoft Docs
description: Learn how projects coordinate document opening, saving, and renaming in the running document table, which tracks document state in the Visual Studio IDE.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- persistence, managing
- IVsPersistHierarchyItem interface, implementing
- architecture, persistence
- running document table (RDT), architecture
ms.assetid: 27117eae-6c58-4189-a61a-1397a43b5ecf
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Persistence and the Running Document Table
In the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE, projects are completely responsible for managing the persistence of their project items, which they accomplish using the service, <xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable>. Documents are the basic unit of persistence in the Visual Studio environment. Projects coordinate the opening, saving, and renaming of documents with the running document table (RDT), a resource that tracks the state of all open documents.

## Managing Persistence
 Projects control the environment's persistence service by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem> interface. While the environment never directly asks a document to persist itself, it asks the owning project (or hierarchy) to save the document. This makes it possible for the project to save its project item data into local files, remote files, a database, a repository, or other medium.

 The global environment maintains the RDT. The environment maintains entries for all open windows and documents in the RDT, which makes it possible for them to receive special notifications, such as when a solution is closed. In addition, the RDT makes it possible for the environment to track their corresponding nodes in **Solution Explorer**. The RDT maintains one record per open, persistable object, including both project files and project-item documents.

## See also
- [Running Document Table](../../extensibility/internals/running-document-table.md)
- [Selection and Currency in the IDE](../../extensibility/internals/selection-and-currency-in-the-ide.md)
