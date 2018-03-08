---
title: "Open Folder Extensibility Overview | Microsoft Docs"
ms.custom: ""
ms.date: "02/21/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 154825cf-901a-4957-ad8b-bad5403c30c2
caps.latest.revision: 1
author: "svukel"
ms.author: "svukel"
manager: "viveis"
ms.workload: 
  - "vssdk"
---
# Open Folder Extensibility

## Introduction of Open Folder

Open Folder is a new experience introduced in Visual Studio 2017. It allows users to open any codebase. Without any workloads installed, Open Folder provides Solution Explorer tree population and search, editor colorization, GoTo and Find in Files search, and more. Other workloads, like the workloads for .NET and C++ development, power richer Intellisense and specific language-specific functionality.

### A divergence from project systems

Historically, Visual Studio only understood files in a Solution and its projects using project systems. A project system is responsible for the functionality and user interactions of a loaded project. It understands what files its project contains, the visual representation of the project contents, dependencies on other projects, and modification of the underlying project file. It's through these hierarchies and capabilities that other components can do some work on behalf of the user. Not all user codebases are represented in this structure. Scripting language projects where there is nothing 'buildable' are an example. With Open Folder, Visual Studio gives end users a new way of interacting with any of their code.

New APIs under the `Microsoft.VisualStudio.Workspace.*` are available for extenders to produce and consume data or actions around files within Open Folder. New concepts or different extension point areas include:

- File contexts and actions
- Workspace indexing
- Build and debug
- Tasks.vs.json and launch.vs.json
- Workspace settings

Features that use the following types will need to adopt new APIs to support Open Folder:

- `IVsHierarchy`
- `IVsProject`
- `DTE`

## Workspaces

A workspace is how Visual Studio represents any collection of files in Open Folder, and it's represented [IWorkspace][Doc:IWorkspace] type. By itself, the workspace doesn't understand the contents or features related to files within the folder. Rather, it provides a general set of APIs for features and extensions to produce and consume data that others can act upon. The producers are composed through MEF using various export attributes.

### Workspace providers and services

Workspace providers and services provide the data and functionality to react to the contents of a workspace. They might provide contextual file information, symbols in source files, or build functionality.

Both concepts use a factory pattern and are imported by MEF by the workspace. All export attributes implement `IProviderMetadataBase` or `IWorkspaceServiceFactoryMetadata`, but there are concrete types extensions should use for exported types.

One difference between providers and services is their relation to the workspace. A workspace can have many providers of a particular type, but only one service of a particular type is created per workspace. For example, a workspace has many file scanner providers but the workspace has only one indexing service per workspace.

Another key difference is consumption of data from providers and services. The workspace is the entry point to get data from providers for a couple reasons. First, providers typically have some narrow set of data they create. The data might be symbols for a C# source file or build file contexts for a _CMakeLists.txt_ file. The workspace will match a consumers request to the providers whose metadata align with the request. Second, some scenarios allow for many providers to contribute to a request while others scenarios use the provider with highest priority.

In contrast, extensions can get instances of and interact directly with workspaces services. Extension methods on `IWorkspace` are available for the services provided by Visual Studio, such as [IWorkspace.GetFileWatcherService][Doc:WorkspaceServiceHelper.GetFileWatcherService]. Your extension may offer a workspace service for components within your extension or for other extensions to consume. Consumers should use [IWorkspace.GetServiceAsync][Doc:WorkspaceServiceHelper.GetServiceAsync] or an extension method you provide on the `IWorkspace` type.

>![Warning]
> Do not author services that conflict with Visual Studio. It will lead to unexpected issues.

### Disposal on workspace closure

On closure of a workspace, extenders might need to dispose but call asynchronous code. The [IAsyncDisposable][Doc:IAsyncDisposable] interface is available to make writing this code easy.

### Related types

- [IWorkspace][Doc:IWorkspace] is the central entity for an opened workspace like an opened folder.
- [IWorkspaceProviderFactory\<T\>][Doc:IWorkspaceProviderFactory<T>] creates a provider per workspace instantiated.
- [IWorkspaceServiceFactory\<T\>][Doc:IWorkspaceServiceFactory<T>] creates a service per workspace instantiated.
- [IAsyncDisposable][Doc:IAsyncDisposable] should be implemented on providers and services that need to run asynchronous code during disposal.
- [WorkspaceServiceHelper][Doc:WorkspaceServiceHelper] provides helper methods for accessing well-known services or arbitrary services.

