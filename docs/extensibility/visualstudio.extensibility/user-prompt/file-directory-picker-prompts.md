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

## Work with file or directory picker prompts

This guide covers the following scenarios for working with the file or directory pick prompts:

- [Prompt the user to select a single file to open](#prompt-the-user-to-select-a-single-file-to-open)
- [Prompt the user to select one or more files to open](#prompt-the-user-to-select-one-or-more-files-to-open)
- [Prompt the user to select a file to Save As](#prompt-the-user-to-select-a-file-to-save-as)
- [Prompt the user to select a directory to open](#prompt-the-user-to-select-a-directory-to-open)
- [Use options to customize file or directory prompts](#use-options-to-customize-file-or-directory-prompts)

## Prompt the user to select a single file to open

To create a file open prompt, call the [`ShowOpenFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFileDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) object.

### `ShellExtensibility.ShowOpenFileDialogAsync()`

The [`ShowOpenFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFileDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FileDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

`ShowOpenFileDialogAsync` returns `null` if the user closes or cancels the dialog.

### Example
The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    FileDialogOptions options = new();
    string? filePath = await this.Extensibility.Shell().ShowOpenFileDialogAsync(options, cancellationToken);
}
```

## Prompt the user to select one or more files to open

In some cases, it's useful to enable users to select more than one file at a time, which can be done with the [`ShowOpenMultipleFilesDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenMultipleFilesDialogAsync) method.

### `ShellExtensibility.ShowOpenMultipleFilesDialogAsync()`

The [`ShowOpenMultipleFilesDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFileDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FileDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

`ShowOpenMultipleFilesDialogAsync` returns `null` if the user closes or cancels the dialog.

### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options. 

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    FileDialogOptions options = new();
    IReadOnlyList<string>? filePath = await this.Extensibility.Shell().ShowOpenMultipleFilesDialogAsync(options, cancellationToken);
}
```

## Prompt the user to select a file to Save As

Prompting the user for a file name to Save As allows them to specify a custom file name.

### `ShellExtensibility.ShowSaveAsFileDialogAsync()`

The [`ShowSaveAsFileDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowSaveAsFileDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FileDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

`ShowSaveAsFileDialogAsync` returns `null` if the user closes or cancels the dialog.

### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    FileDialogOptions options = new();
    string? filePath = await this.Extensibility.Shell().ShowSaveAsFileDialogAsync(options, cancellationToken);
}
```

## Prompt the user to select a directory to open

To create a file open prompt, call the [`ShowOpenFolderDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFolderDialogAsync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) object.

### `ShellExtensibility.ShowOpenFolderDialogAsync()`

The [`ShowOpenFolderDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.ShowOpenFolderDialogAsync) method takes two parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| options   | `FolderDialogOptions` | Yes | Defines the file picker prompt options to customize the dialog. |
| cancellationToken | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force-closed. |

`ShowOpenFolderDialogAsync` returns `null` if the user closes or cancels the dialog.

### Example

The following code inside a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) shows a file prompt with default dialog options.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    FolderDialogOptions options = new();
    string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, cancellationToken);
}
```

## Use options to customize file or directory prompts

The `FileDialogOptions`, `DialogFilters`, and `FolderDialogOptions` types can be used to customize your prompts:

### `FileDialogOptions`
| **Property** | **Type** | **Required** |**Description** | **Sample** |
| :- | :- | :- | :- | :- |
| title  | `string` | No | The title of the dialog. If the title is an empty string, the system uses a default title, which is either "Save As" or "Open". Default is `string.Empty` | "Open a file" |
| initialFileName | `string` | No | The file name in the input box of the dialog. For the open file dialog, the filename must exist or the dialog returns an error. If an invalid filename is passed, we use the default. Default is `string.Empty`. | "filename.ext" |
| filters | `DialogFilters` | No |  The filters used for the dialog. | See [Examples of prompts with custom options](#examples-of-prompts-with-custom-options) |

### `DialogFilters`
| **Term**  | **Type** | **Required** | **Description** | **Example** |
| :- | :- | :- | :- | :- |
| Filters | `IReadOnlyCollection<DialogFilter>` | Yes | The filters for selecting or saving a file. | See [Examples of prompts with custom options](#examples-of-prompts-with-custom-options) |
| DefaultFilterIndex | `int` | No | Used to set the default filter index of the filter that is selected by default. Default is `0`. | The minimum index is `0` and the maximum is the `number of filters - 1`. 

### `FolderDialogOptions`
| **Property** | **Type** | **Required** |**Description** | **Sample** |
| :- | :- | :- | :- | :- |
| title  | `string` | No | The title of the dialog. If the title is an empty string, the system uses a default title, which is either "Save As" or "Open". Default is `string.Empty`. | "Open a file" |
| initialDirectory  | `string` | No | The directory the dialog should have open, which should be an absolute path. If the initialDirectory is an empty string, the initial directory defaults to the last opened directory. If there is no previously opened directory, the initial directory will default to the root folder. If an initialDirectory is specified, we pass in a flag to the dialog to open to the specified directory instead of the last opened directory. If an invalid directory is passed, we use the default. Default is `string.Empty`.| "path/to/folder" |

### Examples of prompts with custom options

#### File picker prompt

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

string? filePath = await Extensibilty.Shell().ShowOpenFileDialogAsync(options, cancellationToken);
```

#### Directory picker prompt

```csharp
FolderDialogOptions options = new FolderDialogOptions()
{
    Title = "Choose a Folder",
    InitialDirectory = "absolute/path/to/folder"
};

string? folderPath = await Extensibilty.Shell().ShowOpenFolderDialogAsync(options, cancellationToken);
```

## Next steps

Next, see the [FilePickerSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/FilePickerSample/).