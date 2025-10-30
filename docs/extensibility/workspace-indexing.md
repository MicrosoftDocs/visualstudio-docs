---
title: "Workspace indexing in Visual Studio"
description: Learn about workspace indexing, which is the collection and persistent storage of data to support rich IDE features for an Open Folder workspace.
ms.date: "02/21/2018"
ms.topic: article
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
---
# Workspace indexing

In a solution, project systems are responsible for providing functionality for build, debug, **GoTo** symbol searching, and more. Project systems can do this work because they understand the relation and capabilities of files within a project. An [Open Folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) workspace needs the same insight to provide rich IDE features as well. The collection and persistent storage of this data is a process called workspace indexing. This indexed data can be queried through a set of asynchronous APIs. Extenders can participate in the indexing process by providing <xref:Microsoft.VisualStudio.Workspace.Indexing.IFileScanner>s that know how to handle certain types of files.

## Types of indexed data

There are three kinds of data that are indexed. Note the type expected from file scanners differs from the type deserialized from the index.

|Data|File scanner type|Index query result type|Related types|
|--|--|--|--|
|References|<xref:Microsoft.VisualStudio.Workspace.Indexing.FileReferenceInfo>|<xref:Microsoft.VisualStudio.Workspace.Indexing.FileReferenceResult>|<xref:Microsoft.VisualStudio.Workspace.Indexing.FileReferenceInfoType>|
|Symbols|<xref:Microsoft.VisualStudio.Workspace.Indexing.SymbolDefinition>|<xref:Microsoft.VisualStudio.Workspace.Indexing.SymbolDefinitionSearchResult>|<xref:Microsoft.VisualStudio.Workspace.Indexing.ISymbolService> should be used instead of `IIndexWorkspaceService` for queries|
|Data values|<xref:Microsoft.VisualStudio.Workspace.Indexing.FileDataValue>|<xref:Microsoft.VisualStudio.Workspace.Indexing.FileDataResult`1>||

## Querying for indexed data

There are two asynchronous types available to access persisted data. The first is through <xref:Microsoft.VisualStudio.Workspace.Indexing.IIndexWorkspaceData>. It provides basic access to a single file's `FileReferenceResult` and `FileDataResult` data, and it caches results. The second is the <xref:Microsoft.VisualStudio.Workspace.Indexing.IIndexWorkspaceService> which doesn't use caching, but allows for more querying capabilities.

```csharp
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Indexing;

private static IIndexWorkspaceData GetCachedIndexedData(IWorkspace workspace)
{
    // Gets access to indexed data wrapped in a cache.
    return workspace?.GetIndexWorkspaceDataService()?.CreateIndexWorkspaceData();
}

private static IIndexWorkspaceService GetDirectIndexedData(IWorkspace workspace)
{
    // Gets direct access to indexed data.
    // Can also be casted to IIndexWorkspaceService2.
    return workspace?.GetIndexWorkspaceService();
}
```

## Participating in indexing

Workspace indexing roughly follows the following sequence:

1. Discovery and persistence of file system entities in the workspace (only on initial opening scan).
1. Per file, the matching provider with the highest priority is asked to scan for `FileReferenceInfo`s.
1. Per file, the matching provider with the highest priority is asked to scan for `SymbolDefinition`s.
1. Per file, all providers are asked for `FileDataValue`s.

Extensions can export a scanner by implementing `IWorkspaceProviderFactory<IFileScanner>` and exporting the type with <xref:Microsoft.VisualStudio.Workspace.Indexing.ExportFileScannerAttribute>. The `SupportedTypes` attribute argument should be one or more values from <xref:Microsoft.VisualStudio.Workspace.Indexing.FileScannerTypeConstants>. For an example scanner, see the VSSDK [sample](https://github.com/Microsoft/VSSDK-Extensibility-Samples/blob/master/Open_Folder_Extensibility/C%23/SymbolScannerSample/TxtFileSymbolScanner.cs).

> [!WARNING]
> Do not export a file scanner that supports the `FileScannerTypeConstants.FileScannerContentType` type. It is used for Microsoft internal purposes, only.

In advanced situations, an extension might dynamically support an arbitrary set of file types. Rather than MEF exporting `IWorkspaceProviderFactory<IFileScanner>`, an extension can export `IWorkspaceProviderFactory<IFileScannerProvider>`. When indexing begins, this factory type will be imported, instantiated, and have its <xref:Microsoft.VisualStudio.Workspace.Indexing.IFileScannerProvider.GetSymbolScannersAsync%2A> method invoked. `IFileScanner` instances supporting any value from `FileScannerTpeConstants` will be honored, not just symbols.

## Related content

* [Workspaces and language services](workspace-language-services.md) - Learn how to integrate language services into an Open Folder workspace.
* [Workspace build](workspace-build.md) - Open Folder supports build systems such as MSBuild and makefiles.