## File contexts

All insights in workspaces are produced by "file context providers" that implement the [IFileContextProvider][Doc:IFileContextProvider] interface. These extensions might look for patterns in folders or files, read MSBuild files, makefiles, package dependencies, etc. in order to accumulate the insights they need to define a file context. A file context by itself does not perform any action, but rather provides data that another extension can then act on.

Each [FileContext][Doc:FileContext] has a `Guid` associated with it that identifies the type of data it carries. A workspace uses this `Guid` later to match it up with extensions that consume the data through the [FileContext.Context][Doc:FileContext.Context] property. A file context provider is exported with metadata that identifies which file context `Guid`s it may produce data for.

Once contrived, a file context can be associated with any number of files or folders in the workspace. A given file or folder may be associated with any number of file contexts. It's a many-to-many relationship.

The most common scenarios for file contexts are related to build, debug, and language services. For more information, see other sections related to these scenarios.

### `FileContext` lifecycle

Lifecycles for a `FileContext` are non-deterministic. At any time, a component can asynchronously request for some set of context types. Providers with that support some subset of the request context types will be queried. The providers The `IWorkspace` instance acts as the middle-man between the consumer and providers through the [IWorkspace.GetFileContextsAsync][Doc:IWorkspace.GetFileContextsAsync] method. Consumers might request a context and perform some action based on the context. Others might request a context and maintain a long lived reference. However, changes might happen to files that cause a file context to become outdated. The provider can fire an event handler on the `FileContext` to notify consumers of updates. For example, if a build context is provided for some file but an on-disk change invalidates that context, then the original producer can invoke [FileContext.OnFileContextChanged][Doc:FileContext.OnFileContextChanged]. Any consumers still referencing that `FileContext` can then requery for a new `FileContext`.

>[!NOTE]
>There is no push model to consumers. Consumers won't be notified of a provider's new `FileContext` after their request.

### Expensive file context computations

Reading contents from the disk can be expensive, especially when a provider needs to find the relation between files. For example, a provider is queried for some source file's file context, but the file context is dependent on metadata from a project file. Parsing the project file or evaluating it with MSBuild is expensive. Instead, the extension can export an `IFileScanner` to create `FileDataValue` data during workspace indexing. Then when asked for file contexts, the `IFileContextProvider` can quickly query for that indexed data. the For more information on indexing, see the [Workspace indexing](#Workspace-indexing) section.

>![Warning]
>Be cautious of other ways your `FileContext` might be expensive to compute. Some UI interactions are synchronous and rely on a high volume of `FileContext` requests. Examples include opening an editor tab and opening a **Solution Explorer** context menu. These actions make many build context type requests.

### File context related APIs

- [FileContext][Doc:FileContext] holds data and metadata.
- [IFileContextProvider][Doc:IFileContextProvider] and [IFileContextProvider\<T\>][Doc:IFileContextProvider<T>] create the file context.
- [ExportFileContextProviderAttribute][Doc:ExportFileContextProviderAttribute] exports a file context provider.
- [IWorkspace.GetFileContextsAsync][Doc:IWorkspace.GetFileContextsAsync] is used for consumers to get file contexts.
- [BuildContextTypes][Doc:BuildContextTypes] defines build context types that Open Folder will consume.

## File context actions

While a `FileContext` itself is just data about some file(s), an [IFileContextAction][Doc:IFileContextAction] is a way to express and act on that data. `IFileContextAction` is flexible in its usage. Two of its most common cases are building and debugging.

### Reporting progress

The [IFileContextAction.ExecuteAsync][Doc:IFileContextActionBase.ExecuteAsync] method is passed `IProgress<IFileContextActionProgressUpdate>`, but the argument shouldn't be used as that type. `IFileContextActionProgressUpdate` is an empty interface, and invoking `IProgress<IFileContextActionProgressUpdate>.Report(IFileContextActionProgressUpdate)` might throw `NotImplementedException`. Instead, the `IFileContextAction` must cast the argument to another type as necessary for the scenario.

For information on the types supplied by Visual Studio, see the respective scenario's documentation.

### File context action related APIs

- [IFileContextAction][Doc:IFileContextAction] executes some behavior based on a `FileContext`.
- [IFileContextActionProvider][Doc:IFileContextActionProvider] creates instances of `IFileContextAction`.
- [ExportFileContextActionProviderAttribute][Doc:ExportFileContextActionProviderAttribute] exports the type `IWorkspaceProviderFactory<IFileContextActionProvider>`.

