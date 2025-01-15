---
title: "Workspaces in Visual Studio"
description: Explore how Visual Studio uses a workspace to represent a collection of files in Open Folder, including workspace providers and services.
ms.date: "02/21/2018"
ms.topic: "conceptual"
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
---
# Workspaces

A workspace is how Visual Studio represents any collection of files in [Open Folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md), and it's represented by the <xref:Microsoft.VisualStudio.Workspace.IWorkspace> type. By itself, the workspace doesn't understand the contents or features related to files within the folder. Rather, it provides a general set of APIs for features and extensions to produce and consume data that others can act upon. The producers are composed through the [Managed Extensibility Framework](https://github.com/Microsoft/vs-mef/blob/main/doc/index.md) (MEF) using various export attributes.

## Workspace providers and services

Workspace providers and services provide the data and functionality to react to the contents of a workspace. They might provide contextual file information, symbols in source files, or build functionality.

Both concepts use a [factory pattern](https://en.wikipedia.org/wiki/Factory_method_pattern) and are imported through MEF by the workspace. All export attributes implement `IProviderMetadataBase` or `IWorkspaceServiceFactoryMetadata`, but there are concrete types that extensions should use for exported types.

One difference between providers and services is their relation to the workspace. A workspace can have many providers of a particular type, but only one service of a particular type is created per workspace. For example, a workspace has many file scanner providers but the workspace has only one indexing service per workspace.

Another key difference is consumption of data from providers and services. The workspace is the entry point to get data from providers for a couple reasons. First, providers typically have some narrow set of data they create. The data might be symbols for a C# source file or build file contexts for a `CMakeLists.txt` file. The workspace will match a consumer's request to the providers whose metadata align with the request. Second, some scenarios allow for many providers to contribute to a request while others scenarios use the provider with highest priority.

In contrast, extensions can get instances of and interact directly with workspace services. Extension methods on `IWorkspace` are available for the services provided by Visual Studio, such as <xref:Microsoft.VisualStudio.Workspace.WorkspaceServiceHelper.GetFileWatcherService%2A>. Your extension may offer a workspace service for components within your extension or for other extensions to consume. Consumers should use <xref:Microsoft.VisualStudio.Workspace.WorkspaceServiceHelper.GetServiceAsync%2A> or an extension method you provide on the `IWorkspace` type.

>[!WARNING]
> Do not author services that conflict with Visual Studio. It can lead to unexpected issues.

## Disposal on workspace closure

On closure of a workspace, extenders might need to dispose but call asynchronous code. The <xref:Microsoft.VisualStudio.Threading.IAsyncDisposable> interface is available to make writing this code easy.

## Related types

- <xref:Microsoft.VisualStudio.Workspace.IWorkspace> is the central entity for an opened workspace like an opened folder.
- <xref:Microsoft.VisualStudio.Workspace.IWorkspaceProviderFactory`1> creates a provider per workspace instantiated.
- <xref:Microsoft.VisualStudio.Workspace.IWorkspaceServiceFactory> creates a service per workspace instantiated.
- <xref:Microsoft.VisualStudio.Threading.IAsyncDisposable> should be implemented on providers and services that need to run asynchronous code during disposal.
- <xref:Microsoft.VisualStudio.Workspace.WorkspaceServiceHelper> provides helper methods for accessing well-known services or arbitrary services.

## Workspace settings

Workspaces have an <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsManager> service with simple but powerful control over a workspace. For a basic overview of settings, see [Customize build and debug tasks](../ide/customize-build-and-debug-tasks-in-visual-studio.md).

Settings for most `SettingsType` types are `.json` files, such as `VSWorkspaceSettings.json` and *tasks.vs.json*.

The power of workspace settings centers around "scopes", which are simply paths within the workspace. When a consumer calls <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsManager.GetAggregatedSettings%2A>, all the scopes that include the requested path and type of setting are aggregated. Scope aggregation priority is as follows:

1. "Local settings", which is typically the workspace root's `.vs` directory.
1. The requested path itself.
1. The parent directory of the requested path.
1. All further parent directories up to and including the workspace root.
1. "Global settings", which is in a user directory.

The result is an instance of <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettings>. This object holds the settings for a particular type, and can be queried for setting key names stored as `string`. The <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettings.GetProperty%2A> methods and <xref:Microsoft.VisualStudio.Workspace.Settings.WorkspaceSettingsExtensions> extension methods expect the caller to know the type of the setting value being requested. As most settings files are persisted as `.json` files, many invocations will use `string`, `bool`, `int`, and arrays of those types. Object types are also supported. In those cases, you can use `IWorkspaceSettings` itself as the type argument. For example:

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

Assuming these settings were in a user's *VSWorkspaceSettings.json*, the data can be accessed as:

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

>[!NOTE]
>These settings APIs are unrelated to the APIs available in the `Microsoft.VisualStudio.Settings` namespace. Workspace settings are agnostic of the host and use workspace-specific settings files or dynamic settings providers.

### Providing dynamic settings

Extensions can provide <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsProvider>s. These in-memory providers allow extensions to add settings or override others.

Exporting an `IWorkspaceSettingsProvider` is different than other workspace providers. The factory is not `IWorkspaceProviderFactory` and there is no special attribute type. Instead, implement <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsProviderFactory> and use `[Export(typeof(IWorkspaceSettingsProviderFactory))]`.

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

>[!TIP]
>When implementing methods that return `IWorkspaceSettingsSource` (like `IWorkspaceSettingsProvider.GetSingleSettings`), return an instance of `IWorkspaceSettings` rather than `IWorkspaceSettingsSource`. `IWorkspaceSettings` provides more information that can be useful during some settings aggregations.

### Settings related APIs

- <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsManager> reads and aggregates settings for workspace.
- <xref:Microsoft.VisualStudio.Workspace.WorkspaceServiceHelper.GetSettingsManager%2A> gets the `IWorkspaceSettingsManager` for a workspace.
- <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettingsManager.GetAggregatedSettings%2A> gets settings for a given scope aggregated across all overlapping scopes.
- <xref:Microsoft.VisualStudio.Workspace.Settings.IWorkspaceSettings> contains settings for a particular scope.

## Workspace suggested practices

- Return objects from `IWorkspaceProviderFactory.CreateProvider` or similar APIs that remember their `Workspace` context when created. Providers interfaces are written expecting this object is kept on creation.
- Save workspace-specific caches or settings within the "Local settings" path of the workspace. Create a path for your file using `Microsoft.VisualStudio.Workspace.WorkspaceHelper.MakeRootedUnderWorkingFolder` in Visual Studio 2017 version 15.6 or later. For versions prior to version 15.6, use the following snippet:

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

### The SourceExplorerPackage package did not load correctly

Workspace extensibility is heavily MEF-based, and composition errors will cause the package hosting Open Folder to fail to load. For example, if an extension exports a type with `ExportFileContextProviderAttribute`, but the type only implements `IWorkspaceProviderFactory<IFileContextActionProvider>`, an error will occur when trying to open a folder in Visual Studio.

Error details can be found in _%LOCALAPPDATA%\Microsoft\VisualStudio\16.0_id\ComponentModelCache\Microsoft.VisualStudio.Default.err_. Resolve any errors for types implemented by your extension.

## Related content

* [File contexts](workspace-file-contexts.md) - File context providers bring code intelligence for Open Folder workspaces.
* [Indexing](workspace-indexing.md) - Workspace indexing collects and persists information about the workspace.
