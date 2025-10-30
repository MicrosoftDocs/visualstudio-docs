---
title: "Workspace build in Visual Studio"
description: Learn about the extender that supplies indexed and file context data for a workspace to support an Open Folder scenario.
ms.date: "02/21/2018"
ms.topic: article
author: "vukelich"
ms.author: "svukel"
manager: "viveis"
---
# Workspace build

Build support in [Open Folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) scenarios requires an extender to supply [indexed](workspace-indexing.md) and [file context](workspace-file-contexts.md) data for the [workspace](workspaces.md), as well as the build action to run.

Below is an outline of what your extension will need.

## Build file context

- Provider factory
  - `ExportFileContextProviderAttribute` attribute with `supportedContextTypeGuids` as all applicable `string` constants from `BuildContextTypes`
  - Implements `IWorkspaceProviderFactory<IFileContextProvider>`
  - File context provider
    - Return a `FileContext` for each build operation and configuration supported
      - `contextType` from <xref:Microsoft.VisualStudio.Workspace.Build.BuildContextTypes>
      - `context` implements <xref:Microsoft.VisualStudio.Workspace.Build.IBuildConfigurationContext> with the `Configuration` property as the build configuration (for example `"Debug|x86"`, `"ret"`, or `null` if not applicable). Alternatively, use an instance of <xref:Microsoft.VisualStudio.Workspace.Build.BuildConfigurationContext>. The configuration value **must** match the configuration from the indexed file data value.

## Indexed build file data value

- Provider Factory
  - `ExportFileScannerAttribute` attribute with `IReadOnlyCollection<FileDataValue>` as a supported type
  - Implements `IWorkspaceProviderFactory<IFileScanner>`
- File scanner on `ScanContentAsync<T>`
  - Returns data when `FileScannerTypeConstants.FileDataValuesType` is the type argument
  - Returns a file data value for each configuration constructed with:
    - `type` as `BuildConfigurationContext.ContextTypeGuid`
    - `context` as your build configuration (for example `"Debug|x86"`, `"ret"`, or `null` if not applicable). This value **must** match the configuration from the file context.

## Build file context action

- Provider factory
  - `ExportFileContextActionProvider` attribute with `supportedContextTypeGuids` as all applicable `string` constants from `BuildContextTypes`
  - Implements `IWorkspaceProviderFactory<IFileContextActionProvider>`
- Action provider on `IFileContextActionProvider.GetActionsAsync`
  - Return an `IFileContextAction` that matches the given `FileContext.ContextType` value
- File context action
  - Implements `IFileContextAction` and <xref:Microsoft.VisualStudio.Workspace.Extensions.VS.IVsCommandItem>
  - `CommandGroup` property returns `16537f6e-cb14-44da-b087-d1387ce3bf57`
  - `CommandId` is `0x1000` for build, `0x1010` for rebuild, or `0x1020` for clean

>[!NOTE]
>Since the `FileDataValue` needs to be indexed, there will be some amount of time between opening the workspace and the point at which the file is scanned for full build functionality. The delay will be seen on the first opening of a folder because there is no previously cached index.

## Reporting messages from a build

The build can surface information, warning, and error messages to users one of two ways. The simple way is to use the <xref:Microsoft.VisualStudio.Workspace.Build.IBuildMessageService> and provide a <xref:Microsoft.VisualStudio.Workspace.Build.BuildMessage>, like so:

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

Alternatively, extensions can directly interact with the **Error List** or **Build** pane. A bug exists in versions prior to Visual Studio 2017 Version 15.7 where the `pszProjectUniqueName` argument of <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane2.OutputTaskItemStringEx2*> is ignored.

>[!WARNING]
>Callers of `IFileContextAction.ExecuteAsync` can provide arbitrary underlying implementations for the `IProgress<IFileContextActionProgressUpdate>` argument. Never invoke `IProgress<IFileContextActionProgressUpdate>.Report(IFileContextActionProgressUpdate)` directly. There are currently no general guidelines for using this argument, but these guidelines are subject to change.

## Build related APIs

- <xref:Microsoft.VisualStudio.Workspace.Build.IBuildConfigurationContext> provides build configuration details.
- <xref:Microsoft.VisualStudio.Workspace.Build.IBuildMessageService> shows <xref:Microsoft.VisualStudio.Workspace.Build.BuildMessage>s to users.

## tasks.vs.json and launch.vs.json

For information on authoring a tasks.vs.json or launch.vs.json file, see [Customize build and debug tasks](../ide/customize-build-and-debug-tasks-in-visual-studio.md).

## Related content

* [Language Server Protocol](language-server-protocol.md) - Learn how to integrate language servers into Visual Studio.