## Workspace indexing

In a Solution, project systems are responsible for providing functionality for build, debug, **GoTo** symbol searching, and more. Project systems can do this work because they understand the relation and capabilities of files within a project. A workspace needs the same insight to provide rich IDE features, too. The collection and persistent storage of this data is a process called workspace indexing. This indexed data can be queried through a set of asynchronous APIs. Extenders can participate in the indexing process by providing `IFileScanner`s that know how to handle certain types of files.

### Types of indexed data

There are three kinds of data that are indexed. Note the type expected from file scanners differs from the type deserialized from the index.

|Data|File scanner type|Index query result type|Related types|
|--|--|--|--|
|References|[FileReferenceInfo][Doc:FileReferenceInfo]|[FileReferenceResult][Doc:FileReferenceResult]|[FileReferenceInfoType][Doc:FileReferenceInfoType]|
|Symbols|[SymbolDefinition][Doc:SymbolDefinition]|[SymbolDefinitionSearchResult][Doc:SymbolDefinitionSearchResult]|[ISymbolService][Doc:ISymbolService] should be used instead of `IIndexWorkspaceService` for queries|
|Data values|[FileDataValue][Doc:FileDataValue]|[FileDataResult<T>][Doc:FileDataResult<T>]||

### Querying for indexed data

There are two asynchronous types available to access persisted data. The first is through [IIndexWorkspaceData][Doc:IIndexWorkspaceData]. It provides basic access to a single file's `FileReferenceResult` and `FileDataResult` data, and it caches results. The second is the [IIndexWorkspaceService][Doc:IIndexWorkspaceService] which doesn't use caching, but allows for more querying capabilities.

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

### Participating in indexing

Workspace indexing roughly follows the following sequence:
1) Discovery and persistence of file system entities in the workspace (only on initial opening scan)
1) Per file, the matching provider with the highest priority is asked to scan for `FileReferneceInfo`s.
1) Per file, the matching provider with the highest priority is asked to scan for `SymbolDefinition`s.
1) Per file, all providers are asked for `FileDataValue`s.

Extensions can export a scanner by implementing `IWorkspaceProviderFactory<IFileScanner>` and exporting the type with [ExportFileScannerAttribute][Doc:ExportFileScannerAttribute]. The `SupportedTypes` attribute argument should be one or more values from [FileScannerTypeConstants][Doc:FileScannerTypeConstants]. For an example scanner, see the VS SDK sample [here][Ex:FileScanner].

>![Warning]
>Do not export a file scanner that supports the `FileScannerTypeConstants.FileScannerContentType` type. It is used for Microsoft internal purposes, only.

In advanced situations, an extension might dynamically support an arbitrary set of file types. Rather than MEF exporting `IWorkspaceProviderFactory<IFileScanner>`, an extension can export `IWorkspaceProviderFactory<IFileScannerProvider>`. When indexing begins, this factory type will be imported, instantiated, and have its [IFileScannerProvider.GetSymbolScannersAsync][Doc:IFileScannerProvider.GetSymbolScannersAsync] method invoked. (`IFileScanner` instances supporting any value from `FileScannerTpeConstants` will be honored, not just symbols.)

## Workspace settings

Workspaces have an [IWorkspaceSettingsManager][Doc:IWorkspaceSettingsManager] service with simple but powerful control over a workspace. For a basic overview of settings, see [Customize build and debug tasks][Ref:TasksLaunchSettings].

Settings for most `SettingsType` types are _.json_ files, such as _VSWorkspaceSettings.json_ and _tasks.vs.json_.

The power of workspace settings centers around "scopes," which are simply paths within the workspace. When a consumer calls [IWorkspaceSettingsManager.GetAggregatedSettings][Doc:IWorkspaceSettingsManager.GetAggregatedSettings], all the scopes that include the requested path and type of setting are aggregated. Scope aggregation priority is as follows:

1. "Local settings", which is typically the workspace root's `.vs` directory.
1. The requested path itself.
1. The parent directory of the requested path.
1. All further parent directories up to and including the workspace root.
1. "Global settings", which is in a user directory.

