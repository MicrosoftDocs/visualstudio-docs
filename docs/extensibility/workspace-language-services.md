---
title: "Workspaces and language services in Visual Studio"
description: Learn how language services can provide Open Folder users the same rich language features they are used to when working with solutions and projects.
ms.date: "02/21/2018"
ms.topic: article
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
---
# Workspaces and language services

Language services can provide [Open Folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) users the same rich language features they are used to when working with solutions and projects. A language service might self-activate based on the file extension or content of an opened document though this "loose file" language service is limited to syntax highlighting. Additional information is required to provide a richer experience when editing/reviewing source code. Each language service has its own API for initialization with this extra contextual data for a document. This is typically managed by a project system, which is tightly coupled both to the language service and to the build system.

## Initialization

In a [workspace](workspaces.md), language services are initialized by an <xref:Microsoft.VisualStudio.Workspace.Intellisense.ILanguageServiceProvider> extension point that specializes only in that language service and knows nothing of the build authoring. In this way, a language service owner can maintain a single Open Folder extension regardless of how many patterns exist within folders and files for running their compiler during a build (for example MSBuild, makefiles, etc.). When files from which a file context was created are changed on disk and the file context is refreshed, the language service provider is notified of the updated set of file contexts. The language service provider can then update its model.

When a document is opened in the editor, Visual Studio only considers language service providers that require file context types for which a matching file context provider can be found. It then passes the file context(s) from the matching provider(s) to the selected language service provider via `ILanguageServiceProvider.InitializeAsync`. What the language service provider does with that file context data is an implementation detail of the language service provider, but the expected user experience is a richer language service for that opened document.

## Using ILanguageServiceProvider

The language service will be notified when a file context is created with a `ContextType` that matches one of the `SupportedContextTypes` values of the language server export attribute.

To support a language service, an extension will need:

- A unique `Guid`. This will be used for `SupportedContextTypes` attribute arguments and in a `FileContext` object.
- Language file context
  - Provider factory
    - `ExportFileContextProviderAttribute` attribute with the above uniquely generated `Guid` in `SupportedContextTypes`
    - Implements `IWorkspaceProviderFactory<IFileContextProvider>`
  - Provider implementation of `IFileContextProvider.GetContextsForFileAsync`
    - Construct a new `FileContext` with the `contextType` constructor argument as the uniquely generated `Guid`
    - Use the `Context` property of the `FileContext` to give additional data to the `ILanguageServiceProvider`
- Language service
  - Provider factory
    - `ExportLanguageServiceProvider` attribute with the above uniquely generated `Guid` in `SupportedContextTypes`
    - Implements `IWorkspaceProviderFactory<ILanguageServiceProvider>`
  - Provider
    - Implements `ILanguageServiceProvider`
    - Use `ILanguageServiceProvider.InitializeAsync` to enable language services for the provided arguments when a file is opened
    - Use `ILanguageServiceProvider.UninitializeAsync` to disable language services for the provided arguments when a file is closed

>[!WARNING]
>The `ILanguageServiceProvider` methods might be invoked by the workspace on the main thread. Consider scheduling work on a different thread to avoid introducing UI delays.

## Language Server Protocol

The `Microsoft.VisualStudio.Workspace.*` APIs aren't the only way to enable your language service in Open Folder. Another option is to use a language server. For more information, read about the [Language Server Protocol](language-server-protocol.md).

## Related interfaces

- <xref:Microsoft.VisualStudio.Workspace.Intellisense.ILanguageServiceProvider> is invoked when a file of matching file types is opened or closed for editing.

## Related content

* [Workspace build](workspace-build.md) - Open Folder supports build systems such as MSBuild and makefiles.
