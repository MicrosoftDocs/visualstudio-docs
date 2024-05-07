---
title: File and Directory Picker Prompts Overview
description: An overview of extensibility file picker prompts
ms.topic: overview
ms.date: 5/10/2024
ms.author: kellyfam
monikerRange: ">=vs-2022"
author: kellyfam
manager: jekelly
ms.subservice: extensibility-integration
---

# Create file or directory picker prompts

File or directory prompts are a simple UI mechanism for prompting the user to select a file or directory path. Prompting the user creates the file dialog from the native OS with custom dialog options to fit the user's specific scenario.

## Get started

To get started, follow the [create the project](./../get-started/create-your-first-extension.md) section in the Getting Started section.

## Work with file or directory picker prompts

This guide covers the following scenarios for working with the file or directory pick prompts:

- [Display a file picker prompt](#display-a-file-picker-prompt)
- [Display a directory picker prompt](#display-a-directory-picker-prompt)
- [Use built-in options](#use-built-in-options)
- [Create a file and directory prompt with custom options](#create-a-file-and-directory-picker-prompt-with-custom-options)

These prompts return `null` if the user closes or cancels the dialog.

## Display a file picker prompt
Creating a file picker prompt with the new Extensibility Model is as simple as calling the following available methods:
- [`ShowOpenFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFileDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) helpers and passing in your options
- [`ShowOpenMultipleFilesDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenMultipleFilesDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) helpers and passing in your options
- [`ShowSaveAsFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowSaveAsFileDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) helpers and passing in your options

### `ShellExtensibility.ShowOpenFileDialogAsync()`

The [`ShowOpenFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFileDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FileDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

#### Example
The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    FileDialogOptions options = new();
    string? filePath = await this.Extensibility.Shell().ShowOpenFileDialogAsync(options, ct);
}
```

### `ShellExtensibility.ShowOpenMultipleFilesDialogAsync()`
This file prompt allows for multi-selection.

#### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options. 

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    FileDialogOptions options = new();
    IReadOnlyList<string>? filePath = await this.Extensibility.Shell().ShowOpenMultipleFilesDialogAsync(options, ct);
}
```

### `ShellExtensibility.ShowSaveAsFileDialogAsync()`

This file prompt allows for custom file name input from the user.

The [`ShowSaveAsFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowSaveAsFileDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FileDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

#### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    FileDialogOptions options = new();
    string? filePath = await this.Extensibility.Shell().ShowSaveAsFileDialogAsync(options, ct);
}
```

## Display a directory picker prompt
Creating a directory picker prompt with the new Extensibility Model is as simple as calling the following available method:
- [`ShowOpenFolderDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFolderDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) helpers and passing in your options

### `ShellExtensibility.ShowOpenFolderDialogAsync()`

The [`ShowOpenFolderDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFolderDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FolderDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

#### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    FolderDialogOptions options = new();
    string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, ct);
}
```

## Use built-in options

### `FileDialogOptions`
| **Property** | **Type** | **Required** |**Description** | **Sample** |
| :- | :- | :- | :- | :- |
| title  | `string` | No | The title of the dialog. If the title is an empty string, the system uses a default title, which is either "Save As" or "Open". Default is `string.Empty` | "Open a file" |
| initialFileName | `string` | No | The file name in the input box of the dialog. For the open file dialog, the filename must exist or the dialog will return an error. If an invalid filename is passed, we use the default. Default is `string.Empty`. | "filename.ext" |
| filters | `DialogFilters` | No |  The filters used for the dialog. | See [Display a file and directory prompt with custom options](#create-a-prompt-with-custom-options) |

### `DialogFilters`
| **Term**  | **Type** | **Required** | **Description** | **Example** |
| :- | :- | :- | :- | :- |
| Filters | `IReadOnlyCollection<DialogFilter>` | Yes | The filters for selecting or saving a file. | See [Display a file and directory prompt with custom options](#create-a-prompt-with-custom-options) |
| DefaultFilterIndex | `int` | No | Used to set the default filter index of the filter that is selected by default. Default is `0`. | Minimum index is `0`, maximum is the `number of filters - 1` 

### `FolderDialogOptions`
| **Property** | **Type** | **Required** |**Description** | **Sample** |
| :- | :- | :- | :- | :- |
| title  | `string` | No | The title of the dialog. If the title is an empty string, the system uses a default title, which is either "Save As" or "Open". Default is `string.Empty`. | "Open a file" |
| initialDirectory  | `string` | No | The directory the dialog should have open. This should be an absolute path. If the initialDirectory is an empty string, the initial directory will default to the last opened directory, but if this is the first time, it is the root folder. If an initialDirectory is specified, we pass in a flag to the dialog to open to the specified directory instead of the last opened directory. If an invalid directory is passed, we use the default. Default is `string.Empty`.| "path/to/folder" |

## Create a file and directory picker prompt with custom options

### File picker prompt
You can specify the following to customize your file picker prompt.
#### Example
```csharp
DialogFilter[] filters = new DialogFilter[]
{
    new DialogFilter("Word Files", ".doc", ".docx"),
    new DialogFilter("Excel Files", ".xls", ".xlsx"),
    new DialogFilter("All Files", ".*"),
};

FileDialogOptions options = new FileDialogOptions()
{
    Title = "Choose a File To Open".
    InitialDirectory = "absolute/path/to/file",
    InitialFileName = "file.txt",
    Filters = new DialogFilters(filters)
    {
        DefaultFilterIndex = 1,
    },
};

string? filePath = await Extensibilty.Shell().ShowOpenFileDialogAsync(options, ct);
```

### Directory picker prompt
You can specify the following to customize your directory picker prompt.
#### Example
```csharp
FolderDialogOptions options = new FolderDialogOptions()
{
    Title = "Choose a Folder",
    InitialDirectory = "absolute/path/to/folder"
};

string? folderPath = await Extensibilty.Shell().ShowOpenFolderDialogAsync(options, ct);
```

## Next steps
Next, see the [FilePickerSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/FilePickerSample/).