The result is an instance of [IWorkspaceSettings][Doc:IWorkspaceSettings]. This object holds the settings for a particular type, and can be queried for setting key names stored as `string`. The [IWorkspaceSettings.GetProperty][Doc:IWorkspaceSettings.GetProperty] methods and [IWorkspaceSettings][Doc:WorkspaceSettingsExtensions] extension methods expect the caller to know the type of the setting value being requested. As most settings files are persisted as _.json_ files, many invocations will use `string`, `bool`, `int`, and arrays of those types. Object types are also supported. In those cases, you can use `IWorkspaceSettings` itself as the type argument. For example:

```json
{
  "intValue": 1,
  "stringValue": "s",
  "boolValue": true,
  "stringArray": [
    "s1",
    "s2"
  ],
  "nestedIWorkspaceSettings": {
    "nestedString": "ns"
  }
}
```

Assuming these settings were in a user's _VSWorkspaceSettings.json_, the data can be accessed as:

```csharp
using System.Collections.Generic;
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Settings;

private static void ReadSettings(IWorkspace workspace)
{
    IWorkspaceSettingsManager settingsManager = workspace.GetSettingsManager();
    IWorkspaceSettings settings = settingsManager.GetAggregatedSettings(SettingsTypes.Generic);

    // result == WorkspaceSettingsResult.Success
    WorkspaceSettingsResult result = settings.GetProperty("intValue", out int intValue);
    result = settings.GetProperty("stringValue", out string stringValue);
    result = settings.GetProperty("boolValue", out bool boolValue);
    result = settings.GetProperty("stringArray", out string[] stringArray);
    result = settings.GetProperty("nestedIWorkspaceSettings", out IWorkspaceSettings nestedIWorkspaceSettings);
    result = nestedIWorkspaceSettings.GetProperty("nestedString", out string nestedString);

    // Extension method alternative using default values.
    int intValueOrDefault = settings.Property("intValue", /* default */ 42);

    // Missing key. result == WorkspaceSettingsResult.Undefined
    result = settings.GetProperty("missing", out string missing);

    // Wrong type for a key. result == WorkspaceSettingsResult.Error
    result = settings.GetProperty("intValue", out IWorkspaceSettings notSettings);

    // Special ability to union "stringArray" across all scopes.
    IEnumerable<string> allStringArray = settings.UnionPropertyArray<string>("stringArray");
}
```

>![NOTE]
>These settings APIs are unrelated to the APIs available in the `Microsoft.VisualStudio.Settings` namespace. Workspace settings are agnostic of the host and use workspace-specific settings files or dynamic settings providers.

### Providing dynamic settings

Extensions can provide [IWorkspaceSettingsProvider][Doc:IWorkspaceSettingsProvider]s. These in-memory providers allow extensions to add settings or override others.

Exporting an `IWorkspaceSettingsProvider` is different than other workspace providers. The factory is not `IWorkspaceProviderFactory` and there is no special attribute type. Instead, implement [IWorkspaceSettingsProviderFactory][Doc:IWorkspaceSettingsProviderFactory] and use `[Export(typeof(IWorkspaceSettingsProviderFactory))]`.

```csharp
// Common workspace provider factory pattern
[ExportFeatureProvider(some, args, to, export)]
internal class MyProviderFactory : IWorkspaceProviderFactory<IFeatureProvider>
{
     IFeatureProvider CreateProvider(IWorkspace workspace) => new Provider(workspace);
}

// IWorkspaceSettingsProvider pattern
[Export(typeof(IWorkspaceSettingsProviderFactory))]
internal class MySettingsProviderFactory : IWorkspaceSettingsProviderFactory
{
    // 100 is typically the value used by built-in settings providers. Lower value is higher priority.
    int Priority => 100;

    IWorkspaceSettingsProvider CreateSettingsProvider(IWorkspace workspace) => new MySettingsProvider(workspace);
}
```

>![TIP]
>When implementing methods that return `IWorkspaceSettingsSource` (like `IWorkspaceSettingsProvider.GetSingleSettings`), return an instance of `IWorkspaceSettings` rather than `IWorkspaceSettingsSource`. `IWorkspaceSettings` provides more information that can be useful during some settings aggregations.

### Settings related APIs

