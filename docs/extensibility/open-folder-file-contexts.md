---
title: "Open Folder File Contexts in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "02/21/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
ms.workload:
  - "vssdk"
---
# Open Folder file contexts

All insights in workspaces are produced by "file context providers" that implement the <xref:Microsoft.VisualStudio.Workspace.IFileContextProvider> interface. These extensions might look for patterns in folders or files, read MSBuild files, makefiles, package dependencies, etc. in order to accumulate the insights they need to define a file context. A file context by itself does not perform any action, but rather provides data that another extension can then act on.

Each <xref:Microsoft.VisualStudio.Workspace.FileContext> has a `Guid` associated with it that identifies the type of data it carries. A workspace uses this `Guid` later to match it up with extensions that consume the data through the <xref:Microsoft.VisualStudio.Workspace.FileContext.Context> property. A file context provider is exported with metadata that identifies which file context `Guid`s it may produce data for.

Once contrived, a file context can be associated with any number of files or folders in the workspace. A given file or folder may be associated with any number of file contexts. It's a many-to-many relationship.

The most common scenarios for file contexts are related to build, debug, and language services. For more information, see other sections related to these scenarios.

## File context lifecycle

Lifecycles for a `FileContext` are non-deterministic. At any time, a component can asynchronously request for some set of context types. Providers with that support some subset of the request context types will be queried. The providers The `IWorkspace` instance acts as the middle-man between the consumer and providers through the <xref:Microsoft.VisualStudio.Workspace.IWorkspace.GetFileContextsAsync%2A> method. Consumers might request a context and perform some action based on the context. Others might request a context and maintain a long lived reference. However, changes might happen to files that cause a file context to become outdated. The provider can fire an event handler on the `FileContext` to notify consumers of updates. For example, if a build context is provided for some file but an on-disk change invalidates that context, then the original producer can invoke. Any consumers still referencing that `FileContext` can then requery for a new `FileContext`.

>[!NOTE]
>There is no push model to consumers. Consumers won't be notified of a provider's new `FileContext` after their request.

## Expensive file context computations

Reading contents from the disk can be expensive, especially when a provider needs to find the relation between files. For example, a provider is queried for some source file's file context, but the file context is dependent on metadata from a project file. Parsing the project file or evaluating it with MSBuild is expensive. Instead, the extension can export an `IFileScanner` to create `FileDataValue` data during workspace indexing. Then when asked for file contexts, the `IFileContextProvider` can quickly query for that indexed data. the For more information on indexing, see the [Workspace indexing](#Workspace-indexing) section.

>[!WARNING]
>Be cautious of other ways your `FileContext` might be expensive to compute. Some UI interactions are synchronous and rely on a high volume of `FileContext` requests. Examples include opening an editor tab and opening a **Solution Explorer** context menu. These actions make many build context type requests.

## File context related APIs

- <xref:Microsoft.VisualStudio.Workspace.FileContext> holds data and metadata.
- <xref:Microsoft.VisualStudio.Workspace.IFileContextProvider> and <xref:Microsoft.VisualStudio.Workspace.IFileContextProvider`1> create the file context.
- <xref:Microsoft.VisualStudio.Workspace.ExportFileContextProviderAttribute> exports a file context provider.
- <xref:Microsoft.VisualStudio.Workspace.IWorkspace.GetFileContextsAsync%2A> is used for consumers to get file contexts.
- <xref:Microsoft.VisualStudio.Workspace.Build.BuildContextTypes> defines build context types that Open Folder will consume.

## File context actions

While a `FileContext` itself is just data about some file(s), an <xref:Microsoft.VisualStudio.Workspace.IFileContextAction> is a way to express and act on that data. `IFileContextAction` is flexible in its usage. Two of its most common cases are building and debugging.

## Reporting progress

The <xref:Microsoft.VisualStudio.Workspace.IFileContextActionBase.ExecuteAsync%2A> method is passed `IProgress<IFileContextActionProgressUpdate>`, but the argument shouldn't be used as that type. `IFileContextActionProgressUpdate` is an empty interface, and invoking `IProgress<IFileContextActionProgressUpdate>.Report(IFileContextActionProgressUpdate)` might throw `NotImplementedException`. Instead, the `IFileContextAction` must cast the argument to another type as necessary for the scenario.

For information on the types supplied by Visual Studio, see the respective scenario's documentation.

## File context action related APIs

- <xref:Microsoft.VisualStudio.Workspace.IFileContextAction> executes some behavior based on a `FileContext`.
- <xref:Microsoft.VisualStudio.Workspace.IFileContextActionProvider> creates instances of `IFileContextAction`.
- <xref:Microsoft.VisualStudio.Workspace.ExportFileContextActionProviderAttribute> exports the type `IWorkspaceProviderFactory<IFileContextActionProvider>`.

## File watching

A workspace listens to file change notifications and provides the <xref:Microsoft.VisualStudio.Workspace.IFileWatcherService> via <xref:Microsoft.VisualStudio.Workspace.WorkspaceServiceHelper.GetFileWatcherService%2A>. Files matching the "ExcludedItems" setting will not produce file notification events. A threshold between events is used for notification simplification and duplicate reduction. When you need to react to a file change, you should subscribe to this service.

>[!TIP]
>A workspace's indexing service is subscribed to file events. File additions and modifications will cause relevant `IFileScanner`s to be invoked for new data for that file. File deletions will remove indexed data. You don't need to subscribe your `IFileScanner` to the file watcher service.