- [IWorkspaceSettingsManager][Doc:IWorkspaceSettingsManager] reads and aggregates settings for workspace.
- [IWorkspace.GetSettingsManager][Doc:WorkspaceServiceHelper.GetSettingsManager] gets the `IWorkspaceSettingsManager` for a workspace.
- [IWorkspaceSettingsManager.GetAggregatedSettings][Doc:IWorkspaceSettingsManager.GetAggregatedSettings] gets settings for a given scope aggregated across all overlapping scopes.
- [IWorkspaceSettings][Doc:IWorkspaceSettings] contains settings for a particular scope.

## Detailed scenarios

### File watching

A workspace listens to file change notifications and provides the [IFileWatcherService][Doc:IFileWatcherService] via [IWorkspace.GetFileWatcherService][Doc:WorkspaceServiceHelper.GetFileWatcherService]. Files matching the "ExcludedItems" setting will not produce file notification events. A threshold between events is used for notification simplification and duplicate reduction. When you need to react to a file change, you should subscribe to this service.

>![TIP]
>A workspace's indexing service is subscribed to file events. File additions and modifications will cause relevant `IFileScanner`s to be invoked for new data for that file. File deletions will remove indexed data. You don't need to subscribe your `IFileScanner` to the file watcher service.

### Build support

Build support requires an extender to supply indexed and file context data, as well as the build action to run. Things you'll need:

- Build file context
  - Provider factory
    - `ExportFileContextProviderAttribute` attribute with `supportedContextTypeGuids` as all applicable `string` constants from `BuildContextTypes`
    - Implements `IWorkspaceProviderFactory<IFileContextProvider>`
    - File context provider
      - Return a `FileContext` for each build operation and configuration supported
        - `contextType` from [BuildContextTypes][Doc:BuildContextTypes]
        - `context` implements [IBuildConfigurationContext][Doc:IBuildConfigurationContext] with the `Configuration` property as the build configuration (e.g. `"Debug|x86"`, `"ret"`, or `null` if not applicable). Alternatively, use an instance of [BuildConfigurationContext][Doc:BuildConfigurationContext]. The configuration value **must** match the configuration from the indexed file data value.
- Indexed build file data value
  - Provider Factory
    - `ExportFileScannerAttribute` attribute with `IReadOnlyCollection<FileDataValue>` as a supported type
    - Implements `IWorkspaceProviderFactory<IFileScanner>`
  - File scanner on `ScanContentAsync<T>`
    - Returns data when `FileScannerTypeConstants.FileDataValuesType` is the type argument
    - Returns a file data value for each configuration constructed with:
      - `type` as `BuildConfigurationContext.ContextTypeGuid`
      - `context` as your build configuration (e.g. `"Debug|x86"`, `"ret"`, or `null` if not applicable). This value **must** match the configuration from the file context.
- Build file context action
  - Provider factory
    - `ExportFileContextActionProvider` attribute with `supportedContextTypeGuids` as all applicable `string` constants from `BuildContextTypes`
    - Implements `IWorkspaceProviderFactory<IFileContextActionProvider>`
  - Action provider on `IFileContextActionProvider.GetActionsAsync`
    - Return an `IFileContextAction` that matches the given `FileContext.ContextType` value
  - File context action
    - Implements `IFileContextAction` and [IVsCommandItem][Doc:IVsCommandItem]
    - `CommandGroup` property returns `16537f6e-cb14-44da-b087-d1387ce3bf57`
    - `CommandId` is `0x1000` for build, `0x1010` for rebuild, or `0x1020` for clean

>![NOTE]
>Since the `FileDataValue` needs to be indexed, there will be some amount of time between opening the workspace and the point at which the file is scanned for build functionality to light up. The delay will be seen on the first opening of a folder because there is no previously cached index.

#### Reporting messages from a build

The build can surface information, warning, and error messages to users one of two ways. The simple way is to use the [IBuildMessageService][Doc:IBuildMessageService] and provide a [BuildMessage][Doc:BuildMessage], like so:

```csharp
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Build;

private static void OutputBuildMessage(IWorkspace workspace)
{
    IBuildMessageService buildMessageService = workspace.GetBuildMessageService();

    if (buildMessageService != null)
    {
      // Example error build message. See the documentation for BuildMessage for more information.
      var message = new BuildMessage()
      {
          Type = BuildMessage.TaskType.Error,
          Code = "MY1001",
          TaskText = "This is a sample error",
          ProjectFile = "buildfile.bld",
          File = "sourcefile.src"
          LogMessage = $"This is sample text that will only go to the Build output window pane.\n"

          // And any other properties to set
      };

      buildMessageService.ReportBuildMessages(new BuildMessage[] { message });
    }
}
```

`BuildMessage.Type` and `BuildMessage.LogMessage` control the behavior of where information is presented to the user. Any `BuildMessage.TaskType` value other than `None` will produce an **Error List** entry with the given details. `LogMessage` will always be output in the **Build** pane of the **Output** tool window.

Alternatively, extensions can directly interact with the **Error List** or **Build** pane. A bug exists in versions prior to Visual Studio 2017 Version 15.7 where the `pszProjectUniqueName` argument of [IVsOutputWindowPane2.OutputTaskItemStringEx2][Doc:IVsOutputWindowPane2.OutputTaskItemStringEx2] is ignored.

>![WARNING]
>Callers of `IFileContextAction.ExecuteAsync` can provide arbitrary underlying implementations for the `IProgress<IFileContextActionProgressUpdate>` argument. Never invoke `IProgress<IFileContextActionProgressUpdate>.Report(IFileContextActionProgressUpdate)` directly. There are currently no general guidelines for using this argument, but these guidelines are subject to change.

#### Build related APIs

- [IBuildConfigurationContext][Doc:IBuildConfigurationContext] provides build configuration details.
- [IBuildMessageService][Doc:IBuildMessageService] shows [BuildMessage][Doc:BuildMessage]s to users.

### Debug support

Debugging support requires patterns similar to build. Extensions will need to create. If you'd like more information on debugging, leave feedback for this document and it'll be prioritized.

## Tasks.vs.json and Launch.vs.json

>![TIP]
>For more information on authoring a tasks.vs.json or launch.vs.json file, see [Customize build and debug tasks][Ref:TasksLaunchSettings].

### Language service support

A language service might self-activate based on the file extension or content of an opened document, this "loose file" language service is limited to syntax highlighting. Additional info is required to provide a richer experience when editing/reviewing code. Each language service has its own API for initialization with this extra contextual data for a document. This is typically managed by a project system, which is tightly coupled both to the language service and to the build system.

In a workspace, language services are initialized by an [ILanguageServiceProvider][Doc:ILanguageServiceProvider] extension point that specializes only in that language service and knows nothing of the build authoring. In this way, a language service owner can maintain a single Open Folder extension regardless of how many patterns exist within folders and files for running their compiler during a build (e.g. MSBuild, makefiles, etc.). When files from which a file context was created are changed on disk and the file context is refreshed, the language service provider is notified of the updated set of file contexts. The language service provider can then update its model.

When a document is opened in the editor, Visual Studio only considers language service providers that require file context types for which a matching file context provider can be found. It then passes the file context(s) from the matching provider(s) to the selected language service provider via `ILangaugeServiceProvider.InitializeAsync`. What the language service provider does with that file context data is an implementation detail of the language service provider, but the expected user experience is a richer language service for that opened document.

#### Using `ILanguageServiceProvider`

The language service will be notified when a file context is created with a `ContextType` that matches one of the `SupportedContextTypes` values of the language server export attribute.

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

>![WARNING]
>The `ILanguageServiceProvider` methods might be invoked by the workspace on the main thread. Consider scheduling work on a different thread to avoid introducing UI delays.

#### Language server protocol

The `Microsoft.VisualStudio.Workspace.*` APIs aren't the only way to enable your language service in Open Folder. Another option is to use a language server. For more information, read about the [language server protocol][Ref:LanguageServerProtocol].

#### Related interfaces

- [ILanguageServiceProvider][Doc:ILanguageServiceProvider] is invoked when a file of matching file types is opened or closed for editing.

## Suggested practices

- Return objects from `IWorkspaceProviderFactory.CreateProvider` or similar APIs that remember their `Workspace` context when created. Providers interfaces are written expecting this object is kept on creation.
- Save workspace-specific caches or settings within the "Local settings" path of the workspace. Create a path for your file using [IWorkspace.MakeRootedUnderWorkingFolder][Doc:WorkspaceHelper.MakeRootedUnderWorkingFolder] in 15.6 or later. For prior to 15.6, use the following snippet:

```csharp
using System.IO;
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Settings;

private static string MakeRootedUnderWorkingFolder(IWorkspace workspace, string relativePath)
{
    string workingFolder = workspace.GetSettingsManager().GetAggregatedSettings(SettingsTypes.WorkspaceControlSettings).Property<string>("WorkingFolder");
    return Path.Combine(workingFolder, relativePath);
}
```

## Solution events and package auto-load

Loaded packages can implement `IVsSolutionEvents7` and invoke `IVsSolution.AdviseSolutionEvents`. It includes eventing on opening and closing a folder in Visual Studio.

A UI context can be used to auto-load your package. The value is `4646B819-1AE0-4E79-97F4-8A8176FDD664`.

## Troubleshooting

### The 'SourceExplorerPackage' package did not load correctly

Workspace extensibility is heavily MEF-based, and composition errors will cause the package hosting Open Folder to fail loading. For example, if an extension exports a type with `ExportFileContextProviderAttribute`, but the type only implements `IWorkspaceProviderFactory<IFileContextActionProvider>`. The error will occur seen when trying to open a folder in Visual Studio. Error details can be found in _%LOCALAPPDATA%\Microsoft\VisualStudio\15.0_id\ComponentModelCache\Microsoft.VisualStudio.Default.err_ . Resolve any errors for types implemented by your extension.

## Feedback, comments, issues

Open Folder and the `Microsoft.VisualStudio.Workspace.*` APIs are under active development. If you see unexpected behavior, then see the known issues for the release of interest. The Developer Community is the recommended place to vote and create any issues. For each feedback, we highly recommend a detailed description of your issue. Include the Visual Studio version you're developing for, the APIs you're using (both what you've implemented and what you're interacting with), the expected outcome, and the actual outcome. If possible, include a dump of the devenv.exe process. Use GitHub's issue tracking for giving feedback on this and related documentation.

[Doc:BuildConfigurationContext]:/dotnet/api/microsoft.visualstudio.workspace.build.buildconfigurationcontext
[Doc:BuildContextTypes]:/dotnet/api/microsoft.visualstudio.workspace.build.buildcontexttypes
[Doc:BuildMessage]:/dotnet/api/microsoft.visualstudio.workspace.build.buildmessage

[Doc:ExportFileContextProviderAttribute]:/dotnet/api/microsoft.visualstudio.workspace.ExportFileContextProviderAttribute
[Doc:ExportFileContextActionProviderAttribute]:/dotnet/api/microsoft.visualstudio.workspace.exportfilecontextactionproviderattribute
[Doc:ExportFileScannerAttribute]:/dotnet/api/microsoft.visualstudio.workspace.indexing.exportfilescannerattribute

[Doc:FileContext]:/dotnet/api/microsoft.visualstudio.workspace.filecontext
[Doc:FileContext.Context]:/dotnet/api/microsoft.visualstudio.workspace.filecontext.context
[Doc:FileContext.OnFileContextChanged]:/dotnet/api/microsoft.visualstudio.workspace.filecontext.onfilecontextchanged
[Doc:FileDataResult<T>]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filedataresult-1
[Doc:FileDataValue]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filedatavalue
[Doc:FileReferenceInfo]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filereferenceinfo
[Doc:FileReferenceResult]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filereferenceresult
[Doc:FileReferenceInfoType]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filereferenceinfotype
[Doc:FileScannerTypeConstants]:/dotnet/api/microsoft.visualstudio.workspace.indexing.filescannertypeconstants

[Doc:IAsyncDisposable]:/dotnet/api/microsoft.visualstudio.threading.iasyncdisposable
[Doc:IBuildConfigurationContext]:/dotnet/api/microsoft.visualstudio.workspace.build.ibuildconfigurationcontext
[Doc:IBuildIncrementalProgressUpdate]:/dotnet/api/microsoft.visualstudio.workspace.build.ibuildincrementalprogressupdate
[Doc:IBuildMessageService]:/dotnet/api/microsoft.visualstudio.workspace.build.ibuildmessageservice
[Doc:IFileContextAction]:/dotnet/api/microsoft.visualstudio.workspace.ifilecontextaction
[Doc:IFileContextActionBase.ExecuteAsync]:/dotnet/api/microsoft.visualstudio.workspace.ifilecontextactionbase.executeasync
[Doc:IFileContextActionProvider]:/dotnet/api/microsoft.visualstudio.workspace.ifilecontextactionprovider
[Doc:IFileContextProvider]:/dotnet/api/microsoft.visualstudio.workspace.ifilecontextprovider
[Doc:IFileContextProvider<T>]:/dotnet/api/microsoft.visualstudio.workspace.ifilecontextprovider-1
[Doc:IFileScanner]:/dotnet/api/microsoft.visualstudio.workspace.indexing.ifilescanner
[Doc:IFileWatcherService]:/dotnet/api/microsoft.visualstudio.workspace.ifilewatcherservice
[Doc:IIndexWorkspaceData]:/dotnet/api/microsoft.visualstudio.workspace.indexing.iindexworkspacedata
[Doc:IIndexWorkspaceDataService.CreateIndexWorkspaceData]:/dotnet/api/microsoft.visualstudio.workspace.indexing.iindexworkspacedataservice.createindexworkspacedata
[Doc:IIndexWorkspaceService]:/dotnet/api/microsoft.visualstudio.workspace.indexing.iindexworkspaceservice
[Doc:ILanguageServiceProvider]:/dotnet/api/microsoft.visualstudio.workspace.intellisense.ilanguageserviceprovider
[Doc:ISymbolService]:/dotnet/api/microsoft.visualstudio.workspace.indexing.isymbolservice
[Doc:IWorkspace]:/dotnet/api/microsoft.visualstudio.workspace.iworkspace
[Doc:IWorkspace.GetFileContextsAsync]:/dotnet/api/microsoft.visualstudio.workspace.iworkspace.getfilecontextsasync
[Doc:IWorkspaceProviderFactory<T>]:/dotnet/api/microsoft.visualstudio.workspace.iworkspaceproviderfactory-1
[Doc:IWorkspaceServiceFactory<T>]:/dotnet/api/microsoft.visualstudio.workspace.iworkspaceservicefactory-1
[Doc:IWorkspaceSettings]:/dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettings
[Doc:IWorkspaceSettings.GetProperty]:/dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettings.getproperty
[Doc:IWorkspaceSettingsManager]:dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettingsmanager
[Doc:IWorkspaceSettingsManager.GetAggregatedSettings]:/dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettingsmanager.getaggregatedsettings
[Doc:IWorkspaceSettingsProvider]:/dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettingsprovider
[Doc:IWorkspaceSettingsProviderFactory]:/dotnet/api/microsoft.visualstudio.workspace.settings.iworkspacesettingsproviderfactory
[Doc:IVsCommandItem]:/dotnet/api/microsoft.visualstudio.workspace.extensions.vs.ivscommanditem
[Doc:IVsOutputWindowPane2.OutputTaskItemStringEx2]:/dotnet/api/microsoft.visualstudio.shell.interop.ivsoutputwindowpane2.outputtaskitemstringex2

[Doc:SymbolDefinition]:/dotnet/api/microsoft.visualstudio.workspace.indexing.symboldefinition
[Doc:SymbolDefinitionSearchResult]:/dotnet/api/microsoft.visualstudio.workspace.indexing.symboldefinitionsearchresult

[Doc:WorkspaceHelper.GetWorkspaceWorkingFolder]:/dotnet/api/microsoft.visualstudio.workspace.workspacehelper.getworkspaceworkingfolder
[Doc:WorkspaceHelper.MakeRootedUnderWorkingFolder]:/dotnet/api/microsoft.visualstudio.workspace.workspaceservicehelper.makerootedunderworkingfolder
[Doc:WorkspaceServiceHelper]:/dotnet/api/microsoft.visualstudio.workspace.workspaceservicehelper
[Doc:WorkspaceServiceHelper.GetFileWatcherService]:/dotnet/api/microsoft.visualstudio.workspace.workspaceservicehelper.getfilewatcherservice
[Doc:WorkspaceServiceHelper.GetServiceAsync]:/dotnet/api/microsoft.visualstudio.workspace.workspaceservicehelper.getserviceasync
[Doc:WorkspaceServiceHelper.GetSettingsManager]:/dotnet/api/microsoft.visualstudio.workspace.workspaceservicehelper.getsettingsmanager
[Doc:WorkspaceSettingsExtensions]:/dotnet/api/microsoft.visualstudio.workspace.settings.workspacesettingsextensions

[Ex:FileScanner]:https://github.com/Microsoft/VSSDK-Extensibility-Samples/blob/master/Open_Folder_Extensibility/C%23/SymbolScannerSample/TxtFileSymbolScanner.cs

[Ref:LanguageServerProtocol]:/docs/extensibility/language-server-protocol
[Ref:TasksLaunchSettings]:/ide/customize-build-and-debug-tasks-in-visual-studio
